---
title: "Regional availability and Service Limits for Customer Service | MicrosoftDocs"
description: "Learn about regional availability and service limits for Customer Service applications."
author: meghanalanka
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.author: v-mlanka
manager: shujoshi
ms.date: 04/08/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Regional availability for Customer Service

Customer Service features are available in the following regions.

| Feature | NAM | EUR | APJ | SAM | OCE |JPN | IND | CAN | GBR |
| ------- | ----- | ------- | -------- | ----- | ------- | ------- | ----- |---- | ------ |
| Customer Service historical analytics | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Case Topic Clustering | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Smart Assist Suggestions | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✖ | ✔ | ✔ |
| Omnichannel historical analytics | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Conversation Topic clustering | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |
| Sentiment analysis | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ |


✔ : Available

✖: Not available


## Service Limits in Dynamics 365 Customer Service Insights

This article describes the built-in limits to the Customer Service Insights service, which are designed to ensure the reliability and stability of the service. Any requests for changes can be made through the Ideas forum.

### Service Limits

This following table lists the built-in limits for the embedded version of insights in Customer Service Hub, Customer Service workspace and Omnichannel for Customer Service.

| Area | Limits | Notes |
| ------------ | ------------- | ----------------- |
| Data age limit | 24 month period | Reports are limited to case data from the past 24 months |
| Dashboard interaction | No limit | No limits on the number of interactions or drill-throughs within reports |
| Topics | At least three related cases | Topics require at least three semantically related cases for the model to generate topics |
| Topics refresh | 100k per run | Refresh of topics uses up to 100,000 cases or conversations per run |
| Data refresh | Once every 24 hours | Data refresh occurs automatically each day, starting at midnight UTC. The time when the refresh completes is not guaranteed. For more information, see [Dashboard overview](customer-service-analytics-insights-csh.md) |
| AI suggestions for active cases | Each user license adds 30 active cases where agents can get AI suggested knowledge articles and similar cases in real-time | 
| AI suggestions for conversations | 150 conversations per month per user license | Each user license adds 150 Omnichannel conversations where agents can get AI suggested knowledge articles and similar cases in real-time. |

## Service protection limits for AI suggestions

AI suggestions for Case and Knowledge are available starting Oct, 2020. We're introducing service protection limits on these capabilities to maintain a consistent quality of service for all our customers, but there is no penalty if customers exceed pre-defined limits. Over time, Microsoft may adjust these limits in keeping with customer usage patterns and provide options for customers with high usage scenarios and patterns to purchase additional capacity in a manner minimally disruptive to those customers.

The service protection limits for AI suggestions are defined below. The total limits are pooled at the tenant level based on the number of Customer Service Enterprise user licenses available in the tenant. For more information about AI suggestions, see [Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md)

## Power platform capacity impact

Enabling the insights feature will impact Dataverse entitlements. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage)