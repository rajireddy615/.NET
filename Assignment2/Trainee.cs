using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    
        public class Trainee : Employee
        {
            public Trainee(long id, string name, string address, long phone, double salary)
                : base(id, name, address, phone, salary)
            {
            }

            public object EmployeeName { get; internal set; }
        }
    
}
