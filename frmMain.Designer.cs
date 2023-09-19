namespace Library
{
    partial class frmMain
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
            this.btnMember = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMember
            // 
            this.btnMember.AutoEllipsis = true;
            this.btnMember.BackColor = System.Drawing.Color.White;
            this.btnMember.Location = new System.Drawing.Point(306, 228);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(189, 40);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "مدیریت اعضاء";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(306, 182);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(189, 40);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "مدیریت کتاب";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnBook);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnBook;
    }
}