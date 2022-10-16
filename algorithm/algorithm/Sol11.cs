using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 점프와 순간이동
/// </summary>
namespace algorithm
{
    public class Sol11
    {
        public int solution(int n)
        {
            int dis = n;
            int answer = 0;
            while (dis > 0)
            {
                if (dis % 2 == 1)
                {
                    dis--;
                    answer++;
                }
                dis /= 2;
            }
            return answer;
        }
    }
}
