using MEOExercise.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MEOExercise.Test
{
    [TestClass]
    public class TestList
    {
        [TestMethod]
        public void CheckForEmptyInputElements()
        {
            // Arrange
            var elements = new int[] { };
            
            // Act
            var groups = DivisibleElements.Instance.Groups(elements);

            // Assert
            var expected = 0;
            Assert.AreEqual(expected, groups.Count());
        }

        [TestMethod]
        public void CheckGroupsUsingDuplicateElements()
        {
            // Arrange
            var elements = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };

            // Act
            var groups = DivisibleElements.Instance.Groups(elements);

            // Assert
            var expected = "1 div 1 | 9 div 1 | 9 div 9 | 9 div 3 | 9 div 9 | 3 div 1 | 3 div 3 | 4 div 1 | 4 div 4 | 4 div 2 | 5 div 1 | 5 div 5 | 6 div 1 | 6 div 3 | 6 div 6 | 6 div 2 | 2 div 1 | 2 div 2 | 9 div 1 | 9 div 9 | 9 div 3 | 9 div 9";
            var found = string.Join(" | ", groups.Select(item => $"{item.Item1} div {item.Item2}"));

            Assert.AreEqual(expected, found);
        }

        [TestMethod]
        public void CheckGroupsUsingDistinctElements()
        {
            // Arrange
            var elements = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };

            // Act
            var groups = DivisibleElements.Instance.DistinctGroups(elements);

            // Assert
            var expected = "1 div 1 | 9 div 1 | 9 div 9 | 9 div 3 | 3 div 1 | 3 div 3 | 4 div 1 | 4 div 4 | 4 div 2 | 5 div 1 | 5 div 5 | 6 div 1 | 6 div 3 | 6 div 6 | 6 div 2 | 2 div 1 | 2 div 2";
            var found = string.Join(" | ", groups.Select(item => $"{item.Item1} div {item.Item2}"));

            Assert.AreEqual(expected, found);
        }
    }
}
