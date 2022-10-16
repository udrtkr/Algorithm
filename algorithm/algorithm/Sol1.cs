using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 타겟 넘버 
/// </summary>
namespace algorithm
{
    public class Sol1
    {
        
        int des, tar;
        int answer = 0;
        public void DFS(int sum, int n, int[] arr)
        {
            if (n < des)
            {
                DFS(sum + arr[n], n + 1, arr);
                DFS(sum - arr[n], n + 1, arr);
            }// 이 두개가 트리에서 두갈레로 나뉘는거 반복, 위에 if문에서 타겟과 같을 때 1 리턴이므로 조건 만족일 때 1 계속 더하니까 값 나옴
            else if (sum == tar)
                answer++;

        }
        public int solution(int[] numbers, int target)
        {
            des = numbers.Length;
            tar = target;
            DFS(0, 0, numbers);
            return answer;
        }

    }
    //즉 각 모든 경우의 수로 나뉜 갈레 결과에 따라 0, 1 중 하나가 부여되고 그 값들을 다 더하게 되는 셈
    //  0
    // / |
    //0   0
    /// | / |
    //0  00  0
    //=1  =0=0 =1 이런식으로 마지막 갈레의 return 을 더하게 되는

}
