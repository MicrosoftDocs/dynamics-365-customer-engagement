---
title: Frequently asked questions on privacy and security
description: Find a list of frequently asked questions that are related to privacy and security in Dynamics 365 Sales.
ms.date: 06/30/2023
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

Most of the Dynamics 365 Sales features fully support customer lockbox, except for the following features:

- Conversation intelligence doesn't support customer lockbox.

- Forecasting partially supports customer lockbox. Customer approval workflow is enabled for forecasting. However, as conversation intelligence and forecasting share the same infrastructure, the forecasting data is not completely restricted for access until conversation intelligence supports lockbox. 

   > [!IMPORTANT]
   > Microsoft support’s access to the forecasting and conversation intelligence data will continue to be managed by our internal customer data access approval process.

  
## Can the Dynamics 365 Sales data be encrypted using customer-managed encryption key (CMK)?

Yes, the Dynamics 365 Sales data can be encrypted using CMK. For more information, see [Manage your customer-managed encryption key](/power-platform/admin/customer-managed-key).

Most of the Dynamics 365 Sales features fully support customer lockbox, except for conversation intelligence. 


### See also

[Dynamics 365 Sales and privacy laws and regulations](dynamics-365-sales-privacy.md)  
[Sales Insights and privacy laws](embedded-intelligence-privacy.md)  
