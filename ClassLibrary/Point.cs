using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Point<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }

        public Point(T x, T y, T z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
