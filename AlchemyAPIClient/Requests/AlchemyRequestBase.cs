using AlchemyAPIClient.Exceptions;
using AlchemyAPIClient.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyRequestBase<dataType, responseType>
        where dataType : class
        where responseType : AlchemyResponseBase<dataType>
    {
        private const string APIKeykey = "apikey";
        private const string outputModeKey = "outputMode";
        private const string jsonOutputMode = "json";
        protected abstract string RequestPath { get; }
        private List<string> _requiredParameters = new List<string>();
        protected IEnumerable<string> RequiredParameters { get { return _requiredParameters; } }
        protected AlchemyRequestBase(AlchemyClient _client)
        {
            if (_client == null)
                throw new ArgumentNullException(nameof(_client));
            AddRequiredParameter(APIKeykey);
            client = _client;
            ThrowExceptionsOnErrors = true;
        }
        protected void AddRequiredParameter(string name)
        {
            _requiredParameters.Add(name);
        }
        public bool ThrowExceptionsOnErrors { get; set; }
        private AlchemyClient client;
        private NameValueCollection AdditionalParameters = new NameValueCollection();
        public virtual async Task<responseType> GetResponse()
        {
            using (var wreq = new WebClient())
            {
                addDefaultParameters(wreq);
                AdditionalParametersHandling();
                checkRequiredParameters();

                var address = new Uri(client.EndPointUrl + RequestPath);
                var responseBytes = await wreq.UploadValuesTaskAsync(address, "POST", AdditionalParameters);
                var textResponse = Encoding.UTF8.GetString(responseBytes);
                return GetTypedResponseFromText<responseType, dataType>(textResponse) as responseType;
            }
        }
        protected virtual void AdditionalParametersHandling()
        {

        }
        private void checkRequiredParameters()
        {
            var missingParameters = RequiredParameters.Where(x => !AdditionalParameters.AllKeys.Contains(x) || string.IsNullOrWhiteSpace(AdditionalParameters[x]));
            if (missingParameters.Any())
                throw new ArgumentNullException(missingParameters.First());
        }
        private void addDefaultParameters(WebClient wreq)
        {
            wreq.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);

            wreq.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            if (!AdditionalParameters.AllKeys.Contains(APIKeykey))
                AdditionalParameters.Add(APIKeykey, client.EndPointKey);
            if (!AdditionalParameters.AllKeys.Contains(outputModeKey))
                AdditionalParameters.Add(outputModeKey, jsonOutputMode);
        }
        protected virtual T GetTypedResponseFromText<T, U>(string textResponse) where T : AlchemyResponseBase<U> where U : class
        {
            var typedResponse = JsonConvert.DeserializeObject<T>(textResponse);
            if (ThrowExceptionsOnErrors && typedResponse.Status == AlchemyAPIResponseStatus.ERROR)
                throw AlchemyAPIServiceCallException.GetValidException(typedResponse.StatusInfo);
            return typedResponse;
        }

        protected void AddOrUpdateParameter(string name, int value)
        {
            AddOrUpdateParameter(name, value.ToString());
        }
        protected void AddOrUpdateParameter(string name, bool value)
        {
            AddOrUpdateParameter(name, Convert.ToInt32(value).ToString());
        }
        protected void AddOrUpdateParameter(string name, Uri value)
        {
            AddOrUpdateParameter(name, value.ToString());
        }
        protected void AddOrUpdateParameter(string name, string value)
        {
            if (AdditionalParameters.AllKeys.Contains(name))
                if (string.IsNullOrEmpty(value))
                    if (RequiredParameters.Contains(name))
                        throw new ArgumentNullException(name);
                    else
                        AdditionalParameters.Remove(name);
                else
                    AdditionalParameters[name] = value;
            else
                AdditionalParameters.Add(name, value);
        }
        protected string GetParameter(string name)
        {
            return AdditionalParameters.AllKeys.Contains(name) ? AdditionalParameters[name] : string.Empty;
        }
        protected bool GetBooleanParameter(string name)
        {
            var textValue = GetParameter(name);
            if (string.IsNullOrWhiteSpace(name))
                return default(bool);
            else
                try
                {
                    return bool.Parse(textValue);
                }
                catch (Exception)
                {
                    return default(bool);
                }
        }
        protected int GetIntParameter(string name)
        {
            var textValue = GetParameter(name);
            if (string.IsNullOrWhiteSpace(textValue))
                return default(int);
            else
                try
                {
                    return int.Parse(textValue);
                }
                catch (Exception)//wrong number format
                {
                    return default(int);
                }
        }
        protected Uri GetUriParameter(string name)
        {
            var textValue = GetParameter(name);
            if (string.IsNullOrWhiteSpace(name))
                return default(Uri);
            else
                try
                {
                    return new Uri(textValue);
                }
                catch (Exception)//wrong url format
                {
                    return default(Uri);
                }
        }
    }
}
