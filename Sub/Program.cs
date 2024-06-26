﻿using System;
using System.ServiceModel;
using Sub.ServiceReference1;

namespace Sub
{
    public class Callback : IPlayerCallback
    {
        public void SummaryArrived(Summary summary)
        {
            Console.WriteLine("Lottery is drawn:");
            Console.WriteLine("Lottery numbers: " + summary.LotteryNumbers.Number1 + " and " + summary.LotteryNumbers.Number2);
            Console.WriteLine("Player: " + summary.Player.Name);
            Console.WriteLine("Rank: " + summary.Rank);
            Console.WriteLine("Current turn earnings: " + summary.CurrentTurnEarnings);
            Console.WriteLine("Hit count: " + summary.HitCount);
            Console.WriteLine("Total stake: " + summary.TotalStake);
            Console.WriteLine("Total earnings: " + summary.TotalEarnings);
            Console.WriteLine();
        }
    }

    internal class Program
    {
        private static PlayerClient _subClient;

        private static void Main()
        {
            Console.WriteLine("Insert your name:");
            var name = Console.ReadLine();

            var ic = new InstanceContext(new Callback());
            _subClient = new PlayerClient(ic);

            _subClient.InitPlayer(name);

            CreateTicket(name);

            Console.WriteLine("Waiting for the draw...");
            Console.WriteLine();

            Console.ReadLine();
        }

        public static void CreateTicket(string name)
        {
            while (true)
            {
                var numbers = new int[2];

                for (var i = 0; i < numbers.Length; i++) {
                    Console.WriteLine("Insert number " + (i + 1) + ":");
                    while (!int.TryParse(Console.ReadLine(), out numbers[i]) || numbers[i] < 1 || numbers[i] > 10) {
                        Console.WriteLine("Invalid number. Please insert a number between 1 and 10.");
                    }
                }

                double stake;
                Console.WriteLine("Insert your stake:");
                while (!double.TryParse(Console.ReadLine(), out stake) || stake <= 0) {
                    Console.WriteLine("Invalid stake. Please insert a positive number.");
                }

                var ticket = new Ticket
                {
                    PlayerName = name,
                    Number1 = numbers[0],
                    Number2 = numbers[1],
                    Stake = stake
                };

                if (_subClient.SubmitTicket(ticket)) return;

                Console.WriteLine("You have already submitted a ticker in this round. Please wait for the next round.");
            }
        }
    }
}