---
title: "Microsoft Dynamics 365 Report Authoring Extension XML configuration file | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 146bfbd7-18e6-498a-9b1a-93fbedc8c2af
caps.latest.revision: 15
ms.author: matp
author: Mattp123
manager: kvivek
---
# Microsoft Dynamics 365 Report Authoring Extension XML configuration file



This topic lists explanations for each XML element and a sample XML file for installing Dynamics 365 [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)]:  
  
 `<CRMSetup> </CRMSetup>`  
 The configuration file must be a valid XML file that uses \<**CRMSetup**> as the root element.  
  
 `<bidsextensions> </bidsextensions>`  
 The configuration file must be a valid XML file that uses **\<bidsextensions>** as the primary element. All the [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)] entries that follow must be within the **\<bidsextensions>** tags  
  
 `<patch update=”true” / ”false” />`  
 Determines the behavior of the update Setup technology. When you specify **True** this feature lets Setup perform a one-time search for, and if applicable, download to apply the latest update files for Dynamics 365 Customer Engagement (on-premises). If you specify **False**, updates will not be applied to Setup.  
  
 `<muoptin optin="true” / “false" />`  
 Specifies whether to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] to download and install updates for [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)]. After the installation is completed, this feature helps keep your computer up-to-date on an ongoing basis.  
  
-   **True**. When you specify this option, Setup will opt in to [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] as the update service and use the Windows automatic updating settings on the computer. Windows automatic update settings can be viewed in Windows Update in [!INCLUDE[pn_Control_Panel](../includes/pn-control-panel.md)]. [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] helps make sure that your computer has the latest technology, which can help reduce the risk of vulnerabilities and security issues.  
  
-   **False**. When you specify this option, Setup will not change the existing Windows automatic update settings. If the computer is not already configured to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] as the update service, we recommend that you have another method to install updates on the computer, such as by using Microsoft Windows Update Services (WSUS). If left blank, a value of `false` will be selected.  
  
 `<InstallDir>c:\program files\Microsoft Dynamics CRM</InstallDir>`  
 Specifies the folder in which application files will be installed. By default, Setup uses the folder C:\Program Files (x86)\Microsoft Dynamics CRM.  
  
 `<InstallType>uninstall/repair</InstallType>`  
 Uninstalls or repairs [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)]. This is a maintenance mode option that is only available when the application is already installed.  
  
 \<InstanceName>InstanceName\</InstanceName>  
 Specifies a named instance of [!INCLUDE[pn_MS_SQL_Server](../includes/pn-ms-sql-server.md)] where to install [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)]. If left blank or not used, [!INCLUDE[pn_Setup](../includes/pn-setup.md)] uses the default instance of [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)].  
  
 `<MonitoringServiceAccount type="DomainUser"/"NetworkService">`   
 `<ServiceAccountLogin>="DomainUser"/"NetworkService"</ServiceAccountLogin>`   
 <`ServiceAccountPassword>password</ServiceAccountPassword>`  
`</MonitoringServiceAccount>`  
 Specifies the service account to use for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Monitoring service.  
  
 Accepted values are *DomainUser*, which will use the specified domain user provided in the \<*prefixServiceAccount*> element or *NetworkService*, which uses the Network Service system account. By default, Setup will use the *DomainUser* option. If *DomainUser* or no type is specified, \<**ServiceAccountLogin**> and \<**ServiceAccountPassword**> are required.  
  
> [!WARNING]
>  Maintaining the configuration file that has \<**ServiceAccountLogin**> and \<**ServiceAccountPassword**> values specified is a security risk because you’re storing a password in plain text. Delete these elements as soon as the configuration file is used to install the application.  
>   
>  We recommend that you specify a different low-privilege user account for each of the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service accounts.  
  
 For information about [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] services, see [Microsoft Dynamics 365 server roles](microsoft-dynamics-365-server-roles.md). For information about the permissions required for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] services and what type of account to use, see [Security considerations for Microsoft Dynamics 365](security-considerations-for-microsoft-dynamics-365.md).  
  
> [!NOTE]
>  [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)] is only available in 32-bit.  
>   
>  [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)] requires [!INCLUDE[pn_sql_server_data_tools_SSDT](../includes/pn-sql-server-data-tools-ssdt.md)]. For more information about the system requirements, see [Microsoft Dynamics 365 Reporting Authoring Extension General Requirements](microsoft-dynamics-365-reporting-requirements.md#report_auth_gen_req).  
  
## See Also  
 [Use command prompt to install the Microsoft Dynamics 365 Report Authoring Extension](install-report-authoring-extension-command-prompt.md) </br>  
 [Install Microsoft Dynamics 365 Reporting Extensions](install-dynamics-365-reporting-extensions-command.md)   </br>
 [Sample Microsoft Dynamics 365 Reporting Extensions XML configuration file](sample-dynamics-365-reporting-extensions-xml-config-file.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]