using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstuctingClass
{
    class Door
    {
        public Door()
        {

        }

        private string mColor;

        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("Door Color is {0} " , mColor);
         
        }
    }
}
