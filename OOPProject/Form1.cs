using LMSBL;

namespace OOPProject
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian("Steve", 1, "Librarian");
            Teacher teacher = new Teacher("Bob", 2, "Teacher");
            Student student = new Student("John", 3, "Student");
            List<User> users = new List<User>();
            users.Add(librarian);
            users.Add(teacher);
            users.Add(student);
            
            cboUsers.DataSource = users;
            cboUsers.ValueMember = "name";
        }

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsers.SelectedValue == "Steve")
            {
                dgvBooks.ReadOnly = false;
                btnAdd.Enabled = true;
            }
            else
            {
                dgvBooks.ReadOnly = true;
                btnAdd.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
