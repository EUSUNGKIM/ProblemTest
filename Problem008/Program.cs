using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem008
{
    /// <summary>
    /// 2024년 8월 5일
    /// 문제 : 배열의 평균값
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120817
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public double solution(int[] numbers)
            {
                double sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum / numbers.Length;
            }
            static void Main(string[] args)
            {
                int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Solution s = new Solution();
                Console.WriteLine(s.solution(numbers));
            }
        }
    }
}
