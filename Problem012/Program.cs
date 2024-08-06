using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem012
{
    /// <summary>
    /// 2024년 8월 6일
    /// 문제 : 양꼬치
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120830
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int n, int k)
            {
                int answer = 0;
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    count++;
                    if (count == 10)
                    {
                        count = 0;
                        k--;
                    }
                }
                return answer = n * 12000 + k * 2000;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int num1 = 10;
            int num2 = 3;

            Console.WriteLine(s.solution(num1, num2));
        }
    }
}
