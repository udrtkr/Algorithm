using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 위장
/// </summary>
namespace algorithm
{
    public class Sol13
    {
        public int solution(string[,] clothes)
        {
            Dictionary<string, List<string>> clothe = new Dictionary<string, List<string>>();

            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if (!clothe.ContainsKey(clothes[i, 1]))
                    clothe.Add(clothes[i, 1], new List<string>());
                clothe[clothes[i, 1]].Add(clothes[i, 0]);
            }
            int a = 1;
            // 조합 곱 각 키마다 value count + 1(안 입는 경우 플러스) 해서 곱한 후 아무것도 안 입는 경우 해서 마지막에 -1;
            foreach (var item in clothe.Keys)
            {
                a *= clothe[item].Count() + 1;
            }

            return a - 1;
        }
    }
}
