namespace WindowForm
{
    partial class Mode1PersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mode1PersonForm));
            this.HumanModeButton = new System.Windows.Forms.Button();
            this.ClassicModeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GuideIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GuideIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // HumanModeButton
            // 
            this.HumanModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HumanModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanModeButton.ForeColor = System.Drawing.Color.White;
            this.HumanModeButton.Location = new System.Drawing.Point(308, 132);
            this.HumanModeButton.Name = "HumanModeButton";
            this.HumanModeButton.Size = new System.Drawing.Size(162, 45);
            this.HumanModeButton.TabIndex = 27;
            this.HumanModeButton.Text = "ESCAPE";
            this.HumanModeButton.UseVisualStyleBackColor = true;
            // 
            // ClassicModeButton
            // 
            this.ClassicModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassicModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassicModeButton.ForeColor = System.Drawing.Color.White;
            this.ClassicModeButton.Location = new System.Drawing.Point(101, 132);
            this.ClassicModeButton.Name = "ClassicModeButton";
            this.ClassicModeButton.Size = new System.Drawing.Size(162, 45);
            this.ClassicModeButton.TabIndex = 26;
            this.ClassicModeButton.Text = "CLASSIC";
            this.ClassicModeButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(200, 231);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(162, 45);
            this.ExitButton.TabIndex = 25;
            this.ExitButton.Text = "BACK";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(2, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(558, 81);
            this.TitleLabel.TabIndex = 24;
            this.TitleLabel.Text = "1 PERSON MODE";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuideIcon
            // 
            this.GuideIcon.BackColor = System.Drawing.Color.Transparent;
            this.GuideIcon.Image = ((System.Drawing.Image)(resources.GetObject("GuideIcon.Image")));
            this.GuideIcon.Location = new System.Drawing.Point(18, 243);
            this.GuideIcon.Name = "GuideIcon";
            this.GuideIcon.Size = new System.Drawing.Size(36, 36);
            this.GuideIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GuideIcon.TabIndex = 28;
            this.GuideIcon.TabStop = false;
            // 
            // Mode1PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(43F, 83F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(562, 290);
            this.Controls.Add(this.GuideIcon);
            this.Controls.Add(this.HumanModeButton);
            this.Controls.Add(this.ClassicModeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(16);
            this.Name = "Mode1PersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mode1PersonForm";
            ((System.ComponentModel.ISupportInitialize)(this.GuideIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HumanModeButton;
        private System.Windows.Forms.Button ClassicModeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox GuideIcon;
    }
}