using System.Reflection;

namespace AdventOfCodeScratchards_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay4.txt");

            var data = FileManager.ReadFile(FILE_PATH);
            double sum = 0;
            foreach (var item in data)
            {
                sum += item.Score;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}