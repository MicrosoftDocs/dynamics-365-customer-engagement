---
title: "Install Microsoft Dynamics 365 Reporting Extensions using a command prompt | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 252a0933-68d9-45bd-9662-71cb819f9604
caps.latest.revision: 19
ms.author: matp
author: Mattp123
manager: kvivek
---
# Install Microsoft Dynamics 365 Reporting Extensions using a command prompt

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

[!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] are data processing extensions that are installed on the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server. [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] accept the authentication information from [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] and pass it to the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server.  
  
 Installing Dynamics 365 Reporting Extensions installs two data processing extensions: Dynamics 365 [!INCLUDE[pn_Fetch_data_processing_extension](../includes/pn-fetch-data-processing-extension.md)] and [!INCLUDE[pn_SQL_data_processing_extension](../includes/pn-sql-data-processing-extension.md)]. The [!INCLUDE[pn_Fetch_data_processing_extension](../includes/pn-fetch-data-processing-extension.md)] is required to create, run, and schedule Fetch-based reports in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. The [!INCLUDE[pn_SQL_data_processing_extension](../includes/pn-sql-data-processing-extension.md)] is required to schedule SQL-based reports in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
## Microsoft Dynamics 365 Reporting Extensions requirements  
 [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] has the following requirements:  
  
-   You must have all Dynamics 365 Server roles installed before you run [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)].  
  
-   You must run [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)] on a computer that has [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] installed.  
  
-   You can run [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] with any supported edition of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)]. For detailed information about the versions of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] supported, see [Microsoft Dynamics 365 Reporting Extensions requirements](microsoft-dynamics-365-reporting-requirements.md).  
  
-   [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_legacy](../includes/pn-microsoft-dynamics-crm-reporting-extensions-legacy.md)] can’t be installed on a server running a Server Core installation of [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)]. This is because [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)], which is required , can’t be installed on a server running a Server Core installation of [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)].  
  
-   For smaller data sets and fewer users, it may be suitable to use a single-server deployment where [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] database engine and [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] run on the same server. However, with larger datasets or more users, performance will decrease quickly when complex reports are run, so we recommend that you use a multi-server deployment with one computer running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] databases, and another server for [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)].  
  
## Command example  
 [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)] accepts the same command-line parameters as [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)]. To install Dynamics 365 Reporting Extensions in quiet mode, which uses an XML configuration file named **install-config.xml**, and creates a log file named **log.txt**, run the Setup program that is located in the **SrsDataConnector** folder from the Dynamics 365 Customer Engagement (on-premises) installation files as follows:  
  
 SetupSrsDataConnector /Q /CONFIG folderpath\install-config.xml /L c:\logfiles\crm\log.txt  
  
## See Also  
 [Use the Command Prompt to Install Microsoft Dynamics 365](use-command-prompt-install-dynamics-365-server.md)   </br>
 [Install Microsoft Dynamics 365 for Outlook using a command prompt](../../../outlook-addin/admin-guide/install-using-command-prompt.md) </br>
 [Microsoft Dynamics 365 Reporting Extensions XML configuration file](dynamics-365-reporting-extensions-xml-config-file.md)

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]