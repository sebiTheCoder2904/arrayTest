using System.Reflection.Metadata.Ecma335;
using System.Linq;


namespace arrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Liste = new int[10];

            Liste[0] = 1;
            Liste[1] = 2;
            Liste[2] = 3;
            Liste[3] = 4;
            Liste[4] = 5;
            Liste[5] = 6;
            Liste[6] = 7;
            Liste[7] = 8;
            Liste[8] = 9;
            Liste[9] = 10;

            // ArraySort(Liste);
            // Console.WriteLine(ArraySum(Liste) + "\n");
            Console.WriteLine("Print array");
            ArrayPrint(Liste);
            Console.Write("\n");

            Console.WriteLine("Print randomised array");
            ArrayRandom(Liste);
            ArrayPrint(Liste);
            Console.WriteLine("\n");

            Console.WriteLine("Print reversed array");
            ArrayReverse(Liste);
            ArrayPrint(Liste);
            Console.Write("\n");


            Console.WriteLine("Print Max of array: " + ArrayMax(Liste).ToString());
            Console.WriteLine("Print Min of array: " + ArrayMin(Liste).ToString());
            Console.WriteLine("Print Sum of array: " + ArraySum(Liste).ToString());

            Console.Write("\n");
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
        static void ArrayPrint(int[] Liste)
        {
            Console.WriteLine(ArrayFormat(Liste, ", "));
        }

            static void ArraySort(int[] Liste)
        {
            Array.Sort(Liste);
        }
        static int ArrayLength(int[] Liste) 
        {
            return Liste.Length;
        }
        static int ArrayMax(int[] Liste)
        {
            return Liste.Max();
        }
        static int ArrayMin(int[] Liste)
        {
            return Liste.Min();
        }
        static int ArraySum(int[] Liste)
        {
            return Liste.Sum();
        }
        public static void ArrayRandom<T>(T[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        public static void ArrayReverse<T>(T[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                T temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }
        }

        public static string ArrayFormat<T>(T[] array, string cutBy)
        {
            return string.Join(cutBy, array);
        }
    }
}
