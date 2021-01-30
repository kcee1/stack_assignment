using System;

namespace stack_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("how many object do you want in this stack? ");
                var count = Convert.ToInt32(Console.ReadLine());

                var cards = new Evans(count);

                while (true)
                {
                    Console.WriteLine("you can either 'push', 'pop', 'clear', 'peek', 'print' items on this stack");
                    Console.WriteLine();
                    Console.WriteLine("what will you like to do: ");
                    var action = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(action))
                    {
                        Console.WriteLine("you can either 'push', 'pop', 'clear', 'peek', 'print' items on this stack");
                    }
                    else if (action == "push")
                    {
                        Console.WriteLine("what item do you want to push: ");
                        var item = Console.ReadLine();

                        cards.push(item);
                    }
                    else if (action == "pop")
                    {
                        cards.Pop();
                    }
                    else if (action == "peek")
                    {
                        cards.Peek();
                    }
                    else if (action == "clear")
                    {
                        cards.Clear();
                    }
                    else if (action == "print")
                    {
                        cards.Print();
                    }
                    else
                        Console.WriteLine("you entered an invalid function.....");
                }

            }
            catch (Exception)
            {

                throw;
            }
   
            


        }
    }
}
