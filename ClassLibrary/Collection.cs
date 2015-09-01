using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// abstract BaseClass for collections
    /// Realizes ICollection interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Collection<T> : ICollection<T>
    {
        protected ArrayList collectArray;
        protected bool isReadOnly;

        /// <summary>
        /// Constructor, that inicializates a collection storage
        /// </summary>
        public Collection()
        {
            collectArray = new ArrayList();
        }

        /// <summary>
        /// Indexer  for the collection
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public virtual T this[int index]
        {
            get { return (T)collectArray[index]; }
            set { collectArray[index] = value; }
        }
        /// <summary>
        /// Count property
        /// Shows, how many elements does this collection contain
        /// </summary>
        public virtual int Count
        {
            get { return collectArray.Count; }
        }
        /// <summary>
        /// Is Read Only Property
        /// Shows, if the collection is Read Only or not
        /// </summary>
        public virtual bool IsReadOnly
        {
            get
            {
                return isReadOnly;
            }
        }

        /// <summary>
        /// Abstract method for adding element to collection
        /// </summary>
        /// <param name="coll"></param>
        public abstract void Add(T coll);

        /// <summary>
        /// Method for removing element from the collection
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Method, that shows if the collection does contain the searching element in it
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Method that copies an array contens to the collection
        /// </summary>
        /// <param name="positions">array that should be copy to collection</param>
        /// <param name="index">index of the element since which should start copy</param>
        public virtual void CopyTo(T[] positions, int index)
        {
            collectArray.CopyTo(positions, index);
        }
        /// <summary>
        /// Method that allows to clear all the contans of the collection
        /// </summary>
        public void Clear()
        {
            collectArray.Clear();
        }
        /// <summary>
        /// Abstact method for creating the enumartor of collection
        /// </summary>
        /// <returns></returns>
        public abstract Enumerator<T> Create();
        /// <summary>
        /// summarysummary
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerator<T> GetEnumerator()
        {
            return Create();
        }
        /// <summary>
        /// Sets the enumerator
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Create();
        }
    }
}
