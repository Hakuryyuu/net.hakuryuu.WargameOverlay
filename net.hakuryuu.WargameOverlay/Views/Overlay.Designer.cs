namespace net.hakuryuu.WargameOverlay.Views
{
    partial class Overlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPlayer1 = new Label();
            lblPlayer2 = new Label();
            lblReportsPlayer1 = new Label();
            lblReportsPlayer2 = new Label();
            SuspendLayout();
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer1.ForeColor = Color.White;
            lblPlayer1.Location = new Point(470, 17);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.RightToLeft = RightToLeft.Yes;
            lblPlayer1.Size = new Size(143, 37);
            lblPlayer1.TabIndex = 0;
            lblPlayer1.Text = "Player1";
            lblPlayer1.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer2.ForeColor = Color.White;
            lblPlayer2.Location = new Point(470, 93);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.RightToLeft = RightToLeft.Yes;
            lblPlayer2.Size = new Size(143, 37);
            lblPlayer2.TabIndex = 1;
            lblPlayer2.Text = "Player2";
            lblPlayer2.TextAlign = ContentAlignment.TopRight;
            // 
            // lblReportsPlayer1
            // 
            lblReportsPlayer1.AutoSize = true;
            lblReportsPlayer1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblReportsPlayer1.ForeColor = Color.RosyBrown;
            lblReportsPlayer1.Location = new Point(341, 54);
            lblReportsPlayer1.Name = "lblReportsPlayer1";
            lblReportsPlayer1.RightToLeft = RightToLeft.Yes;
            lblReportsPlayer1.Size = new Size(272, 28);
            lblReportsPlayer1.TabIndex = 2;
            lblReportsPlayer1.Text = "hr:0 tr:0 ohc:0 mh:0";
            lblReportsPlayer1.TextAlign = ContentAlignment.TopRight;
            // 
            // lblReportsPlayer2
            // 
            lblReportsPlayer2.AutoSize = true;
            lblReportsPlayer2.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblReportsPlayer2.ForeColor = Color.RosyBrown;
            lblReportsPlayer2.Location = new Point(341, 130);
            lblReportsPlayer2.Name = "lblReportsPlayer2";
            lblReportsPlayer2.RightToLeft = RightToLeft.Yes;
            lblReportsPlayer2.Size = new Size(272, 28);
            lblReportsPlayer2.TabIndex = 3;
            lblReportsPlayer2.Text = "hr:0 tr:0 ohc:0 mh:0";
            lblReportsPlayer2.TextAlign = ContentAlignment.TopRight;
            // 
            // Overlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 178);
            Controls.Add(lblReportsPlayer2);
            Controls.Add(lblReportsPlayer1);
            Controls.Add(lblPlayer2);
            Controls.Add(lblPlayer1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Overlay";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Overlay";
            Load += Overlay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayer1;
        private Label lblPlayer2;
        private Label lblReportsPlayer1;
        private Label lblReportsPlayer2;
    }
}