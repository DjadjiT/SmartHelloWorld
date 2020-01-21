using System;
using System.Collections.Generic;
using System.Text;
using App.interfaces;

namespace App.implementation
{
    class DateTimeImpl : IDateTime
    {
        public int hour;



        public DateTimeImpl()
        {
            this.hour = DateTime.Now.Hour;
        }

        public DateTimeImpl(int hour)
        {
            if (hour < 24)
            {
                this.hour = hour;
            }else
            {
                this.hour = hour % 24;
            }
        }

        public Greetings GetTimeOfDay()
        {
            if(this.hour< (int) TimeOfDay.AfterNoon && this.hour >= (int) TimeOfDay.Morning)
            {
                return Greetings.morning;
            }else if(this.hour< (int) TimeOfDay.Night && this.hour >= (int) TimeOfDay.AfterNoon)
            {
                return Greetings.afterNoon;
            }else
            {
                return Greetings.night;
            }
        }

        int IDateTime.hour => throw new NotImplementedException();

    }
}
