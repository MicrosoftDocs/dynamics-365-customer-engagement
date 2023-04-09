---
title: "System requirements, limits, and configuration values for Dynamics 365 App for Outlook | MicrosoftDocs"
ms.custom: 
description: System requirements, limits, and configuration values for Dynamics 365 App for Outlook.
ms.date: 11/02/2022
ms.reviewer: jimholtz
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: Dynamics 365 apps
caps.latest.revision: 1
author: sidhartg
ms.author: sidhartg
search.audienceType: 
  - admin
  - customizer
---


# System requirements, limits, and configuration values for Dynamics 365 App for Outlook


This topic contains requirements, limits, and configuration values for Dynamics 365 App for Outlook.

> [!IMPORTANT] 
> Following the [end of support for Internet Explorer and Microsoft Edge legacy](/power-platform/admin/support-end-internet-explorer), Dynamics 365 App for Outlook is not supported on versions of Microsoft Outlook that use Internet Explorer or Legacy Edge WebView. 


## Email

 | **Server/client type** | **Supported version** |
|---------|---------|
|**Email Server**     |  <ul><li>Exchange Server 2013 CU 14 or greater</li><br/><li>Exchange Server 2016</li><br/> <li>Exchange Server 2019</li><br/><li>Exchange Online</li></ul>       |
|**Email Client**     |  <ul><li>All Microsoft Outlook desktop clients on Windows that use [Edge WebView2](/office/dev/add-ins/concepts/browsers-used-by-office-web-add-ins#microsoft-365-subscription-versions-of-office-on-windows) </li><br/>  <li>Outlook for MAC</li><br/> <li>Outlook for iOS (with Exchange Online, on Apple iPhone 6S or higher, running iOS version 8 or higher)</li><br/>  <li>Outlook for Android (with Exchange Online, on Android phones running Android 4.4,5.0,6.0, or 7.0)</li></ul>  **Note** Support for 2013 versions of Microsoft 365 ProPlus ended February 28, 2017        |
|**Browser (Outlook Web Access)**     | <li>Microsoft Edge (with Exchange on premise 2016 or higher and Exchange Online)</li><br/> <li>Google Chrome (Compose mode supported with Exchange on premise 2016 or higher and Exchange Online)</li><br/>   <li>Mozilla Firefox (Compose mode supported with Exchange on premise 2016 or higher and Exchange Online)</li><br/>      |




## Supported configurations with Microsoft Exchange  

 As of the [!INCLUDE[pn_crm_8_2_0_both](../includes/pn-crm-8-2-0-both.md)] you can use the app with any combination of [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] or [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-onprem.md)] and [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)] or [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] (on-premises), including hybrid configurations. This means you can use [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] in any of the following configurations:  


|       **App**                                                                    |    **Microsoft Exchange configuration**                                                                                                                                                                            |
|---------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] |                                                       [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)]                                                        |
| [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] | [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] (on-premises), version 15.0.1236.3.32 (Cumulative Update 14 for Exchange Server 2013) or greater |
|        [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-onprem.md)]        | [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] (on-premises), version 15.0.1236.3.32 (Cumulative Update 14 for Exchange Server 2013) or greater |
|        [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-onprem.md)]        |                                                       [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)]                                                        |



## Supported servers  
 The [server requirements for using Office Add-ins](/office/dev/add-ins/concepts/requirements-for-running-office-add-ins#server-requirements) are [!INCLUDE[pn_Exchange_Server_2013_short](../includes/pn-exchange-server-2013-short.md)], [!INCLUDE[pn_exchange_server_2016_short](../includes/pn-exchange-server-2016-short.md)], or [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)].  

## Supported languages  
[!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] supports the following languages:  

| &nbsp;| &nbsp;| &nbsp;|  
|-|-|-|  
|Bulgarian (Bulgaria) - 1026|Hebrew - 1037|Portuguese (Brazil) - 1046|  
|Chinese (People's Republic of China) - 2052|Hindi (India) - 1081|Portuguese (Portugal) - 2070|  
|Chinese (Taiwan) - 1028|Hungarian - 1038|Romanian - 1048|  
|Croatian (Croatia) - 1050|Indonesian - 1057|Russian - 1049|  
|Czech (Czech Republic) - 1029|Italian - 1040|Serbian - 2074|  
|Danish - 1030|Japanese - 1041|Slovak - 1051|  
|Dutch - 1043|Kazakh - 1087|Slovenian - 1060|  
|English - 1033|Korean - 1042|Spanish - 3082|  
|Estonian - 1061|Latvian - 1062|Swedish - 1053|  
|Finnish - 1035|Lithuanian - 1063|Thai - 1054|  
|French - 1036|Malaysian - 1086|Turkish - 1055|  
|German - 1031|Norwegian - 1044|Ukrainian - 1058|  
|Greek - 1032|Polish - 1045|Vietnamese - 1066|  

## Synchronization and tracking 

The Dynamics 365 App for Outlook tracks and synchronizes your mail and calendar data between Outlook (Exchange) and Dynamics 365 apps. Server-side synchronization is an asynchronous service that runs in the background approximately every 15 minutes to synchronize items between Exchange and Dynamics 365 apps. In most scenarios, the Outlook item is immediately created in Dynamics 365 apps. However, in some cases, server-side synchronization service is used to promote the item to Dynamics 365 apps and keep it synchronized, which may take up to 15 minutes. The below table provides a brief explainer of the behavior.

In most cases items are immediately tracked, aside from when an email is in compose mode and recurring appointments.

   > [!NOTE]
   > Server-side synchronization is used to promote emails when Microsoft Outlook includes images in email signatures as attachments.

If the Dynamics 365 App for Outlook uses Server-side synchronization to track an item to Dynamics 365 apps, the track status of the item will be “Pending”.

![Outlook app Server-side synchronization.](media/Outlook_app_server_side_sync.png "Outlook app server side sync")

   > [!NOTE]
   > For manually tracked items, App for Outlook only synchronizes pre-definded fields between Outlook (Exchange) and Dynamics 365 apps. Any [Field level synchronization settings](/power-platform/admin/what-fields-synchronized-outlook) will have no effect while tracking the items manually from App for Outlook.

## Things to know

- The latest release of [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)] works with customer engagement apps in Dynamics 365 (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation), [Dynamics 365 Customer Engagement (on-premises), version 9](../customerengagement/on-premises/overview.md), and [Microsoft Dataverse](/powerapps/maker/common-data-service/data-platform-intro).
- App for Outlook uses Microsoft Edge browser when you are using Windows 10 (version 1903 or later) OS and Outlook Click-2-Run client that’s updated to the current channel, Monthly Enterprise channel, or Semi-annual Enterprise channel (16.0.13127.20508 or later). For other combination of Windows and Outlook, App for Outlook uses Microsoft Internet Explorer browser.
- Multi-factor authentication with [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] and Server Side Synchronization is supported only in an online-only configuration. It is not a supported scenario for Dynamics 365 Customer Engagement (on-premises) or Microsoft Exchange on-premises.
-  [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] is not supported on [Microsoft 365 shared mailbox](https://support.office.com/article/open-and-use-a-shared-mailbox-in-outlook-d94a8e9e-21f1-4240-808b-de9c9c088afd).
- [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] is not supported in configurations that have Dynamics 365 apps and Microsoft 365 (Exchange Online) in different tenants.
- Windows 7 had reached [end of life](https://www.microsoft.com/en-us/windows/windows-7-end-of-life-support-information) and is no longer a supported client OS for Dynamics 365 App for Outlook.











