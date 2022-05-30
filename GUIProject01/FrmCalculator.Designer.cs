
namespace GUIProject01
{
    partial class FrmCalculator
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
            this.tbMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btDevide = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.lbN1 = new System.Windows.Forms.Label();
            this.lbOpt = new System.Windows.Forms.Label();
            this.lbN2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMenu.ForeColor = System.Drawing.Color.Blue;
            this.tbMenu.Location = new System.Drawing.Point(12, 12);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Size = new System.Drawing.Size(99, 75);
            this.tbMenu.TabIndex = 1;
            this.tbMenu.Text = "MENU";
            this.tbMenu.UseVisualStyleBackColor = true;
            this.tbMenu.Click += new System.EventHandler(this.tbMenu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(260, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculator Program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(159, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ป้อนตัวเลขที่ 1";
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(276, 113);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(228, 23);
            this.tbNum1.TabIndex = 5;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(280, 177);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(228, 23);
            this.tbNum2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(159, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ป้อนตัวเลขที่ 2";
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPlus.Location = new System.Drawing.Point(42, 240);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(69, 62);
            this.btPlus.TabIndex = 8;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMinus.Location = new System.Drawing.Point(159, 240);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(69, 62);
            this.btMinus.TabIndex = 9;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMultiply.Location = new System.Drawing.Point(276, 240);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(69, 62);
            this.btMultiply.TabIndex = 10;
            this.btMultiply.Text = "x";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // btDevide
            // 
            this.btDevide.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDevide.Location = new System.Drawing.Point(390, 240);
            this.btDevide.Name = "btDevide";
            this.btDevide.Size = new System.Drawing.Size(69, 62);
            this.btDevide.TabIndex = 11;
            this.btDevide.Text = "/";
            this.btDevide.UseVisualStyleBackColor = true;
            this.btDevide.Click += new System.EventHandler(this.btDevide_Click);
            // 
            // btMod
            // 
            this.btMod.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMod.Location = new System.Drawing.Point(497, 240);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(69, 62);
            this.btMod.TabIndex = 12;
            this.btMod.Text = "%";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClear.Image = global::GUIProject01.Properties.Resources.exit4;
            this.btClear.Location = new System.Drawing.Point(599, 240);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(69, 62);
            this.btClear.TabIndex = 13;
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbN1
            // 
            this.lbN1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbN1.ForeColor = System.Drawing.Color.Red;
            this.lbN1.Location = new System.Drawing.Point(60, 368);
            this.lbN1.Name = "lbN1";
            this.lbN1.Size = new System.Drawing.Size(51, 52);
            this.lbN1.TabIndex = 14;
            this.lbN1.Text = "N1";
            // 
            // lbOpt
            // 
            this.lbOpt.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOpt.ForeColor = System.Drawing.Color.Blue;
            this.lbOpt.Location = new System.Drawing.Point(159, 368);
            this.lbOpt.Name = "lbOpt";
            this.lbOpt.Size = new System.Drawing.Size(69, 52);
            this.lbOpt.TabIndex = 15;
            this.lbOpt.Text = "opt";
            // 
            // lbN2
            // 
            this.lbN2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbN2.ForeColor = System.Drawing.Color.Red;
            this.lbN2.Location = new System.Drawing.Point(276, 368);
            this.lbN2.Name = "lbN2";
            this.lbN2.Size = new System.Drawing.Size(51, 52);
            this.lbN2.TabIndex = 16;
            this.lbN2.Text = "N2";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(276, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 52);
            this.label7.TabIndex = 17;
            this.label7.Text = "ผลลัพธ์";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(390, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 52);
            this.label8.TabIndex = 18;
            this.label8.Text = "=";
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(468, 368);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(98, 52);
            this.lbResult.TabIndex = 19;
            this.lbResult.Text = "Result";
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbN2);
            this.Controls.Add(this.lbOpt);
            this.Controls.Add(this.lbN1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.btDevide);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMenu);
            this.MaximizeBox = false;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอเครื่องคิดเลข - โปรเเกรม SAU Learning V.1.0";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btDevide;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lbN1;
        private System.Windows.Forms.Label lbOpt;
        private System.Windows.Forms.Label lbN2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbResult;
    }
}