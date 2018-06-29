using System;
using System.Collections.Generic;
using System.IO;

/*
 * Source: https://www.hackerrank.com/challenges/30-abstract-classes/problem
*/

namespace test.DaysOfCoding
{
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

    class MyBook : Book
    {
        protected int price;

        public MyBook(String t, String a, int p) : base(t, a)
        {
            title = t;
            author = a;
            price = p;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);

        }
    }

    public class AbstractClass
    {
        public void Main()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}