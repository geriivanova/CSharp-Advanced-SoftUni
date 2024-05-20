namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();
            var reverseString = input.Reverse();
            Stack<string> stack = new Stack<string>(reverseString);
            
            int result = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                char symbol = char.Parse(stack.Pop());
                int number = int.Parse(stack.Pop());

                if(symbol == '+')
                {
                    result += number;
                }
                else if(symbol == '-')
                {
                    result -= number;
                }
            }
            Console.WriteLine(result);
        }
    }
}