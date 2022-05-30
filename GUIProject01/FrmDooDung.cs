using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmDooDung : Form
    {
        public FrmDooDung()
        {
            InitializeComponent();
        }

        private void tbMenu_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lbShowResult_Click(object sender, EventArgs e)
        {

        }

        private void FrmDooDung_Load(object sender, EventArgs e)
        {

        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbIdCard_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            mtbIdCard.Clear();
            tbName.Clear();
            dtpBirthday.Value = DateTime.Now;
            nudWeight.Value = 0;
            nudHeight.Value = 0;
            pbShow.Image = Properties.Resources.m0;
            lbIdCard.Text = "xxxxxxxxxxxxx";
            lbName.Text = "xxxxxxxxxxxxx";
            lbBirthday.Text = "xxxxxxxxxxxxx";
            lbAge.Text = "xxxxxxxxxxxxx";
            lbWeight.Text = "xxxxxxxxxxxxx";
            lbHeight.Text = "xxxxxxxxxxxxx";
            lbShowResult.Text = "ผลดวง";
        }

        private void btDooDung_Click(object sender, EventArgs e)
        {
            lbIdCard.Text = mtbIdCard.Text;
            lbName.Text = tbName.Text.Trim();
            //lbBirthday.Text = dtpBirthday.Value.ToString(); // เเสดงเเบบฝรั่ง
            //dtpBirthday.Value.ToString();//เดือน/วัน/ปี เเบบฝรั่ง
            //เเสดง ว/ด/ป เกิด เเบบไทย เช่น 1 มกราคม พ.ศ. 2560 เป้นต้น
            String dBirth = dtpBirthday.Value.Day.ToString();//ได้วัน
            String yBirth = (dtpBirthday.Value.Year + 543).ToString();
            String mBirth = "";
            switch (dtpBirthday.Value.Month)
            {
                case 1: mBirth = "มกราคม"; break;
                case 2: mBirth = "กุมภาพันธ์"; break;
                case 3: mBirth = "มีนาคม"; break;
                case 4: mBirth = "เมษายน"; break;
                case 5: mBirth = "พฤษภาคม"; break;
                case 6: mBirth = "มิถุนายน"; break;
                case 7: mBirth = "กรกฎาคม"; break;
                case 8: mBirth = "สิงหาคม"; break;
                case 9: mBirth = "กันยายน"; break;
                case 10: mBirth = "ตุลาคม"; break;
                case 11: mBirth = "พฤศจิกายน"; break;
                case 12: mBirth = "ธันวาคม"; break;
            }
            lbBirthday.Text = dBirth + " " + mBirth + " พ.ศ. " + yBirth;
            lbAge.Text = (DateTime.Now.Year - dtpBirthday.Value.Year).ToString(); //เอาปีปัจจุบัน - กับปีเกิด = ได้อายุ
            lbWeight.Text = nudWeight.Value.ToString();
            lbHeight.Text = nudHeight.Value.ToString();
            switch(dtpBirthday.Value.Month)
            {
                case 1: lbShowResult.Text = "ผลดวง : ชีวิตเรียบง่าย";
                    pbShow.Image = Properties.Resources.m1;
                    break; 
                case 2: lbShowResult.Text = "ผลดวง : ฉลาดๆ";
                    pbShow.Image = Properties.Resources.m2;
                    break; 
                case 3: lbShowResult.Text = "ผลดวง : เเย่หน่อยนะ";
                    pbShow.Image = Properties.Resources.m3;
                    break; 
                case 4: lbShowResult.Text = "ผลดวง : พูดน้อยต่อยหนักนะ";
                    pbShow.Image = Properties.Resources.m4;
                    break; 
                case 5: lbShowResult.Text = "ผลดวง : พูดมากขี้โม้";
                    pbShow.Image = Properties.Resources.m5;
                    break; 
                case 6: lbShowResult.Text = "ผลดวง : ขยัน";
                    pbShow.Image = Properties.Resources.m6;
                    break; 
                case 7: lbShowResult.Text = "ผลดวง : ตายๆไปนะ";
                    pbShow.Image = Properties.Resources.m7;
                    break; 
                case 8: lbShowResult.Text = "ผลดวง : ปากร้าย";
                    pbShow.Image = Properties.Resources.m8;
                    break; 
                case 9: lbShowResult.Text = "ผลดวง : ใจดี";
                    pbShow.Image = Properties.Resources.m9;
                    break; 
                case 10: lbShowResult.Text = "ผลดวง : ไม่เเน่ไม่นอนหรอกนะ";
                    pbShow.Image = Properties.Resources.m10;
                    break;
                case 11: lbShowResult.Text = "ผลดวง : ไม่มั่นใจ";
                    pbShow.Image = Properties.Resources.m11;
                    break;
                case 12: lbShowResult.Text = "ผลดวง : มีเสน่ห์";
                    pbShow.Image = Properties.Resources.m12;
                    break; 
            }


        }
    }
}
