---
title: "Dynamics365 Sales Insights and GDPR (Dynamics 365 Sales Insights) | Microsoft Docs  "
description: "Protect customer privacy and remain compliant with GDPR regulations when using Dynamics 365 Sales Insights"
keywords: "GDPR; data protection; privacy;"
ms.date: 10/31/2018
ms.service: crm-online
ms.topic: article
ms.assetid: d12b1dbe-b02e-4f61-92b7-3cf06516fe6e
author: KumarVivek
ms.author: kvivek
manager: kvivek
topic-status: Drafting
---

# Dynamics 365 Sales Insights and GDPR

The **General Data Protection Regulation (GDPR)** is a European Union (EU) directive that is fundamentally about protecting and enabling the privacy rights of individuals. The GDPR establishes strict privacy requirements governing how you manage and protect personal data while respecting individual choice—no matter where data is sent, processed, or stored.

The [Auto Capture](/dynamics365/customer-engagement/sales-enterprise/auto-capture) and [Relationship Analytics](relationship-analytics.md) features help organizations work in compliance with the GDPR when using the system, but some customization and development work is required.

Here are some resources where you can learn more about how to bring your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] systems into compliance with the GDPR:

- [Microsoft Dynamics 365 and GDPR](https://docs.microsoft.com/dynamics365/get-started/gdpr/index). This webpage includes links to resources, white papers, blogs, and other information related to various [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] applications and the GDPR.
- [Microsoft Trust Center](https://www.microsoft.com/trustcenter). This webpage includes links to information about how new features in Microsoft help you secure personal data and meet strict GDPR privacy requirements.

## Prepare Auto Capture, Relationship analytics, and Conversation intelligence features for GDPR compliance

You can perform the following tasks in the Auto Capture, Relationship analytics, and Conversation intelligence features to ensure that you are in compliance with GDPR.

|Task|Supported Feature|Topic|
|--|--|--|
|Specify whether relationship analytics will be performed on the data for a contact, lead, or system user by setting the **GDPR Optout** field. If the **GDPR Optout** field is set to true/yes, relationship analytics won't be performed on the data.|[Relationship Analytics](relationship-analytics.md) and [Auto Capture](/dynamics365/customer-engagement/sales-enterprise/auto-capture)|[Opt out of relationship analytics (GDPR)](optout-relationship-analytics-gdpr.md)|
|View KPI data stored for a contact, lead, and opportunity by using system views, and export it to Excel.|[Relationship Analytics](relationship-analytics.md)|[View and export KPI data (GDPR)](view-export-KPI-data-gdpr.md)|
|Retrieve data for an contact, lead, opportunity, and system user from Azure service that is used to compute and store data by using a custom action.|[Relationship Analytics](relationship-analytics.md) and [Introduction to Conversation Intelligence](../sales/dynamics365-sales-insights-app.md)|[Retrieve insights data using msdyn_RetrieveKPIValuesForGDPR action (GDPR)](retrieve-insights-data-msdyn-RetrieveTypeValuesFromDCI.md)  |

### See also

[Overview of Dynamics 365 Sales Insights](overview.md)  
