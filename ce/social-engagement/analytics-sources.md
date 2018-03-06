---
title: "Analytics for sources in Social Engagement | Microsoft Docs"
description: "Learn how to focus your analysis on the various data sources in Social Engagement."
keywords: "sources, analytics, twitter, reddit, facebook, news, blogs, youtube, forums, rss"
ms.date: 10/17/2017
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 3db3ba46-b1a9-41a3-9012-c8e84bb8c5af
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Analyze the sources for the posts
Understand which top social media sources are found most often in your search topics. Using the **Sources** page, you can view analytics such as top sources, top languages, and the sentiment values involved with the posts on these sources.  
  
Go to this page from **Analytics > Sources**.  
  
## Static widgets on the Sources page  
  
|Widget name|What it displays|Metrics|  
|-----------------|----------------------|-------------|  
|Sources History|Volume history for posts from the different sources in the selected time frame.|-   Post volume|  
|Activities|Type of posts based on the volume.|-   Percentage of common posts<br />-   Percentage of comments and replies<br />-   Percentage of retweets and shares|  
|Phrases by Sources|Top phrases for the top five sources based on the volume.|-   Source icon<br />-   Phrases|  
|Languages|The list of five most spoken languages based on the volume of posts using these.<br /><br /> If the set languages are fewer than five, the available number of languages will be displayed in the order of their volume of posts.|-   Top five languages based on the volume of posts using these<br />-   Percentage of posts volume when compared with the total volume of the posts in the current data set<br />     To view the percentage, hover over the graph displayed for each language.<br />-   Trend|  
|Volume Change by Source|Change in post volume for the top five sources, whether increasing or decreasing as compared to previous periods.|-   Name of the source<br />-   Volume change<br />-   Trend|  
|Sources|The Sources widget shows the number of posts in the most active sources, and summarizes how many posts were found in other sources.<br /><br /> Click the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") at the top right to expand the widget to Full view mode.|-   Source icon<br />-   Post volume<br />-   Trend|  
  
## Dynamic widgets on the Sources page  
  
|Widget name|What it displays|Metrics|Display conditions|  
|-----------------|----------------------|-------------|------------------------|  
|Sources by Sentiment|Top five sources along with their sentiment index.|-   Names of the top five sources by volume<br />-   Trend of the sentiment index|-   The current analysis focus is a search topic, not **All Search Topics** or a category.<br />-   The rules in the current search topic contain at least one of the available sentiment languages.|  
|Location Insights|Markers for posts that contain location information.|-   Volume of posts in different locations|-   The rules in the current topic should contain at least one of the sources that support location information.|  
|Authors by Source|Authors by Source not only shows the most active sources, but also summarizes how many authors posted in the other sources.|-   Total number of unique authors<br />-   Percentage of the number of authors per source<br />-   Top five sources<br />-   Number of unique authors per source<br />-   Trend|-   Your current data set contains at least one unique author.|  
|Authors|The normal view of this widget displays the top five authors and the sources, based on the volume of their posts.<br /><br /> Click the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") at the top right to expand the widget to Full view mode.<br /><br /> Full view mode displays additional details about the 100 most active authors and their posts. Full view also displays a **Delete** button ![Delete button](media/trashbin-icon.png "Delete button") that you can use to [delete a selected author](manage-authors.md) and the author’s posts. You must have the **Power Analyst** or **Administrator** user role to delete an author.<br /><br /> To add a filter for multiple authors at the same time, select the check box on the left side of the list for each author that you want to include. Then click **Include** in the list header.<br /><br /> To remove an author from the authors filter, select the check box on the left side of the list for each author that you want to remove from the filter. Then click **Exclude** in the list header.|**Metrics in normal view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source from where the author has posted<br />-   Trend value for the authors<br /><br /> **Metrics in Full view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source<br />-   Number of posts<br />-   Trend<br />-   Sentiment<br />-   Reach<br />-   Location<br />-   Language<br />-   Time when the latest post was posted<br />-   Author details for Twitter ![View author details button in Social Engagement](media/author-details-icon.png "View author details button in Social Engagement")<br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get details on specific authors](author-details.md)<br />-   Delete button ![Delete button](media/trashbin-icon.png "Delete button")|Your data set doesn’t contain posts with positive or negative sentiment value. You can hide them by applying a Sentiment filter for neutral sentiment.|  
  
> [!CAUTION]
>  Once you delete an author, none of the author’s previous posts will be available in the solution’s database; they will be permanently deleted. No new posts from this author will be acquired in the future.  
  
### See Also  
[Analyze social data using widgets](analyze-social-data-using-widgets.md)   
[See the locations for the posts](analytics-location.md)
 
