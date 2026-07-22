---
title: Service limits for analytics and insights
description: Ensure reliability and stability of the service with built-in limits for analytics and insights. 
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: concept-article
ms.collection:
ms.date: 05/07/2026
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/08/2024
---

# Service limits for analytics and insights

The built-in limits are designed to ensure reliability and stability of the service. Use the Ideas forum to request changes.

The following table lists the built-in limits for the embedded version of insights that can be accessed through Copilot Service workspace. This table explains the service limits for Copilot Service historical analytics reports. Learn more about licenses and service limits in the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

| Area | Limits | Notes |
| ------------ | ------------- | ----------------- |
| Data age limit | 24-month period | Reports are limited to case data from the past 24 months. |
| Dashboard interaction | No limit | No limits on the number of interactions or drill-through within reports. |
| Topics | At least three related cases | Topics require at least three semantically related cases for the model to generate topics. |
| Topics refresh | 100k per run | Refresh of topics uses up to 100,000 cases or conversations per run. |
| Data refresh | Once every 24 hours | Data refresh occurs automatically each day, starting at midnight UTC. The time when the refresh completes isn't guaranteed. Learn more in [Dashboard overview](../use/customer-service-analytics-insights-csh.md). |

## Microsoft Power Platform capacity impact

If you enable the insights feature, it affects Dataverse entitlements. Learn more in [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

## Related information

[Supported regions and languages for analytics and insights](cs-region-availability-service-limits.md)  
