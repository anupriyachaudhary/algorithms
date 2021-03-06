using System;

namespace Lib.Utils
{
    public static class ArrayUtils
    {
        public static void Reverse(int[] arr)
        {
            Reverse(arr, 0, arr.Length - 1);
        }

        public static void Reverse(int[] arr, int start, int end)
        {
            if(start < 0 || end >= arr.Length)
            {
                throw new ArgumentException();
            }

            for (int i = start, j = end; i < j; i++, j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        public static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        public static int BinarySearch(int[] arr, int left, int right, int elem)
        {
            if (right >= left) 
            { 
                int mid = (right + left)/2; 

                if (arr[mid] == elem)   
                    return mid; 
  
                if (arr[mid] > elem)  
                    return BinarySearch(arr, left, mid-1, elem); 
    
                return BinarySearch(arr, mid+1, right, elem); 
            } 
  
            return -1; 
        }
    }
}
