using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.3
/// 네트워크
/// </summary>
namespace algorithm
{
    public class Sol4
    {
        public int solution(int n, int[,] computers)
        {
            return BFS(0, n, computers);
        }

        public int BFS(int start, int nodelen, int[,] computer)
        {
            bool[] node = new bool[nodelen];
            List<bool> nodes = new List<bool>(node);
            nodes[start] = true;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            int reNum = 1;

            while (queue.Count > 0)
            {
                int now = queue.Dequeue();
                for (int next = 1; next < nodelen; next++)
                {
                    if (nodes[next])
                        continue;
                    if (computer[now, next] == 0)
                        continue;
                    if (now == next)
                        continue;
                    queue.Enqueue(next);
                    nodes[next] = true;
                }
                if (queue.Count == 0)
                {
                    if (nodes.IndexOf(false) > 0)
                    {
                        reNum++;
                        int idx = nodes.IndexOf(false);
                        queue.Enqueue(idx);
                        nodes[idx] = true;
                    }
                    else
                        break;
                }
            }
            return reNum;
        }
    }
}
