/* 
----------------------------------------------------------------
https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
----------------------------------------------------------------
*/

using System;
using System.Collections.Generic;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        Console.WriteLine(str);
        List<string> sectorsList = new List<string>();
        string result = "";

        string _str = str.Replace('-', '_');
        Console.WriteLine(_str);

        foreach(char chr in _str) 
        {
            var sectors = _str.Split('_');
            foreach (string sector in sectors) { sectorsList.Add(sector); }
            break;
        }

        foreach(string sector in sectorsList)
        {
            if(sector.Length > 0)
            {
                char upperChar = Char.ToUpper(sector[0]);
                result += upperChar + sector.Remove(0, 1);
            }
        }

        if (result.Length > 0 && !Char.IsUpper(_str[0])) result = Char.ToLower(result[0]) + result.Remove(0, 1);
        Console.WriteLine(result);
        return result;
    }
}