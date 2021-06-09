---
title: "Microsoft Dynamics 365 Reporting Extensions XML configuration file | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: d2fb9147-1f7e-42ce-84ba-cbf909423682
caps.latest.revision: 15
ms.author: matp
author: Mattp123
manager: kvivek
---
# Microsoft Dynamics 365 Reporting Extensions XML configuration file

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

Before you run [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)] at a command prompt, you must modify the XML configuration file to include information, such as the name of the computer where the configuration database is located. A sample Dynamics 365 Reporting Extensions configuration file named **install-config.xml** is located in the SrsDataConnector folder on the installation media or download location of the Dynamics 365 Customer Engagement (on-premises) installation files.  
  
 The **/config**[drive:] [[path] configfilename.xml]] command-line parameter provides the [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)] with required information. The information this configuration file supplies is the same that each installation screen requires. The XML elements must be in English (US); special or extended characters cannot be used. An XML configuration file that has localized XML elements will not work correctly. An explanation of each XML element and a sample XML file follows:  
  
 `<CRMSetup>  </CRMSetup>`  
 The configuration file must be a valid XML file that uses \<**CRMSetup**> as the root element.  
  
 `<srsdataconnector>`  
 The configuration file must be a valid XML file that uses \<**srsdataconnector**> as the primary element. All the entries that follow must be within the \<**srsdataconnector**> tags.  
  
 `<InstallType>Uninstall/Repair</InstallType>`  
 Specifies the type of installation that Setup will perform. The following options are available:  
  
 **Uninstall.** Uninstalls [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)].  
  
 **Repair.** Starts Setup in repair mode.  
  
 `<Patch update="true"/"false">\\ServerName\ShareName\Patch_Location</Patch>`  
 If you do not specify a location, by default Setup will go online to a location that is managed by Microsoft to search for available updates. Or, you can point Setup to install a [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_Setup](../includes/pn-microsoft-dynamics-crm-reporting-extensions-setup.md)] update .msp file from a different location, such as an internal share.  
  
 `update`  
  
 Specifies whether Setup will look for, download, and apply updates for [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)]. We recommend that you let Setup download the latest version by selecting **true**. By default, this value is set to **false**. If the value is set to **false**, Setup will ignore this step and continue with the installation.  
  
 `<configdbserver>SQLServerName\Instancename</configdbserver>`  
 Specifies the instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] that stores the configuration database. If you specify the default instance, use *SQLServerName*, or if you use a named instance use *SQLServerName\InstanceName*.  
  
 `<muoptin optin="true”/“false" />`  
 Specifies whether to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] to download and install updates for [!INCLUDE[pn_Microsoft_Dynamics_CRM_Reporting_Extensions_legacy](../includes/pn-microsoft-dynamics-crm-reporting-extensions-legacy.md)]. After the installation is completed, this feature helps keep your computer up-to-date on an ongoing basis.  
  
-   **True**. When you specify this option, Setup will opt in to [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] as the update service and use the Windows automatic updating settings on the computer. Windows automatic update settings can be viewed in [!INCLUDE[pn_ms_Windows_Update](../includes/pn-ms-windows-update.md)] in [!INCLUDE[pn_Control_Panel](../includes/pn-control-panel.md)]. [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] helps make sure that your computer has the latest technology, which can help reduce the risk of vulnerabilities and security issues.  
  
-   **False**. When you specify this option, Setup won’t change the existing Windows automatic update settings. If the computer isn’t already configured to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] as the update service, we recommend that you have another method to install updates on the computer, such as by using [!INCLUDE[pn_ms_Windows_Update_Srvcs_short](../includes/pn-ms-windows-update-srvcs-short.md)]. If left blank, a value of **false** will be selected.  
  
 `<InstallDir>c:\program files\Microsoft Dynamics CRM Reporting Extensions</InstallDir>`  
 Specifies the folder in which the Dynamics 365 Reporting Extensions files will be copied. The default location is c:\program files\Microsoft Dynamics CRM Reporting Extensions.  
  
 `<autogroupmanagementoff>1/0</autogroupmanagementoff>`  
 If \<**automanagegroupsoff**> is **1** (true), Setup will not add or remove any members to the security group in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service. Therefore, you must manually add the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] service account for the associated instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] to the **PrivReportingGroup** security group.  
  
## See Also  
 [Install Microsoft Dynamics 365 Reporting Extensions](install-dynamics-365-reporting-extensions-command.md) </br>  
 [Sample Microsoft Dynamics 365 Reporting Extensions XML configuration file](sample-dynamics-365-reporting-extensions-xml-config-file.md)

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]