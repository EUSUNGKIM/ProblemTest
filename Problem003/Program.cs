using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem003
{
    /// <summary>
    /// 2024년 8월 5일
    /// 문제 : 나머지 구하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120810
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = num1 % num2;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int num1 = 3;
            int num2 = 6;

            Console.WriteLine(s.solution(num1, num2));
        }
    }
}
