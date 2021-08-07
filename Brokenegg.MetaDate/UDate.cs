using System;

namespace Brokenegg.MetaDate
{
    public class UDate
    {
        private ULocale Locale => USettings.Locale;
        private DateTime _dateTime { get; set; }
        public UDate() => this._dateTime = DateTime.MinValue;
        public DateTime ToUtcDateTime() => this._dateTime;
        public DateTime ToLocalDateTime() =>
            this._dateTime
            .AddHours(this.Locale.Hours)
            .AddMinutes(this.Locale.Minutes);

        public string ToString(string format) => this._dateTime.ToString(format);
        public string ToString() => this._dateTime.ToString();
    }
}
