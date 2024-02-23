---
title: Copilot in Dynamics 365 Sales overview
description: Learn how to use Copilot in Dynamics 365 Sales to get quick summaries of opportunities and leads, prepare for meetings, compose emails, and stay up-to-date with news.
ms.date: 02/07/2024
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/02/2023
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ai-usage: ai-assisted
---

# Copilot in Dynamics 365 Sales overview

Copilot is an AI assistant in Dynamics 365 Sales that helps sales teams be more productive and efficient in their daily work. It has a chat interface that sellers can use to get a quick summary of their opportunity and lead records, catch up on recent changes to their records, prepare for meetings, and read the latest news about their accounts.

Copilot is also available as an add-in in Outlook and an integrated app in Teams. With it, sellers can capture, view, and update their customer account data in the apps they use every day. The add-in and Teams app have generative AI capabilities such as record summarization and email content generation. Learn more about [Microsoft Copilot for Sales](/microsoft-sales-copilot/introduction)(formerly known as Microsoft Sales Copilot) and its [generative AI capabilities](/microsoft-sales-copilot/ai-sales-copilot).

Copilot is turned on by default for tenants in North America, in all Sales apps that have lead and opportunity entities. If your tenant is in a different region, an admin needs to [turn on Copilot manually](enable-setup-copilot.md).


## Copilot capabilities

Copilot offers the following capabilities:

- [Record summarization](#record-summarization)
- [Recent changes](#recent-changes)
- [Meeting preparation](#meeting-preparation)
- [Email assistance](#email-assistance)
- [News updates](#news-updates)

### Record summarization

Record summarization gives you a quick summary of your opportunity and lead records. Copilot generates the summary from predefined fields. Your administrator can change the fields that Copilot uses to generate the summary. Ensure that your entire sales team agrees on the top 10 fields that are most relevant for your business.

Learn more:

- [Summarize a lead or opportunity](copilot-get-information.md#summarize-a-lead-or-opportunity)
- [Change the fields in the record summary](enable-setup-copilot.md#configure-fields-for-generating-summaries-and-recent-changes-list)

### Recent changes

To help you stay on top of your sales records, Copilot summarizes any changes that were made to your lead, opportunity, and account records. Copilot generates the list of recent changes from the records' audit history. Your administrator can change the fields that are included in the recent changes list. Ensure that your entire sales team agrees on the top 10 fields that are most relevant for your business.

Learn more:

- [View recent changes to your lead or opportunity](copilot-ask-questions.md#get-recent-changes-to-a-lead-or-opportunity)
- [Get a list of recently updated sales records](copilot-ask-questions.md#whats-new-with-my-sales-records)
- [View the leads and opportunities assigned to you recently](copilot-ask-questions.md#whats-newly-assigned-to-me)
- [Change the fields you want to view in the recent changes list](enable-setup-copilot.md#configure-fields-for-generating-summaries-and-recent-changes-list)


### Meeting preparation

Copilot helps you prepare for your upcoming meetings effortlessly, summarizing relevant information from the opportunity or lead records that are associated with the meeting.

[Learn more about preparing for upcoming sales appointments](copilot-stay-ahead.md#prepare-for-upcoming-sales-appointments).

### Email assistance

Copilot can help you compose professional-looking emails, summarize email conversations to add to your customer notes, and give you reminders to follow up on emails you haven't replied to.

Learn more:

- [Compose and send email messages using Copilot (preview)](compose-send-email-copilot.md)  
- [View and copy an email summary](view-copy-email-summary.md)  
- [View emails you haven't replied to](copilot-stay-ahead.md#show-emails-you-havent-replied-to)

### News updates

Copilot can help you stay current with the latest news about your accounts. News updates can be great conversation starters and help you understand the dynamics of your customers' organizations. Ask Copilot to get you the latest news related to an account and it returns a list of articles that feature or mention the account, curated by Bing. As with any content that's provided by AI, make sure you read the news articles thoroughly and confirm that they're from an authentic source and are indeed about the customer.

[Learn how to get the latest news about an account](copilot-get-information.md#show-the-latest-news-about-an-account).

## Region availability and languages supported

Copilot is available in all regions in English only. If you turn on the feature outside of North America, you need to opt in to share some data with the Azure OpenAI Service outside of your default geography. [Learn more about how Copilot data moves across geographies](./sales-copilot-data-movement.md).
