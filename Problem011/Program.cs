using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem011
{
    /// <summary>
    /// 2024년 8월 6일
    /// 문제 : 두수의 합
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120802
    /// </summary>
    internal class Program
    {
        public class Solution {
        public int solution(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    static void Main(string[] args)
        {
            Solution s = new Solution();
            int num1 = 10;
            int num2 = 10;

            Console.WriteLine(s.solution(num1,num2));
        }
    }
}
