---
title: "Analytics for conversations in Social Engagement | Microsoft Docs"
description: "Learn how to focus your analysis on conversations in Social Engagement."
keywords: "analytics, conversation, phrases, fans, critics"
ms.date: 02/14/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 4396dadd-6cbb-4298-83be-b8dae50141b6
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Gain insights from public conversations
View detailed content analytics on the Conversations page. Using the **Conversations** page, you can understand data like the most-used phrases, their volume, sources these conversations are coming from, and sentiment involved.  
  
Go to this page from **Analytics > Conversations**.  
  
## Static widgets on the Conversations page  
  
|Widget name|What it displays|Metrics|  
|-----------------|----------------------|-------------|  
|Phrases|The top phrases by volume/trend and sentiment.|-   Volume of posts containing a phrase|  
|Phrases History|Top phrases by volume over time.|-   Top phrases<br />-   Phrases history by volume|  
|Trending Phrases|Significant phrases in the current data set , as compared to the significant phrases in the previous five time frames.|-   Volume of posts containing a phrase<br />-   Trend|  
|Sources|Top five sources based on the volume of posts.|-   Volume<br />-   Percentage of volume as compared with the total volume of posts in the data set<br />-   Trend|  
|Phrases on \<Top Source>|Significant phrases on the top source (when compared to all sources), based on the volume of the phrases on the source.<br /><br /> If only one source is filtered, the volume of phrases shown is based on the volume in the current time frame.|-   Post volume in the current time frame|  
|Languages|The top five languages based on the volume of posts that used these languages.|-   Name of the language<br />-   Post volume<br />-   Percentage of volume as compared to all posts in your data set<br />-   Trend|  
  
## Dynamic widgets on the Conversations page  
  
|Widget name|What it displays|Metrics|Display conditions|  
|-----------------|----------------------|-------------|------------------------|  
|Sentiment|Sentiment index and sentiment values: positive, negative, or neutral.|-   Sentiment score<br />-   Volume<br />-   Trend|-   The current filter is a search topic, not All Search Topics or a category.<br />-   The rules in the current search topic contain at least one of the available sentiment languages.|  
|Location Insights|Markers for posts that include location information.|-   Volume of posts from different locations|-   The rules in the current topic contain at least one of the sources that support location information.|  
|Hashtags|List of the [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] hashtags that were found most often in the posts of your current data set.|-   Hashtag<br />-   Volume of posts containing the hashtag<br />-   Trend value for the hashtag|-   Your current data set contains [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] posts that provide hashtags in the post contents.|  
|[!INCLUDE[tn_twitter](../includes/tn-twitter.md)] Mentions|List of the mentioned [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] accounts that were found most often in the posts of your current data set.|-   Author name<br />-   Volume of posts mentioning this author<br />-   Trend value for the number of mentions of this author|-   Your current data set contains [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] posts that mention an author in the post contents.|  
|Intentions|Distribution of the intentions in your current data set. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with tags](tags.md "Work with tags")|-   Total number of posts with intentions<br />-   Number of posts per intention tag<br />-   Trend per intention tag|-   At least one post in your data set contains an intention tag.|  
|Tags|Distribution of custom tags in your current data set. The Full view mode offers the top 100 tags.<br /><br /> Intentions are not included in the Tags widget. They are only displayed in the Intentions widget.|-   Total number of posts with custom tags<br />-   Number of posts per custom tag<br />-   Trend per custom tag|-   At least one post in your data set contains a custom tag.|  
|Sentiment|Sentiment index based on the type of sentiment: positive, negative or neutral.|-   Sentiment index<br />-   Volume<br />-   Trend|-   Your data set contains at least one post with positive or negative sentiment value.|  
|Authors|The normal view of this widget showss the top five authors and the sources, based on the volume of their posts.<br /><br /> Click **Full view** ![Full view button](media/open-full-view-icon.png "Full view button") at the top right to expand the widget to Full view mode.<br /><br /> Full view mode shows additional details about the 100 most-active authors and their posts. Full view mode also has a **Delete** button ![Delete button](media/trashbin-icon.png "Delete button") that you can use to [delete a selected author](manage-authors.md) and the author’s posts. You must have the **Power Analyst** or **Administrator** user role to delete an author.<br /><br /> To add a filter for multiple authors at the same time, select the check boxes on the left side of the list for all authors that you want to include. Then click **Include** in the list header.<br /><br /> To remove an author from the authors filter, select the check boxes on the left side of the list for all authors that you want to remove from the filter. Then click **Exclude** in the list header.|**Metrics in normal view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source from where the author has posted<br />-   Trend value for the authors<br /><br /> **Metrics in Full view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source<br />-   Number of posts<br />-   Trend<br />-   Sentiment<br />-   Reach<br />-   Location<br />-   Language<br />-   Time when the latest post was posted<br />-   Delete button|- Hashtags and [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] Mentions widgets don’t display. You can hide them by applying a Source filter for other sources than [!INCLUDE[tn_twitter](../includes/tn-twitter.md)].|  
  
> [!CAUTION]
>  Once you delete an author, the author’s previous posts are no longer available in the solution’s database. The posts are permanently deleted. No new posts from this author will be acquired in the future.  
  
### See Also  
 [Analyze social data using widgets](analyze-social-data-using-widgets.md)   
 [Understand widgets on the  Overview page](analytics-overview.md)   
 [Understand the public perception using sentiment analysis](analytics-sentiment.md)
 
