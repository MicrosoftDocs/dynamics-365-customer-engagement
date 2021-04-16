---
title: "Integrate (synchronize) your email system  | MicrosoftDocs"
ms.custom: 
ms.date: 12/11/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 6804d996-86b2-4fb0-aed9-21fbdde0bab5
caps.latest.revision: 26
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Integrate (synchronize) your email system

One of the main reasons people use Dynamics 365 Customer Engagement (on-premises) is to store all customer communications in one place, so anyone with the appropriate permissions can see all relevant customer records. For example, view all email associated with a particular contact, account, opportunity, or case.  
  
 To store email and other messaging records in Customer Engagement (on-premises), you need to synchronize your email system with Customer Engagement (on-premises). You can do this with server-side synchronization. 
   
  
> [!IMPORTANT]
> - In previous versions of Dynamics CRM, you could also use the Email Router to synchronize records. The Email Router has been deprecated as of the [!INCLUDE[pn_crm_9_0_0_online](../includes/pn-crm-9-0-0-online.md)].  We strongly recommend that you migrate all email routing functionality to use  server-side synchronization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Migrate settings from the Email Router to server-side synchronization](../admin/migrate-settings-email-router-server-side-synchronization.md)  
> - Internet Message Access Protocol (IMAP) email servers are not currently supported by server-side synchronization or the Email Router.  
>
> Effective October 1 2020, the legacy Dynamics 365 for Outlook (also referred to as Outlook COM add-in) is retired. Customers must transition to the modern [Dynamics 365 App for Outlook](../../../outlook-app/overview.md) at the earliest. Microsoft will not provide support or any further updates (including security and critical updates) to the Outlook COM Add-in.
> 
> Starting December 4, 2020 the legacy Dynamics 365 for Outlook (also referred to as Outlook COM add-in) will be removed and users will no longer be able to use Outlook COM add-in. This removal will happen by geographic location and follows the weekly release schedule.
> For further information and steps to make a smooth transition, download [Dynamics 365 for Outlook (COM add-in) Playbook](https://aka.ms/OutlookCOMPlaybook).
  
<a name="ServerSideSync"></a>  
 
## Using server-side synchronization  

 Server-side synchronization has these benefits:  
  
- **Enables [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)]**. With [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)], Customer Engagement (on-premises) information appears  next to a user’s [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] email messages or appointments. They can view information about contacts and leads stored in Customer Engagement (on-premises) and add Customer Engagement (on-premises) contacts directly from an email message. They can also link email, appointment, and contact records  to new or existing Customer Engagement (on-premises) records, such as opportunity, account, or case records. [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] is very simple to deploy and it works with [!INCLUDE[pn-outlook-short](../includes/pn-outlook-short.md)] on the web (included in [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)])  the [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] desktop client, and [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] mobile. [Learn more about Dynamics 365 App for Outlook](../../../outlook-app/dynamics-365-app-outlook-user-s-guide.md).  
  
- **Enables [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder tracking**. With folder tracking, users can simply drag email to an [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder to track it automatically in Customer Engagement (on-premises). Folder tracking works on any mobile device that supports [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)], which means users can track email from just about any device. [Learn more about folder tracking](track-outlook-email-by-moving-it-tracked-exchange-folder.md).  
  
- **Automatic synchronization**. When you synchronize records with server-side synchronization, the synchronization happens automatically at the server level.  
  
- **Enables multiple scenarios, including hybrid scenarios**. You can use server-side synchronization to connect:  
  
  - Customer Engagement apps to [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)]  
  
  - Customer Engagement apps to [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] (on-premises)  
  
  - [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] server (on-premises) to [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] (on-premises)  
  
  - [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] server (on-premises) to [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)]  
  
- **Synchronize appointments, contacts, and tasks**. In addition to email, you can synchronize [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] appointments, contacts, and tasks.  
  
- **Synchronize with [!INCLUDE[pn_POP3_short](../includes/pn-pop3-short.md)] email servers**. You can use server-side synchronization to synchronize Customer Engagement (on-premises) with Gmail, [!INCLUDE[pn_outlook_com](../includes/pn-outlook-com.md)], Yahoo, and other [!INCLUDE[pn_POP3_short](../includes/pn-pop3-short.md)] email servers. Note, however, that you can’t synchronize appointments, contacts, and tasks with [!INCLUDE[pn_POP3_short](../includes/pn-pop3-short.md)] email servers.  
  
- **Integrated mailbox management and resource utilization**. You can use the server-side synchronization performance dashboard to quickly monitor mailbox performance across the organization. You can also troubleshoot errors through error logging and reporting.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Integrate your email system using server-side synchronization](../admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)  
  
> [!NOTE]
> If you use server-side sync in Dynamics 365 for Customer Engagement, you won't be able to view S/MIME encrypted messages. Encrypting emails with S/MIME requires an application to use an S/MIME control which server-side sync does not support. For more information on S/MIME encryption, see [Encrypt messages by using S/MIME in Outlook Web App](https://support.office.com/article/Encrypt-messages-by-using-S-MIME-in-Outlook-Web-App-2E57E4BD-4CC2-4531-9A39-426E7C873E26). 
  
 
### See also  
[Microsoft Dynamics CRM: How it works documentation ](https://www.microsoft.com/download/details.aspx?id=48718) 
 
[Integrate your email system using server-side synchronization](../admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)   

[Troubleshooting and monitoring server-side synchronization issues](../admin/troubleshooting-monitoring-server-side-synchronization.md)   

[Deploy Dynamics 365 App for Outlook](../../../outlook-app/deploy-dynamics-365-app-for-outlook.md)   

[Migrate settings from the Email Router to server-side synchronization](../admin/migrate-settings-email-router-server-side-synchronization.md)
 
 
 
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]