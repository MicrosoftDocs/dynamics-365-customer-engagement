---
title: "The configuration database does not exist on the specified SQL Server | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 211692df-d41a-48b0-ac60-324436e99db7
caps.latest.revision: 6
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# The configuration database does not exist on the specified SQL Server

There are several reasons why you may receive this error.

## Cause
  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] configuration database (MSCRM_CONFIG) does not exist on the specified instance of [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)]. This issue can occur when [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup has not created the configuration database.  
  
## Solution
  
 To resolve this issue, perform one of the following procedures:  
  
-   If you are running [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup, you must select to install the configuration database, or specify an instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that has the configuration database on it.  
  
-   If you are running [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] Setup, you must first run [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup to install the configuration database, or specify an instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that has the configuration database located on it.  
  
 ## Cause
  
 You do not have sufficient permission to perform the operation.  
  
 ## Solution
  
 Depending on where you received this message, the appropriate permission must be granted. Additionally, you may need to exit the current operation, grant the permission or log on to the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] as a user who has the appropriate permission, and then try the operation again. To resolve this issue, grant the following permissions to the user account that is performing the operation:  
  
-   Local administrator on the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
-   Local administrator on the computer that is running [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)].  
  
-   Local administrator on the computer that is running Dynamics 365 for Customer Engagement Reporting Extensions.  
  
-   A domain user who has Read and Write permissions to the organizational unit in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service where [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] will be installed.  
  
-   SQL administrator permission on the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] (sysadmin fixed server role) where the configuration and organization databases are located.  
  
-   A member of the database owner (db_owner) fixed database role on both the configuration (MSCRM_Config) and the specified organization database.  
  
 ## Cause
  
 Setup cannot connect to the computer that is running [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)]. This problem can occur for any of the following reasons:  
  
-   [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] edition is not supported. 
  
-   The version of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that you are using is Developer Edition, but the Named Pipes protocol is disabled on the server. Named Pipes is required for [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Developer Edition.  
  
-   You do not have the needed permissions for the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. The following permissions are required:  
  
    -   You must be a member of the Administrator local group for the computer on which [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is running.  
  
    -   You must be a member of the sysadmin fixed server role.  
  
-   The network port where [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is running may be blocking incoming requests.  
  
 ## Solution
  
 Select one of the following solutions:  
  
-   Verify that you have a supported version of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] installed. [SQL Server editions](../deploy/software-requirements-for-microsoft-dynamics-365-server.md#sql-server-editions).    
  
-   If you are running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Developer Edition you must enable the Named Pipes protocol. You can enable Named Pipes in [!INCLUDE[pn_SQL_Server_Configuration_Manager](../includes/pn-sql-server-configuration-manager.md)]. For more information about how to do this, see the [!INCLUDE[pn_SQL_Server_Configuration_Manager](../includes/pn-sql-server-configuration-manager.md)] Help.  
  
-   Obtain the necessary permissions.  
  
-   Contact your [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] administrator to verify that you can connect to the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that is used for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and that a firewall is not blocking access to that port. By default, the port to connect to a [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] is TCP 1433.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]