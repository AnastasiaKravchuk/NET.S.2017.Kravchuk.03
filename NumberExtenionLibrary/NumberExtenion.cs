using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Logic
{
    public class NumberExtenion
    {

        #region PublicMethod
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

        /// <summary>
        /// Method to find nth root of a given number with precise accuracy
        /// </summary>
        /// <param name="number"></param>
        /// <param name="n"></param>
        /// <param name="eps"></param>
        /// <returns></returns>
        public static double NewtonMethod(double number, int n, double eps)
        {
            if (n <= 0 || eps <= 0)
            {
                throw new ArgumentOutOfRangeException("The power of root or eps are less or equal 0");
            }

            if ((number <= 0) && (n % 2) == 0)
            {
                throw new ArgumentException("Can't get a even root of a negative number!");
            }

            double prev = number;

            double delta = ((number / Pow(prev, n - 1)) - prev) / n;
            double next = prev + delta; 
            while (Abs(delta) > eps)
            {
                prev = next;
                delta = ((number / Pow(prev, n - 1)) - prev) / n;
                next = prev + delta;
            }
            return next;
        }

        #endregion

        #region PrivateMethods
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
        #endregion
    }
}
