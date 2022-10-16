using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.3
/// 가장 먼 노드
/// </summary>
namespace algorithm
{
    // 가중치x BFS 사용
    public class Sol7
    {
        int[,] map;
        public int solution(int n, int[,] edge)
        {
            map = new int[n + 1, n + 1];
            for (int i = 0; i < edge.GetLength(0); i++)
            {
                map[edge[i, 0], edge[i, 1]] = 1;
                map[edge[i, 1], edge[i, 0]] = 1;
            }
            List<int> distance = new List<int>(BFS(1));

            int max = distance.Max();
            int answer = distance.Count(val => val == max);

            return answer;
        }

        public int[] BFS(int start)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            bool[] isCheck = new bool[map.GetLength(0)];
            isCheck[start] = true;

            int[] dist = new int[map.GetLength(0)];
            dist[start] = 0;

            while (queue.Count > 0)
            {
                int cur = queue.Dequeue();

                for (int next = 1; next < map.GetLength(0); next++)
                {
                    if (map[cur, next] == 0)
                        continue;
                    if (isCheck[next])
                        continue;

                    queue.Enqueue(next);
                    isCheck[next] = true;
                    dist[next] = dist[cur] + 1;
                }
            }
            return dist;
        }
    }
}
