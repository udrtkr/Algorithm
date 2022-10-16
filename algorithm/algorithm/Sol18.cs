using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 게임 맵 최단거리
/// </summary>
namespace algorithm
{
    public class Sol18
    {
        int[] dx = new int[] { 1, -1, 0, 0 };
        int[] dy = new int[] { 0, 0, 1, -1 };
        public int solution(int[,] maps)
        {
            return BFS(0, 0, maps);
        }

        public int BFS(int sx, int sy, int[,] map)
        {
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((sx, sy));

            while (queue.Count > 0)
            {
                (int x, int y) = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];
                    if ((nx >= 0 && nx < map.GetLength(0)) &&
                       (ny >= 0 && ny < map.GetLength(1)) && map[nx, ny] == 1)
                    {
                        queue.Enqueue((nx, ny));
                        map[nx, ny] = map[x, y] + 1;
                    }
                }
            }
            if (map[map.GetLength(0) - 1, map.GetLength(1) - 1] == 1)
                return -1;
            else
                return map[map.GetLength(0) - 1, map.GetLength(1) - 1];
        }
    }
}
