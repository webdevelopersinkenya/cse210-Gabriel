using System;


class Scripture
{
    private string reference;
    private string text;
    private List<int> hiddenWords = new List<int>();

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
    }

    public void HideWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int wordIndex = random.Next(text.Split(' ').Length);
            if (!hiddenWords.Contains(wordIndex))
            {
                hiddenWords.Add(wordIndex);
            }
        }
    }

    public bool IsFullyHidden()
    {
        return hiddenWords.Count == text.Split(' ').Length;
    }

    public override string ToString()
    {
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (hiddenWords.Contains(i))
            {
                words[i] = new string('_', words[i].Length);
            }
        }
        return $"{reference}: {string.Join(' ', words)}";
    }
    public class Reference
    {
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int VerseStart { get; set; }
    public int VerseEnd { get; set; }
    
       
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.Book = book;
        this.Chapter = chapter;
        this.VerseStart = verseStart;
        this.VerseEnd = verseEnd;
    }
    
    public string GetReference()
    {
        if (this.VerseStart == this.VerseEnd)
        {
            return $"{this.Book} {this.Chapter}:{this.VerseStart}";
        }
        else
        {
            return $"{this.Book} {this.Chapter}:{this.VerseStart}-{this.VerseEnd}";
        }
    }


    public class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }
    
    public Word(string text)
    {
        this.Text = text;
        this.Hidden = false;
    }
    
    public string GetText()
    {
        if (this.IsHidden)
        {
            return new String('_', this.Text.Length);
        }
    
        else
        {
            return this.Text;
        }
    }
        class Program
    {
    static void Main(string[] args)
    {
        // Create a scripture reference
        Reference scriptureRef = new Reference("John", 3, 16);
        
        // Create a list of words from the scripture text
        List<Word> words = new List<Word>();
        words.Add(new Word("For"));
        words.Add(new Word("God"));
        words.Add(new Word("so"));
        words.Add(new Word("loved"));
        words.Add(new Word("the"));
        words.Add(new Word("world,"));
        words.Add(new Word("that"));
        words.Add(new Word("he"));
        words.Add(new Word("gave"));
        words.Add(new Word("his"));
        words.Add(new Word("only"));
        words.Add(new Word("Son,"));
        words.Add(new Word("that"));
        words.Add(new Word("whoever"));
        words.Add(new Word("believes"));
        words.Add(new Word("in"));
        words.Add(new Word("him"));
        words.Add(new Word("should"));
        words.Add(new Word("not"));
        words.Add(new Word("perish"));
        words.Add(new Word("but"));
        words.Add(new Word("have"));
        words.Add(new Word("eternal"));
        words.Add(new Word("life."));
        
        // Print the complete scripture
        Console.WriteLine(scriptureRef.GetReference());
        foreach (Word word in words)
        {
            Console.Write($"{word.GetText()} ");
        }
        Console.WriteLine();
        
        // Prompt user to press enter to hide some words
        Console.WriteLine("Press enter to hide some words or type quit to end.");
        string input = Console.ReadLine();
        
        // Hide words until all words are hidden or user types quit
        while (input != "quit")
        {
            // Randomly hide some words
            int wordsToHide = new Random().Next(1, words.Count + 1);
            List<int> indicesToHide = new List<int>();
            
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.WriteLine(scripture.ToString());
        Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");
        }
    }
}
}




        
       
