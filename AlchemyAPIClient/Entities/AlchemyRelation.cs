namespace AlchemyAPIClient
{
    public class AlchemyRelation
    {
        public AlchemySubject Subject { get; set; }
        public AlchemyAction Action { get; set; }
        public AlchemyObject Object { get; set; }
        public string Sentence { get; set; }
    }
}
