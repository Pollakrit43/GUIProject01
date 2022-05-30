
namespace GUIProject01
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.tbMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mcRegiter = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbSubject = new System.Windows.Forms.ListBox();
            this.lsbSubjectSelected = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.rbFund = new System.Windows.Forms.RadioButton();
            this.tbStuCode = new System.Windows.Forms.TextBox();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btNonSelect = new System.Windows.Forms.Button();
            this.btNonSelectAll = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkConfirm = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMenu.ForeColor = System.Drawing.Color.Blue;
            this.tbMenu.Location = new System.Drawing.Point(12, 12);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Size = new System.Drawing.Size(93, 76);
            this.tbMenu.TabIndex = 4;
            this.tbMenu.Text = "MENU";
            this.tbMenu.UseVisualStyleBackColor = true;
            this.tbMenu.Click += new System.EventHandler(this.tbMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(361, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "โปรเเกรมลงทะเบียนเรียน";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mcRegiter
            // 
            this.mcRegiter.Location = new System.Drawing.Point(142, 51);
            this.mcRegiter.Name = "mcRegiter";
            this.mcRegiter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "วันที่ลงทะเบียน";
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "ชันมัธยมศึกษาปีที่ 1",
            "ชันมัธยมศึกษาปีที่ 2",
            "ชันมัธยมศึกษาปีที่ 3",
            "ชันมัธยมศึกษาปีที่ 4",
            "ชันมัธยมศึกษาปีที่ 5",
            "ชันมัธยมศึกษาปีที่ 6"});
            this.cbLevel.Location = new System.Drawing.Point(142, 252);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(121, 23);
            this.cbLevel.TabIndex = 8;
            this.cbLevel.Text = "ชันมัธยมศึกษาปีที่ 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ระดับชั้น";
            // 
            // lsbSubject
            // 
            this.lsbSubject.FormattingEnabled = true;
            this.lsbSubject.ItemHeight = 15;
            this.lsbSubject.Items.AddRange(new object[] {
            "ภาษาไทย",
            "ภาษาอังกฤษ",
            "ภาษาญี่ปุ่ม",
            "ภาษาจีน",
            "สังคมศึกษา",
            "คณิตศาสตร์",
            "พลศึกษา",
            "ประวัติศาสตร์",
            "คอมพิวเตอร์เบื้องต้น",
            "บัญชีเบื้องต้น",
            "กฏหมายเบื้องต้น",
            "เศรษฐศาสตร์เบื้องต้น",
            "หลักการบริหาร",
            "เคมี",
            "ชีววิทยา"});
            this.lsbSubject.Location = new System.Drawing.Point(142, 304);
            this.lsbSubject.Name = "lsbSubject";
            this.lsbSubject.Size = new System.Drawing.Size(178, 124);
            this.lsbSubject.TabIndex = 10;
            // 
            // lsbSubjectSelected
            // 
            this.lsbSubjectSelected.FormattingEnabled = true;
            this.lsbSubjectSelected.ItemHeight = 15;
            this.lsbSubjectSelected.Location = new System.Drawing.Point(440, 256);
            this.lsbSubjectSelected.Name = "lsbSubjectSelected";
            this.lsbSubjectSelected.Size = new System.Drawing.Size(120, 184);
            this.lsbSubjectSelected.TabIndex = 11;
            this.lsbSubjectSelected.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "เลขประจำตัวนักเรียน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "ชื่อ-สกุล";
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Checked = true;
            this.rdNormal.Location = new System.Drawing.Point(350, 216);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(46, 19);
            this.rdNormal.TabIndex = 14;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "ปกติ";
            this.rdNormal.UseVisualStyleBackColor = true;
            // 
            // rbFund
            // 
            this.rbFund.AutoSize = true;
            this.rbFund.Location = new System.Drawing.Point(460, 216);
            this.rbFund.Name = "rbFund";
            this.rbFund.Size = new System.Drawing.Size(57, 19);
            this.rbFund.TabIndex = 15;
            this.rbFund.Text = "กองทุน";
            this.rbFund.UseVisualStyleBackColor = true;
            // 
            // tbStuCode
            // 
            this.tbStuCode.Location = new System.Drawing.Point(352, 81);
            this.tbStuCode.Name = "tbStuCode";
            this.tbStuCode.Size = new System.Drawing.Size(167, 23);
            this.tbStuCode.TabIndex = 16;
            // 
            // tbStuName
            // 
            this.tbStuName.Location = new System.Drawing.Point(352, 153);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(167, 23);
            this.tbStuName.TabIndex = 18;
            this.tbStuName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btSelect
            // 
            this.btSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSelect.ForeColor = System.Drawing.Color.Lime;
            this.btSelect.Location = new System.Drawing.Point(350, 252);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 43);
            this.btSelect.TabIndex = 19;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = false;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btSelectAll
            // 
            this.btSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSelectAll.ForeColor = System.Drawing.Color.Lime;
            this.btSelectAll.Location = new System.Drawing.Point(350, 301);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(75, 46);
            this.btSelectAll.TabIndex = 20;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.UseVisualStyleBackColor = false;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // btNonSelect
            // 
            this.btNonSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNonSelect.ForeColor = System.Drawing.Color.Red;
            this.btNonSelect.Location = new System.Drawing.Point(350, 353);
            this.btNonSelect.Name = "btNonSelect";
            this.btNonSelect.Size = new System.Drawing.Size(75, 43);
            this.btNonSelect.TabIndex = 21;
            this.btNonSelect.Text = "<";
            this.btNonSelect.UseVisualStyleBackColor = false;
            this.btNonSelect.Click += new System.EventHandler(this.btNonSelect_Click);
            // 
            // btNonSelectAll
            // 
            this.btNonSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNonSelectAll.ForeColor = System.Drawing.Color.Red;
            this.btNonSelectAll.Location = new System.Drawing.Point(350, 402);
            this.btNonSelectAll.Name = "btNonSelectAll";
            this.btNonSelectAll.Size = new System.Drawing.Size(75, 47);
            this.btNonSelectAll.TabIndex = 22;
            this.btNonSelectAll.Text = "<<";
            this.btNonSelectAll.UseVisualStyleBackColor = false;
            this.btNonSelectAll.Click += new System.EventHandler(this.btNonSelectAll_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(705, 252);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(118, 67);
            this.btRegister.TabIndex = 23;
            this.btRegister.Text = "ลงทะเบียน";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(620, 325);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(156, 56);
            this.btCancel.TabIndex = 24;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(620, 387);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(157, 52);
            this.btClose.TabIndex = 25;
            this.btClose.Text = "ปิดโปรเเกรม";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "ประเภทนักเรียน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "รายวิชาลงทะเบียน";
            // 
            // chkConfirm
            // 
            this.chkConfirm.AutoSize = true;
            this.chkConfirm.Location = new System.Drawing.Point(580, 277);
            this.chkConfirm.Name = "chkConfirm";
            this.chkConfirm.Size = new System.Drawing.Size(114, 19);
            this.chkConfirm.TabIndex = 29;
            this.chkConfirm.Text = "ยืนยันการลงทะเบียน";
            this.chkConfirm.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btNonSelectAll);
            this.Controls.Add(this.btNonSelect);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.tbStuName);
            this.Controls.Add(this.tbStuCode);
            this.Controls.Add(this.rbFund);
            this.Controls.Add(this.rdNormal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsbSubjectSelected);
            this.Controls.Add(this.lsbSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcRegiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMenu);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอลงทะเบียน - โปรเเกรม SAU Learning V.1.0";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcRegiter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsbSubject;
        private System.Windows.Forms.ListBox lsbSubjectSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.RadioButton rbFund;
        private System.Windows.Forms.TextBox tbStuCode;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btNonSelect;
        private System.Windows.Forms.Button btNonSelectAll;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}