---
title: Supported regions and languages for analytics and insights
description: Learn about region availability and the languages supported for analytics and insights.
ms.date: 11/15/2024
ms.topic: conceptual
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.collection: bap-ai-copilot
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Supported regions and languages for analytics and insights

Depending on your location, certain features are available in Dynamics 365 Customer Service insights. [Service limits ](ana-ser-limits.md#service-limits-for-analytics-and-insights) also apply.

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
|Copilot&mdash;Generate knowledge drafts from cases<sup>**1**</sup> |	Yes |	Yes	| Yes |	Yes |	Yes |	Yes |	No |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	Yes |	No |
| Customer Service historical analytics | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Case topic clustering | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Omnichannel historical analytics | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Conversation topic clustering | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Omnichannel historical analytics - Voice | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
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
| Omnichannel real time analytics | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Data model customization for historical and real-time reports| Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |

Yes: Available  
No: Not available

<sup>**1**</sup> By default, the Copilot features are available in the North America region only. Customers with environments outside the United States can use the Copilot features by opting in to data movement across geographical (data) boundaries to share relevant data outside their region for processing.

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
| Copilot&mdash;Summarize cases<sup>**2**</sup>  | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | No | Yes | Yes | Yes |
|Copilot&mdash;Summarize conversations<sup>**2**</sup>  | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | No | Yes | Yes | Yes |
| Copilot&mdash;Ask a question | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | No | Yes | Yes | Yes |
| Copilot&mdash;Draft a chat response | Yes | No | No | No | No | No | No | No | No | No | No | No | No |
|Copilot&mdash;Draft emails | Yes | No | Yes | Yes | Yes | Yes | Yes | Yes | No | No | Yes | Yes | Yes |
|Copilot&mdash;Generate knowledge drafts from cases | Yes | No | No | No | No | No | No | No | No | No | No | No | No |
| Intelligent skill finder for unified routing | Yes | No | No | No | Yes | Yes | Yes | Yes | No | No | Yes | No | No |
| Effort estimation model for routing | Yes | Yes | No | Yes | Yes | Yes | Yes | Yes | No | No | Yes | No | No |
| AI suggestions for cases and knowledge articles | Yes | No | No | Yes | Yes | Yes | Yes | Yes | No | No | Yes | No | No |
| AI suggestions for contacts in Microsoft Teams | Yes | No | No | Yes | Yes | Yes | Yes | Yes | No | No | Yes | No | No |
| AI topic discovery | Yes | No | No | No | Yes | Yes | Yes | Yes | Yes | No | Yes |  No | No |
| AI suggestions for article keywords and description | Yes | No | No | Yes | Yes | Yes | Yes | Yes | No | No | Yes |  No | No |
|AI generated summary for contacts in Microsoft Teams| Yes | No | No | No | No | No | No | No | No | No | No | No | No |

Yes: Available  
No: Not available

<sup>**2**</sup> Copilot might [generate summaries](../use/copilot-language-support.md) in the agents' UI language even if that isn't an officially supported language.


## Microsoft Power Platform capacity impact

If you enable the insights feature, it affects Dataverse entitlements. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).


### Related information

[Service limits for analytics and insights](ana-ser-limits.md#service-limits-for-analytics-and-insights)  
[Enable Copilot case and conversation summaries](copilot-enable-summary.md)  
[Enable Copilot help pane](copilot-enable-help-pane.md)  
[Enable data movement across regions](/power-platform/admin/geographical-availability-copilot)  
[Set up intelligent skill finder model](set-up-isf-model.md#set-up-intelligent-skill-finder-model)  
[Before you build a category classification model - AI Builder](/ai-builder/before-you-build-text-classification-model)  
[Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md)  
[Configure AI suggestions for contacts in Microsoft Teams](configure-teams-collaboration.md)  
[Configure AI topic clustering for conversations](ai-topic-clustering-conversations.md)  
[Configure AI suggestions for article keywords and description](configure-ai-suggested-article-keywords-description.md)  
