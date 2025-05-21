namespace SortArrays
{
    internal class Program
    {
        static void SortArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                 var minIndexValue = GetMinIndexValue(numbers, i);

                if (minIndexValue != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[minIndexValue];
                    numbers[minIndexValue] = temp;
                }
            }
        }   

        static int GetMinIndexValue(int[] array, int startIndex)
        {
            int minIndexValue = startIndex;

            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndexValue])
                {
                    minIndexValue = i;
                }
            }

            return minIndexValue;
        }

        static void Main(string[] args)
        {
            int[] numbers = [12, 4, -9, 0, 45, 21];
            SortArray(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
