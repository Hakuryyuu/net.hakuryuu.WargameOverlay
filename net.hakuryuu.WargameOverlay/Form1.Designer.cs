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
            components = new System.ComponentModel.Container();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            timer1 = new System.Windows.Forms.Timer(components);
            tbxRefreshRate = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(538, 26);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(122, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "REFRESH NOW";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // tbxRefreshRate
            // 
            tbxRefreshRate.AnimateReadOnly = false;
            tbxRefreshRate.BackgroundImageLayout = ImageLayout.None;
            tbxRefreshRate.CharacterCasing = CharacterCasing.Normal;
            tbxRefreshRate.Depth = 0;
            tbxRefreshRate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxRefreshRate.HideSelection = true;
            tbxRefreshRate.LeadingIcon = null;
            tbxRefreshRate.Location = new Point(397, 166);
            tbxRefreshRate.MaxLength = 32767;
            tbxRefreshRate.MouseState = MaterialSkin.MouseState.OUT;
            tbxRefreshRate.Name = "tbxRefreshRate";
            tbxRefreshRate.PasswordChar = '\0';
            tbxRefreshRate.PrefixSuffixText = null;
            tbxRefreshRate.ReadOnly = false;
            tbxRefreshRate.RightToLeft = RightToLeft.No;
            tbxRefreshRate.SelectedText = "";
            tbxRefreshRate.SelectionLength = 0;
            tbxRefreshRate.SelectionStart = 0;
            tbxRefreshRate.ShortcutsEnabled = true;
            tbxRefreshRate.Size = new Size(250, 48);
            tbxRefreshRate.TabIndex = 4;
            tbxRefreshRate.TabStop = false;
            tbxRefreshRate.TextAlign = HorizontalAlignment.Left;
            tbxRefreshRate.TrailingIcon = null;
            tbxRefreshRate.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(397, 144);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(128, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Auto Refresh Rate";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(583, 447);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(6, 474);
            label1.Name = "label1";
            label1.Size = new Size(160, 11);
            label1.TabIndex = 7;
            label1.Text = "Created by Hakuryuu (info@hakuryuu.net)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(362, 474);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 8;
            label2.Text = "PROTOTYPE VERSION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(667, 492);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(materialLabel1);
            Controls.Add(tbxRefreshRate);
            Controls.Add(materialButton1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Sizable = false;
            Text = "Settings";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialTextBox2 tbxRefreshRate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private Label label1;
        private Label label2;
    }
}
