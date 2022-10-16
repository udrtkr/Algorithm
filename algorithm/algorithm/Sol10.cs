using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 영어 끝말잇기
/// </summary>
namespace algorithm
{
    public class Sol10
    {
        public int[] solution(int n, string[] words)
        {
            int[] answer = new int[2];
            List<string> list = new List<string>();
            list.Add(words[0]);

            for (int i = 1; i < words.Length; i++)
            {
                if ((words[i][0] != words[i - 1][words[i - 1].Length - 1]) || list.Contains(words[i]))
                {
                    answer[0] = (i + 1) % n == 0 ? n : (i + 1) % n;
                    answer[1] = (int)Math.Ceiling((double)(i + 1) / n);
                    break;
                }
                else
                {
                    list.Add(words[i]);
                }
            }
            return answer;
        }
    }
}
