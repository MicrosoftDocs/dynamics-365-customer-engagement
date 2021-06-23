---
title: "Connect to Yammer (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Read about how you can connect Dynamics 365 Customer Engagement (on-premises) to Yammer."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: cac47832-86f4-41b4-b5c6-e470cdcaa79c
caps.latest.revision: 37
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Connect to Yammer

To enhance your organization’s collaboration, use [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to connect directly to [!INCLUDE[pn_yammer](../includes/pn-yammer.md)], a powerful tool for social networking in your company. 

### Prerequisites 

- Before you set up a connection to [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you must purchase [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] enterprise licenses for your organization, such as an Enterprise Network or [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)] + [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] account.

- [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] integration is only available for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].

  
> [!NOTE]
>  Connecting to [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] is a one-way process. After the connection is established, it can’t be removed.  
  
 Several attributes are available that support connection to [!INCLUDE[pn_yammer](../includes/pn-yammer.md)]. The `msdyn_PostRuleConfig.msdyn_PostToYammer` attribute determines whether certain auto posts are posted in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_yammer](../includes/pn-yammer.md)], or only in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Other attributes, intended for internal use only, are added to the `Post`, `PostFollow`, `Organization`, and `SystemUser` entities. [!INCLUDE[metadata_browser](../includes/metadata-browser.md)] The description of the `msdyn_PostRuleConfig.msdyn_PostToYammer` attribute appears as “For internal use only” until you enable the [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] connection. After the connection is enabled, the attribute’s description is updated in the metadata. The attributes exist in the databases of all deployments.  
  
 You’ll notice that, if you enable the [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] connection, Activity Feeds behavior changes, as shown here:  
  
- User posts (manual posts) added through the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] user interface are created and stored directly in [!INCLUDE[pn_yammer](../includes/pn-yammer.md)]. Existing user posts, created before the [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] connection was enabled, aren’t migrated from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to [!INCLUDE[pn_yammer](../includes/pn-yammer.md)].  
  
- Auto posts are created and stored in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
  > [!NOTE]
  >  Selective auto posts are stored in [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] in addition to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], if you set the `msdyn_PostRuleConfig.msdyn_PostToYammer` attribute to `true`. Some of the auto post rules for [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] are enabled out-of-the-box. Other rules can be enabled by the administrator. To see the auto post rules that are available for [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application, on the nav bar, click **[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]** > **Settings** > **Post Rule Configurations**. Click the **All Activity Feeds Rules** drop-down list, and then click **All Yammer Rules**.  
  
- Objects, except users, are followed in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_yammer](../includes/pn-yammer.md)]. You must enable the [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] connection before you can follow an object in [!INCLUDE[pn_yammer](../includes/pn-yammer.md)].  
  
- Users are only followed in [!INCLUDE[pn_yammer](../includes/pn-yammer.md)]. A user must have a valid [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] account to be followed.  
  
- You can stop following an object in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] programmatically or through the user interface. However, this doesn’t unfollow the object in [!INCLUDE[pn_yammer](../includes/pn-yammer.md)]. To stop following an object in [!INCLUDE[pn_yammer](../includes/pn-yammer.md)], you have to use the [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] user interface. You can’t unfollow an object in [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] programmatically.  
  
  If you’re connected to [!INCLUDE[pn_yammer](../includes/pn-yammer.md)], the <xref:Microsoft.Crm.Sdk.Messages.RetrieveRecordWallRequest> message and the <xref:Microsoft.Crm.Sdk.Messages.RetrievePersonalWallRequest> message return the following posts:  
  
- All auto posts.  
  
- User posts created by using the [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] web application, before you enabled the connection to [!INCLUDE[pn_yammer](../includes/pn-yammer.md)].  
  
- User posts created programmatically in [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] before or after you enabled the connection to [!INCLUDE[pn_yammer](../includes/pn-yammer.md)].  
  
### See also  
 [Activity Feeds Entities](activity-feeds-entities.md)   
 [Post Entity](entities/post.md)   
 [Collaborate and communicate with Yammer](../basics/basics-guide.md)   
 [Connect Microsoft Dynamics 365 Customer Engagement to Yammer](../basics/basics-guide.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]