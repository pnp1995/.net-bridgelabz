// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Gambler.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram.functional
{
    /// <summary>
/// Gambller is classname
/// </summary>
    class Gambler
    {
        /// <summary>
        /// Games this instance.
        /// </summary>
        //// <summary>
    public void game()
        {
                //// asks for input of trail,stake and goal
        
            Console.WriteLine("Enter Stake:");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter goal:");
            int goal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter trial:");
            double trial = Convert.ToInt32(Console.ReadLine());

            double win = 0;
            double loss = 0;
            //created object to use method of random class
            for (int t = 0; t < trial; t++)
            {
                Random r = new Random();
                // do one gambler's ruin simulation
                int cash = stake;
                while (cash > 0 && cash < goal)
                {
                    loss++;
                    double result = Convert.ToDouble(r.Next(0, 1));
                    if (result < 0.5) cash++;
                    else cash--;
                }
                if (cash == goal) win++;
            }

            // print results
            Console.WriteLine(win + " wins of " + trial);
            Console.WriteLine("Percent of games won = " + 100.0 * win / trial);
            Console.WriteLine("Avg # bets           = " + 1.0 * loss / trial);

        }
        }
    }
