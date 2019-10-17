// <snippetlinkcustomattributesbetweenseriesandinstances1>



 // Create a custom string attribute for the appointment instance
 StringAttributeMetadata customAppointmentInstanceAttribute = new StringAttributeMetadata
 {
     LogicalName = "new_customAppInstanceAttribute",
     DisplayName = new Label("CustomAppInstanceAttribute", 1033),
     Description = new Label("Sample Custom Appointment Instance Attribute", 1033),
     MaxLength = 500,
     RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
     SchemaName = "new_customAppInstanceAttribute"
 };

 CreateAttributeRequest instanceAttributeRequest = new CreateAttributeRequest
 {
     Attribute = customAppointmentInstanceAttribute,
     EntityName = "appointment"
 };

 CreateAttributeResponse instanceAttributeResponse = (CreateAttributeResponse)_serviceProxy.Execute(instanceAttributeRequest);
 _instanceAttributeID = instanceAttributeResponse.AttributeId;

 // Create a custom string attribute for the recurring appointment master (series)
 StringAttributeMetadata customAppointmentSeriesAttribute = new StringAttributeMetadata
 {
     LogicalName = "new_customAppSeriesAttribute",
     DisplayName = new Label("CustomAppSeriesAttribute", 1033),
     Description = new Label("Sample Custom Appointment Series Attribute", 1033),
     MaxLength = 500,
     RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
     SchemaName = "new_customAppSeriesAttribute",
     LinkedAttributeId = _instanceAttributeID // Link the custom attribute to the appointment’s custom attribute.
 };

 CreateAttributeRequest seriesAttributeRequest = new CreateAttributeRequest
 {
     Attribute = customAppointmentSeriesAttribute,
     EntityName = "recurringappointmentmaster"
 };

 CreateAttributeResponse seriesAttributeResponse = (CreateAttributeResponse)_serviceProxy.Execute(seriesAttributeRequest);
 _seriesAttributeID = seriesAttributeResponse.AttributeId;

 // Publish all the changes to the solution.
 PublishAllXmlRequest createRequest = new PublishAllXmlRequest();
 _serviceProxy.Execute(createRequest);

 Console.WriteLine("Created a custom string attribute, {0}, for the appointment.", customAppointmentInstanceAttribute.LogicalName);
 Console.WriteLine("Created a custom string attribute, {0}, for the recurring appointment, and linked it with {1}.", customAppointmentSeriesAttribute.LogicalName, customAppointmentInstanceAttribute.LogicalName);

// </snippetlinkcustomattributesbetweenseriesandinstances1>