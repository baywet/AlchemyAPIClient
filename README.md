# AlchemyAPIClient
Simple implementation of the www.alchemyapi.com services calls in .net

To install this library you can go here https://www.nuget.org/packages/AlchemyAPIClient/

Supported Operations for V1

--Keywords extraction
http://www.alchemyapi.com/api/keyword-extraction
Example
public async Task<AlchemyKeywordsResponse> GetKeywords(string text, AlchemyClient client)
{
    var request = new AlchemyTextKeywordsRequest(text, client)
    {
        KnowledgeGraph = true,
        ShowSourceText = true,
        MaxRetrieve = 30,
        Sentiment = true,
        KeyWordExtractModeText = KeyWordExtractModeType.Normal
    };
    return await request.GetResponse();
}
//also supports url or html see AlchemyUrlKeywordsRequest and AlchemyHtmlKeywordsRequest
--Entities Extraction
http://www.alchemyapi.com/api/entity-extraction
Example
public async Task<AlchemyEntitiesResponse> GetEntities(string text, AlchemyClient client)
{
    var request = new AlchemyTextEntitiesRequest(text, client)
    {
        Coreference = true,
        Disambiguate = true,
        KnowledgeGraph = true,
        LinkedData = true,
        Quotations = true,
        Sentiment = true,
        ShowSourceText = true,
        StructuredEntities = true,
        MaxRetrieve = 30
    };
    return await request.GetResponse();
}
//also supports url or html see AlchemyUrlEntitiesRequest and AlchemyHtmlEntitiesRequest
--Concepts extraction
http://www.alchemyapi.com/api/concept-tagging
public static async Task<AlchemyConceptsResponse> GetConcepts(string text, AlchemyClient client)
{
    var request = new AlchemyTextConceptsRequest(text, client)
    {
        KnowledgeGraph = true,
        LinkedData = true,
        ShowSourceText = true,
        MaxRetrieve = 30
    };
    return await request.GetResponse();
}
//also supports url or html see AlchemyUrlConceptsRequest and AlchemyHtmlConceptsRequest
--How to get the AlchemyClient ?
//simple get a key on www.alchemyAPI.com 
return new AlchemyClient(yourkey);

--Plans for next versions
V1.1
Support for Sentiment analysis (you already have sentiments on keywords and entities)
http://www.alchemyapi.com/api/sentiment-analysis
Support for Taxonomy extraction
http://www.alchemyapi.com/api/taxonomy

V1.2
Support for Author and Authors extraction (you already have that kind of information via entities extraction)
http://www.alchemyapi.com/api/author-extraction
http://www.alchemyapi.com/api/authors-extraction

V1.3
Support for Language extraction (you already have that information with responses)
http://www.alchemyapi.com/api/language-detection
Support for Text extraction
http://www.alchemyapi.com/api/text-extraction
Support for Relation extraction
http://www.alchemyapi.com/api/relation-extraction
