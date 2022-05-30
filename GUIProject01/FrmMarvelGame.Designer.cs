
namespace GUIProject01
{
    partial class FrmMarvelGame
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
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMenu.ForeColor = System.Drawing.Color.Blue;
            this.tbMenu.Location = new System.Drawing.Point(12, 12);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Size = new System.Drawing.Size(99, 75);
            this.tbMenu.TabIndex = 3;
            this.tbMenu.Text = "MENU";
            this.tbMenu.UseVisualStyleBackColor = true;
            this.tbMenu.Click += new System.EventHandler(this.tbMenu_Click);
            // 
            // FrmMarvelGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMenu);
            this.MaximizeBox = false;
            this.Name = "FrmMarvelGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอMarvel Game - โปรเเกรม SAU Learning V.1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tbMenu;
    }
}