using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        if(int.Parse(bin1) == 0)
            return bin2;
        else if(int.Parse(bin2) == 0)
            return bin1;
        string answer = "";
        int A = 0;
        for(int i = 0; i < bin1.Length; i++)
        {
            int a = bin1[i] - 48;
            A += a * (int)Math.Pow(2, (bin1.Length - 1 - i));
        }
        for(int i = 0; i < bin2.Length; i++)
        {
            int b = bin2[i] - 48;
            A += b * (int)Math.Pow(2, (bin2.Length - 1 - i));
        }
        while(A > 0)
        {
            answer = A % 2 + answer;
            A /= 2;
        }
        return answer;
    }
}