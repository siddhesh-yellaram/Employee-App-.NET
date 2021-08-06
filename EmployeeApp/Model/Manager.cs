using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    class Manager:Employee
    {
        private double HRA, TA;
        public Manager(int eno, string name, double basic):base(eno,name,basic)
        {
            HRA = 0.5* _basic;
            TA = 0.4 * _basic;
        }

        public override double CalculateCTC()
        {
            return HRA + TA + _basic;
        }

        public override string GenerateCTCDetails()
        {
            return "Role: Manager" + "\nBasic Sal: " + _basic + "\nHRA: " + HRA + "\nTA: " + TA;
        }
    }
}
