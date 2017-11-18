' <snippetworkwithglobaloptionsets3>


 ' Create a Picklist linked to the option set.
 ' Specify which entity will own the picklist, and create it.
 Dim createRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = Contact.EntityLogicalName,
  .Attribute = New PicklistAttributeMetadata With {
   .SchemaName = "sample_examplepicklist", .LogicalName = "sample_examplepicklist",
   .DisplayName = New Label("Example Picklist", _languageCode),
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   .OptionSet = New OptionSetMetadata With {
    .IsGlobal = True,
    .Name = _globalOptionSetName
   }
  }
 }
 ' In order to relate the picklist to the global option set, be sure
 ' to specify the two attributes below appropriately.
 ' Failing to do so will lead to errors.

 _serviceProxy.Execute(createRequest)

' </snippetworkwithglobaloptionsets3>