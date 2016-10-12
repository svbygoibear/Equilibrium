using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equilibrium {
    public static class Equilibrium {
        /// <summary>
        /// Returns the first equivalence point found from a list of integers. If none was found then it will return -1.
        /// </summary>
        /// <param name="numbers">List of integers</param>
        /// <returns>Equivalence/Equilibrium index</returns>
        public static int getEquilibrium(this List<int> numbers) {
            if (numbers.Count == 0)
                return -1;

            return calculateEquilibrium(numbers, getSum(numbers), 0, 0);
        }

        /// <summary>
        /// Calculates the equilibrium recursively.
        /// </summary>
        /// <param name="numbers">List of integers</param>
        /// <param name="leftAmount">Summed value on the left(on start this is the total of all integers)</param>
        /// <param name="rightAmount">Summed value on the right(on start this is zero)</param>
        /// <param name="curr">Start index to increment. This is zero at the start</param>
        /// <returns>The first point(index) of equivalence found.</returns>
        private static int calculateEquilibrium(List<int> numbers, int leftAmount, int rightAmount, int curr) {
            if (rightAmount == leftAmount)
                return curr - 1;
            else if (rightAmount > leftAmount)
                return -1;
            else
                return calculateEquilibrium(numbers, leftAmount - numbers[curr],
                    curr > 0 ? getSumFromRight(numbers, curr) : 0, curr + 1);
        }

        /// <summary>
        /// Calculates the sum of the right hand side.
        /// </summary>
        /// <param name="numbers">List of integers</param>
        /// <param name="countFromRight">The current index</param>
        /// <returns>Total of the right hand side.</returns>
        private static int getSumFromRight(List<int> numbers, int countFromRight) {
            var total = 0;
            for (int i = 0; i < countFromRight; i++)
                total += numbers[i];

            return total;
        }

        /// <summary>
        /// Used to calculate the sum from a list of integers.
        /// </summary>
        /// <param name="numbers">List of integers</param>
        /// <returns>Summed total from the integer list.</returns>
        private static int getSum(List<int> numbers) {
            var result = 0;
            numbers.ForEach(number => {
                result += number;
            });

            return result;
        }
    }
}
