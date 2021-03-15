---
title: "Microsoft Dynamics 365 Server installation | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8a64a413-857f-40bd-b12b-f2c3fd68c591
caps.latest.revision: 20
author: Mattp123
ms.author: matp
manager: kvivek
---
# Microsoft Dynamics 365 Server installation

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

This section covers procedures to install [!INCLUDE [pn-microsoftcrm-server](../includes/pn-microsoftcrm-server.md)] on a computer that doesn’t already have [!INCLUDE [pn-microsoftcrm-server](../includes/pn-microsoftcrm-server.md)] installed.  
  
### Install Microsoft Dynamics 365 Server  
  
1.  Verify that you have completed the necessary planning and that you have the required hardware and software components installed and running. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Planning your deployment of Microsoft Dynamics 365 Customer Engagement (on-premises)](planning-your-deployment-of-microsoft-dynamics-365.md)  
  
2.  Make sure that you have the appropriate permissions to run [!INCLUDE [pn-microsoftcrm-server](../includes/pn-microsoftcrm-server.md)] [!INCLUDE[pn_Setup](../includes/pn-setup.md)]. <!-- [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Minimum permissions required for Microsoft Dynamics 365 Customer Engagement (on-premises) Setup and services](security-considerations-for-microsoft-dynamics-365.md#BKMK_MinimumPermissions) -->
  
3.  Run [!INCLUDE [pn-microsoftcrm-server](../includes/pn-microsoftcrm-server.md)] [!INCLUDE[pn_Setup](../includes/pn-setup.md)].  
  
4.  On a server that has [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)], run [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] [!INCLUDE[pn_Setup](../includes/pn-setup.md)].  
  
5.  If you want to configure [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for internet access, run the Set-CRMSettings ClaimsSettings and Set-CRMSettings IfdSettings [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] commands. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Dynamics 365 Customer Engagement (on-premises) PowerShell Reference](/powershell/dynamics365/customer-engagement/overview)  
  
     Alternatively, start [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] and run the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] and then the [!INCLUDE[pn_Internet_Facing_Deployment_Configuration_Wizard](../includes/pn-internet-facing-deployment-configuration-wizard.md)].  
  
6.  If one or more [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users will need email routing, configure server-side synchronization to enable tracking. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Integrate your email system with Microsoft Dynamics 365 Customer Engagement (on-premises)](../admin/integrate-synchronize-your-email-system.md)  
  
## Dynamics CRM 365 files  
 The following table lists the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] installation files to use and their location once the download package is extracted.  
  
|Setup file|Location|  
|----------------|--------------|  
|**SetupServer.exe** for installing [!INCLUDE [pn-crm-2016-server](../includes/pn-crm-2016-server.md)] |..\Server\amd64|  
|**SetupSrsDataConnector.exe** for installing [!INCLUDE [pn-crm-reporting-extensions-server-side](../includes/pn-crm-reporting-extensions-server-side.md)] |..\Server\amd64\SrsDataConnector|  
|**SetupBIDSExtensions.exe** for installing the [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)]. This is an optional feature that can be installed on a computer that has [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] for creating and customizing Fetch-based reports|..\BIDSExtensions\i386|  
|**Setupclient.exe** for installing [!INCLUDE [pn-crm-for-outlook-full](../includes/pn-crm-for-outlook-full.md)]. This is an optional feature that integrates Dynamics 365 Customer Engagement (on-premises) with Office Outlook. | ..\Client\amd64 for 64-bit<br /> ..\Client\i386 for 32-bit|  
<!-- |**SetupEmailRouter.exe** for [!INCLUDE[pn_CRM_E-Mail_Router](../includes/pn-crm-e-mail-router.md)]|-   ..\EmailRouter\amd64 for 64-bit<br />-   ..\EmailRouter\i386 for 32-bit|  -->
 
  
## See also  
 [Install or upgrade Dynamics 365 Server](install-or-upgrade-microsoft-dynamics-365-server.md) </br>  
 <!-- [Upgrading Microsoft Dynamics CRM Server](upgrading-microsoft-dynamics-crm-server.md) </br> -->
 [Install Dynamics 365 for Outlook](../../../outlook-addin/admin-guide/install.md) </br> 

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]