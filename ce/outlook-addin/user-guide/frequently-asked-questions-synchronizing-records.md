---
title: "Frequently asked questions about synchronizing records between Microsoft Dynamics 365 apps and Microsoft Outlook | MicrosoftDocs"
ms.custom: 
ms.date: 01/11/2016
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
ms.assetid: a6b483be-88ff-4264-b834-92a536deb45e
caps.latest.revision: 52
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
# Frequently asked questions about synchronizing records between Microsoft Dynamics 365 apps and Microsoft Outlook
## What's the best way to use Outlook and Microsoft Dynamics 365 apps together?  
 There are three ways to use [!INCLUDE[pn_crm_2016](../../includes/pn-crm-2016.md)] and  [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] together:  
  
- [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../../includes/pn-ms-dyn-crm-app-for-outlook.md)]  
  
- [!INCLUDE[pn_crm_for_outlook_full](../../includes/pn-crm-for-outlook-full.md)] (legacy add-in)  
  
- [!INCLUDE[pn_Microsoft_Exchange](../../includes/pn-microsoft-exchange.md)] folder tracking  
  
  As of the [!INCLUDE[pn_crm_8_2_0_both](../../includes/pn-crm-8-2-0-both.md)], [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../../includes/pn-ms-dyn-crm-app-for-outlook.md)] paired with [!INCLUDE[cc_server_side_synch](../../includes/cc-server-side-synch.md)] is the preferred way to view  [!INCLUDE[pn_crm_2016](../../includes/pn-crm-2016.md)] data in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] and track [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] records in [!INCLUDE[pn_crm_2016](../../includes/pn-crm-2016.md)]. You can use [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../../includes/pn-ms-dyn-crm-app-for-outlook.md)] together with [!INCLUDE[pn_microsoft_outlook_web_app](../../includes/pn-microsoft-outlook-web-app.md)],  the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] desktop application, or with [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] mobile. With [!INCLUDE[pn_crm_app_for_outlook_short](../../includes/pn-crm-app-for-outlook-short.md)], [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] information appears next to a user’s [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] email messages or appointments. For example, people can preview information about contacts and leads stored in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] and add [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] contacts directly from an email message. They can also link email, appointment, and contact records  to new or existing [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] records, such as  opportunity, account, or case records. To use [!INCLUDE[pn_crm_app_for_outlook_short](../../includes/pn-crm-app-for-outlook-short.md)], you must synchronize email with [!INCLUDE[cc_server_side_synch](../../includes/cc-server-side-synch.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Integrate (synchronize) your email system](../../admin/integrate-synchronize-your-email-system.md)
  
## How often are records synchronized through server-side sync?  
 If you synchronize records with [!INCLUDE[cc_server_side_synch](../../includes/cc-server-side-synch.md)], the process is dynamic and unique for each user’s mailbox. The synchronization algorithm ensures that mailboxes are synced according to dynamic parameters such as the number of email messages and the activity within the mailbox. Normally, email synchronization occurs every 5 minutes. When a mailbox has many email messages, the interval can be reduced dynamically to 2 minutes. If the mailbox is less active, the interval can be increased up to 12 minutes. Generally speaking, you can assume that a mailbox will be synced at least once every 12 minutes. Note that you can’t manually synchronize records through [!INCLUDE[cc_server_side_synch](../../includes/cc-server-side-synch.md)] but when you track or link (set the regarding record) for email, appointments, or tasks, synchronization happens immediately.  
  
## Where can I find information on troubleshooting server-side synchronization issues?  
 You can find information on troubleshooting and known issues here: [Troubleshooting and things to know about Microsoft Dynamics 365 for Outlook](../admin-guide/troubleshooting-things-to-know.md) 
  
## Do security permissions affect synchronization?  
 Yes. If a system administrator has implemented security for particular fields or records, it can affect the data that’s synchronized.  
  
## If I synchronize records with Dynamics 365 for Outlook (legacy add-in), how do I change the synchronizing computer (client)?  
 If you use [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] (legacy add-in and not the same thing as [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../../includes/pn-ms-dyn-crm-app-for-outlook.md)]) to synchronize records, and if you have [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] installed on more than one computer, you have to select one computer as the synchronizing computer for email, appointments, contacts, and tasks. To change the synchronizing computer:  
  
1. In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], on the **File** menu, choose **Dynamics 365 apps**, and then choose **Options**.  
  
2. On the **Set Personal Options** page, choose the **Synchronization** tab.  
  
3. In the **Set synchronization client** section, select **Set this computer to be the client to perform synchronization between [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] and your primary [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] organization**.  
  
> [!NOTE]
>  This option only appears when you have multiple computers connected to the same organization.  
  
## Can I view or control the fields that are synchronized between Dynamics 365 apps and Dynamics 365 for Outlook (legacy add-in)?  
 You can view the synchronizing fields and  whether fields are synced one way (from [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]), two ways (back and forth between [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] and [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]), or not at all. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [View the fields that are synchronized between Dynamics 365 apps and Dynamics 365 for Outlook](view-fields-synchronized.md).  
  
 If you’re a system administrator, you can  control field synchronization and sync direction. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Control field synchronization between Dynamics 365 apps and Outlook or Exchange](control-field-synchronization-exchange.md)
  
> [!NOTE]
>  [!INCLUDE[cc_feature_included_with_2015_update_1_admins](../../includes/cc-feature-included-with-2015-update-1-admins.md)]  
  
### See also  
 [Dynamics 365 App for Outlook User's Guide](../../outlook-app/dynamics-365-app-outlook-user-s-guide.md)   
 [Dynamics 365 for Outlook User's Guide](dynamics-365-outlook-user-s-guide.md)   
 [Track Outlook email by moving it to a tracked Exchange folder](track-outlook-email-by-moving-it-tracked-exchange-folder.md)   
 [Set personal options that affect tracking and synchronization between Dynamics 365 apps and Outlook or Exchange](set-personal-options-affect-tracking-synchronization-exchange.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]