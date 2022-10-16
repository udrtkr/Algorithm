using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.3
/// 순위
/// </summary>
namespace algorithm
{
    public class Sol9
    {
        int[,] map;
        public int solution(int n, int[,] results)
        {
            map = new int[n + 1, n + 1];
            for (int i = 0; i < results.GetLength(0); i++)
            {
                map[results[i, 0], results[i, 1]] = 1;
            }

            int answer = 0;
            for (int idx = 1; idx <= n; idx++)
            {
                answer += BFS(idx, n, map);
            }
            return answer;
        }
        // main 함수에서 for 문 사용하여 start 변경 1~n
        int BFS(int start, int num, int[,] map)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            HashSet<int> checkedWin = new HashSet<int>();
            HashSet<int> checkedLos = new HashSet<int>();
            bool[,] mapWin = new bool[num + 1, num + 1];
            bool[,] mapLos = new bool[num + 1, num + 1];


            // 다음 map마다 그 숫자 ++ 해서 HashSet에 추가
            // 이긴거 진거 두가지 다해야댐
            // HashSet 의 개수가 n-1 모두 다 있으면 답 ++

            // 이기는거
            while (queue.Count > 0)
            {
                int now = queue.Dequeue();
                for (int next = 1; next <= num; next++)
                {
                    if (next == start)
                        continue;
                    if (mapWin[now, next] == true)
                        continue;
                    if (map[now, next] == 1)
                    {
                        queue.Enqueue(next);
                        checkedWin.Add(next);
                        mapWin[now, next] = true;
                    }
                }
            }

            queue.Enqueue(start);
            // 지는거
            while (queue.Count > 0)
            {
                int now = queue.Dequeue();
                for (int next = 1; next <= num; next++)
                {
                    if (next == start)
                        continue;
                    if (mapLos[next, now] == true)
                        continue;
                    if (map[next, now] == 1)
                    {
                        queue.Enqueue(next);
                        checkedLos.Add(next);
                        mapLos[next, now] = true;
                    }
                }
            }
            if (checkedWin.Count + checkedLos.Count == num - 1)
                return 1;
            else
                return 0;
        }
    }
}
