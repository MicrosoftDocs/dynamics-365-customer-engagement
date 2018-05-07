---
title: "Embedded Intelligence and GDPR (Dynamics 365 Customer Engagement) | Microsoft Docs  "
description: "Protect customer privacy and remain compliant with GDPR regulations when using Embedded Intelligence in Dynamics 365 Customer Engagement"
keywords: "GDPR; data protection; privacy; embedded intelligence"
ms.date: 04/18/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d12b1dbe-b02e-4f61-92b7-3cf06516fe6e
author: KumarVivek
ms.author: kvivek
manager: kvivek
---

# Embedded Intelligence and GDPR

Applies to Dynamics 365 (online), version 9.0.2

The **General Data Protection Regulation (GDPR)** is a European Union (EU) directive that is fundamentally about protecting and enabling the privacy rights of individuals. The GDPR establishes strict privacy requirements governing how you manage and protect personal data while respecting individual choice—no matter where data is sent, processed, or stored.

The [Auto Capture](../admin/auto-capture.md) and [Relationship Analytics](../admin/relationship-analytics.md) features help organizations work in compliance with the GDPR when using the system, but some customization and development work is required.

Here are some resources where you can learn more about how to bring your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] systems into compliance with the GDPR:

- [Microsoft Dynamics 365 and GDPR](https://docs.microsoft.com/dynamics365/get-started/gdpr/index). This webpage includes links to resources, white papers, blogs, and other information related to various [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] applications and the GDPR.
- [Microsoft Trust Center](https://www.microsoft.com/trustcenter). This webpage includes links to information about how new features in Microsoft help you secure personal data and meet strict GDPR privacy requirements.

## Prepare Auto Capture and Relationship Analytics features for GDPR compliance

You can perform the following tasks in the Auto Capture and Relationship Analytics features to ensure that you are in compliance with GDPR.

|Task|Supported Feature|Topic|
|--|--|--|
|Specify whether relationship analytics will be performed on the data for a contact, lead or system user by setting the **GDPR Optout** field. If the **GDPR Optout** field is set to true/yes, relationship analytics won't be performed on the data.|[Relationship Analytics](../admin/relationship-analytics.md)</br>[Auto Capture](../admin/auto-capture.md)|[Opt out of relationship analytics (GDPR)](optout-relationship-analytics-gdpr.md)|
|View KPI data stored for an account, contact, lead and opportunity by using system views, and export it to Excel.|[Relationship Analytics](../admin/relationship-analytics.md)|[View and export KPI data (GDPR)](view-export-KPI-data-gdpr.md)|
|Retrieve data for an account, contact, lead and opportunity from Azure service that is used to compute and store data by using a custom action.|[Relationship Analytics](../admin/relationship-analytics.md)|[Retrieve insights data using msdyn_RetrieveTypeValuesFromDCI action (GDPR)](retrieve-insights-data-msdyn-RetrieveTypeValuesFromDCI.md)  |

### See also

[Embedded Intelligence for Dynamics 365 Customer Engagement](embedded-intelligence.md)  
