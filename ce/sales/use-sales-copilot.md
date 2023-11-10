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

Copilot is an AI assistant that helps you be more productive and efficient in your daily work. Copilot can summarize information about your leads and opportunities, help you catch up on updates and prepare for meetings, and enrich your leads with information from other sources.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Prerequisites

Your administrator must [turn on and configure Copilot](enable-setup-copilot.md).

## Open Copilot

You can open Copilot as a side pane, in the context of a record, such as an opportunity or lead, or in a full-screen view.

To open **Copilot** as a side pane, select the **Copilot** icon (:::image type="icon" source="media/copilot-icon.png" border="false":::) on the right side of your app. Use the side pane when you want to get quick insights about a record or ask Copilot to summarize other records, display recent changes, and prepare for meetings, without leaving from the current page. You can open the **Copilot** side pane from any page in your app, except the **Copilot** page.

To open Copilot in a full-screen view, select **Copilot** from your sitemap. The full-screen view gives you more space and focus to chat with Copilot and ask questions. If you don't see **Copilot** in your sitemap, ask your administrator to turn on the Copilot preview feature flag. 

:::image type="content" source="media/sales-copilot-pane.png" alt-text="Screenshot of the Copilot page along with the list of suggested requests.":::

In the **Copilot** side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) to get the list of suggested requests or *prompts* that Copilot can help you with. 

You can use Copilot to get information, ask questions, or stay ahead of your work.

## Get information

Use Copilot to view your pipeline, summarize opportunities and leads, and get the latest news about your accounts.

### Show my pipeline

Copilot can get you the list of the open opportunities that you own, sorted by the estimated close date. 

In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Get info** > **Show my pipeline** and press **Enter** to view your opportunity pipeline. 


### Summarize a lead or opportunity

1. In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Ask questions** > **Summarize lead** or **Summarize opportunity**, and then press **Enter**. One of the following happens:
    
    - If you have a related record open, Copilot summarizes that record. For example, if you've opened an opportunity and selected **Summarize opportunity**, you'll see the summary of that opportunity.
    
    - If you're in the grid view or the Copilot page, you'll see a list of records that you own. Hover over the record and select **Summarize** to get a summary of the record.
    
    To get the list of changes for a specific lead or opportunity, type **/** after the prompt, and then start typing the name of the opportunity or lead.

    :::image type="content" source="media/copilot-opportunity-summary.png" alt-text="Screenshot of a Copilot opportunity summary.":::


#### Would you like to see a different set of fields summarized?

Copilot generates the summary from the first seven fields in the default opportunity or lead view. Other fields may be more important to you, however. For example, estimated revenue, close date, contact, pipeline stage, and proposed solution may be the first things you look for in an opportunity. Your administrator can create a view that contains those fields and tell Copilot to [generate the summary based on that view](./enable-setup-copilot.md#configure-record-summary-fields) instead.

Keep in mind that the summary fields are configured at the organization level. Make sure that your entire sales team agrees on the **top seven** fields that are most relevant for your business.


#### Enrich leads with related information

Copilot can enrich your leads with information from Dynamics 365 Sales, LinkedIn, and Bing, such as:

- Possible contacts, based on the lead name, phone number, email address, and company name.
- The latest news about the account, curated by Bing.
- Suggested LinkedIn profiles for the contact, if you have the LinkedIn Sales Navigator license.

After you select a lead, Copilot suggests other records that might be associated with the lead and from which it can glean more information.

1. [Ask Copilot to summarize a lead](#summarize-an-opportunity-or-a-lead).

    If Copilot finds possible matching records, it lists them after the summary.

1. Select **Connect** to connect the lead with a matching record.

    :::image type="content" source="media/copilot-lead-enrichment.png" alt-text="Screenshot of a lead card in the Copilot chat pane, with a matching account highlighted.":::

1. After Copilot connects the records, select **Get updated lead summary** to generate a new summary that includes information from the connected record. Copilot also lists the fields such as the city, state, phone numbers, and zip/postal code, that can be updated from the connected record.  
1. Select **Update all** to update the lead record with the given values.


### Show the latest news about an account

Copilot can get the latest news that features or mentions your accounts, curated from Bing. These news articles can be great conversation starters and help you understand the dynamics in your customers' organizations.

As always when you're working with AI-sourced content, read articles thoroughly to confirm that they're from authentic sources and are indeed about your customer.

1. In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Get info** > **Get latest news for account** and press **Enter**. One of the following happens:
    
    - If you're in the context of an account record, you'll see the list of news articles related to that account.  
    
    - If you aren't, you'll see a list of news articles for the top 10 accounts that you work with, sorted by the revenue associated with the accounts.
    
    To get the news articles for a specific account, type **/** and then start typing the name of the account.

