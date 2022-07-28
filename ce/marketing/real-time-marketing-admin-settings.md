---
title: "Real-time marketing administrator settings (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about administrator settings required for real-time marketing functionality in Dynamics 365 Marketing."
ms.date: 05/13/2022
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

## Journeys

Real-time marketing journeys utilize a Power Automate connector to publish journeys. To ensure real-time marketing journey functionality, the *shared_d365marketingforapps* connector is required to be categorized in the **Business** data group within your data loss prevention (DLP) policy. [DLP policies](/power-platform/admin/wp-data-loss-prevention) are an administrator-level feature from Power Platform that prevent misuse or abuse of company data by restricting usage of Power Platform connectors or combinations of connectors.

The **Business** categorization allows business data to be shared with Power Automate. The connector does not allow sharing or storage of any personal data. The DLP setting for the connector can only be set by an administrator.

> [!NOTE]
> Real-time marketing journeys previous used a connector called Dynamics 365 Marketing (the ID was *shared_dynamics365marketing*). Journeys now use the native connector, which is called Dynamics 365 Marketing V2 (the ID is *shared_d365marketingforapps*). To ensure proper functionality, make sure you are using the most recent native connector.

Learn more about connector settings and DLP policies: [Connector classification](/power-platform/admin/dlp-connector-classification).
