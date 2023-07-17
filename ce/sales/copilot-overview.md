---
title: Sales Copilot overview
description: Learn about Sales Copilot, an AI assistant that helps your sales team be more productive and efficient in their daily work.
ms.date: 07/12/2023
ms.custom: bap-template
ms.topic: overview
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
---

# Sales Copilot overview

Sales Copilot is an AI assistant that helps your sales team be more productive and efficient in their daily work. It has a chat interface that sellers can use to get a quick summary of their opportunity and lead records, catch up on updates, prepare for meetings, and so on. It also has an interface to compose emails, which helps sellers compose professional-looking emails in no time. [Learn more about enabling and setting up Copilot](enable-setup-copilot.md).

## Sales Copilot capabilities

Sales Copilot offers the following capabilities:

- [Record summarization](#record-summarization)
- [Record catch up](#record-catch-up)
- [Meeting preparation](#meeting-preparation)
- [Email assistance](#email-assistance)
- [News updates](#news-updates) 

### Record summarization

Get a quick summary of the opportunity and lead records generated from the fields that matter to you the most. For example, let's say that estimated revenue, close date, contact, and BPF stage are the first few things that you look for in an opportunity. Work with your administrator to configure these fields for summarization. Now, when you ask copilot to summarize an opportunity, you'll get a summary of the opportunity record that includes the estimated revenue, close date, contact, and BPF stage. These fields are configurable at the organization level. Ensure that your entire sales team agrees on the top seven fields that are most relevant to your business.

### Record catch up

Catch up on the updates to your opportunity and lead records since the last seven days. Stay on top of your opportunities and leads by asking Copilot to summarize the changes to fields that matter to you the most. For example, let's say that you want to stay on top of changes to close date, estimated revenue, and contact. Work with your administrator to configure these fields for catch up. These fields are configurable at the organization level. Ensure that your entire sales team agrees on the top 10 fields that are most relevant to your business. 

### Meeting preparation

Prepare for your upcoming meetings effortlessly using Copilot. Copilot identifies your upcoming meetings for the day and summarizes the last three interactions from the Notes content of the related record for the selected meeting. The summary is only generated from the notes recorded in the last three months.

### Email assistance

Use Copilot to compose professional-looking emails, respond to emails, and get email follow up reminders. Copilot uses natural language processing (NLP) algorithms to help creating emails messages. Trained on vast text data, Copilot generates personalized, high-quality emails tailored to specific needs. Dynamics 365 Sales uses Copilot capabilities to help sellers in creating emails that effectively engage customers, ensuring clarity, conciseness, and compelling content. Using the email assistance capabilities, you can do the following tasks:  
- [Compose and send email messages using Copilot](compose-send-email-copilot.md)
- [View and copy email summary](view-copy-email-summary.md) 
- [Use Copilot in rich text editor for email](/power-apps/maker/model-driven-apps/use-copilot-email-assist?context=/dynamics365/context/sales-context)

### News updates

Stay current with trending news about your customers. These news updates can be great conversation starters and help you understand the current dynamics in their organization. Ask Copilot to get you latest news about an account to get the latest news articles featuring or mentioning the account, curated from Bing. Ensure to read through the news article thoroughly to confirm that it's from an authentic source and it's indeed about the customer.

## How can I use Sales Copilot

Use the following links to enable, configure, and use Sales Copilot:

**System administrator:**

- [Enable and set up copilot capabilities](enable-setup-copilot.md)  
- [Configure copilot capabilities](configure-sales-copilot.md)  

**Sellers, Sales managers, and similar role:** 

- [Use Sales Copilot capabilities](use-sales-copilot.md)

## Region availability and languages supported

Sales Copilot is available in all regions and is supported only in English. If you're enabling the feature outside the United States, you'll need to opt in to share relevant data with the Azure OpenAI Service in the United States. This opt-in may result in the transfer of relevant data outside of your default geography. To learn more, see [Copilot data movement across geographies](sales-copilot-data-movement.md).

## Accuracy of the Copilot responses

As Copilot is an AI assistant, it learns from the data in your organization. The accuracy of the responses depends on the quality of the data in your organization. When in doubt, verify the details in the record and provide feedback to Copilot. Copilot uses your feedback to improve the accuracy of its responses.

