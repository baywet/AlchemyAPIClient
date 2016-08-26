using AlchemyAPIClient.Converters;
using Newtonsoft.Json;

namespace AlchemyAPIClient
{
    public class AlchemyVerb
    {
        public string Text { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        public bool Negated { get; set; }
        public AlchemyVerbTense Tense { get; set; }
    }
    public enum AlchemyVerbTense
    {
        Past,
        Present,
        Future
    }
}
