using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    class Developer:Employee
    {
        private double ProjAllowance, PA;
        public Developer(int eno, string name, double basic) : base(eno, name, basic)
        {
            ProjAllowance = 0.4 * _basic;
            PA = 0.3 * _basic;
        }

        public override double CalculateCTC()
        {
            return ProjAllowance + PA + _basic;
        }

        public override string GenerateCTCDetails()
        {
            return "Role: Developer" + "\nBasic Sal: " + _basic + "\nProject Allowance: " + ProjAllowance + "\nPA: " + PA;
        }
    }
}
