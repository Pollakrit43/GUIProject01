using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmBaiHuy : Form
    {
        public FrmBaiHuy()
        {
            InitializeComponent();
        }

        private void tbMenu_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
        }

        private void FrmBaiHuy_Load(object sender, EventArgs e)
        {

        }

        private void btOut_Click(object sender, EventArgs e)
        {
            if (rdOut.Checked == true)
            {
                //ออกหวย
                //โค้ด gen เชข
                Random rd = new Random(); //สร้างออปเจคของคลาส random
                //String num1 = rd.Next(1000000).ToString("000000");
                //lbShow1.Text = num1;
                lbShow1.Text = rd.Next(1000000).ToString("000000");
                lbShowFront1.Text = rd.Next(1000).ToString("000");
                lbShowFront2.Text = rd.Next(1000).ToString("000");
                lbShowBack1.Text = rd.Next(1000).ToString("000");
                lbShowBack2.Text = rd.Next(1000).ToString("000");
                lbShowBack3.Text = rd.Next(100).ToString("00");

            }
            else
            {
                //รีเชตค่ากลับเป็นเหมือนเดิม
                lbShow1.Text = "XXXXXX";
                lbShowFront1.Text = "XXX";
                lbShowFront2.Text = "XXX";
                lbShowBack1.Text = "XXX";
                lbShowBack2.Text = "XXX";
                lbShowBack3.Text = "XX";
            }
        }
    }
}
