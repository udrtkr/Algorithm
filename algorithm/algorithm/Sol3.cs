using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 카펫
/// </summary>
namespace algorithm
{
    public class Sol3
    {
        public int[] solution(int brown, int yellow)
        {
            int[] answer = new int[2];
            for (int i = 1; i <= Math.Sqrt(yellow); i++)
            {
                float ygaro = (float)yellow / i;
                if ((float)brown == ygaro * 2 + i * 2 + 4)
                {
                    answer[0] = (int)ygaro + 2;
                    answer[1] = i + 2;
                    break;
                }
            }
            return answer;
        }
    }
}
