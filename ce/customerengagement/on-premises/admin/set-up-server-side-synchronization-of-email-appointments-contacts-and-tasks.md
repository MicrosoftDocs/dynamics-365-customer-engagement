---
title: "Set up server-side synchronization of email, appointments, contacts, and tasks | MicrosoftDocs"
ms.custom: 
ms.date: 04/16/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 5a297c2d-4336-46c3-952e-625ec22b0382
caps.latest.revision: 52
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Set up server-side synchronization of email, appointments, contacts, and tasks

You can use [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)] to synchronize your email system with Dynamics 365 Customer Engagement (on-premises) at the server level. For example, you can synchronize Customer Engagement (on-premises) with [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)] (hosted email server) or [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] (on-premises). If you synchronize Customer Engagement (on-premises) with [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)] or [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)], in addition to [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] email, you can synchronize [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] appointments, contacts, and tasks.  
  
 You can also use [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)] to synchronize Customer Engagement (on-premises) with a [!INCLUDE[pn_POP3_short](../includes/pn-pop3-short.md)] email server for web-hosted email like Gmail or [!INCLUDE[pn_outlook_com](../includes/pn-outlook-com.md)]. If you synchronize email with a [!INCLUDE[pn_POP3_short](../includes/pn-pop3-short.md)] email server, you can’t synchronize appointments, contacts, and tasks, however.  
  
> [!NOTE]
> Using encryption software (such as Vaultive) together with [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)] is not supported.  
> 
> If you use server-side sync in Customer Engagement (on-premises), you won't be able to view S/MIME encrypted messages. Encrypting emails with S/MIME requires an application to use an S/MIME control which server-side sync does not support. For more information on S/MIME encryption, see [Encrypt messages by using S/MIME in Outlook Web App](https://support.office.com/article/Encrypt-messages-by-using-S-MIME-in-Outlook-Web-App-2E57E4BD-4CC2-4531-9A39-426E7C873E26). 
  
 **Synchronization scenarios**  
  
 Choose one of the following scenarios to configure [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)] for your organization:  
  
-   [Connect Dynamics 365 Customer Engagement (on-premises) to Exchange Online](connect-dynamics-365-on-premises-exchange-online.md)
  
-   [Connect Customer Engagement (on-premises) to Exchange Server on-premises](https://docs.microsoft.com/previous-versions/dynamicscrm-2016/administering-dynamics-365/mt622062%28v%3dcrm.8%29)    
  
-   [Connect to a POP3 or SMTP server](../admin/connect-to-pop3-or-smtp-servers.md)

### See also  
[Server-side synchronization](../admin/server-side-synchronization.md) 
[Troubleshooting server-side synchronization](../admin/troubleshooting-monitoring-server-side-synchronization.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]