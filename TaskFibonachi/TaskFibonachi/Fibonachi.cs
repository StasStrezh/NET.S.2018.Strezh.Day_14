using System;

namespace TaskFibonachi
{
    public class Fibonachi
    {
        public static int[] Generator(int num)
        {
            int[] array = new int[2];
            array[0] = 0;
            array[1] = 1;
            int i = 1;
            while(i<num+1)
            {
                Array.Resize<int>(ref array, i + 2);
                array[i + 1] = Summ(array[i - 1], array[i]);
                i++;
                if (array[i] >= int.MaxValue)
                    break;
            }
            Array.Resize<int>(ref array, i);
            return array;
        }
        private static int Summ(int array1, int array2) => array1 + array2;
    }
}
