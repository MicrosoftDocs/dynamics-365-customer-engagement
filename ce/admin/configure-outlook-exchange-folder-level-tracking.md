---
title: "Configure Outlook or Exchange folder-level tracking for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: ae069f91-8cd7-446e-b13b-05aec2e9b95c
caps.latest.revision: 15
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Configure Outlook or Exchange folder-level tracking 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

You can enable folder-level tracking for [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] folders to map an [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] inbox folder to a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] record so that all the emails in the [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder get automatically tracked against the mapped record in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Consider an example where you have an account called Adventure Works in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. You can create a folder in your [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] called Adventure Works under your Inbox folder, and create some [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] rules to automatically route the emails to the Adventure Works folder based on the subject or the body of an email. Next, in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] you can map your [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder (Adventure Works) with the account record (Adventure Works) to automatically track all the emails in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] that land in the Adventure Works [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder, and set the regarding object as the Adventure Works account record in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
> [!TIP]
> ![Video symbol](../admin/media/video-thumbnail-4.png "Video symbol") Check out the following video: [Folder Level Tracking in CRM Online 2015 Update 1](https://youtu.be/HiNpINvFKq8)  
  
## Enable folder-level tracking  
  
1. In [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], click **Settings** > **Email Configuration**.  
  
2. Click **Email Configuration Settings**.  
  
3. Confirm that **Process Email Using** is set to **Server-Side Synchronization**.  
  
4. Enable **Use folder-level tracking from Exchange folders (server-side synchronization must be enabled)**.  
  
5. Configure other tracking options on this page, and then click **OK**.  
  
Once you’ve enabled folder-level tracking, users will need to configure folder-tracking rules in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] with Settings (![Gear button](../admin/media/selection-rule-gear.gif "Gear button")) > **Options** > **Email** > **Configure Folder Tracking Rules**.  
  
## Some important points about folder-level tracking  
  
- Folder-level tracking of emails will work only if your organization is configured to use server-side synchronization for emails. Server-side synchronization must be configured for [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] (and not POP3) mailboxes. For more information, see [Set up server-side synchronization of email, appointments, contacts, and tasks](../admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md).  
  
- You can track emails only in folders under your Inbox folder in [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]. Other folder emails cannot be tracked.  
  
- You can track up to a maximum of 25 folders per user account.  
  
- Any manual changes done to the regarding object in the tracked activity records in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] will be overridden the next time server-side synchronization kicks in. For example, if you have set up a mapping between the Adventure Works folder and the Adventure Works account, all the emails in the Adventure Works [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder will be tracked as activities in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] with the regarding set to the Adventure Works account record. If you change the regarding to some other record, it will automatically be overridden the next time server-side synchronization occurs. To change the regarding for any email, move the email to a different folder such as the Inbox.  
  
### See also  
 [System Settings dialog box - Email tab](system-settings-dialog-box-email-tab.md)   
