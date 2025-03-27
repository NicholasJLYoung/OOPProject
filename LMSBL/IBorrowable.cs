using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSBL
{
    public interface IBorrowable
    {
        public abstract void Borrow();
        public abstract void Return();
    }
}
