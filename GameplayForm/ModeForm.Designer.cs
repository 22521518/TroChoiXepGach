namespace WindowForm
{
    partial class ModeForm
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
            this.TwoPersonButton = new System.Windows.Forms.Button();
            this.OnePersonButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TwoPersonButton
            // 
            this.TwoPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoPersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPersonButton.ForeColor = System.Drawing.Color.White;
            this.TwoPersonButton.Location = new System.Drawing.Point(308, 123);
            this.TwoPersonButton.Name = "TwoPersonButton";
            this.TwoPersonButton.Size = new System.Drawing.Size(162, 45);
            this.TwoPersonButton.TabIndex = 23;
            this.TwoPersonButton.Text = "2 Players";
            this.TwoPersonButton.UseVisualStyleBackColor = true;
            this.TwoPersonButton.Click += new System.EventHandler(this.TwoPersonButton_Click);
            // 
            // OnePersonButton
            // 
            this.OnePersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnePersonButton.ForeColor = System.Drawing.Color.White;
            this.OnePersonButton.Location = new System.Drawing.Point(101, 123);
            this.OnePersonButton.Name = "OnePersonButton";
            this.OnePersonButton.Size = new System.Drawing.Size(162, 45);
            this.OnePersonButton.TabIndex = 22;
            this.OnePersonButton.Text = "1 Player";
            this.OnePersonButton.UseVisualStyleBackColor = true;
            this.OnePersonButton.Click += new System.EventHandler(this.OnePersonButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(200, 222);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(162, 45);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(2, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(558, 81);
            this.TitleLabel.TabIndex = 20;
            this.TitleLabel.Text = "MODE";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(43F, 83F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(562, 290);
            this.Controls.Add(this.TwoPersonButton);
            this.Controls.Add(this.OnePersonButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(16);
            this.MaximumSize = new System.Drawing.Size(580, 337);
            this.MinimumSize = new System.Drawing.Size(580, 337);
            this.Name = "ModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TwoPersonButton;
        private System.Windows.Forms.Button OnePersonButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}