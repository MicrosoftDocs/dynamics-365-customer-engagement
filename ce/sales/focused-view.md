---
title: View and manage records in focused view
description: Change the general list view to focused view for contact, account, lead, and opportunity entities in Dynamics 365 Sales.
ms.date: 05/05/2023
ms.topic: conceptual
author: udaykirang
ms.author: udag
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-sales
  - bap-template
---

# View and manage records in focused view

The focused view allows you to view and manage account, contact, lead, and opportunity records and their associated activities on one page. This view makes it easier for you to stay focused on your tasks and reduces the need to navigate between multiple screens. It also allows you to better organize and prioritize your tasks.

> [!NOTE]
> Focused view is now available for all entities, including custom entities. However, your administrator must enable it for you to access it. More information: [Set focused view as the default view](set-focused-view-as-default.md)

The focused view is similar to the Sales accelerator workspace view. [Learn how to prioritize your sales pipeline through the work list](prioritize-sales-pipeline-through-work-list.md).

You can't customize how work items are shown in the focused view. You can customize the appearance of work items in sales accelerator, however. Work items are displayed in the focused view according to that customization. [Learn how to customize work items](customize-work-list-card.md#customize-work-items).

>[!IMPORTANT]
> To set focused view as default, contact your administrator. More information: [Set focused view as the default view](set-focused-view-as-default.md)  

## Open the focused view  

The focused view is a centralized place to view all your open records that have activities that are due or pending, without having to navigate through multiple screens.

1. In the site map, select an entity and do one of the following actions depending the entity:
    - For Account, Contact, Lead, and Opportunity entities, select **Focused view** on the command bar.
    - For all other entities, the focused view can be accessed using one of the following options, depending on how your administrator has configured it:
        - Select **Focused view** on the command bar.
        - Select **Show as** > **Focused view** on the command bar.
    > [!NOTE]
    > Focused view is not available for the Activities entity.

>[!NOTE]
>The **Focused view** option isn't displayed if a record is selected.

## Understand the focused view

The focused view consists of three sections.

-	**Search, filter, sort, and switch view**: These options are displayed at the top of the work list item view.   
    You can search, filter, and sort the records that you want to view in the list to quickly identify only the records that you want to work with. You can also switch between the focused view and the list view. 
    
    Filters and sorting that are available here are similar to the list view. Custom filters and sorting and advanced filter queries aren't supported.

-	**Records list**: All records, including records with no associated activities, for the selected entity are displayed in a card format. You can perform and complete the activities, whether manual or automated, on these cards from the current date and from previous dates. Each card displays information such as the name of the record, the primary contact name, and the next best action.

    Next best actions include the top two activities with the latest due date. To complete the next best action, hover over the action and then select the action icon.

    When no action items are available for the record, the record displays information such as the name and contact details.

    When predictive scoring is enabled in your organization, the list also displays the score for that lead or opportunity at the top-right corner of the card. [Learn more about prioritizing leads through scores](work-predictive-lead-scoring.md) and [prioritizing opportunities through scores](work-predictive-opportunity-scoring.md).

-	**Record details**: Select a record in the work list to open a detailed view of the record on the same page.  

The following image is an example of the focused view for the Lead entity:

:::image type="content" source="media/focused-view-lead-entity.png" alt-text="Screenshot of the focused view of the Lead entity.":::

### See also

[Set focused view as the default view](set-focused-view-as-default.md)  
[Prioritize your sales pipeline through the work list](prioritize-sales-pipeline-through-work-list.md)   
[Work with opportunities in the Kanban view](opportunity-kanban-view.md)   
[Customize work items](customize-work-list-card.md#customize-work-items)   
[Focused view FAQs](faq-sales.yml#focused-view)
