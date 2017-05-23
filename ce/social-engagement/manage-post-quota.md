---
title: "Manage your post quota | Microsoft Docs"
 
description:

ms.custom: ""

ms.date: 2017-05-19
ms.reviewer: ""
ms.service: mse
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
applies_to: "Social Engagement"
ms.assetid: 9d9e5115-52c7-4f21-a90b-3bde6804d2fe
caps.latest.revision: 31
author: "m-hartmann"
ms.author: mhart
manager: sakudes
---
# Manage your post quota
Keep track of the number of posts that result from your search topics towards your solution's post quota. Your solution is priced based on the number of posts you can acquire per month.  
  
> [!NOTE]
>  This topic is part of a walkthrough on how you can set up searches. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up searches to listen to social media conversations](../social-engagement/set-up-searches.md)  
  
> [!IMPORTANT]
>  If you’re expected to exceed the post quota of the current month, you’ll get a notification email. When you exceed your post quota, data acquisition will be stopped for either of the following reasons:  
>   
>  -   You still exceed your post quota after a grace period of 48 hours from the time the notification was sent.  
>  -   Your solution passes the  additional post quota granted for the grace period, which is five times your monthly allocated quota.  
  
 For example, if your monthly post quota is 10,000 posts, your grace period starts when you receive a notification that your solution will probably exceed your quota limits. Data acquisition will be stopped automatically after 48 hours if you have exceeded your post quota by then, or as soon as your solution gathered more than 50,000 posts before the 48 hours have passed.  
  
 To see your state of your current post quota, go to **Search Setup**.  
  
 The quota period is one calendar month:  
  
-   Start: First day of a month, 00:00 AM.  
  
-   End: Last day of a month, 11:59 PM.  
  
## Get the post quota status  
 To get a quick overview on the post quota for all your search topics, for single categories, or for single search topics, go to **Search Setup** > **Summary**. For more detailed quota information, drill down into the categories and search topics to see the quota usage of these items.  
  
 If your solution tends to exceed the quota, all users with an Administrator role will get an email notification. You have the following options to take action:  
  
-   Optimize your search topics regularly. Review the search topics to make sure that only relevant data is selected. Previewing a search topic before saving it is a great help to get an impression of how many posts we're expecting for the configuration you provided.  
  
-   Maintain a list of blocked contents to avoid any posts appearing in your results from the listed domains or matching the listed keywords.  
  
-   Exclude authors who publish irrelevant posts that match one of your search queries.  
  
> [!CAUTION]
>  Proceed carefully when excluding an author or blocking contents. Posts matching items on the list of blocked contents will be deleted irreversibly after four hours. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage the quality of your search results](../social-engagement/search-results-quality.md).  
  
|Quota status|Appears|What you should do|  
|------------------|-------------|------------------------|  
|Within quota|When the calculated expectations are still within your monthly limits.|No action is required.|  
|Expected to exceed quota|If your solution is expected to reach your monthly quota before the current month ends.|Monitor your post quota closely. Alternatively, increase the post quota or edit or remove search topics or [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages.|  
|Quota exceeded|If your solution acquired more posts than your post quota allows.|Take immediate action by adding post quota. Your solution will continue to acquire posts until you either surpass the granted grace period, or until you reach the additionally granted post quota.|  
|Acquisition stopped|When Administrators were informed and the solution exceeded your post quota without any action taken. The solution’s acquisition was stopped automatically.|Increase the post quota to restart your acquisition immediately, or wait until the first day of the next month to restart the acquisition.|  
  
 Your [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] admin can upgrade your subscription and purchase additional post quotas for your solution at any time in the [Office 365 admin center](http://go.microsoft.com/fwlink/p/?LinkId=390650).  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Microsoft Dynamics CRM pricing and licensing](http://go.microsoft.com/fwlink/p/?LinkID=401462)  
  
## Keep the post quota healthy  
 Keeping the post quota healthy is crucial to make sure the data acquisition isn’t interrupted, and you don’t miss any relevant information.  
  
> [!TIP]
>  Check out the video about this content: [![Video button](../social-engagement/media/video-icon.png "Video button")](http://go.microsoft.com/fwlink/p/?LinkId=613693) [Microsoft Social Engagement Quota Management (2:33)](http://go.microsoft.com/fwlink/p/?LinkId=544938)  
  
### Impact of exceeding limits  
 All [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] Administrators receive email notifications about the monthly post quota. To reduce the number of posts found by your solution, you can narrow your search topics by removing rules that you don’t need any more. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage the quality of your search results](../social-engagement/search-results-quality.md)  
  
 If no action is taken, exceeding the post quota will get your solution blocked from data acquisition until the end of the month. No more posts are acquired, even if they match your search topics. You can [purchase additional post quota](http://go.microsoft.com/fwlink/p/?LinkID=390650) at any time to unblock your solution immediately.  
  
> [!IMPORTANT]
>  Note that [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] doesn’t gather posts retrospectively. Any missed post won’t appear in your solution if you update your post quota after the acquisition has stopped.  
  
### Understand estimations  
 On the **Summary** page in the **Search Setup** area, you’ll find quota information for all active search topics. The following values are provided for each search topic and all categories that contain a search topic:  
  
- **Monthly post quota**: The initial amount of posts that can be acquired each month.  
  
- **Current number of posts:** The total number of posts (including hidden and visible posts) that were acquired during the current calendar month.  
  
- **Expected number of posts:** The calculated number of posts that [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] is expecting until the end of the calendar month, based on the number of current posts.  
  
 When you set up a search topic, you can validate the rules to estimate how their volume affects your post quota. The rule validation provides the number of posts that would match your query within a month, based on the post volume of the past month. Additionally, if you have [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] selected as a source, you’ll find a preview of the most recent tweets matching your keywords rule.  
  
> [!CAUTION]
>  Peaks and trending terms can’t be estimated. For example, if you set up a search topic in advance for a conference that you plan to establish a hashtag for, the estimates can be far off. Be aware that the post volume will rise significantly when the conference starts, and impact your post quota. Deleting a search topic will stop the acquisition of posts for this topic, but will not recover your quota, meaning you will see no difference in the number of current posts. If you want to recover your quota, you will have to add the keywords of a deleted topic to Blocked Content.  
  
### Privacy notice  
 [!INCLUDE[cc_privacy_mse_bing_social_check](../includes/cc-privacy-mse-bing-social-check.md)]  
  
### See Also  
 [Set up searches to listen to social media conversations](../social-engagement/set-up-searches.md)   
 [Manage the quality of your search results](../social-engagement/search-results-quality.md)   
 [Refine your search rules](../social-engagement/refine-search-rules.md)
 
