// Source : https://leetcode.com/problems/plus-one/ 
// Author : codeyu 
// Date : Sunday, January 15, 2017 9:46:36 PM 

/**********************************************************************************
*
* Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.
* 
* You may assume the integer do not contain any leading zero, except the number 0 itself.
* 
* The digits are stored such that the most significant digit is at the head of the list.
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
public class Solution066 {
    public static int[] PlusOne(int[] digits) {
        if(digits == null || digits.Length==0)  
            return digits;  
        int carry = 1;  
        for(int i=digits.Length-1;i>=0;i--)  
        {  
            int digit = (digits[i]+carry)%10;   
            carry = (digits[i]+carry)/10;  
            digits[i] = digit;  
            if(carry==0)  
                return digits;      
        }  
        int [] res = new int[digits.Length+1];      
        res[0] = 1;  
        return res;
    }
}}

