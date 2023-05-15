---
title: Frequently asked questions on privacy and security
description: Find a list of frequently asked questions that are related to privacy and security in Dynamics 365 Sales.
ms.date: 03/01/2023
ms.topic: article
author: udaykirang
ms.author: udag
---

# Privacy and security FAQs

[!INCLUDE [gdpr-intro](~/../shared-content/shared/privacy-includes/gdpr-intro.md)]

## Where is the Dynamics 365 Sales data stored?  

Dynamics 365 Sales data is stored in Dataverse and in Azure resources (for certain features). Both Dataverse and the Azure resources are co-located with their respective Power Platform environment locations. For more information about Power Platform environment locations, see [Data Location](/power-platform/admin/wp-compliance-data-privacy#data-location).  

## Can the Dynamics 365 Sales data be protected with Customer Lockbox?

Yes, the Dynamics 365 Sales data is stored in the Power Platform environment and is protected with Power Platform Customer Lockbox. For more information, see [Securely access customer data using Customer Lockbox](/power-platform/admin/about-lockbox).

The following list includes services that currently don't support customer lockbox:

- Forecasting

- Predictive scoring

- Conversation intelligence

- [Relationship intelligence](ri-overview.md) (includes relationship analytics and who knows whom)

  
## Can the Dynamics 365 Sales data be encrypted using customer-managed encryption key (CMK)?

Yes, the Dynamics 365 Sales data can be encrypted using CMK. For more information, see [Manage your customer-managed encryption key](/power-platform/admin/customer-managed-key).

The following list includes services that currently don't support CMK:

- Forecasting

- Predictive scoring

- Conversation intelligence

- [Relationship intelligence](ri-overview.md) (includes relationship analytics and who knows whom)


### See also

[Dynamics 365 Sales and privacy laws and regulations](dynamics-365-sales-privacy.md)
[Sales Insights and privacy laws](embedded-intelligence-privacy.md)
