using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BL
{
    public class Student : User
    {
        public int BorrowLimit { get; private set; }
        public Student(string Name, int UserId) 
            : base (Name, UserId, "Student") 
        {
            this.BorrowLimit = 5; // default to 5
        }

        public override void DisplayRole()
        {
            Debug.WriteLine($"{this.Name} is a {this.Role}");
        }
    }
}
