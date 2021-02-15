---
title: "Insufficient permissions | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: ca284e3a-99d6-4cf6-b2e2-a8b176a17e53
caps.latest.revision: 4
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Insufficient permissions

## Cause
  
 You do not have sufficient permission to perform the operation.  
  
 ## Solution
  
 Depending on where you received this message, the appropriate permission must be granted. Additionally, you may need to exit the current operation, grant the permission or log on to the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] as a user who has the appropriate permission, and then try the operation again. To resolve this issue, grant the following permissions to the user account that is performing the operation:  
  
-   Local administrator on the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
-   Local administrator on the computer that is running [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)].  
  
-   Local administrator on the computer that is running [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)].  
  
-   A domain user who has Read and Write permissions to the organizational unit in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service where [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] security groups will be created.  
  
-   SQL administrator permission on the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] (sysadmin fixed server role) where the configuration and organization databases are located.  
  
-   A member of the database owner (db_owner) fixed database role on both the configuration (MSCRM_Config) and the specified organization database.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]