using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 전력망을 둘로 나누기
/// </summary>
namespace algorithm
{
    public class Sol23
    {
        bool[,] mat;
        public int solution(int n, int[,] wires)
        {
            int answer = n - 1;
            mat = new bool[n + 1, n + 1];
            for (int i = 0; i < wires.GetLength(0); i++)
            {
                mat[wires[i, 0], wires[i, 1]] = true;
                mat[wires[i, 1], wires[i, 0]] = true;
            }

            for (int i = 0; i < wires.GetLength(0); i++)
            {
                bool[] check = new bool[n + 1];
                check[wires[i, 0]] = true;
                check[wires[i, 1]] = true;
                int sum1 = bfs(wires[i, 0], check, n);
                int sum2 = bfs(wires[i, 1], check, n);
                answer = Math.Abs(sum1 - sum2) < answer ? Math.Abs(sum1 - sum2) : answer;
                if (answer == 0)
                    break;
            }

            return answer;
        }

        public int bfs(int start, bool[] check, int n)
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(start);

            int sum = 1;

            List<bool> ch = new List<bool>(check);
            // 시작 노드 미리 check에 true로 넣자
            while (que.Count > 0)
            {
                int now = que.Dequeue();
                for (int next = 1; next < n + 1; next++)
                {
                    if (ch[next])
                        continue;
                    if (!mat[now, next])
                        continue;
                    que.Enqueue(next);
                    ch[next] = true;
                    sum++;
                }
            }
            return sum;
        }
    }
}
