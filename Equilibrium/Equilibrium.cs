using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equilibrium {
    public static class Equilibrium {
        public static int getEquilibrium(this List<int> numbers) {
            if (numbers.Count == 0)
                return -1;

            var sum = getSum(numbers);
            return calculateEquilibrium(numbers, sum, 0, sum, 0);
        }

        private static int calculateEquilibrium(List<int> numbers, int leftAmount, int rightAmount, int sum, int curr) {
            if (rightAmount == leftAmount)
                return curr - 1;
            else if (rightAmount > leftAmount)
                return -1;
            else
                return calculateEquilibrium(numbers, leftAmount - numbers[curr],
                    curr > 0 ? getSumFromRight(numbers, curr) : 0, sum, curr + 1);
        }

        private static int getSumFromRight(List<int> numbers, int countFromRight) {
            var total = 0;
            for (int i = 0; i < countFromRight; i++)
                total += numbers[i];

            return total;
        }

        private static int getSum(List<int> numbers) {
            var result = 0;
            numbers.ForEach(number => {
                result += number;
            });

            return result;
        }
    }
}
