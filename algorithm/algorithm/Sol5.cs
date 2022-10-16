using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.3
/// 숫자 게임
/// </summary>
namespace algorithm
{
    public class Sol5
    {
        public int solution(int[] A, int[] B)
        {
            int win = 0;
            List<int> a = new List<int>(A);
            List<int> b = new List<int>(B);
            a.Sort();
            b.Sort();

            int idxa = a.Count() - 1;
            int idxb = b.Count() - 1;
            while (idxa > -1)
            {
                if (b[idxb] > a[idxa])
                {
                    win++;
                    idxa--; idxb--;
                    continue;
                }
                else
                {
                    idxa--;
                    continue;
                }
            }
            return win;
        }
    }
}
