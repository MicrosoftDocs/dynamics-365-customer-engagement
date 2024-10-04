---
title: Ask Copilot about recent changes to your sales records
description: Learn how to ask Copilot in Dynamics 365 Sales questions to know what's new with your leads, opportunities, accounts, and records assigned to you.
ms.date: 09/20/2024
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
---

# Ask Copilot about recent changes to your sales records

Ask Copilot to update you on the latest changes to your sales records, get a list of records that were assigned to you, or list any changes to your accounts, leads, and opportunities. You can either use predefined prompts or ask questions in natural language. This article describes some of the predefined prompts you can use to ask Copilot questions. [Learn more about chatting with Copilot in natural language](use-sales-copilot.md#chat-with-copilot-in-NL).

## What's new with my sales records

Use this prompt to get a list of sales records that were recently updated.  

1. [Open Copilot](use-sales-copilot.md#open-copilot).
1. Select **View Prompts** above the Copilot chat box, select **Ask questions** > **What's new with my sales records**, and then select **Enter**.

    :::image type="content" source="media/whats-new-with-myrecords.png" alt-text="Screenshot of the Copilot response for What's new with my sales records.":::

Copilot fetches the list based on the following conditions:

- The records are of the following types: Account, Lead, and Opportunity.
- The records were updated in the last seven days.
- The records are owned by you. For account records, the records are owned by you or your team.
- The fields that were updated are [configured by your administrator](copilot-configure-summary-fields.md). If you've updated fields other than the configured fields, those records aren't listed in the response.
- If a record type has more than five records, Copilot picks the five most recently updated ones.

Hover over a record in the list and select **Get updates** to view all changes to the record in the last seven days.

## What's newly assigned to me

Copilot can help you stay on top of your pipeline by showing you a list of accounts, leads, and opportunities that were assigned to you in the last 15 days.

[Open Copilot](use-sales-copilot.md#open-copilot), select **View Prompts** above the Copilot chat box, select **Ask questions** > **What's newly assigned to me**, and select **Enter**.

## Get recent changes

Copilot can help you catch up on any updates to your account, lead, or opportunity records in the last seven days or since you last signed in.

1. [Open Copilot](use-sales-copilot.md#open-copilot).
1. Select **View Prompts** above the Copilot chat box, select **Ask questions** > **What's changed for *record type***, and select **Enter**.

    - When a record is opened, Copilot displays the list of recent changes to it.
    - When in grid view, Copilot lists the records for which you have read access. Hover over a record and select **Get updates**.
    
    > [!NOTE]
    > The **What's changed for *record type*** prompt is displayed only if your administrator has [turned on auditing](enable-setup-copilot.md#turn-copilot-features-on-or-off-in-sales-hub) and [granted you access to the audit history](copilot-configure-summary-fields.md#grant-audit-access-to-your-sellers).

1. To get the list of changes to a specific account, lead, or opportunity, type **/** and then start typing the name of the account, lead, or opportunity.

    :::image type="content" source="media/copilot-lead-catchup.png" alt-text="Screenshot of a lead catch up in the Copilot chat pane.":::

1. To learn more about the updated information or activity, select **Know more in audit history**.

### Would you like to view recent changes to different fields?

Copilot summarizes the last 10 updates to the record from the audit history, for the fields configured by your administrator. However, you might want to stay updated on changes to other fields that matter more to you. Work with your Dynamics 365 Sales administrator to [add those fields to the configuration](copilot-configure-summary-fields.md).

Keep in mind that these fields are set at the organization level. Make sure that your entire sales team agrees on the top 15 fields that are most relevant for your business.

## Related information

- [Copilot overview](copilot-overview.md)  
- [Copilot prompt guide reference](copilot-prompt-guide.md)  
- [Enable and set up Copilot](enable-setup-copilot.md)  
- [Chat with Copilot in natural language](use-sales-copilot.md#chat-with-copilot-in-NL)
- [Get answers from SharePoint documents](copilot-get-doc-suggestions.md#get-answers-from-sharepoint-documents)