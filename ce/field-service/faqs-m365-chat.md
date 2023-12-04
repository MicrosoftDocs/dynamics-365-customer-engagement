---
title: FAQ about Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)
description: This FAQ provides information about the AI technology used in the Dynamics 365 Field Service Plugin for Microsoft Copilot (preview).
ms.date: 11/28/2023
ms.custom: 
  - responsible-ai-faqs
ms.topic: article
author: KishorIoT
ms.author: nandab
ms.reviewer: v-wendysmith@microsoft.com
---

# FAQ about Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)

This FAQ describes the AI impact of the Dynamics 365 Field Service Plugin for Microsoft Copilot (preview) to generate questions about work orders.

## What is Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)?

Dynamics 365 Field Service Plugin for Microsoft Copilot (preview) utilizes the power of Microsoft 365 Copilot as your AI assistant. A [Microsoft 365 Copilot license](/microsoft-365-copilot/microsoft-365-copilot-setup#manage-licenses-for-copilot) enables authorized users to engage in a natural-language conversation about work orders with Field Service in Microsoft Teams.  

## What are the feature’s capabilities?

The feature allows you to enter a question about work orders and generate answers quickly. For example, frontline managers can ask for a list of all work orders for tomorrow or how many work orders that are high priority from last week that haven’t completed.  

Frontline workers can ask how many work orders they have for next week or ask for detailed information on a specific work order.

## What is the feature’s intended use?

The feature is intended to help frontline managers and workers who use Field Service in Teams. It provides information at their fingertips without having to access the Field Service web application and search for it.  

## How was the feature evaluated? What metrics are used to measure performance?

The feature is evaluated for accuracy of understanding user prompts, the generated results, and the performance of generating results.

In addition, it's evaluated with embedded monitoring for Responsible AI. Specifically, this feature has been tested with an array of scenarios to ensure it captures and mitigates issues like inappropriate language usage, malicious intention of jail break, and data fabrication.

## What are the limitations of the feature? How can users minimize the impact of the limitations when using the system?

- Only questions related to Field Service work orders are supported.  

- You can’t create, schedule, or close work orders.

- Educational and government environments or other highly regulated organizations aren’t supported.

### Types of data that are supported

The feature supports structured data from the Field Service work order tables in Dataverse. Structured data in the context of Microsoft Dynamics and the Dataverse system refers to data that is organized into a defined format or schema, allowing for easy storage, access, and management within the database system. Structured data is typically managed in tables and columns.

Unstructured data, which includes free-form text, images, documents, PDFs and other types of content is currently not supported.

## What are the supported geographies and languages?

This feature is available in the following countries, regions, and languages:

- English (United States, Great Britain, Australia, Canada, and India)
- Spanish (Spain and Mexico)
- Japanese
- French (France and Canada)
- German
- Portuguese (Brazil)
- Italian
- Chinese Simplified

## What operational factors and settings allow for effective and responsible use of the feature?

Admins can choose to [disable the Microsoft Copilot setting.](/microsoft-copilot-studio/copilot-plugins-overview#enable-the-microsoft-365-copilot-setting-admin)

Feedback you provide on your satisfaction with generated topics will be used to improve system quality. You can provide feedback by selecting thumbs up or thumbs down icon for responses generated through Copilot.

## See also

- [Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)](flw-m365-chat.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)