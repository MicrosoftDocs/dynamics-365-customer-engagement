---
title: "Install Dynamics 365 for Outlook | MicrosoftDocs"
description: How to install Dynamics 365 for Outlook
ms.custom:
ms.date: 10/01/2020
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 7e846aff-e472-4a3a-810d-de2aea0817f0
caps.latest.revision: 63
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
# Install Dynamics 365 for Outlook
To set up [!INCLUDE[pn_crm_for_outlook_full](../../includes/pn-crm-for-outlook-full.md)] on a user’s computer, you need to install the software, and then configure it. This topic describes how to set up and configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], and also how to enable multi-factor authentication (MFA) through OAuth. Using MFA can help make client authentication more secure, especially for mobile users.

 For information about installing [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] at a command prompt (silent installation), see [Install Microsoft Dynamics 365 for Outlook using a Command Prompt](install-using-command-prompt.md).

 For information about installing [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] using System Center Configuration Manager (SCCM), see the download [Use SCCM to install Dynamics 365 for Outlook](https://download.microsoft.com/download/2/C/0/2C0AB67B-8B6F-4EF1-95C3-8DAEAD6E2FAE/Use_SCCM_to_install_Dynamics_365_for_Outlook.pdf).

> [!IMPORTANT]
> - You can’t install  [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] on a computer running [!INCLUDE[pn_Exchange_Server_full](../../includes/pn-exchange-server-full.md)].
> - Tracking activities is not supported when [!INCLUDE[pn_crm_app_for_outlook_short](../../includes/pn-crm-app-for-outlook-short.md)] and [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)] are used together by the same user.

<a name="BKMK_Task1_Install_CRMForOutlook"></a>
## Install Dynamics 365 for Outlook
 You can add offline capability for the user either during this installation or at a later time.

> [!TIP]
>  If you encounter an issue installing, connecting, or enabling [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] with your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] organization, use the [Microsoft Support and Recovery Assistant](https://aka.ms/crmocpub) to diagnose and fix the issue. You’ll need to sign in to the diagnostics tool with your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] credentials.

1. Meet the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] requirements specified in [Microsoft Dynamics 365 for Outlook hardware requirements](hardware-requirements.md) and [Dynamics 365 for Outlook support matrixes](support.md).
2. Log on to the computer as a local administrator.

3. Make sure that the latest [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] updates are installed, including all security updates. To verify, visit [Microsoft Update](https://go.microsoft.com/fwlink/p/?LinkId=165705).

4. Locate and run the appropriate installation file by choosing one of the following methods:

   - To install from the web (version 8.x), go to [Microsoft Dynamics CRM 2016 for Microsoft Office Outlook (Outlook Client)](https://go.microsoft.com/fwlink/p/?LinkId=690396), and then download and run the executable file that matches the installed [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] architecture.

   - To install from the web (version 9.0), go to [Dynamics 365 apps  for Outlook, version 9.0 (Outlook client)](https://www.microsoft.com/en-us/download/details.aspx?id=56972), and then download and run the executable file that matches the installed [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] architecture. 

     > [!NOTE]
     >  If you have updated your Dynamics 365 apps  organziation to version 9.0 and the Dynamics 365 for Outlook client does not connect then you may need to install TLS 1.2. For more information, [Install TLS](https://support.microsoft.com/help/4054414/dynamics-365-for-outlook-update-for-version-9-0).


~~~
-   To install from a DVD, double-click **SetupClient.exe** in the installation folder for the architecture (32-bit or 64-bit) of [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] that you’ve installed:

    -   ... \Client\amd64 for 64-bit

    -   ... \Client\i386 for 32-bit

-   To install from the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] web application:

    1.  Click the **Settings** button ![Settings button](../media/mp-ua-r16-settings.png "Settings button"), and then click **Apps for Dynamics 365 apps**.  

    2.  On the **Apps for Dynamics 365 apps** page, click **Download from [!INCLUDE[cc_Microsoft](../../includes/cc-microsoft.md)] Download Center**.  

    3.  If you see any dialog boxes titled **Security Warning**, click **Run** in each.

     The **Microsoft Dynamics 365 apps for Microsoft Office Outlook Setup** wizard starts.  
~~~

5. On the **License Agreement** page, review the information. If you accept the license agreement, select **I accept the license agreement**, and then click **Next**.

6. If the **Get Recommended Updates** page appears, indicate whether you want to obtain updates through the [!INCLUDE[pn_Microsoft_Update](../../includes/pn-microsoft-update.md)] program, and then click **Next**.

   > [!NOTE]
   >  Microsoft releases improvements to [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] as software updates. If you click **Get Recommended Updates**, those updates will be installed automatically. The exact level of automation, for example, whether any user interaction is required during the installation, is determined by the group policy of your organization.

7. Click **Install Now** or **Options**.

   - To install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] with offline capability, click **Options**, select **Offline Capability** on the **Customize Installation** page, and then click **Install Now**. Although offline capability lets you run [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] without a network or Internet connection, it does require the installation of additional technologies and places more demand on your computer’s processor and memory. For more information about the minimum recommended requirements, see [Microsoft Dynamics 365 for Outlook hardware requirements](hardware-requirements.md).

   - To install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] without offline capability, click **Install Now**.

   > [!IMPORTANT]
   >  If you don’t install offline capability at this point, the user will initially have no offline capability. If you click **Install Now**, the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] user can add offline capability later by clicking **Go Offline** in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].

    The program features are installed and a progress indicator is displayed. You may be asked to restart your computer to complete the installation.

