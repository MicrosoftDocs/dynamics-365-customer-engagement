---
title: "Dynamics 365 Customer Engagement (on-premises) reporting requirements | Microsoft Docs"
ms.custom: ""
ms.date: 04/07/2019
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 6d0d42e2-0ad0-4dfa-aa42-72ab4e92b001
caps.latest.revision: 54
ms.author: matp
author: Mattp123
manager: kvivek
---
# Microsoft Dynamics 365 Customer Engagement (on-premises) reporting requirements



[!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] are data processing extensions that are installed on the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server. The [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] accept authentication information from [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and pass it to the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server.  
  
 Dynamics 365 Customer Engagement (on-premises) Reporting Extensions Setup includes two data processing extensions: [!INCLUDE[pn_Fetch_data_processing_extension](../includes/pn-fetch-data-processing-extension.md)] and [!INCLUDE[pn_SQL_data_processing_extension](../includes/pn-sql-data-processing-extension.md)]. By default, these extensions are installed during Dynamics 365 Customer Engagement (on-premises) Reporting Extensions Setup:  
  
-   The [!INCLUDE[pn_Fetch_data_processing_extension](../includes/pn-fetch-data-processing-extension.md)] is required to create, run, and schedule Fetch-based reports.  
  
-   The [!INCLUDE[pn_SQL_data_processing_extension](../includes/pn-sql-data-processing-extension.md)] is required to create, run, and schedule the default (out-of-the-box) or SQL-based custom reports in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 You don’t need [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] to run [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. However, if you want to create, use, or schedule reports in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you need to install [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)]. Additionally, you need to install these extensions if you want to create or import an organization, like when you migrate from an earlier version of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] using [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)].  
  
  
<a name="sql_server_reporting_services"></a>   
### SQL Server Reporting Services  
 [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] is required for reporting features in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 For [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] reporting, you can use the following [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] editions running on a [supported version of Windows Server](software-requirements-for-microsoft-dynamics-365-server.md#windows-server-operating-system):  
  
-   Microsoft SQL Server 2017 Enterprise<sup>1</sup>  
-   Microsoft SQL Server 2017 Standard<sup>1</sup>   
-   Microsoft SQL Server 2017 Developer (for non-production use only)<sup>1</sup>
-   Microsoft SQL Server 2016 Enterprise, with Service Pack 2  
-   Microsoft SQL Server 2016 Standard, with Service Pack 2   
-   Microsoft SQL Server 2016 Developer, with Service Pack 2 (for non-production use only) 
  
  
> [!IMPORTANT]
> - <sup>1</sup>Requires [Microsoft Dynamics 365 Server, v9.0 (on-premises) Update 0.3](https://www.microsoft.com/download/details.aspx?id=58153).
> -   [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Compact or [!INCLUDE[pn_ms_SQL_Server_Express_long](../includes/pn-ms-sql-server-express-long.md)] editions are not supported for use with [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
> -   Using a [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] server running in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] mode is not supported with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For more information about SQL Server [!INCLUDE[pn_reporting_services_short](../includes/pn-reporting-services-short.md)] [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] mode, see [Reporting Services Report Server (SharePoint Mode)](https://docs.microsoft.com/sql/reporting-services/report-server-sharepoint/reporting-services-report-server-sharepoint-mode?view=sql-server-2016).  
  
<a name="report_ext_gen_req"></a>   
### Dynamics 365 Reporting Extensions requirements  
 The [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] component has the following requirements:  
  
-   You must complete [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] *before* you run Dynamics 365 Customer Engagement (on-premises) Reporting Extensions Setup.  
  
-   You can install and run [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] on only one instance of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] on a computer.  
  
-   The identity account running the instance of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] where the [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] are running can’t be the local system or a virtual account. This is required for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] reporting to work because the identity account must be added to the `PrivReportingGroup` Active Directory security group that is used by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
-   Separate deployments of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] cannot share one [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server. However, a single deployment of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that has multiple organizations can use the same [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server.  
  
-   You must run the Dynamics 365 Customer Engagement (on-premises) Reporting Extensions Setup on a computer that has a supported version and edition of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] installed. More information: [SQL Server Reporting Services](microsoft-dynamics-365-reporting-requirements.md#sql_server_reporting_services)  
  
-   For smaller data sets and fewer users, you can use a single-server deployment or a multi-server deployment. With larger data sets or more users, performance decreases quickly when running complex reports. Use a multi-server deployment with one computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], and another server for [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)].  
  
<a name="report_auth_gen_req"></a>   
### Dynamics 365 Customer Engagement (on-premises) Report Authoring Extension requirements  
 Dynamics 365 Customer Engagement (on-premises) Report Authoring Extension is required to author Fetch-based reports used with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] by using [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)]. You must install the Dynamics 365 Customer Engagement (on-premises) Report Authoring Extension on a PC that has the following software.   
  
#### Supported operating systems
- Windows 10

####  Additional software requirements  
-   [!INCLUDE[pn_microsoft_visual_studio_2015](../includes/pn-microsoft-visual-studio-2015.md)] or [!INCLUDE[pn_microsoft_visual_studio_2013](../includes/pn-microsoft-visual-studio-2013.md)].
  
-   [!INCLUDE[pn_sql_server_data_tools_SSDT](../includes/pn-sql-server-data-tools-ssdt.md)] installed with [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)].  
  
    -   For Microsoft Visual Studio 2015: [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] is already included.  
  
    -   For Microsoft [!INCLUDE[pn_microsoft_visual_studio_2013](../includes/pn-microsoft-visual-studio-2013.md)]: You must download and install [Microsoft SQL Server Data Tools - Business Intelligence for Visual Studio 2013](https://www.microsoft.com/download/details.aspx?id=42313).  
        
-   If your organization uses [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)], make sure the computer with Dynamics 365 Customer Engagement (on-premises) Report Authoring Extension installed also has the [!INCLUDE[pn_Online_Services_SignIn_Assistant](../includes/pn-online-services-signin-assistant.md)] installed on it. If [!INCLUDE[pn_Online_Services_SignIn_Assistant](../includes/pn-online-services-signin-assistant.md)] is already installed, check the registry key SOFTWARE\Microsoft\MSOIdentityCRL and make sure that the TargetDir registry key in MSOIdentityCRL contains msoidcli.dll.  
  
## See also  
 [Microsoft Dynamics 365 Customer Engagement (on-premises) system requirements and required technologies](system-requirements-required-technologies.md)   
 [Microsoft Dynamics 365 Customer Engagement (on-premises) language support](microsoft-dynamics-365-language-support.md)

