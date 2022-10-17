using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 가장 긴 팰린드롬
/// 테스트 케이스 실패 6 12
/// </summary>
namespace algorithm
{
    public class SolX3
    {
        public int solution(string s)
        {
            int len = s.Length;
            HashSet<int> sums = new HashSet<int>();
            sums.Add(0);
            if (len > 0)
                sums.Add(1);
            /*
            if(s.Length==0)
                return 0;
            if(s.Length==1)
                return 1;
            if(s.Length==2)
                return s[0].Equals[1] ? 2 : 1;
            */
            if (len > 2)
            {
                for (int i = 1; i < s.Length - 1; i++)
                {
                    if (s[i - 1].Equals(s[i + 1]))
                    {
                        sums.Add(DP(i - 2, i + 2, s, 3));
                        continue;
                    }
                    else if (s[i - 1].Equals(s[i]))
                    {
                        sums.Add(DP(i - 2, i + 1, s, 2));
                        continue;
                    }
                    else if (s[i].Equals(s[i + 1]))
                    {
                        sums.Add(DP(i - 1, i + 2, s, 2));
                    }
                    else
                        continue;
                }
            }
            else if (len == 2)
            {
                if (s[0].Equals(s[1]))
                    sums.Add(2);
            }
            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            System.Console.WriteLine("Hello C#");

            return sums.Max();
        }
        public int DP(int next1, int next2, string ss, int sum)
        {
            if (next1 < 0 || next2 >= ss.Length)
                return sum;
            if (ss[next1].Equals(ss[next2]))
            {
                sum += 2;
                return DP(next1 - 1, next2 + 1, ss, sum);
            }
            else
                return sum;
        }
    }
}
