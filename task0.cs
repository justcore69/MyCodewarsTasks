/* 
----------------------------------------------------------------
https://www.codewars.com/kata/55f2b110f61eb01779000053/train/csharp 
----------------------------------------------------------------
*/

using System;

public class Sum
{
    public int GetSum(int a, int b)
    {
        int sum = 0;
        int c;
        if (b < a) { c = a; a = b; b = c; }
        if (a == b) return a;
        if(a < 0)
        {
            if(b < 0) for (int i = 0; i < Math.Abs(a) + Math.Abs(b); i++) { sum += a + i; }
            else for (int i = 0; i <= Math.Abs(a) + Math.Abs(b); i++) { sum += a + i; }
        }
        else for (int i = 0; i <= Math.Abs(b) - Math.Abs(a); i++) { sum += a + i; }
        return sum;
    }
}