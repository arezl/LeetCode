// Source : https://leetcode.com/problems/first-missing-positive/ 
// Author : codeyu 
// Date : Tuesday, October 25, 2016 11:16:10 PM 

/**********************************************************************************
*
* 
* Given an unsorted integer array, find the first missing positive integer.
* 
* 
* 
* For example,
* Given [1,2,0] return 3,
* and [3,4,-1,1] return 2.
* 
* 
* 
* Your algorithm should run in O(n) time and uses constant space.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution041 
    {
        public static int FirstMissingPositive(int[] nums) 
        {
            for(int i = 0; i < nums.Length;)
            {
                if(nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
                {
                    Swap(ref nums[i], ref nums[nums[i] - 1]);
                }
                else
                {
                     i++;
                }
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return nums.Length + 1;
        }
        private static void Swap<T> (ref T lhs, ref T rhs) 
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}

