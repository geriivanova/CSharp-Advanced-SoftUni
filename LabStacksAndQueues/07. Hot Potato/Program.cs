namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] childrenNames = Console.ReadLine()
                .Split()
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Queue<string> names = new Queue<string>(childrenNames);

            int tosses = 0;
            while(names.Count != 1 )
            {
                for (int i = 0; i < childrenNames.Length - 1; i++)
                {
                    string childWithPotato = names.Dequeue();
                    tosses++;
                    if(tosses == n)
                    {
                        Console.WriteLine($"Removed {childWithPotato}");
                        tosses = 0;
                    }
                    else
                    {
                        names.Enqueue(childWithPotato);
                    }
                }
            }
            Console.WriteLine($"Last is {names.Dequeue()}");
            
        }
    }
}