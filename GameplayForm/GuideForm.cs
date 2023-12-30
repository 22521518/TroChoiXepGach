using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm
{
    public partial class GuideForm : Form
    {
        public GuideForm()
        {
            InitializeComponent();
            TitleLabel.Font = new Font(MainWindow.cFont.Alkhemikal, 30, FontStyle.Bold);
            ClassicBtn.Font = EscapeBtn.Font = PvPBtn.Font = new Font(MainWindow.cFont.Alkhemikal, 16, FontStyle.Bold);
            foreach (TabPage tb in tabControl1.TabPages)
            {
                foreach (Control label in tb.Controls)
                {
                    label.Font = new Font(MainWindow.cFont.Alkhemikal, 16, FontStyle.Regular);
                }
            }
        }

        private void ClassicBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            ClassicBtn.BackColor = Color.DimGray;
            EscapeBtn.BackColor = Color.Black;
            PvPBtn.BackColor = Color.Black;
        }

        private void EscapeBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            ClassicBtn.BackColor = Color.Black;
            EscapeBtn.BackColor = Color.DimGray;
            PvPBtn.BackColor = Color.Black;
        }

        private void PvPBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
            ClassicBtn.BackColor = Color.Black;
            EscapeBtn.BackColor = Color.Black;
            PvPBtn.BackColor = Color.DimGray;
        }
    }
}
