using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using net.hakuryuu.WargameOverlay.Models;
using Squalr.Engine.Utils.Extensions;

namespace net.hakuryuu.WargameOverlay.Services
{
    public class DataReader : IDataReader
    {
        private const string WARGAME_PROCESS = "WarGame3";

        //private const string HEADER_START = "7B 22 67 61 6D 65 22 3A 7B 22 56 65 72 73 69 6F 6E 22 3A 22 ?? ?? ?? ?? ?? ?? 22 2C 22 4D 61 70 22 3A 22 ?? ?? ?? ?? ??";
        private const string HEADER_START = "7B 22 67 61 6D 65 22 3A 7B 22";
        private const string HEADER_END = "22 3A 22 37 22 7D 7D"; //"22 2C 22 50 6C 61 79 65 72 49 6E 63 6F 6D 65 52 61 74 65 22 3A 22 37 22 7D 7D ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ??";
        private const bool RAM_EXECUTABLE = false;
        private const bool RAM_WRTIEABLE = true;
        private const int ROW = 32;

        private Mem _memdll;

        public DataReader()
        {
            _memdll = new();
        }

        public async Task GetFullGameData()
        {

        }

        public async Task<string> GetRawData()
        {
            var aobRes = await PerformAoB();
            var addr = await GetAddresses(aobRes.firstAddressOptions, aobRes.lastAddress);
            if (addr == null)
            {
                return "404";
            }
            return await GetJsonFromMemory(addr);
        }


        //public async Task<Players> GetPlayers()
        //{

        //}

        private async Task<bool> AccessProcess()
        {
            switch (_memdll.OpenProcess(WARGAME_PROCESS))
            {
                case true:
                    return true;
                case false:
                    throw new Exception("Wargame must be started first.");
            }
            return false;
        }

        private async Task<(List<long> firstAddressOptions, long lastAddress)> PerformAoB()
        {       
            switch (await AccessProcess())
            {
                case true:

                    /*Task<IEnumerable<long>>*/ var start = _memdll.AoBScan(HEADER_START, RAM_WRTIEABLE, RAM_EXECUTABLE).Result.ToList();
                    /*Task<IEnumerable<long>>*/ var end = _memdll.AoBScan(HEADER_END, RAM_WRTIEABLE, RAM_EXECUTABLE).Result.ToList();

                    // await Task.WhenAll(start, end);

                    // Remove all possible last Addresses which are before the first start address
                    // The game saves partial headers in the memory, those are to be avoided
                    end.RemoveAll(x => x < start.FirstOrDefault());
                    return (start, end.FirstOrDefault());
            }

            return (null,0); // Default return
        }

        private async Task<List<IntPtr>> GetAddresses(List<long> firstAddressOptions, long lastAddress)
        {
            List<IntPtr> addressList = new();

            void ExtractAddresses(ref long addresses){
                for (long i = 0; i < addresses; i += ROW)
                {
                    IntPtr currentAddress = IntPtr.Add(firstAddressOptions.FirstOrDefault().ToIntPtr(), (int)i);
                    addressList.Add(currentAddress);
                }
            }

            switch (lastAddress)
            {
                case > 0:
                    switch (firstAddressOptions.Count)
                    {
                        case > 1:
                            var closestAddr = firstAddressOptions.OrderBy(x => Math.Abs(x - lastAddress)).First();
                            var addresse = lastAddress - closestAddr;
                            ExtractAddresses(ref addresse);
                            return addressList;
                        case 1:
                            var addresses = lastAddress - firstAddressOptions.First();
                            ExtractAddresses(ref addresses);
                          return addressList;
                        default:
                            throw new Exception("Could not find firstAddress, are you sure Wargame is still running?");
                    }
                    break;
                default:
                    return null;
            }
            return null;
        }

        private async Task<string> GetJsonFromMemory(List<IntPtr> addresses)
        {
            List<string> content = new();

            foreach (var addr in addresses)
            {
                content.Add(_memdll.ReadString(addr.ToString("X")));
            }

            return String.Join(String.Empty, content);
        }

    }
}
