using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class RationalSorter
    {
        private const int MAX_ONN_ALGORITHMS_COUNT = 10;

        private RationalSorter() { }

        public static void sort(RationalNumber[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return;
            }
            sort(numbers, false);
        }

        public static void sort(RationalNumber[] numbers, bool isDecreaseOrder)
        {
            if (numbers.Length > MAX_ONN_ALGORITHMS_COUNT)
            {
                heapSort(numbers, isDecreaseOrder);
            }
            else
            {
                insertionSorting(numbers, isDecreaseOrder);
            }
        }

        private static void bubbleSorting(RationalNumber[] numbers, bool isDecreaseOrder)
        {
            int length = numbers.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1] && !isDecreaseOrder)
                    {
                        swap(ref numbers[j], ref numbers[j + 1]);
                    }
                    else if (numbers[j] < numbers[j + 1] && isDecreaseOrder)
                    {
                        swap(ref numbers[j], ref numbers[j + 1]);
                    }
                }
            }
        }

        private static void insertionSorting(RationalNumber[] numbers, bool isDecreaseOrder)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                RationalNumber current = numbers[i];
                int key = i - 1;
                if (isDecreaseOrder)
                {
                    while (key >= 0 && numbers[key] < current)
                    {
                        numbers[key + 1] = numbers[key];
                        numbers[key] = current;
                        key--;
                    }
                }
                else
                {
                    while (key >= 0 && numbers[key] > current)
                    {
                        numbers[key + 1] = numbers[key];
                        numbers[key] = current;
                        key--;
                    }
                }
            }
        }

        private static void selectionSorting(RationalNumber[] numbers, bool isDecreaseOrder)
        {
            int length = numbers.Length;
            for (int i = 0; i < length; i++)
            {
                RationalNumber elementToSwap = numbers[i];
                int key = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (elementToSwap > numbers[j] && isDecreaseOrder)
                    {
                        elementToSwap = numbers[j];
                        key = j;
                    }
                    else if (elementToSwap < numbers[j] && !isDecreaseOrder)
                    {
                        elementToSwap = numbers[j];
                        key = j;
                    }
                }
                if (key != i)
                {
                    swap(ref numbers[i], ref numbers[key]);
                }
            }
        }

        private static void mergeSort(RationalNumber[] numbers, bool isDecreaseOrder)
        {
            mergeSortingArray(numbers, 0, numbers.Length - 1, isDecreaseOrder);
        }

        private static void mergeSortingArray(RationalNumber[] numbers, int start, int end,
            bool isDecreaseOrder)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;
                mergeSortingArray(numbers, start, middle, isDecreaseOrder);
                mergeSortingArray(numbers, middle + 1, end, isDecreaseOrder);
                merge(numbers, start, middle, end, isDecreaseOrder);
            }
        }

        private static void merge(RationalNumber[] numbers, int start, int middle, int end,
            bool isDecreaseOrder)
        {
            int firstLen = middle - start + 1;
            int secondLen = end - middle;
            int i = 0;
            int j = 0;

            RationalNumber[] firstArray = new RationalNumber[firstLen];
            for (int k = start; k < middle + 1; k++) firstArray[k - start] = numbers[k];

            RationalNumber[] secondArray = new RationalNumber[secondLen];
            for (int k = middle + 1; k < end + 1; k++) secondArray[k - middle - 1] = numbers[k];

            for (; i < firstLen && j < secondLen; )
            {
                if (isDecreaseOrder)
                {
                    if (firstArray[i] < secondArray[j])
                    {
                        numbers[start + i + j] = secondArray[j];
                        j++;
                    }
                    else
                    {
                        numbers[start + i + j] = firstArray[i];
                        i++;
                    }
                }
                else
                {
                    if (firstArray[i] > secondArray[j])
                    {
                        numbers[start + i + j] = secondArray[j];
                        j++;
                    }
                    else
                    {
                        numbers[start + i + j] = firstArray[i];
                        i++;
                    }
                }
            }

            if (i == firstLen)
            {
                for (; j < secondLen; j++)
                {
                    numbers[start + i + j] = secondArray[j];
                }
            }
            else if (j == secondLen)
            {
                for (; i < firstLen; i++)
                {
                    numbers[start + i + j] = firstArray[i];
                }
            }
        }

        public static void heapSort(RationalNumber[] numbers, bool isDecreaseOrder)
        {
            for (int i = numbers.Length / 2 - 1; i >= 0; i--)
            {
                pushDown(numbers, i, numbers.Length);
            }

            for (int i = numbers.Length; i > 1; i--)
            {
                swap(ref numbers[i - 1], ref numbers[0]);
                pushDown(numbers, 0, i - 1);
            }
            
            /*
             * I've broken my mind, trying to use this fucking work with increase and decrease order,
             * so, I've fixed this in such way. nlogn >> n/2, so I can do it
             */
            if (isDecreaseOrder)
            {
                Array.Reverse(numbers);
            }
        }
        
        private static void pushDown(RationalNumber[] numbers, int position, int length)
        {
            bool isPushed = false;
            int max = 0;

            while ((position * 2 + 1 < length) && (!isPushed))
            {
                if ((position * 2 + 1 == length - 1) || 
                    (numbers[position * 2 + 1] > numbers[position * 2 + 2]))
                {
                    max = position * 2 + 1;
                }
                else
                {
                    max = position * 2 + 2;
                }

                if (numbers[position] < numbers[max])
                {
                    swap(ref numbers[position], ref numbers[max]);
                    position = max;
                }
                else
                {
                    isPushed = true;
                }
            }
        }

        private static void swap(ref RationalNumber numberFirst, ref RationalNumber numberSecond)
        {
            RationalNumber temp = numberFirst;
            numberFirst = numberSecond;
            numberSecond = temp;
        }
    }
}
