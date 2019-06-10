---
title: "Use the Dynamics 365 for Customer Engagement Discovery services (Developer Guide for Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
description: "In a multi-tenant environment like Dynamics 365 for Customer Engagement, the Discovery web service helps determine which organizations a user is a member of."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: "pehecke"
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 0b95ebbd-49f5-4e09-8f18-7708dbef65d0
caps.latest.revision: 9
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Use the Dynamics 365 for Customer Engagement Discovery services

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The Discovery web services are used to determine the organizations that a user is a member of, and the endpoint address URL to access the Organization service or Web API for each of those organizations. This Discovery service is necessary because [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] is a multi-tenant environment. A single [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server can host multiple business organizations. By using the Discovery web service, your application can determine the endpoint address URL to access the target organization’s business data.  
  
A Discovery service is accessed through either the Web API or the Organization Service.  

- For the Web API see: [Discover the URL for your organization using the Web API](webapi/discover-url-organization-web-api.md) 
- For the Organization Service see: [Discover the URL for your organization using the Organization Service API](org-service/discover-url-organization-organization-service.md) 
  
### See also  
 [Use Dynamics 365 for Customer Engagement web services](use-microsoft-dynamics-365-web-services.md)<br />
 [Use Dynamics 365 for Customer Engagement Web API](webapi/index.md)<br />
 [Use Dynamics 365 for Customer Engagement Organization Service](org-service/index.md)<br />
