
namespace GUIProject01
{
    partial class FrmAreaShape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAreaShape));
            this.tbMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbResultCircle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoLineCircle = new System.Windows.Forms.RadioButton();
            this.rdoAreaCircle = new System.Windows.Forms.RadioButton();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCalCircle = new System.Windows.Forms.Button();
            this.btCancelCircle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbResultSquare = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoLineSquare = new System.Windows.Forms.RadioButton();
            this.rdoAreaSquare = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLong = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCalSquare = new System.Windows.Forms.Button();
            this.btCancelSquare = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbCornor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbResultTriangle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoLineTriangle = new System.Windows.Forms.RadioButton();
            this.rdoAreaTriangle = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHigh = new System.Windows.Forms.TextBox();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btCalTriangle = new System.Windows.Forms.Button();
            this.btCancelTriangle = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMenu.ForeColor = System.Drawing.Color.Blue;
            this.tbMenu.Location = new System.Drawing.Point(12, 12);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Size = new System.Drawing.Size(84, 62);
            this.tbMenu.TabIndex = 0;
            this.tbMenu.Text = "MENU";
            this.tbMenu.UseVisualStyleBackColor = true;
            this.tbMenu.Click += new System.EventHandler(this.tbMenu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(220, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "คำนวณ พื้นที่ เส้นรอบวง รูปทรง";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.Location = new System.Drawing.Point(324, 327);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(132, 78);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "จบโปรเเกรม";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(147, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 258);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbResultCircle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rdoLineCircle);
            this.tabPage1.Controls.Add(this.rdoAreaCircle);
            this.tabPage1.Controls.Add(this.tbRadius);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btCalCircle);
            this.tabPage1.Controls.Add(this.btCancelCircle);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วงกลม";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbResultCircle
            // 
            this.lbResultCircle.BackColor = System.Drawing.Color.Gray;
            this.lbResultCircle.Location = new System.Drawing.Point(33, 169);
            this.lbResultCircle.Name = "lbResultCircle";
            this.lbResultCircle.Size = new System.Drawing.Size(233, 32);
            this.lbResultCircle.TabIndex = 12;
            this.lbResultCircle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "ผลลัพธ์";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoLineCircle
            // 
            this.rdoLineCircle.AutoSize = true;
            this.rdoLineCircle.Location = new System.Drawing.Point(33, 109);
            this.rdoLineCircle.Name = "rdoLineCircle";
            this.rdoLineCircle.Size = new System.Drawing.Size(115, 25);
            this.rdoLineCircle.TabIndex = 10;
            this.rdoLineCircle.Text = "เส้นรอบวงกลม";
            this.rdoLineCircle.UseVisualStyleBackColor = true;
            // 
            // rdoAreaCircle
            // 
            this.rdoAreaCircle.AutoSize = true;
            this.rdoAreaCircle.Checked = true;
            this.rdoAreaCircle.Location = new System.Drawing.Point(33, 78);
            this.rdoAreaCircle.Name = "rdoAreaCircle";
            this.rdoAreaCircle.Size = new System.Drawing.Size(98, 25);
            this.rdoAreaCircle.TabIndex = 9;
            this.rdoAreaCircle.TabStop = true;
            this.rdoAreaCircle.Text = "พื้นที่วงกลม";
            this.rdoAreaCircle.UseVisualStyleBackColor = true;
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(33, 43);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(233, 29);
            this.tbRadius.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "รัศมี";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalCircle
            // 
            this.btCalCircle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCalCircle.Image = ((System.Drawing.Image)(resources.GetObject("btCalCircle.Image")));
            this.btCalCircle.Location = new System.Drawing.Point(343, 123);
            this.btCalCircle.Name = "btCalCircle";
            this.btCalCircle.Size = new System.Drawing.Size(93, 64);
            this.btCalCircle.TabIndex = 6;
            this.btCalCircle.Text = "คำนวณ";
            this.btCalCircle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCalCircle.UseVisualStyleBackColor = true;
            this.btCalCircle.Click += new System.EventHandler(this.btCalCircle_Click);
            // 
            // btCancelCircle
            // 
            this.btCancelCircle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelCircle.Image = ((System.Drawing.Image)(resources.GetObject("btCancelCircle.Image")));
            this.btCancelCircle.Location = new System.Drawing.Point(343, 24);
            this.btCancelCircle.Name = "btCancelCircle";
            this.btCancelCircle.Size = new System.Drawing.Size(93, 64);
            this.btCancelCircle.TabIndex = 5;
            this.btCancelCircle.Text = "ยกเลิก";
            this.btCancelCircle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelCircle.UseVisualStyleBackColor = true;
            this.btCancelCircle.Click += new System.EventHandler(this.btCancelCircle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbResultSquare);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.rdoLineSquare);
            this.tabPage2.Controls.Add(this.rdoAreaSquare);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbLong);
            this.tabPage2.Controls.Add(this.tbWidth);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btCalSquare);
            this.tabPage2.Controls.Add(this.btCancelSquare);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "สี่เหลี่ยม";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbResultSquare
            // 
            this.lbResultSquare.BackColor = System.Drawing.Color.Gray;
            this.lbResultSquare.Location = new System.Drawing.Point(6, 164);
            this.lbResultSquare.Name = "lbResultSquare";
            this.lbResultSquare.Size = new System.Drawing.Size(233, 32);
            this.lbResultSquare.TabIndex = 15;
            this.lbResultSquare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "ผลลัพธ์";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoLineSquare
            // 
            this.rdoLineSquare.AutoSize = true;
            this.rdoLineSquare.Location = new System.Drawing.Point(6, 104);
            this.rdoLineSquare.Name = "rdoLineSquare";
            this.rdoLineSquare.Size = new System.Drawing.Size(123, 25);
            this.rdoLineSquare.TabIndex = 13;
            this.rdoLineSquare.Text = "เส้นรอบสี่เหลี่ยม";
            this.rdoLineSquare.UseVisualStyleBackColor = true;
            // 
            // rdoAreaSquare
            // 
            this.rdoAreaSquare.AutoSize = true;
            this.rdoAreaSquare.Checked = true;
            this.rdoAreaSquare.Location = new System.Drawing.Point(6, 73);
            this.rdoAreaSquare.Name = "rdoAreaSquare";
            this.rdoAreaSquare.Size = new System.Drawing.Size(106, 25);
            this.rdoAreaSquare.TabIndex = 12;
            this.rdoAreaSquare.TabStop = true;
            this.rdoAreaSquare.Text = "พื้นที่สี่เหลี่ยม";
            this.rdoAreaSquare.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(141, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "ยาว";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbLong
            // 
            this.tbLong.Location = new System.Drawing.Point(150, 38);
            this.tbLong.Name = "tbLong";
            this.tbLong.Size = new System.Drawing.Size(109, 29);
            this.tbLong.TabIndex = 10;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(6, 38);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(109, 29);
            this.tbWidth.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "กว้าง";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalSquare
            // 
            this.btCalSquare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCalSquare.Image = ((System.Drawing.Image)(resources.GetObject("btCalSquare.Image")));
            this.btCalSquare.Location = new System.Drawing.Point(343, 130);
            this.btCalSquare.Name = "btCalSquare";
            this.btCalSquare.Size = new System.Drawing.Size(93, 64);
            this.btCalSquare.TabIndex = 7;
            this.btCalSquare.Text = "คำนวณ";
            this.btCalSquare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCalSquare.UseVisualStyleBackColor = true;
            this.btCalSquare.Click += new System.EventHandler(this.btCalSquare_Click);
            // 
            // btCancelSquare
            // 
            this.btCancelSquare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelSquare.Image = ((System.Drawing.Image)(resources.GetObject("btCancelSquare.Image")));
            this.btCancelSquare.Location = new System.Drawing.Point(343, 22);
            this.btCancelSquare.Name = "btCancelSquare";
            this.btCancelSquare.Size = new System.Drawing.Size(93, 64);
            this.btCancelSquare.TabIndex = 6;
            this.btCancelSquare.Text = "ยกเลิก";
            this.btCancelSquare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelSquare.UseVisualStyleBackColor = true;
            this.btCancelSquare.Click += new System.EventHandler(this.btCancelSquare_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbCornor);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.lbResultTriangle);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.rdoLineTriangle);
            this.tabPage3.Controls.Add(this.rdoAreaTriangle);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.tbHigh);
            this.tabPage3.Controls.Add(this.tbBase);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btCalTriangle);
            this.tabPage3.Controls.Add(this.btCancelTriangle);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(489, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "สามเหลี่ยม";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbCornor
            // 
            this.tbCornor.Location = new System.Drawing.Point(313, 52);
            this.tbCornor.Name = "tbCornor";
            this.tbCornor.Size = new System.Drawing.Size(109, 29);
            this.tbCornor.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(303, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 32);
            this.label11.TabIndex = 26;
            this.label11.Text = "ด้านตรงข้ามมุมฉาก";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResultTriangle
            // 
            this.lbResultTriangle.BackColor = System.Drawing.Color.Gray;
            this.lbResultTriangle.Location = new System.Drawing.Point(31, 178);
            this.lbResultTriangle.Name = "lbResultTriangle";
            this.lbResultTriangle.Size = new System.Drawing.Size(233, 32);
            this.lbResultTriangle.TabIndex = 25;
            this.lbResultTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(31, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "ผลลัพธ์";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoLineTriangle
            // 
            this.rdoLineTriangle.AutoSize = true;
            this.rdoLineTriangle.Location = new System.Drawing.Point(31, 118);
            this.rdoLineTriangle.Name = "rdoLineTriangle";
            this.rdoLineTriangle.Size = new System.Drawing.Size(139, 25);
            this.rdoLineTriangle.TabIndex = 23;
            this.rdoLineTriangle.Text = "เส้นรอบสามเหลี่ยม";
            this.rdoLineTriangle.UseVisualStyleBackColor = true;
            // 
            // rdoAreaTriangle
            // 
            this.rdoAreaTriangle.AutoSize = true;
            this.rdoAreaTriangle.Checked = true;
            this.rdoAreaTriangle.Location = new System.Drawing.Point(31, 87);
            this.rdoAreaTriangle.Name = "rdoAreaTriangle";
            this.rdoAreaTriangle.Size = new System.Drawing.Size(122, 25);
            this.rdoAreaTriangle.TabIndex = 22;
            this.rdoAreaTriangle.TabStop = true;
            this.rdoAreaTriangle.Text = "พื้นที่สามเหลี่ยม";
            this.rdoAreaTriangle.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(164, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 32);
            this.label9.TabIndex = 21;
            this.label9.Text = "สูง";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHigh
            // 
            this.tbHigh.Location = new System.Drawing.Point(175, 52);
            this.tbHigh.Name = "tbHigh";
            this.tbHigh.Size = new System.Drawing.Size(109, 29);
            this.tbHigh.TabIndex = 20;
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(31, 52);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(109, 29);
            this.tbBase.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(28, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "ฐาน";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalTriangle
            // 
            this.btCalTriangle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCalTriangle.Image = ((System.Drawing.Image)(resources.GetObject("btCalTriangle.Image")));
            this.btCalTriangle.Location = new System.Drawing.Point(366, 101);
            this.btCalTriangle.Name = "btCalTriangle";
            this.btCalTriangle.Size = new System.Drawing.Size(93, 64);
            this.btCalTriangle.TabIndex = 17;
            this.btCalTriangle.Text = "คำนวณ";
            this.btCalTriangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCalTriangle.UseVisualStyleBackColor = true;
            this.btCalTriangle.Click += new System.EventHandler(this.btCalTriangle_Click);
            // 
            // btCancelTriangle
            // 
            this.btCancelTriangle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelTriangle.Image = ((System.Drawing.Image)(resources.GetObject("btCancelTriangle.Image")));
            this.btCancelTriangle.Location = new System.Drawing.Point(258, 101);
            this.btCancelTriangle.Name = "btCancelTriangle";
            this.btCancelTriangle.Size = new System.Drawing.Size(93, 64);
            this.btCancelTriangle.TabIndex = 16;
            this.btCancelTriangle.Text = "ยกเลิก";
            this.btCancelTriangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelTriangle.UseVisualStyleBackColor = true;
            this.btCancelTriangle.Click += new System.EventHandler(this.btCancelTriangle_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel2.Text = "จัดทำโดย Cpmputer SAU";
            // 
            // FrmAreaShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMenu);
            this.MaximizeBox = false;
            this.Name = "FrmAreaShape";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอคำนวณพื้นที่รูปทรง - โปรเเกรม SAU Learning V.1.0";
            this.Load += new System.EventHandler(this.FrmAreaShape_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbResultCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoLineCircle;
        private System.Windows.Forms.RadioButton rdoAreaCircle;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalCircle;
        private System.Windows.Forms.Button btCancelCircle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbResultSquare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoLineSquare;
        private System.Windows.Forms.RadioButton rdoAreaSquare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLong;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCalSquare;
        private System.Windows.Forms.Button btCancelSquare;
        private System.Windows.Forms.TextBox tbCornor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbResultTriangle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdoLineTriangle;
        private System.Windows.Forms.RadioButton rdoAreaTriangle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHigh;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btCalTriangle;
        private System.Windows.Forms.Button btCancelTriangle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}