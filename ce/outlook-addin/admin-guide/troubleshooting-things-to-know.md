---
title: "Troubleshooting and things to know about Microsoft Dynamics 365 for Outlook | MicrosoftDocs"
ms.custom:
ms.date: 09/17/2018
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: b61a8103-1686-47ef-ab28-1a547d61f8f8
caps.latest.revision: 80
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
# Troubleshooting and things to know about Microsoft Dynamics 365 for Outlook
This section describes how to troubleshoot [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] installation and upgrade issues.

> [!TIP]
>  If you encounter an issue installing, connecting, or enabling [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] with your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] organization, use the [Microsoft Support and Recovery Assistant](https://aka.ms/crmocpub) to diagnose and fix the issue. You’ll need to sign in to the diagnostics tool with your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] credentials.

<a name="BKMK_Issues"></a>
## Potential issues and resolutions

### Common Data Service

Microsoft Dynamics 365 for Outlook is not enabled on Common Data Service 2.0. 

<a name="BKMK_AssignedTasks"></a>   
### Assigned tasks not updated in Outlook after updated in Dynamics 365 apps  
 Consider the following scenario:  
  
- In [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], User 1 assigns [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] task to User 2.  
  
- In [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], User 2 accepts and tracks the task.  
  
- In [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], User 2 opens the task and makes a change such as changing the subject or marking the task complete.  
  
  Result: for User 1, in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], the task status remains unchanged.  
  
  To force a status change: User 2, in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)], can open the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] task and click **Send Status Report** to update User 1’s [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] with the latest information.  
  
  Enabling the following settings in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] Task options (**Home tab** > **New Items** > **Task** > **Assign Task**) do not impact this issue:  
  
- Keep an updated copy of this task on my task list.  
  
- Send me a status report when this task is complete.  
  
  This is a known issue and is not supported.  
  
### Simultaneous use of [!INCLUDE[pn_crm_app_for_outlook_short](../../includes/pn-crm-app-for-outlook-short.md)] and [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)]  
 Tracking activities is not supported when [!INCLUDE[pn_crm_app_for_outlook_short](../../includes/pn-crm-app-for-outlook-short.md)] and [!INCLUDE[pn_crm_2016_outlook_shortest](../../includes/pn-crm-2016-outlook-shortest.md)] are used together by the same user.  
  
### Some Outlook add-ins can cause issues  
 Some [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] add-ins can cause issues like connection failure and slow program startup and might be incompatible with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. Try disabling suspect add-ins to see if that resolves your issue.  
  
### Problem when using a proxy auto-config (PAC) file  
 [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] might have authentication and connection issues when using a proxy PAC file configured in workstation browsers. 
  
### Can’t add a related record type when offline  
 If you’re offline, you can’t add a related record type by using the **Add** button (+). Add the related record type while you’re online, and then go offline.  
  
### Inserted picture replaced by text after sync  
 Inserting a picture from a file into an appointment is not supported.  
  
### Some fields synchronize data when an activity is created despite synchronization settings  
 When an activity is created, such as a task, some fields may synchronize even if field synchronization is set to not sync. This is a known issue as some fields cannot have an empty value.  
  
### Users in a different domain cannot install Dynamics 365 for Outlook  
 If the user domain account is in a domain different from the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] organization, the user will receive an error message (see below) when installing [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. This is not a supported scenario.  
  
 **Error message**  
  
 There is a problem communicating with the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] server. The server might be unavailable. Try again later. If the problem persists, contact your system administrator.  
  
 The caller was not authenticated by the service.  
  
### Synchronization support for Cached Exchange Mode  
 [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] synchronization is not supported if Cached Exchange Mode is turned off in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].  See: [Turn on Cached Exchange Mode](https://office.microsoft.com/outlook-help/turn-on-cached-exchange-mode-HA102809573.aspx)  
  
 Server-side synchronization is supported if Cached Exchange Mode is turned off in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)]. See: [Turn on Cached Exchange Mode](https://office.microsoft.com/outlook-help/turn-on-cached-exchange-mode-HA102809573.aspx)  
  
### Automatic email tagging off by default  
 This setting is in the Microsoft Dynamics 365 apps Diagnostics tool included with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. Click **Start** > **All Programs** > **Microsoft Dynamics 365 apps** > **Diagnostics** > **Synchronization Troubleshooting** tab.  
  
 Automatic email tagging is set to be off by default. If you enable this setting but reinstall [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], automatic email tagging will be off.  
  
### Service Appointments and Activities don’t synchronize from Outlook to Dynamics 365 apps  
 Changes made to Service Appointments and Activities in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] will update in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] when you synchronize, but the reverse is not true. When you make changes to Service Appointments or Activities in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], the changes are not synchronized to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].  
  
### Different time value in date and time fields with User Local or Time-Zone Independent behavior  
 If you have system out-of-the box or custom date and time fields with User Local or Time-Zone Independent behavior, the date/time information for years before 1900 won’t display as entered when viewing in the list of records and reading pane in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. The date and time values are correct in the database and will appear as expected in the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] web application.  
  
