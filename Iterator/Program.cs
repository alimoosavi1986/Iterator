using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreateAggregate list = new ConcreateAggregate();
            list[0] = "Item 1";
            list[1] = "Item 2";
            list[2] = "Item 3";
            list[3] = "Item 4";

            IIterator iterator = list.CreateIterator();

            object item = iterator.First();

            while (item != null)
            {
                Console.WriteLine($"Find Item:{item}");
                item = iterator.Next();
            }

            Console.Read();


        }
    }
}
