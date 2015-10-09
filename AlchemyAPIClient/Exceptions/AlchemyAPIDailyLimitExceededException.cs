using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPIDailyLimitExceededException : AlchemyAPIServiceCallException
    {
        public AlchemyAPIDailyLimitExceededException() : base(AlchemyAPIClientResources.daily_limit_exceeded) { }
    }
}
