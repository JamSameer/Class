using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstuctingClass
{
   public class NewHouse
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Area = 1300.0f;
            house.Showdata();
            Door door = new Door();
            door.Color = "Pink";
            door.ShowData();
            AnotherHouse anotherhouse = new AnotherHouse();
            anotherhouse.Area = 1200.0f;
            anotherhouse.Color = "yello";
            anotherhouse.Showdata();

            Console.ReadLine();
        }
       
    }
}
