using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankGUI
{
    class Customer
    {
        private int customer_number;

        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string telephone_number { get; set; }

        Customer(string name, string address, int age, string telephone_number)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.telephone_number = telephone_number;
        }

        public Customer()
        {
            // Default constructor 
        }
    }

    class Customer_Adult : Customer
    {
        
    }

    class Customer_Student : Customer
    {

    }

    class Customer_Senior : Customer
    {

    }
}
