using System;
using System.Collections.Generic;
using System.IO;
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
class MyBook:Book
{
    int price;
    public MyBook(string mytitle, string myauthor, int myprice):base(mytitle, myauthor)
        {
        title = mytitle;
        author = myauthor;
        price = myprice;
        }

    override public void display()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);

    }
}

class Program
{
    static void Main(string[] args)
    {
       
    }
}