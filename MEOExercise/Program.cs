using MEOExercise.Implementations;
using System;
using System.Linq;

namespace MEOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input elements!");
            var elements = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var groups = DivisibleElements.Instance.Groups(elements);
            var distinctGroups = DivisibleElements.Instance.DistinctGroups(elements);
            Console.WriteLine("");
            Console.WriteLine($"These are the groups for {string.Join(',', elements)}");
            groups.ToList().ForEach(item =>
            {
                Console.WriteLine($"{item.Item1} div {item.Item2}");
            });
            Console.WriteLine($"Groups: {groups.Count()}");
            Console.WriteLine("");
            Console.WriteLine($"These are the distinct groups for {string.Join(',', elements)}");
            distinctGroups.ToList().ForEach(item =>
            {
                Console.WriteLine($"{item.Item1} div {item.Item2}");
            });
            Console.WriteLine($"Groups: {distinctGroups.Count()}");
            Console.ReadLine();
        }
    }
}
