﻿using System;
using System.Collections.Generic;
using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {
            string dateStringFirst = Console.ReadLine();
            string dateStringSecond = Console.ReadLine();
            string format = "d.MM.yyyy";
            DateTime firstDate = DateTime.ParseExact(dateStringFirst, format,
            CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(dateStringSecond, format,
            CultureInfo.InvariantCulture);
            int difference = CalculateNumberDifferenceDates(firstDate, secondDate);
            Console.WriteLine("Days between: {0} ", difference);
        }
        private static int CalculateNumberDifferenceDates(DateTime firstDate, DateTime secondDate)
        {
            TimeSpan ts = secondDate - firstDate;
            int differenceInDays = ts.Days;
            return differenceInDays;

        }
    }
