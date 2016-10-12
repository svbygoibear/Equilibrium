using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equilibrium {
    public static class Equilibrium {
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
