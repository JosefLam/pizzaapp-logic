using System;

public class pizza
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
