using System.Collections.Generic;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyMicroFormatResponse : AlchemyResponseBase<AlchemyMicroFormat>
    {
        public List<AlchemyMicroFormat> MicroFormats { get; set; }
    }
}
