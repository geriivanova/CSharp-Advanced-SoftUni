namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string input = Console.ReadLine();
            int namesCount = 0;

            while (input != "End")
            {
               if(input != "Paid")
               {
                    names.Enqueue(input);
                    namesCount++;
               }
               else
               {
                    while(names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                    namesCount = 0;
               }
               input = Console.ReadLine();
            }

            Console.WriteLine($"{namesCount} people remaining.");
        }
    }
}