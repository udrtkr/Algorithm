using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.3
/// 섬 연결하기
/// </summary>
namespace algorithm
{
    public class Sol8
    {
        public int solution(int n, int[,] costs)
        {
            int[,] map = new int[n, n];
            for (int i = 0; i < costs.GetLength(0); i++)
            {
                map[costs[i, 0], costs[i, 1]] = costs[i, 2];
                map[costs[i, 1], costs[i, 0]] = costs[i, 2];
            }

            int answer = 0;
            HashSet<int> check = new HashSet<int>();
            check.Add(0);
            int checkCount = 1;

            while (checkCount < n)
            {
                int min = 999999;
                int minidx = 0;
                foreach (int now in check) // 연결 된 노드 에서 선 연결
                {
                    for (int next = 0; next < n; next++)
                    {
                        if (check.Contains(next)) // 이미 연결되어 있으면 continue
                            continue;
                        if (map[now, next] > 0)
                        {
                            if (map[now, next] < min)
                            {
                                minidx = next;
                                min = map[now, next];
                            }
                        }
                    }
                }
                check.Add(minidx);
                checkCount++;
                answer += min;
            }
            return answer;
        }
    }
}
