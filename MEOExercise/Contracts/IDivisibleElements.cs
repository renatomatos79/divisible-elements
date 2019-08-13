using System;
using System.Collections.Generic;
using System.Text;

namespace MEOExercise.Contracts
{
    public interface IDivisibleElements
    {
        IEnumerable<Tuple<int, int>> Groups(int[] list);
        IEnumerable<Tuple<int, int>> DistinctGroups(int[] list);
    }
}
