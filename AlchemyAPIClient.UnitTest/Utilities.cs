using AlchemyAPIClient.Requests;
using AlchemyAPIClient.Responses;

namespace AlchemyAPIClient.UnitTest
{
    public class Utilities
    {
        public static T getRequestResult<T,U>(AlchemyRequestBase<U, T> request) where T : AlchemyResponseBase<U> where U : class
        {
            var requestTask = request.GetResponse();
            var awaiter = requestTask.GetAwaiter();
            return awaiter.GetResult();
        }
    }
}
