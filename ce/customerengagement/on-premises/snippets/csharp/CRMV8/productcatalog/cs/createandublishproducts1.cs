// <snippetcreateandublishproducts1>


 // Create a product family
 Product newProductFamily = new Product
 {
     Name = "Example Product Family",
     ProductNumber = "PF001",
     ProductStructure = new OptionSetValue(2)
 };
 _productFamilyId = _serviceProxy.Create(newProductFamily);
 Console.WriteLine("\nCreated {0}", newProductFamily.Name);

 // Create couple of product records under the product family
 Product newProduct1 = new Product
 {
     Name = "Example Product 1",
     ProductNumber = "P001",
     ProductStructure = new OptionSetValue(1),
     ParentProductId = new EntityReference(Product.EntityLogicalName, _productFamilyId),
     QuantityDecimal = 2,
     DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId),
     DefaultUoMId = new EntityReference(UoM.EntityLogicalName, _unit.Id)
 };
 _product1Id = _serviceProxy.Create(newProduct1);

 Console.WriteLine("Created {0} under the product family", newProduct1.Name);

 Product newProduct2 = new Product
 {
     Name = "Example Product 2",
     ProductNumber = "P002",
     ProductStructure = new OptionSetValue(1),
     ParentProductId = new EntityReference(Product.EntityLogicalName, _productFamilyId),
     QuantityDecimal = 2,
     DefaultUoMScheduleId = new EntityReference(UoMSchedule.EntityLogicalName, _unitGroupId),
     DefaultUoMId = new EntityReference(UoM.EntityLogicalName, _unit.Id)
 };
 _product2Id = _serviceProxy.Create(newProduct2);

 Console.WriteLine("Created {0} under the product family", newProduct2.Name);

 // Create a price list items for the products
 ProductPriceLevel newPriceListItem1 = new ProductPriceLevel
 {
     PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
     ProductId = new EntityReference(Product.EntityLogicalName, _product1Id),
     UoMId = new EntityReference(UoM.EntityLogicalName, _unit.Id),
     Amount = new Money(20)
 };
 _priceListItem1Id = _serviceProxy.Create(newPriceListItem1);

 Console.WriteLine("Created price list for {0}", newProduct1.Name);

 ProductPriceLevel newPriceListItem2 = new ProductPriceLevel
 {
     PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName, _priceListId),
     ProductId = new EntityReference(Product.EntityLogicalName, _product2Id),
     UoMId = new EntityReference(UoM.EntityLogicalName, _unit.Id),
     Amount = new Money(20)
 };
 _priceListItem2Id = _serviceProxy.Create(newPriceListItem2);

 Console.WriteLine("Created price list for {0}", newProduct2.Name);

 // Set the product relationship
 // Set Example Product 1 and Example Product 2 as substitute of each other (bi-directional)
 ProductSubstitute newProductRelation = new ProductSubstitute
 {
     SalesRelationshipType = new OptionSetValue(3),
     Direction = new OptionSetValue(1),
     ProductId = new EntityReference(Product.EntityLogicalName, _product1Id),
     SubstitutedProductId = new EntityReference(Product.EntityLogicalName, _product2Id)
 };
 _productRelationId = _serviceProxy.Create(newProductRelation);

 Console.WriteLine("Created a substitute relation between the two products.");

// </snippetcreateandublishproducts1>