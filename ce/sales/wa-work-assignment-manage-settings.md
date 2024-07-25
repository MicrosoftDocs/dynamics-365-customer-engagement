---
title: Configure work assignment
description: Learn how to configure Dynamics 365 Sales to automatically assign work to your sales teams.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to
ms.collection:
ms.date: 05/20/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/19/2023
---

# Configure work assignment

Work assignment is a feature of Dynamics 365 Sales that removes the burden of manually assigning leads, opportunities, and other work to your sales team. Using assignment rules that can consider sellers' attributes, availability, and capacity, the sales accelerator automatically assigns the right salesperson at the right time to the right leads and opportunities.

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/), or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |

## Configure work assignment for your sales team

Configuring work assignment is simple:

1. [Select the security roles that assignment rules can automatically assign records to](./wa-manage-sales-teams.md).
1. [Create segments to group incoming leads and opportunities](./wa-create-and-activate-a-segment.md).
1. [Create sequences to automate the steps of your sales process](./create-and-activate-a-sequence.md).
1. [Connect segments to sequences](./wa-connect-a-segment-to-sequence.md).
1. [Set sellers' attributes and capacity](./wa-manage-seller-attributes.md).
1. [Determine how your sellers' availability is set and which calendar to use](./wa-manage-seller-availability.md).
1. [Create and activate assignment rules](./wa-create-and-activate-assignment-rule.md).

## Change work assignment settings

After you configure work assignment for your organization, you can make adjustments as needed:

- [Stop assigning work to sellers](#stop-assigning-work-to-sellers) who are on vacation or otherwise unavailable.
- [Change the priority of your assignment rules](wa-change-priority-assignment-rule.md).
- [Edit your assignment rules](wa-edit-assignment-rule.md) if you need to more extensive changes.
- [Delete or deactivate assignment rules](wa-delete-deactivate-assignment-rule.md) you no longer need.
- [Edit segments](wa-edit-a-segment.md) to fine-tune the records that get connected to them.
- [Delete or deactivate segments](wa-delete-deactivate-a-segment.md) that are no longer useful.

## Stop assigning work to sellers

While sellers are on vacation or are otherwise unavailable, you can stop new records from being assigned to them automatically. Turn assignment on the same way when they're back at work.

1. Sign in to your Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Work assignment**.

1. Select **Settings**.

1. (Optional) If the list of sellers is long, [use filters to focus on the ones you want](./wa-manage-seller-attributes.md#shortlist-sellers-using-search-and-advanced-filters).

1. Turn off the toggle in the **Assign records** column and confirm when you're prompted to do so.

## Add work assignment site map entry to custom app

>[!NOTE]
>Configure the Work assignment feature in your organization before you add the site map to your custom app.

When you create a custom model-driven app, you choose a default solution to create a site map for the app. However, the site map contains only entries that are based on entity forms. The work assignment option is based on URL custom control form and does not appear in the site maps. You must manually add the option to the site map. After you add these options, users in your organization can see them on the app’s sitemap. Use the following URLs to add the work assignment site map to your custom app and perform the steps in [add site map entry to custom app](add-custom-site-map.md):

| Feature name      | URL                                                                                         |
|-------------------|---------------------------------------------------------------------------------------------|
| Work assignment | `/main.aspx?pagetype=control&controlName=MscrmControls.SalesRouting.WorkAssignmentHostControl`|
| Work assignment settings | `/main.aspx?pagetype=control&controlName=MscrmControls.SalesRouting.WorkAssignmentHostControl&data={"isSettingsPageRequested":true}` |


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
