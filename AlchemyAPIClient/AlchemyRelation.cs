using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient
{
    public class AlchemyRelation
    {
        public AlchemySubject Subject { get; set; }
        public AlchemyAction Action { get; set; }
        public AlchemyObject Object { get; set; }
    }
}
