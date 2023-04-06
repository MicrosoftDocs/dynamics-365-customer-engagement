---
title: "Service limits and fair use policy (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about usage limits and quotas in Dynamics 365 Marketing."
ms.date: 04/06/2023
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Service limits and fair use policy

Dynamics 365 Marketing relies on shared cloud resources for data and processing. This policy defines the limits for resource usage per org. These limits ensure that other tenants' performance is not affected and resources are evenly distributed.

The following tables show the current usage limits for Marketing features.

## Outbound marketing

| Feature               | Attribute                                              | Maximum                                                     |
|-----------------------|--------------------------------------------------------|-------------------------------------------------------------|
| Segmentation          | Number of live dynamic segments per org.                | 1,000 (both user defined and system created*)                |
| Segmentation          | Total number of segments.                               | 10,000                                                      |
| Email sending         | Interactions sent (email).                                            | 10,000,000 per month (1,000,000 daily max)                  |
| Email personalization | Number of dynamic attributes.                           | 1,000                                                       |
| Email personalization | Number of [entity relationships connected](../customerengagement/on-premises/customize/create-edit-entity-relationships.md) in personalization.                                         | 1 entity relationship (for example, contact.account, contact.events)               |
| Data sync  | Number of rows in a single [synchronized table](./mkt-settings-sync.md) (for example, number of Marketing contacts). | 30,000,000 rows                                        |
| Data sync  | Total rows across all [synchronized tables](./mkt-settings-sync.md).| 100,000,000 rows                                        |

> [!NOTE]
> System segments are created in three ways:
> 1. Whenever a unified segment is created (a behavior block plus a profile).
> 1. Whenever a journey uses multiple segments that will create a union of segments. For example, you can choose the source type and add multiple segments.
> 1. Whenever a behavior segment is used in journeys.

## Real-time customer journey orchestration

| Feature                     | Attribute                                                   | Maximum                                                    |
|-----------------------------|-------------------------------------------------------------|------------------------------------------------------------|
| Interaction sending         | Interactions sent (email, text, push).                                           | 100,000,000 per month (3,333,000 daily max)                   |
| Interaction personalization | Number of distinct dynamic attributes used in a single message.                                | 100                                                   |
| Interaction personalization | Number of [entity relationships connected](../customerengagement/on-premises/customize/create-edit-entity-relationships.md) in personalization. | 1:1 = up to 6 levels<br>(1:N & N:M = not currently supported) |
| Data sync  | Number of rows in a single [synchronized table](./mkt-settings-sync.md) (for example, number of Marketing contacts). | 30,000,000 rows                                        |
| Data sync  | Total rows across all [synchronized tables](./mkt-settings-sync.md).| 100,000,000 rows                                        |
| Segment-based journeys          | Number of contacts and Customer Insights profiles in a segment used in a real-time marketing journey.          | 10,000,000 members                |
| Latency of trigger-based journeys          | Time from when a trigger is activated to completing first step in the journey.          | < 2 minutes with up to 700 triggers activated per minute.<br>If the total number of triggers activated across your environment exceeds 700 per minute, the time to complete the first step will increase linearly.                |

## Event management

| Feature               | Attribute                                              | Maximum                                                     |
|-----------------------|--------------------------------------------------------|-------------------------------------------------------------|
| Event registrations   | Number of event registrations processed simultaneously. | 60 event registrations per second<br>40 concurrent requests |

If you have questions or concerns about how to optimize your resources, contact [Microsoft support](/power-platform/admin/get-help-support).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
