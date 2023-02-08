using System;

public class Scripture
{
    private string book;
    private int chapter;
    private int verse;
    private string text;

    public string Book
    {
        get { return book; }
        set { book = value; }
    }

    public int Chapter
    {
        get { return chapter; }
        set { chapter = value; }
    }

    public int Verse
    {
        get { return verse; }
        set { verse = value; }
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    public void Display()
    {
        Console.WriteLine(book + " " + chapter + ":" + verse + " - " + text);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.Book = "Proverb";
        scripture.Chapter = 3;
        scripture.Verse = 5 - 6;
        scripture.Text = "Trust in the Lorad with all thine heart and leane not unto thine own understanding; In all thine ways acknowledge Him and He shall direct thy paths.";

        scripture.Display();
    }
}