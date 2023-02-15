using System;
namespace JournalProgram
{
    public class Entry
    {
        public DateTime Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public Entry(DateTime date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }
    }

    public class Journal
    {
        private List<Entry> entries = new List<Entry>();
        private Random random = new Random();

        public void WriteEntry()
        {
            string[] prompts = { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };

            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            string response = Console.ReadLine();

            Entry entry = new Entry(DateTime.Now, prompt, response);
            entries.Add(entry);
        }

        public void DisplayJournal()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine($"{entry.Date.ToString("dd/MM/yyyy")}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
            }
        }

        public void SaveJournal()
        {
            Console.Write("Enter filename to save journal: ");
            string filename = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    sw.WriteLine($"{entry.Date.ToString("dd/MM/yyyy")},{entry.Prompt},{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved.");
        }

        public void LoadJournal()
        {
            Console.Write("Enter filename to load journal: ");
            string filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                entries.Clear();
                using (StreamReader sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');
                        DateTime date = DateTime.ParseExact(values[0], "dd/MM/yyyy", null);
                        Entry entry = new Entry(date, values[1], values[2]);
                        entries.Add(entry);
                    }
                }
                Console.WriteLine("Journal loaded.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            int choice = 0;

            while (true)
            
            {
                Console.WriteLine("Journal Program");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            journal.WriteEntry();
                            break;
                        case 2:
                            journal.DisplayJournal();
                            break;
                        case 3:
                            journal.SaveJournal();
                            break;
                        case 4:
                            journal.LoadJournal();
                            break;
                        case 5:
                            Console.WriteLine("Exiting program.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an event");
                }
            }
        }
    }
}
