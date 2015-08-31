using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Matrix<T> : Collection<Position<T>> where T : struct
    {
        public override void Add(Position<T> coll)
        {
            collectArray.Add(coll);
        }
        public override Enumerator<Position<T>> Create()
        {
            return new MatrixEnumerator<T>(this);
        }
    }
}
