/* 
----------------------------------------------------------------
https://www.codewars.com/kata/515decfd9dcfc23bb6000006/train/csharp
----------------------------------------------------------------
*/

/* A good programmer's best nightmare down below */

using System;
using System.Collections.Generic;

namespace Solution
{
    class Kata
    {
        public static bool IsValidIp(string ipAddres)
        {
            char[] _ip = ipAddres.ToCharArray();
            List<int> curSector = new List<int> { };
            int dotsCount = 0;

            for(int i = 0; i < ipAddres.Length; i++)
            {
                if (_ip[i] == '.')
                {
                    if ((i + 1 < _ip.Length && _ip[i + 1] == '.') || i == 0) return false;
                    if (i == ipAddres.Length-1) return false;

                    int num = 0;
                    foreach (int entry in curSector) { num = 10 * num + entry; }
                    if (num > 255) return false;

                    else curSector.Clear();
                    dotsCount++;
                }
                else
                {
                    if (curSector.Count == 0 && _ip[i] == '0')
                    {
                        if (i + 1 < _ip.Length && _ip[i + 1] != '.') return false;
                    }
                    else 
                    {
                        if (!Char.IsDigit(_ip[i])) return false;
                        curSector.Add(_ip[i] - '0');
                    } 
                }
            }

            int _num = 0;
            foreach (int entry in curSector) { _num = 10 * _num + entry; }

            return !(dotsCount != 3) && _num <= 255;
        }
    }
}