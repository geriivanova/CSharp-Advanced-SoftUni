namespace _01._Reverse_a_String_2._0
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