using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyManagement.Common
{
    public class Option<T> : IEnumerable<T>
    {
        private readonly T[] items;
        private Option(T[] elements)
        {
            this.items = elements;
        }

        public static Option<T> CreateEmpty()
        {
            return new Option<T>(new T[0]);
        }

        public static Option<T> Create(T element)
        {
            return new Option<T>(new T[] { element });
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)this.items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


    }
}
