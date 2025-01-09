---
title: "Set an option to automatically track incoming Outlook email in Dynamics 365 for Outlook | MicrosoftDocs"
ms.custom: 
ms.date: 12/13/2024
ms.reviewer: smurkute 
description: Set an option to automatically track incoming Outlook email in Dynamics 365 for Outlook.
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
ms.assetid: 893ce442-3fb7-48dd-9440-6fb5f169d064
caps.latest.revision: 52
author: shwetamurkute
ms.author: bharavar
search.audienceType: 
  - admin
  - customizer
  - enduser
---
# Set an option to automatically track incoming Outlook email in Dynamics 365 for Outlook
When you use [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to track an email message, a copy of the email record is saved as an activity in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] and synchronized with the [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] record. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Overview of tracking records in Dynamics 365 for Outlook](overview-tracking-records.md)  
  
 By default, tracking email is a manual process—you have to choose the **Track** button or the **Set Regarding** button for each email message you want to track. Manual tracking provides a way for you to keep your personal email separate from your customer email. As an alternative, you can set an option to track email messages automatically.  
  
> [!TIP]
>  You can use [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] folder tracking as an alternate method for tracking messages automatically. With folder tracking, you can track messages directly from virtually any device. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Track Outlook email by moving it to a tracked Exchange folder](track-outlook-email-by-moving-it-tracked-exchange-folder.md)  
  
## Automatically track email messages  
  
1. In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], on the **File** tab, choose **[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]**, and then choose **Options**.  
  
2. In the **Set Personal Options** dialog box, on the **Email** tab, in the **Select how [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] should integrate email with [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]** section, select the **Check incoming email in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] and determine whether an email should be linked and saved as a [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] record** option.  
  
3. To specify whether to track all email messages or only certain types, in the **Select the email messages to track in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]** section, in the **Track** list, select one of the following options:  
  
   - **All email messages**. Tracks all email messages related to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] email messages. If you select this option, Dynamics 365 apps will track junk mail and business conversations, so choose this option carefully.  
  
   - **Email messages in response to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] email**. Only replies to or forwards of email messages that have already been tracked will be saved as email activities. This is the most common option.  
  
   - **Email messages from Dynamics 365 apps Leads, Contacts, and Accounts**. Tracks email messages only if they originate from someone with a [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] lead, contact, or account record.  
  
   - **Email messages from [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] records that are email enabled**. Tracks email messages from all record types (including custom record types) that contain an email address field.  

   > [!NOTE]
   >  By default email in your Sent Items folder within Outlook won't automatically appear as tracked in Dynamics 365. An optional setting is available to automatically track items from the Sent Items folder. If an administrator enables this setting, the personal options mentioned earlier will be used to determine which sent emails are automatically tracked. For more information, see [Automatically track sent folder items with server-side synchronization](/power-platform/admin/track-sent-folder-items)
  
   > [!NOTE]
   >  Keep in mind that the more you use the same email address for tracking purposes, the less useful it becomes since it will be mapped to many records.  
  
4. If you want to automatically create contact or lead records for tracked email messages, in the **Automatically create records in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]** section, choose the **Create** check box, and then choose **Contacts** or **Leads** from the list. When this check box is selected, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] will try to match the email address of recipients to an email address in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. If it can’t find a matching record, it will automatically create a contact or lead record.  
  
   > [!NOTE]
   >  Contact and lead records won’t be created if you don’t have the appropriate security permissions. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [TechNet: How security affects synchronization between Dynamics 365 apps and Outlook](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn832097(v=crm.8))  
  
> [!NOTE]
> More than one custom record type can contain the same email address. When this happens, Dynamics 365 for Customer Engagement links the email messages received from this email address to one of the custom record types. For example, if there are two record types (Patient and Doctor) with the same email address someone@example.com, Dynamics 365 for Customer Engagement links the email messages received from someone@example.com to **either** Patient or Doctor record type. However, sending an email message to someone@example.com links the email message to **both** the Patient record type and the Doctor record type.
  
### See also  
 [Overview of tracking records in Dynamics 365 for Outlook](overview-tracking-records.md)   
 [Frequently asked questions about synchronizing records between Microsoft Dynamics 365 apps and Microsoft Outlook](frequently-asked-questions-synchronizing-records.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
