---
title: "SQL Server hardware requirements for Dynamics 365 Server | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics CRM 2016
ms.assetid: aad0533d-0790-4a8b-8201-9bbd82bb026e
caps.latest.revision: 11
author: Mattp123
ms.author: matp
manager: kvivek
---
# Microsoft SQL Server hardware requirements for Microsoft Dynamics 365 Server



You need [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] database engine and [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] to install and run on-premises versions of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. The following table lists the minimum and recommended hardware requirements for [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)]. These requirements assume that additional components such as [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)], [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)], or [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] aren’t installed or running on the system.  
  
|Component|\*Minimum|\*Recommended|  
|---------------|---------------|-------------------|  
|Processor|x64 architecture or compatible dual-core 1.5 GHz processor|Quad-core x64 architecture 2 GHz CPU or higher such as AMD Opteron or Intel Xeon systems|  
|Memory|4 GB RAM|16 GB RAM or more|  
|Hard disk|SAS RAID 5 or RAID 10 hard disk array|SAS RAID 5 or RAID 10 hard disk array|  
  
 \*Actual requirements and product functionality might vary based on your system configuration and operating system.  
  
 Maintaining [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases on a computer that has less than the recommended requirements may result in inadequate performance.  
  
 The minimum and recommended requirements are based on 320-user load simulation tests.  
  
## See also  
 [Microsoft Dynamics 365 Customer Engagement (on-premises) system requirements and required technologies](system-requirements-required-technologies.md)   
 [Microsoft Dynamics 365 Server hardware requirements](microsoft-dynamics-365-server-hardware-requirements.md)   
 [Software requirements for Microsoft Dynamics 365 Server](software-requirements-for-microsoft-dynamics-365-server.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]