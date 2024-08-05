using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem007
{
    /// <summary>
    /// 2024년 8월 5일
    /// 문제 : 나이 출력
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120820
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int age)
            {
                int result = 2023;
                return result -= age;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int num1 = 24;

            Console.WriteLine(s.solution(num1));
        }
    }
}
