using System;
using System.Globalization;

namespace AlchemyAPIClient
{
    public class AlchemyPublicationDate
    {
        public AlchemyConfident Confident { get; set; }
        public string Date { get; set; }
        public DateTime FormattedDate
        {
            get
            {
                if (_formattedDate == default(DateTime))
                    _formattedDate = DateTime.ParseExact(Date, "yyyyMMdd\\Thhmmss", CultureInfo.InvariantCulture);
                return _formattedDate;
            }
        }
        private DateTime _formattedDate;
    }
    public enum AlchemyConfident
    {
        NotProvided,
        No
    }
}
