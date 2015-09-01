using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Enumerator for position collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PositionEnumerator<T> : Enumerator<Point<T>> where T : struct
    {
        public PositionEnumerator() { }

        public PositionEnumerator(Position<T> collection)
        {
            this.collection = collection;
            index = -1;
            current = default(Point<T>);
        }

    }
}
