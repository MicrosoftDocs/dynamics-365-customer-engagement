---
title: "Planning requirements for SQL Server Reporting Services | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 0477d5c9-ae75-45c7-b37d-4088e6928cfb
caps.latest.revision: 14
ms.author: matp
author: Mattp123
manager: kvivek
---
# Planning requirements for SQL Server Reporting Services



The [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] are data processing extensions that are installed on the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server. [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] accept the authentication information from [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and passes it to the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server. [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)] includes both the [!INCLUDE[pn_Fetch_data_processing_extension](../includes/pn-fetch-data-processing-extension.md)] and [!INCLUDE[pn_SQL_data_processing_extension](../includes/pn-sql-data-processing-extension.md)].  
  
 The [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] are required for all major reporting tasks in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], such as working with default (out-of-box) [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] reports, uploading custom reports, creating Report Wizard reports, or scheduling reports. [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] must also be installed before you import or provision new organizations.  
  
 The [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)] does the following:  
  
1.  Installs [!INCLUDE[pn_Fetch_data_processing_extension](../includes/pn-fetch-data-processing-extension.md)] and [!INCLUDE[pn_SQL_data_processing_extension](../includes/pn-sql-data-processing-extension.md)] on the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server.  
  
2.  Installs custom assemblies used by default reports and wizard reports on [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server.  
  
3.  Creates default reports (SQL-based) for the default organization both on [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] servers.  
  
 The following table explains what reporting options will be available to you if you install [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)].  
  
### What reports will work?  
  
|Installed?|Default reports|Custom SQL-based reports|Fetch-based Wizard reports|Custom Fetch-based reports|  
|----------------|---------------------|-------------------------------|---------------------------------|---------------------------------|  
|No|Clean installation:<br /><br /> Will not be available.|-   Can’t be scheduled.<br />-   Can be uploaded and run if [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] are installed on one computer or Trust for Delegation is configured.|Will not be available.|Cannot be uploaded and run.|  
|Yes|Will be published for the default organization.|Can be uploaded and run.|Can be created, run, and scheduled.|Can be uploaded, run, and scheduled.|  
  
> [!IMPORTANT]
>  [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] shouldn’t be installed on an instance of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] that is running under an account that is a member of the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] SQL Access Group. This can occur when [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] is running under the same account as a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] service or feature. This configuration can make the system vulnerable to certain attacks. During installation, Setup detects this scenario and you can click Help for information about how to work around the issue.  
  
 Note that when you install [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)], you have the option of installing the component on a different server that is running [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)]. Therefore, by isolating [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] on a separate instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], which does not store the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases, report performance may be improved.  
  
## Microsoft Dynamics 365 Reporting Extensions requirements  
 [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] has the following requirements:  
  
-   You must complete [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] before you run the [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)].  
  
-   You must run the [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)] on a computer that has [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] installed. For smaller data sets and fewer users, you can use either a single-server deployment, or a multiple-server deployment with one computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], and another server for [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)]. With larger datasets or more users, performance will decrease quickly when complex reports are run.  
  
## See Also  
 [SQL Server installation and configuration](sql-server-installation-and-configuration.md)   



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]