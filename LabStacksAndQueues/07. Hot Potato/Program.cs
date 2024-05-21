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

            Queue<string> names = new Queue<string>();

            for(int i = 0; i < childrenNames.Length; i++)
            {
                names.Enqueue(childrenNames[i]);
            }
            int tosses = 0;
            while(names.Count != 1 )
            {
                for (int i = 0; i < n; i++)
                {
                    string childWithPotato = names.Dequeue();

                }
            }
            
        }
    }
}