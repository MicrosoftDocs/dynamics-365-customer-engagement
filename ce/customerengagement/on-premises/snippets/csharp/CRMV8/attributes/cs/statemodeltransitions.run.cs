// <snippetstatemodeltransitions.run>


 String entityLogicalName = "incident";
 // Retrieve status options for the Incident entity

 //Retrieve just the incident entity and its attributes
 MetadataFilterExpression entityFilter = new MetadataFilterExpression(LogicalOperator.And);
 entityFilter.Conditions.Add(new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, entityLogicalName));
 MetadataPropertiesExpression entityProperties = new MetadataPropertiesExpression(new string[] { "Attributes" });
 
 //Retrieve just the status attribute and the OptionSet property
 MetadataFilterExpression attributeFilter = new MetadataFilterExpression(LogicalOperator.And);
 attributeFilter.Conditions.Add(new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Status));
 MetadataPropertiesExpression attributeProperties = new MetadataPropertiesExpression(new string[] { "OptionSet" });
 
 //Instantiate the entity query
 EntityQueryExpression query = new EntityQueryExpression()
 {
  Criteria = entityFilter,
  Properties = entityProperties,
  AttributeQuery = new AttributeQueryExpression() { Criteria = attributeFilter, Properties = attributeProperties }
 };

 //Retrieve the metadata
 RetrieveMetadataChangesRequest request = new RetrieveMetadataChangesRequest() { Query = query };
 RetrieveMetadataChangesResponse response = (RetrieveMetadataChangesResponse)_serviceProxy.Execute(request);


 StatusAttributeMetadata statusAttribute = (StatusAttributeMetadata)response.EntityMetadata[0].Attributes[0];
 OptionMetadataCollection statusOptions = statusAttribute.OptionSet.Options;
 //Loop through each of the status options
 foreach (StatusOptionMetadata option in statusOptions)
 {
  String StatusOptionLabel = GetOptionSetLabel(statusAttribute, option.Value.Value);
  Console.WriteLine("[{0}] {1} records can transition to:", StatusOptionLabel, entityLogicalName);
  List<StatusOption> validStatusOptions = GetValidStatusOptions(entityLogicalName, option.Value.Value);
  //Loop through each valid transition for the option
  foreach (StatusOption opt in validStatusOptions)
  {
   Console.WriteLine("{0,-3}{1,-10}{2,-5}{3,-10}", opt.StateValue, opt.StateLabel, opt.StatusValue, opt.StatusLabel);
  }
  Console.WriteLine("");
 }

// </snippetstatemodeltransitions.run>