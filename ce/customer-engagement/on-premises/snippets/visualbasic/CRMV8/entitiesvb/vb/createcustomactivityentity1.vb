' <snippetcreatecustomactivityentity1>


 ' The custom prefix would typically be passed in as an argument or 
 ' determined by the publisher of the custom solution.
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

 ' Add few attributes to the custom activity entity.
 Dim fontFamilyAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = customEntityName,
  .Attribute = New StringAttributeMetadata With {
   .SchemaName = prefix &amp; "fontfamily",
   .DisplayName = New Label("Font Family", 1033),
   .MaxLength = 100}}
 Dim fontFamilyAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(fontFamilyAttributeRequest), CreateAttributeResponse)

 Dim fontColorAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = customEntityName,
  .Attribute = New StringAttributeMetadata With {
   .SchemaName = prefix &amp; "fontcolor",
   .DisplayName = New Label("Font Color", 1033),
   .MaxLength = 50}}
 Dim fontColorAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(fontColorAttributeRequest), CreateAttributeResponse)

 Dim fontSizeAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = customEntityName,
  .Attribute = New IntegerAttributeMetadata With {
   .SchemaName = prefix &amp; "fontSize",
   .DisplayName = New Label("Font Size", 1033)}}
 Dim fontSizeAttributeResponse As CreateAttributeResponse = CType(_serviceProxy.Execute(fontSizeAttributeRequest), CreateAttributeResponse)

' </snippetcreatecustomactivityentity1>