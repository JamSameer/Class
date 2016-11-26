using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClass
{
    class Main
    {
        static void Main(string[] args)
        {
            Customer custum = new Customer();
            custum.FirstName = "Sameer";
            custum.LastName = "Khan";
            custum.EmailID = "sameer@jamsons.in";
            custum.HomeAddress = "Dandeli";
            custum.WorkAddress = "Bangalore";
        }
    }
}
