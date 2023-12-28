using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowForm.Assets;
using GameComponent.Player;
using System.Runtime.CompilerServices;

namespace WindowForm
{
    public partial class MainWindow : Form
    {
        public static CustomFont cFont = new CustomFont();
        public static Sound Music = new Sound();

        public static ReaderSQL readerSQL = new ReaderSQL();
        public static WriterSQL writerSQL = new WriterSQL();

        public static Player user = new Player();
        static MenuForm menuForm = new MenuForm();
        static GameplayForm gameplayForm = new GameplayForm();
        static ModeForm modeForm = new ModeForm();
        public MainWindow()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.Black;
                    break;
                }
            }
            
            menuForm.MdiParent = this;
            modeForm.MdiParent = this;
            gameplayForm.MdiParent = this;

            BackHome();
        }

        public static void BackHome()
        {
            menuForm.StartPosition = FormStartPosition.CenterScreen;
            menuForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            menuForm.Show();
            menuForm.KeyPreview = true;

            gameplayForm.Hide();
            gameplayForm.KeyPreview = false;
            
            modeForm.Hide();
            modeForm.KeyPreview = false;

        }
        static void OpenForm(Form src, Form dest)
        {
            src.Hide();
            src.KeyPreview = false;

            dest.StartPosition = FormStartPosition.CenterScreen;
            dest.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dest.Show();
            dest.KeyPreview = true;
        }
        public static void OpenMenuWindow(Form form)
        {
            OpenForm(form, menuForm);
        }
        public static void OpenGamePlayWindow(Form form)
        {
            gameplayForm.InitializeGame();
            OpenForm(form, gameplayForm);
        }

        public static void OpenModeWindow(Form form)
        {
            OpenForm(form, modeForm);
        }
    }
}
