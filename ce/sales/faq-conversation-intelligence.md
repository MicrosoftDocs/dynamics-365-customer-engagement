---
title: Conversation intelligence FAQs
description: Get answers to frequently asked questions about conversation intelligence.
ms.date: 03/15/2024
ms.topic: troubleshooting
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

This article answers frequently asked questions about conversation intelligence in Dynamics 365 Sales and Sales premium.

## Which Conversation intelligence features are available in Dynamics 365 Sales versus Microsoft 365 Copilot for Sales?  

|Feature  | Copilot for Sales  |Sales Enterprise / Sales Premium  |
|---------|---------|---------|
| **Call processing**   |    |    |
|Conversation intelligence for phone calls from Teams (Inbound / Outbound)     |  No       | Yes, unlimited access to conversation intelligence  |
|Conversation intelligence for Teams meetings     | Yes (unlimited)        |  Yes<sup>12</sup> <br><sup>1</sup> Using the Copilot for Sales app for Teams <br> <sup>2</sup> Unlimited Copilot for Sales hours included with Sales Premium / Sales Enterprise license        |
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
|Supported languages for conversation intelligence      |    Conversation intelligence languages listed in this article: [Supported languages in Copilot for Sales](/viva/sales/supported-languages)|   Conversation intelligence languages listed in this section: [What languages are supported for Sales Premium?](faq-region-language.md#what-languages-are-supported-for-sales-premium-features)       |
|Supported languages for UI      |   User interface languages listed in this article: [Supported languages in Copilot for Sales](/viva/sales/supported-languages)|   All languages supported in Dynamics 365 Sales       |

## How long does it take for data updates to reflect in the app?

Conversation intelligence data is refreshed periodically and could take up to 12 hours to appear in the app. We continue to make improvements to reduce the delay.

## How many hours of conversation intelligence are available with Copilot for Sales?

You get unlimited call recording and processing hours with Copilot for Sales. You must create the meeting in Outlook and turn on the **Teams meeting** toggle to get conversation intelligence through Copilot for Sales. For more information, see [Use Copilot for Sales in Teams](https://support.microsoft.com/topic/use-viva-sales-in-teams-04286b82-bdf8-4e37-94ce-be1943b2d6ea).  

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

