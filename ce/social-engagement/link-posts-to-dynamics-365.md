---
title: "Link posts from Social Engagement to Dynamics 365 for Customer Engagement | Microsoft Docs"
description: "Learn how to link social posts to Dynamics 365 for Customer Engagement and create new case or lead records."
keywords: link to crm, link to customer engagement
ms.date: 02/14/2019
ms.service: dynamics-365-marketing
ms.topic: article
applies_to: 
  - Social Engagement
ms.assetid: e97a38d7-37c4-4dce-b02e-1076ad992cff
author: m-hartmann
ms.author: mhart
ms.custom: 
  - dyn365-socialengagement
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365SE
---

# Link posts from [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps

[!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] provides a platform for capturing public posts from social media. You link posts in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance and turn them into new records.

When you link a post from [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance, a Social Activity record is created. [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps can turn these social activities into other types of records, for example into a lead, an opportunity, or a case.

> [!NOTE]
> Social Engagement will be discontinued on January 16, 2020 and integration features will also stop working at this date. We recommend transitioning to Dynamics 365 Market Insights. Learn more about the [capabilities in Market Insights](eol/comparison-mse-mi.md) and find answers to [frequently asked questions about Social Engagement service discontinuation](eol/discontinuation-faq.md).
  
## Steps for linking posts  

1. First, [set up the feature to link social posts](connect-dynamics-365-social-engagement.md) to a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance as social activities. As a [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] Administrator, you need to connect the instance to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].   
  
2. Next, you can [define the attributes](create-dynamics-365-record-from-social-post.md) for the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] entities that you want to display in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].   
  
3. As a system administrator or customizer in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you can configure rules to handle newly created social activities by using the [**Automatic Record Creation and Update Rules**](configure-automatic-record-creation.md) feature in your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] settings.   
  
4. When everything is set up, your users can start to link social posts to create or update [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records.   
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a new Dynamics 365 for Customer Engagement record from a social post](create-dynamics-365-record-from-social-post.md)  
  
5. Optionally, you can configure [automation rules](automation-rules.md) in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] to create new [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records for posts that match a specified data set.   
  
6. Understand how to [delete or disable a connection](manage-connection-dynamics-365-social-engagement.md) and how this might affect existing linkages or linking newly acquired social posts.   
  
### Privacy notice 
 
 [!INCLUDE[cc_privacy_mse_post_and_automation_rules](../includes/cc-privacy-mse-post-and-automation-rules.md)]  
  
### See also  

 [Administer Microsoft Social Engagement](administer-microsoft-social-engagement.md)   
 [Set up the connection between Dynamics 365 for Customer Engagement and Social Engagement](connect-dynamics-365-social-engagement.md)   
 [Create a new Dynamics 365 for Customer Engagement record from a social post](create-dynamics-365-record-from-social-post.md)
