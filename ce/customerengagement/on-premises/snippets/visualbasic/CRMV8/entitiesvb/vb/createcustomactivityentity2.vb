' <snippetcreatecustomactivityentity2>


 Dim prefix As String = "new_"

 Dim customEntityName As String = prefix &amp; "instantmessage"

 ' Create the custom activity entity.
 Dim request As CreateEntityRequest = New CreateEntityRequest With {
  .HasNotes = True,
  .HasActivities = False,
  .PrimaryAttribute = New StringAttributeMetadata With {
   .SchemaName = "Subject",
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   .MaxLength = 100,
   .DisplayName = New Label("Subject", 1033)},
  .Entity = New EntityMetadata With {
   .IsActivity = True,
   .SchemaName = customEntityName,
   .DisplayName = New Label("Instant Message", 1033),
   .DisplayCollectionName = New Label("Instant Messages", 1033),
   .OwnershipType = OwnershipTypes.UserOwned,
   .IsAvailableOffline = True}}

 _serviceProxy.Execute(request)

 'Entity must be published

' </snippetcreatecustomactivityentity2>