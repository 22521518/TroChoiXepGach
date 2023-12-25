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
            this.HumanModeButton = new System.Windows.Forms.Button();
            this.ClassicModeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
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
            this.HumanModeButton.Text = "HUMAN";
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
            // Mode1PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(43F, 83F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(562, 290);
            this.Controls.Add(this.HumanModeButton);
            this.Controls.Add(this.ClassicModeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.Name = "Mode1PersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mode1PersonForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HumanModeButton;
        private System.Windows.Forms.Button ClassicModeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}