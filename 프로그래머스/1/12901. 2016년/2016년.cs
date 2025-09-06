using System;

public class Solution {
    public string solution(int a, int b) {
        DateTime date = new DateTime(2016, a, b);

        string[] week = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
        return week[(int)date.DayOfWeek];
    }
}