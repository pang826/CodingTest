using System;
using System.Collections.Generic;
class Solution 
{
    public int solution(int n) 
   {
        string a = Convert.ToString(n, 2).Replace("0","");
        int newN = n;
        while(true)
        {
            newN++;
            string b = Convert.ToString(newN, 2).Replace("0","");
            if(a == b) return newN;
        }
    }
}