using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    class Employee
    {
        private int _eno;
        private string _name;
        protected double _basic;

        public Employee(int eno, string name, double basic)
        {
            _eno = eno;
            _name = name;
            _basic = basic;
        }

        public int EmpNo
        {
            get
            {
                return _eno;
            }
        }

        public string EmpName
        {
            get
            {
                return _name;
            }
        }

        public double EmpBasicSal
        {
            get
            {
                return _basic;
            }
        }

        public virtual double CalculateCTC(){
            return _basic;
        }

        public virtual string GenerateCTCDetails() {
            return "Role: Emp" + " Basic Sal: " + _basic;
        }
    }
}
