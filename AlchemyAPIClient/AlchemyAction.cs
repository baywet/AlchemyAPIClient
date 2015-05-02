using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient
{
    public class AlchemyAction
    {
        public string Text { get; set; }
        public string Lemmatized { get; set; }
        public AlchemyVerb Verb { get; set; }
    }
}
