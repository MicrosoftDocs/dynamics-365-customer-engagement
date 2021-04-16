---
title: "Troubleshooting installation and upgrade | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 593d28ea-fa94-4ced-83e0-f394bc3962cf
caps.latest.revision: 11
ms.author: matp
author: Mattp123
manager: kvivek
---
# Troubleshooting installation and upgrade



This section describes how to troubleshoot installation and known issues.  
  
## Log files  
 Setup creates log files that can be reviewed and used for troubleshooting. The log files are produced in clear unstructured text or xml and can be viewed by a basic text editor, such as [!INCLUDE[pn_Notepad](../includes/pn-notepad.md)]. By default, the location of the log files, where *User* is the account of the user who ran Setup, is as follows:  
  
 SystemDrive:\Users\\*User*\AppData\Roaming\Microsoft\MSCRM\Logs\  
  
> [!IMPORTANT]
>  By default, [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] hides the folders where the log files are located. To view these folders, go to **Folder Options** in Control Panel to change the setting so you can view these folders.  
  
 [!INCLUDE[pn_Microsoft_Dynamics_CRM_Server_Setup](../includes/pn-microsoft-dynamics-crm-server-setup.md)] generates several distinct log files, depending on whether the installation is for a new deployment or an upgrade from a previous version.  
  
-   Crmserversetup.log. The file that contains most of the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] installation or upgrade activity.  
  
-   Crmsetup.log. The file that contains [!INCLUDE[pn_Setup](../includes/pn-setup.md)] update (self-healing Setup) activity.  
  
-   LegacyFeatureCheck.xml. During [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] upgrade, Setup analyzes the deployment for outdated (legacy) customization and extensibility features, such as [!INCLUDE[pn_Microsoft_Dynamics_CRM_4.0](../includes/pn-microsoft-dynamics-crm-4-0.md)] plug-ins or solutions that use the 2007 web services endpoint. This file contains the results.  
  
-   SrsDataConnectorSetup.log. The file that contains most of the [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)] installation activity.  
  
## See Also  
 [Install Microsoft Dynamics 365](install-or-upgrade-microsoft-dynamics-365-server.md) </br>  
 [Install or upgrade language packs for Microsoft Dynamics 365](install-or-upgrade-language-packs.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]