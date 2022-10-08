using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine($"{this.Name}: I'm a cat and I'll eat anything. Also hi.");
        }

        public override void Play()
        {
            Console.WriteLine($"{this.Name}: I want to play, but like for 5 minutes then I'll bite you");
        }

        public void Purr()
        {
            Console.WriteLine($"{this.Name}: *purrs*");
        }

        public void Scratch()
        {
            Console.WriteLine($"{this.Name}: I'm a cat. Unprompted interaction resulted in a scratch");
        }

        public override void GotoVet()
        {
            Console.WriteLine($"{this.Name}: Bark. Haha jk I'm a cat. If I barked, I'm probably sick. Take me to the vet");
        }

        public Cat(string license, int age) : base(license, age)
        {

        }
    }

    public class Dog : Pet, IDog
    {
        public string license;

        public override void Eat()
        {
            Console.WriteLine($"{this.Name}: Yummy, I'll eat anything cus I am a dog lmao");
        }

        public override void Play()
        {
            Console.WriteLine($"{this.Name}: Ayo I need to go out about right now (I'm a dog)");
        }

        public void Bark()
        {
            Console.WriteLine($"{this.Name}: WOOF");
        }

        public void NeedWalk()
        {
            Console.WriteLine($"{this.Name}: I'm a dog, and I yearn to parambulate");
        }

        public override void GotoVet()
        {
            Console.WriteLine($"{this.Name}: I'm a dog. *cough*. I'm a dog I should bark, so take me to the vet lol");
        }

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense;
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
            this.petList.Add(pet);
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
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();

            Random rand = new Random();

            for (short i = 0; i < 50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        // prompt user for id and stuff
                        Console.WriteLine("You bought a dog!");
                        Console.Write("LICENSE NUMBER: ");
                        string license = Console.ReadLine();
                        Console.Write("NAME: ");
                        string name = Console.ReadLine();

                        // add a dog
                        dog = new Dog(license, name, rand.Next(0, 10));
                        pets.Add(dog);
                    }
                    else
                    {
                        // prompt user for id and stuff
                        Console.WriteLine("You bought a cat!");
                        Console.Write("NAME: ");
                        string name = Console.ReadLine();
                        // else add a cat
                        cat = new Cat(name, rand.Next(0, 10));
                        pets.Add(cat);
                    }
                } else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    thisPet = pets[rand.Next(0, pets.Count)];
                    if (thisPet == null)
                    {
                        continue;
                    }
                    if (thisPet is Cat)
                    {
                        iCat = (Cat)thisPet;
                        switch (rand.Next(0, 4))
                        {
                            case 0:
                                iCat.Eat();
                                break;
                            case 1:
                                iCat.Play();
                                break;
                            case 2:
                                iCat.Scratch();
                                break;
                            case 3:
                                iCat.Purr();
                                break;
                        }
                    }
                    else
                    {
                        iDog = (Dog)thisPet;
                        switch (rand.Next(0, 4))
                        {
                            case 0:
                                iDog.Eat();
                                break;
                            case 1:
                                iDog.Play();
                                break;
                            case 2:
                                iDog.Bark();
                                break;
                            case 3:
                                iDog.NeedWalk();
                                break;
                        }
                    }
                }
            }
        }
    }
}
