using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Base Class for collection enumerators 
    /// Realization of IEnumerator interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Enumerator<T> : IEnumerator<T>
    {
        protected Collection<T> collection;
        protected int index;
        protected T current;

        public Enumerator() { }

        public Enumerator(Collection<T> collection)
        {
            this.collection = collection;
            index = -1;
            current = default(T);
        }
        public virtual T Current
        {
            get
            {
                return current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return current;
            }
        }

        public virtual void Dispose()
        {
            collection = null;
            current = default(T);
            index = -1;
        }
        public virtual bool MoveNext()
        {
            if (++index >= collection.Count)
            {
                return false;
            }
            else
            {
                current = (T)collection[index];
            }
            return true;
        }
        public virtual void Reset()
        {
            current = default(T);
            index = -1;
        }
    }

}
