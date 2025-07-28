using System;
using System.Linq;
public class Solution {
    public string solution(string my_string) {
        char[] c = my_string.ToCharArray();
        char[] ch = c.Distinct().ToArray();
        return new string(ch);
    }
}