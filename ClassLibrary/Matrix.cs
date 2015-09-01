using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Matrix collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Matrix<T> : Collection<Position<T>> where T : struct
    {
        /// <summary>
        /// Matrix  Add method 
        /// </summary>
        /// <param name="coll"></param>
        public override void Add(Position<T> coll)
        {
            collectArray.Add(coll);
        }
        /// <summary>
        /// Matrix enumerator
        /// </summary>
        /// <returns></returns>
        public override Enumerator<Position<T>> Create()
        {
            return new MatrixEnumerator<T>(this);
        }
    }
}
