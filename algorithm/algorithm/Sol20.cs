using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 쿼드압축 후 개수 세기
/// </summary>
namespace algorithm
{
    public class Sol20
    {
        int[] answer = new int[2];
        public int[] solution(int[,] arr)
        {
            Quad(arr, 0, 0, arr.GetLength(0));
            return answer;
        }

        public void Quad(int[,] arr, int sx, int sy, int n)
        {
            int num = arr[sx, sy];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[sx + i, sy + j] != num)
                    {
                        Quad(arr, sx + n / 2, sy, n / 2);
                        Quad(arr, sx, sy + n / 2, n / 2);
                        Quad(arr, sx + n / 2, sy + n / 2, n / 2);
                        Quad(arr, sx, sy, n / 2);
                        return;
                    }
                }
            }
            answer[num]++;
        }
    }
}
