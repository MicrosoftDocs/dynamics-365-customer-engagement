---
title: "Supported regions and languages, and service limits for analytics and insights | MicrosoftDocs"
description: "Learn about region availability, languages supported, and service limits for analytics and insights."
ms.date: 11/04/2022
ms.topic: article
author: lalexms
ms.author: laalexan
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Supported regions and languages, and service limits for analytics and insights

Depending on your location, certain features are available for in Dynamics 365 Customer Service insights. Service limits also apply.

## Prerequisites

The [AI Builder preview models](/ai-builder/administer#enable-or-disable-ai-builder-preview-features) setting should be enabled in [Power Platform Admin Center](https://admin.powerplatform.microsoft.com).

## Region availability of analytics and insights

The following features are available in all geographic locations where the voice channel in Omnichannel for Customer Service is supported:
- Call transcription
- Call insights

Geographic support for real-time message translation is dependent on your translator service.

The following table lists the region availability of analytics and insights.

> [!NOTE]
> The features listed in the table are not available in South Africa, Korea, and Norway.

| Feature | North America| Europe | Asia Pacific | South America | Australia |Japan | China | India | Canada | United Kingdom | France | United Arab Emirates | Switzerland |Germany | Government Community Cloud|
| ------------------------ | ----- | ------- | -------- | ----- | ------- | ------- | ----- |---- | ------ | ------ | -------- | ------ | 
| Customer Service historical analytics | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Case topic clustering | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Omnichannel historical analytics | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |  ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Conversation topic clustering | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Omnichannel historical analytics - Voice| ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Sentiment analysis | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |  ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| AI suggestions for cases and knowledge articles | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✔ |
| Intelligent skill finder for unified routing | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Sentiment prediction-based routing | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ |
| Effort estimation model for unified routing | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |  ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ |
| AI suggestions for contacts in Microsoft Teams | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✖ |
| AI generated summary for contacts in Microsoft Teams | ✔ | ✔ | ✖ |✖ |✖ | ✖ | ✖ | ✖ | ✖ | ✖ | ✖ | ✖| ✖ | ✖ | ✖ |
| Forecast report for agents, cases, and conversations | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ |
| Knowledge Base keywords suggestion| ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔  | ✔ |
| Unified routing analytics | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔  | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✔ |

✔: Available  
✖: Not available

## Language support for AI-based analytics and insights in Customer Service

The following features support all languages that the product supports.

- Sentiment prediction-based routing
- Sentiment analysis
- Call transcription
- Call insights

Language availability for real-time message translation is dependent on your translator service provider.

The following table lists the language availability of the other Customer Service Insights features.

| Feature name | English | Arabic | Dutch | French | German | Italian | Japanese | Portuguese | Simplified Chinese | Spanish |
| ------- | ----- | -------- | ----- | ------- | ------- | ----- |---- | ------ | ------ | -------- | ------ |
| Intelligent skill finder for unified routing | ✔ | ✖ | ✖ |✔ | ✔ | ✔ | ✔ | ✖ | ✖ | ✔ |
| Effort estimation model for routing | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✖ | ✔ |
| AI suggestions for cases and knowledge articles | ✔ | ✖ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✖ | ✔ |
| AI suggestions for contacts in Microsoft Teams | ✔ | ✖ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✖ | ✔ |
| AI topic discovery | ✔ | ✖ | ✖ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✔ |
| AI suggestions for article keywords and description |  ✔ | ✖ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✖ | ✔ |
|AI generated summary for contacts in Microsoft Teams|  ✔ | ✖ | ✖ | ✖  | ✖ | ✖ | ✖ | ✖ | ✖ | ✖ |

✔ : Available  
✖ : Not available


## Service limits for analytics and insights

The built-in limits are designed to ensure reliability and stability of the service. Use the Ideas forum to request changes.

The following table lists the built-in limits for the embedded version of insights that can be accessed through the Customer Service Hub, Customer Service workspace, and Omnichannel for Customer Service apps.

| Area | Limits | Notes |
| ------------ | ------------- | ----------------- |
| Data age limit | 24-month period | Reports are limited to case data from the past 24 months. |
| Dashboard interaction | No limit | No limits on the number of interactions or drill-throughs within reports. |
| Topics | At least three related cases | Topics require at least three semantically related cases for the model to generate topics. |
| Topics refresh | 100k per run | Refresh of topics uses up to 100,000 cases or conversations per run. |
| Data refresh | Once every 24 hours | Data refresh occurs automatically each day, starting at midnight UTC. The time when the refresh completes isn't guaranteed. More information: [Dashboard overview](customer-service-analytics-insights-csh.md). |
| AI suggestions for active cases | Each user license adds 30 active cases where agents can get AI suggested knowledge articles and similar cases in real time. |
| AI suggestions for conversations | 150 conversations per month per user license | Each user license adds 150 Omnichannel conversations where agents can get AI suggested knowledge articles and similar cases in real time. |

## Service protection limits for AI suggestions

AI suggestions for case and knowledge was introduced in October 2020 with service protection limits on these capabilities to maintain a consistent quality of service for all our customers. However, there aren't penalties if customers exceed predefined limits. Over time, Microsoft might adjust these limits in keeping with customer usage patterns. Microsoft provides options for customers with high usage scenarios and patterns to purchase additional capacity in a manner that's minimally disruptive.

For information on the service protection limits for AI suggestions, see [Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md). The total limits are pooled at the tenant level based on the number of Customer Service Enterprise user licenses that are available in the tenant.

## Microsoft Power Platform capacity impact

Enabling the insights feature will affect Dataverse entitlements. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage)

### See also

[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)<br>
[Set up intelligent skill finder model](set-up-skill-based-routing.md#set-up-intelligent-skill-finder-model)<br> 
[Before you build a category classification model - AI Builder](/ai-builder/before-you-build-text-classification-model)<br>
[Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md)<br>
[Configure AI suggestions for contacts in Microsoft Teams](configure-teams-collaboration.md)<br>
[Configure AI topic clustering for conversations](ai-topic-clustering-conversations.md)<br>
[Configure AI suggestions for article keywords and description](configure-ai-suggested-article-keywords-description.md)


