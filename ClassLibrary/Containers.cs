using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Containers<T> : Collection<Container<T>> where T : struct
    {
        public override void Add(Container<T> coll)
        {
            collectArray.Add(coll);
        }

        public override Enumerator<Container<T>> Create()
        {
            return new ContainersEnumerator<T>(this);
        }
    }
}
