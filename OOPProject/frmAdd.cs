using LMSBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class frmAdd : Form
    {
        public Book bookAdd;
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text != "" && txtTitle.Text != "")
            {
                bookAdd = new Book();
                bookAdd.Author = txtAuthor.Text;
                bookAdd.Title = txtTitle.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("All fields must be filled out.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
