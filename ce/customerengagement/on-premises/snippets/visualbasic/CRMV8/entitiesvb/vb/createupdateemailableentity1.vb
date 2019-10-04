' <snippetcreateupdateemailableentity1>



 ' Create the custom entity.
 Dim createrequest As CreateEntityRequest = New CreateEntityRequest With {.Entity = New EntityMetadata With {
   .SchemaName = _customEntityName,
   .DisplayName = New Label("Agent", 1033),
   .DisplayCollectionName = New Label("Agents", 1033),
   .Description = New Label("Insurance Agents", 1033),
   .OwnershipType = OwnershipTypes.UserOwned,
   .IsActivity = False, .IsActivityParty = True},
   .PrimaryAttribute = New StringAttributeMetadata With {
    .SchemaName = "new_fullname",
    .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
    .MaxLength = 100,
    .Format = StringFormat.Text,
    .DisplayName = New Label("Agent Name", 1033),
    .Description = New Label("Agent Name", 1033)
    }
   }
 ' Define an entity to enable for emailing. In order to do so,
 ' IsActivityParty must be set.
 ' Unless this flag is set, this entity cannot be party to an
 ' activity.
 ' As with built-in emailable entities, the Primary Attribute will
 ' be used in the activity party screens. Be sure to choose descriptive
 ' attributes.

 _serviceProxy.Execute(createrequest)
 Console.WriteLine("The emailable entity has been created.")

 ' The entity will not be selectable as an activity party until its customizations
 ' have been published. Otherwise, the e-mail activity dialog cannot find
 ' a correct default view.
 Dim publishRequest As New PublishAllXmlRequest()
 _serviceProxy.Execute(publishRequest)

 ' Before any emails can be created for this entity, an Email attribute
 ' must be defined.
 Dim createFirstEmailAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = _customEntityName,
  .Attribute = New StringAttributeMetadata With {
   .SchemaName = "new_emailaddress",
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   .MaxLength = 100,
   .Format = StringFormat.Email,
   .DisplayName = New Label("Email Address", 1033),
   .Description = New Label("Email Address", 1033)
  }
 }

 _serviceProxy.Execute(createFirstEmailAttributeRequest)
 Console.WriteLine("An email attribute has been added to the emailable entity.")

 ' Create a second, alternate email address. Since there is already one 
 ' email attribute on the entity, this will never be used for emailing
 ' even if the first one is not populated.
 Dim createSecondEmailAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = _customEntityName,
  .Attribute = New StringAttributeMetadata With {
   .SchemaName = "new_secondaryaddress",
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   .MaxLength = 100,
   .Format = StringFormat.Email,
   .DisplayName = New Label("Secondary Email Address", 1033),
   .Description = New Label("Secondary Email Address", 1033)
  }
 }

 _serviceProxy.Execute(createSecondEmailAttributeRequest)

 Console.WriteLine("A second email attribute has been added to the emailable entity.")

' </snippetcreateupdateemailableentity1>