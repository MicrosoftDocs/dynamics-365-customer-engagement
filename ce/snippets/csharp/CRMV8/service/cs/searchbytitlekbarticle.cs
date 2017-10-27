// <snippetsearchbytitlekbarticle>



 // create the request
 SearchByTitleKbArticleRequest searchByTitleRequest = 
     new SearchByTitleKbArticleRequest()
 {
     SubjectId = _subjectId,
     UseInflection = false,
     SearchText = "code",
     QueryExpression = new QueryExpression()
     {
         ColumnSet = new ColumnSet("title"),
         EntityName = KbArticle.EntityLogicalName
     }
 };

 // execute the request
 Console.WriteLine();
 Console.WriteLine("  Searching for published articles with 'code' in the title");
 var searchByTitleResponse = (SearchByTitleKbArticleResponse)
     _context.Execute(searchByTitleRequest);

 // check success
 var retrievedArticles = searchByTitleResponse.EntityCollection.Entities
     .Select((entity) => (KbArticle)entity);
 Console.WriteLine("  Results of search (titles found):");
 foreach (var article in retrievedArticles)
     Console.WriteLine(article.Title);

// </snippetsearchbytitlekbarticle>