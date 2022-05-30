using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmAreaShape : Form
    {
        public FrmAreaShape()
        {
            InitializeComponent();
        }

        private void FrmAreaShape_Load(object sender, EventArgs e)
        {

        }

        private void tbMenu_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void showWarningMSG(string msg)
        {
            MessageBox.Show(
                msg,"คำเตือน",MessageBoxButtons.OK,MessageBoxIcon.Warning
                );
        }

        private void btCalCircle_Click(object sender, EventArgs e)
        {
            if (tbRadius.Text.Trim().Length == 0)
            {
                showWarningMSG("ป้อนรัศมีด้วย....!");
            }
            else
            {
                //พร้อมคำนวณ เเต่ต้องตรวจสอบก่อนว่าเลือกคำนวณอะไร
                if (rdoAreaCircle.Checked == true)
                {
                    //สูตร pi r * r
                    double r = double.Parse(tbRadius.Text.Trim());
                    double result = Math.PI * r * r ;
                    lbResultCircle.Text = result.ToString("0.##");
                }
                else
                {
                    //สูตร 2 * PI * r
                    double r = double.Parse(tbRadius.Text.Trim());
                    double result = 2 * Math.PI * r;
                    lbResultCircle.Text = result.ToString("0.##");
                }
            }
        }

        private void btCancelCircle_Click(object sender, EventArgs e)
        {
            tbRadius.Clear();
            rdoAreaCircle.Checked = true;
            lbResultCircle.Text = "";
        }

        private void btCalSquare_Click(object sender, EventArgs e)
        {
            if (tbWidth.Text.Trim().Length == 0)
            {
                showWarningMSG("ป้อนความกว้างด้วยนะ....!");
            }
            else if (tbLong.Text.Trim().Length == 0 )
            {
                showWarningMSG("ป้อนความยาวด้วยนะ....!");
            }
            else
            {
                //พร้อมคำนวณ เเต่ต้องตรวจสอบก่อนว่าเลือกคำนวณอะไร
                if (rdoAreaSquare.Checked == true)
                {
                    
                    double w = double.Parse(tbWidth.Text.Trim());
                    double l = double.Parse(tbLong.Text.Trim());
                    double result = w*l ;
                    lbResultSquare.Text = result.ToString("0.##");
                }
                else
                {
                    double w = double.Parse(tbWidth.Text.Trim());
                    double l = double.Parse(tbLong.Text.Trim());
                    double result = (w*2) * (l*2);
                    lbResultSquare.Text = result.ToString("0.##");
                }
            }
            
        }

        private void btCancelSquare_Click(object sender, EventArgs e)
        {
            tbWidth.Clear();
            tbLong.Clear();
            rdoAreaSquare.Checked = true;
            lbResultSquare.Text = "";
        }

        private void btCalTriangle_Click(object sender, EventArgs e)
        {
            if (tbBase.Text.Trim().Length == 0)
            {
                showWarningMSG("ป้อนฐานด้วยนะ....!");
            }
            else if (tbHigh.Text.Trim().Length == 0)
            {
                showWarningMSG("ป้อนความสูงด้วยนะ....!");
            }
            else if (tbCornor.Text.Trim().Length == 0)
            {
                showWarningMSG("ป้อนด้านด้วยนะ....!");
            }
            else
            {
                //พร้อมคำนวณ เเต่ต้องตรวจสอบก่อนว่าเลือกคำนวณอะไร
                if (rdoAreaTriangle.Checked == true)
                {

                    double b = double.Parse(tbBase.Text.Trim());
                    double h = double.Parse(tbHigh.Text.Trim());
                    double c = double.Parse(tbCornor.Text.Trim());
                    double result = b*h/2;
                    lbResultTriangle.Text = result.ToString("0.##");
                }
                else
                {
                    double b = double.Parse(tbBase.Text.Trim());
                    double h = double.Parse(tbHigh.Text.Trim());
                    double c = double.Parse(tbCornor.Text.Trim());
                    double result = b+h+c;
                    lbResultTriangle.Text = result.ToString("0.##");
                }
            }
        }

        private void btCancelTriangle_Click(object sender, EventArgs e)
        {
            tbBase.Clear();
            tbHigh.Clear();
            tbCornor.Clear();
            rdoAreaTriangle.Checked = true;
            lbResultTriangle.Text = "";
        }
    }
}
