using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.Model;
using System.IO;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager(101, "Sid", 600000);
            Developer d1 = new Developer(106, "Tom", 500000);
            Analyst a1 = new Analyst(108, "Steve", 450000);
            PrintEmployeeDetails(m1);
            PrintEmployeeDetails(d1);
            PrintEmployeeDetails(a1);
            PrintEmpDetailsToFile(m1);
            PrintEmpDetailsToFile(d1);
            PrintEmpDetailsToFile(a1);
            Console.ReadLine();
        }

        static void PrintEmployeeDetails(Employee emp)
        {
            Console.WriteLine("\nTotal CTC Offered: " + emp.CalculateCTC());
            Console.WriteLine(emp.GenerateCTCDetails());
        }

        static void PrintEmpDetailsToFile(Employee emp)
        {
            using (FileStream fs = new FileStream("D:\\test\\.NET\\" + emp.EmpName + ".html", FileMode.Create))
            {
                using(StreamWriter st = new StreamWriter(fs, Encoding.UTF8))
                {
                    st.WriteLine("<h1>" + emp.EmpName + "</h1>");
                    st.WriteLine("<p>" + emp.GenerateCTCDetails() + "</p>");
                    st.WriteLine("<p> Total CTC Offered: " + emp.CalculateCTC() + "</p>");
                }
            }
        }
    }
}
