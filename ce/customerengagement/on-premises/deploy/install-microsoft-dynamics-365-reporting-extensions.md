---
title: "Install Dynamics 365 Customer Engagement (on-premises) Reporting Extensions | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: fb4cfdb3-c71f-454e-8ae8-966a47106aaa
caps.latest.revision: 25
author: Mattp123
ms.author: matp
manager: kvivek
---
# Install Microsoft Dynamics 365 Customer Engagement (on-premises) Reporting Extensions



[!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] has the following requirements:  
  
-   You must complete [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] Setup before you run [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] Setup.  
  
-   You must run [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] Setup on a computer that has a supported version of [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] installed.  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Microsoft Dynamics 365 Customer Engagement (on-premises) reporting requirements](microsoft-dynamics-365-reporting-requirements.md).  
  
> [!WARNING]
>  [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users who use the Report Viewer control included with [!INCLUDE [pn-visual-studio-short](../includes/pn-visual-studio-short.md)] can view information from the reports that they have access to. By using this control, the user can view additional report and session data that is not displayed when running the report in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. To reduce the risk of exposing confidential data, we recommend that you configure the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] website where the [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] is installed to allow only [!INCLUDE[pn_Secure_Sockets_Layer](../includes/pn-secure-sockets-layer.md)], also known as Secure HTTP, connections. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure SSL Connections on a Native Mode Report Server](https://msdn.microsoft.com/library/ms345223.aspx)  
>   
>  To reduce the risk of certain security vulnerabilities, we strongly recommend that you use different [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] accounts for the application pools used to run the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] websites.  
  
## Install the Microsoft Dynamics 365 Customer Engagement (on-premises) Reporting Extensions  
 To install the [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)], locate the [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] installation files, and follow these steps:  

1.  In the ..\Server\amd64\SrsDataConnector folder, double-click **SetupSrsDataConnector.exe**.  
  
2.  On the **Welcome to Microsoft Dynamics 365 Customer Engagement (on-premises) Reporting Extensions Setup** page, select whether you want to update [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] Setup. We recommend that if updates are available, you let Setup download the latest version. To do this, select **Update installation files**, wait until the update process is complete, and then select **Next**.  
  
3.  On the **License Agreement** page, review the information and, if you accept the license agreement, select **I accept this license agreement**, and then select **I Accept**.  
  
4.  If Setup detects that components are missing, the **Install Required Components** page appears.  
  
    1.  If you have already installed the required components, this page will not appear.  
  
    2.  If you have not installed the required components listed, you can install them now. Select **Install**. When the components are installed, the status column will change from **Missing** to **Installed**, and you can select **Next** to continue.  
  
5.  On the **Specify Configuration Database Server** page, if you are using the default instance of the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], enter the name of the computer that is running [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] and contains the configuration database (MSCRM_CONFIG), and then select **Next**.  
  
    > [!NOTE]
    >  If you are not using the default [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] instance, enter \<machine-name>\<instance-name>.  
  
6.  On the **Specify SSRS Instance Name** page, select a [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] instance that will be used for [!INCLUDE [pn-microsoftcrm](../includes/pn-microsoftcrm.md)] reporting, and then select **Next**.  
  
7.  On the **Select Microsoft Update OptIn** page, select whether you want to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] for checking for updates for your Microsoft products, and select **Next**. We recommend that you use the [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] to check for updates because this helps keep your computer up-to-date and secure.  
  
8.  On the **Select Installation Location** page, accept the default location or enter a different file installation location where you want to install [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)]. Select **Next**.  
  
9. The **System Checks** page appears. This page is a summary of the requirements for a successful [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] installation. Errors must be corrected before installation can continue. All errors must be resolved. If no errors or only warnings appear, you can continue with the installation. To do this, select **Next**.  
  
10. The **Service Disruption Warning** page appears. Verify the suitability of the services that will be stopped or restarted, and then select **Next**.  
  
11. Review the **Ready to Install Microsoft Dynamics 365 Customer Engagement (on-premises) Reporting Extensions** page, and then select **Back** to correct any errors. When you are ready to continue, select **Install**.  
  
12. When Setup completes successfully, the **Microsoft Dynamics 365 Customer Engagement (on-premises) Reporting Extensions Setup Completed** page appears. Select **Finish**.  
  
     During Setup, reports will be published for the default organization.  
  
    > [!IMPORTANT]
    >  The reports will not be published if:  
    >   
    >  -   The user running [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] Setup does not have appropriate permissions on the organization database.  
    > -   [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] are installed for a [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] instance that is different from the one that is being used by the organization.  
    > -   The base language of the organization is different from the language in which [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] are being installed.  
  
## See also  
 [Microsoft Dynamics 365 Server installation](microsoft-dynamics-365-server-installation.md)   



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]