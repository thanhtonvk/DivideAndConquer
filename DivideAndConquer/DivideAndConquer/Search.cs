using System;

namespace DivideAndConquer
{
    public class Search
    {
        public static int linearSearch(int[] arr, int target)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == target) return i;
            }

            return -1;
        }

        public static int binarySearch(int[] arr, int l, int r, int target)
        {
            int mid = (l + r) / 2;

            // base case 1 = checks if array is empty or not
            if (r - l < 0)
            {
                return -1;
            }

            // base case 2 = checks if array middle is the target value
            if (target == arr[mid])
            {
                return mid;
            }

            // recursive case 1 = removes left array
            if (target >= arr[mid])
            {
                return binarySearch(arr, mid + 1, r, target);
            }

            // recursive case 2 = removes right array
            return binarySearch(arr, l, mid - 1, target);
        }

        public static int ternary(int[] arr, int target)
        {
            int n = arr.Length;
            int l = 0;
            int r = n - 1;

            while (r - l >= 0)
            {
                int partiton = (r - l) / 3;
                int mid1 = l + partiton;
                int mid2 = r - partiton;

                if (target == arr[mid1])
                    return mid1;
                if (target == arr[mid2])
                    return mid2;
                if (target < arr[mid1])
                    r = mid1 - 1;
                else if (target > arr[mid2])
                    l = mid2 + 1;
                else
                {
                    l = mid1 + 1;
                    r = mid2 - 1;
                }
            } // while ends

            return -1;
        }

        public static int jumpSearch(int[] arr, int target)
        {
            int blockSize = (int) Math.Sqrt(arr.Length);
            int start = 0;
            int next = blockSize;

            while (start < arr.Length && target > arr[next - 1])
            {
                start = next;
                next = next + blockSize;

                if (next >= arr.Length)
                    next = arr.Length;
            }

            for (int i = start; i < next; i++)
            {
                if (target == arr[i])
                    return i;
            }

            return -1;
        }

        public static int expoSearch(int[] arr, int target)
        {
            int bound = 1;
            while (bound < arr.Length)
            {
                if (target <= arr[bound])
                {
                    break;
                }
                else
                {
                    bound = bound * 2;
                }
            }

            int left_bound = bound / 2;
            int right_bound = Math.Min(bound, arr.Length - 1);
            int answer = binarySearch(arr, left_bound, right_bound, target);
            return answer;
        }
    }
}