using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort : MonoBehaviour
{
    int[] data = new[] { 4, 8, 2, 3, 9, 7, 1, 6, 10, 5 };

    void QuickFunction(int[] array, int start, int end)
    {
        int pivot = start;
        int left = pivot + 1;
        int right = end;
        int temp = 0;

        while (left < right)
        {
            while (left <= end && array[left] < array[pivot])
            {
                left++;
            }

            while (right > start && array[right] > array[pivot])
            {
                right--;
            }

            if(left > right)
            {
                temp = array[right];
                array[right] = array[pivot];
                array[pivot] = temp;
            }
            else
            {
                temp = array[left];
                array[right] = array[left];
                array[right] = temp;
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        QuickFunction(data, 0, data.Length - 1);

        for(int i = 0; i < data.Length; i++)
        {
            Debug.Log(data[i]); 
        }
    }
}
