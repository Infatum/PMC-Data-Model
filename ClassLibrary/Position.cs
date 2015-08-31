using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassLibrary
{
    public class Position<T> : Collection<Point<T>> where T : struct
    {
        public override void Add(Point<T> point)
        {
            collectArray.Add(point);
        }
        public override Enumerator<Point<T>> Create()
        {
            return new PositionEnumerator<T>(this);
        }

    }
}
