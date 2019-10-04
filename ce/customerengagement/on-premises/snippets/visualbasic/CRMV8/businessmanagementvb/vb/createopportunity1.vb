' <snippetcreateopportunity1>



 ' Create a new opportunity with user specified estimated revenue
 Dim newOpportunity As Opportunity = New Opportunity With { _
     .Name = "Example Opportunity", .CustomerId = New EntityReference(Account.EntityLogicalName, _accountId), _
     .PriceLevelId = New EntityReference(PriceLevel.EntityLogicalName, _priceListId), _
     .IsRevenueSystemCalculated = False, .EstimatedValue = New Money(400D), _
     .FreightAmount = New Money(10D), .DiscountAmount = New Money(0.1D), .DiscountPercentage = 0.2D}

 _opportunityId = _serviceProxy.Create(newOpportunity)
 Console.WriteLine("Created {0} with user specified estimated revenue.", newOpportunity.Name)

 ' Create a new opportunity product from the catalog

 ' Create a catalog product
 Dim catalogProduct As OpportunityProduct = New OpportunityProduct With { _
     .OpportunityId = New EntityReference(Opportunity.EntityLogicalName, _opportunityId), _
     .ProductId = New EntityReference(Product.EntityLogicalName, _product1Id), _
     .UoMId = New EntityReference(UoM.EntityLogicalName, _defaultUnitId), .Quantity = 8, .Tax = New Money(12.42D)}

 _catalogProductId = _serviceProxy.Create(catalogProduct)
 Console.WriteLine("Created the catalog product.")

 ' Create anothter catalog product and override the list price
 Dim catalogProductPriceOverride As OpportunityProduct = New OpportunityProduct With { _
     .OpportunityId = New EntityReference(Opportunity.EntityLogicalName, _opportunityId), _
     .ProductId = New EntityReference(Product.EntityLogicalName, _product2Id), _
     .UoMId = New EntityReference(UoM.EntityLogicalName, _defaultUnitId), .Quantity = 3, _
     .Tax = New Money(2.88D), .IsPriceOverridden = True, .PricePerUnit = New Money(12)}

 _catalogProductPriceOverrideId = _serviceProxy.Create(catalogProductPriceOverride)
 Console.WriteLine("Created another catalog product and " &amp; _
                   ControlChars.CrLf &amp; "                    overriden the list price.")

 ' create a new write-in opportunity product with a manual discount applied
 Dim writeInProduct As OpportunityProduct = New OpportunityProduct With { _
     .OpportunityId = New EntityReference(Opportunity.EntityLogicalName, _opportunityId), _
     .IsProductOverridden = True, .ProductDescription = "Example Write-in Product", _
     .PricePerUnit = New Money(20D), .Quantity = 5, _
     .ManualDiscountAmount = New Money(10.5D), .Tax = New Money(7.16D)}

 _writeInProductId = _serviceProxy.Create(writeInProduct)
 Console.WriteLine("Created {0}.", writeInProduct.ProductDescription)

' </snippetcreateopportunity1>