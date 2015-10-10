using System;

namespace AlchemyAPIClient
{
    public class AlchemyConcept
    {
        public string Text { get; set; }
        public double Relevance { get; set; }
        public AlchemyGraph KnowledgeGraph { get; set; }
        public Uri Geo { get; set; }
        public Uri Website { get; set; }
        public Uri Dbpedia { get; set; }
        public Uri Yago { get; set; }
        public Uri Opencyc { get; set; }
        public Uri Freebase { get; set; }
        public Uri CiaFactbook { get; set; }
        public Uri Census { get; set; }
        public Uri Geonames { get; set; }
        public Uri MusicBrainz { get; set; }
        public Uri Crunchbase { get; set; }
    }
}
