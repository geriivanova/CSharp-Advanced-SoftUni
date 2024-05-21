namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(numbers);
            Queue<int> even = new Queue<int>();

            while (queue.Count > 0)
            {
                int currentNumber = queue.Dequeue();
                if (currentNumber % 2 == 0)
                {
                    even.Enqueue(currentNumber);
                }
                
            }
            Console.WriteLine(string.Join(", ", even.ToArray()));
        }
    }
}