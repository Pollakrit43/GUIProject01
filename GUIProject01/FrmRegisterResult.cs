using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmRegisterResult : Form
    {
        //ประกาศตัวเเปรเพื่อรับค่าข้อมูลที่ส่งมาจากอีกหน้าหนึ่ง
        int day, month, year;
        string stuCode, stuName, stuLevel, stuType;

        private void FrmRegisterResult_Load(object sender, EventArgs e)
        {
            lbDateRegis.Text = day + "/" + month + "/" + (year + 543);
            lbStuCode.Text = stuCode;
            lbStuName.Text = stuName;
            lbStuLevel.Text = stuLevel;
            lbStuStatus.Text = stuType;
            lbStuSubjectRegis.Text = string.Join(",",stuSubjectSeleted);
        }

        string[] stuSubjectSeleted;

        //สร้าง constructor เพื่อรับค่าจากอีกหน้าหนึ่งมาเก็บในตัวเเปร
        public FrmRegisterResult(int day,int month,int year,
            string stuCode,string stuName,string stuLevel,
            string stuType,string [] stuSubjectSelected)
        {
            InitializeComponent(); // คำสั่งสร้าง UI 
            this.day = day;
            this.month = month;
            this.year = year;
            this.stuCode = stuCode;
            this.stuName = stuName;
            this.stuLevel = stuLevel;
            this.stuType = stuType;
            this.stuSubjectSeleted = stuSubjectSelected;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
        }
    }
}
