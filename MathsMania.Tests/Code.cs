using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsMania.Tests
{
    public class Code
    {
        public void RandominiseArrayContents(int[] arrray, int swapTimes)
        {
            System.Random random = new System.Random(Guid.NewGuid().GetHashCode());//https://stackoverflow.com/questions/1785744/how-do-i-seed-a-random-class-to-avoid-getting-duplicate-random-values

            for (int swapCount = 0; swapCount < swapTimes; swapCount++)
            {
                int randomIndex1 = random.Next(0, arrray.Length);
                int randomIndex2 = random.Next(0, arrray.Length);

                if (randomIndex1 != randomIndex2)
                {
                    swapArrayElements(arrray, randomIndex1, randomIndex2);
                }
            }
        }
        public void swapArrayElements(int[] arrray, int lhsIndex, int rhsIndex)
        {
            int swapSapce = arrray[lhsIndex];
            arrray[lhsIndex] = arrray[rhsIndex];
            arrray[rhsIndex] = swapSapce;
        }
    }
}
