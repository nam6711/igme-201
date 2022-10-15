using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public interface IMood
    {
        string Mood
        {
            get;
        }
    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        
        private byte sugar;

        public string size;
        public string brand;

        public Customer customer;

        public virtual void AddSugar(byte amount)
        {
            // default code
        }

        public abstract void Steam();

        // Constructors
        public HotDrink()
        {
        }
        public HotDrink(string brand)
        {
            this.brand = brand;
        }
    }

    public class Waiter : IMood
    {
        public string name;
        private string mood;

        public string Mood
        {
            get { return mood; }
        }

        public void ServeCustomer(HotDrink cup)
        {
            // code to implement
        }
    }

    public class Customer
    {
        public string name;
        public string creditCardNumber;
        private string mood;

        public string Mood
        {
            get { return mood; }
        }
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public override void Steam()
        {
            throw new NotImplementedException();
        }

        public void TakeOrder()
        {
            throw new NotImplementedException();
        }

        // Constructor
        public CupOfCoffee(string brand) : base(brand)
        {
            this.brand = brand;
        }
    }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;

        public bool customerIsWealthy;

        public override void Steam()
        {
            throw new NotImplementedException();
        }

        public void TakeOrder()
        {
            throw new NotImplementedException();
        }

        // Constructor
        public CupOfTea(bool customerIsWealthy)
        {
            this.customerIsWealthy = customerIsWealthy;
        }
    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public static int numCups;

        public bool marshmallows;

        private string source;

        public string Source
        {
            set { source = value; }
        }

        public override void Steam()
        {
            throw new NotImplementedException();
        }

        public override void AddSugar(byte amount)
        {
            base.AddSugar(amount);
        }

        public void TakeOrder()
        {
            throw new NotImplementedException();
        }

        public CupOfCocoa() : this(false)
        {
        }

        public CupOfCocoa(bool marshmallows) : base ("Expensive Organic Brand")
        {
            this.marshmallows = marshmallows;
        }
    }
}
