---
title: "Microsoft Dynamics 365 Server feature using the same account as instance of SQL Server Reporting Services | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: d2d2dc47-96f2-4452-9d6a-6b35c0b2aedc
caps.latest.revision: 8
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Microsoft Dynamics 365 Server feature using the same account as instance of SQL Server Reporting Services
A [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] feature is using the same account as the instance of [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] that you specified.  
  
 ## Cause 
  
 [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] should not be installed on an instance of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] that is running under the same account as a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] feature. Setup will detect this problem when any of the following conditions are true:  
  
-   Condition 1: Error  
  
    -   A [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] feature is installed on the computer [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] Setup is being run.  
  
    -   The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] account is a member of the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] SQLAccessGroup security group. This can occur when the [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] is running under the same account as another [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] feature.  
  
-   Condition 2: Warning  
  
    -   [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] features, [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], and [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] are all installed on a [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] where [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] Setup is being run.  
  
-   Condition 3: Error  
  
    -   The [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] account is set as "Local Service."  
  
 ## Solution
  
 To help make data more secure, before you install [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)], we recommend that you select one of the following options:  
  
1.  Install [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] on a different computer that is running [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)].  
  
2.  Configure the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] service identity on this computer to use a domain user account. To change the identity, see the procedure below. For information about permissions that are required to run this service, see the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] documentation.  
  
3.  Configure a different account that is not a member of the SQLAccessGroup to run the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] service.  
  
### Change the service account for a service  
  
1.  On the **Start** menu, type services.msc, or select **Run** and then type services.msc, and then press **Enter**.  
  
2.  Right-click the service that you want, and then select **Properties**.  
  
3.  Select the Log On tab, and then select **This Account**.  
  
4.  Type a user name, type a password, and confirm the password.  
  
5.  Restart the service.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]