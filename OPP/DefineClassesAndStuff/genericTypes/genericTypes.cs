using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericTypes
{
    public class Dog
    {
    }
    public class Cat
    {
    }
    public class AnimalShelter<T>
    {
        private const int DefaultPlacesCount = 20;

        private T[] animalList;
        private int usedPlaces;

        public AnimalShelter()
            : this(DefaultPlacesCount)
        {
        }
        public AnimalShelter(int placesCount)
        {
            this.animalList = new T[placesCount];
            this.usedPlaces = 0;
        }
        public void Shelter(T newAnimal)
        {
            if (this.usedPlaces >= this.animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full.");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }

        public T Release(int index)
        {
            if (index < 0 || index >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: " + index);
            }
            T releasedAnimal = this.animalList[index];
            for (int i = index; i < this.usedPlaces - 1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.usedPlaces - 1] = default(T);
            this.usedPlaces--;
            return releasedAnimal;
        }

        public static void Main()
        {
            AnimalShelter<Dog> shelter = new AnimalShelter<Dog>();
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            Dog d = shelter.Release(1); // Release the second dog
            Console.WriteLine(d);
            d = shelter.Release(0); // Release the first dog
            Console.WriteLine(d);
            d = shelter.Release(0); // Release the third dog
            Console.WriteLine(d);
            d = shelter.Release(0); // Exception: invalid cell index
        }
    }
}
