---
title: "Organization entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "An organization entity is internal to the customer relationship management process. The organization is the top level of the Dynamics 365 Customer Engagement business hierarchy. The organization can be a specific business, a holding company, a corporation, and so on."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - organization, top level of business hierarchy
  - organization records
  - organization entities, introduction
  - WhoAmIRequest message, determining organization
  - announcement, definition
  - deployment, definition
ms.assetid: 11ff225b-8173-419e-b16f-2d43faa4294d
caps.latest.revision: 30
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---

# Organization entities

An *organization* entity is internal to the customer relationship management process. The organization is the top level of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] business hierarchy. The organization can be a specific business, a holding company, a corporation, and so on. An organization is divided into business units. Schema customization is done at this level.  

 A *deployment* is a single installation of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. 

 An *announcement* is a message that appears to all users on the home page of the web application. Announcements are owned by the organization and are represented by the `BusinessUnitNewsArticle` entity.  

 You can call the <xref:Microsoft.Crm.Sdk.Messages.WhoAmIRequest> message to find out the organization for the currently logged on or impersonated user.  

## Actions on the organization entity

 An organization record is created when an organization is created in a deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. To create, import, or delete an organization programmatically, you must use the deployment web service. After an organization is created, you can use the organization web service to retrieve or update the organization. 

 An organization can own records as defined in the ownership type in the metadata definition for an entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Entity Ownership](introduction-entities.md#EntityOwnership)
  
### See also

 [Administration and Security Entities](administration-security-entities.md)   
 [Organization Entity](entities/organization.md)   
 [BusinessUnitNewsArticle Entity](entities/businessunitnewsarticle.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]