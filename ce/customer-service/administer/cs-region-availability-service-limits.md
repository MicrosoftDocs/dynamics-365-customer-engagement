---
title: Supported regions and languages, and service limits for analytics and insights
description: Learn about region availability, languages supported, and service limits for analytics and insights.
ms.date: 03/01/2024
ms.topic: article
author: lalexms
ms.author: laalexan
ms.reviewer: shujoshi
ms.collection: bap-ai-copilot
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
> The features listed in the table aren't available in South Africa, Korea, and Norway.

| Feature | North America| Europe | Asia Pacific | South America | Australia |Japan | China | India | Canada | United Kingdom | France | United Arab Emirates | Switzerland |Germany | Government Community Cloud|
| ------------------------ | ----- | ------- | -------- | ----- | ------- | ------- | ----- |---- | ------ | ------ | -------- | ------ |
| Copilot&mdash;Summarize cases<sup>**1**</sup> | Yes | Yes |	Yes |	Yes |	Yes |	Yes |	No |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	No |
|Copilot&mdash;Summarize conversations<sup>**1**</sup> | Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	No |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	No |
| Copilot&mdash;Ask a question<sup>**1**</sup> | Yes | Yes | Yes | Yes | Yes | Yes | No |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	No |
| Copilot&mdash;Draft a chat response<sup>**1**</sup> |	Yes |	Yes |	No | No |	No | No |	No | No |	No |	Yes |	No | No |	No | No |	No |
|Copilot&mdash;Draft emails<sup>**1**</sup> |	Yes |	Yes	| Yes |	Yes |	Yes |	Yes |	No |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	No |
| Customer Service historical analytics | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |
| Case topic clustering | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Omnichannel historical analytics | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |
| Conversation topic clustering | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Omnichannel historical analytics - Voice | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |
| Sentiment analysis | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| AI suggestions for cases and knowledge articles | Yes | Yes | Yes | Yes | Yes | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | Yes |
| Intelligent skill finder for unified routing | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Sentiment prediction-based routing | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |
| Effort estimation model for unified routing | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |
| AI suggestions for contacts in Microsoft Teams | Yes | Yes | Yes | Yes | Yes | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | No |
| AI generated summary for contacts in Microsoft Teams | Yes | Yes | No | No | No | No | No | No | No | No | No | No | No | No | No |
| Forecast report for agents, cases, and conversations | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |
| Knowledge Base keywords suggestion| Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Unified routing analytics | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No | Yes |
| Omnichannel real time analytics | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |

Yes: Available  
No: Not available

<sup>**1**</sup> By default, the copilot features are available in the North America region only. Customers with environments outside the United States can use the copilot features by opting in to data movement across geographical (data) boundaries to share relevant data outside their region for processing.

## Language support for AI-based analytics and insights in Customer Service

The following features support all languages that the product supports.

- Sentiment prediction-based routing
- Sentiment analysis
- Call transcription
- Call insights

Language availability for real-time message translation is dependent on your translator service provider.

The following table lists the language availability of the other Customer Service Insights features.

