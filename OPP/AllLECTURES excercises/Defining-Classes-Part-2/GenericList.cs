﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2
{
    internal class GenericList<T>
    {
        const int DefaultCapacity = 4096;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList() : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                throw new ArgumentOutOfRangeException("Out of range");
            }
            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new ArgumentOutOfRangeException("out of range - invalid index");
                }
                T result = elements[index];
                return result;
            }
        }
    }
}
