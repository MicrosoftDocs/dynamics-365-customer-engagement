---
title: "Use the Dynamics 365 Customer Engagement (on-premises) Discovery services (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "In a multi-tenant environment like Dynamics 365 Customer Engagement (on-premises), the Discovery web service helps determine which organizations a user is a member of."
ms.custom: 
ms.date: 09/05/2019
ms.reviewer: pehecke
ms.service: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0b95ebbd-49f5-4e09-8f18-7708dbef65d0
caps.latest.revision: 9
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Use the Dynamics 365 Customer Engagement (on-premises) Discovery service

The Discovery web service is used to determine the organizations that a user is a member of, and the endpoint address URL to access the Organization service or Web API for each of those organizations. This Discovery service is necessary because Dynamics 365 Customer Engagement (on-premises) is a multi-tenant environment. A single Dynamics 365 Server can host multiple business organizations. By using the Discovery web service, your application can determine the endpoint address URL to access the target organization’s business data.  
  
The Discovery service is accessed through the OData V4 RESTful API or the Organization service.  

- For the Web API see: [Discover the URL for your organization](webapi/discover-url-organization-web-api.md) 
- For the Organization Service see: [Discover the URL for your organization using the Organization Service API](org-service/discover-url-organization-organization-service.md) 
  
### See also  
 [Use Dynamics 365 Customer Engagement web services](use-microsoft-dynamics-365-web-services.md)<br />
 [Use Dynamics 365 Customer Engagement Web API](./use-microsoft-dynamics-365-web-api.md)<br />
 [Use Dynamics 365 Customer Engagement Organization Service](/dynamics365/customerengagement/on-premises/developer/org-servi/use-microsoft-dynamics-365-organization-service)<br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]