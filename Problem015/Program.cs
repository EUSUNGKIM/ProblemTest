using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem015
{
    /// <summary>
    /// 2024년 8월 6일
    /// 문제 : 배열 두배 만들기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120809
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int[] solution(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }
                return numbers;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 100, -99, 1,2,3 };
            Solution s = new Solution();
            int[] reu = s.solution(numbers);
            for (int i = 0;i < reu.Length;i++)
            {
                Console.Write($"{reu[i]} ");
            }
        }
    }
}
