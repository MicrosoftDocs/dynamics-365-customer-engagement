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

The Embedded Intelligence feature is prepared to help organizations work in compliance with the GDPR when using the system, but some customization and development work is required.

Here are some resources where you can learn more about how to bring your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] systems into compliance with the GDPR:

- [Microsoft Dynamics 365 and GDPR](https://docs.microsoft.com/dynamics365/get-started/gdpr/index). This webpage includes links to resources, white papers, blogs, and other information related to various [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] applications and the GDPR.
- [Microsoft Trust Center](https://www.microsoft.com/trustcenter). This webpage includes links to information about how new features in Microsoft help you secure personal data and meet strict GDPR privacy requirements.

## Prepare Embedded Intelligence for GDPR compliance

Perform one or more of the following tasks in your in your Dynamics 365 instance where Embedded Intelligence feature is enabled to ensure that you are in compliance with GDPR:
- Specify whether analytics will be performed on the data for a contact, lead or system user by setting the **GDPR Optout** field. If the **GDPR Optout** field is set to true/yes, no analytics is performed on the data.  More information: [Opt out of data analytics (GDPR)](optout-data-analytics-gdpr.md)
- View KPI data stored for an account, contact, lead and opportunity by using system views, and and export it to Excel. More information: [View and export KPI data (GDPR)](view-export-KPI-data-gdpr.md)
- Retrieve data for an account, contact, lead and opportunity from Dynamics 365 for Customer Insights by using a custom action

### See also

[Embedded Intelligence for Dynamics 365 Customer Engagement ](embedded-intelligence.md)  
