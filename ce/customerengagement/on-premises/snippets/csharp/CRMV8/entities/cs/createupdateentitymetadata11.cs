// <snippetcreateupdateentitymetadata11>


 //Create an Image attribute for the custom entity
 // Only one Image attribute can be added to an entity that doesn't already have one.
 CreateAttributeRequest createEntityImageRequest = new CreateAttributeRequest
 {
  EntityName = _customEntityName,
  Attribute = new ImageAttributeMetadata
  {
   SchemaName = "EntityImage", //The name is always EntityImage
   RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   DisplayName = new Label("Image", 1033),
   Description = new Label("An image to represent the bank account.", 1033)

  }
 };

 _serviceProxy.Execute(createEntityImageRequest);
 Console.WriteLine("An image attribute has been added to the bank account entity.");

// </snippetcreateupdateentitymetadata11>