using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 기능개발
/// </summary>
namespace algorithm
{
    public class Sol14
    {
        public int[] solution(int[] progresses, int[] speeds)
        { // <= 100 둘 크기 똑같 각각의 스피드 담김
            List<int> answer = new List<int>();
            Queue<int> queueProg = new Queue<int>(progresses);
            Queue<int> queueSpeeds = new Queue<int>(speeds);

            int proNum = 0;


            while (queueProg.Count > 0)
            {
                // 각 요소별로 빼면서 speeds + 해주어 다시 엔큐
                for (int i = 0; i < queueProg.Count; ++i)
                {
                    int progAt = 0;
                    int speedAt = 0;
                    progAt = queueProg.Dequeue();
                    speedAt = queueSpeeds.Dequeue();
                    progAt += speedAt;
                    queueProg.Enqueue(progAt);
                    queueSpeeds.Enqueue(speedAt);
                }

                if (queueProg.Count > 0)
                {
                    while (queueProg.Peek() >= 100)
                    {
                        queueProg.Dequeue();
                        proNum++;
                        queueSpeeds.Dequeue();

                        if (queueProg.Count <= 0)
                            break;
                    }
                }




                if (proNum > 0)
                {
                    answer.Add(proNum);
                    proNum = 0;
                }
            }

            return answer.ToArray(); // <100
        }
    }
}
