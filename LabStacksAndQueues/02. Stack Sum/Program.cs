namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();
            
            while(command != "end")
            {
                string[] splited = command.Split();
                int firstNumber = int.Parse(splited[1]);

                if (splited[0] == "add")
                {
                    int secondNumber = int.Parse(splited[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (splited[0] == "remove")
                {
                    if(numbers.Count >= firstNumber)
                    {
                        for(int i = 0; i < firstNumber; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");

        }
    }
}