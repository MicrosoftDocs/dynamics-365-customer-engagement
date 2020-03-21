// <snippetsearchbykeywordskbarticle>



 // Create the request
 SearchByKeywordsKbArticleRequest searchByKeywordRequest = 
     new SearchByKeywordsKbArticleRequest()
 {
     SubjectId = _subjectId,
     UseInflection = true,
     SearchText = "Search",
     QueryExpression = new QueryExpression()
     {
         ColumnSet = new ColumnSet("keywords"),
         EntityName = KbArticle.EntityLogicalName
     }
 };

 // Execute the request
 Console.WriteLine();
 Console.WriteLine("  Searching for published article with 'search' as a keyword");
 var searchByKeywordResponse =
     (SearchByKeywordsKbArticleResponse)_context.Execute(searchByKeywordRequest);

 // Check success
 var retrievedArticleKeywords = searchByKeywordResponse.EntityCollection.Entities
     .Select((entity) => (KbArticle)entity);

 if (retrievedArticleKeywords.Count() == 0)
     throw new Exception("No articles found");

 Console.WriteLine("  Results of search (keywords found):");
 foreach (var article in retrievedArticleKeywords)
     Console.WriteLine(article.KeyWords);

// </snippetsearchbykeywordskbarticle>