using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2SanwichBuilder
{
    public class Customer
    {
        private string name;
        private string lastname;
        private string street;
        private string city;
        private string state;
        private double zipcode;
        private double phonenumber;
        private double customerTip;

        public Customer()
        {

        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public String Street
        {
            get { return street; }
            set { street = value; }
        }
        public String City
        {
            get { return city; }
            set { city = value; }
        }
        public String State
        {
            get { return state; }
            set { state = value; }
        }
        
        public Double Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        public Double PhoneNumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        public Double CustomerTip 
        {
            get { return customerTip; }
            set { customerTip = value; }
        }

    }


}
