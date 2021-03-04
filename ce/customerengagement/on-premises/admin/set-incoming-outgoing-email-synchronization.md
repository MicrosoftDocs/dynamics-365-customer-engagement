---
title: "Set incoming and outgoing email synchronization  | MicrosoftDocs"
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
ms.assetid: 17128669-8d3d-45fb-9a54-4b1dbf56ed4b
caps.latest.revision: 14
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Set incoming and outgoing email synchronization 

You have several options for synchronizing email messages with Dynamics 365 Customer Engagement (on-premises). Use the following information to deploy the best option for your company.  
  
## Set the synchronization method  
 You can set the default synchronization method applied to all newly created user mailboxes:  
  
1.  Go to **Settings** > **Email Configuration**  
  
2.  Click the **Email Configuration Settings** > **Email tab**.  
  
You can set the synchronization method for individual mailboxes:  
  
1.  Go to **Settings** > **Email Configuration**  
  
2.  Click **Mailboxes** > select a mailbox.  
  
For information on picking a synchronization method, see [Integrate your email system](../admin/integrate-synchronize-your-email-system.md).  
  
## Incoming email messaging options  
 The available incoming email configurations that you can use when a user or a queue receives Customer Engagement (on-premises) email messages are as follows:  
  
- **None**. Use this option for users or queues that do not use Customer Engagement (on-premises) to track received email messages.  
  
- **Dynamics 365 for Outlook**. This option is available for users and requires that [!INCLUDE[pn_MS_Outlook_Full](../includes/pn-ms-outlook-full.md)] be installed on the user's computer. This option does not require the Email Router component and is not available for queues.  
  
- **Server-Side Synchronization or Email Router**. When you select this option, the server-side synchronization or Email Router will process Customer Engagement (on-premises) email messages directly from the user's or queue's inbox, without using a forward or a sink mailbox. Although this option does not require a sink mailbox, it does make troubleshooting server-side synchronization or Email Router issues more complex for larger user bases (10 or more users) because each incoming email message is processed by the server-side synchronization or Email Router in every user's mailbox instead of in a single dedicated mailbox.  
  
- **Forward Mailbox**. To use this option, you must install the Email Router. This option requires a *sink* mailbox, which is a dedicated mailbox that collects email messages transferred from each Customer Engagement (on-premises) user's mailbox by a server-side rule. Although this option does not require users to run [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)], it does require that the rule be deployed for each user. You use the Rule Deployment Wizard to deploy rules to each Customer Engagement (on-premises) user mailbox.  
  
## Outgoing email messaging options  
 The available outgoing email configurations that you can use when users or queues send Customer Engagement (on-premises) email messages are as follows:  
  
- **None**. Use this option for users or queues that do not use Customer Engagement (on-premises) to send email messages.  
  
- **Dynamics 365 for Outlook**. This option is available for users and requires that [!INCLUDE[pn_MS_Outlook_Full](../includes/pn-ms-outlook-full.md)] be installed on the user's computer. This option does not require the Email Router component and is not available for queues.  
  
- **Server-Side Synchronization or Email Router**. This option delivers Customer Engagement (on-premises) email messages by using the server-side synchronization or Email Router component. The email system must be [!INCLUDE[pn_SMTP](../includes/pn-smtp.md)]-compliant. The server-side synchronization or Email Router can be installed on the [!INCLUDE[pn_SMTP](../includes/pn-smtp.md)] server or on a different computer that has a connection to the [!INCLUDE[pn_SMTP](../includes/pn-smtp.md)] server.  
  
### See also  
 [Forward mailbox vs. individual mailboxes](../admin/forward-mailbox-vs-individual-mailboxes.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]