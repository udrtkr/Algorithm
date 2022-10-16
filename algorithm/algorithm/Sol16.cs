using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 피로도 (완전탐색)
/// </summary>
namespace algorithm
{
    public class Sol16
    {
        int answer = -1;
        bool[] check;
        public int solution(int k, int[,] dungeons)
        {
            check = new bool[dungeons.GetLength(0)];

            return Algo(k, check, dungeons, 0);
        }

        public int Algo(int k, bool[] check, int[,] dungeons, int n)
        {
            for (int i = 0; i < dungeons.GetLength(0); i++)
            {
                if (k >= dungeons[i, 0] && !check[i])
                {
                    check[i] = true;
                    Algo(k - dungeons[i, 1], check, dungeons, n + 1);
                    check[i] = false;
                }
            }
            answer = answer > n ? answer : n;
            return answer;
        }
    }
}
