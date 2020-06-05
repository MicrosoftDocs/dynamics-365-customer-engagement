---
title: "Set up Dynamics 365 for phones and Dynamics 365 for tablets | MicrosoftDocs"
ms.custom:
ms.date: 06/5/2020
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: get-started-article
applies_to: Dynamics 365 apps
ms.assetid: 7a28ff46-558b-47c5-9c99-073fd6f66844
caps.latest.revision: 141
ms.author: mkaur
author: mduelae
manager: kvivek
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365Sales
---
# Setup overview for mobile apps

Your users can access their data stored in Common Data Service or Dynamics 365 Customer Engagement (on-premises) while they're out in the field by using either of the following apps:  
  
- **[!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)]**: With [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)], you can design your information architecture once and the customizations will automatically flow to all form factors. Much is shared with [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].  
  
  
- **[!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]**: With the same basic features as [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)], tablet users will appreciate the experience optimized for a larger screen.  
    
<a name="BKMK_GetStartedTablets"></a>   
## Get started with [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]  
  
### Requirements  
 For hardware and software requirements for [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)], see [Support for Dynamics 365 for phones and Dynamics 365 for tablets](support-phones-tablets.md).  
  
### Required privileges  
 Both Common Data Service and Dynamics 365 Customer Engagement (on-premises) uses a security privilege, **Dynamics 365 for mobile**, to provide access to [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]. The privilege is pre-configured for Sales roles, but not other security roles, so you may want to add to other roles for your teams.  
  
 Follow these steps to check and assign the security privilege for a security role:  
  
1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2. Select **Security Roles**.  
  
3. Select a security role > **Business Management** tab.  
  
4. In the **Privacy Related Privileges** section, verify that **Dynamics 365 for mobile** is set to **Organization**. If not, select **Dynamics 365 for mobile**.  
  
5. Select **Save and Close** to save the changes to the security role.  
  
6. Send an email to mobile-enabled users to let them know they can download the mobile app from the app store. Include the organization URL and sign-in information in the email.  
  
This applies to new installations of Common Data Service or Dynamics 365 Customer Engagement (on-premises). You can add or remove this privilege from custom or default security roles to meet your business needs. Users who do not have this privilege will see and see an empty app list or the following error: **Contact your administrator for access your organization’s mobile apps**  
> 
> [!NOTE]
> Both Common Data Service and Dynamics 365 Customer Engagement (on-premises) include the ability to audit user access. Audit events are logged if a user accesses your Dynamics 365 apps organization through the Dynamics 365 mobile app. However, there is not a new event type that indicates the access was through the mobile app. The audit login events would appear as **User Access via Web**.  
  
 In addition, particularly if you have created a custom security role, validate that these entities have **Read** permission.  
  
1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2. Click **Security Roles**.  
  
3. Choose a security role > **Customization** tab. Verify that the **Read** permission is set for the following entities:   
  
   -   System Application Metadata  
  
   -   System Form  
  
   -   User Application Metadata  
 
   -   View  
 
   -   Model-driven App

4. Choose a security role > **Business Management** tab. Verify that the **Read** permission is set for the following entity:

   -   User Settings

5. Click **Save and Close** to save the changes to the security role.

### Required services
This list identifies all services to which Dynamics 365 for Phones and Tablets talks and their usages. Your network must **not** block these services.

| Domain(s) | Protocols | Uses |
| --- | --- | --- |
| management.azure.com |https |Between version 13.19022.10 and 13.19081.22, used to fetch the list of apps to populate the app list. |
| api.businessappdiscovery.microsoft.com |https |Starting with version 13.19091.0, used to fetch the list of apps to populate the app list. |

<a name="BKMK_UsersToDo"></a>
## What users need to do

