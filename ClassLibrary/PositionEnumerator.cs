using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
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
