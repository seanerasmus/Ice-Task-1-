using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexExample
{
    public class Customer
    {
        string customerID, name, email, phone;
        double balance;

        public Customer(string customerID, string name, string email, string phone, double balance)
        {
            this.customerID = customerID;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.balance = balance;
        }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return customerID;
                    case 1: return name;
                    case 2: return email;
                    case 3: return phone;
                    case 4: return balance;
                    default: return null;
                }
            }
            set
            {
                switch (index)
                {
                    case 0: customerID = (string)value; break;
                    case 1: name = (string)value; break;
                    case 2: email = (string)value; break;
                    case 3: phone = (string)value; break;
                    case 4: balance = (double)value; break;
                }
            }
        }

        public object this[string attrName]
        {
            get
            {
                switch (attrName.ToLower())
                {
                    case "customerid": return customerID;
                    case "name": return name;
                    case "email": return email;
                    case "phone": return phone;
                    case "balance": return balance;
                    default: return null;
                }
            }
            set
            {
                switch (attrName.ToLower())
                {
                    case "customerid": customerID = (string)value; break;
                    case "name": name = (string)value; break;
                    case "email": email = (string)value; break;
                    case "phone": phone = (string)value; break;
                    case "balance": balance = (double)value; break;
                }
            }
        }
    }
}