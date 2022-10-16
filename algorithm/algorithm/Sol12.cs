using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 프로그래머스 Lv.2
/// 괄호 회전하기
/// </summary>
namespace algorithm
{
    public class Sol12
    {
        public int solution(string s)
        {
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < s.Length; i++)
            {
                queue.Enqueue(s[i]);
            }
            int answer = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                answer += gg(queue.ToArray());
                char d = queue.Dequeue();
                queue.Enqueue(d);
            }

            return answer;
        }

        public int gg(char[] que)
        {
            Stack<char> stack = new Stack<char>();
            Queue<char> q = new Queue<char>(que);
            while (q.Count > 0)
            {
                char now = q.Dequeue();
                if (now == ')' || now == '}' || now == ']')
                {
                    if (stack.Count == 0)
                        return 0;
                    switch (stack.Peek())
                    {
                        case '(':
                            if (now == ')')
                                stack.Pop();
                            break;
                        case '{':
                            if (now == '}')
                                stack.Pop();
                            break;
                        case '[':
                            if (now == ']')
                                stack.Pop();
                            break;
                        default:
                            break;
                    }
                    continue;
                }
                else
                    stack.Push(now);
            }
            if (stack.Count == 0)
                return 1;
            else
                return 0;
        }
    }
}
