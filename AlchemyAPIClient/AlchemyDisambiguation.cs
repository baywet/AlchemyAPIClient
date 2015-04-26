using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient
{
    public class AlchemyDisambiguation
    {
        public string Name { get; set; }
        public List<string> SubType { get; set; }
        public Uri Geo { get; set; }
        public Uri Website { get; set; }
        public Uri Dbpedia { get; set; }
        public Uri Yago { get; set; }
        public Uri Opencyc { get; set; }
        public Uri Umbel { get; set; }
        public Uri Freebase { get; set; }
        public Uri CiaFactbook { get; set; }
        public Uri Census { get; set; }
        public Uri Geonames { get; set; }
        public Uri MusicBrainz { get; set; }
        public Uri Crunchbase { get; set; }
    }
}
