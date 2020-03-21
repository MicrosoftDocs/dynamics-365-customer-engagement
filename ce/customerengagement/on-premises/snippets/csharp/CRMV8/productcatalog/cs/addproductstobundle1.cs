// <snippetaddproductstobundle1>


 // Add products to a bundle
 ProductAssociation newAssociation1 = new ProductAssociation
 {
     AssociatedProduct = new EntityReference(Product.EntityLogicalName, _product1Id),
     ProductId = new EntityReference(Product.EntityLogicalName, _bundleId),
     Quantity = new decimal(15),
     ProductIsRequired = new OptionSetValue(0), // Adding this as an optional product
     UoMId = new EntityReference(UoM.EntityLogicalName, unit.Id)
 };
 _product1AssociationId = _serviceProxy.Create(newAssociation1);                    
 
 ProductAssociation newAssociation2 = new ProductAssociation
 {
     AssociatedProduct = new EntityReference(Product.EntityLogicalName, _product2Id),
     ProductId = new EntityReference(Product.EntityLogicalName, _bundleId),
     Quantity = new decimal(20),
     ProductIsRequired = new OptionSetValue(1), // Adding this as a mandatory product
     UoMId = new EntityReference(UoM.EntityLogicalName, unit.Id),                        
 };
 _product2AssociationId = _serviceProxy.Create(newAssociation2);

 // Verify if the product association is created
 if ((_product1AssociationId != null) && (_product1AssociationId != null))
 {
     Console.WriteLine("\nAdded both the products to the bundle");
 }

// </snippetaddproductstobundle1>