namespace WindowForm
{
    partial class SettingForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.MusicTrackBar = new System.Windows.Forms.TrackBar();
            this.MusicLabel = new System.Windows.Forms.Label();
            this.EffectTrackBar = new System.Windows.Forms.TrackBar();
            this.EffectLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MusicTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(207, 243);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(162, 45);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MusicTrackBar
            // 
            this.MusicTrackBar.LargeChange = 1;
            this.MusicTrackBar.Location = new System.Drawing.Point(144, 153);
            this.MusicTrackBar.Name = "MusicTrackBar";
            this.MusicTrackBar.Size = new System.Drawing.Size(414, 56);
            this.MusicTrackBar.TabIndex = 10;
            this.MusicTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.MusicTrackBar.Scroll += new System.EventHandler(this.MusicTrackBar_Scroll);
            // 
            // MusicLabel
            // 
            this.MusicLabel.BackColor = System.Drawing.Color.Transparent;
            this.MusicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicLabel.ForeColor = System.Drawing.Color.White;
            this.MusicLabel.Location = new System.Drawing.Point(9, 162);
            this.MusicLabel.Name = "MusicLabel";
            this.MusicLabel.Size = new System.Drawing.Size(126, 23);
            this.MusicLabel.TabIndex = 9;
            this.MusicLabel.Text = "Sound";
            this.MusicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EffectTrackBar
            // 
            this.EffectTrackBar.BackColor = System.Drawing.Color.Black;
            this.EffectTrackBar.LargeChange = 1;
            this.EffectTrackBar.Location = new System.Drawing.Point(144, 90);
            this.EffectTrackBar.Name = "EffectTrackBar";
            this.EffectTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EffectTrackBar.Size = new System.Drawing.Size(414, 56);
            this.EffectTrackBar.TabIndex = 8;
            this.EffectTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.EffectTrackBar.Scroll += new System.EventHandler(this.EffectTrackBar_Scroll);
            // 
            // EffectLabel
            // 
            this.EffectLabel.BackColor = System.Drawing.Color.Transparent;
            this.EffectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectLabel.ForeColor = System.Drawing.Color.White;
            this.EffectLabel.Location = new System.Drawing.Point(9, 99);
            this.EffectLabel.Name = "EffectLabel";
            this.EffectLabel.Size = new System.Drawing.Size(126, 23);
            this.EffectLabel.TabIndex = 7;
            this.EffectLabel.Text = "Effect";
            this.EffectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(580, 81);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "SETTING";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(43F, 83F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(580, 310);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MusicTrackBar);
            this.Controls.Add(this.MusicLabel);
            this.Controls.Add(this.EffectTrackBar);
            this.Controls.Add(this.EffectLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(16);
            this.MaximumSize = new System.Drawing.Size(580, 310);
            this.MinimumSize = new System.Drawing.Size(580, 310);
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CÀI ĐẶT";
            ((System.ComponentModel.ISupportInitialize)(this.MusicTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TrackBar MusicTrackBar;
        private System.Windows.Forms.Label MusicLabel;
        private System.Windows.Forms.TrackBar EffectTrackBar;
        private System.Windows.Forms.Label EffectLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}