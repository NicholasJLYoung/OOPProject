using LMSBL;
using System.ComponentModel;

namespace OOPProject
{
    public partial class Form1 : Form
    {
        BindingList<Book> books = new BindingList<Book>();

        private Book bookAdd;

        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian("Steve - Librarian", 1, "Librarian");
            Teacher teacher = new Teacher("Bob - Teacher", 2, "Teacher");
            Student student = new Student("John - Student", 3, "Student");
            users.Add(librarian);
            users.Add(teacher);
            users.Add(student);

            cboUsers.DataSource = users;
            cboUsers.ValueMember = "role";
            cboUsers.DisplayMember = "name";
            btnAdd.Enabled = true;

            Book book = new Book();
            book.Title = "Eragon";
            book.Author = "Christopher Paolini";
            books.Add(book);
            Book book2 = new Book();
            book2.Title = "The Hobbit";
            book2.Author = "J.R.R. Tolkein";
            books.Add(book2);
            Book book3 = new Book();
            book3.Title = "A Game of Thrones";
            book3.Author = "George R.R. Martin";
            books.Add(book3);
            Book book4 = new Book();
            book4.Title = "Artemis Fowl";
            book4.Author = "Eoin Colfer";
            books.Add(book4);
            Book book5 = new Book();
            book5.Title = "The Hunger Games";
            book5.Author = "Suzanne Collins";
            books.Add(book5);
            Book book6 = new Book();
            book6.Title = "The Maze Runner";
            book6.Author = "James Dashner";
            books.Add(book6);

            dgvBooks.DataSource = books;
            dgvBooks.Columns[3].Visible = false;
            dgvBooks.AutoResizeColumns();
        }

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsers.SelectedValue == "Librarian")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd();
            DialogResult result = frmAdd.ShowDialog();

            if (result == DialogResult.OK)
            {
                books.Add(frmAdd.bookAdd);
                dgvBooks.AutoResizeColumns();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow.Cells[2].Value.Equals(true))
            {
                if (cboUsers.SelectedValue == "Librarian")
                {
                    books[dgvBooks.CurrentRow.Index].Borrow(users[cboUsers.SelectedIndex]);
                    books[dgvBooks.CurrentRow.Index].BorrowedBy = users[cboUsers.SelectedIndex].UserID;
                }
                else if (cboUsers.SelectedValue == "Teacher")
                {
                    if (((Teacher)users[cboUsers.SelectedIndex]).BorrowLimit > 0)
                    {
                        books[dgvBooks.CurrentRow.Index].Borrow(users[cboUsers.SelectedIndex]);
                        books[dgvBooks.CurrentRow.Index].BorrowedBy = users[cboUsers.SelectedIndex].UserID;
                        ((Teacher)users[cboUsers.SelectedIndex]).BorrowLimit--;
                    }
                    else
                    {
                        MessageBox.Show("User has already borrowed their limit");
                    }
                }
                else if (cboUsers.SelectedValue == "Student")
                {
                    if (((Student)users[cboUsers.SelectedIndex]).BorrowLimit > 0)
                    {
                        books[dgvBooks.CurrentRow.Index].Borrow(users[cboUsers.SelectedIndex]);
                        books[dgvBooks.CurrentRow.Index].BorrowedBy = users[cboUsers.SelectedIndex].UserID;
                        ((Student)users[cboUsers.SelectedIndex]).BorrowLimit--;
                    }
                    else
                    {
                        MessageBox.Show("User has already borrowed their limit");
                    }
                }
            }
            else
            {
                MessageBox.Show($"{dgvBooks.CurrentRow.Cells[0].Value} is not currently available");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow.Cells[2].Value.Equals(false))
            {
                User user = (User)users[users.IndexOf(users.First(s => s.UserID == books[dgvBooks.CurrentRow.Index].BorrowedBy))];
                books[dgvBooks.CurrentRow.Index].BorrowedBy = null;
                books[dgvBooks.CurrentRow.Index].Return(user);

                if (user is Teacher)
                {
                    ((Teacher)user).BorrowLimit++;
                }
                else if (user is Student)
                {
                    ((Student)user).BorrowLimit++;    
                }
            }
            else
            {
                MessageBox.Show($"{dgvBooks.CurrentRow.Cells[0].Value} cannot be returned before being borrowed");
            }
        }
    }
}
