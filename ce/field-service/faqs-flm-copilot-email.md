---
title: FAQ about draft email responses using Copilot in Field Service for Outlook
description:  Get answers to common questions about the AI technology used to draft email responses in the Dynamics 365 Field Service for Outlook.
ms.date: 08/08/2024
ms.custom: 
  - responsible-ai-faqs
ms.topic: faq
author: KishorIoT
ms.author: nandab
ms.reviewer: v-wendysmith
ms.collection: bap-ai-copilot 
---

# FAQ about draft email responses using Copilot in Field Service for Outlook

This article answers common questions about the AI technology used to draft email responses in Dynamics 365 Field Service for Outlook. It also includes key considerations and details about how the AI is used, how it was tested and evaluated, and lists specific limitations.

## What is draft email responses using Copilot in Outlook?

This feature allows frontline managers to easily respond to customer emails with proposed schedules or schedule confirmations on their work orders.

## What are the feature's capabilities?

The feature parses the contents of an email thread and Dynamics 365 Field Service work orders and uses that information to draft an email response to the customer. The feature generates a proposed schedule for unscheduled work orders or schedule confirmation for scheduled work orders.

## What is the feature's intended use?

The intention is to aid frontline managers in responding to emails about work order schedules in less time and with less manual effort.

## How was the feature evaluated? What metrics are used to measure performance?

This feature was evaluated using both conventional performance testing and methods targeted to AI features to ensure user safety and security. An extensive set of test cases was used to evaluate the risk of generating potentially sensitive or harmful content. Standardized internal tooling provided further testing to ensure harm filters and security mitigations functioned as intended, including prevention of attacks such as jailbreak attempts. More evaluation takes place with each subsequent update throughout the feature's lifecycle. [Learn more about Microsoft Responsible AI principles](https://www.microsoft.com/en-us/ai/responsible-ai).

## What are the limitations of the feature? How can users minimize the impact of the Outlook email response limitations when using the feature?

Email responses are generated for work orders with a **System Status** of **Scheduled** or **Unscheduled** only.

## What are the supported geographies and languages?

For more information, go to [Copilot International Availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

## What operational factors and settings allow for effective and responsible use of the feature?

Users are reminded that AI-generated content can be inaccurate, both above the form and in the description box. Users are encouraged to review the AI-generated content before saving.

## See also

- [Draft an email response with Copilot](flw-outlook.md#draft-an-email-response-with-copilot)
- [FAQs for Dynamics 365 Field Service](responsible-ai-overview.md)
