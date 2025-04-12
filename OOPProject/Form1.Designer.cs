namespace OOPProject
{
    partial class Form1
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
            dgvBooks = new DataGridView();
            btnBorrow = new Button();
            btnReturn = new Button();
            btnAdd = new Button();
            cboUsers = new ComboBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(17, 20);
            dgvBooks.Margin = new Padding(4, 5, 4, 5);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.Size = new Size(680, 430);
            dgvBooks.TabIndex = 0;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(13, 460);
            btnBorrow.Margin = new Padding(4, 5, 4, 5);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(107, 38);
            btnBorrow.TabIndex = 1;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(129, 460);
            btnReturn.Margin = new Padding(4, 5, 4, 5);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(107, 38);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(244, 460);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboUsers
            // 
            cboUsers.FormattingEnabled = true;
            cboUsers.Location = new Point(500, 462);
            cboUsers.Margin = new Padding(4, 5, 4, 5);
            cboUsers.Name = "cboUsers";
            cboUsers.Size = new Size(171, 33);
            cboUsers.TabIndex = 4;
            cboUsers.SelectedIndexChanged += cboUsers_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(360, 462);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 519);
            Controls.Add(btnClose);
            Controls.Add(cboUsers);
            Controls.Add(btnAdd);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(dgvBooks);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBooks;
        private Button btnBorrow;
        private Button btnReturn;
        private Button btnAdd;
        private ComboBox cboUsers;
        private Button btnClose;
    }
}
