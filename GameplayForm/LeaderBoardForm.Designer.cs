using System.Windows.Forms;

namespace WindowForm
{
    partial class LeaderBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderBoardForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NameFilterLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ModeFilterLabel = new System.Windows.Forms.Label();
            this.ModeClassicFilterButton = new System.Windows.Forms.Button();
            this.ModeHumanFilterButton = new System.Windows.Forms.Button();
            this.NameFilterButton = new System.Windows.Forms.Button();
            this.LeaderBoard = new System.Windows.Forms.DataGridView();
            this.AllModeButton = new System.Windows.Forms.Button();
            this.PlayerBoardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseButton.Location = new System.Drawing.Point(18, 671);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(117, 36);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameFilterLabel
            // 
            this.NameFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFilterLabel.Location = new System.Drawing.Point(0, 122);
            this.NameFilterLabel.Name = "NameFilterLabel";
            this.NameFilterLabel.Size = new System.Drawing.Size(180, 27);
            this.NameFilterLabel.TabIndex = 21;
            this.NameFilterLabel.Text = "Enter name";
            this.NameFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(189, 122);
            this.NameTextBox.MaxLength = 100;
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(441, 31);
            this.NameTextBox.TabIndex = 20;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Black;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(279, 29);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(243, 65);
            this.TitleLabel.TabIndex = 19;
            this.TitleLabel.Text = "LEADERBOARD";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ModeFilterLabel
            // 
            this.ModeFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.ModeFilterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ModeFilterLabel.Location = new System.Drawing.Point(288, 671);
            this.ModeFilterLabel.Name = "ModeFilterLabel";
            this.ModeFilterLabel.Size = new System.Drawing.Size(108, 36);
            this.ModeFilterLabel.TabIndex = 17;
            this.ModeFilterLabel.Text = "Mode";
            this.ModeFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModeClassicFilterButton
            // 
            this.ModeClassicFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeClassicFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeClassicFilterButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ModeClassicFilterButton.Location = new System.Drawing.Point(657, 671);
            this.ModeClassicFilterButton.Name = "ModeClassicFilterButton";
            this.ModeClassicFilterButton.Size = new System.Drawing.Size(117, 36);
            this.ModeClassicFilterButton.TabIndex = 16;
            this.ModeClassicFilterButton.Text = "Classic";
            this.ModeClassicFilterButton.UseVisualStyleBackColor = true;
            this.ModeClassicFilterButton.Click += new System.EventHandler(this.ModeClassicFilterButton_Click);
            // 
            // ModeHumanFilterButton
            // 
            this.ModeHumanFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeHumanFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeHumanFilterButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ModeHumanFilterButton.Location = new System.Drawing.Point(531, 671);
            this.ModeHumanFilterButton.Name = "ModeHumanFilterButton";
            this.ModeHumanFilterButton.Size = new System.Drawing.Size(117, 36);
            this.ModeHumanFilterButton.TabIndex = 15;
            this.ModeHumanFilterButton.Text = "Human";
            this.ModeHumanFilterButton.UseVisualStyleBackColor = true;
            this.ModeHumanFilterButton.Click += new System.EventHandler(this.ModeHumanFilterButton_Click);
            // 
            // NameFilterButton
            // 
            this.NameFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFilterButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameFilterButton.Location = new System.Drawing.Point(648, 122);
            this.NameFilterButton.Name = "NameFilterButton";
            this.NameFilterButton.Size = new System.Drawing.Size(117, 30);
            this.NameFilterButton.TabIndex = 14;
            this.NameFilterButton.Text = "Find";
            this.NameFilterButton.UseVisualStyleBackColor = true;
            this.NameFilterButton.Click += new System.EventHandler(this.NameFilterButton_Click);
            // 
            // LeaderBoard
            // 
            this.LeaderBoard.AllowUserToAddRows = false;
            this.LeaderBoard.AllowUserToDeleteRows = false;
            this.LeaderBoard.AllowUserToResizeColumns = false;
            this.LeaderBoard.AllowUserToResizeRows = false;
            this.LeaderBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeaderBoard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.LeaderBoard.BackgroundColor = System.Drawing.Color.Black;
            this.LeaderBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeaderBoard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LeaderBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LeaderBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LeaderBoard.DefaultCellStyle = dataGridViewCellStyle2;
            this.LeaderBoard.Location = new System.Drawing.Point(0, 153);
            this.LeaderBoard.MultiSelect = false;
            this.LeaderBoard.Name = "LeaderBoard";
            this.LeaderBoard.ReadOnly = true;
            this.LeaderBoard.RowHeadersVisible = false;
            this.LeaderBoard.RowHeadersWidth = 51;
            this.LeaderBoard.RowTemplate.Height = 24;
            this.LeaderBoard.Size = new System.Drawing.Size(774, 513);
            this.LeaderBoard.TabIndex = 23;
            // 
            // AllModeButton
            // 
            this.AllModeButton.BackColor = System.Drawing.Color.DimGray;
            this.AllModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllModeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AllModeButton.Location = new System.Drawing.Point(405, 671);
            this.AllModeButton.Name = "AllModeButton";
            this.AllModeButton.Size = new System.Drawing.Size(117, 36);
            this.AllModeButton.TabIndex = 24;
            this.AllModeButton.Text = "All";
            this.AllModeButton.UseVisualStyleBackColor = false;
            this.AllModeButton.Click += new System.EventHandler(this.AllModeButton_Click);
            // 
            // PlayerBoardButton
            // 
            this.PlayerBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerBoardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.PlayerBoardButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerBoardButton.Location = new System.Drawing.Point(153, 671);
            this.PlayerBoardButton.Name = "PlayerBoardButton";
            this.PlayerBoardButton.Size = new System.Drawing.Size(117, 36);
            this.PlayerBoardButton.TabIndex = 25;
            this.PlayerBoardButton.Text = "Player";
            this.PlayerBoardButton.UseVisualStyleBackColor = true;
            this.PlayerBoardButton.Click += new System.EventHandler(this.PlayerBoardButton_Click);
            // 
            // LeaderBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(43F, 83F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 712);
            this.Controls.Add(this.PlayerBoardButton);
            this.Controls.Add(this.AllModeButton);
            this.Controls.Add(this.LeaderBoard);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NameFilterLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ModeFilterLabel);
            this.Controls.Add(this.ModeClassicFilterButton);
            this.Controls.Add(this.ModeHumanFilterButton);
            this.Controls.Add(this.NameFilterButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(16);
            this.Name = "LeaderBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BẢNG XẾP HẠNG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CloseButton;
        private Label NameFilterLabel;
        private TextBox NameTextBox;
        private Label TitleLabel;
        private PictureBox pictureBox1;
        private Label ModeFilterLabel;
        private Button ModeClassicFilterButton;
        private Button ModeHumanFilterButton;
        private Button NameFilterButton;
        private DataGridView LeaderBoard;
        private Button AllModeButton;
        private Button PlayerBoardButton;
    }
}