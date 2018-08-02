---
title: "Forward mailbox vs. individual mailboxes for Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: ddd3e2d0-7b6d-463f-b413-e8e1ea371daa
caps.latest.revision: 18
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Forward mailbox vs. individual mailboxes 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

You can use mailbox monitoring to poll one or more mailboxes for incoming email messages, and then determine what actions [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] will take based on the email message, such as create or update records in the system. You can configure server-side synchronization or the Email Router to monitor either of the following:  
  
-   A forward mailbox. This is a single, central mailbox.  
  
-   The mailbox for each user or queue.  
  
If you administer an organization that has to monitor a large number of mailboxes, you should consider using a forward mailbox to reduce the administrative effort. Monitoring many mailboxes can sometimes require maintaining access credentials in many incoming configuration profiles.  
  
By using a forward mailbox, you shift the administrative effort to the task of deploying a server-side forwarding rule to each user mailbox. The forwarding rule forwards all incoming email messages as attachments to the centralized forward mailbox. For [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] only, you can use the Rule Deployment Wizard (installed with the [!INCLUDE[pn_CRM_E-Mail_Router](../includes/pn-crm-e-mail-router.md)]) to deploy forwarding rules. This can significantly reduce administration and maintenance requirements because the Rule Deployment Wizard can deploy forwarding rules to multiple [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users at the same time.  
  
> [!IMPORTANT]
> - To use a forward mailbox with a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment that interfaces with a POP3-compliant email system, the email system must be able to forward email messages as attachments.  
> - For POP3 e-mail servers and Exchange Online, you cannot use the Rule Deployment Wizard. Instead, you must create the rules manually.  
  
 You can configure users and queues in different ways within the same Dynamics 365 deployment. For example, you may want to configure some user or queue mailboxes to be monitored directly on one email server, and configure others to use a forward mailbox on a different email server.  
  
## Monitor a forward mailbox  
 When you use forward mailbox monitoring, incoming email messages are processed by [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)] or the [!INCLUDE[pn_POP3_short](../includes/pn-pop3-short.md)] server and [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] in the following sequence:  
  
1. An email message is received by a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user or queue mailbox, on either the [!INCLUDE[pn_Exchange_Server_short](../includes/pn-exchange-server-short.md)] or the [!INCLUDE[pn_POP3_short](../includes/pn-pop3-short.md)] server.  
  
2. A rule in the user's mailbox sends a copy of the message, as an attachment, to the forward mailbox.  
  
3. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] (by using server-side synchronization or Email Router) retrieves the message from the forward mailbox and creates the appropriate records.  
  
### See also  
