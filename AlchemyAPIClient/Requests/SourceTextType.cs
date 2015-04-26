using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public enum SourceTextType
    {
        cleaned_or_raw,
        cleaned,
        raw,
        cquery,
        xpath,
        xpath_or_raw,
        cleaned_and_xpath
    }
}
