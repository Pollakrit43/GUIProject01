
namespace GUIProject01
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExitProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(167, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "โปรแกรม SAU Learning V.1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(192, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อผู้ใช้";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(192, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "รหัสผ่าน";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(285, 160);
            this.tbUser.Name = "tbUser";
            this.tbUser.PlaceholderText = "ป้อนภาษาอังกฤษเท่านั้น";
            this.tbUser.Size = new System.Drawing.Size(302, 23);
            this.tbUser.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(285, 251);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderText = "ป้อนรหัสผ่านไม่ต่ำกว่า 6 ตัว";
            this.tbPassword.Size = new System.Drawing.Size(302, 23);
            this.tbPassword.TabIndex = 5;
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLogin.Location = new System.Drawing.Point(285, 313);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(120, 54);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "เข้าใช้งานระบบ";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancel.Location = new System.Drawing.Point(467, 313);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 54);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIProject01.Properties.Resources.a2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btExitProgram
            // 
            this.btExitProgram.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExitProgram.Location = new System.Drawing.Point(285, 403);
            this.btExitProgram.Name = "btExitProgram";
            this.btExitProgram.Size = new System.Drawing.Size(302, 54);
            this.btExitProgram.TabIndex = 9;
            this.btExitProgram.Text = "ออกจากโปรแกรม";
            this.btExitProgram.UseVisualStyleBackColor = true;
            this.btExitProgram.Click += new System.EventHandler(this.btExitProgram_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 507);
            this.Controls.Add(this.btExitProgram);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btExitProgram;
    }
}