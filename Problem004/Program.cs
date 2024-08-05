using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem004
{
    /// <summary>
    /// 2024년 8월 5일
    /// 문제 : 몫 구하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120805
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                return num1 / num2;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int num1 = 9;
            int num2 = 3;

            Console.WriteLine(s.solution(num1, num2));
        }
    }
}
