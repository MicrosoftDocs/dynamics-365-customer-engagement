// <snippetworkwithglobaloptionsets3>


 // Create a Picklist linked to the option set.
 // Specify which entity will own the picklist, and create it.
 CreateAttributeRequest createRequest = new CreateAttributeRequest
 {
     EntityName = Contact.EntityLogicalName,
     Attribute = new PicklistAttributeMetadata
     {
         SchemaName = "sample_examplepicklist",
         LogicalName = "sample_examplepicklist",
         DisplayName = new Label("Example Picklist", _languageCode),
         RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),

         // In order to relate the picklist to the global option set, be sure
         // to specify the two attributes below appropriately.
         // Failing to do so will lead to errors.
         OptionSet = new OptionSetMetadata
         {
             IsGlobal = true,
             Name = _globalOptionSetName
         }
     }
 };

 _serviceProxy.Execute(createRequest);

// </snippetworkwithglobaloptionsets3>