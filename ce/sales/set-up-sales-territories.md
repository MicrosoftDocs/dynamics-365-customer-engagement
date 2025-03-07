---
title: Set up Sales territories
description: Define sales territories to organize customer and market segments, assign salespeople, and simplify business analysis.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: how-to
ms.collection: get-started
ms.date: 09/13/2023
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-territory
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/06/2023
---
# Set up sales territories

Improve sales potential and revenues by creating territories for customer and market segments in Dynamics 365 Sales. Then assign appropriate salespeople to handle the sales and revenue opportunities for those territories.  
  
Sales territories improve the sales potential because the members of a territory are focused on the sales within that territory. You can associate the financials directly with a territory and its members, which simplifies business analysis. Also, based on the sales territory type and size, you can define sales methodologies and the training required for those locations.  

Organizations can create a model and visualize their sales territories in a hierarchical format using out-of-the-box territory hierarchical relationships.

> [!IMPORTANT]
> - For a new organization that provisions Dynamics 365 Sales, the territory hierarchical relationship will be available and enabled by default.
> - For existing customers upgrading to the latest release, if the organization doesn't already have a hierarchical relationship created for the Territory table, the hierarchical relationship will be available and enabled. If the organization has a hierarchical relationship created for territory, the new out-of-the-box territory hierarchical relationship will be available but not enabled.

## Create a sales territory

Create a sales territory to define a geographical area for your business. For example, you can create a sales territory for a city, state, or country/region. You can also create a sales territory for a specific industry or product line.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **App settings**.

1. Under **Sales Administration**, select **Sales Territories**.

   :::image type="content" source="media/sales-territories.png" alt-text="Screenshot of the Sales Territories menu in App settings along with the list of territories.":::
1. Select **New** on the command bar.

4. In the sales territory form, fill in your information.

   a. **Name**. Enter the geographical name for the territory such as the name of a city, country/region, or state.

   b. **Manager**. Select the user who manages the territory. This person would typically assign leads to salespeople.

    > [!Important]
    > You can't allocate the same user to multiple territories. If you need to assign a user to a larger area (more than one existing territory), create a new territory that includes the existing territories, and then assign the user to that new territory.
  
   c.  **Parent**. Select a parent territory. The current territory will be added as a child territory to the selected territory. For example, If you are creating sales territories for California and Washington, you can add the United States of America as a parent so that a parent-child relationship is created between the sales territories and the parent territory.  

   d. **Description**. Enter any details that you'd like to include for this territory, for example, "Sales territory created for education and training."

5. Save the changes.

## Add members to a territory

Add salespeople as members of a territory to assign them the sales and revenue opportunities for that territory.  

1. Open the territory record that you want to add members to.

2. Select the **Related** tab, and then select **Members**.

3. On the **Members** tab, select **Add members**.

4. In the **Lookup Records** pane, search and select users who are members of this territory, and then select **Add**.

5. To add sub-territories to this territory, select the **Sub-territories** tab, and select **Add New Territory**.  

6. Enter the necessary information and select **Save**. This territory will be added as a sub-territory in the Sub-territories grid.

7. Select **Save**. 

> [!TIP]
>  To make your salesperson's job easier, you can also set a default price list for a territory. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Define product pricing with price lists and price list items](create-price-lists-price-list-items-define-pricing-products.md)  
  
## Related information  

[Configure forecasts in your organization](configure-forecast.md)  
[Define and track your sales goals](goals-overview.md)  




[!INCLUDE[footer-include](../includes/footer-banner.md)]
