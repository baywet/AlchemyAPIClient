﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient
{
    public class AlchemiAPIServiceCallException : Exception
    {
        public AlchemiAPIServiceCallException(string message)
            : base(message)
        { }
    }
}
