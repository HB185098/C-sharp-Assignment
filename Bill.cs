// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace myproject
{
    public delegate void Product(String name);
    interface Item
    {
         void cost(String name);
    }
    interface Offer
    {
          void discount(String name);
          
    }
    
    
    class  Pizza :Item,Offer
    {
        public void cost(String name)
        {
                Console.WriteLine($"Price of 1 {name} is Rs.199.");
        }
        public void discount(String name)
        {
                Console.WriteLine($"Discount on {name} is Rs.20.");
        }
        public virtual  void rating(String name){
            Console.WriteLine($"Rating for Item {name} is 4.");
        }
    }
    class Bill : Pizza
    {
        public override  void rating(String name)
        {
            Console.WriteLine($"Rating for Item {name} is 5.");
        }
        
        static void Main(String[] args)
        {
            Pizza pizza = new Pizza();
            Product p = new Product(pizza.cost)+pizza.rating;
            Console.WriteLine($"Before Discount : ");
            p("pizza");
            Console.WriteLine($"After Discount : ");
            p-=pizza.rating;
            p+=pizza.discount;
            p+=(new Bill()).rating;
            p("pizza");
        }
          
            
    }

}

