// <snippetcreateopportunity1>



 // Create a new opportunity with user specified estimated revenue
 Opportunity newOpportunity = new Opportunity
 {
     Name = "Example Opportunity",
     CustomerId = new EntityReference(Account.EntityLogicalName,
         _accountId),
     PriceLevelId = new EntityReference(PriceLevel.EntityLogicalName,
         _priceListId),
     IsRevenueSystemCalculated = false,
     EstimatedValue = new Money(400.00m),
     FreightAmount = new Money(10.00m),
     DiscountAmount = new Money(0.10m),
     DiscountPercentage = 0.20m
 };

 _opportunityId = _serviceProxy.Create(newOpportunity);
 Console.WriteLine("Created {0} with user specified estimated revenue.",
     newOpportunity.Name);

 // Create a new opportunity product from the catalog

 // Create a catalog product
 OpportunityProduct catalogProduct = new OpportunityProduct
 {
     OpportunityId = new EntityReference(Opportunity.EntityLogicalName,
         _opportunityId),
     ProductId = new EntityReference(Product.EntityLogicalName,
         _product1Id),
     UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
     Quantity = 8,
     Tax = new Money(12.42m)
 };

 _catalogProductId = _serviceProxy.Create(catalogProduct);
 Console.WriteLine("Created the catalog product.");

 // Create anothter catalog product and override the list price
 OpportunityProduct catalogProductPriceOverride = new OpportunityProduct
 {
     OpportunityId = new EntityReference(Opportunity.EntityLogicalName,
         _opportunityId),
     ProductId = new EntityReference(Product.EntityLogicalName,
         _product2Id),
     UoMId = new EntityReference(UoM.EntityLogicalName, _defaultUnitId),
     Quantity = 3,
     Tax = new Money(2.88m),
     IsPriceOverridden = true,
     PricePerUnit = new Money(12)
 };

 _catalogProductPriceOverrideId = _serviceProxy.Create(
     catalogProductPriceOverride);
 Console.WriteLine(@"Created another catalog product and 
 overriden the list price.");

 // create a new write-in opportunity product with a manual discount applied
 OpportunityProduct writeInProduct = new OpportunityProduct
 {
     OpportunityId = new EntityReference(Opportunity.EntityLogicalName,
         _opportunityId),
     IsProductOverridden = true,
     ProductDescription = "Example Write-in Product",
     PricePerUnit = new Money(20.00m),
     Quantity = 5,
     ManualDiscountAmount = new Money(10.50m),
     Tax = new Money(7.16m)
 };

 _writeInProductId = _serviceProxy.Create(writeInProduct);
 Console.WriteLine("Created {0}.", writeInProduct.ProductDescription);

// </snippetcreateopportunity1>