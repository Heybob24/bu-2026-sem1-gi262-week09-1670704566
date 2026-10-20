using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int count = stack.Count;
            Debug.Log($"count: {count}");
            int popped = stack.Pop();
            Debug.Log($"pop: {popped}");
            int peek = stack.Peek();
            int countAfterPeek = stack.Count;

            return (count, popped, peek, countAfterPeek);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int count = queue.Count;
            int dequeued = queue.Dequeue();
            int peek = queue.Peek();
            int countAfterPeek = queue.Count;

            return (count, dequeued, peek, countAfterPeek);
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Stack<Action> stack = new Stack<Action>();

            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);

            string[] result = new string[3];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = stack.Pop().Name;
            }

            return result;
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Queue<Action> queue = new Queue<Action>();

            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);

            string[] result = new string[3];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = queue.Dequeue().Name;
            }

            return result;
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            char[] result = new char[str.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = stack.Pop();
            }

            return new string(result);
        }

        public bool ASN02_StackPalindrome(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            foreach (char c in str)
            {
                if (c != stack.Pop())
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char opening = stack.Pop();

                    if ((c == ')' && opening != '(') ||
                        (c == ']' && opening != '[') ||
                        (c == '}' && opening != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        #endregion
    }
}
