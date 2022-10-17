using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 두 큐 합 같게 만들기
/// 테스트 케이스 실패 21-27 30 런타임 에러
/// </summary>
namespace algorithm
{
    public class SolX2
    {
        public int solution(int[] queue1, int[] queue2)
        {
            Queue<int> que1 = new Queue<int>(queue1);
            Queue<int> que2 = new Queue<int>(queue2);
            long sum1 = (long)que1.Sum();
            long sum2 = (long)que2.Sum();

            int Maxtry = 2 * queue1.Length + 3;

            if ((sum1 + sum2) % 2 == 1)
                return -1;

            int answer = 0;

            while (sum1 != sum2)
            {
                if (answer >= Maxtry)
                {
                    answer = -1;
                    break;
                }
                else
                {
                    if (sum1 > sum2)
                    {
                        int now = que1.Dequeue();
                        que2.Enqueue(now);
                        sum2 += (long)now;
                        sum1 -= (long)now;
                        answer++;
                    }
                    else if (sum2 > sum1)
                    {
                        int now = que2.Dequeue();
                        que1.Enqueue(now);
                        sum1 += (long)now;
                        sum2 -= (long)now;
                        answer++;
                    }
                }
            }
            return answer;
        }
    }
}
