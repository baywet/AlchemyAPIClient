using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Exceptions
{
    public class AlchemyAPICannotLocateAuthorException : AlchemyAPIServiceCallException
    {
        public AlchemyAPICannotLocateAuthorException() : base(AlchemyAPIClientResources.cannot_locate_author_error) { }
    }
}
