using System;

namespace BinarySearch
{
    public static class Binary
    {
        /// <summary>
        /// Binary search
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public static int BinarySearch<T>(this T[] array, T element, Comparison<T> comparison)
        {
            int left = 0, right = array.Length - 1;
            int mid = right / 2;

            while (left <= right)
            {
                int result = comparison(array[mid], element);
                if (result == 0)
                    return mid;
                else if (result < 0)
                {
                    left = mid + 1;
                    mid = (left + right) / 2;
                }
                else if (true)
                {
                    right = mid - 1;
                    mid = (left + right) / 2;
                }
            }
            return -1;
        }
    }
}
