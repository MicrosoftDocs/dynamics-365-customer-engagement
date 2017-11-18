// <snippetconvertdateandtimebehavior2>


 // Create a date time attribute for the Account entity
 // with the UserLocal behavior
 dtAttribute = new DateTimeAttributeMetadata
 {                             
     SchemaName = "new_SampleDateTimeAttribute",
     DisplayName = new Label("Sample Date Time Attribute", _languageCode),
     RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),                
     Description = new Label("Created by SDK Sample", _languageCode),                
     DateTimeBehavior = DateTimeBehavior.UserLocal,
     Format = DateTimeFormat.DateAndTime,
     ImeMode = ImeMode.Disabled
 };

 CreateAttributeRequest createAttributeRequest = new CreateAttributeRequest
 {
     EntityName = Account.EntityLogicalName,
     Attribute = dtAttribute
 };
 _serviceProxy.Execute(createAttributeRequest);
 Console.WriteLine("Created attribute '{0}' with UserLocal behavior\nfor the Account entity.\n", 
                             dtAttribute.SchemaName);

// </snippetconvertdateandtimebehavior2>