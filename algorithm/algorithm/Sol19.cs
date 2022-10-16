using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 다리를 지나는 트럭
/// </summary>
namespace algorithm
{
    // queue로 while 안에서 하나씩 Enqueue, 각 트럭이 bridge_length만큼 지나면 Dequeue
    public class Sol19
    {
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;
            int l = truck_weights.Length;
            Queue<int> q = new Queue<int>(truck_weights);
            Queue<int> q1 = new Queue<int>();
            int tryn = 0;
            List<int> time = new List<int>(); // 다리 길이 넣고 빼가면서 0이면 리무브

            while (tryn < l)
            {
                answer++;
                for (int i = 0; i < time.Count; i++)
                {
                    time[i]--;
                }
                if (q1.Count > 0)
                {
                    if (time[0] == 0)
                    {
                        q1.Dequeue();
                        tryn++;
                        time.RemoveAt(0);
                    }
                }
                if (q.Count > 0)
                {
                    if (q1.Count < bridge_length && q1.Sum() + q.Peek() <= weight)
                    {
                        int now = q.Dequeue();
                        q1.Enqueue(now);
                        time.Add(bridge_length);
                    }
                }

            }
            return answer;
        }
    }
}
