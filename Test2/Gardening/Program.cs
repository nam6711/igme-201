using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardening
{
    public interface ISun
    {
        void Shine();
    }

    public class Sun : ISun
    {
        public bool shining;
        public void Shine()
        {
            if (this.shining)
            {
                Console.WriteLine("The Sun Shines down");
            }
            else
            {
                Console.WriteLine("The moon glows");
            }
        }
    }

    public interface IGardener
    {
        void Till();

        void PotPlant(Plant plant);

        void Harvest(Plant plant);
    }

    public class Human : IGardener
    {
        public virtual void Till()
        {
            Console.WriteLine("The ground has been tilled");
        }

        public void PotPlant(Plant plant)
        {
            Console.WriteLine($"The {plant.Name} has been potted");
        }

        public void Harvest(Plant plant)
        {
            Console.WriteLine($"The {plant.Name} produced a {plant.Fruit}");
        }
    }

    public abstract class Plant
    {
        private string _name;
        private string _fruit;
        public double size;
        public bool leafy;

        public string Name {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Fruit
        {
            get { return _fruit; }
            set { this._fruit = value; }
        }

        public void Grow()
        {
            this.size += 1.2;
        }
        public void Fruiting()
        {
            Console.WriteLine("The plant starts to bud");
        }
        public virtual void ShedLeaves()
        {
            this.leafy = false;
        }

        public Plant(string name, string fruit, double size, bool leafy)
        {
            this._name = name;
            this._fruit = fruit;
            this.size = size;
            this.leafy = leafy;
        }
    }

    public class Angiosperm : Plant
    {
        public void Grow()
        {
            Console.WriteLine("The plant grows a little bit!");
            base.Grow();
        }

        public Angiosperm(string name, string fruit, double size, bool leafy) : base(name, fruit, size, leafy)
        {
        }
    }

    public class EverGreen : Plant
    {
        public override void ShedLeaves()
        {
            Console.WriteLine("The evergreen stays green through the winter");
        }

        public EverGreen(string name, string fruit, double size, bool leafy) : base(name, fruit, size, leafy)
        {
        }
    }


    internal class Program
    {
        public static void MyMethod(object obj1, object obj2)
        {
            // cast obj1 to a generic gardener
            IGardener gardener = (IGardener)obj1;
            // cast obj2 to a generic plant
            Plant plant = (Plant)obj2;

            // call the pot and harvest methods using the gardener and
            // plant objects!
            gardener.PotPlant(plant);
            gardener.Harvest(plant);
        }

        static void Main(string[] args)
        {
            // holds new human to garden
            Human dude = new Human();
            // holds two new plants, one a Evergreen, the other a generic AngioSperm
            EverGreen evrGrn = new EverGreen("Pine Tree", "Pinecone", 10000.23, true);
            Angiosperm appleTree = new Angiosperm("Apple Tree", "Apple", 10900.213, false);

            // call my method with the human and plants
            MyMethod(dude, evrGrn);
            MyMethod(dude, appleTree);
        }
    }
}
