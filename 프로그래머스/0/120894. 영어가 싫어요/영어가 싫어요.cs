using System;
public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        string[] s = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        for(int i = 0; i < s.Length; i++)
        {
            numbers = numbers.Replace(s[i], i.ToString());
        }
        return long.Parse(numbers);
    }
}