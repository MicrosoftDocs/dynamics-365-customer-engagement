---
title: "Configure Outlook or Exchange folder-level tracking  | MicrosoftDocs"
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
ms.assetid: ae069f91-8cd7-446e-b13b-05aec2e9b95c
caps.latest.revision: 15
author: jimholtz
ms.author: jimholtz
search.audienceType: 
  - admin
---
# Configure Outlook or Exchange folder-level tracking 

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

You can enable folder-level tracking for [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] folders to map an [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] inbox folder to a Dynamics 365 Customer Engagement (on-premises) record so that all the emails in the [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder get automatically tracked against the mapped record in Customer Engagement (on-premises). Consider an example where you have an account called Adventure Works in Customer Engagement (on-premises). You can create a folder in your [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] called Adventure Works under your Inbox folder, and create some [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] rules to automatically route the emails to the Adventure Works folder based on the subject or the body of an email. Next, in Customer Engagement (on-premises) you can map your [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder (Adventure Works) with the account record (Adventure Works) to automatically track all the emails in Customer Engagement (on-premises) that land in the Adventure Works [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder, and set the regarding object as the Adventure Works account record in Customer Engagement (on-premises).  
  
> [!TIP]
> ![Video symbol](../admin/media/video-thumbnail-4.png "Video symbol") Check out the following video: [Folder Level Tracking in CRM Online 2015 Update 1](https://youtu.be/HiNpINvFKq8)  
  
## Enable folder-level tracking  
  
1. In Customer Engagement (on-premises), click **Settings** > **Email Configuration**.  
  
2. Click **Email Configuration Settings**.  
  
3. Confirm that **Process Email Using** is set to **Server-Side Synchronization**.  
  
4. Enable **Use folder-level tracking from Exchange folders (server-side synchronization must be enabled)**.  
  
5. Configure other tracking options on this page, and then click **OK**.  
  
Once you’ve enabled folder-level tracking, users will need to configure folder-tracking rules in Customer Engagement (on-premises) with Settings (![Gear button](../admin/media/selection-rule-gear.gif "Gear button")) > **Options** > **Email** > **Configure Folder Tracking Rules**.  
  
## Some important points about folder-level tracking  
  
- Folder-level tracking of emails will work only if your organization is configured to use server-side synchronization for emails. Server-side synchronization must be configured for [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] (and not POP3) mailboxes. For more information, see [Set up server-side synchronization of email, appointments, contacts, and tasks](../admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md).  
  
- You can track emails only in folders under your Inbox folder in [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]. Other folder emails cannot be tracked.  
  
- You can track up to a maximum of 25 folders per user account.  
  
- Any manual changes done to the regarding object in the tracked activity records in Customer Engagement (on-premises) will be overridden the next time server-side synchronization kicks in. For example, if you have set up a mapping between the Adventure Works folder and the Adventure Works account, all the emails in the Adventure Works [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] folder will be tracked as activities in Customer Engagement (on-premises) with the regarding set to the Adventure Works account record. If you change the regarding to some other record, it will automatically be overridden the next time server-side synchronization occurs. To change the regarding for any email, move the email to a different folder such as the Inbox.  

- Folder-level tracking for queue mailboxes is not supported.  
  
### See also  
 [System Settings dialog box - Email tab](system-settings-dialog-box-email-tab.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]