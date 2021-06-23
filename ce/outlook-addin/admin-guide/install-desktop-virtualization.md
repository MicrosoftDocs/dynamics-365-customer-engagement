---
title: "Install Microsoft Dynamics 365 for Outlook for desktop virtualization | MicrosoftDocs"
ms.custom: 
ms.date: 11/28/2016
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 4c6960a6-ffe7-478a-88c5-14d4f64f6320
caps.latest.revision: 46
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Install Microsoft Dynamics 365 for Outlook for desktop virtualization
This topic describes how to install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] with roaming user profiles by using [!INCLUDE[pn_Windows_Server](../../includes/pn-windows-server.md)][!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)]. [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)], formerly Terminal Services, is a server role in [!INCLUDE[pn_Windows_Server](../../includes/pn-windows-server.md)] that provides technologies that enable users to access session-based desktops, virtual machine-based desktops, or applications in the data center from both within a corporate network and from the Internet.  
  
<a name="BKMK_OC_roamingprofiles"></a>   
## Roaming user profiles  
 A roaming user profile is a copy of the local user profile that is copied to, and stored on, a server share. The advantage of roaming user profiles is that users do not have to create a profile on each computer that they use on a network. Their profile is downloaded to each computer that they log on to on a network. Changes made to a roaming user profile are synchronized with the server copy of the profile when the user logs off.  
  
 While the roaming user profile moves with the user, software applications such as [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] do not. Identical applications have to be installed on each computer that the user logs on to.  
  
<a name="BMK_OC_RDS"></a>   
## Windows Server Remote Desktop Services  
 [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is supported for running on [!INCLUDE[pn_windowsserver2012](../../includes/pn-windowsserver2012.md)][!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)]. When users run an application on [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)], the application execution occurs on the server. Only keyboard, mouse, and display information are transmitted over the network. Users see only their own individual sessions, which are managed transparently by the server operating system and remain independent of any other client session.  
  
 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Remote Desktop Services](/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/hh831447(v=ws.11))  
  
### Deploy Dynamics 365 for Outlook to use as a Remote Desktop Services application  
 The following is the basic procedure required to deploy [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] to use as a [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)] application.  
  
1. Provide at least one [!INCLUDE[pn_ms_Windows_Server_long](../../includes/pn-ms-windows-server-long.md)] that is running the [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)] server role. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Remote Desktop Services](/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/hh831447(v=ws.11))  
  
2. Install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] using the /disableofflinecapability parameter on the [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)] server. Go offline mode is not supported when [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is installed for [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)] use. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Install Microsoft Dynamics 365 for Outlook using a Command Prompt](install-using-command-prompt.md)  
  
   > [!IMPORTANT]
   >  The [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] offline database is not supported for roaming profile use.  
  
3. Run the [!INCLUDE[pn_Configuration_Wizard_long](../../includes/pn-configuration-wizard-long.md)] on the [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)] server. For instructions, see [Install Dynamics 365 for Outlook](install.md).  
  
4. Disable the [!INCLUDE[pn_Configuration_Wizard_long](../../includes/pn-configuration-wizard-long.md)] on all desktops that will be used to connect to [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)] and run [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. For details, see the section below.  
  
### Disable the Dynamics 365 for Outlook Configuration Wizard  
  
> [!NOTE]
>  The information in this topic applies to [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] deployments that use [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)]. To remove only the **Get Dynamics 365 for Outlook** button for [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] deployments that don’t use [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)], see the “Set whether users see Dynamics 365 for Outlook message” setting in [System Settings dialog box - Outlook tab](/power-platform/admin/system-settings-dialog-box-outlook-tab).
  
 The [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)][!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] starts every time a roaming user connects to a [!INCLUDE[pn_Windows_Server](../../includes/pn-windows-server.md)] that is running [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)]. In addition, users will see the option to configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] when they run [!INCLUDE[pn_MS_Outlook_Full](../../includes/pn-ms-outlook-full.md)].  
  
> [!TIP]
>  Instead of manually creating the registry key as described here, you can use Group Policy or a logon script to create the registry key for the [!INCLUDE[pn_Remote_Desktop_Services](../../includes/pn-remote-desktop-services.md)] users who do not use [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].  
> 
> [!WARNING]
>  [!INCLUDE[cc_RegEdit_warning](../../includes/cc-regedit-warning.md)]  
  
 To disable the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)][!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] and the option to configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], follow these steps on the client computer.  
  
#### Disable the Configuration Wizard  
  
1. On the computer where [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] is installed, start [!INCLUDE[pn_ms_Registry_Editor](../../includes/pn-ms-registry-editor.md)] (regedit.exe).  
  
2. Locate the following registry subkey:  HKEY_CURRENT_USER\Software\Microsoft\Office\Outlook\Addins  
  
3. Right-click **Addins**, point to **New**, and then click **Key**.  
  
4. Type `crmaddin.Addin`, and then press ENTER.  
  
5. Right-click **crmaddin.Addin**, point to **New**, and then click **DWORD Value** or **DWORD (32-bit) Value**.  
  
6. Type `LoadBehavior` and then press ENTER.  
  
7. Right-click **LoadBehavior**, and then click **Modify**.  
  
8. Type `8` in the **Value Data** box, click **Decimal**, and then click **OK**.  
  
9. Exit Registry Editor.  
  
<a name="BKMK_Citrix"></a>   
## Support for Citrix XenApp 6.5 and 7.0-7.18 session virtualization for Microsoft Dynamics 365 for Outlook on a single XenApp instance  
 [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)] will support Citrix XenApp 6.5 and 7.0 -7.18 with session virtualization for [!INCLUDE[pn_crm_2016_outlook](../../includes/pn-crm-2016-outlook.md)] on a single XenApp instance.  
  
 Please note that Citrix deployment may include a complex configuration topology based on other configurations, and these are not supported. For example, these configurations are not supported:  
  
- Citrix products like XenApp (except for versions 6.5 and 7.0-7.18), XenDesktop, and XenServer and versions of these products  
  
- Application streaming modes  
  
- Modes of application deployment  
  
- Application virtualization layered on top of other virtualization technologies (such as Network and storage virtualization technologies)  
  
- Cached Exchange Mode turned off in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] is supported if [!INCLUDE[proc_crm_for_outlook](../../includes/proc-crm-for-outlook.md)] syncs with [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] using server-side synchronization but not supported if [!INCLUDE[proc_crm_for_outlook](../../includes/proc-crm-for-outlook.md)] syncs with [!INCLUDE[proc_crm_for_outlook](../../includes/proc-crm-for-outlook.md)] synchronization. See: [Turn on Cached Exchange Mode](https://support.office.com/article/Turn-on-Cached-Exchange-Mode-7885af08-9a60-4ec3-850a-e221c1ed0c1c?CorrelationId=90246111-3367-4702-a41b-62ab9b65f3f0).  
  
### See Also  
 [Install or upgrade language packs for Microsoft Dynamics 365 apps](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/hh699674(v=crm.8))   
 [Planning and installing Dynamics 365 for Outlook for Microsoft Dynamics 365 apps and Dynamics 365 apps Online](planning-installing.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]