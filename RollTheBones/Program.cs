using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTheBones
{
    public class RollTheBones
    {
        static Random rng = new Random(Guid.NewGuid().GetHashCode());
        public static void Main(string[] args)
        {
            double[] buffs = new double[4];
            int count = 0;
            Console.WriteLine("Enter Number of Iterations.");
            try
            {
                double total = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                while (count < total)
                {
                    int[] temp = rollSix();
                    if (twoBuff(temp))
                        ++buffs[1];
                    else if (threeBuff(temp))
                        ++buffs[2];
                    else if (allBuff(temp))
                        ++buffs[3];
                    else
                        ++buffs[0];
                    ++count;
                }
                Console.WriteLine("Chance of One Buff: {0}%\nChance of Two Buffs: {1}%\nChance of Three Buffs: {2}%\nChance of All Buffs: {3}%", ((buffs[0] / total) * 100).ToString("F2", CultureInfo.InvariantCulture), ((buffs[1] / total) * 100).ToString("F2", CultureInfo.InvariantCulture), ((buffs[2] / total) * 100).ToString("F2", CultureInfo.InvariantCulture), ((buffs[3] / total) * 100).ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (FormatException)
            {
                Console.WriteLine("Not a Double. Exiting.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too large. Exiting.");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown error, contact creator with your input. Exiting");
            }
            Console.Read();

        }

        public static int[] rollSix()
        {
            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = rng.Next(1, 7);
            }
            return numbers;
        }

        public static bool twoBuff(int[] numbers)
        {
            List<int> results = new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                results.Add(numbers.ToList().Count(x => x == i));
            }
            return ((results.Count(x => x == 2) == 2) || (results.Count(x => x == 3) == 2));
        }
        public static bool threeBuff(int[] numbers)
        {
            List<int> results = new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                results.Add(numbers.ToList().Count(x => x == i));
            }
            return (results.Count(x => x == 2) == 3);
        }
        public static bool allBuff(int[] numbers)
        {
            List<int> ints = numbers.ToList();
            return (ints.Distinct().Count() == ints.Count());
        }

    }
}
