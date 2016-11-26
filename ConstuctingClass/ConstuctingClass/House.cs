using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstuctingClass
{
    class House
    {
        public House()
        {
            
        }
        private float mArea;
        public float Area
        {
            get { return mArea; }
            set { mArea = value; }
        }
        public void Showdata()
        {
            Console.WriteLine("My Area is {0}",mArea);
        }
    }
}
