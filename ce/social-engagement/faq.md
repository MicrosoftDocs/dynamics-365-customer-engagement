---
title: "Frequently asked questions for Microsoft Social Engagement | Microsoft Docs"
description: "Find answers to frequently asked questions about Social Engagement."
keywords: "FAQ, questions, common issues, quota, search setup, search topics"
ms.date: 10/04/2017
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: ac2d84b4-f7c6-9694-cf10-539e529f2e25
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
ms.custom: dyn365-socialengagement
---

# Microsoft Social Engagement FAQ
Are you new to [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] or looking for some help? We've compiled a list of frequently asked questions and provided brief answers to help you get to your information quickly.  
  
## How soon will I start seeing data after I set up a search topic?  
Data acquisition starts immediately after you set up your search topic. Depending on the source, it can take up to 30 minutes from the moment a social post is posted for it to show up in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. But usually it's much faster. We don't retroactively acquire social posts; however, if there are posts in our index that match your search topic, we might show those. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up searches to listen to social media conversations](set-up-searches.md)  
  
## What are my options if I am reaching my quota limit?  
As a rule of thumb, every post you can access in Analytics counts against your post quota. If a post that was published in the current calendar month is removed from Analytics, it's also deducted from the quota usage of the current month. You have multiple options to extend or stay within your quota limits:  
  
-   You can buy a post quota add-on and increase your organization's total quota.  
  
-   You can review or delete search topics or search rules that you don't need any more. This usually leads to fewer posts getting acquired and thus helps you stay on track with your monthly post quota.  
  
-   You can narrow your search rules by removing keywords, or adding inclusions or exclusions.  
  
-   You can add keywords and phrases to the list of blocked content to delete the posts that contain these terms, and free up some quota space.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage your post quota](manage-post-quota.md), [Manage the quality of your search results](search-results-quality.md)  
  
## What happens if I exceed my post quota?  
Administrators start receiving email notifications when the estimated post volume for data acquisition seems likely to exceed the monthly post quota, regardless of how much quota is already consumed. If you exceed the post quota, data acquisition is stopped after a grace period. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage your post quota](manage-post-quota.md)  

## Why does the number of posts in Search Setup Quota differ from Analytics?
You might notice that there is a difference between the **Current number of posts** shown in the **Search Setup Quota** section and the **Analytics** dashboard when the time frame is set to the current month.  
There are two common reasons for this:
- The **Analytics** page honors the web browser's time zone so that the posts displayed there are the posts for the month in your time zone. The Quota section, however, uses [Coordinated Universal Time](https://en.wikipedia.org/wiki/Coordinated_Universal_Time) to calculate the number of posts for the month.  
For example, if your browser is set to the Hawaii–Aleutian time zone (UTC-10), your Quota section would include the posts from the last ten hours of the previous month _in your time zone_.
- You deleted search topics this month. Posts that were already acquired by the now-deleted search topic will still count against your monthly quota shown in the **Search Setup Quota** section. They will not appear in the Analytics posts number because they do not match any of your current search topics.
  
## Why is there no Facebook in keyword search?  
Facebook changed its APIs in April 2015. Although it's no longer possible to create keyword search rules for the Facebook source, you can still add entire Facebook pages to your search topics to track activities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add rules to a search topic](add-rules-search-topic.md)  
  
## On what level can I filter for Location from the filter section?  
You can drill down to the level of all available countries/regions in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. In addition, you can create your own location groups to quickly filter for a set of countries/regions. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage global settings](manage-global-settings.md)  
  
## Why can't I filter on the Top Cities widget in the Location dashboard?  
We currently don't support filtering at the city level.  
  
## Why can't I see the original post on some of the News posts in the posts view?  
In addition to covering online news, the News coverage provided by [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] also covers news venues that are not publicly available on the web (for example, behind a pay wall). In such a case, no link to the original source is available for the post.  
  
## Is there a limit to the number of terms or phrases that can be used in a keyword search rule?  
Although you can create an unlimited number of search rules per search topic, there is a limit on the length and number of terms.  
  
-   Maximum length, in characters, of search topic names: 35.  
  
-   Maximum length, in characters, per keyword, inclusion, and exclusion: 128.  
  
-   Maximum number of keywords per rule: 15.  
  
-   Maximum number of inclusions per rule: 15.  
  
-   Maximum number of exclusions per rule: 25.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add rules to a search topic](add-rules-search-topic.md)  
  
## Does your sentiment analysis accurately read emoticons or emoji?  
 There is a difference between *emoticons* (for example, **:)** or **:(**) and *emoji* (icons used mainly on mobile devices and IM). Our sentiment algorithm handles emoticons in addition to emoji, and assigns positive and negative values accordingly.  
  
### See also
 [Get started with Social Engagement](get-started.md)   
 [Administer Microsoft Social Engagement](administer-microsoft-social-engagement.md)   
 [Set up searches to listen to social media conversations](set-up-searches.md)
 
