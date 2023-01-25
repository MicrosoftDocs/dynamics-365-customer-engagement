---
title: Change from list view to focused view
description: Change the general list view to focused view for contact, account, lead, and opportunity entities.
ms.date: 01/31/2023
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

# Change from list view to focused view

[!INCLUDE[cc-early-access](../includes/cc-early-access.md)]

The focused view allows you to view records and associated activities on one page, making it more efficient for you to stay focused on your tasks and by reducing the need to navigate between multiple screens. Also allows for better organization and prioritization of tasks.

>[!NOTE]
>The focused view is similar to the Sales accelerator workspace view. More information: [Prioritize your sales pipeline through the work list](prioritize-sales-pipeline-through-work-list.md)

Currently, focused view is available for Account, Contact, Lead, and Opportunity entities.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Open the grid in the focused view  

When you open the account, contact, lead, or opportunity in the application, the records are displayed in a tabular format with limited information such as the name and email of the record. To view more detailed information of a record, you open a specific record to access its detailed view such as, business process flow and activities timeline.

To change to the focused view:

1.	In the site map, select an entity (Account, Contact, Lead, or Opportunity).
2.	On the command bar, select **Focused view**.

>[!NOTE]
>The **Focused view** option will not be displayed if you select any record in the grid. 

The grid transforms into a work list view, which is a centralized location for accessing all records with activities that are due or pending. This view allows you to see all relevant information in one place, without having to navigate through multiple forms in the application. 

## Understand the focused view

Typically, the focused view can be categorized into the following three sections:

-	**Search, filter, sort, and switch view**: These options are displayed on the top of the work list item view.   
    You can search, filter, and sort the records that you want to view in the list to quickly identify only the customers that you want to work with.  
    
    >[!NOTE]
    >Filters and sort that are available in the control are similar to the list view. Currently, custom filers and sort are not supported. Also, the advanced filter queries are not supported.
    
    Also, you change from focused view to the grid view (list view).

-	**Records list**: The list of records is displayed in a card format. You can perform and complete the activities on these cards from the current date and from previous dates. Each card displays information such as, the name of the record, primary contact name, and next best action.   
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

