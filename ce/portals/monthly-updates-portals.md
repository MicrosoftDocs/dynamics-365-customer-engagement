---
title: "Monthly updates in portal capabilities for Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 873dffa1-e598-4548-b494-7b67f2b01bb1
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# What’s new

The December 2016 update has brought many new features to the portal capabilities of Dynamics 365. These updates allow for better interactions among companies, partners, and customers and make the experience of navigating the portal faster and easier. Some of the major updates include:

-   **Multiple language support:** Support customers from multiple regions by using a single portal.

-   **East Asian language support:** Multi-byte languages such as Japanese, Chinese, and Korean are now supported.

--   **Faceted search:** New filters improve how quickly customers can find the content they are looking for while granting more control over visibility of content.

-   **Product filtering:** Portal users can trim access knowledge articles related to their product ownership to avoid information overload.

-   **Content access levels:** A new level of ownership associated with Portal contact, account, or web role that is used to control access to knowledge articles. Provide the right article for the right audience and prevent irrelevant articles from surfacing.

-   **Knowledge article reporting enhancement:** The portal tracks where a knowledge article was used in the portal.

-   **Project Service Automation integration:** Provide access and visibility for active and closed projects across all stages of a project lifecycle to partners and customers. Team members, reviewers, and customers can view project status, quotes, order forums, and bookable resources on the portal with this solution.

-   **Field Service integration:** Expose information about active agreements, assets, work orders, invoices, and support cases to partners and customers on the portal with this solution.

-   **Partner onboarding:** Recruit new partners for better customer sales and service experiences. Potential partners can apply for partner status through the portal.

## Privacy notice

By enabling the portal capabilities for Microsoft Dynamics 365, Dynamics 365 data, such as customer name, product name, case number, or any custom entity data, can be exposed through an external-facing Dynamics 365 portal. Any data exposed through the portal is stored in memory in Microsoft Azure Web Apps for caching and also as files on the local hard drive to enable portal search functionality.

A tenant administrator enables Dynamics 365 portals by configuring it through the Dynamics 365 Administration Center, which also installs a package (with solutions and data) in the selected Dynamics 365 instance. A tenant administrator or a Dynamics 365 user set up as a Portal Administrator can then specify the data that will be exposed through the portal. To subsequently disable the portal capabilities, a tenant administrator can cancel the Portal Add-on subscription with Office 365.

Azure components and services that are involved with the portal capabilities are detailed in the following sections.

**Note:** For more information about additional Azure service offerings, see the [Microsoft Azure Trust Center](https://azure.microsoft.com/support/trust-center/)  

- [Azure Web Apps](https://azure.microsoft.com/services/app-service/web/): Azure Web Apps are used to host the portal in Azure
- [Azure Traffic Manager](https://azure.microsoft.com/services/traffic-manager/): Azure Traffic Manager is used to ensure the high availability of the service by routing the user to the Web Apps that are up and running. 
- [Azure Service Bus](https://azure.microsoft.com/services/service-bus/): Azure Service Bus (Topics/Subscriptions) is used for cache invalidation of the portals. Azure Service Bus temporarily stores the messages, which are triggered when any portal-related record is changed in Dynamics 365, and are passed along to Web Apps to do the cache invalidation. 
- [Azure Key Vault](https://azure.microsoft.com/services/key-vault/)  All services store configuration data in Azure Key Vault.
- [Azure Storage](https://azure.microsoft.com/services/storage/): Data related to the organization, tenant, and portal is stored in Azure Storage.
- [Azure Active Directory](https://azure.microsoft.com/services/active-directory/): All the web services use Azure Active Directory to authenticate.
