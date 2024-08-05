using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem002
{
    /// <summary>
    /// 2024년 8월 5일
    /// 문제 : 두수의 곱
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120804
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = num1 * num2;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int num1 = 2;
            int num2 = 5;

            Console.WriteLine(solution.solution(num1, num2));
        }
    }
}
