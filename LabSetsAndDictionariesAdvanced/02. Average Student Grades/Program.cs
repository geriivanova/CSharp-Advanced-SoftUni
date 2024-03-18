namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);

                if(!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<decimal>();
                }
                students[studentName].Add(grade); 
            }

            foreach(var (name, studentGrade) in students)
            {
                var average = studentGrade.Average();
                Console.Write($"{name} -> ");
                foreach(var grade in studentGrade)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}