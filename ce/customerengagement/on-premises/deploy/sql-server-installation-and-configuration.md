---
title: "SQL Server installation and configuration | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: b5101a95-2ba8-44f9-9c89-e7e2698f0112
caps.latest.revision: 16
ms.author: matp
author: Mattp123
manager: kvivek
---
# SQL Server installation and configuration



To plan your use of [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] with [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], you must understand how [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] uses [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], and what [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] does and does not do:  
  
-   [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] requires [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] 64-bit versions for storing the databases that contain [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data and metadata. For specific details, see [SQL Server editions](software-requirements-for-microsoft-dynamics-365-server.md#sql_server_editions).
  
-   Reports in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] depend on [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)], a feature in [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] includes two server components that are used to store, display, and manage reports: [!INCLUDE[pn_Report_Server](../includes/pn-report-server.md)] and [!INCLUDE[pn_Report_Manager](../includes/pn-report-manager.md)]. A third component, Report Builder, is used to customize reports and write new reports. The Report Designer component is available for download on the [Microsoft Download Center](https://www.microsoft.com/download/details.aspx?id=53613) and is installed on a workstation, instead of on the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].  
  
-   [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] does not install [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] database engine or [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)].  
  
 There are many configurations possible based on your expected usage of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For information about the feature implications when you install [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] on a separate computer, see [Editions and Components of SQL Server](https://technet.microsoft.com/library/ms144275\(v=sql.110\).aspx).  
  
-   Although we do not recommend it, you can install [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] on the same computer as [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)]. For better performance, install and run [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] on a separate dedicated computer. For better performance and improved availability, install and run [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] on separate multiple dedicated computers in a clustered configuration. <!-- For more information, see [Set configuration and organization databases for SQL Server 2012 AlwaysOn failover](configuration-organization-databases-alwayson-failover.md).  -->
  
-   Similarly, we recommend that you install [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] on a separate [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that is running [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)]. However, if needed you can install [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] on a [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that is running [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] but also stores the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases.  
  
-   Although, in a multiple organization deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you can specify different [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] servers or server instances when you create or edit an organization, only one instance of [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] is supported for all organizations in the deployment. For better load balancing of reports, we recommend configuring [!INCLUDE[pn_Report_Server](../includes/pn-report-server.md)] in a Network Load Balancing (NLB) cluster.  <!-- For more information, see [Configure a Report Server on a Network Load Balancing Cluster](/sql/reporting-services/report-server/configure-a-report-server-on-a-network-load-balancing-cluster).  -->
  
-   Multiple [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] front-end servers that run in a network load balancing cluster can use the same computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].  
  
  
## Related sections 
 [Planning deployment of Microsoft Dynamics 365 prerequisites and considerations](prerequisites-considerations-planning-deployment.md)  </br>
 <!--  
 [Planning requirements for Microsoft SQL Server Reporting Services](planning-requirements-for-sql-server-reporting-services.md) -->



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]