- [Install Dynamics 365 for tablets and phones](https://docs.microsoft.com//dynamics365/mobile-app/install-dynamics-365-for-phones-and-tablets#install-the-app-from-your-devices-app-store)
- [Learn how to use the app](https://docs.microsoft.com/dynamics365/mobile-app/dynamics-365-phones-tablets-users-guide)
 
> [!TIP]
>  Be sure to provide users the URL and credentials they need to sign in.  
  
<a name="BKMK_AdminToDo"></a>   

## What admins need to do  
  
### Security privileges  
 Both Common Data Service and Dynamics 365 Customer Engagement (on-premises) use a security privilege, **Dynamics 365 apps for mobile**, to provides access to [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]. This privilege is pre-configured for Sales roles, but not other security roles, so you may want to add to other roles for your teams. For more information on how to share apps in Common Data Service, see [Share a model-driven app using Power Apps](https://docs.microsoft.com/powerapps/maker/model-driven-apps/share-model-driven-app).
  
### Enable dashboards for Dynamics 365 for phones and Dynamics 365 for tablet users  
 The mobile app has multiple dashboards are available for users. After you set up standard or custom dashboards for mobile access, users can easily modify which dashboards appear and how they appear on their phones or tablets.  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2. Select **Customize the System**.  
  
3. Under Components, select **Dashboards**.  
  
4. Double-click or press and hold the dashboard you want to enable for phone or tablet access.  
  
5. Select **Properties** > **Enable for mobile** > **OK**.  

   > [!div class="mx-imgBorder"] 
   > ![Enable for mobile ](media/mobile_enable_dashboard.png "Select Enable for mobile").

 
6. Select **Save**.  
  
   Show your users how to set and view the enabled dashboards on their phones or tablets. More information: [User Guide for Dynamics 365 for phones and tablets](dynamics-365-phones-tablets-users-guide.md)  
  
   You can assign security roles to a dashboard so the dashboard appears only to users with certain security roles. For example, to set who has access to the Sales Dashboard, click **Settings** > **Customizations** > **Customize the System** > **Components** > **Dashboards**, and then select   the **Sales Dashboard**. Then, click **Enable Security Roles**.  
  
### Update the registry on managed mobile devices  
 If your mobile devices are managed under the control of group policy, the following steps describe what you need to do.  
  
> [!CAUTION]
>  This task contains steps that tell you how to modify the registry. However, because serious problems may occur if you modify the registry incorrectly, it’s important that you follow these steps carefully. For added protection, back up the registry before you modify it. Then, you can restore the registry if a problem occurs. For more information about how to back up and restore the registry, open the following link to view the article in the Microsoft Knowledge Base: [How to back up and restore the registry in Windows](https://support.microsoft.com/kb/322756).  
  
1. If you plan on using group policy to do a domain wide deployment of the registry change and your server is not running [!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)] or later, download and install the [Windows Server Administrative Templates](https://go.microsoft.com/fwlink/p/?LinkId=392790).  
  
2. Open the Group Policy Management Editor.  
  
3. Select an existing policy or create a new policy.  
  
4. Go to **Computer Configuration** > **Policies** > **Administrative Templates** > **Windows Components** > **App runtime** and set **Turn on dynamic Content URI Rules for Windows store apps** to **Enabled**.  
  
5. Click **Show**, and then add the URL for your organization. For example, https://orgname.contoso.com.  
  
6. Close the group policy editor and save your changes.  
  
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [How to update links to external web pages for an enterprise environment](https://go.microsoft.com/fwlink/p/?LinkId=392788) and [Group Policy](https://technet.microsoft.com/windowsserver/bb310732.aspx)  
  
### Update the registry on unmanaged mobile devices using a script  
 If your mobile devices are unmanaged, see the following sample [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] script that shows how to change the registry on each [!INCLUDE[pn_windows_8_1](../includes/pn-windows-8-1.md)] or later device.  
  
```powershell  
  
# *********************************************************  
#   
#    Copyright (c) Microsoft. All rights reserved.  
#    This code is licensed under the Microsoft Limited Public License.  
#    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF  
#    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY  
#    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR  
#    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.  
#   
# *********************************************************  
param([string]$admin)  
  
#Force PowerShell to relaunch in Admin mode  
if($admin -ne 'LaunchingAsAdminNow')   
{  
    $Args = '-ExecutionPolicy Unrestricted -file "' + ((Get-Variable MyInvocation).Value.MyCommand.Path) + '" LaunchingAsAdminNow'  
    $AdminProcess = Start-Process "$PsHome\PowerShell.exe" -Verb RunAs -ArgumentList $Args -PassThru  
}  
else  
{  
    # Create Packages key if it does not exist  
    $packages=Get-Item -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Packages -ErrorAction SilentlyContinue  
    if($packages -eq $null)  
    { New-Item -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies -Name Packages}  
  
    # Create Applications key if it does not exist  
    $apps=Get-Item -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Packages\Applications -ErrorAction SilentlyContinue  
    if($apps -eq $null)  
    { New-Item -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Packages -Name Applications}  
  
    # Add or overwrite EnableDynamicContentUriRules value to 1  
    New-ItemProperty -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Packages\Applications -Name EnableDynamicContentUriRules -PropertyType DWord -Value 1 -force  
  
    # Create ContentUriRules key if it does not exist  
    $rules=Get-Item -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Packages\Applications\ContentUriRules -ErrorAction SilentlyContinue  
    if($rules -eq $null)  
    {New-Item -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Packages\Applications -Name ContentUriRules}  
  
    # Prompt user for the domain uri  
    $domainname = Read-Host 'Please provide the domain uri that you want to add to the allow list(such as https://*.contoso.com:444)'  
  
    # Add uri to the allow list under ContentUriRules  
    $urls=Get-Item -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Packages\Applications\ContentUriRules -ErrorAction SilentlyContinue  
    New-ItemProperty -Path HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Packages\Applications\ContentUriRules -Name ($urls.ValueCount+1) -PropertyType String -Value $domainname -force  
}  
  
```  
  
### Update the registry on unmanaged mobile devices using the Registry Editor  
 If your mobile devices are unmanaged, you can also change the registry on each [!INCLUDE[pn_windows_8_1](../includes/pn-windows-8-1.md)] or later device like this:  
  
1. Start Registry Editor.  
  
2. Before making changes to your registry, make a backup. Click **File** > **Export**, and then enter your settings.  
  
3. Locate the following registry subkey: HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\policies  
  
4. Right-click or tap **policies**, point to **New**, and then click **Key**.  
  
5. Type **Packages**, and then press **ENTER**.  
  
6. Right-click or tap **Packages**, point to **New**, and then click **Key**.  
  
7. Type **Applications**, and then save the text.  
  
8. Right-click or tap **Applications**, point to **New**, and then click **DWORD (32-bit) Value**.  
  
9. Type `EnableDynamicContentUriRules` and then save the text.  
  
10. Right-click or tap **EnableDynamicContentUriRules**, and then click **Modify**.  
  
11. Type **1** in the **Value Data** box, and then click **OK**.  
  
12. Right-click or tap **Applications**, point to **New**, and then click **Key**.  
  
13. Type **ContentUriRules**, and then save the text.  
  
14. Right-click or tap **ContentUriRules**, point to **New**, and then click **String Value**.  
  
15. Type **1**, and then save the text.  
  
16. Right-click or tap **1**, and then click **Modify**.  
  
17. Type your Common Data Service environment's or Dynamics 365 Customer Engagement (on-premises) organization's URL in the **Value Data** box (for example, <https://contoso.com>), and then click **OK**.  
  
18. Exit Registry Editor.  
  
     Now you can point your users to the [!INCLUDE[pn_windows_8_1](../includes/pn-windows-8-1.md)] app, so they can get the added functionality of the offline experience. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install the Dynamics 365 for tablets app](dynamics-365-phones-tablets-users-guide.md)  
  
<a name="BKMK_Configure"></a>   
## Configure the Dynamics 365 mobile app 
 
 - For Dynamics 365 Customer Engagement (on-premises), see [App making and customization overview](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/customize/overview) 
  
### Charts  
 All the charts you can create in the Chart Designer, such as Bar, Line, Pie, and Funnel charts, are viewable in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].  
  
 Some more things to note:  
  
- Open a chart from the Sales Dashboard to get a page with a chart and the records used to generate the chart.  
  
- Choose the chart sections to see the records filtered for that part of the chart.  
  
- Charts are not available offline in the Dynamics 365 mobile app.  
  
- You can add charts to dashboards and chart pages only.  
  
### Forms  
 Forms in the Dynamics 365 mobile app are based on the development principle of “Design once and deploy across clients.” 

|                                                                                                                                               |   |                                                                                                                                                                                                               |
|-----------------------------------------------------------------------------------------------------------------------------------------------|---|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ![Sales form in Dynamics 365 apps](../admin/media/e-microsoft-crm.png "Sales form in Dynamics 365 apps")<br /><br /> Sales Lead form in web application | > | ![Sales form in Dynamics 365 for tablets](../admin/media/g-microsoft-crm.png "Sales form in Dynamics 365 for tablets")<br /><br /> Sales Lead form in [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] |
  
  
 Forms in the Dynamics 365 mobile app use the Main form type. The main form is used by all model-driven apps. This form provides a consistent user experience whether someone is using a web browser or the Dynamics 365 mobile app.
  
 To further simplify forms, you can hide components from appearing in the phone app. You can hide tabs, sections, subgrids, fields, and charts. For example, to hide the Details tab in the Contact form, click **Settings** > **Customizations** > **Customize the System** > **Components** > expand **Entities** > expand the **Contact** entity > **Forms**. Select the **Contact** form, the select **Change Properties** and clear the **Available on phone** check box to hide the Detail tab from appearing on the Contact form for phone users.  
  

   > [!div class="mx-imgBorder"] 
   > ![Available on phone](media/uncheck_for_mobile_app.png "Uncheck Available on phone")

  
<a name="BKMK_PhoneLanguages"></a>   
## Supported languages for [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] 

When the application first loads after installation, it will determine the device language and load the user interface in that language.  Once you sign in and launched an app, the language will be selected based on your personal options or the base language in Common Data Service or Dynamics 365 Customer Engagement (on-premises). If a language is not supported, the user experience will be shown in English. 

 [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] support the following languages:  
  
- Basque (Basque) - 1069  
  
- Bulgarian (Bulgaria) - 1026  
  
- Catalan (Catalan) - 1027  
  
- Chinese (Hong Kong S.A.R.) - 3076  
  
- Chinese (People's Republic of China) - 2052  
  
- Chinese (Simplified) - 2052  
  
- Chinese (Taiwan) - 1028  
  
- Chinese (Traditional) - 1028  
  
- Croatian (Croatia) - 1050  
  
- Czech (Czech Republic) - 1029  
  
- Danish - 1030  
  
- Dutch - 1043  
  
- English - 1033  
  
- Estonian - 1061  
  
- Finnish - 1035  
  
- French - 1036  
  
- Galician  
  
- German - 1031  
  
- Greek - 30  
  
- Hindi (India) - 91  
  
- Hungarian - 36  
  
- Indonesian - 62  
  
- Italian - 1040  
  
- Japanese - 1041  
  
- Kazakh - 705  
  
- Korean - 82  
  
- Latvian - 371  
  
- Lithuanian - 370  
  
- Norwegian - 47  
  
- Polish - 48  
  
- Portuguese (Brazil) - 55  
  
- Portuguese (Portugal) - 2070  
  
- Romanian - 40  
  
- Russian - 7  
  
- Serbian  
  
- Slovak - 421  
  
- Slovenian - 386  
  
- Spanish - 3082  
  
- Swedish - 46  
  
- Thai - 66  
  
- Turkish - 90  
  
- Ukrainian - 380  
  
  
<a name="BKMK_PhoneEntities"></a>   
## Entities and [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]  

 You can enable a limited set of entities for [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]. To see if an entity is enabled or to enable an entity, click **Settings** > **Customizations** > **Customize the System** > **Entities**. Select an entity and scroll down and review the **Outlook & Mobile** settings.  
 
   > [!div class="mx-imgBorder"] 
   > ![Enable mobile entities](media/enable_mobile_entity.png "Enable mobile entities").

Things to note:  
  
- All custom entities can be enabled for [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].  
  
- You can use the Lookup for entities that are not enabled for [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] from a record that is enabled and see the data. However, you won’t be able to edit the entity.  
  
  **Entities that are visible and read/write in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]**  
  
|Entity Name| Visibility Property| Read-only Property|  
|-----------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|  
|Account|Modifiable|Modifiable|  
|Activity|Not modifiable|Not modifiable|  
|Appointment|Modifiable|Modifiable|  
|Case|Modifiable|Modifiable|  
|Competitor|Modifiable|Modifiable|  
|Connection|Not modifiable|Modifiable|  
|Contact|Modifiable|Modifiable|  
|Invoice|Modifiable|Modifiable|  
|Lead|Modifiable|Modifiable|  
|Note|Not modifiable|Not modifiable|  
|Opportunity|Modifiable|Modifiable|  
|Order|Modifiable|Modifiable|  
|Phone Call|Modifiable|Modifiable|  
|Quote|Modifiable|Modifiable|  
|Social Activity|Modifiable|Modifiable|  
|Social Profile|Modifiable|Modifiable|  
|Task|Modifiable|Modifiable|  
  
 **Entities that are visible and read-only in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]**  
  
|Entity Name| Visibility Property| Read-only Property|  
|-----------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|  
|Attachment|Not modifiable|Not modifiable|  
|Email|Modifiable|Not modifiable|  
|Entitlement|Not modifiable|Not modifiable|  
|Knowledge Article|Modifiable|Not modifiable|  
|Price List|Not modifiable|Not modifiable|  
|Product|Modifiable|Not modifiable|  
|Queue|Modifiable|Not modifiable|  
|Sharepoint Document|Not modifiable|Not modifiable|  
|SLA KPI Instance|Not modifiable|Modifiable|  
|Team|Not modifiable|Not modifiable|  
|User|Not modifiable|Not modifiable|  
|Web Resource|Not modifiable|Not modifiable|  
  
<a name="BKMK_PhoneAuth"></a>   
## Authentication and [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]  
 [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] authenticate users with browser-based authentication, which means no credentials are stored on the phone.  
    
<a name="BKMK_SecuringData"></a>   
## Considerations and best practices for securing Dynamics 365 apps data on [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]  
 Consider the following when planning security for [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]:  
  
- **Data transmission**. [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] requires an [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)], so when your organization’s mobile devices synchronize Dynamics 365 apps data with your Common Data Service environment or Dynamics 365 Customer Engagement (on-premises) organization, the data is encrypted with [!INCLUDE[pn_Secure_Sockets_Layer](../includes/pn-secure-sockets-layer.md)].  
  
- **Cached data**. [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] only cache records and lists that you’ve recently accessed in the app. To clear cached data, users can either sign out or reconfigure.

- **Encrypting cached data**. By default data are not encrypted but can be encrypted through several mechanisms:

  - You can use Intune's MDM capabilities to enforce device wide encryption. 
  - The mobile application also implements and enforces Intune's application policies. This allows you to encrypt data at the application level.  
  - You can use BitLocker to encrypt the entire hard drive on a Windows 8 or later device.


<a name="BKMK_OtherFeatures"></a>
## Other features

### Save
 Records are saved in [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] based on how you configured autosave in your organization settings. To view your save settings, click **Settings** > **Administration** > **System Settings** > **General** tab. View the settings under **Select the default save option for forms**.

 If autosave is:

-   Enabled for the organization, changes to forms are saved when users leave forms.

-   Disabled for the organization, users must use the command bar and click **Save** to save form changes.

### Images
 The mobile app honors the server's caching policies and won't store the content locally unless it's permitted to do so by the server.
 
<a name="BKMK_Privacy"></a>
## Privacy notice
 [!INCLUDE[cc_privacy_crm_for_tablets](../includes/cc-privacy-crm-for-tablets.md)]

### See Also
 [Secure and manage Dynamics 365 for phones and tablets](secure-manage-phones-tablets.md)
 [What's supported](support-phones-tablets.md) </br>
 [Troubleshooting](troubleshooting-things-know-about-phones-tablets.md)
 [Install Dynamics 365 for tablets and phones](dynamics-365-phones-tablets-users-guide.md)
 [Dynamics 365 for phones and tablets User's Guide](dynamics-365-phones-tablets-users-guide.md)

