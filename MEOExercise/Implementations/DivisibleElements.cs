using MEOExercise.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEOExercise.Implementations
{
    public class DivisibleElements : IDivisibleElements
    {
        private static readonly DivisibleElements _Instance = new DivisibleElements();

        public static DivisibleElements Instance => _Instance;

        /// <summary>
        /// Check if a specific element is divisible each other and then return all possible divisible groups
        /// Example: Input  { 1, 2, 3, 4 }
        /// Output { [ 1, 1 ], [ 2, 1 ], [ 2, 2], [ 3, 1 ], [ 3, 3 ], [ 4, 1 ], [ 4, 2 ], [ 4 , 4 ] }
        /// </summary>
        /// <param name="list">input int list</param>
        /// <returns>all groups which contain only divisible numbers each other</returns>
        public virtual IEnumerable<Tuple<int, int>> Groups(int[] list)
        {
            var result = new List<Tuple<int, int>>();
            // check for empty list
            if (list.Any() == false)
            {
                return result;
            }
            list.ToList().ForEach(ele1 =>
            {
                list.ToList().ForEach(ele2 =>
                {
                    // check for divisibility testing elements 1 and 2
                    // divider element cannot be zero and the first element must be divided by the second one
                    if ((ele2 != 0) && (ele1 % ele2 == 0))
                    {
                        result.Add(new Tuple<int, int>(ele1, ele2));
                    }
                });
            });
            return result;            
        }

        /// <summary>
        /// This method input to the Groups method only distinct elements.
        /// </summary>
        /// <param name="list">consider as input only distinct elements</param>
        /// <returns>all groups which contain only divisible numbers each other</returns>
        public virtual IEnumerable<Tuple<int, int>> DistinctGroups(int[] list)
        {
            // avoid repetition using Distinct
            return Groups(list.Distinct().ToArray());
        }
    }
}
