namespace Library
{
    partial class frmBook
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.ListViewBook = new System.Windows.Forms.ListView();
            this.colBookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookAurthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookSummery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBookStatus = new System.Windows.Forms.TextBox();
            this.lblBookStatus = new System.Windows.Forms.Label();
            this.txtBookSummery = new System.Windows.Forms.TextBox();
            this.lblBookSummery = new System.Windows.Forms.Label();
            this.txtBookAurthor = new System.Windows.Forms.TextBox();
            this.lblBookAurthor = new System.Windows.Forms.Label();
            this.txtbookId = new System.Windows.Forms.TextBox();
            this.lblbookId = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.groupBoxBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 26);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(555, 391);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 30);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "حذف";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(666, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.ListViewBook);
            this.groupBoxBook.Controls.Add(this.txtBookStatus);
            this.groupBoxBook.Controls.Add(this.lblBookStatus);
            this.groupBoxBook.Controls.Add(this.txtBookSummery);
            this.groupBoxBook.Controls.Add(this.lblBookSummery);
            this.groupBoxBook.Controls.Add(this.txtBookAurthor);
            this.groupBoxBook.Controls.Add(this.lblBookAurthor);
            this.groupBoxBook.Controls.Add(this.txtbookId);
            this.groupBoxBook.Controls.Add(this.lblbookId);
            this.groupBoxBook.Controls.Add(this.txtBookName);
            this.groupBoxBook.Controls.Add(this.lblBookName);
            this.groupBoxBook.Location = new System.Drawing.Point(12, 68);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(767, 317);
            this.groupBoxBook.TabIndex = 14;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "اطلاعات مربوط به کتاب";
            // 
            // ListViewBook
            // 
            this.ListViewBook.AllowDrop = true;
            this.ListViewBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListViewBook.AutoArrange = false;
            this.ListViewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBookId,
            this.colBookName,
            this.colBookAurthor,
            this.colBookSummery,
            this.colBookStatus});
            this.ListViewBook.FullRowSelect = true;
            this.ListViewBook.HideSelection = false;
            this.ListViewBook.Location = new System.Drawing.Point(25, 35);
            this.ListViewBook.Name = "ListViewBook";
            this.ListViewBook.Size = new System.Drawing.Size(512, 276);
            this.ListViewBook.TabIndex = 10;
            this.ListViewBook.UseCompatibleStateImageBehavior = false;
            this.ListViewBook.View = System.Windows.Forms.View.Details;
            // 
            // colBookId
            // 
            this.colBookId.Text = "کد";
            // 
            // colBookName
            // 
            this.colBookName.Text = "اسم";
            this.colBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBookName.Width = 75;
            // 
            // colBookAurthor
            // 
            this.colBookAurthor.Text = "نویسنده";
            this.colBookAurthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colBookSummery
            // 
            this.colBookSummery.Text = "مختصر توضیح";
            this.colBookSummery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBookSummery.Width = 200;
            // 
            // colBookStatus
            // 
            this.colBookStatus.Text = "وضعیت موجودی";
            this.colBookStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBookStatus.Width = 120;
            // 
            // txtBookStatus
            // 
            this.txtBookStatus.Location = new System.Drawing.Point(543, 255);
            this.txtBookStatus.Name = "txtBookStatus";
            this.txtBookStatus.Size = new System.Drawing.Size(100, 20);
            this.txtBookStatus.TabIndex = 9;
            this.txtBookStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBookStatus
            // 
            this.lblBookStatus.AutoSize = true;
            this.lblBookStatus.Location = new System.Drawing.Point(667, 258);
            this.lblBookStatus.Name = "lblBookStatus";
            this.lblBookStatus.Size = new System.Drawing.Size(82, 13);
            this.lblBookStatus.TabIndex = 8;
            this.lblBookStatus.Text = "وضعیت موجودی";
            // 
            // txtBookSummery
            // 
            this.txtBookSummery.Location = new System.Drawing.Point(543, 190);
            this.txtBookSummery.Multiline = true;
            this.txtBookSummery.Name = "txtBookSummery";
            this.txtBookSummery.Size = new System.Drawing.Size(206, 42);
            this.txtBookSummery.TabIndex = 7;
            this.txtBookSummery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBookSummery
            // 
            this.lblBookSummery.AutoSize = true;
            this.lblBookSummery.Location = new System.Drawing.Point(678, 167);
            this.lblBookSummery.Name = "lblBookSummery";
            this.lblBookSummery.Size = new System.Drawing.Size(71, 13);
            this.lblBookSummery.TabIndex = 6;
            this.lblBookSummery.Text = "توضیح مختصر";
            // 
            // txtBookAurthor
            // 
            this.txtBookAurthor.Location = new System.Drawing.Point(543, 121);
            this.txtBookAurthor.Name = "txtBookAurthor";
            this.txtBookAurthor.Size = new System.Drawing.Size(100, 20);
            this.txtBookAurthor.TabIndex = 5;
            this.txtBookAurthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBookAurthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookAurthor_KeyPress);
            // 
            // lblBookAurthor
            // 
            this.lblBookAurthor.AutoSize = true;
            this.lblBookAurthor.Location = new System.Drawing.Point(704, 124);
            this.lblBookAurthor.Name = "lblBookAurthor";
            this.lblBookAurthor.Size = new System.Drawing.Size(45, 13);
            this.lblBookAurthor.TabIndex = 4;
            this.lblBookAurthor.Text = "نویسنده";
            // 
            // txtbookId
            // 
            this.txtbookId.Location = new System.Drawing.Point(543, 78);
            this.txtbookId.MaxLength = 5;
            this.txtbookId.Name = "txtbookId";
            this.txtbookId.Size = new System.Drawing.Size(100, 20);
            this.txtbookId.TabIndex = 3;
            this.txtbookId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbookId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbookId_KeyPress);
            // 
            // lblbookId
            // 
            this.lblbookId.AutoSize = true;
            this.lblbookId.Location = new System.Drawing.Point(730, 81);
            this.lblbookId.Name = "lblbookId";
            this.lblbookId.Size = new System.Drawing.Size(19, 13);
            this.lblbookId.TabIndex = 2;
            this.lblbookId.Text = "کد";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(543, 35);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookName_KeyPress);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(729, 38);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(20, 13);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "نام";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxBook);
            this.Name = "frmBook";
            this.Text = "frmBook";
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.ListView ListViewBook;
        private System.Windows.Forms.ColumnHeader colBookId;
        private System.Windows.Forms.ColumnHeader colBookName;
        private System.Windows.Forms.ColumnHeader colBookAurthor;
        private System.Windows.Forms.ColumnHeader colBookSummery;
        private System.Windows.Forms.ColumnHeader colBookStatus;
        private System.Windows.Forms.TextBox txtBookStatus;
        private System.Windows.Forms.Label lblBookStatus;
        private System.Windows.Forms.TextBox txtBookSummery;
        private System.Windows.Forms.Label lblBookSummery;
        private System.Windows.Forms.TextBox txtBookAurthor;
        private System.Windows.Forms.Label lblBookAurthor;
        private System.Windows.Forms.TextBox txtbookId;
        private System.Windows.Forms.Label lblbookId;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
    }
}

