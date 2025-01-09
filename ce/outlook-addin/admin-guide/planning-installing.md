---
title: "Planning and installing Dynamics 365 for Outlook for Microsoft Dynamics 365 apps and Dynamics 365 apps Online | MicrosoftDocs"
description: Learn about planning and installing Dynamics 365 for Outlook to enable user access to Dynamics 365 for Customer Engagement data.
ms.custom: 
ms.date: 12/13/2024
ms.reviewer: smurkute

ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 0e6157ee-a9fc-4da2-8ade-9199a405db05
caps.latest.revision: 40
author: shwetamurkute
ms.author: bharavar
search.audienceType:
  - admin
  - customizer
  - enduser
---
# Planning and installing Dynamics 365 for Outlook for Microsoft Dynamics 365 apps and Dynamics 365 apps Online
[!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] enables access to the same data through [!INCLUDE[pn_MS_Outlook_Short](../../includes/pn-ms-outlook-short.md)] as the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] Web client. [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is for [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] users who need access to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] data while they're using the familiar [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] application.  
  
> [!IMPORTANT]
>  Before you and your users install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], be sure to have completed your desired customizations. In particular, for best performance, you should ensure that you enable only the minimum required entities and views for offline use in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. For more information about customization, see [App making and customization overview](../../customerengagement/on-premises/customize/overview.md). For more information about setting up entities for synchronization, see [Create or edit entities (record types)](../../customerengagement/on-premises/customize/create-edit-entities.md).
>
>  After you install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], you have to set some options so that users can send and receive email from [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] and to specify what data is synchronized.
>
>  [!INCLUDE[cc_Outlook_Offline_LocalAccess](../../includes/cc-outlook-offline-localaccess.md)]

 After you install and configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], an individual user can use it to access [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] data. If a computer is shared by several users (that is, each user has a separate sign in account and is a valid [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] user), you must configure [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] by running [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] configuration for each user.

> [!NOTE]
>  We don't guarantee synchronization will work as expected if Cached [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] Mode is turned off in [!INCLUDE[pn_MS_Outlook_Short](../../includes/pn-ms-outlook-short.md)]. For example, sometimes, tracking email from the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] Search folder gives an error when Cached [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] Mode is off when you set up your [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] email account in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)]. The best practice is to turn on Cached [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] Mode when you set up your [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] email account in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Turn on Cached Exchange Mode](https://support.microsoft.com/en-us/office/turn-on-cached-exchange-mode-7885af08-9a60-4ec3-850a-e221c1ed0c1c)
>
>  To install or upgrade [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], you must have administrator permissions on the computer where you perform the installation or upgrade steps. The exception to this is when you install an update from [Microsoft Update](https://go.microsoft.com/fwlink/p/?LinkId=165705), in which case administrator privileges aren't required. You can install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] with offline capability. A user who has this capability installed can access [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] data when they aren't connected to the LAN. You can add offline capability at either of the following times:
>
> - During installation of [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].
> - After installation has completed. In this case, a user can add offline capability by clicking **Go Offline** in [!INCLUDE[pn_MS_Outlook_Short](../../includes/pn-ms-outlook-short.md)]. This starts the installation of another required components and stores a copy of the user’s [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] data locally. Subsequent offline sessions require no other installations, but might require updating the local copy of the user’s data.
>
> [!NOTE]
>  Although multiple users can share a computer that uses [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], go offline capability isn't supported in a shared computer environment, such as when you use remote desktop services (formerly Terminal Services).  
> 
>  [Using Folder Redirection](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc753996(v=ws.11)) with offline files isn't supported for [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. If the Dynamics 365 apps data is stored with redirected offline files, users might be unable to use [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].  
  
### See Also  
 [Compatibility with Microsoft Dynamics CRM 2016](https://support.microsoft.com/kb/3124955)   
 [Compatibility with Microsoft Dynamics CRM 2015](https://support.microsoft.com/kb/3018360)   
 [Compatibility with Microsoft Dynamics CRM 2013](https://support.microsoft.com/kb/3005167)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
