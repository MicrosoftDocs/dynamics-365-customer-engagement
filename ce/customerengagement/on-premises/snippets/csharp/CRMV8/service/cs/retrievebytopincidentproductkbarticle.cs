// <snippetretrievebytopincidentproductkbarticle>



 // create the request
 var retrieveByTopIncidentProductRequest = 
     new RetrieveByTopIncidentProductKbArticleRequest()
 {
     ProductId = _product.Id
 };

 // execute request
 Console.WriteLine();
 Console.WriteLine("  Searching for the top articles for product 'Sample Product'");
 var retrieveByTopIncidentProductResponse = (RetrieveByTopIncidentProductKbArticleResponse)
     _context.Execute(retrieveByTopIncidentProductRequest);

 // check success
 articles = retrieveByTopIncidentProductResponse.EntityCollection.Entities.Select(
     (entity) => (KbArticle)entity);
 Console.WriteLine("  Top articles for product 'Sample Product':");
 foreach (var article in articles)
     Console.WriteLine(article.Title);

// </snippetretrievebytopincidentproductkbarticle>