using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClass
{
    class Product
    {
        public Product()
        {

        }
        private string mProductName;
        private string mDescription;
        private float mCurrentPrice;
        public string ProductName
        {
            get { return mProductName; }
            set { mProductName = value; }
        }
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }
        public float CurrentPrice
        {
            get { return mCurrentPrice; }
            set { mCurrentPrice = value; }
        }
        public bool Validate()
        {
            return true;
        }
        public Product Retrive(int id)
        {
            return new Product();
        }
        public bool Save(Product product)
        {
            return true;
        }
    }
}
