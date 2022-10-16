using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 삼각 달팽이
/// </summary>
namespace algorithm
{
    public class Sol21
    {
        public int[] solution(int n)
        {
            int[] answer = new int[n * (n + 1) / 2];
            int[,] mat = new int[n, n];
            int r = -1;
            int c = 0;
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    switch (i % 3)
                    {
                        case 0:
                            r++;
                            break;
                        case 1:
                            c++;
                            break;
                        case 2:
                            r--; c--;
                            break;
                        default:
                            break;
                    }
                    num++;
                    mat[r, c] = num;
                }
            }

            int a = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == 0)
                        break;
                    answer[a] = mat[i, j];
                    a++;
                }
            }

            return answer;
        }
    }
}
