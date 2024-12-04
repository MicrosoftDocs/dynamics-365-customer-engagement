---
title: FAQ about Dynamics 365 Field Service Plugin for Microsoft Copilot
description: This FAQ provides information about the AI technology used in the Dynamics 365 Field Service Plugin for Microsoft Copilot.
ms.date: 11/12/2024
ms.custom: 
  - responsible-ai-faqs
ms.topic: faq
author: KishorIoT
ms.author: nandab
ms.reviewer: v-wendysmith
ms.collection: bap-ai-copilot 
---

# FAQ about Dynamics 365 Field Service Plugin for Microsoft Copilot

> [!IMPORTANT]
> The Dynamics 365 Field Service Plugin for Microsoft Copilot is no longer available after January 15 for users of the Field Service app in Microsoft Teams. For more information, see [Feature deprecations](deprecations-field-service.md).

This FAQ answers questions about the AI impact of the Dynamics 365 Field Service Plugin for Microsoft Copilot and how the plugin helps with work orders.

## What is Dynamics 365 Field Service Plugin for Microsoft Copilot?

Dynamics 365 Field Service Plugin for Microsoft Copilot uses the power of Microsoft 365 Copilot as your AI assistant. A [Copilot for Microsoft 365 license](/microsoft-365-copilot/extensibility/overview-business-applications#get-copilot-for-microsoft-365-licenses-and-enable-plugins) is required. The plugin enables authorized users to engage in a natural-language conversation about work orders with Field Service in Microsoft Teams.  

## What are the feature’s capabilities?

The feature allows you to ask questions about work orders and generate answers quickly. For example, frontline managers can ask for a list of all work orders for tomorrow or how many high-priority work orders from last week that didn’t complete.  

Frontline workers can ask how many work orders they have for next week or ask for detailed information on a specific work order. They can ask how to do a task or what tools they need for the job.

## What is the feature’s intended use?

The feature is intended to help frontline managers and workers who use Field Service in Teams. It provides information at their fingertips without having to access the Field Service web application and search for it.  

## How was the feature evaluated? What metrics are used to measure performance?

The feature is evaluated for accuracy of understanding user prompts, the generated results, and the performance of generating results.

In addition, it's evaluated with embedded monitoring for Responsible AI. Specifically, this feature has been tested with an array of scenarios to ensure it captures and mitigates issues like inappropriate language usage, malicious intention of jail break, and data fabrication.

## What are the limitations of the feature? How can users minimize the impact of the limitations when using the system?

- Only questions related to Field Service work orders are supported. Questions about information contained in tables, images, or figures within a document or PDF work order attachment aren't supported.

- You can’t create, schedule, or close work orders.

- Educational and government environments or other highly regulated organizations aren’t supported.

## What types of data are supported?

The feature supports:

- Structured data from the Field Service work order tables in Dataverse, typically managed in tables and columns.

- Unstructured data in the form of text within documents and PDFs attached to the Field Service work order. Support of unstructured data is in public preview.

## What are the supported geographies and languages?

[Explore Copilot features by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

## What operational factors and settings allow for effective and responsible use of the feature?

Admins can choose to [block the Microsoft Copilot plugin](/microsoft-365-copilot/extensibility/overview-business-applications#deploy-a-plugin) from certain users or not deploy it.

Feedback you provide on your satisfaction with generated articles is used to improve system quality. To provide feedback on responses generated through Copilot, select the thumbs-up or thumbs-down icon.

## See also

- [Dynamics 365 Field Service Plugin for Microsoft Copilot](flw-m365-chat.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)
