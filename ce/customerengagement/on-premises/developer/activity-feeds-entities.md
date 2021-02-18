---
title: "Activity feeds entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The activity feeds help promote internal collaboration through quick and short updates in Dynamics 365 Customer Engagement (on-premises). The activity feeds do not replace emails or in-person communications."
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
  - integrating activity feeds with other applications
  - activity feeds, collaborating internally
  - collaborating internally, activity feeds
  - activity feeds, definition of
  - activity feeds, benefits of
  - activity feeds, integrating with other applications
  - activity feeds, introduction
ms.assetid: e475491b-179a-4c26-9acd-3d6557173d9d
caps.latest.revision: 56
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Activity feeds entities

The *activity feeds* help promote internal collaboration through quick and short updates in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. The activity feeds do not replace emails or in-person communications. Instead, they augment these traditional methods with non-intrusive and non-urgent ways of communication.  
  
 The activity feeds enable a salesperson to stay on top of situations that involve people, accounts, leads, contacts, or opportunities. They provide easy and convenient ways of monitoring important information that can be critical for closing a deal.  
  
 With activity feeds you can easily accomplish important tasks, such as:  
  
- Share information about users, accounts, leads, and other entity records.  
  
- Receive important updates regarding opportunities, users, or other records.  
  
- Follow users, accounts, and other records.  
  
- Learn, in a timely manner, about updates regarding users, accounts, or opportunities and items that are related to them.  
  
- Take quick actions on specific updates to move your work towards successful completion.  
  
  As a developer you can consume and create activity feeds data programmatically. You can integrate activity feeds with other applications, and extend activity feeds to meet the needs of the organization. The following are examples of custom applications that you can build around activity feeds:  
  
- Build full-featured activity feeds clients to complement [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] out-of-the-box client experiences that include Web, Outlook, and Mobile clients. For example, you can develop a desktop client.  
  
- Build surfaces to expose activity feeds data inside other applications, such as [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] or enterprise resource planning (ERP).  
  
- Build custom business logic to create activity feed posts when internal [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] app events or external events occur. An example of an external event is an invoice creation in an external ERP system.  
  
- Perform specific actions when posts are created or deleted. For example, use a workflow to send an email when a post is created.  
  
> [!NOTE]
>  In addition to activity feeds, from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] you can directly connect to [!INCLUDE[pn_yammer](../includes/pn-yammer.md)], a powerful tool for collaborating in your organization. For more information, see [Connect to Yammer](connect-yammer.md).  
  
## In This Section  
 [Introduction to Activity Feeds](introduction-activity-feeds.md)  
  
 [Configure Activity Feeds](configure-activity-feeds.md)  
  
 [Connect to Yammer](connect-yammer.md)  

 [Post Entity](entities/post.md)  
  
 [PostComment Entity](entities/postcomment.md)  
  
 [PostFollow Entity](entities/postfollow.md)  
  
 [PostLike Entity](entities/postlike.md)  
  
 [msdyn_PostAlbum Entity](entities/msdyn_postalbum.md)  
  
 [msdyn_PostConfig Entity](entities/msdyn_postconfig.md)
  
 [msdyn_PostRuleConfig Entity](entities/msdyn_postruleconfig.md)
  
 [Sample: Collaborate with Activity Feeds](sample-collaborate-with-activity-feeds.md)  
  
## Related Sections  
 [Model Your Business Data With Dynamics 365 Customer Engagement (on-premises)](model-business-data.md)  
  
 [Customer Entities (Account, Contact)](customer-entities-account-contact.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]