---
title: Conversation intelligence FAQs
description: Get answers to frequently asked questions about conversation intelligence.
ms.date: 06/12/2025
ms.topic: faq
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Conversation intelligence FAQs

This article answers frequently asked questions about conversation intelligence in Dynamics 365 Sales.

## Which Conversation intelligence features are available in Dynamics 365 Sales versus Sales in Microsoft 365 Copilot?

|Feature  | Sales in Microsoft 365 Copilot  |Sales Enterprise / Sales Premium  |
|---------|---------|---------|
| **Call processing**   |    |    |
|Conversation intelligence for phone calls from Teams (Inbound / Outbound)     |  No       | Yes, unlimited access to conversation intelligence  |
|Conversation intelligence for Teams meetings <br><br> Meeting summary with sentiment analysis and post-meeting actions such as creating tasks, viewing questions, saving AI notes, and sending follow up emails.    | Yes (unlimited)        |  Yes<sup>1,2</sup> <br><sup>1</sup> Using the Sales app for Teams <br> <sup>2</sup> Unlimited Sales in Microsoft 365 Copilot hours included with Sales Premium / Sales Enterprise license        |
| **During the call**   |    |
|Real-time conversation intelligence     |    No       |    Yes     |
|Conversation intelligence for seller-only recordings (When customer is not recorded)     |   No      |   Yes      |
| **After the call**   |    |
|Conversation summary and details logged back into CRM record     |   No      |   Yes      |
|Editing and sharing a conversation summary     |   No      |   Yes      |
|Scheduling an action item from a conversation summary    |   No      |   Yes      |
|Aggregated dashboards for managers    |   No      |   Yes      |
|Manager Coaching tools     |   No      |   Yes      |
| **Admin configurations**   |    |
|Storage of call recording and conversation intelligence insights    |   Teams storage only      |   Option of Microsoft provided storage, or your own Azure storage       |
|Supported languages for conversation intelligence      |    Conversation intelligence languages listed in this article: [Supported languages in Sales in Microsoft 365 Copilot](/microsoft-sales-copilot/introduction#supported-languages-and-geographies)|   Conversation intelligence languages listed in this section: [What languages are supported for Sales Premium?](faq-region-language.md#what-languages-are-supported-for-sales-premium-features)       |
|Supported languages for UI      |   User interface languages listed in this article: [Supported languages in Sales in Microsoft 365 Copilot](/microsoft-sales-copilot/introduction#supported-languages-and-geographies)|   All languages supported in Dynamics 365 Sales       |

## How long does it take for data updates to reflect in the app?

Conversation intelligence data is refreshed periodically and could take up to 12 hours to appear in the app. We continue to make improvements to reduce the delay.

## How many hours of conversation intelligence are available with Sales in Microsoft 365 Copilot?

You get unlimited call recording and processing hours with Sales in Microsoft 365 Copilot. You must create the meeting in Outlook and turn on the **Teams meeting** toggle to get conversation intelligence through Sales in Microsoft 365 Copilot. For more information, see [Access Sales app in Teams](/microsoft-sales-copilot/open-app#access-sales-app-in-teams).  

## Can sellers and nonmanagers use this app?

The application is available for sellers to view their conversational insights.

## Is an admin needed to enable the app for my organization?

An administrator must configure the application for you to use. If an administrator didn't configure the application, you can explore the app with the demo data that's provided.

## Which telephony system do you support?

The application is independent of telephony systems. If you have stereo call recordings (two-channel stereo), we process them at scale to generate insights​.

## What does the onboarding experience require?​

As part of the onboarding experience, you must provide the access key to the Azure blob location where you upload your call recording files for processing. You must adhere to standard metadata format (in JSON) of conversation intelligence and upload that along with every call recording file. You must also share trackers that you care about, along with your competitive brands and products, for conversation intelligence to track these words across calls.

## How is the sentiment model built?

Conversation intelligence transcribes the calls into text and generates sentiment from the text in the conversation.

## I have mono-channel recording files. Can I still use conversation intelligence?

No, we **do not** process mono-channel call recording files. We only support stereo-type call recording files.

## How long does it take to see the results?

Conversation intelligence takes a few minutes to process and display the data on the dashboard, depending on the size and format of the call recording files. You must have at least 10 call recording files to process and display the data.

## Do you retain the call recordings?

Call recordings are deleted as soon as the audio file is processed​.

