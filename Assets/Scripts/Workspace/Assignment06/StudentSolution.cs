using System;
using System.Collections.Generic;
using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment06
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public void LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            // Your code here ...
            for(int i = 0;i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    index = i;
                    break;
                }
            }
            // ...
            Debug.Log(index);
        }

        public void LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            // Your code here ...
            for (int i = 0;i < array.GetLength(0);i++)
            {
                for (int j = 0;j < array.GetLength(1);j++)
                {
                    if (array[i,j] == target)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
                if (row != -1 && col != -1) break;
            }
            
            // ...

            Debug.Log($"({row}, {col})");
        }

        public void LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            // Your code here ...
            int left = 0;
            int right = array.Length-1;

            while (left <= right)
            {
                int mid = left +(right-left)/2;
                if (array[mid] == target)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < target)
                {
                    left = mid+1;
                }
                else if (array[mid] > target)
                {
                    right = mid-1;
                }
                ;
            }
            // ...

            Debug.Log(index);
        }

        #endregion

        #region Assignment

        public void AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int start = -1;
            int end = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (start == -1) start = i;
                    end = i;
                }
            }
            if (start == -1 && end == -1)
            {
                Debug.Log(start);
                return;
            }
            Debug.Log(start);
            Debug.Log(end);
        }

        public void AS02_FindMaxLessThan(int[] array, int target)
        {
            int temp = target;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < target)
                {
                    if (temp == target)
                    {
                        temp = array[i];
                    }
                    else if ( array[i] > temp)
                    {
                        temp = array[i];
                    }    
                    
                }
            }
            if (temp == target)
            {
                Debug.Log(-1);
            }
            else
            {
                Debug.Log(temp);
            }
        }

        public void AS03_FindRange(int[] array, int min, int max)
        {
            int[] sorted = Sort(array);


            bool hasValue = false;

            for (int i = 0; i < sorted.Length; i++)
            {
                if (sorted[i] >= min && sorted[i] <= max)
                {
                    Debug.Log(sorted[i]);
                    hasValue = true; 
                }
            }
            if (!hasValue)
            {
                Debug.Log("Empty");
            }
        }
        public int[] Sort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        #endregion

        #region Extra

        public void EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            int[] sorted = (int[])enemyHPs.Clone();
            SortAscendingButNoReturn(sorted);
            int manaLeft = mana;
            int maxKillableCount = 0;
            List<int> hpsToKill = new List<int>();

            for (int i = 0; i < sorted.Length; i++)
            {
                if (sorted[i] <= manaLeft)
                {
                    manaLeft -= sorted[i];
                    hpsToKill.Add(sorted[i]); 
                    maxKillableCount++;
                }
                else break;
            }
            foreach (int hp in enemyHPs)
            {
                if (hpsToKill.Contains(hp))
                {
                    Debug.Log(hp);
                    hpsToKill.Remove(hp);
                }
            }
        }
        public void SortAscendingButNoReturn(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
        }
        #endregion
    }
}
