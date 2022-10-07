using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
    }

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }

    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get { return this.name; }
        }

        public abstract void Eat();

        public abstract void Play();

        public abstract void GotoVet();

        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Cat : Pet, ICat
    {
        public override void Eat()
        {

        }

        public override void Play()
        {

        }

        public void Purr()
        {

        }

        public void Scratch()
        {

        }

        public override void GotoVet()
        {

        }

        public Cat()
        {

        }
    }

    public class Dog : Pet, IDog
    {
        public string license;

        public override void Eat()
        {

        }

        public override void Play()
        {

        }

        public void Bark()
        {

        }

        public void NeedWalk()
        {

        }

        public override void GotoVet()
        {

        }

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
        
        }
    }

    public class Pets
    {
        // create a new list of pets
        public List<Pet> petList = new List<Pet>();

        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        public int Count
        {
            get { return this.petList.Count; }
        }
        
        public void Add(Pet pet)
        {

        }

        public void Remove(Pet pet)
        {
            this.petList.Remove(pet);
        }

        public void RemoveAt(int petEl)
        {
            this.petList.RemoveAt(petEl);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
