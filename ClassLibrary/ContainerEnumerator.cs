using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ContainerEnumerator<T> : Enumerator<Matrix<T>> where T : struct
    {
        public ContainerEnumerator() { }
        public ContainerEnumerator(Container<T> matrix)
        {
            this.collection = matrix;
            index = -1;
            current = default(Matrix<T>);
        }
    }
}
