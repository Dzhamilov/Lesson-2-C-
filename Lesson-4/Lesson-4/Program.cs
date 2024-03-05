using System;
using System.Collections.Generic;

namespace Lesson_4
{
    internal class Program
    {
        public static void FindSumOfThreeNums2(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length - 1; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == target)
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} + {arr[k]}= {target}");
                        }
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 10, 15, 12, 11, 4, 14, 0 };
            int target = 28;
            FindSumOfThreeNums (arr, target);
            Console.WriteLine("***");
            FindSumOfThreeNums2(arr, target);


        }

        public static void FindSumOfThreeNums(int[] arr, int target)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length-1; i++)
            {
                int left = i + 1;
                int right = arr.Length - 1;
                while (left<right)
                {
                    int sum = arr[left] + arr[i] + arr[right];
                    if (sum == target)
                    {
                        Console.WriteLine($"{arr[i]} + {arr[left]} + {arr[right]} = {target}");
                        break;
                    }
                    else if (sum < target) left++;
                    else right--;
                    
                }
                
            }
        }
    }
}
