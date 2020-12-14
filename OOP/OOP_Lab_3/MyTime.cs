using System;
namespace OOP_Lab_3
{
    public class MyTime
    {
        // Fields

        protected int hour, minute, second;

        // Properties

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
                Normalize();
            }
        }


        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
                Normalize();
            }
        }


        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
                Normalize();
            }
        }


        // Constructors

        public MyTime()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }


        public MyTime(MyTime other)
        {
            hour = other.hour;
            minute = other.minute;
            second = other.second;
        }


        public MyTime(int secondsFromMidnight)
        {
            Second = secondsFromMidnight;
        }


        public MyTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            Normalize();
        }


        // Protected Methods

        protected void HMSFromSeconds(int s)
        {
            s %= (24 * 60 * 60);
            s += (24 * 60 * 60);
            s %= (24 * 60 * 60);

            hour = s / 60 / 60;
            minute = (s / 60) % 60;
            second = s % 60;
        }


        protected void Normalize()
        {
            int s = TimeSinceMidnight();
            HMSFromSeconds(s);
        }


        // Static Methods

        public static int Difference(MyTime t1, MyTime t2)
        {
            return t1.TimeSinceMidnight() - t2.TimeSinceMidnight();
        }


        public static int operator -(MyTime t1, MyTime t2)
        {
            return t1.TimeSinceMidnight() - t2.TimeSinceMidnight();
        }


        public static bool operator <(MyTime t1, MyTime t2)
        {
            return t1.TimeSinceMidnight() < t2.TimeSinceMidnight();
        }


        public static bool operator >(MyTime t1, MyTime t2)
        {
            return t1.TimeSinceMidnight() > t2.TimeSinceMidnight();
        }


        public static bool operator <=(MyTime t1, MyTime t2)
        {
            return t1.TimeSinceMidnight() <= t2.TimeSinceMidnight();
        }


        public static bool operator >=(MyTime t1, MyTime t2)
        {
            return t1.TimeSinceMidnight() >= t2.TimeSinceMidnight();
        }


        // Public Methods

        public int TimeSinceMidnight()
        {
            return Hour * 60 * 60 + Minute * 60 + Second;
        }


        public MyTime AddOneSecond()
        {
            return new MyTime(Hour, Minute, Second + 1);
        }


        public MyTime AddOneMinute()
        {
            return new MyTime(Hour, Minute + 1, Second);
        }


        public MyTime AddOneHour()
        {
            return new MyTime(Hour + 1, Minute, Second);
        }


        public MyTime AddSeconds(int s)
        {
            return new MyTime(Hour, Minute, Second + s);
        }


        public string WhatLesson()
        {
            if (this < new MyTime(8, 0, 0))
            {
                return "пари ще не почались";
            }
            MyTime tmp = new MyTime(this);
            tmp.Hour -= 8;
            int les_num = 1;
            while (les_num < 5 && (tmp >= new MyTime(1, 40, 0))) // Counting lessons and breaks 1st through 4th
            {
                les_num++;
                tmp.Hour -= 1;
                tmp.Minute -= 40;
            }
            if (les_num == 5 && (tmp >= new MyTime(1, 30, 0))) // after 5th lesson break is 10mins long
            {
                les_num++;
                tmp.Hour -= 1;
                tmp.Minute -= 30;
            }

            if (tmp < new MyTime(1, 20, 0))
            {
                return $"{les_num}-{(les_num == 3 ? "я" : "а")} пара";
            }

            else if (les_num < 6)
            {
                return $"перерва між {les_num}-ю та {les_num + 1}-ю парами";
            }
            else
            {
                return "пари вже скінчились";
            }
        }


        public override string ToString()
        {
            return string.Format("{0}:{1:d2}:{2:d2}", Hour, Minute, Second);
        }
    }
}
