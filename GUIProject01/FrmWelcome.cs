using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbName.Focus();
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่าชื่อป้อนหรือยัง ยังไม่ได้ป้อนเเสดง MSG
            //ป้อนเเล้วเเสดง MSG ยินดีต้อนรับ เเล้วตามด้วยชื่อที่ป้อน
            if (tbName.Text.Trim().Length == 0)
            {
                MessageBox.Show("ป้อนชื่อด้วย" , "คำเตือน", 
                    MessageBoxButtons.OK , MessageBoxIcon.Warning );
            }
            else
            {
                MessageBox.Show("ยินดีต้อนรับ " + tbName.Text.Trim(), "Welcome" , 
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
