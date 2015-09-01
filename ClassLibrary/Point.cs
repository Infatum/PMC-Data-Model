using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Generic point class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Point<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }

        /// <summary>
        /// 3d constructor of a point
        /// Initializates a 3 dimentional presentation of a point
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point(T x, T y, T z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        /// <summary>
        /// 2d constructor of a point
        ///  Initializates a 2 dimentional presentation of a point
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
