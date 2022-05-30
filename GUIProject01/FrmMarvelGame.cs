using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmMarvelGame : Form
    {
        public FrmMarvelGame()
        {
            InitializeComponent();
        }

        private void tbMenu_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
