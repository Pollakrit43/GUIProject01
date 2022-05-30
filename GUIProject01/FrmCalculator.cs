using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void tbMenu_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
        }
        private void calculatorsymbol(String optSymbol)
        {
            //algo+logic
            //ตรวจสอบป้อนครบหรือยัง ยังเเสดง MSG
            //ครบเเล้วก็คำนวณ
            if (tbNum1.Text.Trim().Length == 0)
            {
                MessageBox.Show("ป้อนตัวเลขตัวที่ 1 ด้วย !!! ", "คำเตือน",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbNum2.Text.Trim().Length == 0)
            {
                MessageBox.Show("ป้อนตัวเลขตัวที่ 2 ด้วย !!! ", "คำเตือน",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //ต้องเเปลง text เป็นตัวเลขมาคำนวณ
                double num1 = Double.Parse(tbNum1.Text.Trim());
                double num2 = Double.Parse(tbNum2.Text.Trim());
                double result = 0;
                if (optSymbol == "+")
                {
                    result = num1 + num2;
                }
                else if (optSymbol == "-")
                {
                    result = num1 - num2;
                }
                else if (optSymbol == "*")
                {
                    result = num1 * num2;
                }
                else if (optSymbol == "/")
                {
                    result = num1 / num2;
                }
                else if (optSymbol == "%")
                {
                    result = num1 % num2;
                }

                lbN1.Text = tbNum1.Text.Trim();
                lbN2.Text = tbNum2.Text.Trim();
                lbOpt.Text = optSymbol;
                lbResult.Text = result.ToString();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            //เปิดไปหน้าจอ Main
            //FrmMain frmMain = new FrmMain();
            //frmMain.Show();


            //สามารถเขียนได้บรรทัดเดียว
            new FrmMain().Show();
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            calculatorsymbol("+");
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            calculatorsymbol("-");
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            calculatorsymbol("*");
        }

        private void btDevide_Click(object sender, EventArgs e)
        {
            calculatorsymbol("/");
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            calculatorsymbol("%");
        }
    }
}
