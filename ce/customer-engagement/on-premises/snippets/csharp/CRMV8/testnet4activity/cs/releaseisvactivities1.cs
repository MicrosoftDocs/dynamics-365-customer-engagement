// <snippetreleaseisvactivities1>


 //Create the request
 RetrieveRequest request = new RetrieveRequest();
 request.ColumnSet = new ColumnSet(new string[] { "birthdate" });
 request.Target = new EntityReference(EntityName.Contact, contactId);

 //Retrieve the entity to determine what the birthdate is set at
 Entity entity = (Entity)((RetrieveResponse)service.Execute(request)).Entity;

// </snippetreleaseisvactivities1>