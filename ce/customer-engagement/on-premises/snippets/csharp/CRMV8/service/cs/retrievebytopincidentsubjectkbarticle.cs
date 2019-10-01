// <snippetretrievebytopincidentsubjectkbarticle>



 // create the request
 var retrieveByTopIncidentSubjectRequest = 
     new RetrieveByTopIncidentSubjectKbArticleRequest()
 {
     SubjectId = _subjectId
 };

 // execute request
 Console.WriteLine();
 Console.WriteLine("  Searching for the top articles in subject 'Default Subject'");
 var retrieveByTopIncidentSubjectResponse = (RetrieveByTopIncidentSubjectKbArticleResponse)
     _context.Execute(retrieveByTopIncidentSubjectRequest);

 // check success
 var articles = retrieveByTopIncidentSubjectResponse.EntityCollection.Entities.Select(
     (entity) => (KbArticle)entity);
 Console.WriteLine("  Top articles in subject 'Default Subject':");
 foreach (var article in articles)
     Console.WriteLine(article.Title);

// </snippetretrievebytopincidentsubjectkbarticle>