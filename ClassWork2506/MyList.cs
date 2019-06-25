using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2506
{
    public class MyList<T> : IMyList<T> where T: IEquatable<T>
    {
        protected T[] array { get; set; }
        private int count;
        
        public MyList()
            {
            this.array = new T[0];
            }
       
        public int Count
        {
            get
            {
                return this.array.Length;
            }
        }

        public void Add(T a)
        {
            T[] arr = new T[array.Length + 1];

            array.CopyTo(arr, 0);
            array = arr;

            array[array.Length - 1] = a;
        }

        public void Clear()
        {
            this.array = new T[0];
        }

        public T this[int index]
        {
            get
            {
                return this.array[index];
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

