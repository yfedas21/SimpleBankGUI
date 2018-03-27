using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankGUI
{
    class Account
    {
        protected int account_number;
        protected Customer customer { get; set; }
        protected double balance { get; set; }
        protected List<Transaction> transactions { get; set; }

        public Account(Customer customer, int id)
        {
            this.customer = customer;
            this.account_number = id;
        }
    }

    class Account_Checking : Account {
        
    }

    class Account_Savings : Account {
        
    }                                       
}
