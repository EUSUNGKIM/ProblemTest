using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem014
{
    /// <summary>
    /// 2024년 8월 6일
    /// 문제 : 중복된 숫자 개수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120583
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int[] array, int n)
            {
                int answer = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == n)
                    {
                        answer++;
                    }
                }
                return answer;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 3, 4, 5 };
            int a = 3;
            Solution s = new Solution();
            Console.WriteLine(s.solution(numbers, a));
        }
    }
}
