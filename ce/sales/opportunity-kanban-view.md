---
title: Work with opportunities in the Kanban view
description: Use the opportunity Kanban view to effectively monitor the pipeline and see the opportunities in their different statuses or stages of business process flow.
ms.date: 12/9/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-opportunity
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Work with opportunities in the Kanban view 

Use the opportunity Kanban view to effectively monitor the pipeline and see the opportunities in their different statuses or stages of business process flow.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## What is a Kanban view? 

The Kanban view shows opportunities as cards. The lanes in the Kanban view represent the default statuses or business process flow stages of opportunities. The opportunity cards within the swim lanes show where in the process the opportunities are.  

You can drag the opportunities to different lanes to move them from one status or stage to another.

:::image type="Status-based opportunity Kanban view" source="media/status-based-opportunity-kanban-view.png" alt-text="Status-based opportunity Kanban view":::

> [!NOTE]
> The Kanban view is not supported in the mobile app.

## Open a Kanban view

A Kanban view is available when the Kanban control is added to the Opportunity entity. If you don't see the Kanban view, talk to your system customizer.

**To open the Kanban view:**

1. In the site map, select **Opportunities**.
2. On the command bar, select **Show As** > **Kanban**.

    :::image type="More commands icon on the opportunity grid" source="media/opportunity-grid-more-commands-icon.png" alt-text="More commands icon on the opportunity grid":::

## Available Kanban views for opportunity records

The following two types of Kanban views are available for opportunities:

- Based on the business process flow stage (default view).
- Based on the Opportunity status.

You can switch between the views by selecting the Kanban type from the Kanban type drop-down list.

:::image type="Kanban type list" source="media/kanban-type-list-kanban-view.png" alt-text="Kanban type list":::

In the status-based Kanban view, each swim lane represents a default opportunity status such as, Open, Won, or Lost.

:::image type="Status-based opportunity Kanban view" source="media/status-based-opportunity-kanban-view.png" alt-text="Status-based opportunity Kanban view":::
 
In the Business process flow-based view, swim lanes represent the stages of opportunities in the **Sales Process** business process flow. 

Currently, the Kanban view is only available for the **Sales Process** business process flow.

:::image type="Business process flow-based opportunity Kanban view" source="media/bpf-based-kanban-view.png" alt-text="Business process flow-based opportunity Kanban view":::


> [!NOTE]
> If your system administrator or customizer has customized the **Sales Process** business process, such as changing the stages in the business process flow, the changes are reflected in the business process flow-based opportunity Kanban view. 
 
## Know your Kanban views

Here are some important things to know about your Kanban view:
-  At the top of each lane, the total estimated revenue for the opportunities in that lane is shown. 

    :::image type="Sum of estimated revenue" source="media/total-estimated-revenue.png" alt-text="Sum of estimated revenue":::

    It also shows a count of opportunity cards in that lane. At any given point, only the first 10 records or cards will be shown in any lane. If there are more than 10 opportunity cards in a lane—for example, 50—the count shows 10/50. To see more cards, scroll down in the lane. When you scroll down, the count changes to show 20/50, and so on.
    
    > [!NOTE]
    > Aggregation of more than 50,000 records is not supported in a single swim lane. If there are more than 50,000 records, the aggregated estimated revenue is shown as blank and the total number of records are shown as 50000+. 


-  Selecting the card title opens the opportunity Main form. The Main form also opens when you move cards across business process flow stages. When you close the Main form, the whole Kanban view is refreshed.

-  The card fields are editable inline. You can quickly change details for the three fields of an opportunity record right from the card.

    :::image type="Editable fields on the opportunity card" source="media/editable-fields-opportunity-card.png" alt-text="Editable fields on the opportunity card":::

-  When you select a different view, cards in the lanes are filtered based on the selected view. 

-  You can use the **Search** box to filter the records or cards in the swim lane based on the search criteria. For example, if you enter the keyword "Interested," it will refresh the Kanban view to only show the opportunity records where the title begins with "Interested".

    :::image type="Use the Search box to filter records in the Kanban view" source="media/search-in-kanban.png" alt-text="Use the Search box to filter records in the Kanban view":::

-  You can drag a card and move it to other lanes. 

    **In the Status-based Kanban view:**

    - Moving a card to other lanes in the Status-based Kanban view opens the Opportunity status change dialog box, even if you've configured a customized opportunity close form.
    
      :::image type="Close opportunity" source="media/close-opportunity-in-kanban-view.png" alt-text="Close opportunity":::
        
    - You can drag an opportunity card from the Open pane to the Won or Close lanes. 
    
    - When you move the card to the Won or Lost lanes, the opportunity record is closed. A lock icon is shown on the card, which means that the card (opportunity record) is inactive—you can't edit the fields on the card.
    
    - You can still reopen a closed opportunity (a locked card) by moving the card from the Won or Lost lanes to the Open lane. 
    
    - When you're dragging a card to move to another lane, the lanes where the card can't be dropped appear dimmed.

    **In the Business process flow-based view:**
    
    - Moving a card to other lanes in the Business process flow-based Kanban view opens the main Opportunity form with the business process flow pop-up window.

      :::image type="Main Opportunity form" source="media/main-opportunity-form.png" alt-text="Main Opportunity form":::

    - You can move the card from the current lane to the consecutive next or previous lane. Swim lanes where the card can't be dropped appear dimmed.

    - When you're dragging a card to move to another lane, the lanes where the card can't be dropped appear dimmed.
    
    - For all closed opportunities a lock icon is shown. The lock icon means that you can't change the information on the card inline, but you can still move the cards from one lane to another.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Add the Kanban control to Opportunity or Activity entities](add-kanban-control.md)  
[Create or edit opportunities](create-edit-opportunity-sales.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
