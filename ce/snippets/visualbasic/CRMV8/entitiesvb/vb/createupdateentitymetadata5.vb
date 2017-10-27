' <snippetcreateupdateentitymetadata5>


 Dim req As New CreateOneToManyRequest() With {
  .Lookup = New LookupAttributeMetadata() With {
   .Description = New Label("The owner of the bank account", 1033),
   .DisplayName = New Label("Account Owner", 1033),
   .LogicalName = "new_parent_contactid",
   .SchemaName = "New_Parent_ContactId",
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.ApplicationRequired)},
  .OneToManyRelationship = New OneToManyRelationshipMetadata() With {
   .AssociatedMenuConfiguration = New AssociatedMenuConfiguration() With {
    .Behavior = AssociatedMenuBehavior.UseCollectionName,
    .Group = AssociatedMenuGroup.Details,
    .Label = New Label("Bank Accounts", 1033),
    .Order = 10000},
   .CascadeConfiguration = New CascadeConfiguration() With {
    .Assign = CascadeType.Cascade,
    .Delete = CascadeType.Cascade,
    .Merge = CascadeType.Cascade,
    .Reparent = CascadeType.Cascade,
    .Share = CascadeType.Cascade,
    .Unshare = CascadeType.Cascade},
   .ReferencedEntity = Contact.EntityLogicalName,
   .ReferencedAttribute = "contactid",
   .ReferencingEntity = _customEntityName,
   .SchemaName = "new_contact_new_bankaccount"
  }
 }
 _serviceProxy.Execute(req)

' </snippetcreateupdateentitymetadata5>