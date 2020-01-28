---
title: "Work with opportunities in the Kanban view (Dynamics 365 Sales) | MicrosoftDocs"
description: "Use the opportunity Kanban view to effectively monitor pipeline and see the opportunities in their different statuses or stages of business process flow."
ms.date: 02/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Work with opportunities in the Kanban view

Use the Kanban view to effectively keep tabs on the sales pipeline. 
The Kanban view shows opportunities as cards. The lanes in the Kanban view represent the default statuses or stages of opportunities. The opportunity cards within the swim lanes show where in the process the opportunities are. 
You can drag the opportunities to different lanes to move them from one status/stage to another.

## Open a Kanban view

A Kanban view is available when your system customizer has added the Kanban control to the Opportunity entity. If you don't see the Kanban view, talk to your system customizer.

To open the Kanban view:

1. In the site map, select **Opportunities**.
2. On the command bar, select the **More commands** icon ![More commands icon](media/more-commands-button.png "More commands icon"), and select **Show As** > **Kanban**.

    > [!div class="mx-imgBorder"]  
    > ![More commands icon on the opportunity grid](media/opportunity-grid-more-commands-icon.png "More commands icon on the opportunity grid") 

## Available Kanban views for opportunity records

The following two types of Kanban views available for opportunities:

- Based on the business process flow stage
- Based on the Opportunity status

You can switch between the views by selecting the Kanban type from the Kanban type drop-down list.

> [!div class="mx-imgBorder"]  
> ![Kanban type list](media/kanban-type-list-kanban-view.png "Kanban type list")
 
In the status-based Kanban view, each lane represents a default opportunity status such as, Open, Won, or Lost.

> [!div class="mx-imgBorder"]  
> ![Status-based opportunity Kanban view](media/status-based-opportunity-kanban-view.png "Status-based opportunity Kanban view")
 
In the Business process flow-based view, swim lanes represent the following stages of opportunities in the Opportunity sales process business process flow:

- Qualify
- Develop
- Propose
- Won

Currently, the Kanban view is only available for the Opportunity sales process business process flow.

> [!div class="mx-imgBorder"]  
> ![Business process flow-based opportunity Kanban view](media/bpf-based-kanban-view.png "Business process flow-based opportunity Kanban view")
 
## Know your Kanban views

Here are some important things to know about your Kanban view:
-  At the top of each lane, the total estimated revenue for the opportunities in that lane is shown. 

    > [!div class="mx-imgBorder"]  
    > ![Sum of estimated revenue](media/total-estimated-revenue.png "Sum of estimated revenue")

    It also shows a count of opportunity cards in that lane. At any given point, only the first 10 records/cards will be shown in any lane. If there are more than 10 opportunity cards in a lane, for example, 50, the count shows 10/50. To see more cards, scroll down in the lane. When you scroll down, the count changes to show 20/50, and so on.

-  Selecting the card title opens the opportunity record/form.

-  The card fields are editable. You can quickly change details for the three fields of an opportunity record that are shown in the card.

    > [!div class="mx-imgBorder"]  
    > ![Editable fields on the opportunity card](media/editable-fields-opportunity-card.png "Editable fields on the opportunity card")

-  When you select a different view, cards in the lanes are filtered based on the selected view. 

-  You can use the **Search** box to filter the records/cards in the swim lane based on the search criteria.

-  You can drag a card and move it to other lanes. When you drag a card from one lane to another, the opportunity status or the stage changes depending on which type of Kanban view you're using.  


### See also

[Add the Kanban control entity](add-kanban-control.md)  
[Create or edit opportunities](create-edit-opportunity-sales.md)  
