using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Container<T> : Collection<Matrix<T>> where T : struct
    {
        public override void Add(Matrix<T> coll)
        {
            collectArray.Add(coll);
        }

        public override Enumerator<Matrix<T>> Create()
        {
            return new ContainerEnumerator<T>(this);
        }
    }
}
