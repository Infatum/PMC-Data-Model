using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Container enumerator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ContainersEnumerator<T> : Enumerator<Container<T>> where T : struct
    {
        public ContainersEnumerator() { }

        public ContainersEnumerator(Containers<T> collection)
        {
            this.collection = collection;
            index = -1;
            current = default(Container<T>);
        }
    }
}
