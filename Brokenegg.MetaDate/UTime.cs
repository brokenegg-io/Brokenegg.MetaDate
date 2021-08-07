using System;
using System.Collections.Generic;
using System.Text;

namespace Brokenegg.MetaDate
{
    public class UTime
    {
        private int Hours { get; set; }
        private int Minutes { get; set; }

        public UTime() { }

        public UTime(string time)
        {

        }

        public UTime(int hours, int minutes)
        {
            this.Hours = hours;
            this.Minutes = minutes;
        }

        public int GetHours() => this.Hours;
        public int GetMinutes() => this.Minutes;
    }
}
