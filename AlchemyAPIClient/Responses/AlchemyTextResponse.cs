﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyTextResponse : AlchemyResponseBase<string>
    {
        public string Text { get; set; }
    }
}