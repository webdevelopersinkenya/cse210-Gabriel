using System;
using System.Threading;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Select an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("0. Quit");
                Console.WriteLine();

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        break;

                    case "2":
                        ReflectionActivity reflection = new ReflectionActivity();
                        reflection.Run();
                        break;

                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        break;

                    case "0":
                        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

    class MindfulnessActivity : WritingAssignment
    {
        protected int duration;

        public MindfulnessActivity(string name, string description) : base(name, description)
        {
            duration = 0;
        }

        protected void DisplayStartingMessage()
        {
            Console.WriteLine("Starting " + name + " activity.");
            Console.WriteLine(description);
            Console.WriteLine();

            Console.WriteLine("Please enter the duration of the activity in seconds:");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Preparing to begin in:");
            Countdown(3);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine("Great job! You have completed the " + name + " activity.");
            Console.WriteLine("Total time: " + duration + " seconds.");
            Console.WriteLine();

            Console.WriteLine("Taking a moment to reflect...");
            Countdown(3);
        }

        protected void Countdown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }

            Console.WriteLine();
        }
    }

    class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public void Run()
        {
            DisplayStartingMessage();

            for (int i = 0; i < duration; i += 4)
            {
                Console.WriteLine("Breathe in...");
                Countdown(2);

                Console.WriteLine("Breathe out...");
                Countdown(2);
            }

            DisplayEndingMessage();
        }
    }

    class ReflectionActivity : MindfulnessActivity
    {
        private string[] prompts = { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        private string[] questions = { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about
