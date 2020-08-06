---
title: "Fair use policy (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about usage limits and quotas in Dynamics 365 Marketing"
keywords:
ms.date: 08/06/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
ms.assetid: 361dea50-9093-4668-910c-50f715fdd572
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Fair use policy

Dynamics 365 Marketing relies on shared cloud resources for data and processing. This policy defines the limits for resource usage per org. These limits ensure that other tenants' performance is not affected and resources are evenly distributed.

The table below shows the current usage limits for Marketing features.

| Feature               | Attribute                                          | Maximum                                                 |
|-----------------------|--------------------------------------------------------|-------------------------------------------------------------|
| Segmentation          | Number of live segments per org                        | 1,000 (both user defined and system created)                |
| Segmentation          | Total number of segments                               | 10,000                                                      |
| Email sending         | Emails sent per day                                        | 1,000,000                                                   |
| Email sending         | Emails sent  per month                                      | 10,000,000                                                  |
| Email personalization | Number of dynamic attributes                           | 1,000                                                       |
| Email personalization | Number of [entity relationships connected](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/customize/create-edit-entity-relationships) in personalization                                         | 1 entity relationship (e.g., contact.account, contact.events)               |
| Custom channel        | Interactions per second                                | 50 interactions per second                                  |
| Event registrations   | Number of event registrations processed simultaneously | 60 event registrations per second<br>40 concurrent requests |

If you have questions or concerns about how to optimize your resources, contact [Microsoft support](https://docs.microsoft.com/power-platform/admin/get-help-support).