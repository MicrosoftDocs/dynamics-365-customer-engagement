---
title: Copilot capabilities overview
description: Learn about the copilot capabilities in Dynamics 365 Sales, an AI assistant that helps your sales team be more productive and efficient in their daily work.
ms.date: 10/05/2023
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
-	AI-contribution
ms.custom:
 - ai-gen-docs-bap
 - bap-template
search.app: salescopilot-docs 
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# Copilot in Dynamics 365 Sales overview

Copilot is an AI assistant that helps sales teams be more productive and efficient in their daily work. It has a chat interface that sellers can use to get a quick summary of their opportunity and lead records, catch up on updates, prepare for meetings, and so on. Copilot is enabled by default for orgs in North America region. It's enabled for all the sales apps with lead and opportunity entities in this region. If your org is in a different region, you need to enable Copilot manually. [Learn more about enabling and setting up Copilot](enable-setup-copilot.md).

> [!NOTE]
> Copilot is also available as an add-in and an integrated app in Outlook and Teams respectively, allowing you to capture, access, and update your CRM data from the apps you use every day. It also has generative AI capabilities such as record summarization and email content generation. Learn more about [Microsoft Sales Copilot](/microsoft-sales-copilot/introduction) and its [generative AI capabilities](/microsoft-sales-copilot/ai-sales-copilot). 

## Copilot capabilities

Copilot offers the following capabilities:

- [Record summarization](#record-summarization)
- [Record catch up](#record-catch-up)
- [Meeting preparation](#meeting-preparation)
- [Email assistance](#email-assistance)
- [News updates](#news-updates) 

### Record summarization

Record summarization helps you get a quick summary of your opportunity and lead records. By default, the summary is generated from your default opportunity and lead views. However, a system administrator can configure the fields that are used to generate the summary. Ensure that your entire sales team agrees on the top seven fields that are most relevant for your business. 

More information:

- [Summarize an opportunity or a lead](use-sales-copilot.md#summarize-an-opportunity-or-a-lead) 
- [Configure fields for summarization](configure-sales-copilot.md#configure-record-summary-and-catch-up-fields)

### Record catch up

Stay on top of the changes to your opportunities and leads. Copilot summarizes the changes to your records since the last seven days or your last login. Copilot generates this information from the audit history of the record. A system administrator can configure the fields that you want to catch up on. Ensure that your entire sales team agrees on the top 10 fields that are most relevant for your business.

More information:

- [Catch up with an opportunity or lead](use-sales-copilot.md#catch-up-with-an-opportunity-or-lead)  
- [Configure fields for summarization](configure-sales-copilot.md#configure-record-summary-and-catch-up-fields)

### Meeting preparation

Meeting preparation helps you prepare for your upcoming meetings effortlessly using Copilot. Copilot identifies your upcoming meetings for the day and summarizes the relevant information from the opportunity or lead records that are associated with the meeting. 

More information: [Prepare for upcoming meetings](use-sales-copilot.md#prepare-for-upcoming-meetings)

### Email assistance

Use Copilot to compose professional-looking emails, respond to emails, and get email follow up reminders. Copilot uses natural language processing (NLP) algorithms to help creating emails messages. Trained on vast text data, Copilot generates personalized, high-quality emails tailored to specific needs. Dynamics 365 Sales uses Copilot capabilities to help sellers in creating emails that effectively engage customers, ensuring clarity, conciseness, and compelling content. Using the email assistance capabilities, you can do the following tasks:  

- [Compose and send email messages using Copilot (preview)](compose-send-email-copilot.md)  
- [View and copy email summary](view-copy-email-summary.md)  
- [Show emails that are not replied](use-sales-copilot.md#show-emails-that-are-not-replied)

### News updates

News updates help you stay current with the latest news about your account. These news updates can be great conversation starters and help you understand the current dynamics in your customers' organization. Ask Copilot to get you the latest news related to an account and get a list of articles featuring or mentioning the account, curated from Bing. Ensure to read through the news article thoroughly to confirm that it's from an authentic source and it's indeed about the customer.

More information: [Show latest news for an account](use-sales-copilot.md#show-latest-news-for-an-account)

## Region availability and languages supported

Copilot is available in all regions and is supported only in English. However, if you're enabling the feature for orgs outside of North America, you'll need to opt in to share relevant data with the Azure OpenAI Service outside of your default geography. To learn more, see [Copilot data movement across geographies](sales-copilot-data-movement.md).