8. On the completion page of the **Microsoft Dynamics 365 apps for Microsoft Office Outlook Setup** wizard, click **Close**.  

<a name="BKMK_Task2_ConfigureCRMforOutlook"></a>
## Configure Dynamics 365 for Outlook
 After [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is installed, it must be configured. When you restart [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] after you’ve installed [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], the configuration wizard starts automatically.

> [!NOTE]
>  If you don’t want to configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] immediately after you install it, click **Cancel**. A **Configure Microsoft Dynamics 365 for Outlook** button then appears on the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] toolbar and will remain there until you configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].  
> 
>  If the wizard doesn’t start automatically, you can start it as follows: On the Start screen, click **Configuration Wizard** or on earlier versions of Windows click **Start** > **All Programs** > **Microsoft Dynamics 365 apps**, and then click **Configuration Wizard**. Alternatively, click **Configure Microsoft Dynamics 365 for Outlook** on the **Dynamics 365 apps** tab in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].  
> 
>  If you encounter an issue configuring [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] with your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] organization, use the [Microsoft Dynamics CRM for Outlook Configuration Diagnostic](https://aka.ms/crmocpub) to fix the issue. You’ll need to sign in to the diagnostics tool with your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] credentials.  

1. To add an organization, choose one of the following:

   - To connect to a [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] organization, choose **Dynamics 365 apps ** from the drop-down list.  

2. Click **Connect**.

    If you are prompted for credentials, select from the following options.

   - For a [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] organization, enter your [!INCLUDE[pn_MS_Online_Services](../../includes/pn-ms-online-services.md)] user name and password, and then click **OK**. This information should have been sent to you in email when your account was added.

3. Click **Close**.

4. If you’re a member of more than one organization, restart the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] to designate a different organization as your current organization.

<a name="BKMK_OAuth"></a>   
## Enable multi-factor authentication through OAuth  
 In the [!INCLUDE[pn_Outlook_Config_Wiz_long](../../includes/pn-outlook-config-wiz-long.md)], System Administrators can enable multi-factor authentication through the OAuth 2.0 Framework. [OAuth 2.0](https://oauth.net/) is an open framework for authorization that lets users provide access tokens, instead of credentials, to access data hosted by a given service provider (such as Dynamics 365 apps). Using MFA can help make client authentication more secure, especially for mobile users. Dynamics 365 apps  versions of [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] can take advantage of MFA.. [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] automatically uses OAuth.  

 If you have upgraded your authentication server to use OAuth **prior** to installing Dynamics 365 for Outlook, Dynamics 365 for Outlook will automatically check for and use OAuth for MFA. Users will see the OAuth sign-in form the first time they use Dynamics 365 for Outlook.

 If you upgrade your authentication server to use OAuth **after** rolling out Dynamics 365 for Outlook, you have two options to set Dynamics 365 for Outlook to use OAuth.

1. Reconfigure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] on all computers. Run the [!INCLUDE[pn_Outlook_Config_Wiz_long](../../includes/pn-outlook-config-wiz-long.md)] and remove and re-add your organization.

    -- OR --

2. Use Group Policy to update the following registration key:

    `HKEY_CURRENT_USER\Software\Microsoft\MSCRMClient\{orgid}.`

    Set `AuthenticationProvider` to 0

    After the registry change, Dynamics 365 for Outlook will automatically check for and use OAuth for MFA.

   **In addition**

   You might need to enable the following  AD FS endpoint: **/adfs/service/trust/13/windowstransport**

   For information on enabling an endpoint, see [Sign in to Microsoft 365, Azure, or Intune fails after you change the federation service endpoint](https://support.microsoft.com/help/2712957/sign-in-to-office-365,-azure,-or-intune-fails-after-you-change-the-federation-service-endpoint).

### See Also
 [Dynamics 365 for Outlook support](support.md)
 [Blog: Microsoft Dynamics CRM for Outlook Configuration Diagnostic](https://go.microsoft.com/fwlink/p/?LinkID=717230)
 [Deploy Microsoft Dynamics 365 for Outlook by using Group Policy](deploy-using-group-policy.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]