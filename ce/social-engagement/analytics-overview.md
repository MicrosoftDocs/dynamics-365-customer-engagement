---
title: "Start analyzing data in Social Engagement | Microsoft Docs"
description: "Learn how to get an overview about your data in Social Engagement."
keywords: "analytics, overview"
ms.date: 10/17/2017
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 8ac1759b-8534-43c9-a273-f56ce1505166
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Understand widgets on the Overview page
See key widgets on the Overview page. The widgets on this page provide information about the volume of posts, sources, and locations where these posts are coming from, topics discussed, languages used, and the details of influencing authors.  
  
Go to this page from **Analytics > Overview**.  
  
> [!NOTE]
> **Overview** is the default landing page when you go to the Analytics area, or when you choose [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] on the nav bar.  
  
## Static widgets on the Overview page  
  
|Widget name|What it displays|Metrics|  
|-----------------|----------------------|-------------|  
|Volume|Volume of posts for a selected time frame.<br /><br /> **Options**: Today, last week, last month, or custom time frame.|-   Volume of posts<br />-   Average volume of posts<br />-   Details of any unavailable data for the selected time frame|  
|Search Topics|Top five categories or search topics, based on the volume of the posts.|-   Volume of posts<br />-   Relative volume within the current data set<br />-   Trend options: All search topics, topics, categories|  
|Languages|The list of five most-found languages based on the volume of posts.|-   Top five languages by name<br />-   Volume of posts using these<br />-   Percentage of posts volume when compared with the total volume of the posts in the current data set<br />-   Trend|  
|Authors|The normal view of this widget shows the top five authors and the sources, based on the volume of their posts.<br /><br /> Click the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") to expand the widget to Full view mode.<br /><br /> Full view mode shows additional details about the 100 most active authors and their posts. Full view also has a **Delete** button ![Delete button](media/trashbin-icon.png "Delete button") you can use to [delete a selected author](manage-authors.md) and the author’s posts. You must have a **Power Analyst** or **Administrator** user role to delete an author.<br /><br /> To add a filter for multiple authors at once, select the check boxes on the left side of the list for all authors that you want to include. Then click **INCLUDE** in the list header.<br /><br /> To remove an author from the authors filter, select the check boxes on the left side of the list for all authors that you want to remove from the filter. Then click **EXCLUDE** in the list header.|**Metrics in normal view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source from where the author has posted<br />-   Trend value for the authors<br /><br /> **Metrics in Full view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source<br />-   Number of posts<br />-   Trend<br />-   Sentiment<br />-   Reach<br />-   Location<br />-   Language<br />-   Time when the latest post was posted<br />-   Author details for Twitter ![View author details button in Social Engagement](media/author-details-icon.png)<br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get details on specific authors](author-details.md)<br />-   Delete button ![Delete button](media/trashbin-icon.png "Delete button")|  
|Sources|The Sources widget shows the number of posts in the most active sources, and summarizes how many posts were found in other sources.<br /><br /> Click the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") at the top right to expand the widget to Full view mode.|-   Top sources icons<br />-   Volume of posts<br />-   Percentage of volume as compared with the total volume in the current data sets<br />-   Trend|  
|Phrases|Most often mentioned phrases, based on the posts of your current data set.|-   Volume of posts|  
  
> [!CAUTION]
>  When you delete an author, none of the author’s previous posts will be available in the solution’s database; they are permanently deleted. No new posts from this author will be acquired in the future.  
  
## Dynamic widgets on the Overview page  
  
|Widget name|What it displays|Metrics|Display conditions|  
|-----------------|----------------------|-------------|------------------------|  
|Sentiment|Sentiment index based on the type of sentiment:  positive, negative, or neutral.<br /><br /> You can manually change the sentiment values if you think any posts are incorrectly analyzed for the sentiment index. More information: [Understand the public perception using sentiment analysis](analytics-sentiment.md)|-   Sentiment index<br />-   Volume<br />-   Trend|-   The current filter is a search topic, not **All Search Topics** or a category.<br />-   The rules in the current topic contain at least one of the available sentiment languages.|  
|Post Types|Volume of posts on [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages, separated by page and by authors.|-   Volume of posts<br />-   Volume of comments|-   The selected search topic or category contains at least one [!INCLUDE[tn_facebook](../includes/tn-facebook.md)] pages rule.|  
|Categories by Sentiment|Find out about the sentiment index for all posts with sentiment value in your categories.<br /><br /> Click the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") to expand the widget to the Full view mode.|**Metrics in normal view**<br /><br /> -   Sentiment index<br />-   Trend of sentiment index<br />-   Sorted by the number of posts per category<br /><br /> **Metrics in Full view**<br /><br /> -   Categories<br />-   Sentiment index<br />-   Sentiment change<br />-   Number of positive posts<br />-   Number of negative posts<br />-   Number of neutral posts|-   Your data set contains at least one post with a positive or negative sentiment value.|  
|Topics by Sentiment|Find out about the sentiment index for all posts with sentiment value in your search topics.<br /><br /> Click the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") to expand the widget to the Full view mode.|**Metrics in normal view**<br /><br /> -   Volume of posts<br />-   Trend of sentiment index<br />-   Sorted by the number of posts per search topic<br /><br /> **Metrics in Full view**<br /><br /> -   Search topics<br />-   Sentiment index<br />-   Sentiment change<br />-   Number of positive posts<br />-   Number of negative posts<br />-   Number of neutral posts|-   Your data set contains at least one post with a positive or negative sentiment value.<br />-   The analysis focus is set to a category.|  
|Sentiment|Sentiment index based on the type of sentiment:  positive, negative, or neutral.|-   Sentiment index<br />-   Volume<br />-   Trend|-   Your data set contains at least one post with a positive or negative sentiment value.|  
  
### See Also  
[Analyze social data using widgets](analyze-social-data-using-widgets.md)   
[Find out what people are saying over conversations](analytics-conversations.md)   
[Understand the public perception using sentiment analysis](analytics-sentiment.md)   
[See the locations for the posts](analytics-location.md)   
[Analyze the sources for the posts](analytics-sources.md)
 
