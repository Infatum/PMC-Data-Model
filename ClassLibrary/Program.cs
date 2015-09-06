using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Position<int> p = new Position<int>();
            Point<int> point = new Point<int>(3, 18);
            Point<int> point2 = new Point<int>(19, 29);
            Console.WriteLine(p.Count);
            p.Add(point);
            p.Add(point2);
            Console.WriteLine(p.Count);
            Console.WriteLine(p.Contains(point2));
            p.Remove(point2);
            Console.WriteLine(p.Count);

            Console.WriteLine(p.Contains(point2));
            Console.ReadKey();
        }
    }
}
