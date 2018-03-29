---
title: "Analytics for locations in Social Engagement | Microsoft Docs"
description: "Learn how to focus your analysis on location data in Social Engagement."
keywords: "analytics, locations, maps, location analysis"
ms.date: 03/19/2018
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

# Focus your analysis on location data

Get insights from geographical location information contained in posts or in authors’ profiles. Using the **Location** page, you can analyze your data set with a strong focus on where posts are coming from.  
  
In [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)], go to **Analytics** > **Conversations** to access the conversations page.  

![Screenshot of the location page in the Analytics area of Social Engagement](media/analytics-location.png "Screenshot of the location page in the Analytics area of Social Engagement")
  
## Types of location data  

In [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], two types of location data are available:  
  
- **Author location:** Location data that is shared by a user through a profile, for example, on a user’s [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile page. It is an approximate value, because the system calculates geographical coordinates. If no post location is provided by the user, the author location is considered, where available.  
  
- **Post location:** Location data that shows where (latitude/longitude) a post was published. The location can differ greatly between posts from the same author, depending on the settings that are applied when publishing the post. It is an exact value because geographical coordinates are provided with the post.  
  
Both types of location data are available under the [**Location Type** filter](understand-filters.md#location-type) when defining a data set. 
  
For the United States, you can choose between two ways of grouping visualized data. To see how many posts with location data are available in each subregion, apply a filter for post location and select **Subregions**. To see posts with precise geographical information (post location data) on the map, select **Posts**.

> [!NOTE]
>  Some posts may have both post and author location. In these cases, the post location information is considered&mdash;not the author location.  
  
## Sources that provide location data  

A subset of available sources provides location data. Authors need to share their location information, so it can be processed by [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)].  

  
||Author location|Post location|  
|-|---------------------|-------------------|  
|[!INCLUDE[tn_twitter](../includes/tn-twitter.md)]|Yes|Yes|  
|News|Yes|No|  
|[!INCLUDE[tn_facebook](../includes/tn-facebook.md)]|No|No|  
|Blogs|No|No|  
|Videos|No|No|  
|Forums|Yes|No|  
|[!INCLUDE[tn_instagram](../includes/tn-instagram.md)]|No|Yes|  
  
<<<<<<< HEAD
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


|Name of the widget|What it displays|Metrics |Display conditions|  
|------------------------|----------------------|-------------|------------------------|  
|Location Groups|Top five location groups.|-   Location group name<br />     Volume of posts<br />-   Trend|Displays only if the location groups include the country/region of the post location or author location of your current data set.|  
|Sentiment|Sentiment index based on the type of sentiment:  positive, negative, or neutral.<br /><br /> You can manually change the sentiment values in case you think any posts are incorrectly analyzed for the sentiment index. More information: [Understand the public perception using Sentiment Analysis](analytics-sentiment.md)|-   Sentiment index on the scale of -10  to +10<br />-   Volume<br />-   Trend|-   The current filter is a search topic, not **All Search Topics**, or a category.<br />-   The rules in the current search topic contain at least one of the six sentiment languages.|  
|Sentiment by Country/Region|Sentiment index by country/region and trend of the sentiment index.|-   Names of the top five countries/regions based on post volume<br />-   Sentiment index on the scale of – 10 to +10<br />-   Trend of the sentiment index|-   The current filter is a search topic, not **All Search Topics**, or a category.<br />-   The rules in the current search topic contain at least one of the six sentiment languages.|  
|Authors|The normal view of this widget displays the top five authors and the sources, based on the volume of their posts.<br /><br /> Click the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") to expand the widget to Full view mode.<br /><br /> Full view mode shows additional details about the 100 most active authors and their posts. Full view also includes a **Delete** button ![Delete button](media/trashbin-icon.png "Delete button") that you can use to [delete a selected author](manage-authors.md) and the author’s posts. You must have the **Power Analyst** or **Administrator** user role to delete an author.<br /><br /> To add a filter for multiple authors at once, select the check boxes on the left side of the list for all authors that you want to include. Then click **Include** in the list header.<br /><br /> To remove an author from the Authors filter, select the check boxes on the left side of the list for all authors that you want to remove from the filter. Then click **Exclude** in the list header.|**Metrics in normal view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source from where the author has posted<br />-   Trend value for the authors<br /><br /> **Metrics in Full view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source<br />-   Number of posts<br />-   Trend<br />-   Sentiment<br />-   Reach<br />-   Location<br />-   Language<br />-   Time when the latest post was posted<br />-   Author details for Twitter ![View author details button in Social Engagement](media/author-details-icon.png "View author details button in Social Engagement")<br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See author details](author-details.md)<br />-   Delete button ![Delete button](media/trashbin-icon.png "Delete button")|Your data set doesn’t contain posts with positive or negative sentiment value. You can hide them by applying a Sentiment filter for neutral sentiment.|  
|Sentiment|Sentiment index based on the type of sentiment: positive, negative, or neutral.|-   Sentiment index<br />-   Volume<br />-   Trend|Your data set contains at least one post with a positive or negative sentiment value.|  
=======
## Authors

The normal view of this widget shows the top five authors and sources, based on the volume of posts and trend indicator. Select the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") to expand the widget and find more details such as reach, source, and location for the 100 most-active authors and their posts.    
To add a filter for multiple authors at once, select the check boxes on the left side of the list for all authors that you want to include. Then select **INCLUDE** in the list header. To remove an author from the authors filter, select the check boxes on the left side of the list for all authors that you want to remove from the filter. Then select **EXCLUDE** in the list header.

> [!NOTE]
> Full view also has a **Delete** button ![Delete button](media/trashbin-icon.png "Delete button") you can use to [delete a selected author](manage-authors.md) and the author’s posts. You must have a **Power Analyst** or **Administrator** user role to delete an author.
>  When you delete an author, none of the author’s previous posts will be available in the solution’s database; they are permanently deleted. No new posts from this author will be acquired in the future. 

## Cities

Lists the cities where most posts are coming from and their trend indicator. You can't drill down into more details from this list. 

## Languages

Lists the five most-used languages based on the volume of posts and their trend indicator.

## Locations

Lists the countries/regions where most posts are coming from and their trend indicator.

## Location coverage

Shows the percentage of posts and authors based on their location, combined with posts without location information.

## Location groups

Lists the location groups where most posts are coming from and their trend indicator.  

Dynamic widget. Shows only if posts from a country/region in the [configured location groups](manage-global-settings.md#create-and-manage-location-groups) are available. 

## Location insights

Visualizes the posts with location information on a map to find out where the posts are coming from. You can also [define an activity map](activity-maps.md) to see new posts in real-time, with additional functionality. 

 - ![Single post symbol](media/single-post-marker.png "Single post symbol") Single post in a specific location.
 - ![Multiple posts symbol](media/post-cluster-marker.png "Multiple posts symbol") Multiple posts at the same location.
 - ![Cluster symbol](media/map-cluster-marker.png "Cluster symbol") Clusters of posts with location data in the same area.

## Phrases by country/region

Lists the most-mentioned phrases coming from the five countries/regions with the most posts in the current data set.
>>>>>>> da29597b4be336aa94753e8c765487c209b84494
  

## Sentiment

Visualizes the sentiment index across all posts with a sentiment value in the selected data set. It also shows the change in sentiment index compared to the last similar time frame and a trend indicator.    
You can [manually change the sentiment values](analytics-sentiment.md) if a post's sentiment is analyzed incorrectly. 

Dynamic widget. Shows only if the data set contains posts with sentiment value.
  
### See Also

[Analyze social data using widgets](analyze-social-data-using-widgets.md)   
[Get to know your filters](use-filters.md)    
[Explore more options with your data set](more-options-with-data-set.md)    
