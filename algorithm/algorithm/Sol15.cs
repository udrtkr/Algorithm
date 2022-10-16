using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 프린터
/// </summary>
namespace algorithm
{
    public class Sol15
    {
        public int solution(int[] priorities, int location)
        {
            int answer = 0;
            Queue<KeyValuePair<int, int>> queue = new Queue<KeyValuePair<int, int>>();
            for (int i = 0; i < priorities.Length; i++)
            {
                queue.Enqueue(new KeyValuePair<int, int>(i, priorities[i]));
            }

            while (true)
            {
                int max = queue.Max(x => x.Value);
                KeyValuePair<int, int> cur = queue.Dequeue();
                if (cur.Value == max)
                {
                    if (cur.Key == location)
                    {
                        answer++;
                        break;
                    }
                    else
                    {
                        answer++;
                    }
                }
                else
                {
                    queue.Enqueue(cur);
                }
            }
            return answer;
        }
    }
}
