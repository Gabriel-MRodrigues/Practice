using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BL
{
    public class Teacher : User
    {
        public int BorrowLimit { get; private set; }
        public Teacher(string Name, int UserId)
            : base (Name, UserId, "Teacher") 
        {
            this.BorrowLimit = 10; // default to 10;
        }

        public override void DisplayRole()
        {
            Debug.WriteLine($"{this.Name} is a {this.Role}");
        }
    }
}
