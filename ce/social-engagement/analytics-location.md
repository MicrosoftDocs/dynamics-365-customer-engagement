---
title: "Analytics for locations in Social Engagement | Microsoft Docs"
description: "Learn how to focus your analysis on location data in Social Engagement."
keywords: "analytics, locations, maps, location analysis"
ms.date: 03/02/2018
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
  
In [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)], go to **Analytics > Conversations** to access the conversations page.  

![Screenshot of the location page in the Analytics area of Social Engagement](media/analytics-location.png "Screenshot of the location page in the Analytics area of Social Engagement")
  
## Types of location data  

In [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)], two types of location data are available:  
  
- **Author location:** Location data that is shared by a user through a profile (for example, on a user’s [!INCLUDE[tn_twitter](../includes/tn-twitter.md)] profile page). Consider this an approximate value because the geographical coordinates are calculated by the system. If no post location is provided by the user, the author location is taken into account, where available.  
  
- **Post location:** Location data that determines from which geographical point (latitude/longitude) a post was published. This can differ greatly between posts from the same author, depending on the applied settings when publishing the post. This is an exact value because geographical coordinates are provided with the post.  
  
Both types of location data are available under the [**Location Type** filter](use-filters.md) when defining a data set. 
  
For some locations, for example the United States, you can choose between two ways of grouping the visualized data. To see how many posts with location data are available in each subregion, apply a filter for post location and select **Subregions**. To see posts with precise geographical information (post location data) on the map, select **Posts**.

[comment]: <> (Confirm with PM and in UI)
  
> [!NOTE]
>  Some posts may have both post and author location. In these cases, the post location information is taken into account (and not the author location).  
  
## Sources that provide location data  

A subset of the available sources provide location data. Authors need to share their location information so it can be processed by [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)].  

[comment]: <> (Review list with PM and Acq Dev for completeness. Move to sources-coverage.)
  
||Author location|Post location|  
|-|---------------------|-------------------|  
|[!INCLUDE[tn_twitter](../includes/tn-twitter.md)]|Yes|Yes|  
|News|Yes|No|  
|[!INCLUDE[tn_facebook](../includes/tn-facebook.md)]|No|No|  
|Blogs|No|No|  
|Videos|No|No|  
|Forums|Yes|No|  
|[!INCLUDE[tn_instagram](../includes/tn-instagram.md)]|No|Yes|  
  
## Authors

The normal view of this widget shows the top five authors and the sources, based on the volume of their posts and their trend indicator. Select the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") to expand the widget and find additional details such as reach, source, and location about the 100 most active authors and their posts.    
To add a filter for multiple authors at once, select the check boxes on the left side of the list for all authors that you want to include. Then select **INCLUDE** in the list header. To remove an author from the authors filter, select the check boxes on the left side of the list for all authors that you want to remove from the filter. Then select **EXCLUDE** in the list header.

> [!NOTE]
> Full view also has a **Delete** button ![Delete button](media/trashbin-icon.png "Delete button") you can use to [delete a selected author](manage-authors.md) and the author’s posts. You must have a **Power Analyst** or **Administrator** user role to delete an author.
>  When you delete an author, none of the author’s previous posts will be available in the solution’s database; they are permanently deleted. No new posts from this author will be acquired in the future. 

## Cities

Lists the cities where most posts are coming from and their trend indicator.

## Languages

Lists the five most-found languages based on the volume of posts and their trend indicator.

##Locations
Lists the countries/regions where most posts are coming from and their trend indicator.

## Location coverage

Shows the percentage of posts and authors based on their location details, combined with posts without location information.

## Location Groups

Lists the location groups where most posts are coming from and their trend indicator.  

Dynamic widget. Shows only if posts from a country/region in the [configured location groups](manage-global-settings.md#create-and-manage-location-groups) is available. 

##Location insights

Visualizes the posts with location information on a map to find out where the posts are coming from. You can also [define an activity map](activity-maps.md) to see new posts in real-time, with additional functionality. 

 - ![Single post symbol](media/single-post-marker.png "Single post symbol") Single post in a specific location
 - ![Multiple posts symbol](media/post-cluster-marker.png "Multiple posts symbol") Multiple posts at the same location
 - ![Cluster symbol](media/map-cluster-marker.png "Cluster symbol") Clusters of posts with location data in the same area

## Phrases by country/region

Lists the most mentioned phrases coming from the five countries/regions with the most posts in the current data set.
  

## Sentiment

Visualizes the sentiment index across all posts with sentiment value in the selected data set. Additionally, you find the change in sentiment index compared to the last similar time frame and its trend indicator.    
You can [manually change the sentiment values](analytics-sentiment.md) if you find a post's sentiment incorrectly analyzed. 

Dynamic widget. Shows only if the data set contains posts with sentiment value.
  
### See Also

[Analyze social data using widgets](analyze-social-data-using-widgets.md)   
[Get to know your filters](use-filters.md)    
[Explore more options with your data set](more-options-with-data-set.md)    