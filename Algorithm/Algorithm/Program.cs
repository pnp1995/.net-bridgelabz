// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    namespace Algorithm
    {
        class Program
        {
            static void Main(string[] args)
            {
                int choice;
                Console.Write("1.Anagram\n2.PrimeNumber\n3.QuestionNumber\n4.BubbleSort\n5.InsertionSort\n6.MergeSort\n7.VendingMachine");
                Console.WriteLine("\n8.GregorianCalender\n9.Tempreature\n10.MonthlyPayment\n11.SquareRoot\n12.DecimalNumber\n13.SearchTextFile");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());

        
                switch (choice)
                {
                    case 1:
                        Anagram ana = new Anagram();
                        ana.AreAnagram();
                        break;
                    case 2:
                       
                        PrimePalindromic prime = new PrimePalindromic();
                        prime.Prime();
                        break;
                    case 3:
                        QuestionNumber question = new QuestionNumber();
                        question.Question_Game();
                        break;
                    case 4:
                        BubbleSort bubble = new BubbleSort();
                        bubble.sort();
                        break;
                    case 5:
                        InsertioonSort insertioon = new InsertioonSort();
                        insertioon.Sort();
                        break;
                    case 6:
                        MergeSort merge = new MergeSort();
                        merge.Callsort();
                        break;
                    case 7:
                        VendingMachine machine = new VendingMachine();
                        machine.Amount();
                        break;
                    case 8:
                        GregorianCalender.DayofWeek();
                        break;
                    case 9:
                        Tempreature tempreature = new Tempreature();
                        tempreature.Conversion();
                        break;
                    case 10:
                        MonthlyPayment.Payment();
                        break;
                    case 11:
                        SquareRoot.Sqrt();
                        break;
                    case 12:
                        DecimalNumber number = new DecimalNumber();
                        number.BinaryNumber();
                        break;
                    case 13:
                        SearchTextfile search = new SearchTextfile();
                        search.TextFile();
                        break;
                }
            }
        }
    }
}