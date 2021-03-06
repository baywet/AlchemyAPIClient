﻿using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyCleanTextRequestBase : AlchemyTextRequestBase
    {
        private const string useMetadataKey = "useMetadata";
        private const string extractLinksKey = "extractLinks";
        private const string sourceTextKey = "sourceText";
        public AlchemyCleanTextRequestBase(AlchemyClient client)
            : base(client)
        {

        }
        public bool ExtractLinks { get { return GetBooleanParameter(extractLinksKey); } set { AddOrUpdateParameter(extractLinksKey, value); } }
        public bool UseMetadata { get { return GetBooleanParameter(useMetadataKey); } set { AddOrUpdateParameter(useMetadataKey, value); } }
        public SourceTextType SourceText
        {
            get
            {
                var textValue = GetParameter(sourceTextKey);
                if (string.IsNullOrEmpty(textValue))
                    return SourceTextType.cleaned_or_raw;
                else
                    return (SourceTextType)Enum.Parse(typeof(SourceTextType), textValue);
            }
            set
            {
                AddOrUpdateParameter(sourceTextKey, Enum.GetName(typeof(SourceTextType), value));
            }
        }
    }
}
