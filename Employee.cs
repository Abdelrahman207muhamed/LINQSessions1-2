using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSessions1_2
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Salary:{Salary}";
        }

    }
}
