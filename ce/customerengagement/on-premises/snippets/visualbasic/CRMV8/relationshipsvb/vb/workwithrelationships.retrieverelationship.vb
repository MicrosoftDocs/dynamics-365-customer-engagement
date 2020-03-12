' <snippetworkwithrelationships.retrieverelationship>



 'You can use either the Name or the MetadataId of the relationship.

 'Retrieve the One-to-many relationship using the MetadataId.
 Dim retrieveOneToManyRequest As RetrieveRelationshipRequest =
  New RetrieveRelationshipRequest With {.MetadataId = _oneToManyRelationshipId}
 Dim retrieveOneToManyResponse As RetrieveRelationshipResponse =
  CType(_serviceProxy.Execute(retrieveOneToManyRequest), RetrieveRelationshipResponse)

 Console.WriteLine("Retrieved {0} One-to-many relationship by id",
                   retrieveOneToManyResponse.RelationshipMetadata.SchemaName)

 'Retrieve the Many-to-many relationship using the Name.
 Dim retrieveManyToManyRequest As RetrieveRelationshipRequest =
  New RetrieveRelationshipRequest With {
   .Name = _manyToManyRelationshipName
  }
 Dim retrieveManyToManyResponse As RetrieveRelationshipResponse =
  CType(_serviceProxy.Execute(retrieveManyToManyRequest), RetrieveRelationshipResponse)

 Console.WriteLine("Retrieved {0} Many-to-Many relationship by Name",
                   retrieveManyToManyResponse.RelationshipMetadata.MetadataId)

' </snippetworkwithrelationships.retrieverelationship>