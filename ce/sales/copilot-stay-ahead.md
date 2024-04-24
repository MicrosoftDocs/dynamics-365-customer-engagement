---
title: Stay ahead with Copilot
description: Learn how to prepare for upcoming meetings and catch up on emails with Copilot in Dynamics 365 Sales.
ms.date: 04/30/2024
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
---

# Stay ahead with Copilot

Stay ahead of your work by asking Copilot to help you prepare for meetings and catch up on emails that need your attention.

## Prepare for upcoming sales appointments

If you have meetings scheduled on your Outlook calendar in the next seven days, Copilot can help you prepare for them.  

>[!NOTE]
>Currently, meeting preparation is available only for opportunities.

1. [Open Copilot](use-sales-copilot.md#open-copilot).

    >[!NOTE]
    >You're prompted to grant access to your Outlook calendar the first time you open Copilot. Copilot uses this access to gather data from your sales contacts (external) from Outlook and shows upcoming meetings and schedules.

1. Under **Stay ahead**, select **Prepare for sales appointments**.  
    The Copilot lists the meetings scheduled for the current day and the upcoming seven days from the records you have access to.  

1. From the list of sales appointments, hover over the meeting that you'd like to prepare for and select **Prepare**.  
    A list of meeting insights are displayed in the chat pane. The insights are generated based on the [fields selected for generating summaries](enable-setup-copilot.md#configure-fields-for-generating-summaries-and-recent-changes-list).  
    Select **Source** corresponding to the insight to view the record from which the insight is created.  

    :::image type="content" source="media/copilot-prepare-for-meetings.svg" alt-text="Screenshot of Copilot's notes for an upcoming meeting.":::

1. (Optional) To view the meeting in Outlook, select **Open Meeting**. 15 minutes before the start time, the option changes to join teams meeting. You can join the meeting directly by selecting this option.  

1. (Optional) To provide feedback on the insights, select the Thumps Up or Down icon.

## Show emails you haven't replied to

Copilot can help make sure that you don't miss important emails by reminding you of any that you haven't replied to.

1. [Open Copilot](use-sales-copilot.md#open-copilot).
1. Select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Stay ahead** >  **Show emails that need follow up**.

    - If you have a record open, Copilot lists unanswered emails related to the record.
    - If you're in the grid view, Copilot lists all your unanswered emails.

To be included in the list, emails must meet the following criteria:

- They've been in your mailbox, unanswered, for the past three to seven days. Email that's been unanswered for longer than seven days falls off the list.
- They contain a buying intent, a question, a query, or an action item.
- They have the **Regarding** field as a lead or an opportunity.

:::image type="content" source="media/copilot-email-reminder.png" alt-text="Screenshot of a list of unanswered emails in the Copilot chat pane.":::

### See also

- [Copilot overview](copilot-overview.md)
- [Enable and set up Copilot](enable-setup-copilot.md)
