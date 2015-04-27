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
        protected const string APIKeykey = "apikey";
        protected const string outputModeKey = "outputMode";
        protected const string jsonOutputMode = "json";
        protected abstract string RequestPath { get; }
        protected AlchemyRequestBase(AlchemyClient _client)
        {
            if (_client == null)
                throw new ArgumentNullException("_client");
            AdditionalParameters = new NameValueCollection();
            client = _client;
            ThrowExceptionsOnErrors = true;
        }
        public bool ThrowExceptionsOnErrors { get; set; }
        protected AlchemyClient client { get; set; }
        private NameValueCollection AdditionalParameters { get; set; }
        public virtual async Task<responseType> GetResponse()
        {
            using (var wreq = new WebClient())
            {
                wreq.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);

                Uri address = new Uri(client.EndPointUrl + RequestPath);

                wreq.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                if (!AdditionalParameters.AllKeys.Contains(APIKeykey))
                    AdditionalParameters.Add(APIKeykey, client.EndPointKey);
                if (!AdditionalParameters.AllKeys.Contains(outputModeKey))
                    AdditionalParameters.Add(outputModeKey, jsonOutputMode);

                var responseBytes = await wreq.UploadValuesTaskAsync(address, "POST", AdditionalParameters);
                var textResponse = UTF8Encoding.UTF8.GetString(responseBytes);
                var typedResponse = JsonConvert.DeserializeObject<responseType>(textResponse);
                if (ThrowExceptionsOnErrors && typedResponse.Status == AlchemyAPIResponseStatus.ERROR)
                    throw new AlchemiAPIServiceCallException(typedResponse.StatusInfo);
                return typedResponse;
            }
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
            if (string.IsNullOrWhiteSpace(name))
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
