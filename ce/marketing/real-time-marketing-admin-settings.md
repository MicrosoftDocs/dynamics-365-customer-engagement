---
title: "Real-time marketing administrator settings (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about administrator settings required for real-time marketing functionality in Dynamics 365 Marketing."
ms.date: 03/29/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Real-time marketing administrator settings

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

This article describes administrator settings required for real-time marketing features.

## Journeys

Real-time marketing journeys utilize a Power Automate connector to publish journeys. To ensure real-time marketing journey functionality, the *shared_d365marketingforapps* connector is required to be categorized in the **Business** data group within your data loss prevention (DLP) policy. [DLP policies](/power-platform/admin/wp-data-loss-prevention) are an administrator-level feature from Power Platform that prevent misuse or abuse of company data by restricting usage of Power Platform connectors or combinations of connectors.

The **Business** categorization allows business data to be shared with Power Automate. The connector does not allow sharing or storage of any personal data. The DLP setting for the connector can only be set by an administrator.

> [!NOTE]
> Real-time marketing journeys previous used a connector called Dynamics 365 Marketing (the ID was *shared_dynamics365marketing*). Journeys now use the native connector, which is called Dynamics 365 Marketing V2 (the ID is *shared_d365marketingforapps*). To ensure proper functionality, make sure you are using the most recent native connector.

> [!IMPORTANT]
> The Marketing connector is only available to be used directly by the Dynamics 365 Marketing product and cannot be used by any user or service outside of the product. The connector is visible in the DLP connectors list to allow you to enable Marketing to work when you have explicit DLP policies configured.

Learn more about connector settings and DLP policies: [Connector classification](/power-platform/admin/dlp-connector-classification).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
