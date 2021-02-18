---
title: "Cannot connect to SQL Server | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
f1_keywords: 
  - SQLInstanceNameValidator
  - SQLInstanceNameValidator.htm
ms.assetid: 6d200486-7216-491f-bb84-bedda2ee5aa9
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Cannot connect to SQL Server

## Cause
  
 Setup cannot connect to the computer that is running SQL Server. This problem can occur for any of the following reasons:  
  
-   The SQL Server version or edition is not supported. 
  
-   The version of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that you are using is Developer Edition, but the Named Pipes protocol is disabled on the server. Named Pipes is required for [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Developer Edition.  
  
-   You do not have the needed permissions for the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. The following permissions are required:  
  
    -   You must be a member of the Administrator local group for the computer on which [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is running.  
  
    -   You must be a member of the sysadmin fixed server role.  
  
-   The network port where [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is running may be blocking incoming requests.  
  
 ## Solution
  
 Select one of the following solutions:  
  
-   Verify that you have a supported version of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] installed. More information: [SQL Server editions](../deploy/software-requirements-for-microsoft-dynamics-365-server.md#sql-server-editions)     
  
-   If you are running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Developer Edition, you must enable the Named Pipes protocol. You can enable Named Pipes in SQL Server Configuration Manager. For more information about how to do this, see the SQL Server Configuration Manager Help.  
  
-   Obtain the necessary permissions.  
  
-   Contact your [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] administrator to verify that you can connect to the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that is used for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and that a firewall is not blocking access to that port. By default, the port to connect to a [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is TCP 1433.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]