---
title: "SQL Server failure recovery | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 7b1cd83f-78cb-40f8-a745-b3c2727464dd
caps.latest.revision: 17
ms.author: matp
author: Mattp123
manager: kvivek
---
# SQL Server failure recovery with Dynamics 365 Customer Engagement (on-premises)



If the computer that is running [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] fails, you must restore the databases from backup, and then reassociate them with the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment.  
  
1.  Install [!INCLUDE[pn_ms_Windows_Server_long](../includes/pn-ms-windows-server-long.md)] and make sure that the computer is in the same domain as the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] or [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] roles. In addition, you should use the same database name and disk structure. If you change either of these, you must take additional steps to correctly restore the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] databases.  
  
2.  Install [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. For supported versions, see [SQL Server editions](software-requirements-for-microsoft-dynamics-365-server.md#sql_server_editions).  
  
3.  If you have a valid backup of the master database, restore that backup. For more information, see [MSDN: Back Up and Restore of System Databases](https://msdn.microsoft.com/library/ms190190\(v=sql.110\).aspx) in [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Books Online.  
  
4.  Restore the msdb database. For more information, see [MSDN: Back Up and Restore of System Databases](https://msdn.microsoft.com/library/ms190190\(v=sql.110\).aspx) in [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Books Online.  
  
5.  Restore the MSCRM_CONFIG and *OrganizationName*_MSCRM databases. For more information about how to restore [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] databases, see [MSDN: Back Up and Restore of SQL Server Databases](https://msdn.microsoft.com/library/ms187048.aspx).  
  
6.  If [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] and the [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] are also installed on the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], restore the **ReportServer** and **ReportServertempDB** databases. For more information about how to restore databases, see [MSDN: Backup and Restore of SQL Server Databases](https://msdn.microsoft.com/library/ms187048.aspx).  
  
7.  If you restored the MSCRM_CONFIG database, you must run [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] and use the **Connect to existing databases** option on the **Specify Deployment Options** page. If you didn’t restore the MSCRM_CONFIG database and the database is functioning correctly, you can reconnect the organization database to the system. To do this, run the `Disable-CrmOrganization` and `Edit-CrmOrganization`[!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] commands. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Administer the deployment using Windows PowerShell](administer-the-deployment-using-windows-powershell.md). Alternatively, in [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] right-click the organization and select **Disable**, right-click the organization again, select **Edit Organization**, and then change the **[!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]** value in the wizard.  For more information about how to edit an organization, see  [Edit an organizations attributes.](edit-an-organization-s-attributes.md).  
  
 This scenario is a worst-case situation, that is, a total failure of the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. In other circumstances, such as the failure of a disk, you may only have to restore a single database to recover the environment.  
 
<!--  
 For more information about high availability and disaster recovery using [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] availability groups, see [AlwaysOn Availability Groups (SQL Server)](https://msdn.microsoft.com/library/hh510230.aspx) and [Set configuration and organization databases for SQL Server 2012 AlwaysOn failover](configuration-organization-databases-alwayson-failover.md).  -->
  
## See Also  
 [Failure Recovery](microsoft-dynamics-365-failure-recovery.md)  </br> 
 [Microsoft Dynamics 365 Server failure](microsoft-dynamics-365-server-failure-recovery.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]