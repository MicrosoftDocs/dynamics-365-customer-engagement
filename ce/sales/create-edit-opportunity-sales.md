---
title: "Create or edit opportunities (Dynamics 365 Sales) | MicrosoftDocs"
description: "An opportunity is a deal you're ready to win. Create an opportunity record for a lead who's ready to buy."
ms.date: 03/29/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-opportunity
  - D365-Entity-lead
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Create or edit opportunities 

Create an opportunity when your lead is almost ready to buy. Use one of the following methods to create an opportunity:

- Convert a qualified lead into an opportunity. In this case,
    - Information from the lead record is copied to the opportunity.
    - The lead and opportunity records are linked. 
- Create a new opportunity from scratch if it didn't originate from a lead.  

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson and above <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Convert a lead to an opportunity

If the opportunity originated from an existing lead, quality the lead and convert it to an opportunity. More information: [Qualify a lead and convert it to an opportunity](qualify-lead-convert-opportunity-sales.md)

## Create an opportunity

Create an opportunity with the details you have. You can update the opportunity as you progress through the different stages of the opportunity - Qualify, Develop, Propose, and Close.  

**To create an opportunity:**

<a name="create-sales-hub"></a>

1. In the Sales Hub site map, select **Opportunities**.

2. On the command bar, select **+ New**.

3. In the **Summary** tab, capture important details about the opportunity. The following list describes fields that require explanation:

    - **Topic**: Specify a brief summary of the opportunity. Include details such as the product, quantity, and customer name. A well-written topic helps your stakeholders spot the opportunity by just glancing through the opportunity list.  **Example:** 125 CRM licenses for Contoso inc. 
    
   - **Currency**: Select the currency to use for calculating values in the opportunity.

     > [!NOTE]
     > Your base record and all its line items must use the same currency. For example, if your opportunity has the currency set to U.S Dollars, you must use the same currency for the price list items that you add to the opportunity. You can't change the currency of the base record (in this case, an opportunity), unless you remove all the list items associated with the record.
     > Similarly, all the records created from an opportunity, such as a quote, order or invoice must use the same currency as the opportunity. 

1. Select the pull-down menu at the top-right corner of the opportunity as shown in the following screenshot:
    
    :::image type="content" source="media/opportunity-est-values.png" alt-text="A screenshot of the estimated close date field."::: 
1. Specify the following details:

    1. If you're not ready to add products to the opportunity yet but want to capture the estimated revenue, specify it in the **Est. Revenue** field. 
        > [!NOTE]
        > When you're ready to add products, you can choose to auto-calculate the revenue based on the products added, price list, discounts and so on. 
    1. Specify the estimated close date in the **Est. Close Date** field.
    1. To change the owner of the opportunity, update the **Owner** field. 
   
4. Select **Save**.

## Typical next steps  

 ![Right arrow button](media/orange-right-arrow-button.png "Right arrow button") [Preview: Find and add multiple products to an opportunity](add-products-enhanced-experience.md)  
 ![Right arrow button](media/orange-right-arrow-button.png "Right arrow button") [Add contacts relevant for the opportunity](add-stakeholder.md)
 ![Right arrow button](media/orange-right-arrow-button.png "Right arrow button") [Move the opportunity through different stages](move-opportunity-stages.md) 
  
 ![Home button](media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](nurture-sales-from-lead-order-sales.md)  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
  
### See also 

[Import opportunity records](/powerapps/user/import-data)
[Create an opportunity by using the Quick create option on the command bar](/powerapps/user/create-a-record)
[Add products to an opportunity](add-products-opportunity.md)  
[Add products to an opportunity using the enhanced experience](add-products-enhanced-experience.md)  
[Recalculate an opportunity](recalculate-opportunity.md)  
[Close an opportunity](close-opportunity-won-lost-sales.md)  
[Work with opportunities in the Kanban view](opportunity-kanban-view.md)  
[Troubleshooting the Opportunity entity](ts-opportunities.md)  
[Boost sales with Versium Predict](../versium-predict/versium-predict.md)   
[Insights, powered by InsideView](../insights-insideview/insights-powered-by-insideview.md)   
[Print quote, invoice, or other records](print-records.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
