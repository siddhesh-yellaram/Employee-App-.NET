using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    class Analyst:Employee
    {
        private double perks;
        public Analyst(int eno, string name, double basic) : base(eno, name, basic)
        {
            perks = 0.3 * _basic;
        }
        public override double CalculateCTC()
        {
            return perks + _basic;
        }

        public override string GenerateCTCDetails()
        {
            return "Role: Analyst" + "\nBasic Sal: " + _basic + "\nPerks: " + perks;
        }
    }
}
