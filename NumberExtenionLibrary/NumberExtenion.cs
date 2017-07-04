using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NumberExtenion
    {
        /// <summary>
        /// Method Swap exchanges two elements in the array
        /// </summary>
        /// <param name="a">The first element to be swapped</param>
        /// <param name="b">The second element to be swapped</param>
        private static void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Method CreateCharArray returnes array of digits of given number
        /// </summary>
        /// <param name="n">Number to be splitted into digits</param>
        /// <returns></returns>
        private static char[] CreateCharArray(int n)
        {
            string s = n.ToString();
            char[] arr = s.ToCharArray();
            return arr;
        }


        /// <summary>
        /// Method FindNext returns an array of digits of the next greatest number
        /// </summary>
        /// <param name="arr">Array of digits of given number</param>
        /// <returns></returns>
        private static char[] FindNext(char[] arr)
        {
            int i; int j;
            int n = arr.Length;
            for (i = n - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    break;
                }
            }

            if (i == 0)
            {
                arr[0] = '0';
                return arr; 
            }

            int x = arr[i - 1]; int min = i;
            for (j = i + 1; j < n; j++)
            {
                if (arr[j] > x && arr[j] < arr[min])
                    min = j;
            }


            Swap(ref arr[min], ref arr[i - 1]);
            Array.Sort(arr, i, n - i);
            return arr;
        }

        /// <summary>
        /// Method ConvertArrayToString returns string representation of given array
        /// </summary>
        /// <param name="arr">Array of digits</param>
        /// <returns></returns>
        private static string ConvertArrayTostring(char[] arr)
        {
            string s = new string(arr);

            return s;
        }

        /// <summary>
        /// The wrapping method for FindNear.
        /// </summary>
        /// <param name="number">Argument "number" of FindNearWrapper</param>
        /// <returns></returns>
        public static string FindNearWrapper(int number)
        {
            char[] array = FindNext(CreateCharArray(number));
            if (array[0] == '0')
            {
                return "-1";
            }
            return ConvertArrayTostring((array));
        }
    }
}
