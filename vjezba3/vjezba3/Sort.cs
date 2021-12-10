using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba3
{
    class Sort
    {
        public void QuickSort(int[] arr, int left, int right)
        {

            int i = left, j = right; 
            int x = arr[(left + right) / 2];

            do 
            {
                 while (arr[i] < x && i < right) i++;

                 while (arr[j] > x && j > left) j--;

                 if (i <= j) 
                 { 
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp; i++; 
                    j--;
                 }
            }
            while(i <= j); 

            if (left < j)
            {
                QuickSort(arr, left, j);
            }
                

            if (i < right)
            {
                QuickSort(arr, i, right);
            }

        }
    }
}
