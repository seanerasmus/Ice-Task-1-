using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexExample
{
    public class Employee
    {
        double salary;
        string empNumber, jobTittle, name, surname; // dont have direcct varibles 

        public Employee(string empNumber, string jobTitle, string name, string surname, double salary)
        {
            this.empNumber = empNumber;
            this.jobTittle = jobTitle;
            this.name = name;
            this.salary = salary;
        }
        public object this[int index]
        {
            get
            {

                if (index == 0)
                    return this.empNumber;

                else if (index == 1)
                    return this.jobTittle;

                else if (index == 2)
                    return this.surname;

                else if (index == 1)
                    return this.salary;
                return null;




            }
            set
            {
                if (index == 0)
                    this.empNumber = (string)value;

                else if (index == 1)
                    this.jobTittle = (string)value;

                else if (index == 2)
                    this.name = (string)value;

                else if (index == 3)
                    this.surname = (string)value;

                else if (index == 4)
                    this.salary = (double)value;

            }
        }
        public object this[string attrName]
        {
            get
            {

                if (attrName.ToLower().Equals("empnumber"))
                    return this.empNumber;
                if (attrName.ToLower().Equals("jobtitle"))
                    return this.jobTittle;
                if (attrName.ToLower().Equals("name"))
                    return this.empNumber;
                if (attrName.ToLower().Equals("surname"))
                    return this.surname;
                if (attrName.ToLower().Equals("salary"))
                    return this.salary;
                return null;



            }
            set
            {
                if (attrName.ToLower().Equals("empNumber"))
                    this.empNumber = (string)value;
                if (attrName.ToLower().Equals("jobTittle"))
                    this.jobTittle = (string)value;
                if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                if (attrName.ToLower().Equals("surname"))
                    this.surname = (string)value;
                if (attrName.ToLower().Equals(salary))
                    this.salary = (double)value;


            }
        }
    }
}