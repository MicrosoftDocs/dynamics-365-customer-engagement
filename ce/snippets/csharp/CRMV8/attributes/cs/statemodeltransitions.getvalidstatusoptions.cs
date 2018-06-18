// <snippetstatemodeltransitions.getvalidstatusoptions>


 /// <summary>
 /// Returns valid status option transitions regardless of whether state transitions are enabled for the entity
 /// </summary>
 /// <param name="entityLogicalName">The logical name of the entity</param>
 /// <param name="currentStatusValue">The current status of the entity instance</param>
 /// <returns>A list of StatusOptions that represent the valid transitions</returns>
 public List<StatusOption> GetValidStatusOptions(String entityLogicalName, int currentStatusValue)
 {

  List<StatusOption> validStatusOptions = new List<StatusOption>();

  //Check entity Metadata

  //Retrieve just one entity definition
  MetadataFilterExpression entityFilter = new MetadataFilterExpression(LogicalOperator.And);
  entityFilter.Conditions.Add(new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, entityLogicalName));
  //Return the attributes and the EnforceStateTransitions property
  MetadataPropertiesExpression entityProperties = new MetadataPropertiesExpression(new string[] { "Attributes", "EnforceStateTransitions" });

  //Retrieve only State or Status attributes
  MetadataFilterExpression attributeFilter = new MetadataFilterExpression(LogicalOperator.Or);
  attributeFilter.Conditions.Add(new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Status));
  attributeFilter.Conditions.Add(new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.State));

  //Retrieve only the OptionSet property of the attributes
  MetadataPropertiesExpression attributeProperties = new MetadataPropertiesExpression(new string[] { "OptionSet" });

  //Set the query
  EntityQueryExpression query = new EntityQueryExpression()
  {
   Criteria = entityFilter,
   Properties = entityProperties,
   AttributeQuery = new AttributeQueryExpression() { Criteria = attributeFilter, Properties = attributeProperties }
  };

  //Retrieve the metadata
  RetrieveMetadataChangesRequest request = new RetrieveMetadataChangesRequest() { Query = query };
  RetrieveMetadataChangesResponse response = (RetrieveMetadataChangesResponse)_serviceProxy.Execute(request);

  //Check the value of EnforceStateTransitions
  Boolean? EnforceStateTransitions = response.EntityMetadata[0].EnforceStateTransitions;

  //Capture the state and status attributes
  StatusAttributeMetadata statusAttribute = new StatusAttributeMetadata();
  StateAttributeMetadata stateAttribute = new StateAttributeMetadata();

  foreach (AttributeMetadata attributeMetadata in response.EntityMetadata[0].Attributes)
  {
   switch (attributeMetadata.AttributeType)
   {
    case AttributeTypeCode.Status:
     statusAttribute = (StatusAttributeMetadata)attributeMetadata;
     break;
    case AttributeTypeCode.State:
     stateAttribute = (StateAttributeMetadata)attributeMetadata;
     break;
   }
  }


  if (EnforceStateTransitions.HasValue && EnforceStateTransitions.Value == true)
  {
   //When EnforceStateTransitions is true use the TransitionData to filter the valid options
   foreach (StatusOptionMetadata option in statusAttribute.OptionSet.Options)
   {
    if (option.Value == currentStatusValue)
    {
     if (option.TransitionData != String.Empty)
     {
      XDocument transitionData = XDocument.Parse(option.TransitionData);

      IEnumerable<XElement> elements = (((XElement)transitionData.FirstNode)).Descendants();

      foreach (XElement e in elements)
      {
       int statusOptionValue = Convert.ToInt32(e.Attribute("tostatusid").Value);
       String statusLabel = GetOptionSetLabel(statusAttribute, statusOptionValue);

       string stateLabel = String.Empty;
       int? stateValue = null;
       foreach (StatusOptionMetadata statusOption in statusAttribute.OptionSet.Options)
       {
        if (statusOption.Value.Value == statusOptionValue)
        {
         stateValue = statusOption.State.Value;
         stateLabel = GetOptionSetLabel(stateAttribute, stateValue.Value);
        }

       }


       validStatusOptions.Add(new StatusOption()
       {
        StateLabel = stateLabel,
        StateValue = stateValue.Value,
        StatusLabel = statusLabel,
        StatusValue = option.Value.Value
       });
      }
     }
    }
   }

  }
  else
  {
   ////When EnforceStateTransitions is false do not filter the available options

   foreach (StatusOptionMetadata option in statusAttribute.OptionSet.Options)
   {
    if (option.Value != currentStatusValue)
    {

     String statusLabel = "";
     try
     {
      statusLabel = option.Label.UserLocalizedLabel.Label;
     }
     catch (Exception)
     {
      statusLabel = option.Label.LocalizedLabels[0].Label;
     };

     String stateLabel = GetOptionSetLabel(stateAttribute, option.State.Value);

     validStatusOptions.Add(new StatusOption()
     {
      StateLabel = stateLabel,
      StateValue = option.State.Value,
      StatusLabel = statusLabel,
      StatusValue = option.Value.Value

     });
    }
   }
  }
  return validStatusOptions;

 }

// </snippetstatemodeltransitions.getvalidstatusoptions>