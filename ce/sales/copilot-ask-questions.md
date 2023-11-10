---
title: Ask questions to Copilot
description: Get up to speed with Copilot and quickly find out what's changed to your sales records, leads, opportunities, and accounts.
ms.date: 10/23/2023
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
search.app: salescopilot-docs
---

# Ask questions to Copilot

Ask Copilot to update you on the latest changes to your sales records, get a list of records that have been assigned to you, or list the changes to your leads and opportunities.

## What's new with my sales records

With Copilot, quickly get up to speed with all the updates to your sales records, such as leads, opportunities, and accounts. Copilot lists the records that have been updated in the last seven days.

In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Ask questions** > **What's new with my sales records** and press **Enter**. 

Copilot displays a quick summary of the records that you own, grouped by the type of record. 

:::image type="content" source="media/whats-new-with-myrecords.png" alt-text="Screenshot of the Copilot response for What's new with my sales records."::: 

## What's newly assigned to me

Copilot can help you stay on top your pipeline by getting you the list of leads and opportunities that have been assigned to you in the last 15 days.

In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Ask questions** > **What's newly assigned to me** and press **Enter**. 

## Get recent changes to a lead or opportunity

Copilot can help you catch up on any updates to your opportunity or lead records in the last seven days or since you last signed in.

The list of recent changes is taken from the audit history of the record. If you don't see the list of changes, ask your administrator to [turn on auditing](./enable-setup-copilot.md#configure-record-catch-up-fields) and [grant you access to the audit history](enable-setup-copilot.md#grant-audit-access-to-your-sellers).

1. In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Ask questions** > **What's changed for opportunity** or **What's changed for lead    ** and press **Enter**. One of the following happens:
    
    - - If you have a related record open, you'll see the list of recent changes to the record. For example, if you've opened an opportunity and selected **What's changed for opportunity**, you'll see the list of recent changes to the opportunity.
    
    - If you're in the grid view or the Copilot page, you'll see a list of records that you own. Hover over the record and select **Get updates** to get the list of recent changes to the record.  
    
    To get the list of changes for a specific lead or opportunity, type **/** and then start typing the name of the opportunity or lead.
    
    :::image type="content" source="media/copilot-lead-catchup.png" alt-text="Screenshot of a lead catch up in the Copilot chat pane.":::

1. To learn more about the updated information or activity, select **Know more in audit history**.

    :::image type="content" source="media/copilot-lead-catchup-audit-history.png" alt-text="Screenshot of a lead's audit history.":::

### Would you like to see the recent changes for a different set of fields?

Copilot summarizes the last 10 updates to the record from the audit history, based on the fields in the default opportunity or lead view. You may want to stay updated on changes to other columns that matter more to you, however. Your administrator can create a view that contains those columns and tell Copilot to [generate catch up information based on that view](./enable-setup-copilot.md#configure-record-catch-up-fields) instead.

Keep in mind that these fields are configured at the organization level. Make sure that your entire sales team agrees on the **top ten** fields that are most relevant for your business.

### See also

- [Copilot overview](copilot-overview.md)  
- [How Copilot responds when in context and out of context](use-copilot-new.md)