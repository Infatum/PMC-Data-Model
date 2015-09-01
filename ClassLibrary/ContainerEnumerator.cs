using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
/// <summary>
/// An enumerator for container collection
/// </summary>
/// <typeparam name="T"></typeparam>
    public class ContainerEnumerator<T> : Enumerator<Matrix<T>> where T : struct
    {
        public ContainerEnumerator() { }
        /// <summary>
        /// Initialization of Container collection that implements a collection of matrixes 
        /// </summary>
        /// <param name="matrix"></param>
        public ContainerEnumerator(Container<T> matrix)
        {
            this.collection = matrix;
            index = -1;
            current = default(Matrix<T>);
        }
    }
}
