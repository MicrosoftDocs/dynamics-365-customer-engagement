---
title: "Install the Unified Service Desk client | MicrosoftDocs"
description: "Learn how to install and upgrade Unified Service Desk client using the Setup Wizard and using the command line."
ms.date: 06/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - admin
ms.custom: evergreen
tags: MigrationHO
---

# Install the Unified Service Desk client

Make sure your computer meets all requirements before you install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Unified Service Desk system requirements](../../unified-service-desk/admin/unified-service-desk-system-requirements.md)

 [Download](../download-unified-service-desk.md) the appropriate [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client setup file (.exe), and save it on your computer:

::: moniker range=">=dynamics-usd-4"

- For a 32-bit version of [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)], download the Dynamics365-USD-4.x.x.xxx-i386.exe file.

- For a 64-bit version of [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)], download the Dynamics365-USD-4.x.x.xxx-amd64.exe file.

::: moniker-end


<a name="BKMK_USDwizard"></a>   

## Install the Unified Service Desk client using the Setup Wizard  
  
1. Sign in as a user with local Administrators group membership, and then double-click the downloaded file to begin the setup.  
  
2. The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client installer starts automatically. If it doesn’t, go to the folder where the extracted installation files are located and run the SetupUnifiedServiceDesk.exe file to start the installation.  
  
3. On the Unified Service Desk screen, keep the default location or enter the complete path where the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application files will be installed, and then select **Next**.  
  
4. On the Unified Service Desk Installation screen, choose from the following options:  
  
   - The [!INCLUDE[pn_Microsoft_.Net_Framework](../../includes/pn-microsoft-net-framework.md)] and [!INCLUDE[pn_Windows_Identity_Foundation](../../includes/pn-windows-identity-foundation.md)] prerequisites. You can’t remove these from the installation if these prerequisites are not already installed.  
  
   - **Unified Service Desk**. Because [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is the core component of setup, you cannot continue unless it is selected.  
  
   - **Create a desktop shortcut for Unified Service Desk**. By default, a shortcut will be created for easy launching of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client from the desktop. 
  
5. Select **Install**.  
  
6. The next screen shows the installation status of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. When you're prompted to authorize the installation (as a result of User Account Control), select **Yes**.  
  
7. A confirmation message appears on successful installation of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. Select **X** to exit the installer or select **Launch** to start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  
  
<a name="BKMK_USDupgrade"></a>   

## Upgrade the Unified Service Desk client using the Setup Wizard  

::: moniker range="=dynamics-usd-4.2"

> [!Important]
> Clear the cache **before and after** you upgrade your Unified Service Desk client. The cache is located at: `%appData%\Roaming\Microsoft\USD`. More information: [Configure client caching](../../unified-service-desk/admin/configure-client-caching-unified-service-desk.md)

::: moniker-end

1. On a computer where a previous version of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is installed, sign in to the computer as a user with local Administrators group membership, and then double-click the SetupUnifiedServiceDesk.exe file to begin the upgrade.  
  
2. When setup detects the previous version of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, you'll see the following information:  
  
   **An older version of Unified Service Desk is already installed on your computer. Setup will upgrade Unified Service Desk on your computer**.  
  
3. Select **Next**.  
  
4. On the Unified Service Desk Upgrade screen, decide if you want to create a shortcut for the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.
  
5. The next screen shows the installation status of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  
  
6. A confirmation message appears on successful upgrade of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. Select **X** to exit the installer or select **Launch** to start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  
  
<a name="BKMK_USDsilent"></a>   

## Install or upgrade the Unified Service Desk client in silent mode  
 When [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] setup runs in silent mode, no user interface (UI) is displayed. Instead, you supply the required information at the command prompt.  
  
> [!NOTE]
> - You may be prompted to supply the information due to the computer’s User Account Control Settings. To suppress this message when setup runs, set the User Account Control Setting to **Never notify**. After setup is complete, we recommend that you set the User Account Control Setting back to the original notification level.  
> - When the [!INCLUDE[pn_NET_Framework](../../includes/pn-net-framework.md)] is installed as part of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client setup, a restart may be required for setup to continue.  
  
### Command line syntax  
 SetupUnifiedServiceDesk.exe [destination] [Shortcut = [y &#124; n]] [/S] [install/uninstall/help]
  
### Parameters  
  
|                   Parameter                    |                                                                                                                                                                                                                                                                                             Description                                                                                                                                                                                                                                                                                              |
|------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| install<br /><br /> uninstall<br /><br /> help | Required parameter that performs one of the following functions depending on which parameter you choose:<br /><br /> -   Install. Installs or, if a previous version exists, upgrades the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.<br />-   Uninstall. Uninstalls the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. This is a maintenance mode option that is only available when the application is already installed.<br />-   Help. Shows information about setup, such as supported parameters and usage. |
|                       /S                       |                                                                                                                                                                                                                                                                                Silent mode. No setup UI is displayed.                                                                                                                                                                                                                                                                                |
|                  destination                   |                                                                                                                                               The folder where the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client files will be installed. By default, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is installed in the c:\program files\Microsoft Dynamics 365 Customer Engagement USD\ folder.                                                                                                                                                |
|            Shortcut = [y &#124; n]             |                                                                                                                                                           Shortcut=y creates a shortcut to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] application on the user’s desktop. If you don’t set this parameter, the shortcut is defaulted to y. When you specify Shortcut=n, a shortcut is not created.                                                                                                                                                            |
|                      help                      |                                                                                                                                                                                                                                                                                  Shows a list of valid parameters.                                                                                                                                                                                                                                                                                   |
  
### Examples  

This example installs or upgrades the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client in silent mode, creates a shortcut on the desktop.
  
```  
SetupUnifiedServiceDesk.exe install Shortcut=y /S  
```  

This example uninstalls the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. Note that no UI displays, even when the /S parameter is not used.  
  
```  
SetupUnifiedServiceDesk.exe uninstall  
```  
  
<a name="BKMK_USDNext"></a>   
## Next Step  

Deploy the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample packages on Microsoft Dataverse. For more information, see [Deploy Unified Service Desk packages to a Dataverse platform using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md).  
  

  
### See also

[Install and deploy Unified Service Desk](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)   
[Update Unified Service Desk](../../unified-service-desk/admin/update-unified-service-desk-solution.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
