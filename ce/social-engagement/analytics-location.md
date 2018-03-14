---
title: "Analytics for locations in Social Engagement | Microsoft Docs"
description: "Learn how to focus your analysis on location data in Social Engagement."
keywords: "analytics, localtions, maps, location analysis"
ms.date: 10/17/2017
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 8aec5246-e411-4fb9-9790-2bcd94438038
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# See the locations for the posts
View the analysis for geographical location information contained in posts or in authors’ profiles. Using the **Location** page, you can view details such as top locations, top languages, and top location groups.  
  
Go to this page from **Analytics > Location.**  
  
## Types of location data  
In [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], two types of location data are available:  
  
- **Author location:** Location data that is shared by a user through a profile (for example, on a user’s [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile page). Consider this an approximate value because the geographical coordinates are calculated by the system. If no post location is provided by the user, the author location is taken into account, where available.  
  
- **Post location:** Location data that determines from which geographical point (latitude/longitude) a post was published. This can differ greatly between posts from the same author, depending on the applied settings when publishing the post. This is an exact value because geographical coordinates are provided with the post.  
  
Both types of location data are available under the **Location Type** filter when performing analysis. More information: [Get relevant data using filters](use-filters.md)  
  
For some locations, for example the United States, you can choose between two ways of grouping the visualized data. To see how many posts with location data are available in each subregion, apply a filter for post location and select **SUBREGIONS**. To see posts with precise geographical information (post location data) on the map, select **POSTS**.  
  
> [!NOTE]
>  Some posts may have both post and author location. In these cases, that post is counted for the post location metric (and not counted for author location metric).  
  
## Sources that provide location data  
A subset of the available sources that provide location data. Authors need to share their information to see location for sources.  
  
||Author location|Post location|  
|-|---------------------|-------------------|  
|[!INCLUDE[tn_twitter](../includes/tn-twitter.md)]|Yes|Yes|  
|News|Yes|No|  
|[!INCLUDE[tn_facebook](../includes/tn-facebook.md)]|No|No|  
|Blogs|No|No|  
|Videos|No|No|  
|Forums|Yes|No|  
|[!INCLUDE[tn_instagram](../includes/tn-instagram.md)]|No|Yes|  
  
## Static widgets on the Location page  
  
|Name of the widget|What it displays|Metrics|  
|------------------------|----------------------|-------------|  
|Location Insights|Markers for posts that contain location information.<br /><br /> For your reference, a legend for the available push pins is provided on the map.<br /><br /> - ![Single post symbol](media/single-post-marker.png "Single post symbol") Single post in a specific location<br />- ![Multiple posts symbol](media/post-cluster-marker.png "Multiple posts symbol") Multiple posts at the same location<br />- ![Cluster symbol](media/map-cluster-marker.png "Cluster symbol") Clusters of posts with location data in the same area|-   Volume<br />-   Sentiment<br />-   Buzz|  
|Location Coverage|Percentage of posts and authors based on their location details.|-   Post location<br />-   Author location<br />-   No location data available|  
|Phrases by Country/Region|Top phrases coming from the five countries/regions with the most posts.|-   Name of the country/region<br />-   Most mentioned phrases in a country/region|  
|Cities|Top five cities based on the volume of the posts.|-   Name of the city<br />-   Volume of posts<br />-   Trend|  
|Languages|Top five languages based on  the volume of posts that used these languages.|-   Name of the language<br />-   Volume of posts<br />-   Percentage of post volume when compared with the total volume of posts in the current data set<br />-   Trend|  
|Locations|Top five countries/regions, based on the volume of posts.|-   Name of the country/region<br />-   Volume of posts<br />-   Trend|  
  
## Dynamic widgets on the Location page  


|Name of the widget|What it displays|Metrics &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|Display conditions|  
|------------------------|----------------------|-------------|------------------------|  
|Location Groups|Top five location groups.|-   Location group name<br />     Volume of posts<br />-   Trend|Displays only if the location groups include the country/region of the post location or author location of your current data set.|  
|Sentiment|Sentiment index based on the type of sentiment:  positive, negative, or neutral.<br /><br /> You can manually change the sentiment values in case you think any posts are incorrectly analyzed for the sentiment index. More information: [Understand the public perception using Sentiment Analysis](analytics-sentiment.md)|-   Sentiment index on the scale of -10  to +10<br />-   Volume<br />-   Trend|-   The current filter is a search topic, not **All Search Topics**, or a category.<br />-   The rules in the current search topic contain at least one of the six sentiment languages.|  
|Sentiment by Country/Region|Sentiment index by country/region and trend of the sentiment index.|-   Names of the top five countries/regions based on post volume<br />-   Sentiment index on the scale of – 10 to +10<br />-   Trend of the sentiment index|-   The current filter is a search topic, not **All Search Topics**, or a category.<br />-   The rules in the current search topic contain at least one of the six sentiment languages.|  
|Authors|The normal view of this widget displays the top five authors and the sources, based on the volume of their posts.<br /><br /> Click the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") to expand the widget to Full view mode.<br /><br /> Full view mode shows additional details about the 100 most active authors and their posts. Full view also includes a **Delete** button ![Delete button](media/trashbin-icon.png "Delete button") that you can use to [delete a selected author](manage-authors.md) and the author’s posts. You must have the **Power Analyst** or **Administrator** user role to delete an author.<br /><br /> To add a filter for multiple authors at once, select the check boxes on the left side of the list for all authors that you want to include. Then click **Include** in the list header.<br /><br /> To remove an author from the Authors filter, select the check boxes on the left side of the list for all authors that you want to remove from the filter. Then click **Exclude** in the list header.|**Metrics in normal view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source from where the author has posted<br />-   Trend value for the authors<br /><br /> **Metrics in Full view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source<br />-   Number of posts<br />-   Trend<br />-   Sentiment<br />-   Reach<br />-   Location<br />-   Language<br />-   Time when the latest post was posted<br />-   Author details for Twitter ![View author details button in Social Engagement](media/author-details-icon.png "View author details button in Social Engagement")<br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See author details](author-details.md)<br />-   Delete button ![Delete button](media/trashbin-icon.png "Delete button")|Your data set doesn’t contain posts with positive or negative sentiment value. You can hide them by applying a Sentiment filter for neutral sentiment.|  
|Sentiment|Sentiment index based on the type of sentiment: positive, negative, or neutral.|-   Sentiment index<br />-   Volume<br />-   Trend|Your data set contains at least one post with a positive or negative sentiment value.|  
  
> [!CAUTION]
>  After you delete an author, none of the author’s previous posts will be available in the solution’s database anymore; they will be permanently deleted. No new posts from this author will be acquired in the future.  
  
### See Also  
[Analyze social data using widgets](analyze-social-data-using-widgets.md)   
[Understand the public perception using sentiment analysis](analytics-sentiment.md)   
[Analyze the sources for the posts](analytics-sources.md)
 
