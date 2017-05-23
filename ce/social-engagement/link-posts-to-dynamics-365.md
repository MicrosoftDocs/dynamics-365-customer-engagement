---
title: "Link posts from Social Engagement to Dynamics 365 | Microsoft Docs"
description:
ms.custom: ""
ms.date: "2017-05-19"
ms.reviewer: ""
ms.service: "mse"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Social Engagement"
ms.assetid: e97a38d7-37c4-4dce-b02e-1076ad992cff
caps.latest.revision: 28
author: "saurabh-kudesia"
ms.author: "sakudes"
manager: "sakudes"
---
# Link posts from Social Engagement to Dynamics 365
[!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] provides a platform for capturing public posts from social media. Based on the social activity in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] and [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-op-edition.md)] with [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)] enabled, the social post gets linked to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] that is defined by the rules in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. As an admin, you can connect one or more [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instances with [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)], and then define or customize the data structure of the linked [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record and display it within record details that are associated with a [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] post. When you send a post from [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] to a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] instance, a social activity is created in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. The rule framework in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] can automatically turn these social activities into other types of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records, for example into a lead, an opportunity, or a case. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up rules to automatically create or update records in CRM](http://go.microsoft.com/fwlink/p/?LinkId=624394)  
  
## Steps for linking posts from Social Engagement to Dynamics 365  
  
1.  Learn how you can set up the feature to link social posts to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance in your organization as social activities. As a [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] Administrator, you need to connect [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up the connection between Dynamics 365 and Social Engagement](../social-engagement/connect-dynamics-365-social-engagement.md)  
  
2.  Next, you can define the attributes for the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] entities that you want to display in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a new Dynamics 365 record from a social post](../social-engagement/create-dynamics-365-record-from-social-post.md)  
  
3.  In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], as a system administrator or customizer, you can configure [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to handle newly-created social activities using the record creation and update rules feature in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [CRM Help & Training: Set up rules to automatically create or update records in CRM](http://go.microsoft.com/fwlink/p/?LinkId=624394)  
  
4.  When everything is set up, your users can start to send social posts from [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to create or update [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a new Dynamics 365 record from a social post](../social-engagement/create-dynamics-365-record-from-social-post.md)  
  
5.  Optionally, configure automation rules in [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] to create new [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records for posts that match a given set of filters. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Route posts using automation rules](../social-engagement/automation-rules.md)  
  
6.  Understand how to delete or disable a connection between [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] and how this may affect existing linkages or linking social posts to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage the connection between Dynamics 365 and Social Engagement](../social-engagement/manage-connection-dynamics-365-social-engagement.md)  
  
### Privacy Notice  
 [!INCLUDE[cc_privacy_mse_post_and_automation_rules](../includes/cc-privacy-mse-post-and-automation-rules.md)]  
  
### See Also  
 [Administer Microsoft Social Engagement](../social-engagement/administer-microsoft-social-engagement.md)   
 [Set up the connection between Dynamics 365 and Social Engagement](../social-engagement/connect-dynamics-365-social-engagement.md)   
 [Create a new Dynamics 365 record from a social post](../social-engagement/create-dynamics-365-record-from-social-post.md)
 
