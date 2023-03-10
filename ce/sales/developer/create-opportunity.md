---
title: Create an opportunity (Dynamics 365 Sales)"
description: Learn about creating a new opportunity or an opportunity from a qualified lead. An opportunity contains sales information like quotes, sales orders, and invoices.
ms.date: 03/01/2023
ms.topic: article
applies_to: 
  - Dynamics 365 Sales
ms.reviewer: lavanyakr
author: udaykirang
ms.author: udag
manager: shujoshi
search.audienceType: 
  - developer

---
# Create an opportunity

You can create an opportunity from a qualified lead or you can create a new opportunity for one of your existing customers. You can track the information about each opportunity, such as state and status of the opportunity, the probability of the sale, and the estimated closing date. An opportunity contains important sales information that can be used later in quotes, sales orders, and invoices. The sales information includes:  
  
-   Products and services from the product catalog and write-in products that you plan to sell  
  
-   Overridden prices of the products and services from the product catalog  
  
-   Discounted prices of the products and services from the product catalog and the write-in products  
  
-   Calculated or estimated revenues  
  
-   Freight rates  
  
-   Calculated tax and cost totals  
  
<a name="bkmk_PreparingDataforanOpportunity"></a>   
## Prepare Data for an Opportunity  
 Before you create an opportunity, ensure that [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] contains necessary data:  
  
- Create accounts, contacts, and leads before you create an opportunity. You can create an opportunity for an existing account or contact, or convert a qualified lead into an opportunity.  
  
- Each opportunity must be associated with one account or a contact.  
  
- Qualify a lead for an opportunity by using your company’s lead qualification criteria. The possible states for a lead are Open, Qualified, and Disqualified.  
  
  If you add products to an opportunity, the system must contain a product catalog, products, price lists, and units of measure.  
  
<a name="bkmk_AddExistingProducts"></a>   
## Add Existing Products and Write-in Products  
 A single opportunity may be associated with multiple products that include existing products and write-in products. Existing products are a part of the product catalog and are associated with the price lists in the product catalog. Write-in products are products that your company sells, but does not include in the product catalog. The prices of write-in products are not associated with the price lists in the product catalog. An existing product or a write-in product is a line item in the opportunity record. The existing products and the write-in products are represented by the opportunity product table. To associate the products with a specific opportunity, use the `OpportunityProduct.OpportunityId` column.  
  
 To set up a product catalog, products, price lists, and discount lists you must have system administrator privileges.  
  
### Add Existing Products from the Product Catalog  
 To specify an existing product from the catalog, set the `OpportunityProduct.IsProductOverridden` column to `false`. Specify the following information: product ID (`OpportunityProduct.ProductId`), price per unit (`OpportunityProduct.PricePerUnit`), quantity (`OpportunityProduct.Quantity`) and units of measure (`OpportunityProduct.UomId`). To associate a price list with the opportunity, use the `Opportunity.PriceLevelId` column. You can add other product-related data, such as tax amount (`OpportunityProduct.Tax`), volume discount (`OpportunityProduct.VolumeDiscountAmount`), or manual discount (`OpportunityProduct.ManualDiscountAmount`).  
  
### Add Write-in Products  
 Although, a write-in product is not in the product catalog, you can add it to an opportunity. To specify a write-in product, set the `OpportunityProduct.IsProductOverridden` column to `true`. Specify the following information: product description (`OpportunityProduct.ProductDescription`), price per unit (`OpportunityProduct.PricePerUnit`), and quantity (`OpportunityProduct.Quantity`). You can add other product-related data, such as tax amount (`OpportunityProduct.Tax`), volume discount (`OpportunityProduct.VolumeDiscountAmount`), or manual discount (`OpportunityProduct.ManualDiscountAmount`).  
  
<a name="bkmk_PriceOverride"></a>   
## Price Overriding  
 For a write-in product, you can use any price that you want and the quantities that you plan to sell. However, if you add an existing product from the catalog, you have an option to override the list price. To override the list price of the existing product, set the `OpportunityProduct.IsPriceOverridden` column to `true`. Specify a desired price by using the `OpportunityProduct.PricePerUnit` column.  
  
<a name="bkmk_ApplyDiscounts"></a>   
## Apply Discounts  
 In addition to price overriding, you can apply volume discounts and manual discounts. The discounts can be applied to line items and to a whole opportunity.  
  
 For example, if the average order from your customers is for five units of your product, you could create an incentive for your customers to order more than five units by giving them a discount when they order six or more units. A discount can be specified as a percentage or an amount. To specify a volume discount for the opportunity product, use the `OpportunityProduct.VolumeDiscountAmount` column. To specify a manual discount for the opportunity product, use the `OpportunityProduct.ManualDiscountAmount` column. To specify an overall discount for the opportunity, use the `Opportunity.DiscountAmount` column.  
  
<a name="bkmk_CalculateTax"></a>   
## Calculate Tax and Totals  
 The estimated tax and the estimated total value of the opportunity are automatically calculated. The estimated value is based on the combined cost of all products added to the opportunity and the associated price lists. Instead of using the system calculated value, you can specify the estimated revenue for the opportunity. To do this, set the `Opportunity.IsRevenueSystemCalculated` column to `false` and specify the estimated value in the `Opportunity.EstimatedValue` column.  
  
 The breakdown of the opportunity total costs is a follows:  
  
- Total amount  
  
- Total amount less freight  
  
- Total discount amount  
  
- Total line item amount  
  
- Total line item discount amount  
  
- Total discount  
  
- Total tax  
  
  Having information about individual costs helps you analyze your overall cost. You can make necessary adjustments to pricing, discounts, and freight cost to help with closing a deal.  
  
<a name="bkmk_CloseAnOpportunity"></a>   
## Close an Opportunity  
 If a customer decides to purchase products or services from your company, you can close an opportunity as a won opportunity. The opportunity states are specified in the `Opportunity.StateCode` column. If you are using early bound types, you can use the `OpportunityState` enumeration. For a list of the state values, see the picklist values for this table. [!INCLUDE[metadata_browser](../../includes/metadata-browser.md)]  
  
 When you close an opportunity, an activity is created automatically by creating a record of the table type opportunity close. The states of the opportunity close activity are specified in the `OpportunityClose.StateCode` column. If you are using early bound types, you can use the `OpportunityCloseState` enumeration. For a list of the state values, see the picklist values for this table.  
  
 The opportunity close activity contains information about the user that created the activity, and the date and time when it was created. It also contains the information about the estimated revenue, close date, and competitor. You can add notes that explain the reasons why you closed the opportunity.  
  
### See also  
 [Opportunity Tables](opportunity-entities.md)   
 [Converting an Opportunity to a Quote, Sales Order or Invoice](convert-opportunity-quote-sales-order-invoice.md)   
 [Product Catalog Tables](product-catalog-entities.md)   
 [Sales Tables](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Customer Tables](/power-apps/developer/data-platform/customer-entities-account-contact)  
 [Generate early-bound classes for the Organization service (CrmSvcUtil.exe)](/power-apps/developer/data-platform/org-service/generate-early-bound-classes)



[!INCLUDE[footer-include](../../includes/footer-banner.md)]