using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.3
/// 기지국 설치
/// </summary>
namespace algorithm
{
    public class Sol6
    {
        public int solution(int n, int[] stations, int w)
        {
            int answer = 0;

            bool[] check = new bool[n + 1];
            foreach (int i in stations)
            {
                for (int j = i - w; j <= i + w; j++)
                {
                    if (j > 0 && j < n + 1)
                    {
                        check[j] = true;
                    }
                }
            }
            // 첨부터 반복하면서 t/f 가져옴
            List<int> fnums = new List<int>();
            int fnum = 0;
            for (int i = 1; i < n + 1; i++)
            {
                if (!check[i])
                {
                    fnum++;
                    if (i == n)
                    {
                        fnums.Add(fnum);
                    }
                }
                if (check[i])
                {
                    if (!check[i - 1])
                    {
                        fnums.Add(fnum);
                        fnum = 0;
                    }
                    continue;
                }
            }

            foreach (int num in fnums)
            {
                answer += (int)(Math.Ceiling((double)num / (w * 2 + 1)));
            }
            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
            System.Console.WriteLine("Hello C#");

            return answer;
        }
    }
}
