using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem006
{
    /// <summary>
    /// 2024년 8월 5일
    /// 문제 : 두 수의 나눗셈
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120806
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                return (int)((float)num1 / (int)((float)num2) * 1000);
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int num1 = 3;
            int num2 = 2;

            Console.WriteLine(s.solution(num1, num2));
        }
    }
}
