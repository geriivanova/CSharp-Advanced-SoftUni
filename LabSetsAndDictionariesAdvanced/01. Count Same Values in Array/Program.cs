namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> rezult = new Dictionary<double, int>();

            foreach (double number in numbers)
            {
                if(!rezult.ContainsKey(number))
                {
                    rezult[number] = 0;
                }
                rezult[number]++;
            }

            foreach (var rez in rezult)
            {
                Console.WriteLine($"{rez.Key} - {rez.Value} times");
            }   
        }
    }
}