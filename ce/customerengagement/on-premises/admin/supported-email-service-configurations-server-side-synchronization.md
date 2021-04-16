---
title: "Supported email service configurations for server-side synchronization  | MicrosoftDocs"
ms.custom: 
ms.date: 05/19/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 034c2ad9-9a34-4d47-8d9e-f0399d9cec96
caps.latest.revision: 51
author: jimholtz
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin

---
# Supported email service configurations for server-side synchronization

Depending on your Dynamics 365 Customer Engagement (on-premises) installation, you may be deciding whether to use server-side synchronization or the Email Router/[!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] synchronization. This following table lists what is supported by server-side synchronization for each type of installation. Later in this topic, you can read about the scenarios that aren’t supported by server-side synchronization.  
  
> [!IMPORTANT]
> - The information here includes the POP3/SMTP systems supported by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)]. Although other POP3/SMTP systems might work with Customer Engagement (on-premises), those systems were not tested by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] and are not supported.  
> - [!INCLUDE[pn-outlook-short](../includes/pn-outlook-short.md)] on the web is not supported in a hybrid deployment: Customer Engagement (on-premises) with [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)].  
> - You can create two different email server profiles: one for online mailboxes, and another for on-premises mailboxes. Associate the mailboxes with the correct email server profile.  
> - Manual tracking in [!INCLUDE[proc_crm_for_outlook](../includes/proc-crm-for-outlook.md)] is not supported when a user’s mailbox is configured to use server-side synchronization with the POP/SMTP protocol.  
  

| Dynamics 365 for Customer Engagement apps deployment |  Email system  | Email synchronization | Appointments, contacts, and tasks synchronization |  Protocol  
|---------|------|----------|-----------|------------|  
| Customer Engagement (on-premises) |  - [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)]<br />- [!INCLUDE[pn_ms_Exchange_Server_2010_short](../includes/pn-ms-exchange-server-2010-short.md)]<br />- [!INCLUDE[pn_Exchange_Server_2013_short](../includes/pn-exchange-server-2013-short.md)]<br />- Exchange Server 2016 <br /> - Exchange Server 2019  |  Yes  |  Yes  | [!INCLUDE[pn_Exchange_Web_Services](../includes/pn-exchange-web-services.md)] | 
| Customer Engagement (on-premises) | - Gmail<br />- Yahoo! Mail<br />- MSN<sup>1</sup><br />- Outlook.com<sup>1</sup><br />- Windows Live Mail<sup>1</sup>   |  Yes |  No  | POP3/SMTP  |
  
 <sup>1</sup> May be unsupported for FIPS-compliancy. See the following section for more information.  
  
## Unsupported email service configurations  
 Server-side synchronization doesn’t support the following scenarios:  
  
- Mix of [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]/SMTP and POP3/[!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]  

- Exchange Online profile mailbox with Exchange on-premises user. Use the Exchange Server (Hybrid) profile, associate the mailbox to it, then test and enable.
  
- Exchange Online profile mailbox with an Exchange mailbox that points to an external email server. Use the POP3/SMTP Server profile, associate the mailbox to it, then test and enable.

- Creation of mass email marketing campaigns  
  
- Extensibility scenarios like extending EWS/POP3/SMTP protocols and creating custom email providers  
  
- [!INCLUDE[pn_ms_Exchange_Server_2003_short](../includes/pn-ms-exchange-server-2003-short.md)] and [!INCLUDE[pn_ms_Exchange_Server_2007_short](../includes/pn-ms-exchange-server-2007-short.md)]  
  
- Server-side synchronization in Customer Engagement (on-premises) deployment that is configured for FIPS 140-2 compliancy, requires a [!INCLUDE[pn_POP3_short](../includes/pn-pop3-short.md)]/SMTP email server that is also FIPS 140-2 compliant. Some email servers are not FIPS 140-2 compliant, such as MSN, Outlook.com, or Windows Live Mail.  

- Multi-factor authentication isn’t supported for Customer Engagement (on-premises) to Exchange Online.
  
For most situations not supported by server-side synchronization, you can use the [!INCLUDE[pn_CRM_E-Mail_Router](../includes/pn-crm-e-mail-router.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Integrate your email system](../admin/integrate-synchronize-your-email-system.md)  
  
> [!NOTE]
>  We recommend that you don’t use a mixed configuration of [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] synchronization and server-side synchronization for appointments, contacts, and tasks in the same organization, because it may result in updated [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps data not synchronizing to all attendees.  
  
### See also  
 [Server-side synchronization](../admin/server-side-synchronization.md)   
 [Set up server-side synchronization of email, appointments, contacts, and tasks](../admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]