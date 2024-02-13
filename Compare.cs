using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    public class Compare
    {
        public static int Sort(StudentModel s1, StudentModel s2)
        {
            return s1.Id.CompareTo(s2.Id);
        }
    }
}
