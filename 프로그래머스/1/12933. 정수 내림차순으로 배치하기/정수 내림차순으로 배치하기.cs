using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public long solution(long n) {
        List<long> list = new List<long>();
        long answer = 0;
        while(n > 0)
        {
            list.Add(n % 10);
            n /= 10;
        }
        
        long[] longArray = list.ToArray();
        Array.Sort(longArray);
        Array.Reverse(longArray);
        for(long i = 0; i < longArray.Length; i++)
        {
            answer += longArray[i] * (int)Math.Pow(10, longArray.Length - i - 1);
        }
        return answer;
    }
}