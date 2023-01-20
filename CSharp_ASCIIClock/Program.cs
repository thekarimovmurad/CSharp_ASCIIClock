using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_ASCIIClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string time = DateTime.Now.ToString("HH:mm");

                char firstHour = time[0];
                char lastHour = time[1];
                char firstMinute = time[3];
                char lastMinute = time[4];
                string[] digitArray = null;

                string[] FirstHour=null;
                string[] LastHour = null;
                string[] FirstMinute = null;
                string[] LastMinute = null;

                char[] Time = { firstHour, lastHour, firstMinute, lastMinute };

                string[] zero = { "****", "*  *", "*  *", "*  *", "*  *", "*  *", "****" };
                string[] one = { "*", "*", "*", "*", "*", "*", "*" };
                string[] two = { "****", "   *", "   *", "****", "*   ", "*   ", "****" };
                string[] tree = { "****", "   *", "   *", "****", "   *", "   *", "****" };
                string[] four = { "   *", "  **", " * *", "*  *", "****", "   *", "   *" };
                string[] five = { "****", "*   ", "*   ", "****", "   *", "   *", "****" };
                string[] six = { "****", "*   ", "*   ", "****", "*  *", "*  *", "****" };
                string[] seven = { "****", "   *", "   *", "   *", "   *", "   *", "   *" };
                string[] eight = { "****", "*  *", "*  *", "****", "*  *", "*  *", "****" };
                string[] nine = { "****", "*  *", "*  *", "****", "   *", "   *", "****" };
                string[] double_dot = { "   ", "   ", " * ", "   ", " * ", "   ", "   " };

                int index = 0;
                foreach (char digit in Time)
                {
                    if (digit == '0') digitArray = zero;
                    if (digit == '1') digitArray = one;
                    if (digit == '2') digitArray = two;
                    if (digit == '3') digitArray = tree;
                    if (digit == '4') digitArray = four;
                    if (digit == '5') digitArray = five;
                    if (digit == '6') digitArray = six;
                    if (digit == '7') digitArray = seven;
                    if (digit == '8') digitArray = eight;
                    if (digit == '9') digitArray = nine;

                    if (index == 0) FirstHour = digitArray;
                    if (index == 1) LastHour = digitArray;
                    if (index == 2) FirstMinute = digitArray;
                    if (index == 3) LastMinute = digitArray;
                    index++;
                }

                for (int i = 0; i < one.Length; i++)
                {
                    Console.WriteLine(FirstHour[i] + " " + LastHour[i] + double_dot[i] + FirstMinute[i] + " " + LastMinute[i]);
                }

                Thread.Sleep(60000);
            }
        }
    }
}