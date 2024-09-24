---
title: Stay ahead with Copilot
description: Learn how to prepare for upcoming meetings and catch up on emails with Copilot in Dynamics 365 Sales.
ms.date: 04/26/2024
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

# Stay ahead with Copilot

Stay ahead of your work by asking Copilot to help you prepare for meetings and catch up on emails that need your attention. You can either use predefined prompts or ask questions in natural language. This article describes some of the predefined prompts you can use to stay ahead with Copilot. [Learn more about chatting with Copilot in natural language](use-sales-copilot.md#chat-with-copilot-in-NL).

## Prepare for upcoming sales appointments

If you have meetings scheduled on your Outlook calendar in the next seven days, Copilot can help you prepare for them.  

>[!NOTE]
>Currently, meeting preparation is available only for opportunities.

1. [Open Copilot](use-sales-copilot.md#open-copilot).

1. Select **Stay ahead** > **Prepare for sales appointments**.  

    Copilot lists the meetings scheduled for the current day and the next seven days from the records that you have access to. The meetings listed here have an external participant whose email address is linked to a contact in Dynamics 365, and this email address must be associated with an opportunity.

    >[!NOTE]
    >- Copilot uses your Outlook to gather data from your sales contacts (external) and shows upcoming meetings and schedules. If you haven't provided access for Copilot to use your Outlook, you'll see a prompt requesting this access. Proceed to grant the access.
    >- If you don't want Copilot to access your Outlook calendar, select the information icon in the meetings section and select **Change preferences**. In the **Disconnect Copilot and Outlook?** dialog box, select **Disconnect**.

1. From the list of sales appointments, hover over the meeting that you'd like to prepare for and select **Prepare**.  
    A list of meeting insights are displayed. The first point of the meeting insights always shows the short summary of the opportunity.  
    Select **Source** corresponding to the insight to view the record from which the insight is created.  
    The insights are generated based on the following considerations for the opportunity:  
    - Notes added to the timeline.
    - All open tasks.
    - Any related open opportunity and cases of the associated account.  

    :::image type="content" source="media/copilot-prepare-for-meetings.svg" alt-text="Screenshot of Copilot's notes for an upcoming meeting.":::

1. (Optional) To view the meeting in Outlook, select **Open Meeting**. 15 minutes before the start time, the option changes to join teams meeting. You can join the meeting directly by selecting this option.  

## Display unanswered emails

Copilot can help make sure that you don't miss important emails by reminding you of messages that need a reply.

1. [Open Copilot](use-sales-copilot.md#open-copilot).
1. Select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Stay ahead** >  **Show emails that need follow up**.

    - If you have a record open, Copilot lists unanswered emails related to the record.
    - If you're in the grid view, Copilot lists all your unanswered emails.

To be included in the list, emails must meet the following criteria:

- They are in your mailbox, unanswered, for the past three to seven days. Emails that are unanswered for longer than seven days fall off the list.
- They contain a buying intent, a question, a query, or an action item.
- They have the **Regarding** field as a lead or an opportunity.

:::image type="content" source="media/copilot-email-reminder.png" alt-text="Screenshot of a list of unanswered emails in the Copilot chat pane.":::

## Related information

- [Copilot overview](copilot-overview.md)
- [Copilot prompt guide reference](copilot-prompt-guide.md)
- [Enable and set up Copilot](enable-setup-copilot.md)
- [Chat with Copilot in natural language](use-sales-copilot.md#chat-with-copilot-in-NL)
