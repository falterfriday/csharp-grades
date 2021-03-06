﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;


namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is the grade book program.");

            Gradebook book = new Gradebook(); //constructor
            book.AddGrade(91);
            book.AddGrade(30);
            book.AddGrade(99);
            book.AddGrade(59);
            book.AddGrade(93);
            book.AddGrade(20);
            book.AddGrade(74);
            book.AddGrade(68);
            book.AddGrade(71);
            book.AddGrade(85.5f); //appending f allows float to be treated as a double

            //book = new Gradebook(); //wipes out previous instance of gradebook
            //book.AddGrade(60);

            Gradebook book2 = new Gradebook(); // new instance "book2"
            book2.AddGrade(75);

            Gradebook book3 = book; //creates a reference to original book (points to the memory address of book), NOT A COPY
            book3.AddGrade(99);

            GradeStats stats = book.ComputeStats();
            Console.WriteLine("Your average grade {0}", stats.AverageGrade);
            Console.WriteLine("Your highest grade {0}", stats.HighestGrade);
            Console.WriteLine("Your lowest grade {0}", stats.LowestGrade);
            Console.ReadKey();
        }
    }
}
