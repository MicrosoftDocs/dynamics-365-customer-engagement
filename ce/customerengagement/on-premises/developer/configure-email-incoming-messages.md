---
title: "Configure email for incoming messages (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about configuring email for the incoming messages to deliver directly to a queue."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - email, configuring to deliver to a queue
  - configuring email
  - email, configuring address; delivery methods; router; and filtering
  - email, approval of (ensuring unblocked)
ms.assetid: 24e17276-ee23-4414-a025-030b841ae166
caps.latest.revision: 51
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Configure email for incoming messages

If you want incoming email messages to be delivered directly to a queue, specify the following information in the queue:  
  
- An email address by using the `Queue.EmailAddress` attribute. It must be a valid email address where emails that are sent to the queue are directed.  
  
- An incoming email delivery method by using the `Queue.IncomingEmailDeliveryMethod` attribute. You can specify email to be sent and received with the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]Email Router or forwarded from another email address. If you specify the email router, you have an option to include the user’s email server credentials to give the user access to the server for retrieving emails.  
  
- An outgoing email delivery method, such as email router, by using the `Queue.OutgoingEmailDeliveryMethod` attribute.  
  
- An incoming email filtering method by using the `Queue.IncomingEmailFilteringMethod` attribute. You can specify to convert all incoming email messages to email activities or only email messages that relate to existing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] records.  
  
> [!IMPORTANT]
>  The primary email address of the queue must be approved to ensure that the incoming and outgoing email messages are not blocked. The `Queue.EmailRouterAccessApproval` attribute contains the status of the primary email address of the queue. The status must be set to 1 (Approved). You can update the queue record to change the attribute value to 1 (Approved), if it is not already in the approved state. To update the attribute value, you must have the **prvApproveRejectEmailAddress** privilege. You also must set the `Organization.RequireApprovalForQueueEmail` attribute to 1 (True). If not set to 1 (True), the value provided in the `Queue.EmailRouterAccessApproval` attribute is ignored.  
> 
>  It’s no longer possible to configure Email Router credentials by setting the `Queue.AllowEmailCredentials` attribute to `true` followed by specifying the user name and password in `Queue.EmailUserName` and `Queue.EmailPassword`. These attributes have been deprecated and made read-only. The same restriction applies to the `UserSettings.EmailPassword` and `UserSettings.EmailUserName` attributes. However, these attributes can be set in the Email Router configuration. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure the Email Router](/previous-versions/dynamicscrm-2016/administering-dynamics-365/hh699786(v=crm.8)).  
  
### See also  
 [Queue Entities](queue-entities.md)   
 [Queue Entity](entities/queue.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]