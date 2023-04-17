---
title: Product pricing methods (Dynamics 365 Sales)
description: Use the ProductPriceLevel.PricingMethodCode column to determine product prices.
ms.date: 03/01/2023
ms.reviewer: lavanyakr
ms.topic: article
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
search.audienceType: 
  - developer

---
# Product pricing methods

Dynamics 365 Sales uses the `ProductPriceLevel.PricingMethodCode` column to determine prices. The value of this column affects:  
  
- How the price for the product is determined for each unit of measure that is defined for that product.  
  
- What columns are required when you create or update a product price level and its associated product.  
  
  You can also use custom pricing for products instead of using the Dynamics 365 system pricing. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Use custom pricing for products](use-custom-pricing-products.md)  
  
  The following table lists the formulas that are used for each value and the columns that are required by each value.  
  
| Drop-down list value and equivalent pricing method value | Description and required columns |
|----------------------------------------------------------|-------------------------------------|
| **Currency Amount** <br />CurrencyAmount = 1 |  The price is specified for each unit of measure for each product. <br />price = amount<br /><br /> For each unit of measure for each product, use the `ProductPriceLevel.Amount` column. **Note:**  The `ProductPriceLevel.Amount` column isn’t platform required if you’re not using the pricing methods provided by [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. However, if you use the `Currency Amount` pricing method to determine a price, this column is platform required and you must specify a value for this column. |
| **Percent of List** <br />PercentListPrice = 2 | The price is calculated based on the manufacturer's or distributor's list price. <br />calculated price = list price x percentage<br /><br /> For each unit of measure for each product, you must enter data for the following columns:<br /><br /> -   `Product.Price` column. This is the **List Price** in the **Product** form.<br />-   `ProductPriceLevel.Percentage` column. This is the desired percentage of the list price.<br />-   `ProductPriceLevel.RoundingPolicyCode` column. This is the policy for rounding the price list. |
|  **Percent Markup - Current Cost** <br />MarkupCurrentCost = 3  | The price is calculated as a percentage of your current cost for the item. <br />calculated price = current cost x 100% + percentage<br /><br /> For each unit of measure for each product, you must enter data for the following columns:<br /><br /> -   `Product.CurrentCost` column. You must update this cost every time that you receive a shipment of the item.<br />-   `ProductPriceLevel.Percentage` column. This is the percent markup.<br />-   `ProductPriceLevel.RoundingPolicyCode` column. |
|  **Percent Margin - Current Cost** <br />MarginCurrentCost =4 | The price is based on the profit percentage you want to achieve and your current cost for the item. <br />calculated price = current cost + [(current cost x percentage)/ (100% - percentage)]<br /><br /> For each unit of measure for each product, you must enter data for the following columns:<br /><br /> -   `Product.StandardCost` column. You must update this cost every time when you receive a shipment of the item.<br />-   `ProductPriceLevel.Percentage` column. This is the profit percentage you want to achieve.<br />-   `ProductPriceLevel.RoundingPolicyCode` column. |
| **Percent Markup - Standard Cost** <br />MarkupStandardCost = 5 | The price is calculated as a percentage of the standard cost of the item. <br />calculated price = standard cost x 100% + percentage <br />Because the standard cost is updated periodically, the standard cost amount in this equation is an average and will not always be the same as the amount you paid most recently for the item.<br /><br /> For each unit of measure for each product, you must enter data for the following columns:<br /><br /> -   `Product.StandardCost` column. Every time that you update the standard cost, the price changes.<br />-   `ProductPriceLevel.Percentage` column. This is the percent markup.<br />-   `ProductPriceLevel.RoundingPolicyCode` column.  |
| **Percent Margin - Standard Cost** <br />MarginStandardCost = 6 | The price is based on the profit percentage you want to achieve and the standard cost of the item. <br />calculated price = standard cost + [(standard cost x percentage)/(100% - percentage)]<br />Because the standard cost is updated periodically, the standard cost amount in this equation is an average and will not always be the same as the amount you paid most recently for the item.<br /><br /> For each unit of measure for each product, you must enter data for the following columns:<br /><br /> -   `Product.StandardCost` column. Every time that you update the standard cost, the price changes.<br />-   `ProductPriceLevel.Percentage` column. This is the profit percentage you want to achieve.<br />-   `ProductPriceLevel.RoundingPolicyCode` column. |
  
 To set the values for the `ProductPriceLevel.PricingMethodCode` column and the other product price level table columns, use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> method, passing an instance of the `ProductPriceLevel` class. To set the values for the product columns, use the methods in the `Product` class.  
  
### See Also  
 [ProductPriceLevel Table](entities/productpricelevel.md)   
 [Product Table](entities/product.md)   
 [Product Catalog Tables](product-catalog-entities.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
