---
title: "Frequently asked questions on GDPR and Security"
description: "Find a list of frequently asked questions that are related to GDPR for Dynamics 365 Sales."
ms.date: 07/06/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
---

# General Data Protection Regulation (GDPR) and security FAQs

## Where is the Dynamics 365 Sales data stored?  

Dynamics 365 Sales data is stored in Dataverse and in Azure resources (for certain features). Both Dataverse and the Azure resources are co-located with their respective Power Platform environment locations. For more information about Power Platform environment locations, see [Data Location](/power-platform/admin/wp-compliance-data-privacy#data-location).  

## Can the Dynamics 365 Sales data be protected with Customer Lockbox and customer-managed encryption key (CMK)?

Yes, the Dynamics 365 Sales data stored in the Power Platform environment is protected with Power Platform Customer Lockbox. The data can also be encrypted using the customer-managed encryption key(CMK).

The following list includes services that currently don't support lockbox and CMK:

- Forecasting

- Predictive scoring

- Conversation intelligence

- Relationship intelligence

For more information about lockbox and CMK, see
- [Securely access customer data using Customer Lockbox](/power-platform/admin/about-lockbox)
- [Manage your customer-managed encryption key](/power-platform/admin/customer-managed-key)
  

### See also

[Dynamics 365 Sales & GDPR](dynamics-365-sales-gdpr.md)  
[GDPR for sales premium](embedded-intelligence-gdpr.md)  