---
title: "Real-time marketing administrator settings (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about administrator settings required for real-time marketing functionality in Dynamics 365 Marketing."
ms.date: 11/10/2021
ms.service: dynamics-365-marketing
ms.custom: 
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

# Real-time marketing administrator settings

This article describes administrator settings required for real-time marketing features.

## Customer journeys

Real-time marketing customer journeys utilize a Power Automate connector to publish customer journeys. To ensure real-time marketing customer journey functionality, the connector is required to be categorized in the **Business** data group within your data loss prevention (DLP) policy. This categorization allows business data to be shared with Power Automate. The connector does not allow sharing or storage of any personal data. The DLP setting for the connector can only be set by an administrator.

Learn more about connector settings and DLP policies: [Connector classification](/power-platform/admin/dlp-connector-classification).