---
title: "Server-side synchronization entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "In Dynamics 365 Customer Engagement (on-premises), server-side synchronization provides an interface between Dynamics 365 Customer Engagement and one or more Exchange servers or POP3 servers for incoming email, and one or more SMTP or Exchange servers for outgoing email"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8595e377-7496-456d-ba2f-8671d066098a
caps.latest.revision: 27
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Server-side synchronization entities

In [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)], server-side synchronization provides an interface between [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and one or more [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] servers or POP3 servers for incoming email, and one or more [!INCLUDE[pn_SMTP](../includes/pn-smtp.md)] or [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] servers for outgoing email. It retrieves and evaluates emails for relevance to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and accordingly creates corresponding email activities in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. It also picks emails from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and sends them through the configured email server for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] users and queues. It also allows synchronization of appointments, contacts, and tasks with [!INCLUDE[pn_ms_Exchange_Server_2010_short](../includes/pn-ms-exchange-server-2010-short.md)] and [!INCLUDE[pn_Exchange_Server_2013_short](../includes/pn-exchange-server-2013-short.md)].  
  
 With the centralized email configuration, the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] entity model allows having common user interface (UI) settings (like user name, password, email address, and synchronization methods) for users, queues, and forward mailboxes. Each [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] user or a queue can have mailboxes, which can be monitored through either server-side synchronization or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)]. The `EmailServerProfile` entity represents the email server profile for an organization. The `Mailbox` entity represents the appointments, contacts, and tasks delivery method of the mailbox. Currently, the user entity is restricted to have only one mailbox record per user and the queues entity to have only one mailbox record per queue, as shown in the following illustration.  
  
 ![Email connector entity model](media/email-connector-entity-model.png "Email connector entity model")  
  
 Server-side synchronization offers the following capabilities:  
  
- Process emails of a user and a queue using the email address, email delivery method, and credentials from the related mailbox record.  
  
- Process appointments, contacts, and tasks.  
  
- Use mailbox records to process emails for users and queues having the incoming delivery method set as Forward Mailbox.  
  
- Use information from a related email profile record to process emails for all mailboxes.  
  
- Prevent email processing for inactive mailboxes or for mailboxes that don’t have an associated email profile.  
  
- Automatically relate an associated mailbox to the default email profile when a user or a queue is created with the email delivery method set as server-side synchronization.  
  
- Automatically track [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] emails in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for a user based on the folder-level tracking rules.  
  
## In This Section  
 [Configure folder level tracking rules](configure-exchange-folder-level-tracking-rules.md)  
  
 [EmailServerProfile Entity](entities/emailserverprofile.md)  
  
 [ExchangeSyncIdMapping Entity](entities/exchangesyncidmapping.md)  
  
 [Mailbox Entity](entities/mailbox.md)  
  
 [MailboxTrackingFolder Entity](entities/mailboxtrackingfolder.md) 
  
## Related Sections

 [Model Your Business Data With Dynamics 365 Customer Engagement (on-premises)](model-business-data.md)  
  
 [Goal Management Entities](goal-management-entities.md)  
  
 [Product Catalog Entities](product-catalog-entities.md)  
  
 [Sales Literature Entities](sales-literature-entities.md)  
  
 [Schedule and Appointment Entities](schedule-appointment-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]