using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
   public class GenericList<T>
    {
        const int DefaultCapacity = 4096;

        internal T[] elements;
        internal int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList():this(DefaultCapacity)
        {
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)
        {
            if (count>=elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format("The list capacity of {0} was exceeded", elements.Length));
            }
            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index>=count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}",index)); 
                }
                T result = elements[index];
                return result;
            }
        }
    }
    class GenericListExample
    {
        static void Main(string[] args)
        {
            // Declare a list of type int 
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            Console.WriteLine("Number of elements {0}", intList.count);
            for (int i = 0; i < intList.count; i++)
            {
                int element = intList[i];
                Console.WriteLine(element);
            }
            Console.WriteLine();

            //Declare a list of type string
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("C#");
            stringList.Add("Java");
            stringList.Add("PHP");
            stringList.Add("SQL");
            Console.WriteLine("Number of elements {0}", stringList.count);
            for (int i = 0; i < stringList.count; i++)
            {
                string element = stringList[i];
                Console.WriteLine(element);
            }
        }
    }
}