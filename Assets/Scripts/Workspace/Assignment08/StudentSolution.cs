using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment08
{
    public class StudentSolution : IAssignment
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public void LCT01_StackSyntax()
        {
            throw new NotImplementedException();
        }

        public void LCT02_QueueSyntax()
        {
            throw new NotImplementedException();
        }

        public void LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            throw new NotImplementedException();
        }

        public void LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            throw new NotImplementedException();
        }

        #endregion

        #region Assignment

        public void ASN01_ReverseString(string str)
        {
            Stack<string> stack = new Stack<string>();
            string reversed = "";
            foreach (char c in str)
            {
                stack.Push($"{c}");
            }
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }
            Debug.Log(reversed);
        }

        public void ASN02_StackPalindrome(string str)
        {
            Stack<string> stack = new Stack<string>();
            string reversed = "";
            foreach (char c in str)
            {
                stack.Push($"{c}");
            }
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            if (reversed == str)
            {
                Debug.Log("is a palindrome");
            }
            else
            {
                Debug.Log("is not a palindrome");
            }
        }

        #endregion

        #region Extra

        public void EX01_ParenthesesChecker(string str)
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
                        Debug.Log("Unbalanced");
                        return;
                    }
                    char open = stack.Pop();
                    if (!IsMatching(open, c))
                    {
                        Debug.Log("Unbalanced");
                        return;
                    }
                }
            }
            if (stack.Count == 0)
            {
                Debug.Log("Balanced");
            }
            else
            {
                Debug.Log("Unbalanced");
            }
        }
        private bool IsMatching(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }
        #endregion
    }
}
