using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class Student : User
    {
        public int BorrowLimit { get; } = 5;
        public override void DisplayRole()
        {
            Debug.WriteLine($"{Name} is a Student");
        }

        public Student(string name, int id, string role)
        {
            this.Name = name;
            this.UserID = id;
            this.Role = role;
        }
    }
}
