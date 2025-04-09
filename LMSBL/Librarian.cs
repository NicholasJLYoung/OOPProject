using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public class Librarian : User
    {
        public override void DisplayRole()
        {
            Debug.WriteLine($"{Name} is a Librarian");
        }
        
        public Librarian(string name, int id, string role)
        {
            this.Name = name;
            this.UserID = id;
            this.Role = role;
        }
    }
}
