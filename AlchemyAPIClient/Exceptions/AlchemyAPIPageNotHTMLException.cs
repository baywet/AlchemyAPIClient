using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlchemyAPIClient.Exceptions
{
    public class AlchemyAPIPageNotHTMLException : AlchemyAPIServiceCallException
    {
        internal AlchemyAPIPageNotHTMLException() : base(AlchemyAPIClientResources.page_not_html_error) { }
    }
}
