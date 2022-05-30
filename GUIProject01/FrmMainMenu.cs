using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btExitProgram_Click(object sender, EventArgs e)
        {
            //ปุ่มนี้กลับไปหน้า FrmLogin
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            //ซ่อนหน้าจอนี้
            this.Hide();
        }

        private void btOpenPage1_Click(object sender, EventArgs e)
        {
            FrmWelcome frmWelcome = new FrmWelcome();
            frmWelcome.Show();
            this.Hide();
        }

        private void btOpenPage2_Click(object sender, EventArgs e)
        {
            FrmCalculator frmCalculator = new FrmCalculator();
            frmCalculator.Show();
            this.Hide();
        }

        private void btOpenPage3_Click(object sender, EventArgs e)
        {
            FrmMarvelGame frmMarvelGame = new FrmMarvelGame();
            frmMarvelGame.Show();
            this.Hide();
        }

        private void btOpenPage4_Click(object sender, EventArgs e)
        {
            FrmDooDung frmDooDung = new FrmDooDung();
            frmDooDung.Show();
            this.Hide();
        }

        private void btOpenPage5_Click(object sender, EventArgs e)
        {
            FrmBaiHuy frmBaiHuy = new FrmBaiHuy();
            frmBaiHuy.Show();
            this.Hide();
        }

        private void btOpenPage6_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void btOpenPage7_Click(object sender, EventArgs e)
        {
            FrmAreaShape frmAreaShape = new FrmAreaShape();
            frmAreaShape.Show();
            this.Hide();
        }
    }
}
