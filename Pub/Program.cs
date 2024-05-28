using System;
using System.Security.Cryptography;
using System.Threading;
using Pub.ServiceReference1;

namespace Pub
{
    internal class Program
    {
        private const int Frequency = 60000;
        private static readonly MachineClient MachineClient = new MachineClient();

        private static void Main()
        {
            while (true)
            {
                var numbers = DrawLotteryNumbers();
                MachineClient.DrawLotteryNumbers(numbers);
                Console.WriteLine($"Drew numbers: {numbers.Number1} and {numbers.Number2}");
                Thread.Sleep(Frequency);
            }
        }

        public static LotteryNumbers DrawLotteryNumbers()
        {
            var number1 = GetSecureRandomNumber(1, 10);
            var number2 = GetSecureRandomNumber(1, 10);
            var numbers = new LotteryNumbers
            {
                Number1 = number1,
                Number2 = number2
            };
            return numbers;
        }

        private static int GetSecureRandomNumber(int minValue, int maxValue)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[4];
                rng.GetBytes(randomNumber);
                var value = BitConverter.ToInt32(randomNumber, 0) & int.MaxValue; // Ensure non-negative number
                return value % (maxValue - minValue + 1) + minValue;
            }
        }
    }
}