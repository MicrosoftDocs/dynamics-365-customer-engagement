---
title: "Link posts from Social Engagement to Dynamics 365 | Microsoft Docs"
description: "Learn how to link social posts to Dynamics 365 and create new case or lead records."
keywords: "link to crm, link to customer engagement"
ms.date: 01/30/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: e97a38d7-37c4-4dce-b02e-1076ad992cff
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Link posts from Social Engagement to Dynamics 365

[!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] provides a platform for capturing public posts from social media. You link posts in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance and turn them into new records in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].

When you link a post from [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] instance, a Social Activity record is created in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] can turn these social activities into other types of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records, for example into a lead, an opportunity, or a case.
  
## Steps for linking posts from Social Engagement to Dynamics 365  


[comment]: <> (All more info links: map to right section)


1.  First, set up the feature to link social posts to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance as social activities. As a [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Administrator, you need to connect [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].   
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Connect Dynamics 365 and Social Engagement](connect-dynamics-365-social-engagement.md)  
  
2.  Next, you can define the attributes for the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] entities that you want to display in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].   
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a new Dynamics 365 record from a social post](create-dynamics-365-record-from-social-post.md)  
  
3.  As a system administrator or customizer in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you can configure rules to handle newly created social activities by using the **Automatic Record Creation and Update Rules** feature in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].   
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Record Creation and Update Rule in Dynamics 365 to process Social Actity entities from Social Engagement](configure-automatic-record-creation.md) 
  
4.  When everything is set up, your users can start to link social posts to create or update [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records.   
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a new Dynamics 365 record from a social post](create-dynamics-365-record-from-social-post.md)  
  
5.  Optionally, you can configure automation rules in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to create new [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records for posts that match a specified data set.   
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Route posts using automation rules](automation-rules.md)  
  
6.  Understand how to delete or disable a connection between [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], and understand how this might affect existing linkages or linking newly acquired social posts.   
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage the connection between Dynamics 365 and Social Engagement](manage-connection-dynamics-365-social-engagement.md)  
  
### Privacy notice 
 
 [!INCLUDE[cc_privacy_mse_post_and_automation_rules](../includes/cc-privacy-mse-post-and-automation-rules.md)]  
  
### See also  

 [Administer Microsoft Social Engagement](administer-microsoft-social-engagement.md)   
 [Set up the connection between Dynamics 365 and Social Engagement](connect-dynamics-365-social-engagement.md)   
 [Create a new Dynamics 365 record from a social post](create-dynamics-365-record-from-social-post.md)