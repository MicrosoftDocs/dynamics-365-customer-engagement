---
title: Control which hierarchies are used for specific records
description: Learn how to use views and relationships so each type of account record opens only in the visual hierarchy designed for it.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: how-to
ms.date: 10/19/2026
ai-usage: ai-assisted
---

# Control which hierarchies are used for specific records

In this article, we show how different types of account records can each have their own specialized hierarchy view that's tailored to best display that specific account. While this article details a specific scenario for crafting visual hierarchies, you can leverage the approach to solve a variety of business requirements.

## Example scenario

An organization has four types of account records:  

- **Global accounts** are top-level accounts for major multinational organizations.
- **Agency accounts** (which work on behalf of a business) and **Corporate accounts** (which represent a business) might or might not have a parent Global account.
- Agency and Corporate accounts can have one or more child **Home office** accounts.
- Home office accounts can have one or more child **Branch office** accounts.

## Common issues with multiple hierarchies

When different sets of records have different structures or display requirements, you might run into the following issues:

- A record that doesn't have an expected parent or grandparent in a hierarchy can cause an error.
- If you have multiple hierarchies, a record might open in a hierarchy that you didn't design for it.
- Users might switch to another hierarchy that isn't intended for the record, and the result might not display correctly.

## Solution overview

Use views and relationships so that each record can open only in a hierarchy that supports it. The example account structure creates four distinct display paths:

1. Global account > Agency account > Home office > Branch office
1. Global account > Corporate account > Home office > Branch office
1. Agency account (no Global account) > Home office > Branch office
1. Corporate account (no Global account) > Home office > Branch office

The following screenshot illustrates the example account structure.

:::image type="content" source="media/example-hv-account-structure.png" alt-text="Screenshot of the hierarchy structure for different account types.":::

> [!NOTE]
> When you open or select a record and then select **View hierarchy**, visual hierarchies check levels 1, 2, and 3 of each published hierarchy to determine which hierarchies can display the record. If a hierarchy's view filters exclude the record, that hierarchy isn't available for the record. Use these filters to control which hierarchies are available for specific records.
  
## Prerequisites

- A column on the **Account** table that identifies each account type. This example uses a custom choice column named **Account Type**. You can use any column that lets you filter a view by account type.
- Permission to create views in Power Apps and to design and publish visual hierarchies. Learn more in [Design and publish hierarchies](create-activate-hierarchy-visualizations.md).

## Step 1: Create a view for Global accounts

Create a view that includes only Global accounts by filtering on the **Account Type** column. This article refers to it as the *Global accounts* view.

Learn how to create views in [Create or edit a model-driven app view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view).

## Step 2: Create views for Agency and Corporate accounts

Create four views to separate Agency and Corporate accounts that have a parent Global account from those that don't:

| View name | Account Type filter | Parent Account filter |
|---|---|---|
| Agency account with parent | Agency | **Contains data** |
| Agency account no parent | Agency | **Does not contain data** |
| Corporate account with parent | Corporate | **Contains data** |
| Corporate account no parent | Corporate | **Does not contain data** |

**To create each view**:

1. Sign in to [Power Apps](https://make.powerapps.com) and open the **Account** table.
2. Select **Views** > **New view**.
3. Add a filter on the **Account Type** column for the Agency or Corporate value.
4. Add a filter on the **Parent Account** column for **Contains data** or **Does not contain data**, as shown in the preceding table.
5. Save and publish the view.

## Step 3: Create views for Home office and Branch office accounts

Similar to [step 1](#step-1-create-a-view-for-global-accounts), create two views: one that includes only Home office accounts and one that includes only Branch office accounts. Filter each view on the **Account Type** column.

## Step 4: Connect each account to its immediate parent

This example uses the standard **Parent Account** lookup column (`parentaccountid`) and its relationship (`account_parent_account`) to define the parent-child relationship between records. Set the **Parent Account** value for each account as follows:

| Account | Parent Account value |
|---|---|
| Agency or Corporate account | The Global account, or empty if the account doesn't have a Global account |
| Home office account | Its Agency or Corporate account |
| Branch office account | Its Home office account |

## Step 5: Configure and publish the four hierarchies

In the hierarchy designer, create four hierarchies. Each hierarchy uses the views and relationships that match one display path.

- **Hierarchies with a Global account root node**: Start the Agency (with parent) and Corporate (with parent) hierarchies with a Global account node. Then add an Agency or Corporate node that uses the view that includes only accounts with a parent Global account.
- **Hierarchies without a Global account root node**: Start with the Agency or Corporate node, and use the view that includes only accounts without a parent.

For each hierarchy, add the Home office and Branch office nodes by using the views from step 3.

Keep the following points in mind:

- The **relationship** determines which records are children of the displayed parent. The **view** limits which of those related records appear in a node. Both must match your data.
- Don't turn on **Expand all levels**. This solution uses explicit nodes so you control exactly what appears at each level. **Expand all levels** follows a relationship recursively and displays all children, their children, and so on, as far as the relationship extends. That option works best when every node represents the same type of record, such as people in an organization chart.

> [!NOTE]
> To find a hierarchy for a selected record, visual hierarchies search the first and second configuration levels. This design places Agency and Corporate accounts at the second level when they have a parent Global account, and at the first level when they don't. Don't assume that records at deeper levels can use the same entry point.

Before you publish:

1. Preview each hierarchy and check that its views and relationships return the expected records.
2. Review other published Account hierarchies for overlapping views. Update their scope, or move obsolete configurations to **Draft**, so they don't also match these accounts.

The following screenshot illustrates how a corporate account with a global parent successfully opens in the hierarchy designed for that scenario.  
:::image type="content" source="media/published-hierarchy.png" alt-text="Screenshot of the published hierarchy.":::

## Verify the hierarchies

After you publish the hierarchies:

1. Open an Agency or Corporate account from each of the four display paths.
2. Select **View hierarchy**.
3. Check that the account opens in its intended hierarchy, with Home office accounts below it and Branch office accounts below their Home office accounts.
4. Check that the hierarchy switcher shows only one hierarchy for the record.

## Limitations

You can open a visual hierarchy only from a record at level 1, 2, or 3. You can create hierarchies with more levels, but the **View hierarchy** button checks only the first three levels for the selected record. If the record is at level 4 or deeper, you can't open the hierarchy from that record.

For example, a Branch office account under a Global account is at level 4. If you try to open the hierarchy from that record, an error states that no hierarchy can be found for it. This behavior is by design because each level affects performance. To support these records, create a dedicated hierarchy that opens them at level 1, 2, or 3.

## Related information

- [Overview of visual hierarchies](/dynamics365/sales/hierarchy-visualization)
- [Design and publish hierarchies](/dynamics365/sales/create-activate-hierarchy-visualizations)
- [View and use a visual hierarchy](/dynamics365/sales/view-hierarchy-visualizations)
- [Create or edit a model-driven app view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view)
