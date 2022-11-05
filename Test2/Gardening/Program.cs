using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardening
{
    // Interface: ISun
    // Author: Nat Manoucheri
    // Purpose: Holds potential methods of use for any suns that may need creating
    // Restrictions: interface
    public interface ISun
    {
        void Shine();
    }

    // Class: Sun
    // Author: Nat Manoucheri
    // Purpose: Writes to the console whether it is shining currently
    // Restrictions: None
    public class Sun : ISun
    {
        // property that holds whether the sun is out and shining
        public bool shining;
        // Method: Shine
        // Purpose: If it is sunny out, the sun will shine!
        // Restrictions: None
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

    // Interface: IGardener
    // Author: Nat Manoucheri
    // Purpose: Useful scaffolding for a potential Gardener
    //          Any human can be a gardener as long as they can perform
    //          the tasks associated with the class
    // Restrictions: interface
    public interface IGardener
    {
        void Till();

        void PotPlant(Plant plant);

        void Harvest(Plant plant);
    }

    // Class: Human
    // Author: Nat Manoucheri
    // Purpose: Writes to the console things about the plants that the human
    //          is interacting with
    // Restrictions: None
    public class Human : IGardener
    {
        // Method: Till
        // Purpose: The human will till the ground
        // Restrictions: None
        public virtual void Till()
        {
            Console.WriteLine("The ground has been tilled");
        }
        // Method: PotPlant
        // Purpose: The human pots the plant, and names the plant
        // Restrictions: None
        public void PotPlant(Plant plant)
        {
            Console.WriteLine($"The {plant.Name} has been potted");
        }
        // Method: Harvest
        // Purpose: The human harvests the plant, and denotes the
        // //       type of fruit it produced
        // Restrictions: None
        public void Harvest(Plant plant)
        {
            Console.WriteLine($"The {plant.Name} produced a {plant.Fruit}");
        }
    }

    // Class: Plant
    // Author: Nat Manoucheri
    // Purpose: Writes to the console data about the plant
    //          and holds states about the plant and what is unique about it
    // Restrictions: abstract
    public abstract class Plant
    {
        // plant properties!
        private string _name; // name of the plant
        private string _fruit; // the type of fruit of this plant
        public double size; // size of the plant
        public bool leafy; // holds whether the plant has leaves or not

        // Accessor: Name
        // Purpose: Sets and Gets the values of this._name
        // Restrictions: None
        public string Name {
            get { return this._name; }
            set { this._name = value; }
        }

        // Accessor: Fruit
        // Purpose: Sets and Gets the values of this._fruit
        // Restrictions: None
        public string Fruit
        {
            get { return _fruit; }
            set { this._fruit = value; }
        }


        // Method: Grow
        // Purpose: PIncreases a plant's height!
        // Restrictions: None
        public void Grow()
        {
            this.size += 1.2;
        }

        // Method: Fruiting
        // Purpose: Prints that the plant has started budding!
        // Restrictions: None
        public void Fruiting()
        {
            Console.WriteLine("The plant starts to bud");
        }

        // Method: ShedLeaves
        // Purpose: Changes the state of the plant to having no leaves!
        // Restrictions: Can be overidden
        public virtual void ShedLeaves()
        {
            this.leafy = false;
        }

        // Method: Constructor
        // Purpose: Initializes the class
        // Restrictions: None
        public Plant(string name, string fruit, double size, bool leafy)
        {
            this._name = name;
            this._fruit = fruit;
            this.size = size;
            this.leafy = leafy;
        }
    }

    // Class: Angiosperm
    // Author: Nat Manoucheri
    // Purpose: Angiosperms are a generic term for any plant
    //          that prdocues a fruiting body. This class will
    //          be useful for a generic plant of any type
    // Restrictions: inherits from Plant
    public class Angiosperm : Plant
    {
        // Method: Grow
        // Purpose: PIncreases a plant's height!
        // Restrictions: None
        public void Grow()
        {
            Console.WriteLine("The plant grows a little bit!");
            base.Grow();
        }
        // Method: Constructor
        // Purpose: Initializes the class
        // Restrictions: None
        public Angiosperm(string name, string fruit, double size, bool leafy) : base(name, fruit, size, leafy)
        {
        }
    }

    // Class: Angiosperm
    // Author: Nat Manoucheri
    // Purpose: EverGreens are always green, so the ShedLeaves method
    //          should be essentially removed to prevent any leaf loss
    // Restrictions: inherits from Plant; Cannot shed leaves, so always will be 'leafy'
    public class EverGreen : Plant
    {
        // Method: ShedLeaves
        // Purpose: Ever greens are always green, so they shouldn't shed
        //          their leaves! As a result, overrides the parent class' method
        // Restrictions: Overriden?
        public override void ShedLeaves()
        {
            Console.WriteLine("The evergreen stays green through the winter");
        }
        // Method: Constructor
        // Purpose: Initializes the class
        // Restrictions: None
        public EverGreen(string name, string fruit, double size, bool leafy) : base(name, fruit, size, leafy)
        {
        }
    }

    // Class: Program
    // Author: Nat Manoucheri
    // Purpose: Runs through the MyMethod to perform the plant and human
    //          interactions of potting and harvesting
    // Restrictions: none
    internal class Program
    {
        // Method: MyMethod
        // Purpose: Using a generic class that is derived from IGardener
        //          and a generic class derived from Plant, pot and harvest the
        //          plants using the gardener
        // Restrictions: None
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

        // Method: Main
        // Purpose: Create a few plants and humans and use them in order
        //          to simulate farming under the sun
        // Restrictions: None
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
