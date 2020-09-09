// <snippetgetsolutiondependencies8>


 // Use the RetrieveOptionSetRequest message to retrieve  
 // a global option set by it's name.
 RetrieveOptionSetRequest retrieveOptionSetRequest =
     new RetrieveOptionSetRequest
     {
      Name = _globalOptionSetName
     };

 // Execute the request.
 RetrieveOptionSetResponse retrieveOptionSetResponse =
     (RetrieveOptionSetResponse)_serviceProxy.Execute(
     retrieveOptionSetRequest);
 _globalOptionSetId = retrieveOptionSetResponse.OptionSetMetadata.MetadataId;
 if (_globalOptionSetId != null)
 { 
  //Use the global OptionSet MetadataId with the appropriate componenttype
  // to call RetrieveDependenciesForDeleteRequest
  RetrieveDependenciesForDeleteRequest retrieveDependenciesForDeleteRequest = new RetrieveDependenciesForDeleteRequest 
 { 
  ComponentType = (int)componenttype.OptionSet,
  ObjectId = (Guid)_globalOptionSetId
 };

  RetrieveDependenciesForDeleteResponse retrieveDependenciesForDeleteResponse =
   (RetrieveDependenciesForDeleteResponse)_serviceProxy.Execute(retrieveDependenciesForDeleteRequest);
  Console.WriteLine("");
  foreach (Dependency d in retrieveDependenciesForDeleteResponse.EntityCollection.Entities)
  {

   if (d.DependentComponentType.Value == 2)//Just testing for Attributes
   {
    String attributeLabel = "";
    RetrieveAttributeRequest retrieveAttributeRequest = new RetrieveAttributeRequest
    {
     MetadataId = (Guid)d.DependentComponentObjectId
    };
    RetrieveAttributeResponse retrieveAttributeResponse = (RetrieveAttributeResponse)_serviceProxy.Execute(retrieveAttributeRequest);

    AttributeMetadata attmet = retrieveAttributeResponse.AttributeMetadata;

    attributeLabel = attmet.DisplayName.UserLocalizedLabel.Label;
   
     Console.WriteLine("An {0} named {1} will prevent deleting the {2} global option set.", 
    (componenttype)d.DependentComponentType.Value, 
    attributeLabel, 
    _globalOptionSetName);
   }
  }                 
 }

// </snippetgetsolutiondependencies8>