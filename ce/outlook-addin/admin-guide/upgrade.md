---
title: "Upgrade Microsoft Dynamics CRM for Outlook | MicrosoftDocs"
ms.custom:
ms.date: 01/06/2017
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 65f15bc1-3295-4b62-8cf2-1b3ff65b7064
caps.latest.revision: 64
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
# Upgrade Microsoft Dynamics CRM for Outlook
Follow these steps for a smooth upgrade to [!INCLUDE[pn_crm_2016_outlook](../../includes/pn-crm-2016-outlook.md)].  
  
1. If you're using a version of CRM for Outlook earlier than [!INCLUDE[pn_crm_2015_outlook](../../includes/pn-crm-2015-outlook.md)], uninstall it and [install Dynamics CRM 2016 for Outlook](https://technet.microsoft.com/library/hh699760.aspx). Then do Step 4.  
  
2. Upgrade [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)] to Dynamics CRM 2016 for Outlook.  
  
3. Upgrade Dynamics CRM 2016 for Outlook to December 2016 Update for Dynamics 365 apps (Dynamics 365 for Outlook).  
  
> [!TIP]
>  With all the changes going on with [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] terminology and versions, the following table could  add some clarity.  
  
|Name|What is this?|  
|----------|-------------------|  
|CRM 2015 for Outlook|Version: 07.00.0000.3543.<br /><br /> Published: 11/20/2014.<br /><br /> [Download](https://www.microsoft.com/download/details.aspx?id=45015).<br /><br /> This is a full installation of CRM for Outlook.|  
|CRM 2016 for Outlook|Version: 08.00.0000.1088.<br /><br /> Published: 11/26/2015.<br /><br /> [Download](https://www.microsoft.com/download/details.aspx?id=50370).<br /><br /> This is a full installation of CRM for Outlook.|  
|December 2016 Update for Dynamics 365 apps|Version: 08.02.0000.0749.<br /><br /> Published: 12/16/2016.<br /><br /> [Download](https://www.microsoft.com/download/details.aspx?id=54515).<br /><br /> This is an update for CRM 2016 for Outlook and not a full installation.|  
|Dynamics 365 for Outlook|This is the new name for Dynamics CRM for Outlook.|  
  
<a name="BKMK_Requirements"></a>  
## Microsoft Dynamics CRM for Outlook upgrade requirements  
  
|                                                          Requirement                                                           |                                                                                                                                                                                                                                                                    Description                                                                                                                                                                                                                                                                    |
|--------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Understand [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)] compatibility requirements |                                                                                                               [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)] has a variety of software dependencies that must be understood and adhered to for a successful upgrade. For a current and historical view of these dependencies, see [Dynamics 365 for Outlook support matrixes](support.md)                                                                                                               |
|                                             Use a PC that has sufficient hardware                                              |               For the best performance when you run [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)], make sure your PC is running 64-bit [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)] and 64-bit [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] and has sufficient hard disk and RAM. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Microsoft Dynamics 365 for Outlook hardware requirements](hardware-requirements.md)                |
|                                          Verify that you have appropriate permission                                           |                                                                                                                                                                To install or upgrade [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], you must have local administrator permission on the computer where you perform the installation or upgrade.                                                                                                                                                                |
|                                                      Verify base language                                                      |                                                                                                       To upgrade [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], the base language of [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)] must match the base language of [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)].                                                                                                        |
|       Verify [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)] is in online mode        | You cannot upgrade [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)] when it is in **Go offline** mode. You must bring [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)] online before you can upgrade to [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)]. To check, in [!INCLUDE[pn_crm_2015_outlook](../../includes/pn-crm-2015-outlook.md)]: click **File** > **Dynamics CRM** and verify the tile says **Go Offline**. |
  
<a name="BKMK_Task1"></a>   
## Task 1: Upgrade Dynamics CRM 2015 for Outlook to Dynamics CRM 2016 for Outlook  
 Follow this procedure to upgrade to [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)] on a computer that has [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)] installed.  
  
1. Log on to the computer as a user who has local Administrators group permissions.  
  
