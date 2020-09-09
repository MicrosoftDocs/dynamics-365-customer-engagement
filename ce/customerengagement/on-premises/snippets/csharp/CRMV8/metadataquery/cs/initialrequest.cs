// <snippetinitialrequest>


 //An entity query expression to combine the filter expressions and property expressions for the query.
 EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
 {

  Criteria = EntityFilter,
  Properties = EntityProperties,
  AttributeQuery = new AttributeQueryExpression()
  {
   Criteria = AttributeFilter,
   Properties = AttributeProperties
  },
  LabelQuery = labelQuery

 };
 
 //Retrieve the metadata for the query without a ClientVersionStamp
 RetrieveMetadataChangesResponse initialRequest = getMetadataChanges(entityQueryExpression, null, DeletedMetadataFilters.OptionSet);

// </snippetinitialrequest>