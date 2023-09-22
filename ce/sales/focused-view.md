---
title: View and manage records in focused view
description: Change the general list view to focused view for contact, account, lead, and opportunity entities in Dynamics 365 Sales.
ms.date: 09/15/2023
ms.topic: how-to
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
> Focused view is now available for all entities, including custom entities. However, your administrator must enable it for you to access it. More information: [Enable focused view and set it as the default view](set-focused-view-as-default.md)

The focused view is similar to the Sales accelerator workspace view. [Learn how to prioritize your sales pipeline through the work list](prioritize-sales-pipeline-through-work-list.md).

You can't customize how work items are shown in the focused view. You can customize the appearance of work items in sales accelerator, however. Work items are displayed in the focused view according to that customization. [Learn how to customize work items](customize-work-list-card.md#customize-work-items).

## Open the focused view  

The focused view is a centralized place to view all your open records that have activities that are due or pending, without having to navigate through multiple screens.

1. In the site map, select an entity and do one of the following actions depending on the entity:
    - For Account, Contact, Lead, and Opportunity entities, select **Focused view** on the command bar.
    - For all other entities, select **Show as** > **Focused view** on the command bar.

>[!NOTE]
>
>- The **Focused view** option isn't displayed if a record is selected.
>- Focused view is not available for the Activities entity.

## Understand the focused view

The focused view consists of three sections.

-	**Search, filter, sort, and switch view**: These options are displayed at the top of the work list item view.   
    You can search, filter, and sort the records that you want to view in the list to quickly identify only the records that you want to work with. You can also switch between the focused view and the list view.  

    Filters and sorting that are available here are similar to the list view. Also, you can add an advanced filter option to the available filters.  

    Create an advanced filter option using the expression builder to refine the content displayed in the work list. You can have only one advanced filter defined for an entity in focused view.  Select **Edit filters** to open the expression builder. In the expression builder, create the conditions as required and then select **Apply**. When the advanced filter is applied, you will observe the filter icon is filled with a blue color, and the advanced filter tag is displayed under the filter options. 

-	**Records list**: All records, including records with no associated activities, for the selected entity are displayed in a card format. You can perform and complete the activities, whether manual or automated, on these cards from the current date and from previous dates. Each card displays information such as the name of the record, the primary contact name, and the next best action.

    Next best actions, include the top two activities with the latest due date. To complete the next best action, hover over the action and then select the action icon.

    When no action items are available for the record, the record displays information such as the name and contact details.

    When predictive scoring is enabled in your organization, the list also displays the score for that lead or opportunity at the top-right corner of the card. [Learn more about prioritizing leads through scores](work-predictive-lead-scoring.md) and [prioritizing opportunities through scores](work-predictive-opportunity-scoring.md).

-	**Record details**: Select a record in the work list to open a detailed view of the record on the same page.  

The following image is an example of the focused view for the Lead entity:

:::image type="content" source="media/focused-view-lead-entity.png" alt-text="Screenshot of the focused view of the Lead entity.":::

## Customize the work list card

You can customize the work list card to display the information that you want to see. When sales acclerator is enabled, the customizations you make here are also reflected in the sales accelerator worklist itmes. More information: [Customize the appearance of work items in sales accelerator](customize-work-list-card.md)

The customization that you make to the work list card is specific to the entity type. For example, if you customize the work list card for the Lead entity, the customization is applied only to the Lead entity. The customization isn't applied to the Account, Contact, Opportunity, or other entities. These customizations also effects the sales accelerator workspace view. 

1. In the focused view page, on the work list pane, select **More options** and then select **Settings**.  

    :::image type="content" source="media/focused-view-select-settings-more-options.png" alt-text="Screenshot of the focused view to select settings through more options.":::  

1. In the **Settings** dialog box, select **Work item appearance**.

    :::image type="content" source="media/focused-view-customize-select-work-item-appearance.png" alt-text="Screenshot of the work item appearance settings page in focused view.":::

    The following are the considerations to keep in mind when customizing the work list card in focused view:  
    - The **Switch to admin mode** and **Lock customization** options are available only for administrators.
    - If the customization is disabled, contact your administrator to turn off the customization lock.
    - When admin mode is turned on, you can customize work items for all users within your organization. When turned off, you can customize work items only for yourself. If admin mode is turned off, contact your administrator to turn it on. More information: [Lock or unlock customization for other user roles](customize-work-list-card.md#lock-or-unlock-customization-for-other-user-roles)  
    - You can't customize the action items in the work list card. Also, in preview mode, the **More options** icon isn't visible to select action items that are configured in the sales accelerator workspace view.
1. Under the **Customize** section use the following options to customize:  
    - To change the icon that appears on a work item, select the pencil icon, and then choose one of the following options:
        - **Record image**: A photo of the contact, if one is available
        - **Record initials**: The contact’s first and last initials
        - **Record type**: The icon associated with the record type
        - **Activity type**: The icon associated with the current activity on the record  
    - To change the content of work items, select the fields or attributes to display:  
        - To change an existing attribute, select a different one in its place from the list.
        - To add an attribute in the same row, hover over an existing attribute and select **More options** > **Add a field**. You can show up to three fields in a row.
        - To add an icon in the same row, hover over an existing attribute and select **More options** > **Add an icon**. You can show up to three icons in a row.
        - To add a row, select the add icon (**+**). You can show up to four rows of information in a work item.
        - To delete a field or an icon, hover over it and select **More options** > **Remove**.
    - To remove all customizations and restore work items to their original appearance, select **Reset to default**.

    The **Preview** section displays a preview of the work list card based on the customizations that you make.

1. Select **Save**.

### See also

[Set focused view as the default view](set-focused-view-as-default.md)  
[Prioritize your sales pipeline through the work list](prioritize-sales-pipeline-through-work-list.md)   
[Work with opportunities in the Kanban view](opportunity-kanban-view.md)   
[Customize work items](customize-work-list-card.md#customize-work-items)   
[Focused view FAQs](faq-sales.yml#focused-view)
