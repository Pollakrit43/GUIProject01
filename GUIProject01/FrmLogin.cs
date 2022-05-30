using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่า username ใช่ admin เเละ password ใช่ abc123456 ป่าว
            //ถ้าใช่เปิด FrmMainmenu ถ้าไม่ใช่ เเสดง MSG เตือน
            if (tbUser.Text.Trim() == "admin" 
                && tbPassword.Text.Trim() == "abc123456" )
            {
                //เปิดหน้าจอ FrmMainMenu
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                //เเสดง MSG
                MessageBox.Show("ชื่อผู้ใช้เเละรหัสผ่านไม่ถูกต้อง","คำเตือน",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btExitProgram_Click(object sender, EventArgs e)
        {
            //click ปุ่มนี้เเล้วให้ปิดโปรเเกรม
            //เเต่ควรจะข้อความยินยันการปิดโปรเเกรมก่อนดีไหม????
            if (MessageBox.Show("ต้องการปิดโปรเเกรม????","ยืนยัน",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //โค้ดปิดโปรเเกรม
                Application.Exit();
            }
            else
            {
                tbUser.Focus();
            }
           
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbUser.Clear();//หรือ tbUser.Text = "";
            tbPassword.Text = ""; //หรือtbPassword.Clear();

            tbUser.Focus();
        }
    }
}
