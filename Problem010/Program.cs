using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem010
{
    /// <summary>
    /// 2024년 8월 6일
    /// 문제 : 짝수의 합
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120831
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 == 0)
                        answer += i;
                }
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int num1 = 10;

            Console.WriteLine(s.solution(num1));
        }
    }
}
