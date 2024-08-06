using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem009
{
    /// <summary>
    /// 2024년 8월 6일
    /// 문제 : 각도기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120829
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int angle)
            {
                int answer = angle < 90 ? 1 : angle == 90 ? 2 : angle < 180 ? 3 : 4;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int num1 = 91;

            Console.WriteLine(s.solution(num1));
        }
    }
}
