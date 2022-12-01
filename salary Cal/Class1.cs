using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary_Cal
{
    internal class Class1
    {
        static string EmployeeName;
        public static string employeeName
        {
            get
            {
                return EmployeeName;
            }
            set
            {
                EmployeeName = value;
            }
        }
    }
}
