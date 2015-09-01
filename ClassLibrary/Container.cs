using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Container<T> : Collection<Matrix<T>> where T : struct
    {
        /// <summary>
        /// Adding an element to a matrix
        /// </summary>
        /// <param name="coll"></param>
        public override void Add(Matrix<T> coll)
        {
            collectArray.Add(coll);
        }
        /// <summary>
        /// Creating an enumerator for matrix collection
        /// </summary>
        /// <returns></returns>
        public override Enumerator<Matrix<T>> Create()
        {
            return new ContainerEnumerator<T>(this);
        }
    }
}
