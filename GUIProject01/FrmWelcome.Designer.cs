
namespace GUIProject01
{
    partial class FrmWelcome
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
            this.btMenu = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAccept = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMenu.ForeColor = System.Drawing.Color.Blue;
            this.btMenu.Location = new System.Drawing.Point(12, 12);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(99, 75);
            this.btMenu.TabIndex = 5;
            this.btMenu.Text = "MENU";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(219, 162);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(329, 23);
            this.tbName.TabIndex = 6;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(219, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "ป้อนชื่อ :";
            // 
            // btAccept
            // 
            this.btAccept.Image = global::GUIProject01.Properties.Resources.ok3;
            this.btAccept.Location = new System.Drawing.Point(219, 245);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(109, 85);
            this.btAccept.TabIndex = 8;
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = global::GUIProject01.Properties.Resources.cancel1;
            this.btCancel.Location = new System.Drawing.Point(431, 245);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(117, 85);
            this.btCancel.TabIndex = 9;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btMenu);
            this.MaximizeBox = false;
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอWelcome - โปรเเกรม SAU Learning V.1.0";
            this.Load += new System.EventHandler(this.FrmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Button btCancel;
    }
}