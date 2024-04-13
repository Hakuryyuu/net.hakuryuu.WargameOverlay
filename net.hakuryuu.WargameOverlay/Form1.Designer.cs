namespace net.hakuryuu.WargameOverlay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxResult = new TextBox();
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // tbxResult
            // 
            tbxResult.Location = new Point(873, 84);
            tbxResult.Name = "tbxResult";
            tbxResult.Size = new Size(100, 23);
            tbxResult.TabIndex = 1;
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(20, 128);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(1451, 859);
            rtbResult.TabIndex = 2;
            rtbResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1491, 1002);
            Controls.Add(rtbResult);
            Controls.Add(tbxResult);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Wargame";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxResult;
        private RichTextBox rtbResult;
    }
}
