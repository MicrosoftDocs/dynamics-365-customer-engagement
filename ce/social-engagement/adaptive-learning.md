---
title: "Adaptive learning in Social Engagement | Microsoft Docs"
description: "Learn about sentiment analysis and the organization-based machine learning models which learn from your inputs."
keywords: ""
ms.date: 12/08/2017
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 2c056a5c-d890-4106-837a-d4b403e011a1
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom: dyn365-socialengagement
---

# Adaptive learning based on changes to organization’s sentiment values
[!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] now uses *adaptive learning* to gain information about your edits and confirmations on sentiment values. With adaptive learning, every edit on the sentiment value of posts contributes to the way that sentiments are determined for your organization.  
  
To manage adaptive learning in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], you need to be a Social Engagement Administrator. Every user role in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] is able to edit the sentiment value of a post. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Understand user roles](user-roles.md)  
  
> [!IMPORTANT]
>  Edited and confirmed sentiment values only apply to your organization database. Edits and confirmations performed on other organizations’ databases have no impact on how the sentiment is determined for your organization.  
  
## Activate or deactivate machine learning for your organization  
By default, machine learning is active for your organization, but you can turn it off at any time.  
  
1.  Navigate to **Settings** > **Global Settings**.  
  
2.  In the list, click **Sentiment**.  
  
3.  On the **Sentiment** pane, clear the **Adaptive learning** check box.  
  
4.  Click **Save** ![Save button](media/save-icon.png "Save button").  
  
Your organization’s sentiment analysis no longer learns from your users’ edits.  
  
To turn machine learning on, select the **Adaptive learning** check box and click **Save** ![Save button](media/save-icon.png "Save button"). Your organization’s sentiment analysis will now be able to learn from your users’ edits.  
## Reset your organization’s sentiment analysis  
If you aren’t happy with the results of the sentiment analysis, you can always reset your organization’s sentiment analysis to the system default. This will discard all previously made edits and confirmations to sentiment values, and restart the learning from the system default.  
  
 [!INCLUDE[proc_permissions_social_listening_admin](../includes/proc-permissions-social-listening-admin.md)]  
  
1.  Navigate to **Settings** > **Global Settings**.  
  
2.  In the list, click **Sentiment**.  
  
3.  On the **Sentiment** pane, click **Reset**.  
  
> [!NOTE]
>  If you restart the learning for the sentiment analysis, you’ll find the date of the restart at the bottom of the page when you go to **Global Settings** > **Sentiment**.  
  
> [!CAUTION]
>  There’s no way of undoing this reset. Use this functionality careful to avoid accidental loss of all your users’ edits and confirmation to sentiment values.  
  
> [!TIP]
>  If you compare several months of Sentiment KPI, make sure that you account for the matured sentiment calculation when comparing the findings.  
  
### See Also  
[Manage global settings](manage-global-settings.md)   
[Understand the public perception using sentiment analysis](analytics-sentiment.md)
 
