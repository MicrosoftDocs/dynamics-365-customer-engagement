// <snippetretrieveduplicatesrequest>


 var request = new RetrieveDuplicatesRequest
 {
     BusinessEntity = new Account { Name = "Microsoft" }.ToEntity<Entity>(),
     MatchingEntityName = Account.EntityLogicalName,
     PagingInfo = new PagingInfo() { PageNumber = 1, Count = 50 }
 };

 Console.WriteLine("Retrieving duplicates");
 var response =(RetrieveDuplicatesResponse)_serviceProxy.Execute(request);

// </snippetretrieveduplicatesrequest>