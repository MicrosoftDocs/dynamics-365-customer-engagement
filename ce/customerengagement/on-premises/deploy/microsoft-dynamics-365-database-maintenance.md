---
title: "Dynamics 365 Customer Engagement (on-premises) database maintenance | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 05893d42-273f-4ef1-b070-b9d53a7dbb18
caps.latest.revision: 6
ms.author: matp
author: Mattp123
manager: kvivek
---
# Dynamics 365 Customer Engagement (on-premises) database maintenance



A [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment consists of the following databases:  
  
-   MSCRM_CONFIG. A single database that contains [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] metadata, such as configuration and location information that is specific to each organization database.  
  
-   *OrganizationName*_MSCRM. One or more organization databases. This is the database where [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data is stored, such as all records and activities, and metadata details like entity relationships.  
  
 Database maintenance for the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] databases should include regular backups, frequent security patch evaluation, and health check monitoring.  
  
> [!IMPORTANT]
>  Database maintenance or repair operations that can result in  data loss, such as DBCC CHECKDB WITH REPAIR_ALLOW_DATA_LOSS, are not supported.  
  
  
## See Also  
 [Back up the Microsoft Dynamics 365 Customer Engagement (on-premises) System](back-up-the-microsoft-dynamics-365-system.md) </br>
 [Update Microsoft Dynamics 365 Customer Engagement (on-premises)](update-microsoft-dynamics-crm.md) 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]