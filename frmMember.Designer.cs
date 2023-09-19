namespace Library
{
    partial class frmMember
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
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxMember = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ListViewMember = new System.Windows.Forms.ListView();
            this.colMemberName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMemberCellPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMemberId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLibraryId = new System.Windows.Forms.TextBox();
            this.lblLibraryId = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBoxMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 26);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxMember
            // 
            this.groupBoxMember.Controls.Add(this.btnRemove);
            this.groupBoxMember.Controls.Add(this.btnAdd);
            this.groupBoxMember.Controls.Add(this.ListViewMember);
            this.groupBoxMember.Controls.Add(this.txtLibraryId);
            this.groupBoxMember.Controls.Add(this.lblLibraryId);
            this.groupBoxMember.Controls.Add(this.txtCellPhone);
            this.groupBoxMember.Controls.Add(this.lblCellPhone);
            this.groupBoxMember.Controls.Add(this.txtLastName);
            this.groupBoxMember.Controls.Add(this.lblLastName);
            this.groupBoxMember.Controls.Add(this.txtName);
            this.groupBoxMember.Controls.Add(this.lblName);
            this.groupBoxMember.Location = new System.Drawing.Point(12, 68);
            this.groupBoxMember.Name = "groupBoxMember";
            this.groupBoxMember.Size = new System.Drawing.Size(767, 257);
            this.groupBoxMember.TabIndex = 15;
            this.groupBoxMember.TabStop = false;
            this.groupBoxMember.Text = "اطلاعات مربوط به اعضاء";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(543, 209);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 30);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "حذف";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(654, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ListViewMember
            // 
            this.ListViewMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMemberName,
            this.colLastName,
            this.colMemberCellPhone,
            this.colMemberId});
            this.ListViewMember.HideSelection = false;
            this.ListViewMember.Location = new System.Drawing.Point(19, 19);
            this.ListViewMember.Name = "ListViewMember";
            this.ListViewMember.Size = new System.Drawing.Size(518, 165);
            this.ListViewMember.TabIndex = 8;
            this.ListViewMember.UseCompatibleStateImageBehavior = false;
            this.ListViewMember.View = System.Windows.Forms.View.Details;
            // 
            // colMemberName
            // 
            this.colMemberName.Text = "نام";
            this.colMemberName.Width = 120;
            // 
            // colLastName
            // 
            this.colLastName.Text = "نام خانوادگی";
            this.colLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLastName.Width = 120;
            // 
            // colMemberCellPhone
            // 
            this.colMemberCellPhone.Text = "شماره تلفن";
            this.colMemberCellPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMemberCellPhone.Width = 120;
            // 
            // colMemberId
            // 
            this.colMemberId.Text = "کد اشتراک";
            this.colMemberId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMemberId.Width = 120;
            // 
            // txtLibraryId
            // 
            this.txtLibraryId.Location = new System.Drawing.Point(543, 164);
            this.txtLibraryId.MaxLength = 10;
            this.txtLibraryId.Name = "txtLibraryId";
            this.txtLibraryId.Size = new System.Drawing.Size(100, 20);
            this.txtLibraryId.TabIndex = 7;
            this.txtLibraryId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLibraryId_KeyDown);
            this.txtLibraryId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLibraryId_KeyPress);
            // 
            // lblLibraryId
            // 
            this.lblLibraryId.AutoSize = true;
            this.lblLibraryId.Location = new System.Drawing.Point(696, 167);
            this.lblLibraryId.Name = "lblLibraryId";
            this.lblLibraryId.Size = new System.Drawing.Size(53, 13);
            this.lblLibraryId.TabIndex = 6;
            this.lblLibraryId.Text = "کد اشتراک";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(543, 121);
            this.txtCellPhone.MaxLength = 11;
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCellPhone.TabIndex = 5;
            this.txtCellPhone.Click += new System.EventHandler(this.txtCellPhone_Click);
            this.txtCellPhone.TextChanged += new System.EventHandler(this.txtCellPhone_TextChanged);
            this.txtCellPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellPhone_KeyPress);
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(691, 124);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(58, 13);
            this.lblCellPhone.TabIndex = 4;
            this.lblCellPhone.Text = "شماره تلفن";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(543, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(680, 81);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(543, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(729, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام";
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxMember);
            this.Name = "frmMember";
            this.Text = "FrmMember";
            this.groupBoxMember.ResumeLayout(false);
            this.groupBoxMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxMember;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView ListViewMember;
        private System.Windows.Forms.ColumnHeader colMemberName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colMemberCellPhone;
        private System.Windows.Forms.ColumnHeader colMemberId;
        private System.Windows.Forms.TextBox txtLibraryId;
        private System.Windows.Forms.Label lblLibraryId;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}