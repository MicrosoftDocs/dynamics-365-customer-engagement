---
title: "Security model (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Provides a security model that protects data integrity and privacy, and supports efficient data access and collaboration."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - record-based security, definition
  - security model of Microsoft Dynamics CRM, types of security
  - field-level security, definition
  - goals for the security model in Microsoft Dynamics CRM, security model of Microsoft Dynamics CRM
  - types of security in Microsoft Dynamics CRM, role-based security
  - types of security in Microsoft Dynamics CRM, field-level security
  - role-based security, definition
  - learning about development in CRM, security model of Microsoft Dynamics CRM
  - security model of Microsoft Dynamics CRM, goals for
  - security model of Microsoft Dynamics CRM, overview of
  - types of security in Microsoft Dynamics CRM, record-based security
ms.assetid: b5b10592-5e1f-4243-be90-2fedd718ad9c
caps.latest.revision: 38
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Security model of Customer Engagement

[!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] provides a security model that protects data integrity and privacy, and supports efficient data access and collaboration. The goals of the model are as follows:  
  
- Provide users with the access only to the appropriate levels of information that is required to do their jobs.  
  
- Categorize users by role and restrict access based on those roles.  
  
- Support data sharing so that users and teams can be granted access to records that they do not own for a specified collaborative effort.  
  
- Prevent a user's access to records the user does not own or share.  
  
  **Role-based security** in Dynamics 365 Customer Engagement (on-premises) focuses on grouping a set of privileges together that describe the responsibilities (or tasks that can be performed) for a user. Dynamics 365 Customer Engagement (on-premises) includes a set of predefined security roles. Each aggregates a set of user rights to make user security management easier. Also, each application deployment can define its own roles to meet the needs of different users.  
  
  **Record-based security** in Dynamics 365 Customer Engagement (on-premises) focuses on access rights to specific records.  
  
  **Field-level security** in Dynamics 365 Customer Engagement (on-premises) restricts access to specific high business impact fields in an entity only to specified users or teams.  
  
  Combine role-based security, record-level security, and field-level security to define the overall security rights that users have within your customDynamics 365 Customer Engagement (on-premises).  
  
  More overview information about security can be found on the [Microsoft Trust Center](https://www.microsoft.com/TrustCenter/CloudServices/Dynamics365), and in this white paper: [Microsoft Dynamics CRM Online security and compliance planning guide](https://download.microsoft.com/download/B/4/A/B4A6FDE3-A5ED-43A8-99CB-E218E51AE106/Microsoft%20Dynamics%20CRM%20Online%20security%20and%20compliance%20planning%20guide.pdf).  
  
## In This Section  
 [How Role-Based Security Can Be Used to Control Access to Entities In Microsoft Dynamics 365 Customer Engagemen (on-premises)](how-role-based-security-control-access-entities.md)  
  
 [How Instance-Based Security Can Be Used to Control Access to Records In Microsoft Dynamics 365 Customer Engagement (on-premises)](use-record-based-security-control-access-records.md)  
  
 [How Field Security Can Be Used to Control Access to Field Values In Microsoft Dynamics 365 Customer Engagement (on-premises)](use-field-security-control-access-field-values.md)  
  
 [How hierarchical security can be used to control access to entities in Microsoft Dynamics 365 Customer Engagement (on-premises)](hierarchical-security-control-access-entities.md)  
  
## Related Sections  
 [Security concepts for Microsoft Dynamics 365 Customer Engagement (on-premises)](https://technet.microsoft.com/library/hh699698\(v=crm.8\).aspx)  
  
   


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]