//time in words
using System;

namespace TimeInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input Time in 12 Hour Format 
            int hr, min;
            hr = Convert.ToInt32(Console.ReadLine());
            min = Convert.ToInt32(Console.ReadLine());
            time(hr, min);
        }
        static void time(int hr, int min)
        {
            string[] nums = { "zero", "one", "two", "three", "four",
                            "five", "six", "seven", "eight", "nine",
                            "ten", "eleven", "twelve", "thirteen",
                            "fourteen", "fifteen", "sixteen", "seventeen",
                            "eighteen", "nineteen", "twenty", "twenty one",
                            "twenty two", "twenty three", "twenty four",
                            "twenty five", "twenty six", "twenty seven",
                            "twenty eight", "twenty nine", 
                        };
            // To check that whether the Time is in range or not
            if (hr > 12 || hr==00 || min >= 60)
            {
                Console.WriteLine("enter time in range");
            }
            else if (min == 0)
            {
                Console.WriteLine(nums[hr] + " O' clock");
            }
            // if hour is 12 and minute is greater than 30
            else if (hr == 12 && min>30)
            {
                if (min == 45)
                {
                    Console.WriteLine("quarter to " + nums[1]);
                }
                else if (min == 59)
                {
                    Console.WriteLine("one minute to " + nums[1]);
                }
                else
                {
                    Console.WriteLine(nums[60 - min] + " minutes to " + nums[1]);
                }

            }
            // If the minutes are less than 30
            else if (min <= 30)
            {
                if (min == 1) 
                {
                    Console.WriteLine(nums[min] + " minute past " + nums[hr]);
                }
                else if (min == 15)
                {
                    Console.WriteLine("quarter past " + nums[hr]);
                }
                else if (min == 30)
                {
                    Console.WriteLine("half past " + nums[hr]);
                }
                else
                {
                    Console.WriteLine(nums[min] + " minutes past " + nums[hr]);
                }
            }
            else // If the Minute are greater than 30
            {
                if (min == 45)
                {
                    Console.WriteLine("quarter to " + nums[hr + 1]);
                }
                else if (min == 59)
                {
                    Console.WriteLine("one minute to " + nums[hr + 1]);
                }
                else
                {
                    Console.WriteLine(nums[60 - min] + " minutes to " + nums[hr + 1]);
                }
            }           
        }
    }
}
