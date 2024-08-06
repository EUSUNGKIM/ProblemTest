using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem013
{
    /// <summary>
    /// 2024년 8월 6일
    /// 문제 : 짝수 홀수 개수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120824
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int[] solution(int[] num_list)
            {
                int[] answer = new int[] { 0, 0 };
                for (int i = 0; i < num_list.Length; i++)
                {
                    if (num_list[i] % 2 == 0)
                        answer[0] += 1;
                    else
                        answer[1] += 1;
                }
                return answer;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            Solution s = new Solution();
            int[] reu = s.solution(numbers);
            Console.WriteLine($"{reu[0]}, {reu[1]}");
        }
    }
}
