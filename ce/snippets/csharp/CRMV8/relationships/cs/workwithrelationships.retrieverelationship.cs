// <snippetworkwithrelationships.retrieverelationship>



 //You can use either the Name or the MetadataId of the relationship.

 //Retrieve the One-to-many relationship using the MetadataId.
 RetrieveRelationshipRequest retrieveOneToManyRequest =
     new RetrieveRelationshipRequest { MetadataId = _oneToManyRelationshipId };
 RetrieveRelationshipResponse retrieveOneToManyResponse =
     (RetrieveRelationshipResponse)_serviceProxy.Execute(retrieveOneToManyRequest);

 Console.WriteLine("Retrieved {0} One-to-many relationship by id", retrieveOneToManyResponse.RelationshipMetadata.SchemaName);

 //Retrieve the Many-to-many relationship using the Name.
 RetrieveRelationshipRequest retrieveManyToManyRequest =
     new RetrieveRelationshipRequest { Name = _manyToManyRelationshipName};
 RetrieveRelationshipResponse retrieveManyToManyResponse =
     (RetrieveRelationshipResponse)_serviceProxy.Execute(retrieveManyToManyRequest);

 Console.WriteLine("Retrieved {0} Many-to-Many relationship by Name", retrieveManyToManyResponse.RelationshipMetadata.MetadataId);

// </snippetworkwithrelationships.retrieverelationship>