namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<char> stack = new Stack<char>(Console.ReadLine().ToCharArray());

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            
        }
    }
}