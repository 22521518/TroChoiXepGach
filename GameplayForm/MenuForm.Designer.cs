namespace WindowForm
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.SettingIcon = new System.Windows.Forms.PictureBox();
            this.LeaderBoardIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SettingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderBoardIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Location = new System.Drawing.Point(0, 234);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(846, 225);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "TETRISS";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartLabel
            // 
            this.StartLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StartLabel.Location = new System.Drawing.Point(0, 603);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(855, 99);
            this.StartLabel.TabIndex = 1;
            this.StartLabel.Text = "START GAME";
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartLabel.Click += new System.EventHandler(this.StartLabel_Click);
            // 
            // SettingIcon
            // 
            this.SettingIcon.BackColor = System.Drawing.Color.Transparent;
            this.SettingIcon.Image = ((System.Drawing.Image)(resources.GetObject("SettingIcon.Image")));
            this.SettingIcon.Location = new System.Drawing.Point(702, 0);
            this.SettingIcon.Name = "SettingIcon";
            this.SettingIcon.Size = new System.Drawing.Size(64, 64);
            this.SettingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingIcon.TabIndex = 2;
            this.SettingIcon.TabStop = false;
            this.SettingIcon.Click += new System.EventHandler(this.SettingIcon_Click);
            // 
            // LeaderBoardIcon
            // 
            this.LeaderBoardIcon.BackColor = System.Drawing.Color.Transparent;
            this.LeaderBoardIcon.Image = ((System.Drawing.Image)(resources.GetObject("LeaderBoardIcon.Image")));
            this.LeaderBoardIcon.Location = new System.Drawing.Point(783, 0);
            this.LeaderBoardIcon.Name = "LeaderBoardIcon";
            this.LeaderBoardIcon.Size = new System.Drawing.Size(64, 64);
            this.LeaderBoardIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeaderBoardIcon.TabIndex = 3;
            this.LeaderBoardIcon.TabStop = false;
            this.LeaderBoardIcon.Click += new System.EventHandler(this.LeaderBoardIcon_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(43F, 83F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 783);
            this.Controls.Add(this.LeaderBoardIcon);
            this.Controls.Add(this.SettingIcon);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.TitleLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(16);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TRÒ CHƠI XẾP GẠCH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SettingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderBoardIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.PictureBox SettingIcon;
        private System.Windows.Forms.PictureBox LeaderBoardIcon;
    }
}