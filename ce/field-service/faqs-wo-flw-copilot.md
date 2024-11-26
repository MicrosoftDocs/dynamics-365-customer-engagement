---
title: FAQ about work order creation using Copilot in Field Service for Outlook
description:  Get answers to common questions about the AI technology used in Dynamics 365 Field Service for Outlook, along with key considerations and details about how the AI is used, how it was tested and evaluated, and any specific limitations.
ms.date: 11/12/2024
ms.custom: 
  - responsible-ai-faqs
ms.topic: faq
author: KishorIoT
ms.author: nandab
ms.reviewer: v-wendysmith
ms.collection: bap-ai-copilot 
---

# FAQ about work order creation using Copilot in Field Service for Outlook 

This article answers common questions about the AI technology used in the Dynamics 365 Field Service for Outlook to create work orders from emails with Copilot. It also includes key considerations and details about how the AI is used, how it was tested and evaluated, and any specific limitations.

## What is work order creation using Copilot in Outlook?

This AI-powered feature allows frontline managers to easily create work orders from emails they receive from customers. Managers can review, revise, and schedule work orders in Outlook without disrupting their workflow.

## What are the feature's capabilities?

The feature parses the contents of an email thread and uses that information to populate fields in the work order form, including generating a summary for the work order description field.

## What is the feature's intended use?

The intention is to aid frontline managers in creating work orders at scale in less time and with less manual effort. This capability completes many fields and details required to create work orders based on the email content and service account details.

## How was the feature evaluated? What metrics are used to measure performance?

This feature was evaluated using both conventional performance testing and methods specifically targeted to AI features to ensure user safety and security. An extensive set of test cases was used to evaluate the risk of generating potentially sensitive or harmful content. Standardized internal tooling provided further testing to ensure harm filters and security mitigations functioned as intended, including prevention of attacks such as jailbreak attempts. More evaluation takes place with each subsequent update throughout the feature's lifecycle. [Learn more about Microsoft Responsible AI principles](https://www.microsoft.com/en-us/ai/responsible-ai).

## What are the limitations of the feature? How can users minimize the impact of the Outlook work order creation limitations when using the feature?

- The email body can't exceed 15,788 characters.
- Customized work order creation forms aren't supported.
- Summaries that are generated during work order creation are provided only in English (en-us).
- Some fields in the work order form might not be populated automatically.

## What are the supported geographies and languages?

[Explore Copilot features by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

## What operational factors and settings allow for effective and responsible use of the feature?

- Users are reminded that AI-generated content can be inaccurate, both above the form and within the description box.
- Users are prompted to review the AI-generated content before saving.

## See also

- [Create a work order in Outlook with Copilot in Field Service](flw-outlook.md#create-a-work-order-with-copilot)
- [FAQs for Dynamics 365 Field Service](responsible-ai-overview.md)
