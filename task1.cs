/* 
----------------------------------------------------------------
https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp
----------------------------------------------------------------
*/

using System;
using System.Collections.Generic;

class Solution{
    public static int Stray(int[] numbers){
        List<int> firstGroup = new List<int> { };
        List<int> secondGroup = new List<int> { };

        for(int i = 0; i < numbers.Length; i++){
            if(i == 0){
                firstGroup.Add(numbers[i]);
            }
            else{
                if (numbers[i] == firstGroup[0]) firstGroup.Add(numbers[i]);
                else secondGroup.Add(numbers[i]);
            }
        }

        if (firstGroup.Count > secondGroup.Count) return secondGroup[0];
        else return firstGroup[0];
    }
}