<a name="BKMK_OnlineandO365"></a>   
## Microsoft Dynamics 365 apps  with Microsoft 365  
 When you try to connect to an organization that is part of your [!INCLUDE[pn_MS_Office_365](../../includes/pn-ms-office-365.md)] subscription by using the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] or [!INCLUDE[pn_oc_online_short](../../includes/pn-oc-online-short.md)], you cannot connect. To resolve this issue, verify, and if necessary, correct the following:  
  
- Make sure that you can connect to the organization by using [!INCLUDE[pn_Internet_Explorer](../../includes/pn-internet-explorer.md)]. There may be incomplete information with your [!INCLUDE[pn_MS_Online_Services](../../includes/pn-ms-online-services.md)] account that is preventing you from authenticating with the service. The URL for the organization is provided in the invitation email message you should have received from [!INCLUDE[pn_MS_Online_Services](../../includes/pn-ms-online-services.md)], and is typically in the form of https://<em>OrganizationName</em>.onmicrosoft.com or https://<em>OrganizationName</em>.crm.dynamics.com. If you are not certain of the URL, contact your system administrator  
  
<a name="BKMK_OCLogfiles"></a>   
## Log files  
 When you install and configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], the system creates log files that you can use for troubleshooting.  
  
 By default, the location of the Setup log files (including crmsetup.log and crm60clientmsi.log files), where User is the account of the user who ran Setup, is as follows:  
  
- [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)], [!INCLUDE[pn_windows8](../../includes/pn-windows8.md)], and [!INCLUDE[pn_Windows_7](../../includes/pn-windows-7.md)]: `SystemDrive`:\Users\\<User\>\AppData\Local\Microsoft\MSCRM\Logs  
  
  By default, the location of the configuration log files (including crm50clientconfig.log), where User is the account of the user who ran Configuration Wizard, is as follows:  
  
- [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)], [!INCLUDE[pn_windows8](../../includes/pn-windows8.md)], and [!INCLUDE[pn_Windows_7](../../includes/pn-windows-7.md)]: `SystemDrive`:\Users\\<User\>\AppData\Local\Microsoft\MSCRM\Logs  
  
> [!IMPORTANT]
>  By default, the AppData folder is hidden. To view the AppData folder, use **Folder Options** in **[!INCLUDE[pn_Control_Panel](../../includes/pn-control-panel.md)]** to enable viewing for hidden files and folders.
>
> [!TIP]
>  You can use the shortcut path to access the AppData folder, %LocalAppData%\Microsoft\MSCRM\Logs.  
  
<a name="BKMK_OCEvents"></a>   
## Event Viewer  
 To access event logging information for [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], open [!INCLUDE[pn_Event_Viewer](../../includes/pn-event-viewer.md)] from the client computer where [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is installed, and then view the entries in the Application log.  
  
 To view the Application log in [!INCLUDE[pn_Event_Viewer](../../includes/pn-event-viewer.md)]:  
  
1. On the computer where [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is installed, start [!INCLUDE[pn_Event_Viewer](../../includes/pn-event-viewer.md)].  
  
2. In the navigation pane, expand **Windows Logs** and then click **Application**.  
  
3. To make it easier to locate events that apply to [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], use **Create Custom View** or **Filter Current Log** and then select the following **Event sources**:  
  
   -   Event sources that begin with MSCRM (such as MSCRMAddin and MSCRMAddressBook)  
  
   -   MSSQL$Dynamics 365 apps  
  
<a name="BKMK_OC_disableButton"></a>   
## Disable the Dynamics 365 for Outlook notification bar on the Web application  
 By default, if a user does not have [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] installed and configured, the Microsoft Dynamics 365 apps web application displays a **Get Dynamics 365 for Outlook** button on the notification bar. This button provides a link for users to download and install software features that configure a local [!INCLUDE[pn_ms_SQL_Server_Express_long](../../includes/pn-ms-sql-server-express-long.md)] data store. If you do not want users to have this capability, you can remove the button.  
  
### Remove the Get Dynamics 365 for Outlook button from the Microsoft Dynamics 365 apps web application  
  
1. With a security role that has read and write permissions (for example, the System Administrator role), start the Microsoft Dynamics 365 apps web application.  
  
2. [!INCLUDE[proc_settings_administration](../../includes/proc-settings-administration.md)]  
  
3. Click **System Settings**.  
  
4. Click the **Outlook** tab.  
  
5. Set the value for **Users see “Get Dynamics 365 for Outlook” option displayed in the message bar** to **No**.  
  
6. Click **OK** to close System Settings.  
  
### See Also  
 [Blog: Microsoft Dynamics CRM for Outlook Configuration Diagnostic](https://go.microsoft.com/fwlink/p/?LinkID=717230)   
 [Troubleshooting and monitoring server-side synchronization](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn850386(v=crm.8))


[!INCLUDE[footer-include](../../includes/footer-banner.md)]