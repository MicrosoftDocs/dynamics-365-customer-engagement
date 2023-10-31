---
title: Use Copilot in Dynamics 365 apps
description: Learn how to use Copilot to summarize your leads and opportunities records, catch up on updates, prepare for meetings, and enrich your leads with data from different sources.
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

# Use Copilot in Dynamics 365 apps

Copilot is an AI assistant that helps you be more productive and efficient in your daily work in Dynamics 365 apps. Copilot can summarize information about your leads and opportunities, help you catch up on updates and prepare for meetings, and enrich your leads with information from other sources.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Prerequisites

Your administrator must [turn on and configure Copilot](enable-setup-copilot.md).

## Open Copilot

From your Dynamics 365 app, select the Copilot icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) in the right navigation bar to open the Copilot pane.

## Chat with Copilot

In the Copilot pane, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) or place the cursor in the chat area to get the list of suggested requests or *prompts*, that Copilot can help you with. 

:::image type="content" source="media/sales-copilot-pane.png" alt-text="Screenshot of the Copilot pane along with the list of suggested requests":::

### Summarize an opportunity or a lead

1. In the Copilot chat pane, type **/** and select **Summarize opportunity** or **Summarize lead** from the **Suggested requests** list.

    You can also type the prompt.

1. Start typing the name of the opportunity or lead after the **@** symbol.

    If you type the prompt, follow it with **@**.

1. Select an opportunity or lead from the list of suggested records that match your search.

    :::image type="content" source="media/copilot-opportunity-summary.png" alt-text="Screenshot of a Copilot opportunity summary.":::

#### Would you like to see a different set of fields summarized?

Copilot generates the summary from the first seven fields in the default opportunity or lead view. Other fields may be more important to you, however. For example, estimated revenue, close date, contact, pipeline stage, and proposed solution may be the first things you look for in an opportunity. Your administrator can create a view that contains those fields and tell Copilot to [generate the summary based on that view](./enable-setup-copilot.md#configure-record-summary-fields) instead.

Keep in mind that the summary fields are configured at the organization level. Make sure that your entire sales team agrees on the **top seven** fields that are most relevant for your business.

### Enrich leads with related information

Copilot can enrich your leads with information from Dynamics 365 Sales, LinkedIn, and Bing, such as:

- Possible contacts, based on the lead name, phone number, email address, and company name.
- The latest news about the account, curated by Bing.
- Suggested LinkedIn profiles for the contact, if you have the LinkedIn Sales Navigator license.

After you select a lead, Copilot suggests other records that might be associated with the lead and from which it can glean more information.

1. [Ask Copilot to summarize a lead](#summarize-an-opportunity-or-a-lead).

    If Copilot finds possible matching records, it lists them after the summary.

1. Select **Connect** to connect the lead with a matching record.

    :::image type="content" source="media/copilot-lead-enrichment.png" alt-text="Screenshot of a lead card in the Copilot chat pane, with a matching account highlighted.":::

1. After Copilot connects the records, select **Get updated lead summary** to generate a new summary that includes information from the connected record.

### Catch up with an opportunity or lead

Copilot can help you catch up on any updates to your opportunity or lead records in the last seven days or since you last signed in.

The catch up information is taken from the audit history. If you don't see any catch up information, ask your administrator to [turn on auditing](./enable-setup-copilot.md#configure-record-catch-up-fields) and [grant you access to the audit history](enable-setup-copilot.md#grant-audit-access-to-your-sellers).

1. In the Copilot chat pane, type **/** and select **Catch up on opportunity** or **Catch up on lead** from the **Suggested requests** list.

    You can also type the prompt.

1. Start typing the name of the opportunity or lead after the **@** symbol.

    If you type the prompt, follow it with **@**.

1. Select an opportunity or lead from the list of suggested records that match your search.

    :::image type="content" source="media/copilot-lead-catchup.png" alt-text="Screenshot of a lead catch up in the Copilot chat pane.":::

1. To learn more about the updated information or activity, select **Know more in audit history**.

    :::image type="content" source="media/copilot-lead-catchup-audit-history.png" alt-text="Screenshot of a lead's audit history.":::

#### Would you like to define the fields that you want to catch up on?

Copilot summarizes the last 10 updates to the record from the audit history, based on the fields in the default opportunity or lead view. You may want to stay updated on changes to other columns that matter more to you, however. Your administrator can create a view that contains those columns and tell Copilot to [generate catch up information based on that view](./enable-setup-copilot.md#configure-record-catch-up-fields) instead.

Keep in mind that the catch up fields are configured at the organization level. Make sure that your entire sales team agrees on the **top ten** fields that are most relevant for your business.

### Prepare for upcoming meetings

If you have meetings scheduled on your calendar in the next 24 hours, Copilot can help you prepare for them. Go into your meetings with a helpful summary of notes recorded in the last three months and the most recent email thread on the timeline of the related record.

1. In the Copilot chat pane, type **/** and select the **Prepare for upcoming meetings** prompt.

1. Select the meeting that you'd like to prepare for.

    If you only have one meeting coming up in the next 24 hours, it's summarized automatically.

    :::image type="content" source="media/copilot-prepare-for-meetings.png" alt-text="Screenshot of Copilot's notes for an upcoming meeting.":::

### Show the latest news about an account

Copilot can get the latest news that features or mentions your accounts, curated from Bing. These news articles can be great conversation starters and help you understand the dynamics in your customers' organizations.

As always when you're working with AI-sourced content, read articles thoroughly to confirm that they're from authentic sources and are indeed about your customer.

1. In the Copilot chat pane, type **/** and select the **Show latest news for account** prompt.
  
1. Type the account name to view the latest news articles associated with that account. 


### Show emails you haven't replied to

Copilot can help you make sure you don't miss important emails. If you have email that you haven't responded to yet, the Copilot chat pane includes an option to **Show my unanswered email**. Select it to view a list of emails you might want to reply to, and then select **Reply** to compose your response.

To be included in the list, emails must meet the following criteria:

- They've been in your mailbox, unanswered, for the past three to seven days. Email that's been unanswered for longer than seven days falls off the list.
- They contain a buying intent, a question, a query, or an action item.
- They have the **Regarding** field as a lead or an opportunity.

:::image type="content" source="media/copilot-email-reminder.png" alt-text="Screenshot of a list of unanswered emails in the Copilot chat pane.":::

### See also

- [Copilot overview](copilot-overview.md)
