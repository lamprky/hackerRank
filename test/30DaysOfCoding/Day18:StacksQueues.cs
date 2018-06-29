using System;
using System.Collections.Generic;
using System.IO;

/*
 * Source: https://www.hackerrank.com/challenges/30-queues-stacks/problem
*/

namespace test.DaysOfCoding
{
    public class StacksQueues
    {
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();

        private void pushCharacter(char ch)
        {
            stack.Push(ch);
        }

        private void enqueueCharacter(char ch)
        {
            queue.Enqueue(ch);
        }

        private char popCharacter()
        {
            return stack.Pop();
        }

        private char dequeueCharacter()
        {
            return queue.Dequeue();
        }

        public void Main()
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            StacksQueues obj = new StacksQueues();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}