using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public abstract class AlchemyResponseBase<T> where T : class
    {
        public AlchemyAPIResponseStatus Status { get; set; }
        public string Usage { get; set; }
        public string Url { get; set; }
        public string Language { get; set; }
        public int TotalTransactions { get; set; }
        public string Text { get; set; }
        public string StatusInfo { get; set; }
    }
    public enum AlchemyAPIResponseStatus
    {
        OK,
        ERROR
    }
}
