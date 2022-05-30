using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIProject01
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void tbMenu_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lsbSubject.SelectedIndex.ToString());
            //ตรวจสอบก่อนว่า User ได้เลือกวิชาที่จะลงหรือยัง
            if (lsbSubject.SelectedIndex < 0)
            {
                MessageBox.Show("เลือกวิชาที่จะลงทะเบียนด้วย", "คำเตือน", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //user เลือกวิชาเเล้ว เขียนโค้ดย้ายรายการเลือกไปใส่ในอีก ListBox หนึ่ง
                lsbSubjectSelected.Items.Add(lsbSubject.SelectedItem);
                lsbSubject.Items.Remove(lsbSubject.SelectedItem);
            }
        }

        private void btNonSelect_Click(object sender, EventArgs e)
        {
            if (lsbSubjectSelected.SelectedIndex < 0)
            {
                MessageBox.Show("เลือกวิชาที่จะลงทะเบียนที่จะเอาออกด้วย", "คำเตือน",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //user เลือกวิชาเเล้วที่จะเอาออก เขียนโค้ดย้ายรายการเลือกไปใส่ในอีก ListBox หนึ่ง
                lsbSubject.Items.Add(lsbSubjectSelected.SelectedItem);
                lsbSubjectSelected.Items.Remove(lsbSubjectSelected.SelectedItem);
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var value in lsbSubject.Items)
            {
                lsbSubjectSelected.Items.Add(value);
            }
            //วนลูปเอาทุกรายการทั้งหมดออกจาก lsbSubject
            lsbSubject.Items.Clear();

        }

        private void btNonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var value in lsbSubjectSelected.Items)
            {
                lsbSubject.Items.Add(value);
            }
            //วนลูปเอาทุกรายการทั้งหมดออกจาก lsbSubject
            lsbSubjectSelected.Items.Clear();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            mcRegiter.SelectionStart = DateTime.Now;
            tbStuCode.Clear();
            tbStuName.Clear();
            rdNormal.Checked = true;
            cbLevel.Text = "ชั้นมัธยมศึกษาปีที่ 1 ";
            lsbSubject.Items.Clear();
            lsbSubject.Items.Add("ภาษาไทย");
            lsbSubject.Items.Add("ภาษาอังกฤษ");
            lsbSubject.Items.Add("ภาษาญี่ปุ่ม");
            lsbSubject.Items.Add("ภาษาจีน");
            lsbSubject.Items.Add("สังคมศึกษา");
            lsbSubject.Items.Add("คณิตศาสตร์");
            lsbSubject.Items.Add("พลศึกษา");
            lsbSubject.Items.Add("ประวัติศาสตร์");
            lsbSubject.Items.Add("คอมพิวเตอร์เบื้องต้น");
            lsbSubject.Items.Add("บัญชีเบื้องต้น");
            lsbSubject.Items.Add("กฏหมายเบื้องต้น");
            lsbSubject.Items.Add("เศรษฐศาสตร์เบื้องต้น");
            lsbSubject.Items.Add("หลักการบริหาร");
            lsbSubject.Items.Add("เคมี");
            lsbSubject.Items.Add("ชีววิทยา");
            lsbSubjectSelected.Items.Clear();
            chkConfirm.Checked = false;
        }
        private void showWarningMSG(String msg)
        {
            MessageBox.Show(msg,
                "คำเตือน",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            //ตรวจสอบก่อนว่า เลขประจำตัว ชื่อ วิชาที่ลงทะเบียน บืนยัน ได้ป้อนหรือเลือกหรือยัง
            if (tbStuCode.Text.Trim().Length == 0)
            {
                showWarningMSG("ป้อนเลขประจำตัว");
            }
            else if (tbStuName.Text.Trim().Length == 0)
            {
                showWarningMSG("ป้อนชื่อด้วย");
            }
            else if (lsbSubjectSelected.Items.Count < 0)
            {
                showWarningMSG("เลือกวิชาที่จะลงทะเบียนด้วย อย่างน้อย 1 วิชา");
            }
            else if (chkConfirm.Checked==false)
            {
                showWarningMSG("กรุณายืนยันการลงทะเบียนด้วย");
            }
            else
            {
                //สร้างตัวเเปรพร้อมกับเก็บค่าที่ผู้ใช้ป้อน เเละเลือกเพื่อส่งไปหน้า FrmRegisterResult
                int day = mcRegiter.SelectionStart.Day;
                int month = mcRegiter.SelectionStart.Month;
                int year = mcRegiter.SelectionStart.Year;
                string stuCode = tbStuCode.Text.Trim();
                string stuName = tbStuName.Text.Trim();
                string stuType = "";
                if (rdNormal.Checked == true)
                {
                    stuType = "นักเรียนปกติ";
                }
                else
                {
                    stuType = "นักเรียนทุน";
                }
                string stuLevel = cbLevel.Text;
                string[] stuSubjectSelected = new string[lsbSubjectSelected.Items.Count];
                for (int i=0; i< lsbSubjectSelected.Items.Count;i++)
                {
                    stuSubjectSelected[i] = lsbSubjectSelected.Items[i].ToString();
                }
                //โค้ดส่งข้อมูลไปเเสดงที่หน้า FrmRegisterResult
                FrmRegisterResult frmRegisterResult = new FrmRegisterResult(
                    day,month,year,stuCode,stuName,stuLevel,stuType,stuSubjectSelected);
                frmRegisterResult.Show();
                this.Hide();
            }

            
                
        }
    }
}
