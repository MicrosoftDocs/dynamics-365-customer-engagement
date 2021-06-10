---
title: "Work offline with Dynamics 365 for Outlook | MicrosoftDocs"
ms.custom: 
ms.date: 09/17/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
  - Dynamics 365 apps (on-premises)
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
  - Dynamics CRM Online
ms.assetid: c97851f5-3063-4318-95fa-1d84c5f898c6
caps.latest.revision: 41
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
# Work offline with Dynamics 365 for Outlook
You can use [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to access your [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] data when you’re on the go. For example, if you travel to a customer’s site, you can look up your Dynamics 365 apps contacts, review and add new notes, and more without connecting to the Internet.  
  
 When you go offline with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], the software copies a subset of [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] data to your computer’s hard drive. Changes you make while you’re offline are stored locally. When you connect to the server again, the changes are automatically synchronized with the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server.  
 
 ### Offline Support

The following operating systems are supported for offline mode.

 ![Offline Support](../media/OfflineSupport.PNG "Offline Support") 
  
<a name="BeforeYouGoOffline"></a>   
## Before you go offline  
 [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] uses offline synchronization filters to determine the subset of data to copy to your local hard drive when you go offline. Before you go offline, you can modify these filters or create new filters to synchronize just the data you need. You can also delete, deactivate, or activate filters. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Choose records to work with offline in Dynamics 365 for Outlook](choose-records-work-offline.md)  
  
> [!TIP]
>  The first time you go offline, it can take a significant amount of time to synchronize your local data with the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server if you have a lot of data. For example, in customer service situations, a parent case may have thousands of child cases. [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] isn’t available when [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is synchronizing. You can shorten the time by using the offline synchronization filters to limit the amount of synchronized data.  
  
<a name="GoOffline"></a>   
## Go offline  
  
- When you’re ready to go offline, in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], choose **File** > **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]** > **Go Offline**.  
  
   When you choose **Go Offline**, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] syncs your data to your local computer using the offline sync filters. When synchronization is complete, you can disconnect your computer from the network.  
  
  > [!TIP]
  >  You can tell if you’re offline by using any of the following indicators:  
  > 
  > - The [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] toolbar displays the **Go Online** button.  
  >   - The [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] menu displays the **Go Online** option.  
  >   - If you’re using [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] 2010 or [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] 2013, the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] tab displays the **Go Online** button.  
  
<a name="GoBackOnline"></a>   
## Go back online  
  
1. Make sure you’re connected to your organization’s network.  
  
2. Choose **File** > **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]** > **Go Online**.  
  
<a name="UnavailableFeatures"></a>   
## What features are unavailable offline?  
  
### Not available offline  
  
-   Assigning records  
  
-   Posts  
  
-   Converting quotes to sales orders  
  
-   Converting sales orders to invoices  
  
-   Managing system administration  
  
-   Updating system configuration  
  
-   Managing service activities  
  
-   Managing services  
  
-   Using the Service calendar and Workplace calendar  
  
-   Editing articles  
  
-   Editing or managing sales literature  
  
-   Changing organizations  
  
-   Sharing records  
  
-   Detecting duplicate records  
  
-   Managing system jobs  
  
-   Running some diagnostic tests  
  
-   Running workflow rules  
  
-   Create quick campaign and related activities from a mail merge  
  
-   Tracking assigned tasks  
  
-   Revise quote functionality  
  
-   Follow or unfollow in the activity feed  
  
-   Custom themes  
  
### Limited availability offline  
  
-   Creating or viewing reports (based on local data groups and offline data)  
  
-   Running some custom business processes (plug-ins)  
  
### Can be viewed, but can’t be edited offline  
  
-   Articles  
  
-   Sales literature  
  
-   Mail-merge templates  
  
<a name="OtherThingsToKnow"></a>   
## Other things to know about going offline  
  
- **Shared use of a computer.** Any users who log on locally to a computer that has [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] installed can potentially access [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] data stored in the offline database. Shared use of a computer running [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is not supported.  
  
- **How [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] handles changes from multiple users.** [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] applies additions and changes to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server in the same order they’re entered. If you make a change to a record while you’re offline, and another user changes the same record during that time, when you go back online, your change will overwrite the changes that the other user made while you were offline.  
  
- **Workflows.** When you work offline, [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] disables workflow notifications. If the changes you make offline are set to trigger an automated workflow process or a system job, the process is automatically triggered when you go back online.  
  
- **Duplicate detection.** [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] disables duplicate detection when you’re offline. Duplicate detection is automatically re-enabled when you go back online. You can set a personal option to determine how duplicate records are handled during synchronization. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Set personal options that affect tracking and synchronization between Dynamics 365 apps and Outlook or Exchange](set-personal-options-affect-tracking-synchronization-exchange.md)  
  
- **Undelivered messages.** Email messages can fail to be delivered if the mail server is down, or can be blocked if the recipient doesn’t want to receive the email. If this happens, [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] saves the email message to your **Drafts** folder, but [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] creates a closed activity. In [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], use the **Pending E-mail** view to see unsent messages.  
  
   When you’re working offline, email messages that you send are saved to your [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] offline queue. When you go online, [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] automatically tries to send them and create the activities. If an email message can’t be sent, [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] saves it as a draft activity, but it does not appear in your **Drafts** folder in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].  
  
- **Offline security permissions.** You have the same security permissions offline as when you’re online.  
  
- **Adding a related record type using the Add  button (+).** If you’re offline, you can’t add a related record type by using the **Add** button (+). Add the related record type while you’re online, and then go offline.  
  
### See also  
 [Set up Dynamics 365 for Outlook](set-up.md)   


[!INCLUDE[footer-include](../../includes/footer-banner.md)]