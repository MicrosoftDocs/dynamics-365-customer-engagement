---
title: View and manage records in focused view
description: Change the general list view to focused view for contact, account, lead, and opportunity entities.
ms.date: 02/03/2023
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-sales
---

# View and manage records in focused view

[!INCLUDE[cc-early-access](../includes/cc-early-access.md)]

The focused view allows you to view and manage records with their associated activities on one page. This view makes it more efficient for you to stay focused on your tasks and reduces the need to navigate between multiple screens. It, also allows for better organization and prioritization of tasks.

>[!NOTE]
>- The focused view is similar to the Sales accelerator workspace view. More information: [Prioritize your sales pipeline through the work list](prioritize-sales-pipeline-through-work-list.md)
>- You can't customize the work items in the focused view. However, if card customization is done in Sales accelerator, the work items are displayed according to the customization. More information: [Customize work items](customize-work-list-card.md#customize-work-items)

>[!IMPORTANT]
>Currently, focused view is available for Account, Contact, Lead, and Opportunity entities.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles) <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Open the focused view  

The focused view is a centralized location for accessing all your open records with activities that are due or pending. This view allows you to see all relevant information in one place, without having to navigate through multiple forms in the application. 

To change to the focused view:

1.	In the site map, select an entity (Account, Contact, Lead, or Opportunity).
2.	On the command bar, select **Focused view**.

>[!NOTE]
>The **Focused view** option will not be displayed if you select any record in the grid. 

## Understand the focused view

The focused view can be categorized into the following three sections:

-	**Search, filter, sort, and switch view**: These options are displayed on the top of the work list item view.   
    You can search, filter, and sort the records that you want to view in the list to quickly identify only the records that you want to work with.  
    
    >[!NOTE]
    >Filters and sort that are available in the control are similar to the list view. Currently, custom filters and sort are not supported. Also, the advanced filter queries are not supported.
    
    Also, you change from focused view to the list view (grid control).

-	**Records list**: All records (including records with no associated activities) for the selected entity are displayed in a card format. You can perform and complete the activities (manual and automated) on these cards from the current date and from previous dates. Each card displays information such as, the name of the record, primary contact name, and next best action.   
    The next best actions include the top two activities with latest due date. To complete the next best action, hover over the action and then select the action icon.   
    When no action items are available for the record, the record displays information such as the name and contact details.   
    When predictive scoring is enabled in your organization, the list also displays the score for that lead or opportunity on the top-right corner of the card. More information: [Prioritize leads through scores](work-predictive-lead-scoring.md) and [Prioritize opportunities through scores](work-predictive-opportunity-scoring.md)

-	**Record details**: When you select a record from the wok list, the record opens on the same page with a detailed view.  

The following image is an example of the focused view for the lead entity:

:::image type="content" source="media/focused-view-lead-entity.png" alt-text="Screenshot of focused view appearance for the lead entity.":::

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Prioritize your sales pipeline through the work list](prioritize-sales-pipeline-through-work-list.md)   
[Work with opportunities in the Kanban view](opportunity-kanban-view.md)   
[Customize work items](customize-work-list-card.md#customize-work-items)   
[Focused view FAQs](faq-sales.yml#forecasting)