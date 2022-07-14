---
title: Customize the appearance of work items in sales accelerator
description: Customize the appearance of work items to show more relevant information in the work list in sales accelerator.
ms.date: 07/19/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---
<!-- 
NOTE re: "cards": I noticed that items in the work list aren't called "cards" anywhere else in this doc set. They're just "work items." The settings page itself is called "Work item appearance." I removed references to "cards" in this article.
NOTE re: screenshots: I tweaked the screenshots in this article to use red boxes, not orange. I noticed that other articles in this doc also set use orange boxes. The Microsoft Style Guide directs us to use red callouts.
NOTE: I think this article could be part of the personalize-sales-accelerator.md article. It's dealing with the same settings, just at a personal level. Or if you do keep it separate (which is fine), please include a link to this article in that one.
-->

# Customize the appearance of work items

The work list in sales accelerator helps sellers prioritize their time and effort. Customize work items to display the most relevant and important information in the work list. You can customize work items for each entity type your sellers work with.

[!INCLUDE[cc-early-access](../includes/cc-early-access.md)]

## License and role requirements

| Requirement type | You must have |  
| --- | --- |
| **License** | Dynamics 365 Sales Premium, Microsoft Relationship Sales, or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any [primary sales role](security-roles-for-sales.md#primary-sales-roles), such as salesperson or sales manager |

If you're an administrator, you can customize work items for yourself and for your organization. You can also allow sellers to override your customizations.

If you have a primary sales role, you can customize work items for yourself. Your customizations don't affect what other sellers see in their work list.

## Customize work items

1. Sign in to the Dynamics 365 Sales Hub app, and go to **Change area** > **Sales**.

1. In the left pane, under **My Work**, select **Sales accelerator**.

1. On the work list page, select **More options** > **Settings**.

    :::image type="content" source="media/sa-personal-settings-select-settings-icon-worklist.png" alt-text="Screenshot of the More options, Settings, menu in sales accelerator.":::

1. On the **Settings** page, select **Work item appearance**.

    :::image type="content" source="media/worklist-customize-select-work-item-appearance.png" alt-text="Screenshot of the Work item appearance settings page.":::

1. In the **Select record type** list, select the record type for which you're customizing work items.

1. Turn on **Switch to admin mode** to allow changes. With this setting off, work items can't be customized.

    Turning on admin mode reveals another setting, **Lock customization**. To prevent sellers from overriding your customizations, select this setting. To allow sellers to make further changes to work items, clear it.

    :::image type="content" source="media/worklist-customize-enable-admin-mode.png" alt-text="Screenshot of the Work item appearance settings page, with Switch to admin mode and Lock customization highlighted.":::

1. Use the options under **Customize** to [change the icon and content of work items](#customize-work-item-icon-and-content).

1. Select **Save**.

### Customize work item icon and content

To change the icon that appears on a work item, select the pencil icon, and then choose one of the following options:

- **Record image**: A photo of the contact, if one is available
- **Record initials**: The contact’s first and last initials
- **Record type**: The icon associated with the record type
- **Activity type**: The icon associated with the current activity on the record

    :::image type="content" source="media/worklist-customize-select-icon-appearance.png" alt-text="Screenshot of the options for customizing a work item icon.":::

To change the content of work items, select the fields or attributes to display:

- To change an existing attribute, select a different one in its place.

- To add an attribute in the same row, hover over an existing attribute and select **More options** > **Add a field**. You can show up to three fields in a row.

- To add an icon in the same row, hover over an existing attribute and select **More options** > **Add an icon**. You can show up to three icons in a row.

- To add a row, select the add icon (**+**). You can show up to four rows of information in a work item.

- To change the action that's displayed when the work item's **More options** icon is selected, select the pencil-and-gear icon and then choose one or more actions.

    :::image type="content" source="media/worklist-customize-choose-actions.png" alt-text="Screenshot of work item action icons to display.":::

- To delete a field or an icon, hover over it and select **More options** > **Remove**.

To remove all customizations and restore work items to their original appearance, select **Reset to default**.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Prioritize your sales pipeline by using the work list](prioritize-sales-pipeline-through-work-list.md)
