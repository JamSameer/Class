using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClass
{
  public  class Customer
    {
        public Customer()
        {

        }
        private string mFirstName;
        private string mLastName;
        private string mEmailID;
        private Address mHomeAddress;
        private Address mWorkAddress;
        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }

        }
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }

        }
        public string EmailID
        {
            get { return mEmailID; }
            set { mEmailID = value; }

        }
        public Address HomeAddress
        {
            get { return mHomeAddress; }
            set { mHomeAddress = value; }

        }
        public Address WorkAddress
        {
            get { return mWorkAddress; }
            set { mWorkAddress = value; }

        }
      public bool Validate()
        {
            return true;
        }
      public Customer Retrive(int id)
      {
          return new Customer();

      }
      public bool Save(Customer customer)
      {
          return true;
      }
    }
}
