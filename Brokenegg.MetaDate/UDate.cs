using System;

namespace Brokenegg.MetaDate
{
    public class UDate
    {
        private ULocale Locale => USettings.Locale ?? ULocale.FindLocale(ELocales.COORDINATED_UNIVERSAL_TIME);
        private DateTime _dateTime { get; set; }
        public UDate() => this._dateTime = DateTime.Now;
        public UDate(DateTime dateTime, ULocale locale = null)
        {
            this._dateTime = ToUtcDateTime(dateTime);
            if (locale != null) USettings.Locale = locale;
        }

        /// <summary>
        /// Converts from local to UTC date
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        private DateTime ToUtcDateTime(DateTime dateTime) =>  dateTime
                .AddHours(this.Locale.Hours * -1)
                .AddMinutes(this.Locale.Minutes * -1);

        /// <summary>
        /// Returns the UTC date
        /// </summary>
        /// <returns></returns>
        public DateTime ToUtcDateTime() => this._dateTime;
        /// <summary>
        /// Converts to local datetime
        /// </summary>
        /// <returns></returns>
        public DateTime ToLocalDateTime() =>
            this._dateTime
            .AddHours(this.Locale.Hours)
            .AddMinutes(this.Locale.Minutes);
    }
}
