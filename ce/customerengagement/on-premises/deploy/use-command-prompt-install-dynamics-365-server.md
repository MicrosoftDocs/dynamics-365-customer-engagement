---
title: "Use the command prompt to install Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 04e55eb6-9d97-433f-abc5-f6ab55ef16ba
caps.latest.revision: 17
ms.author: matp
author: Mattp123
manager: kvivek
---
# Use the command prompt to install Dynamics 365 Customer Engagement (on-premises) 

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

You can install Dynamics 365 Server and Dynamics 365 Reporting Extensions from their respective installation media location by using the command prompt. The required setup information is provided to the Setup program both as command-line parameters and as an XML configuration file that the Setup program references.  
  
 One advantage of using the command prompt to install Dynamics 365 Customer Engagement (on-premises) is that you don’t have to attend to the installation. Attended installation requires you to make decisions and provide information so the installation can run successfully. Unattended installation, by using the command prompt, requires you to provide installation information as command-line parameters and an XML configuration file. No other action is required until the Setup program is finished. Warnings and installation progress can be logged to a file you can view and analyze later.  
  
> [!TIP]
>  To help troubleshoot invalid XML error messages, open the XML configuration file using a web browser to help indicate where the problem occurs in the file.  
  
## General procedures  
 The general procedures for running the Setup program from a command prompt are described here. The prerequisites for each of the Dynamics 365 Customer Engagement (on-premises) system features as discussed in previous section also apply.  
  
#### To run the Setup program from a command prompt, follow these steps:  
  
1.  Provide a customized Setup configuration file. Examples are in the topics that follow.  
  
2.  Sign in as a member of the Domain Users [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service group and administrators group on the local computer. If you’re installing Dynamics 365 Server using the Full Server role, the user running Setup must be a member of the local administrators group on the computer that has [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] installed, and permissions on the organizational unit to create or modify [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] groups in the domain where Dynamics 365 Server is installed. If you’re using pre-created groups, you must have read and write permission to each group.  
  
3.  If you’re installing from an installation disk, insert the Dynamics 365 Server installation disk into the CD/DVD drive. The **Autorun** screen appears. Close the **Autorun** screen.  
  
4.  Open a Command Prompt window.  
  
5.  At the command prompt, change to the CD/DVD drive or change to the location where the Dynamics 365 Customer Engagement (on-premises) installation files are located:  
  
    -   **SetupServer.exe** for Dynamics 365 Server is located in the Server folder of the Dynamics 365 Customer Engagement (on-premises) installation disk or file download location.  
  
    -   **SetupSrsDataConnector.exe** for the Dynamics 365 Reporting Extensions is located in the \SrsDataConnector folder of the Dynamics 365 Customer Engagement (on-premises) installation disk or file download location.    
  
6.  Run the Setup command using the following syntax:  
  
     SetupServer.exe /Q /config c:\CRMSetupconfig.xml  
  
## Known issues  
  
### Error message “Setup failed to validate specified Reporting Services Report Server https://ServerName/ReportServer” when you install Dynamics CRM Server on Server Core  
 You may see this error message when the following conditions are true:  
  
-   You run [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] on a [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] running Server Core.  
  
-   The [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] server that is specified in the Setup XML configuration file configured for an authentication type that is not NTLM authentication only.  
  
 To work around this problem, on the [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] where you are installing Dynamics 365 Customer Engagement (on-premises), modify the RSServer.config file to remove all authentication types so that the only authentication type is RSWindowsNTLM.  
  
```  
<AuthenticationTypes>     
   <RSWindowsNTLM/>  
</AuthenticationTypes>  
  
```  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [RSReportServer Configuration File](/sql/reporting-services/report-server/rsreportserver-config-configuration-file?view=sql-server-2016)  
  
 After you make the RSServer.config file change, run [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] again.  
  
  
## See Also  
 [Install Microsoft Dynamics 365 for Outlook using a command prompt](../../../outlook-addin/admin-guide/install-using-command-prompt.md)   <br/> 
 [Installing on-premises Dynamics 365](installing-on-premises-dynamics-365.md)  <br/>
 [Post-installation and configuration guidelines for Microsoft Dynamics 365](post-installation-configuration-guidelines-dynamics-365.md)

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]