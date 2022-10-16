using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 최댓값과 최솟값
/// </summary>
namespace algorithm
{
    public class Sol2
    {
        public string solution(string s)
        {
            string[] arr = s.Split(' ');
            string[] ans = new string[] { arr[0], arr[0] };

            for (int i = 1; i < arr.Length; i++)
            {
                if (int.Parse(ans[0]) > int.Parse(arr[i]))
                {
                    ans[0] = arr[i];
                    continue;
                }
                else if (int.Parse(ans[1]) < int.Parse(arr[i]))
                {
                    ans[1] = arr[i];
                    continue;
                }
            }

            return ans[0] + " " + ans[1];
        }
    }
}
