using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassesAndStructs
{
    public class GenericList<T>
    {
        private T[] arr;
        private const int initialCapacity = 4;

        public int Size { get; private set; }
        public int Capacity { get; private set; }

        public GenericList()
        {
            this.Size = 0;
            this.Capacity = initialCapacity;
            this.arr = new T[this.Capacity];
        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.arr[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.arr[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.Size==this.Capacity)
            {
                Resize();
            }
            this.arr[this.Size] = element;
            this.Size++;
        }
        public void Remove(int index)
        {
            this.ValidateIndex(index);
            for (int i = index; i < this.Size - 1; i++)
            {
                this.arr[i] = this.arr[i + 1];
            }
            this.Size--;
        }

        public void Insert(int index, T element)
        {
            if (this.Size == this.Capacity)
            {
                this.Resize();
            }
            this.Size++;
            this.ValidateIndex(index);
            for (int i = this.Size - 1; i >= index; i--)
            {
                this.arr[i] = this.arr[i - 1];
            }
            this.arr[index] = element;
        }

        public void Clear()
        {
            this.Size = 0;
        }

        public int IndexOf(T element)
        {
            var result= Array.IndexOf(this.arr, element);
            return result;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < this.Size; i++)
            {
                builder.Append(this.arr[i] + ",");
            }
            return builder.ToString().Trim(new[] { ',', ' ' });
        }

        public T Min<V>() where V : IComparable<T>
        {
            return this.arr.Take(this.Size).Min();
        }

        public T Max<V>() where V : IComparable<T>
        {
            return this.arr.Take(this.Size).Max();
        }

        private void Resize()
        {
            this.Capacity *= 2;
            var oldArr = this.arr;
            this.arr = new T[this.Capacity];
            Array.Copy(oldArr, this.arr,this.Size);
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Size)
            {
                throw new ArgumentException("Invalid index.");
            }
        }
    }
}