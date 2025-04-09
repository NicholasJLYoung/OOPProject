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
            Title = new DataGridViewTextBoxColumn();
            Availablility = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
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
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Title, Availablility, Author });
            dgvBooks.Location = new Point(12, 12);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(476, 258);
            dgvBooks.TabIndex = 0;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // Availablility
            // 
            Availablility.HeaderText = "Availability";
            Availablility.Name = "Availablility";
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.Name = "Author";
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(9, 276);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(75, 23);
            btnBorrow.TabIndex = 1;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(90, 276);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(171, 276);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // cboUsers
            // 
            cboUsers.FormattingEnabled = true;
            cboUsers.Location = new Point(350, 277);
            cboUsers.Name = "cboUsers";
            cboUsers.Size = new Size(121, 23);
            cboUsers.TabIndex = 4;
            cboUsers.SelectedIndexChanged += cboUsers_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(252, 277);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(cboUsers);
            Controls.Add(btnAdd);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(dgvBooks);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBooks;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Availablility;
        private DataGridViewTextBoxColumn Author;
        private Button btnBorrow;
        private Button btnReturn;
        private Button btnAdd;
        private ComboBox cboUsers;
        private Button btnClose;
    }
}
