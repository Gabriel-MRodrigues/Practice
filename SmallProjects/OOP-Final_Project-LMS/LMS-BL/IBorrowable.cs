using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_BL
{
    public interface IBorrowable
    {
        public abstract void Borrow(User user);
        public abstract void Return(User user);
    }
}