| Feature name | English | Arabic |  Danish | Dutch | French | German | Italian | Japanese | Portuguese | Simplified Chinese | Spanish | Portugese (Brazil) |Thai |
| ------- | ----- | -------- | ----- | ------- | ------- | ----- |---- | ------ | ------ | -------- | ------ |--------|
| Copilot&mdash;Summarize cases<sup>**2**</sup>  | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | No | Yes | Yes | No |
|Copilot&mdash;Summarize conversations<sup>**2**</sup>  | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | No | Yes | Yes | No |
| Copilot&mdash;Ask a question | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | No | Yes | Yes | Yes |
| Copilot&mdash;Draft a chat response | Yes | No | No | No | No | No | No | No | No | No | No | No | No |
|Copilot&mdash;Draft emails | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | No | Yes | Yes | Yes |
| Intelligent skill finder for unified routing | Yes | No | No | No | Yes | Yes | Yes | Yes | No | No | Yes | No | No |
| Effort estimation model for routing | Yes | Yes | No | Yes | Yes | Yes | Yes | Yes | No | No | Yes | No | No |
| AI suggestions for cases and knowledge articles | Yes | No | No | Yes | Yes | Yes | Yes | Yes | No | No | Yes | No | No |
| AI suggestions for contacts in Microsoft Teams | Yes | No | No | Yes | Yes | Yes | Yes | Yes | No | No | Yes | No | No |
| AI topic discovery | Yes | No | No | No | Yes | Yes | Yes | Yes | Yes | No | Yes |  No | No |
| AI suggestions for article keywords and description | Yes | No | No | Yes | Yes | Yes | Yes | Yes | No | No | Yes |  No | No |
|AI generated summary for contacts in Microsoft Teams| Yes | No | No | No | No | No | No | No | No | No | No | No | No |

Yes: Available  
No: Not available

<sup>**2**</sup> Copilot generates summaries in the agents' UI language.

## Service limits for analytics and insights

The built-in limits are designed to ensure reliability and stability of the service. Use the Ideas forum to request changes.

The following table lists the built-in limits for the embedded version of insights that can be accessed through the Customer Service Hub, Customer Service workspace, and Omnichannel for Customer Service apps.

| Area | Limits | Notes |
| ------------ | ------------- | ----------------- |
| Data age limit | 24-month period | Reports are limited to case data from the past 24 months. |
| Dashboard interaction | No limit | No limits on the number of interactions or drill-throughs within reports. |
| Topics | At least three related cases | Topics require at least three semantically related cases for the model to generate topics. |
| Topics refresh | 100k per run | Refresh of topics uses up to 100,000 cases or conversations per run. |
| Data refresh | Once every 24 hours | Data refresh occurs automatically each day, starting at midnight UTC. The time when the refresh completes isn't guaranteed. More information: [Dashboard overview](../use/customer-service-analytics-insights-csh.md). |
| AI suggestions for active cases | Each user license adds 30 active cases where agents can get AI suggested knowledge articles and similar cases in real time. ||
| AI suggestions for conversations | 150 conversations per month per user license | Each user license adds 150 Omnichannel conversations where agents can get AI suggested knowledge articles and similar cases in real time. |

## Service protection limits for AI suggestions

The AI suggestions for case and knowledge feature was introduced in October 2020 with service protection limits on these capabilities to maintain a consistent quality of service for all our customers. However, there aren't penalties if customers exceed predefined limits. Over time, Microsoft might adjust these limits in keeping with customer usage patterns. Microsoft provides options for customers with high usage scenarios and patterns to purchase more capacity in a manner that's minimally disruptive.

For information on the service protection limits for AI suggestions, see [Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md). The total limits are pooled at the tenant level based on the number of Customer Service Enterprise user licenses that are available in the tenant.

## Microsoft Power Platform capacity impact

If you enable the insights feature, it affects Dataverse entitlements. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

### See also

[Introduction to Customer Service Insights](../implement/introduction-customer-service-analytics.md)  
[Enable Copilot case and conversation summaries](copilot-enable-summary.md)  
[Enable Copilot help pane](copilot-enable-help-pane.md)  
[Enable data movement across regions](/power-platform/admin/geographical-availability-copilot)  
[Set up intelligent skill finder model](set-up-isf-model.md#set-up-intelligent-skill-finder-model)  
[Before you build a category classification model - AI Builder](/ai-builder/before-you-build-text-classification-model)  
[Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md)  
[Configure AI suggestions for contacts in Microsoft Teams](configure-teams-collaboration.md)  
[Configure AI topic clustering for conversations](ai-topic-clustering-conversations.md)  
[Configure AI suggestions for article keywords and description](configure-ai-suggested-article-keywords-description.md)  
