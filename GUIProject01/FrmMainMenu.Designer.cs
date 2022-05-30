
namespace GUIProject01
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btOpenPage2 = new System.Windows.Forms.Button();
            this.btOpenPage3 = new System.Windows.Forms.Button();
            this.btOpenPage5 = new System.Windows.Forms.Button();
            this.btOpenPage4 = new System.Windows.Forms.Button();
            this.btOpenPage6 = new System.Windows.Forms.Button();
            this.btOpenPage7 = new System.Windows.Forms.Button();
            this.btExitProgram = new System.Windows.Forms.Button();
            this.btOpenPage1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรม SAU Learning V.1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btOpenPage2
            // 
            this.btOpenPage2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOpenPage2.Location = new System.Drawing.Point(78, 140);
            this.btOpenPage2.Name = "btOpenPage2";
            this.btOpenPage2.Size = new System.Drawing.Size(230, 68);
            this.btOpenPage2.TabIndex = 1;
            this.btOpenPage2.Text = "หน้าจอ Calculator";
            this.btOpenPage2.UseVisualStyleBackColor = true;
            this.btOpenPage2.Click += new System.EventHandler(this.btOpenPage2_Click);
            // 
            // btOpenPage3
            // 
            this.btOpenPage3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOpenPage3.Location = new System.Drawing.Point(398, 140);
            this.btOpenPage3.Name = "btOpenPage3";
            this.btOpenPage3.Size = new System.Drawing.Size(230, 68);
            this.btOpenPage3.TabIndex = 2;
            this.btOpenPage3.Text = "หน้าจอ Marvel Game";
            this.btOpenPage3.UseVisualStyleBackColor = true;
            this.btOpenPage3.Click += new System.EventHandler(this.btOpenPage3_Click);
            // 
            // btOpenPage5
            // 
            this.btOpenPage5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOpenPage5.Location = new System.Drawing.Point(398, 263);
            this.btOpenPage5.Name = "btOpenPage5";
            this.btOpenPage5.Size = new System.Drawing.Size(230, 68);
            this.btOpenPage5.TabIndex = 4;
            this.btOpenPage5.Text = "หน้าจอ ใบ้หวย";
            this.btOpenPage5.UseVisualStyleBackColor = true;
            this.btOpenPage5.Click += new System.EventHandler(this.btOpenPage5_Click);
            // 
            // btOpenPage4
            // 
            this.btOpenPage4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOpenPage4.Location = new System.Drawing.Point(78, 263);
            this.btOpenPage4.Name = "btOpenPage4";
            this.btOpenPage4.Size = new System.Drawing.Size(230, 68);
            this.btOpenPage4.TabIndex = 3;
            this.btOpenPage4.Text = "หน้าจอ ดูดวงแม่นๆ";
            this.btOpenPage4.UseVisualStyleBackColor = true;
            this.btOpenPage4.Click += new System.EventHandler(this.btOpenPage4_Click);
            // 
            // btOpenPage6
            // 
            this.btOpenPage6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOpenPage6.Location = new System.Drawing.Point(78, 372);
            this.btOpenPage6.Name = "btOpenPage6";
            this.btOpenPage6.Size = new System.Drawing.Size(230, 68);
            this.btOpenPage6.TabIndex = 5;
            this.btOpenPage6.Text = "หน้าจอ ลงทะเบียน";
            this.btOpenPage6.UseVisualStyleBackColor = true;
            this.btOpenPage6.Click += new System.EventHandler(this.btOpenPage6_Click);
            // 
            // btOpenPage7
            // 
            this.btOpenPage7.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOpenPage7.Location = new System.Drawing.Point(398, 372);
            this.btOpenPage7.Name = "btOpenPage7";
            this.btOpenPage7.Size = new System.Drawing.Size(230, 68);
            this.btOpenPage7.TabIndex = 6;
            this.btOpenPage7.Text = "หน้าจอ คำนวณพื้นที่รูปทรง";
            this.btOpenPage7.UseVisualStyleBackColor = true;
            this.btOpenPage7.Click += new System.EventHandler(this.btOpenPage7_Click);
            // 
            // btExitProgram
            // 
            this.btExitProgram.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExitProgram.Image = global::GUIProject01.Properties.Resources.exit1;
            this.btExitProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExitProgram.Location = new System.Drawing.Point(270, 468);
            this.btExitProgram.Name = "btExitProgram";
            this.btExitProgram.Size = new System.Drawing.Size(159, 60);
            this.btExitProgram.TabIndex = 7;
            this.btExitProgram.Text = "ออกจากโปรแกรม";
            this.btExitProgram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExitProgram.UseVisualStyleBackColor = true;
            this.btExitProgram.Click += new System.EventHandler(this.btExitProgram_Click);
            // 
            // btOpenPage1
            // 
            this.btOpenPage1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOpenPage1.Image = global::GUIProject01.Properties.Resources.star1;
            this.btOpenPage1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOpenPage1.Location = new System.Drawing.Point(233, 66);
            this.btOpenPage1.Name = "btOpenPage1";
            this.btOpenPage1.Size = new System.Drawing.Size(230, 68);
            this.btOpenPage1.TabIndex = 0;
            this.btOpenPage1.Text = "หน้าจอ Welcome";
            this.btOpenPage1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOpenPage1.UseVisualStyleBackColor = true;
            this.btOpenPage1.Click += new System.EventHandler(this.btOpenPage1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 558);
            this.Controls.Add(this.btOpenPage1);
            this.Controls.Add(this.btExitProgram);
            this.Controls.Add(this.btOpenPage7);
            this.Controls.Add(this.btOpenPage6);
            this.Controls.Add(this.btOpenPage4);
            this.Controls.Add(this.btOpenPage5);
            this.Controls.Add(this.btOpenPage3);
            this.Controls.Add(this.btOpenPage2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอเมนู-โปรแกรม SAU Learning V1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOpenPage2;
        private System.Windows.Forms.Button btOpenPage3;
        private System.Windows.Forms.Button btOpenPage5;
        private System.Windows.Forms.Button btOpenPage4;
        private System.Windows.Forms.Button btOpenPage6;
        private System.Windows.Forms.Button btOpenPage7;
        private System.Windows.Forms.Button btExitProgram;
        private System.Windows.Forms.Button btOpenPage1;
    }
}

