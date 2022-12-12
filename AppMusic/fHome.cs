using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMusic
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
            this.Icon = Resource.btnPlaySong1;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            fPlay fplay = new fPlay();
            this.Hide();
            fplay.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the app?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
