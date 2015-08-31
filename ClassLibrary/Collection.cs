using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// abstract BaseClass, which 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Collection<T> : ICollection<T>
    {
        protected ArrayList collectArray;
        protected bool isReadOnly;

        public Collection()
        {
            collectArray = new ArrayList();
        }

        public virtual T this[int index]
        {
            get { return (T)collectArray[index]; }
            set { collectArray[index] = value; }
        }

        public virtual int Count
        {
            get { return collectArray.Count; }
        }

        public virtual bool IsReadOnly
        {
            get
            {
                return isReadOnly;
            }
        }

        public abstract void Add(T coll);

        public virtual bool Remove(T vertex)
        {
            bool result = false;

            for (int i = 0; i < collectArray.Count; i++)
            {
                T obj = (T)collectArray[i];


                if (obj.Equals(vertex))
                {
                    collectArray.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        public virtual bool Contains(T vertex)
        {
            foreach (var position in collectArray)
            {
                if (position.Equals(vertex))
                {
                    return true;
                }
            }
            return false;
        }

        public virtual void CopyTo(T[] positions, int index)
        {
            collectArray.CopyTo(positions, index);
        }

        public void Clear()
        {
            collectArray.Clear();
        }

        public abstract Enumerator<T> Create();

        public virtual IEnumerator<T> GetEnumerator()
        {
            return Create();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Create();
        }
    }
}
