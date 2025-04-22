using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BL
{
    public class Librarian : User
    {
        public Librarian(string Name, int UserId)
            : base (Name, UserId, "Librarian") 
        {
        }
        public override void DisplayRole()
        {
            Debug.WriteLine($"{this.Name} is a {this.Role}");
        }
    }
}
