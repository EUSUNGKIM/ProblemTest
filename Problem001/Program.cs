using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem001
{
    /// <summary>
    /// 2024년 8월 5일
    /// 문제 : 숫자 비교하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120807
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = 0;
                return answer = num1 == num2 ? 1 : -1;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int num1 = 2;
            int num2 = 5;

            Console.WriteLine(s.solution(num1, num2));
        }
    }
}
