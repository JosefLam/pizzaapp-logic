using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("do you want: 1(magerita) or 2(peperoni)");
            string choice = Console.ReadLine();
            pizza order = new pizza();
            if string(parse(choice)) ==
            
        }

    }
    class pizza
    {
        public string pizzaname;
        public bool tomato;
        public bool cheese;
        public bool pepparoni;

        public void showtoppings()
        {
            Console.WriteLine($"you have ordered: {pizzaname}");
            Console.WriteLine("This has:");
            if (tomato)
            {
                Console.WriteLine("tomato");
            }
            if (cheese)
            {
                Console.WriteLine("cheese");
            }
            if (pepparoni)
            {
                Console.WriteLine("pepparoni");
            }

        }
    }
}
