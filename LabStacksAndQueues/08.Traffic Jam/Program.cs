namespace _08.Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            Queue<string> cars = new Queue<string>();
            int passedCarsNumber = 0;

            while((input = Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else if(input == "green")
                {
                    for(int i = 0; i < n; i++)
                    {
                        if(cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCarsNumber++;
                        }
                    }
                }
            }
            Console.WriteLine($"{passedCarsNumber} cars passed the crossroads.");
        }
    }
}