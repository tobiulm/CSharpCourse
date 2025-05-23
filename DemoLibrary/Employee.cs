using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Employee : Person
    {
        private Guid _employeeId;
        private string _jobTitle;
        private decimal _salary;
        private string _department;

        public Guid EmployeeId { get => _employeeId;  }
        public string JobTitle { get => _jobTitle; set => _jobTitle = value; }
        public decimal Salary { get => _salary;  }
        public string Department { get => _department; set { _department = value; SetSalary(); }  }

        public Employee():this(string.Empty, string.Empty, string.Empty, string.Empty)
        {

        }

        public Employee(string firstName, string lastName, string department, string jobTitle) : this(firstName, lastName, new DateOnly(1980,1,1), Gender.Unknown, "", "")
        {
            
        }

        public Employee(string firstName, string lastName, DateOnly dateOfBirth, Gender gender, string department, string jobTitle):base(firstName, lastName, dateOfBirth, gender)
        {
            Department = department;
            _jobTitle = jobTitle;
            _employeeId = Guid.NewGuid();
        }

        private void SetSalary()
        {
            switch(_department)
            {
                case "Prodution":
                    _salary = 50000;
                    break;
                case "Management":
                    _salary = 100000;
                    break;
                case "IT":
                    _salary = 80000;
                    break;
                    case "HR":
                    _salary = 60000;
                    break;
                default:
                    _salary = 40000;
                    break;
            }
        }

        public override string SayHello()
        {
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("###############################################################################################################");
            sb.AppendLine(base.SayHello());
            sb.AppendLine($"I work in the {_department} department as {_jobTitle}.");
            sb.AppendLine($"My employee ID is {_employeeId}.");
            sb.AppendLine("###############################################################################################################");
            return sb.ToString();
        }

    }
}
