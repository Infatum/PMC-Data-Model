using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Matrix enumerator class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MatrixEnumerator<T> : Enumerator<Position<T>> where T : struct
    {
        public MatrixEnumerator() { }

        public MatrixEnumerator(Matrix<T> collection)
        {
            this.collection = collection;
            index = -1;
            current = default(Position<T>);
        }
    }
}
