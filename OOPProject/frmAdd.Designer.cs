namespace OOPProject
{
    partial class frmAdd
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
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 31);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 79);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Author:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(120, 31);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(312, 31);
            txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(120, 79);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(312, 31);
            txtAuthor.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(120, 134);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(282, 134);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 206);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAdd";
            Text = "Add New Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Button btnAdd;
        private Button btnCancel;
    }
}