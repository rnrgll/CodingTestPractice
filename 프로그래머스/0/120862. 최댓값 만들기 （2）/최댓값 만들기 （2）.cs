using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        Array.Sort(numbers);
        int result = Math.Max(numbers[0]*numbers[1], numbers[numbers.Length-1]*numbers[numbers.Length-2]);
        return result;
    }
}