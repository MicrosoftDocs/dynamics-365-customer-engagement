---
title: "Install the Unified Service Desk for Dynamics 365 Customer Engagement client | MicrosoftDocs"
description: "Learn how  to install the Unified Service Desk for Dynamics 365 Customer Engagement client."
ms.custom: ""
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: "usd"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: d1ad62d9-a401-4941-828f-d3b13d80b38d
caps.latest.revision: 24
author: "Mattp123"
ms.author: "matp"
manager: "amyla"
tags: 
 - "MigrationHO"
---
# Installing the Unified Service Desk client
Make sure your computer meets all requirements before you install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Service Desk system requirements](../../unified-service-desk/admin/unified-service-desk-system-requirements.md)  
  
 [Download](../download-unified-service-desk.md) the appropriate [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client setup file (.exe), and save it on your computer:  
  
-   For a 32-bit version of [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)], download the Dynamics365-USD-3.x.x.xxx-i386.exe file.  
  
-   For a 64-bit version of [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)], download the Dynamics365-USD-3.x.x.xxx-amd64.exe file.  
  
  
<a name="BKMK_USDwizard"></a>   
## Install the Unified Service Desk client using the Setup Wizard  
  
1.  Sign in as a user with local Administrators group membership, and then double-click the downloaded file to begin Setup.  
  
2.  The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client installer starts automatically. If it doesn’t, go to the  folder where the extracted installation files are located and run the SetupUnifiedServiceDesk.exe file to start the installation.  
  
3.  On the **Microsoft Dynamics 365 Unified Service Desk** screen, keep the default location or enter the complete path where the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application files will be installed, and then click **Next**.  
  
4.  On the **Microsoft Dynamics 365 Unified Service Desk Installation** screen, choose from the following options:  
  
    -   The [!INCLUDE[pn_Microsoft_.Net_Framework](../../includes/pn-microsoft-net-framework.md)] and [!INCLUDE[pn_Windows_Identity_Foundation](../../includes/pn-windows-identity-foundation.md)] prerequisites. You can’t remove these from the installation if these prerequisites are not already installed.  
  
    - **Unified Service Desk**. Because [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is the core component of setup, you cannot continue unless it is selected.  
  
    - **Create a desktop shortcut for Unified Service Desk**. By default, a shortcut will be created for easy launching of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client from the desktop.  
  
    - **Keep Unified Service Desk up to date with Windows Update**.   We recommend that you select this option to use Windows Update to automatically apply updates to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. This option was first introduced in [!INCLUDE[pn_unified_service_desk_2_1](../../includes/pn-unified-service-desk-2-1.md)] and  you'll see it when the computer where you install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is not already using Windows Update.   For more information about Windows Update, see [Keep your PC up to date](http://go.microsoft.com/fwlink/p/?LinkId=784862). For information about how to fully manage the distribution of updates released through Microsoft Update, see [Windows Server Update Services](https://technet.microsoft.com/library/bb332157.aspx).  
  
5.  Click **Install**.  
  
6.  The next screen shows the installation status of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. When you are prompted to authorize the installation (as a result of User Account Control), click **Yes**.  
  
7.  A confirmation message appears on successful installation of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. Click **X** to exit the installer or click **Launch** to start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  
  
<a name="BKMK_USDupgrade"></a>   
## Upgrade the Unified Service Desk client using the Setup Wizard  
  
1.  On a computer where a previous version of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is installed, sign in to the computer as a user with local Administrators group membership, and then double-click the SetupUnifiedServiceDesk.exe file to begin the upgrade.  
  
2.  When setup detects the previous version of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, you'll see the following information:  
  
 **An older version of Unified Service Desk is already installed on your computer. Setup will upgrade Unified Service Desk on your computer**.  
  
3.  Click **Next**.  
  
4.  On the Unified Service Desk Upgrade screen, decide if you want to create a shortcut for the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. Use Windows Update if the computer is not already set to do so, and then click **Upgrade**.  
  
5.  The next screen shows the installation status of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  
  
6.  A confirmation message appears on successful upgrade of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. Click **X** to exit the installer or click **Launch** to start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  
  
<a name="BKMK_USDsilent"></a>   
## Install or upgrade the Unified Service Desk client in silent mode  
 When [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] setup runs in silent mode, no user interface (UI) is displayed. Instead, you supply the required information at the command prompt.  
  
> [!NOTE]
>  -   You may be prompted to supply the information due to the computer’s User Account Control Settings. To suppress this message when setup runs, set the User Account Control Setting to **Never notify**. After setup is complete, we recommend you set the User Account Control Setting back to the original notification level.  
>  -   When the [!INCLUDE[pn_NET_Framework](../../includes/pn-net-framework.md)] is installed as part of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client setup, a restart may be required for setup to continue.  
  
### Command line syntax  
 SetupUnifiedServiceDesk.exe [destination] [Shortcut = [y &#124; n]] [/S] [install/uninstall/help] [optin = [y &#124; n]]
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|install<br /><br /> uninstall<br /><br /> help|Required parameter that performs one of the following functions depending on which parameter you choose:<br /><br /> -   Install. Installs or, if a previous version exists, upgrades the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.<br />-   Uninstall. Uninstalls the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. This is a maintenance mode option that is only available when the application is already installed.<br />-   Help. Shows information about setup, such as supported parameters and usage.|  
|/S|Silent mode. No setup UI is displayed.| 
|destination|The folder where the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client files will be installed. By default, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is installed in the c:\program files\Microsoft Dynamics 365 USD\ folder.|  
|Shortcut = [y &#124; n]|Shortcut=y creates a shortcut to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] application on the user’s desktop. If you don’t set this parameter, the shortcut is defaulted to y. When you specify Shortcut=n, a shortcut is not created.|
|optin = [y &#124; n]|optin = y uses Windows Update to automatically apply updates to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. If not specified the default is no, which does not use Windows Update for the computer that is not already set to do so.|  
|help|Shows a list of valid parameters.|

<!-- |/M|Manual mode. Minimal UI is displayed for information to be entered only as needed. If setup has enough information to complete the install, no UI will be displayed when using this parameter. You cannot specify both /S and /M.| removed the content for 3.2.0 (kabala)-->
  
### Examples  
 This example installs or upgrades the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client in silent mode, creates a shortcut on the desktop, and uses Windows Update to apply updates to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].  
  
```  
SetupUnifiedServiceDesk.exe install Shortcut=y  optin=y /S  
```  
  
 This example uninstalls the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. Note that no UI displays, even when the /S parameter is not used.  
  
```  
SetupUnifiedServiceDesk.exe uninstall  
```  
  
<a name="BKMK_USDNext"></a>   
## Next Step  
 Deploy the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample packages on the [!INCLUDE[pn_microsoftcrm_server](../../includes/pn-microsoftcrm-server.md)]. For more information, see [Deploy Unified Service Desk packages to Dynamics 365 Server using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md).  
  
<a name="knownissues"></a>   
## Known issues  
  
### Unified Service Desk client setup (SetupUnifiedServiceDesk.exe) hangs after you click Install  
 This can happen when you run setup as a user who does not have local Administrators group membership, using “Run as different user”, and when some Windows User Account Control (UAC) settings have been changed from the default, for example, if the **Admin Approval Mode for the Built-in Administrator account** UAC setting is set to **Disabled** on the local computer where setup runs. By default, Admin Approval Mode for the built-in Administrator account is enabled, but can be disabled through a Group Policy change.  
  
## See also  
 [Install and Deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)   
 [Update Unified Service Desk](../../unified-service-desk/admin/update-unified-service-desk-solution.md)   
 