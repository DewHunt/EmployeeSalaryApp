using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Salary
    {
        public string employeeName;
        public double basicAmount;
        public double houseRentPercentage;
        public double medicalAllowancePercentage;

        public double CalculateSalary()
        {
            return (basicAmount + ((basicAmount * houseRentPercentage) / 100) + ((basicAmount * medicalAllowancePercentage) / 100));

        }

        public string ShowSalary()
        {
            return employeeName+" Your Salary = "+CalculateSalary();
        }
    }
}
