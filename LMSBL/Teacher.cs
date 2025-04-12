using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class Teacher : User
    {
        public int BorrowLimit { get; set; } = 10;
        public override void DisplayRole()
        {
            Debug.WriteLine($"{Name} is a Teacher");
        }

        public Teacher(string name, int id, string role)
        {
            this.Name = name;
            this.UserID = id;
            this.Role = role;
        }
    }
}
