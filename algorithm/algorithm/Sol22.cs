using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 배달 (다익스트라)
/// </summary>
namespace algorithm
{
    public class Sol22
    {
        public int solution(int N, int[,] road, int K)
        {
            int answer = 0;
            int[] nodes = new int[N + 1];
            int[,] map = new int[N + 1, N + 1];
            for (int i = 0; i < road.GetLength(0); i++)
            {
                if (map[road[i, 0], road[i, 1]] > 0)
                {
                    if (map[road[i, 0], road[i, 1]] > road[i, 2])
                    {
                        map[road[i, 0], road[i, 1]] = road[i, 2];
                        map[road[i, 1], road[i, 0]] = road[i, 2];
                        continue;
                    }
                    else
                        continue;
                }
                map[road[i, 0], road[i, 1]] = road[i, 2];
                map[road[i, 1], road[i, 0]] = road[i, 2];
            }
            if (nodes.Length > 2)
            {
                for (int i = 2; i < nodes.Length; i++)
                {
                    nodes[i] = 500000;
                }
            }

            for (int t = 0; t < N; t++)
            {
                for (int now = 1; now <= N; now++)
                {
                    for (int next = 1; next <= N; next++)
                    {
                        if (map[now, next] > 0)
                        {
                            if (nodes[next] > nodes[now] + map[now, next])
                            {
                                nodes[next] = nodes[now] + map[now, next];
                                continue;
                            }
                            else
                                continue;
                        }
                    }
                }
            }
            for (int i = 1; i < nodes.Length; i++)
            {
                if (nodes[i] <= K)
                    answer++;
            }
            return answer;
        }
    }
}
