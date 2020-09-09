// <snippetretrievedatafilters2>



 // Call InstantiateFiltersRequest
 Console.WriteLine("Retrieving user's ID and creating the template collection");
 WhoAmIRequest whoAmI = new WhoAmIRequest();
 Guid id = ((WhoAmIResponse)_serviceProxy.Execute(whoAmI)).UserId;
 EntityReferenceCollection templates = new EntityReferenceCollection();
 templates.Add(new EntityReference(
     SavedQuery.EntityLogicalName,
     _offlineTemplate));

 Console.WriteLine("Activating the selected offline templates for this user");
 InstantiateFiltersRequest request = new InstantiateFiltersRequest
 {
     UserId = id,
     TemplateCollection = templates                            
 };
 InstantiateFiltersResponse response =
     (InstantiateFiltersResponse)_serviceProxy.Execute(request);
 Console.WriteLine();

// </snippetretrievedatafilters2>