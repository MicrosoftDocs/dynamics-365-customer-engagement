// <snippetsearchbybodykbarticle>



 // Create the request
 SearchByBodyKbArticleRequest searchByBodyRequest = 
     new SearchByBodyKbArticleRequest()
 {
     SubjectId = _subjectId,
     UseInflection = true, // allows for a different tense or 
     // inflection to be substituted for the search text
     SearchText = "contained", // will also match on 'contains'
     QueryExpression = new QueryExpression()
     {
         ColumnSet = new ColumnSet("articlexml"),
         EntityName = KbArticle.EntityLogicalName
     }
 };

 // Execute the request
 Console.WriteLine("  Searching for published article with 'contained' in the body");

 SearchByBodyKbArticleResponse seachByBodyResponse =
     (SearchByBodyKbArticleResponse)_context.Execute(searchByBodyRequest);

 // Check success
 var retrievedArticleBodies = seachByBodyResponse.EntityCollection.Entities
     .Select((entity) => ((KbArticle)entity).ArticleXml);

 if (retrievedArticleBodies.Count() == 0)
     throw new Exception("No articles found");

 Console.WriteLine("  Results of search (article bodies found):");
 foreach (var body in retrievedArticleBodies)
     Console.WriteLine(body);

// </snippetsearchbybodykbarticle>