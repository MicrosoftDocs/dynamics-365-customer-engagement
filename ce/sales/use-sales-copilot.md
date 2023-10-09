---
title: Use Sales Copilot
description: Learn how to use Sales Copilot to summarize your leads and opportunities records, catch up on updates, prepare for meetings, and enrich your leads with data from different sources.
ms.date: 08/10/2023
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

# Use Copilot in Dynamics 365 Sales

Sales Copilot is an AI assistant that helps you be more productive and efficient in your daily work in Dynamics 365 sales apps. Sales Copilot can summarize information about your leads and opportunities, help you catch up on updates and prepare for meetings, and enrich your leads with information from other sources.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [Any primary sales role, such as salesperson or sales manager](security-roles-for-sales.md#primary-sales-roles)|

## Prerequisites

Your administrator must [turn on and set up Sales Copilot](enable-setup-copilot.md).

## Open Sales Copilot

Sales Copilot opens automatically in a pane at the right side of the window when you open the Sales Hub app.

If the Sales Copilot pane is closed, select the Copilot icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) in the right navigation bar.

## Chat with Sales Copilot

In the Sales Copilot pane, type **/** to get a list of the requests, or *prompts*, that Sales Copilot can help you with. Type **@** and a record name to select a specific account, opportunity, or lead. To send the prompt to Copilot, press Enter or select the **Submit** (paper airplane) icon.

:::image type="content" source="media/sales-copilot-pane.png" alt-text="Screenshot of the Sales Copilot pane and the list of suggested requests.":::

### Summarize an opportunity or a lead

1. In the Sales Copilot chat pane, type **/** and select **Summarize opportunity** or **Summarize lead** from the **Suggested requests** list.

    You can also type the prompt.

1. Start typing the name of the opportunity or lead after the **@** symbol.

    If you type the prompt, follow it with **@**.

1. Select an opportunity or lead from the list of suggested records that match your search.

    :::image type="content" source="media/copilot-opportunity-summary.png" alt-text="Screenshot of a Sales Copilot opportunity summary.":::

#### Make the summary more relevant to you

Sales Copilot generates the summary from the first seven columns in the default opportunity or lead view. Other columns may be more important to you, however. For example, estimated revenue, close date, contact, pipeline stage, and proposed solution may be the first things you look for in an opportunity. Your administrator can create a view that contains those columns and tell Sales Copilot to [base its summary on that view](./enable-setup-copilot.md#configure-record-summary-fields) instead.

Keep in mind that the summary view is set at the organization level. Make sure your entire sales team agrees on the seven most important columns.

### Enrich leads with related information

Sales Copilot can enrich your leads with information from Dynamics 365 Sales, LinkedIn, and Bing, such as:

- Possible contacts, based on the lead name, phone number, email address, and company name.
- The latest news about the account, curated by Bing.
- Suggested LinkedIn profiles for the contact, if you have the LinkedIn Sales Navigator license.

After you select a lead, Sales Copilot suggests other records that might be associated with the lead and from which it can glean more information.

1. [Ask Sales Copilot to summarize a lead](#summarize-an-opportunity-or-a-lead).

    If Sales Copilot finds possible matching records, it lists them after the summary.

1. Select **Connect** to connect the lead with a matching record.

    :::image type="content" source="media/copilot-lead-enrichment.png" alt-text="Screenshot of a lead card in the Sales Copilot chat pane, with a matching account highlighted.":::

1. After Sales Copilot connects the records, select **Get updated lead summary** to generate a new summary that includes information from the connected record.

### Catch up with an opportunity or lead

Sales Copilot can catch you up on any updates to your opportunity or lead records in the last seven days or since you last signed in.

The catch up information is taken from the audit history. If you don't see any catch up information, ask your administrator to [turn on auditing](./enable-setup-copilot.md#configure-record-catch-up-fields) and [grant you access to the audit history](enable-setup-copilot.md#grant-audit-access-to-your-sellers).

1. In the Sales Copilot chat pane, type **/** and select **Catch up on opportunity** or **Catch up on lead** from the **Suggested requests** list.

    You can also type the prompt.

1. Start typing the name of the opportunity or lead after the **@** symbol.

    If you type the prompt, follow it with **@**.

1. Select an opportunity or lead from the list of suggested records that match your search.

    :::image type="content" source="media/copilot-lead-catchup.png" alt-text="Screenshot of a lead catch up in the Sales Copilot chat pane.":::

1. To learn more about the updated information or activity, select **Know more in audit history**.

    :::image type="content" source="media/copilot-lead-catchup-audit-history.png" alt-text="Screenshot of a lead's audit history.":::

#### Make the catch up information more relevant to you

Sales Copilot summarizes the last 10 updates to the record from the audit history. It generates the summary from the first few columns in the default opportunity or lead view. You may want to stay updated on changes to other columns that matter more to you, however. Your administrator can create a view that contains those columns and tell Sales Copilot to [base its catch up on that view](./enable-setup-copilot.md#configure-record-catch-up-fields) instead.

Keep in mind that the catch up view is set at the organization level. Make sure your entire sales team agrees on the most important columns.

### Prepare for upcoming meetings

If you have meetings scheduled on your calendar in the next 24 hours, Sales Copilot can help you prepare for them. Go into your meetings with a helpful summary of notes recorded in the last three months and the most recent email thread on the timeline of the contact you're meeting with.

1. In the Sales Copilot chat pane, type **/** and select the **Prepare for upcoming meetings** prompt.

1. Select the meeting that you'd like to prepare for.

    If you only have one meeting coming up in the next 24 hours, it's summarized automatically.

    :::image type="content" source="media/copilot-prepare-for-meetings.png" alt-text="Screenshot of Sales Copilot's notes for an upcoming meeting.":::

### Show the latest news about an account

Sales Copilot can get the latest news that features or mentions your accounts, curated from Bing. These news articles can be great conversation starters and help you understand the dynamics in your customers' organizations.

As always when you're working with AI-sourced content, read articles thoroughly to confirm that they're from authentic sources and are indeed about your customer.

### Show emails you haven't replied to

Sales Copilot can help you make sure you don't miss important emails. If you have email you haven't responded to yet, the Sales Copilot chat pane includes an option to **Show my unanswered email**. Select it to view a list of emails you might want to reply to, and then select **Reply** to compose your response.

To be included in the list, emails must meet the following criteria:

- They've been in your mailbox, unanswered, for the past three to seven days. Email that's been unanswered for longer than seven days falls off the list.
- They contain a buying intent, a question, a query, or an action item.
- They have the **Regarding** field as a lead or an opportunity.

:::image type="content" source="media/copilot-email-reminder.png" alt-text="Screenshot of a list of unanswered emails in the Sales Copilot chat pane.":::

### See also

- [Copilot overview](copilot-overview.md)
