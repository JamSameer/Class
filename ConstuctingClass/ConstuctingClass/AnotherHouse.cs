using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstuctingClass
{
    class AnotherHouse
    {
        public AnotherHouse()
        {
            float area;
        }
        private float mArea;
        public float Area
        {
            get { return mArea; }
            set { mArea = value; }
        }
        private string mColor;

        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        public void Showdata()
        {
            Console.WriteLine("My Area is {0}", mArea);
            Console.WriteLine("Color is {0}", mColor);
        }
    }
}