## Ask questions

Ask Copilot to update you on the latest changes to your sales records, get a list of records that have been assigned to you, or list the changes to your leads and opportunities.

### What's new with my sales records

With Copilot, quickly get up to speed with all the updates to your sales records, such as leads, opportunities, and accounts. Copilot lists the records that have been updated in the last seven days.

In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Ask questions** > **What's new with my sales records** and press **Enter**. 

Copilot displays a quick summary of the records that you own, grouped by the type of record. 

:::image type="content" source="media/whats-new-with-myrecords.png" alt-text="Screenshot of the Copilot response for What's new with my sales records."::: 

### What's newly assigned to me

Copilot can help you stay on top your pipeline by getting you the list of leads and opportunities that have been assigned to you in the last 15 days.

In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Ask questions** > **What's newly assigned to me** and press **Enter**. 

### Get recent changes to a lead or opportunity

Copilot can help you catch up on any updates to your opportunity or lead records in the last seven days or since you last signed in.

The list of recent changes is taken from the audit history of the record. If you don't see the list of changes, ask your administrator to [turn on auditing](./enable-setup-copilot.md#configure-record-catch-up-fields) and [grant you access to the audit history](enable-setup-copilot.md#grant-audit-access-to-your-sellers).

1. In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Ask questions** > **What's changed for opportunity** or **What's changed for lead    ** and press **Enter**. One of the following happens:
    
    - - If you have a related record open, you'll see the list of recent changes to the record. For example, if you've opened an opportunity and selected **What's changed for opportunity**, you'll see the list of recent changes to the opportunity.
    
    - If you're in the grid view or the Copilot page, you'll see a list of records that you own. Hover over the record and select **Get updates** to get the list of recent changes to the record.  
    
    To get the list of changes for a specific lead or opportunity, type **/** and then start typing the name of the opportunity or lead.
    
    :::image type="content" source="media/copilot-lead-catchup.png" alt-text="Screenshot of a lead catch up in the Copilot chat pane.":::

1. To learn more about the updated information or activity, select **Know more in audit history**.

    :::image type="content" source="media/copilot-lead-catchup-audit-history.png" alt-text="Screenshot of a lead's audit history.":::

#### Would you like to see the recent changes for a different set of fields?

Copilot summarizes the last 10 updates to the record from the audit history, based on the fields in the default opportunity or lead view. You may want to stay updated on changes to other columns that matter more to you, however. Your administrator can create a view that contains those columns and tell Copilot to [generate catch up information based on that view](./enable-setup-copilot.md#configure-record-catch-up-fields) instead.

Keep in mind that these fields are configured at the organization level. Make sure that your entire sales team agrees on the **top ten** fields that are most relevant for your business.

## Stay ahead

Stay ahead of your work by asking Copilot to help you prepare for meetings and catch up on emails that need your attention.

### Prepare for upcoming sales appointments

If you have meetings scheduled on your calendar in the next 24 hours, Copilot can help you prepare for them. Go into your meetings with a helpful summary of notes recorded in the last three months and the most recent email thread on the timeline of the related record.

1. In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Stay ahead** >  **Prepare for sales appointments** to view the list of meetings scheduled on your calendar for the next 24 hours. One of the following happens: 

    - If you are in the context of a record, you'll see the list of sales appointments related to that record. 
    
    - If you're in the grid view or the Copilot page, you'll see all your sales appointments. 
    
1. From the list of sales appointments, hover over the meeting that you'd like to prepare for and select **Prepare**.

    If you only have one meeting coming up in the next 24 hours, it's summarized automatically.

    :::image type="content" source="media/copilot-prepare-for-meetings.png" alt-text="Screenshot of Copilot's notes for an upcoming meeting.":::


### Show emails you haven't replied to

Copilot can help ensure that you don't miss important emails by reminding you of emails that you haven't replied to.

In the Copilot side pane or page, select the sparkle icon (:::image type="icon" source="media/sparkle-icon.png" border="false":::) and select **Stay ahead** >  **Show emails that need follow up**. One of the following happens: 

    - If you are in the context of a record, you'll see the list of unanswered emails related to that record. 
    
    - If you're in the grid view or the Copilot page, you'll see all your unanswered emails. 

To be included in the list, emails must meet the following criteria:

- They've been in your mailbox, unanswered, for the past three to seven days. Email that's been unanswered for longer than seven days falls off the list.
- They contain a buying intent, a question, a query, or an action item.
- They have the **Regarding** field as a lead or an opportunity.

:::image type="content" source="media/copilot-email-reminder.png" alt-text="Screenshot of a list of unanswered emails in the Copilot chat pane.":::

### See also

- [Copilot overview](copilot-overview.md)
- [How Copilot responds when in context and out of context](use-copilot-new.md)
