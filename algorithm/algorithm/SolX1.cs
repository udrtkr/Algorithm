using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 방문 길이
/// 테스트 케이스 실패 1 5 6 18
/// </summary>
namespace algorithm
{
    public class SolX1
    {
        public int solution(string dirs)
        {
            int answer = 0;

            HashSet<string> check = new HashSet<string>();

            string currow = "5";
            string curcol = "5";
            string prevrow = currow;
            string prevcol = curcol;
            for (int i = 0; i < dirs.Length; i++)
            {
                prevrow = currow;
                prevcol = curcol;
                if (dirs[i] == 'U')
                {
                    if (int.Parse(currow) < 10)
                    {
                        currow = (int.Parse(currow) + 1).ToString();
                        check.Add(prevrow + currow + prevcol + curcol);
                        check.Add(currow + prevrow + curcol + prevcol);
                    }
                    else
                        continue;
                }
                else if (dirs[i] == 'D')
                {
                    if (int.Parse(currow) > 0)
                    {
                        currow = (int.Parse(currow) - 1).ToString();
                        check.Add(prevrow + currow + prevcol + curcol);
                        check.Add(currow + prevrow + curcol + prevcol);
                    }
                    else
                        continue;
                }
                else if (dirs[i] == 'R')
                {
                    if (int.Parse(curcol) < 10)
                    {
                        curcol = (int.Parse(curcol) + 1).ToString();
                        check.Add(prevrow + currow + prevcol + curcol);
                        check.Add(currow + prevrow + curcol + prevcol);
                    }
                    else
                        continue;
                }
                else
                {
                    if (int.Parse(curcol) > 0)
                    {
                        curcol = (int.Parse(curcol) - 1).ToString();
                        check.Add(prevrow + currow + prevcol + curcol);
                        check.Add(currow + prevrow + curcol + prevcol);
                    }
                    else
                        continue;
                }
            }
            return check.Count / 2;
        }
    }
}
