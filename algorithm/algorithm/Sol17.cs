using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 스킬트리
/// </summary>
namespace algorithm
{
    public class Sol17
    {
        public int solution(string skill, string[] skill_trees)
        {
            int answer = 0;

            foreach (string skill_tree in skill_trees)
            {
                answer += AAA(skill, skill_tree);
            }

            return answer;
        }
        public int AAA(string skill, string skill_tree)
        {
            List<int> num = new List<int>();
            for (int i = 0; i < skill_tree.Length; i++)
            {
                for (int j = 0; j < skill.Length; j++)
                {
                    if (skill_tree[i] == skill[j])
                    {
                        num.Add(j);
                    }
                }
            }
            if (num.Count == 0)
                return 1;
            else if (num.Count == 1)
            {
                if (num[0] == 0)
                    return 1;
                else
                    return 0;
            }
            else
            {
                if (num[0] != 0)
                    return 0;
                for (int i = 0; i < num.Count - 1; i++)
                {
                    if (num[i + 1] - num[i] != 1)
                        return 0;
                    else
                        continue;
                }
                return 1;
            }
        }
    }
}
