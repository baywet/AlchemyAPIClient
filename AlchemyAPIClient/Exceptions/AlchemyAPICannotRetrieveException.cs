﻿using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPICannotRetrieveException : AlchemyAPIServiceCallException
    {
        internal AlchemyAPICannotRetrieveException() : base(AlchemyAPIClientResources.cannot_retrieve_error) { }
    }
}
