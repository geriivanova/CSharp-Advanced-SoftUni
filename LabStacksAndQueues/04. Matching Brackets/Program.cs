namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> openingBracket = new Stack<int>();
            
            for(int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openingBracket.Push(i);
                }
                else if(expression[i] == ')')
                {
                    int startIndex = openingBracket.Pop();
                    int endIndex = i;

                    string substring = expression.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(substring);
                }
            }

        }
    }
}