using System.Collections.Generic;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyFeedResponse : AlchemyResponseBase<AlchemyFeed>
    {
        public List<AlchemyFeed> Feeds { get; set; }
    }
}