2. Best practice: Make sure that all Microsoft Office security updates are installed. To verify, visit [Microsoft Update](https://go.microsoft.com/fwlink/p/?LinkId=165705).  
  
3. Locate and run the appropriate installation file:  
  
   - To install from a DVD, double-click **SetupClient.exe** in the installation folder for the architecture (32-bit or 64-bit) of [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] that you’ve installed:  
  
     -   ... \Client\amd64 for 64-bit  
  
     -   ... \Client\i386 for 32-bit  
  
   - To install from the web, open the [Microsoft Dynamics CRM 2016 for Outlook (Outlook Client)](https://go.microsoft.com/fwlink/p/?LinkID=690396) download page and then download and run the installation package.  
  
   - To install from the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] user interface, click **Get Dynamics 365 for Outlook** on the message bar. If you see any dialog boxes titled **Security Warning**, click **Run** in each.  
  
     The **Microsoft Dynamics 365 for Outlook Setup** wizard starts.  
  
4. On the **License Agreement** page, review the information. If you accept the license agreement, select **I accept the license agreement**, and then click **Next**.  
  
5. On the **Upgrade** page, click **Upgrade Now**.  
  
6. Setup stores your configuration information, installs the program features, and displays a progress indicator. Your configuration information is reapplied in the new installation.  
  
7. On the completion page of the **Microsoft Dynamics 365 for Outlook Setup** wizard, click **Close**.  
  
<a name="BKMK_Task2"></a>   
## Task 2: Update Dynamics 2016 for Outlook  
 Follow this procedure to upgrade [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)] on a computer that has it installed.  
  
1.  Browse to [December 2016 Update for Dynamics 365 apps](https://www.microsoft.com/download/details.aspx?id=54515) and run either the 32-bit (CRM2016-Client-KB3205084-ENU-I386.exe) or 64-bit  (CRM2016-Client-KB3205084-ENU-Amd64.exe) package.  
  
2.  Complete the installation steps and close the program.  
  
<a name="BKMK_Task3"></a>   
## Task 3: Configure Dynamics 365 for Outlook  
 After the upgrade from [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)], [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] attempts to use the configuration information that was used by [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)].  
  
 When your restart [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] after the upgrade of [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], you will know that reconfiguration is necessary if the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] automatically starts.  
  
 If you don’t want to configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] immediately after you install it, click **Cancel** on the **Configure Organization** page of the wizard. A **Configure Microsoft Dynamics 365 for Outlook** button then appears on the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] toolbar and remains there until you configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].  
  
 If the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] doesn’t start automatically, you can start it as described in the following procedure.  
  
### To configure Microsoft Dynamics 365 for Outlook  
  
1. Start the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)]: On the Start screen, click **Configuration Wizard** or on earlier versions of Windows click **Start** > **All Programs** > **Microsoft Dynamics 365 apps** > **Configuration Wizard**. Alternatively, click **Configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]** on the **Dynamics 365 apps** tab in Outlook.  
  
2. Click **Delete** or **Add** to remove or add a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] organization.  
  
3. To add an organization, choose the option appropriate for you.  
  
   - To connect to a [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] organization, choose **Dynamics 365 apps ** from the drop-down menu.  
  
4. Click **Connect**.  
  
    If you are prompted for credentials, select from the following options.  
  
   - For a [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] organization, enter your [!INCLUDE[pn_MS_Online_Services](../../includes/pn-ms-online-services.md)] user name and password, and then click **OK**. This information should have been sent to you in email when your account was added.  
  
5. Click **Close**.  
  
6. If you are a member of more than one organization, restart the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] to designate a different organization as your current organization.  
  
<a name="BKMK_Silent"></a>   
## Silent installation and configuration  
 You use the command prompt to install and configure [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Install Microsoft Dynamics 365 for Outlook using a Command Prompt](install-using-command-prompt.md)  
  
<a name="BKMK_Architecture"></a>   
## Cross-architecture upgrade of Microsoft Dynamics 365 for Outlook  
 If you intend to change to a different architecture (move from 32-bit to 64-bit) while upgrading, note the following:  
  
- **In-place cross-architecture upgrade is not supported**. If you are running [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)] 32-bit, you can perform an in-place upgrade only to 32-bit Dynamics CRM 2016 for Outlook. This also applies to [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)]: If you are running and intend to retain a 32-bit version of [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)], you can upgrade only to 32-bit Dynamics CRM 2016 for Outlook.  
  
- **Cross-architecture upgrade requires uninstalling and reinstalling**. If you have a 64-bit PC running a 64-bit version of [!INCLUDE[pn_ms_Windows_long](../../includes/pn-ms-windows-long.md)], you can change from 32-bit to 64-bit [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)] by performing the following steps in the order listed.  
  
  1. Make sure that your PC has a 64-bit version of Windows. [How to determine whether a computer is running a 32-bit version or 64-bit version of the Windows operating system](https://support.microsoft.com/kb/827218).  
  
  2. Uninstall [!INCLUDE[pn_crm_2015_outlook_shortest](../../includes/pn-crm-2015-outlook-shortest.md)].  
  
  3. Uninstall [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)].  
  
  4. Install a 64-bit edition of [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)].  
  
  5. Install the 64-bit edition of [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)].  
  
  For more information about installing [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)], see [Install Dynamics 365 for Outlook](install.md).  
  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]