---
title: Customize the appearance of work items in sales accelerator
description: Customize the appearance of work items to show more relevant information in the work list in sales accelerator.
ms.date: 08/18/2023
author: udaykirang
ms.author: udag
ms.topic: how-to 
ms.collection: 
ms.custom: bap-template 
---

# Customize the appearance of work items

The work list in sales accelerator helps sellers prioritize their time and effort. Customize work items to display the most relevant and important information in the work list. You can customize work items for each entity type that you or your sellers work with.

[!INCLUDE[cc-early-access](../includes/cc-early-access.md)]

## License and role requirements

| Requirement type | You must have |  
| --- | --- |
| **License** | Dynamics 365 Sales Premium, Microsoft Relationship Sales, or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Administrator or any [primary sales role](security-roles-for-sales.md#primary-sales-roles), such as salesperson or sales manager |

If you have an **administrator** role, you can do the following tasks.
- Enable customizations. More information: [Turn on customizations](#turn-on-customizations)
- Allow sellers to override your customizations. More information: [Lock or unlock customization for other user roles](#lock-or-unlock-customization-for-other-user-roles)
- Customize work items for your organization. More information: [Customize work items](#customize-work-items) 

If you have a **primary sales role** and if your admin has turned on the ability to customize work items, you can customize them for yourself only. Your customizations don't affect what other sellers see in their work list. More information: [Customize work items](#customize-work-items)

## Turn on customizations

As an administrator, you must turn on the ability to customize work items. Unless you turn on, nobody (including you) can customize the work item in your organization.  

1. Sign in to the Dynamics 365 Sales Hub app, and go to **Change area** > **Sales**.

1. In the left pane, under **My Work**, select **Sales accelerator**.

1. On the work list page, select **More options** > **Settings**.

    :::image type="content" source="media/sa-personal-settings-select-settings-icon-worklist.png" alt-text="Screenshot of the More options, Settings, menu in sales accelerator.":::

1. On the **Settings** page, select **Work item appearance**.

    :::image type="content" source="media/worklist-customize-select-work-item-appearance.png" alt-text="Screenshot of the Work item appearance settings page.":::

    If you don't see **Work item appearance** in the **Settings** list, it means your admin hasn't turned on work item customization. Follow these steps again when that's been done.

1. Turn on **Switch to admin mode** to allow work items to be customized. With this setting off, work items can't be changed by anyone, not even an administrator.

    Turning on admin mode reveals another setting, **Lock customization**. To prevent sellers from overriding your customizations, select this setting. To allow sellers to make their own changes to work items, clear it.

    :::image type="content" source="media/worklist-customize-enable-admin-mode.png" alt-text="Screenshot of the Work item appearance settings page, with Switch to admin mode and Lock customization highlighted.":::

The administrator mode is turned on. Now, you can customize the work item for your organization and also, let other user roles in your organization to customize the work item.

## Lock or unlock customization for other user roles

As an administrator, you can let other user roles to override the customizations you made to the work items according to their requirements.

Turn on the admin mode and the **Lock customization** settings is revealed. More information: [Turn on customizations](#turn-on-customizations)

:::image type="content" source="media/worklist-customize-lock-customization.png" alt-text="Screenshot of the Work item appearance settings page, with Lock customization highlighted.":::

For the **Lock customization** settings, choose one of the following options to configure: 

- To allow sellers to make their own changes to work items, clear it. 
- To prevent sellers from overriding your customizations, select this setting. 

## Customize work items

If you aren't an admin, you'll need to ask your admin to let you customize work item. More information: [Lock or unlock customization for other user roles](#lock-or-unlock-customization-for-other-user-roles)   

The procedure to customize work items is the same for both administrators and other primary sales roles.

1. Sign in to the Dynamics 365 Sales Hub app, and go to **Change area** > **Sales**.

1. In the left pane, under **My Work**, select **Sales accelerator**.

1. On the work list page, select **More options** > **Settings**.

    :::image type="content" source="media/sa-personal-settings-select-settings-icon-worklist.png" alt-text="Screenshot of the More options, Settings, menu in sales accelerator.":::

1. On the **Settings** page, select **Work item appearance**.

    :::image type="content" source="media/worklist-customize-select-work-item-appearance.png" alt-text="Screenshot of the Work item appearance settings page.":::

    >[!NOTE]
    >
    >- The **Switch to admin mode** and **Lock customization** options are available only for administrators.
    >- If you're not an administrator, you must ask your administrator to turn on admin mode before you can customize work items.

1. In the **Select record type** list, select the record type you're customizing work items for.

1. Under the **Customize** section, use the following options to customize:
          
    - To change the icon that appears on a work item, select the pencil icon, and then choose one of the following options:
        - **Record image**: A photo of the contact, if one is available
        - **Record initials**: The contact’s first and last initials
        - **Record type**: The icon associated with the record type
        - **Activity type**: The icon associated with the current activity on the record
        
        :::image type="content" source="media/worklist-customize-select-icon-appearance.png" alt-text="Screenshot of the options for customizing a work item icon.":::

    - To change the content of work items, select the fields or attributes to display:    
        - To change an existing attribute, select a different one in its place.
        - To add an attribute in the same row, hover over an existing attribute and select **More options** > **Add a field**. You can show up to three fields in a row.
        - To add an icon in the same row, hover over an existing attribute and select **More options** > **Add an icon**. You can show up to three icons in a row.
        - To add a row, select the add icon (**+**). You can show up to four rows of information in a work item.
        - To change the action that's displayed when the work item's **More options** icon is selected, select the pencil-and-gear icon and then choose one or more actions.
        
        :::image type="content" source="media/worklist-customize-choose-actions.png" alt-text="Screenshot of work item action icons to display.":::

        - To delete a field or an icon, hover over it and select **More options** > **Remove**.

    - To remove all customizations and restore work items to their original appearance, select **Reset to default**.

1. Select **Save**.

## Default work item appearance

By default the work item appearance is set to the following values:

| Entity name | default values |
|-------------|----------------|
| Accounts | Row 1: Account name and follow indicator <br> Row 2: Primary contact full name and job title <br> Row 3: Up next activity |
| Contacts | Row 1: Full name and follow indicator <br> Row 2: Job title and company name <br> Row 3: Up next activity |
| Leads | Row 1: Name, follow indicator, and predictive score <br> Row 2: Job title and company name <br> Row 3: Up next activity |
| Opportunities | Row 1: Contact full name, follow indicator, and predictive score <br> Row 2: Contact Job title and company name <br> Row 3: Topic and estimated revenue <br> Row 4: Up next activity |

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Prioritize your sales pipeline by using the work list](prioritize-sales-pipeline-through-work-list.md)
