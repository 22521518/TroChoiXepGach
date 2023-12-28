namespace WindowForm
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(9, 27);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(576, 117);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Please enter your name";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(117, 171);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(333, 32);
            this.NameTextBox.TabIndex = 2;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(162, 234);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(252, 45);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CloseIcon
            // 
            this.CloseIcon.BackColor = System.Drawing.Color.Transparent;
            this.CloseIcon.Image = ((System.Drawing.Image)(resources.GetObject("CloseIcon.Image")));
            this.CloseIcon.Location = new System.Drawing.Point(549, 0);
            this.CloseIcon.Margin = new System.Windows.Forms.Padding(0);
            this.CloseIcon.Name = "CloseIcon";
            this.CloseIcon.Size = new System.Drawing.Size(32, 32);
            this.CloseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseIcon.TabIndex = 4;
            this.CloseIcon.TabStop = false;
            this.CloseIcon.Click += new System.EventHandler(this.CloseIcon_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(43F, 83F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(580, 310);
            this.Controls.Add(this.CloseIcon);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(16);
            this.MaximumSize = new System.Drawing.Size(580, 310);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TRÒ CHƠI XẾP GẠCH";
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.PictureBox CloseIcon;
    }
}