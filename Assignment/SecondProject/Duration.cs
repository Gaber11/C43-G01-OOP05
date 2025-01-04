using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.SecondProject
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Duration(int hour, int minute, int second)
        {
            Hours = hour;
            Minutes = minute;
            Seconds = second;

        }
        public Duration(int durTime)
        {

            Hours = durTime / 3600;
            Minutes = (durTime % 3600) / 60;
            Seconds = (durTime % 3600) % 60;


        }

        public override string ToString()
        {
            if (Hours == 0)
            {
                return $" Minutes: {Minutes} ,Seconds: {Seconds} ";
            }
            return $" Hours: {Hours} , Minutes: {Minutes} ,Seconds: {Seconds} ";

        }

        public Duration()
        {

        }
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration()
            {
                Hours = d1.Hours + d2.Hours,
                Minutes = d1.Minutes + d2.Minutes,
                Seconds = d1.Seconds + d2.Seconds
            };



        }

        public static Duration operator +(Duration d1, int durTime)
        {
            return new Duration()
            {
                Hours = d1.Hours + durTime / 3600,
                Minutes = d1.Minutes + (durTime % 3600) / 60,
                Seconds = d1.Seconds + (durTime % 3600) % 60
            };
        }

        public static Duration operator +(int durTime, Duration d3)
        {
            return new Duration()
            {
                Hours = d3.Hours + durTime / 3600,
                Minutes = d3.Minutes + (durTime % 3600) / 60,
                Seconds = d3.Seconds + (durTime % 3600) % 60
            };
        }

        public static Duration operator ++(Duration d1)
        {
            return new Duration()
            {
                Hours = d1.Hours,
                Minutes = d1.Minutes + 1,
                Seconds = d1.Seconds
            };
        }
    }
}
