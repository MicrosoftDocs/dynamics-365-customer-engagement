---
title: Service limits for analytics and insights
description: Ensure reliability and stability of the service with built-in limits for analytics and insights. 
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 03/13/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/08/2024
---

# Service limits for analytics and insights

The built-in limits are designed to ensure reliability and stability of the service. Use the Ideas forum to request changes.

The following table lists the built-in limits for the embedded version of insights that can be accessed through the Customer Service workspace and Omnichannel for Customer Service apps. This table explains the service limits for Customer Service historical analytics reports.

| Area | Limits | Notes |
| ------------ | ------------- | ----------------- |
| Data age limit | 24-month period | Reports are limited to case data from the past 24 months. |
| Dashboard interaction | No limit | No limits on the number of interactions or drill-through within reports. |
| Topics | At least three related cases | Topics require at least three semantically related cases for the model to generate topics. |
| Topics refresh | 100k per run | Refresh of topics uses up to 100,000 cases or conversations per run. |
| Data refresh | Once every 24 hours | Data refresh occurs automatically each day, starting at midnight UTC. The time when the refresh completes isn't guaranteed. More information: [Dashboard overview](../use/customer-service-analytics-insights-csh.md). |
| AI suggestions for active cases | Each user license adds 30 active cases where agents can get AI-suggested knowledge articles and similar cases in real time. ||
| AI suggestions for conversations | 150 conversations per month per user license | Each user license adds 150 omnichannel conversations where agents can get AI-suggested knowledge articles and similar cases in real time. |

## Service protection limits for AI suggestions

The AI suggestions for case and knowledge feature was introduced in October 2020 with service protection limits on these capabilities to maintain a consistent quality of service for all our customers. However, there aren't penalties if customers exceed predefined limits. Over time, Microsoft might adjust these limits in keeping with customer usage patterns. Microsoft provides options for customers with high usage scenarios and patterns to purchase more capacity in a manner that's minimally disruptive.

For information on the service protection limits for AI suggestions, see [Enable AI suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md). The total limits are pooled at the tenant level based on the number of Customer Service Enterprise user licenses that are available in the tenant.

## Microsoft Power Platform capacity impact

If you enable the insights feature, it affects Dataverse entitlements. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

## Related information

[Supported regions and languages for analytics and insights](cs-region-availability-service-limits.md#supported-regions-and-languages-for-analytics-and-insights)
