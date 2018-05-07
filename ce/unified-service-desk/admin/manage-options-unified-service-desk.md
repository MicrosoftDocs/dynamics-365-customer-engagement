---
title: "Manage Options for Unified Service Desk for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: "Learn how to change the global settings in Unified Service Desk for Dynamics 365 Customer Engagement."
ms.custom:
  - dyn365-USD, dyn365-admin
ms.date: 02/06/2018
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: be4effc4-a2a8-414b-87a1-a8b303160bac
author: kabala123
ms.author: kabala
manager: sakudes
tags: 
 - "MigrationHO"
---
# Options for Unified Service Desk
The **Options** setting in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] (**Settings** > **Unified Service Desk** > **Options**) lets you manage global name/value pairs that are used by the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] components.  
  

  
## Manage a [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] option  
 To manage the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] options:  
  
1.  Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]  
  
3.  Choose **Options**.  
  
4.  On the **Active UII Options** page, click **New**.
  
5.  On the **New Option** page, type the option name and corresponding value. Some options are available in the **Global Options** list. Additional global options for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] that aren't displayed in the list and must be entered by the administrator are described in this table.  
  
    |Option Name|Value and Description|  
    |-----------------|---------------------------|  
    |`HideSessionCloseButton`|Set the value to **true** to hide the close button on the session tabs. If you use this option, you should plan to provide a button or some other method to close a session. You may call the **CloseSession** action on the **Session Tabs** hosted control to close the session.|  
    |`CRM UI Base Url`|If the URL for accessing the Dynamics 365 web services is different than the URL for accessing the web UI, you may need to use this option to specify an override. When a user logs in, the system uses the discovery server to determine the web services endpoints but can only imply the URL used for the UI. This option can be used to specify what the URL should be when accessing the GUI.|  
    |`AutoUseExternalBrowser`|If this is set to **true**, the system will use the embedded WPF `WebBrowser` control until the memory reaches a threshold, and then it will switch to launching the browser in an iexplorer.exe process and attach it to the window. **Warning:**  This option is known to have some issues with security. If you want to activate this mode, it should be thoroughly tested in the target environment. This mode is considered unsupported.|  
    |`MemoryLimit`|Specify the value in bytes. This specifies the memory limit that the process can use (working set), before the application refuses to allocate additional browser instances. If this value is specified:<br /><br /> **1.**  The **OutOfMemoryThreshold** option will be ignored.<br />**2.**  If the **AutoUseExternalBrowser** option is true, the value specified in the **MemoryLimit** option will be the memory limit that will trigger the application to launch the browser externally.|  
    |`OutOfMemoryThreshold`|This is a threshold value beyond which the application will refuse to allocate additional browser instances. This value is specified in bytes and is subtracted from the maxworkingset value to determine how much memory is allowed for the process. If the **AutoUseExternalBrowser** option is true, this will be the memory limit that will trigger the application to launch the browser externally.|  
    |`MaxReplacementParameterDepth`|Specifies the depth to which nesting of replacement parameters can be done in an expression. Specify an integer value for this option.<br /><br /> Consider the following example, where you have the following replacement parameters:<br /><br /> `Str3 = "Level 3"`<br /><br /> `Str2 = "Level 2 – [[Str3]v]"`<br /><br /> `Str1 = "TopLevel – [[Str2]v]"`<br /><br /> If you consider, the following expression:<br /><br /> `Value = [[Str1]]`<br /><br /> `Value` would result in `"TopLevel - Level 2 - Level 3"`.<br /><br /> In the above expression, the depth of the nesting of the replacement parameters is **2**.<br /><br /> More information: [Use replacement parameters to configure Unified Service Desk](../../unified-service-desk/use-replacement-parameters-configure-unified-service-desk.md)|  
    |`GenericListener`|Specify a custom URL for the generic listener port. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Change the port of generic listener](../../unified-service-desk/use-generic-listener-adapter-unified-service-desk.md#ChangePort)|  
    |`ShowScriptErrors`|Specify whether to display (`True`) or suppress (`False`) script errors in webpages displayed in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. If you don’t specify the `ShowScriptErrors` option for a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance, the value is assumed to be `False`, which implies that the script errors aren’t displayed in the client application.|  
    |`EntitySearchPageCount`|Specify an integer value to override the default page count (records displayed per page) value of 50 for the [DoSearch](../../unified-service-desk/global-manager-hosted-control.md#DoSearch) action.|  
    |`ClientCacheVersionNumber`|Enables client caching in Unified Service Desk. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure client caching in Unified Service Desk](../../unified-service-desk/admin/configure-client-caching-unified-service-desk.md)|  
    |`maxNumberOfSessions`|Indicates the maximum number of simultaneous sessions that each user can open using Unified Service Desk client. An error message is displayed to the users when they exceed the specified simultaneous session limit. More information: [Session management in Unified Service Desk](../../unified-service-desk/session-management-unified-service-desk.md)|  
    |`ProcessTerminationThreshold`|Indicates the timeout period for the duration (in milliseconds) that the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring process (usdmp.exe) waits before terminating an unresponsive [!INCLUDE[pn_Internet_Explorer](../../includes/pn-internet-explorer.md)] process, which also causes [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to become unresponsive. Valid range is between 0 and 30000. If set to 0,  the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring process will not start and will not monitor [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] for unresponsive behavior. if set to any other value within the range, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] automatically starts the monitoring process.  The default value is 5000 milliseconds (5 seconds). [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [IE Process hosting method](../../unified-service-desk/select-a-hosting-method-for-your-controls.md#IEProcess)|  
    |`HelpImproveUSD`|Enables the organization-wide setting that allows user agents to send improvement program information to Microsoft. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Help improve Unified Service Desk](../../unified-service-desk/admin/help-improve-unified-service-desk.md)|  
    |`IEProcessKeyboardShortcut`|For page and Standard Web Application components that use the IE Process hosting type, users can move out of the current IE Process hosted control by pressing the Alt+0  keys.  If the Alt+0 key combination is assigned as a shortcut in another application, you can use the IEProcessKeyboardShortcut option in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to assign a different key combination for moving out of a IE Process hosted control, such as *Alt+r*. <br/>**Note:**  We recommend that you do not include the CTRL key with the IEProcessKeyBoardShortcut because it can cause unexpected navigation in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client. This is a known issue with   Windows Presentation Foundation.|  
    |`PopupNavigationShortcut`|By default, users press the Alt+1 keys to navigate through all active notifications. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrators can use the `PopupNavigationShortcut` option  to assign a different key combination. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure notifications in Unified Service Desk](../configure-notifications-unified-service-desk.md)|
    |`PanelNavigationShortcut`|By default, users press the Ctrl+0 keys to navigate through all active panels. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrators can use the `PanelNavigationShortcut` option  to assign a different key combination. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Keyboard shortcuts for panels](../keyboard-shortcuts-panels.md)|
    |`IEWebPageRecovery`|Recovers an unresponsive Internet Explorer webpage. By default, the `IEWebPageRecovery` is enabled. Set the value as **false** to disable the `IEWebPageRecovery`. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Recover Internet Explorer process instance](../admin/recover-internet-explorer-process-instance.md)|
    |`IEWebPageInactivityTimeOut`|Indicates the timeout period for the duration (in milliseconds) that the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] waits before displaying a message. The default value is 15000 (15 seconds). If set to 0, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] disables the `IEWebPageInactivityTimeOut`. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Recover Internet Explorer process instance](../admin/recover-internet-explorer-process-instance.md)|
    |`On-DemandIETerminationShortcut`|The keyboard shortcut enables you to terminate an unresponsive Internet Explorer webpage. Default keyboard shortcut is **Ctrl+Alt+K**. To change the default, enter in the form _Key1+Key2+Key3_. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Recover Internet Explorer process instance](../admin/recover-internet-explorer-process-instance.md) </br>**Note:**</br> **1.** The agent must use the keyboard shortcut as last option when the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] monitoring process fails to detect the unresponsive Internet Explorer process instance.</br> **2.** Using the keyboard shortcut may terminate any responsive Internet Explorer webpage, causing you to lose any unsaved work.</br>|
    |`InternetExplorerPooling`|If this is set to **true**, you can experience enhanced performance of CRM entity page loading and faster inline navigation in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. That is, the hosted control uses an Internet Explorer instance from the pool, which performs inline navigation. By default, the `InternetExplorerPooling` is disabled (false). [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Performance enhancement for CRM entity page loads](../admin/performance-enhancement-CRM-entity-page-loads.md)|
    |`TotalRecordCountLimit`|This value is for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to determine the batch size while fetching entity records from [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance. The default value of the `TotalRecordCountLimit` in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and in MSCRM\_CONFIG database is 5000. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure Unified Service Desk entities](../understand-unified-service-desk-concepts.md)</br>**Note:** <br> **1.** `TotalRecordCountLimit` value must be equal to the value in MSCRM\_CONFIG database.<br>**2.** You must not change the default value unless the MSCRM\_CONFIG database administrator changes the value.| 
    |**Others**|This option allows you to type one of the global options listed in this table that does not appear in the **Global Options** list.|
  
6.  Click **Save**.
  
> [!NOTE]
>  Apart from these, the **Options** setting is also used to configure auditing and client caching in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure auditing and diagnostics in Unified Service Desk](../../unified-service-desk/admin/configure-auditing-diagnostics-unified-service-desk.md) and [Configure client caching in Unified Service Desk](../../unified-service-desk/admin/configure-client-caching-unified-service-desk.md)
  
## See also  
 [Configure client caching in Unified Service Desk](../../unified-service-desk/admin/configure-client-caching-unified-service-desk.md)  
  
 [Help improve Unified Service Desk by sending usage data](../../unified-service-desk/admin/help-improve-unified-service-desk.md)

 [Understand Unified Service Desk concepts](../../unified-service-desk/understand-unified-service-desk-concepts.md)
 
 [Performance data collection using keyboard shortcut](../../unified-service-desk/admin/performance-data-collection-using-keyboard-shortcut.md) 

 [Recover Internet Explorer process instance](../admin/recover-internet-explorer-process-instance.md)

 [Performance enhancement for CRM entity page loads](../admin/performance-enhancement-CRM-entity-page-loads.md)

 [Configure Unified Service Desk entities](../understand-unified-service-desk-concepts.md)
