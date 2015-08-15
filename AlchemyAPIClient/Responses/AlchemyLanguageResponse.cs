using Newtonsoft.Json;
using System;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyLanguageResponse : AlchemyResponseBase<string>
    {
        [JsonProperty(PropertyName = "iso-639-1")]
        public string Iso_639_1 { get; set; }
        [JsonProperty(PropertyName = "iso-639-2")]
        public string Iso_639_2 { get; set; }
        [JsonProperty(PropertyName = "iso-639-3")]
        public string Iso_639_3 { get; set; }
        public Uri Ethnologue { get; set; }
        [JsonProperty(PropertyName = "Native-speakers")]
        public string Native_speakers { get; set; }
        public Uri Wikipedia { get; set; }
    }
}
