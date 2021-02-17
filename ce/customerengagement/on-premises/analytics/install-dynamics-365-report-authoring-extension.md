---
title: "Install Dynamics 365 Report Authoring Extension | Microsoft Docs"
ms.custom: ""
ms.date: "11/28/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
author: Mattp123
ms.author: matp
manager: kvivek
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 2add576b-ccf1-46cf-85b3-dde0af8cbab5
caps.latest.revision: 37
---
# Install Dynamics 365 Report Authoring Extension

 Dynamics 365 Report Authoring Extension is required to create and customize fetch-based reports by using [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)] - Business Intelligence, an authoring environment for [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]. More information: [Microsoft Dynamics 365 reporting requirements](../deploy/microsoft-dynamics-365-reporting-requirements.md)  
  
 If not already installed, the following components are installed during Dynamics 365 Report Authoring Extension Setup:  
  
-   [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)]  
  
-   Microsoft Application Error Reporting Tool  
  
-   Windows Live ID Sign-in Assistant 6.5  
  
> [!WARNING]
>  People who use the Report Viewer control included with [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] can view information from the reports that they have access to. By using this control, the user can view additional report and session data that is not displayed when running the report in a Microsoft Dynamics 365 Customer Engagement (on-premises) app. To reduce the risk of exposing confidential data, we recommend that you configure the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] URL where the [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] is installed to allow only [!INCLUDE[pn_Secure_Sockets_Layer](../includes/pn-secure-sockets-layer.md)], also known as Secure HTTP, connections. More information: [MSDN: Configure SSL Connections on a Native Mode Report Server](/sql/reporting-services/security/configure-ssl-connections-on-a-native-mode-report-server?view=sql-server-2017).  
  
> [!IMPORTANT]
>  If your organization uses [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)], the computer on which the Dynamics 365 Report Authoring Extension is installed must have the [!INCLUDE[pn_Online_Services_SignIn_Assistant](../includes/pn-online-services-signin-assistant.md)] installed on it. If [!INCLUDE[pn_Online_Services_SignIn_Assistant](../includes/pn-online-services-signin-assistant.md)] is already installed, check the registry key SOFTWARE\Microsoft\MSOIdentityCRL and make sure that the TargetDir registry key in MSOIdentityCRL contains msoidcli.dll.  
  
## Install the plug-in  
 Dynamics 365 Report Authoring Extension is a plug-in that obtains the metadata and data from Customer Engagement (on-premises). This metadata is required to design and preview Fetch-based reports in [!INCLUDE[pn_sql_server_data_tools](../includes/pn-sql-server-data-tools.md)]. You  can use Dynamics 365 Report Authoring Extension with either Customer Engagement (on-premises).  
  
1.  In the /BIDSExtensions/ folder, double-click **SetupBIDSExtensions.exe**. [Download from the Microsoft Download Center](https://go.microsoft.com/fwlink/p/?LinkId=624672).  
  
2.  On the **Welcome to Microsoft Dynamics 365 Report Authoring Extension Setup** page, we recommend that you choose **Get updates for Microsoft Dynamics 365**, to make sure that Setup has the most recent installation files. Select **Next**.  
  
3.  On the **License Agreement** page, review the information, and if you accept the license agreement, select the **I accept this license agreement** check box, and then select **I Accept**.  
  
4.  If Setup detects that some required components are missing, the **Install Required Components** page appears. To install them, select **Install**. When the components are installed, the status column changes from **Not Installed** to **Installed**. Select **Next** to continue.  
  
    > [!NOTE]
    >  -   These components are required before Dynamics 365 Report Authoring Extension can be installed. You can exit Setup and install the components manually, or select **Install**. The **Next** button on this page is disabled until Setup detects that these components are installed.  
    > -   Installing these components may require you to restart the computer. If you are prompted to restart the computer, do so, and then start Setup again.  
  
5.  On the **Select Microsoft Update Preference** page, we recommend that you select the **Use Microsoft Update when I check for updates (recommended)** option. [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] makes sure that your computer has the latest technology, which can help to reduce the risk of vulnerabilities and security issues.  
  
6.  On the **Select Installation Location** page, accept the default location or enter a different file installation location, and then select **Next**.  
  
7.  On the **System Checks** page, a summary of all requirements and recommendations for a successful installation is shown. Errors must be corrected before installation can continue. If no errors, or only warnings appear, you can continue with the installation. To do this, select **Next**.  
  
8.  Review the **Ready to Install Microsoft Dynamics 365 Report Authoring Extension** page, and then select **Back** to correct any errors. When you are ready to continue, select **Install**.  
  
9. When Setup successfully completes, the **Microsoft Dynamics 365 Report Authoring Extension Completed** page appears. Select **Finish**.  
  
## See Also  
 [Create a new report using SQL Server Data Tools](create-a-new-report-using-sql-server-data-tools.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]