---
title: "Frequently asked questions about synchronizing records  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: a6b483be-88ff-4264-b834-92a536deb45e
caps.latest.revision: 50
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Frequently asked questions about synchronizing records between Customer Engagement (on-premises) and Microsoft Outlook

## What's the best way to use Outlook and Customer Engagement (on-premises) together?  
 There are three ways to use Dynamics 365 Customer Engagement (on-premises) and [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] together:  
  
- [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)]  
  
- [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] 
  
- [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] folder tracking  
  
  Use [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)] paired with [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)] to view Customer Engagement (on-premises) data in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] and track [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] records in [!INCLUDE[pn_crm_2016](../includes/pn-crm-2016.md)]. You can use [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)] together with [!INCLUDE[pn_microsoft_outlook_web_app](../includes/pn-microsoft-outlook-web-app.md)],  the [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] desktop application, or with [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] mobile. With [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)], Customer Engagement (on-premises) information appears next to a user’s [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] email messages or appointments. For example, people can preview information about contacts and leads stored in Customer Engagement (on-premises) and add Customer Engagement (on-premises) contacts directly from an email message. They can also link email, appointment, and contact records  to new or existing Customer Engagement (on-premises) records, such as  opportunity, account, or case records. To use [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)], you must synchronize email with [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Integrate your email system](../admin/integrate-synchronize-your-email-system.md)  

## How often are records synchronized through server-side sync?  
 If you synchronize records with [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)], the process is dynamic and unique for each user’s mailbox. The synchronization algorithm ensures that mailboxes are synced according to dynamic parameters such as the number of email messages and the activity within the mailbox. Normally, email synchronization occurs every 5 minutes. When a mailbox has many email messages, the interval can be reduced dynamically to 2 minutes. If the mailbox is less active, the interval can be increased up to 12 minutes. Generally speaking, you can assume that a mailbox will be synced at least once every 12 minutes. 

However, when you use Dynamics 365 App for Outlook to track or set the regarding record for an email or appointment, synchronization happens immediately in most scenarios for received emails and sent appointments. If the immediate synchronization in Dynamics 365 App for Outlook fails, we leverage server-side synchronization to create or update the activity record in Customer Engagement (on-premises).
  
## Where can I find information on troubleshooting server-side synchronization issues?  
 You can find information on troubleshooting and known issues here: [Troubleshooting and things to know about server-side synchronization](../admin/troubleshooting-monitoring-server-side-synchronization.md).  
  
## Do security permissions affect synchronization?  
 Yes. If a system administrator has implemented security for particular fields or records, it can affect the data that’s synchronized.  
  
## Privacy notices  
[!INCLUDE[cc_privacy_crm_server_side_sync](../includes/cc-privacy-crm-server-side-sync.md)]
  
 [!INCLUDE[cc_privacy_crm_sync_to_outlook](../includes/cc-privacy-crm-sync-to-outlook.md)]
  
 [!INCLUDE[cc_privacy_crm_outlook1](../includes/cc-privacy-crm-outlook1.md)]
  
### See also 
 [Integrate your email system](../admin/integrate-synchronize-your-email-system.md)   
 [Dynamics 365 App for Outlook User's Guide](../../../outlook-app/dynamics-365-app-outlook-user-s-guide.md)   
 [Track Outlook email by moving it to a tracked Exchange folder](track-outlook-email-by-moving-it-tracked-exchange-folder.md)   
 [Set personal options that affect tracking and synchronization between Customer Engagement (on-premises) and Outlook or Exchange](set-personal-options-affect-tracking-synchronization-between-dynamics-365-outlook-exchange.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]