---
title: "Analytics for sentiment in Social Engagement | Microsoft Docs"
description: "Learn how to focus your analysis on sentiments and tonality in Social Engagement."
keywords: "sentiment, natural language processing, tonality, analytics, sentiment analysis"
ms.date: 02/28/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: eafeef08-d2ea-470a-a538-9010b19bb7dd
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Understand the public perception using sentiment analysis
View and understand the sentiments in the social chat related to the posts that are found by your search topics. Using the **Sentiments** page, [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)] calculates the sentiment value of social posts with natural-language processing and machine learning techniques. From the details displayed on this page, you can understand the positive, negative, or neutral sentiments and also the volume and the sources they come from.  
  
Navigate to this page from **Analytics > Sentiments**.  
  
## See the perception of a post and its sentiment value  
Each post that results from your defined searches is processed by the sentiment algorithm in the original language and annotated with a calculated sentiment value. For more information on the supported languages, you can download the [Microsoft Social Engagement Translation Guide](http://go.microsoft.com/fwlink/p/?LinkID=391086).  
  
The sentiment value results in a positive, negative, neutral, or unknown sentiment for a post. Occasionally, the algorithm identifies positive and negative parts of a sentence and still rates the post as neutral. This happens because the amount of a post’s text identified as positive or negative cancel each other out. A post is also classified as neutral if there are no positive or negative statements detected in it. Unknown sentiment value indicates that the post’s language isn’t supported by the sentiment algorithm.  
  
The sentiment values from posts with positive or negative sentiment that match your defined filters are normalized and result in the sentiment index for your search topic.  
  
## See the normalized perception of a data set and its sentiment index  
The sentiment index is normalized to a value between -10 and 10. All your active filters and parameters are taken into account to define the data set that the sentiment index is calculated for.  
  
-   A sentiment index of 10 means that there are no negative posts in your data set.  
  
-   A sentiment index of 0 means that there is an equal amount of positive and negative posts in your data set.  
  
-   A sentiment index of -10 means that there are no positive posts in your data set.  
  
You can calculate the sentiment index with the following formula:  
  
`Sentiment index = (Positive posts – Negative posts)/(Positive posts + Negative posts) * 10`  
  
You’ll find the change in trend next to the sentiment index. [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] compares the sentiment index of previous time frames to the current value of the sentiment index in your time frame. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [View the trend values](analyze-social-data-using-widgets.md)  
  
## Static widgets on the Sentiments page  
  
|Name of the widget|What it displays|Metrics|  
|------------------------|----------------------|-------------|  
|Sentiment History|Sentiment changes over different time lines, sentiment index associated with these and the sentiment index for previous period|-   Positive<br />-   Negative<br />-   Steady|  
|Sentiment Coverage|Sentiment coverage values for the current sentiments displayed on the widgets|-   System-rated sentiment<br />-   Edited sentiment<br />-   Unknown data, if a post’s language doesn’t support sentiment calculation|  
|Sentiment|Sentiment index based on the type of sentiment - positive, negative, or neutral.|-   Index for positive, negative or neutral sentiments<br />-   Volume<br />-   Trend|  
|Sources by Sentiment|Top five sources and the sentiment index for the sources|-   Sentiment index on the scale of +10 to -10 scale.<br />-   Trend.|  
|Negative Phrases|Top phrases from posts with negative sentiment values|-   Phrases by volume<br />-   Sentiment index|  
|Positive Phrases|Top phrases from posts with positive sentiment values|-   Phrases by volume<br />-   Sentiment index|  
  
## Dynamic widgets on the Sentiments page  
  
|Name of the widget|What it displays|Metrics|Display conditions|  
|------------------------|----------------------|-------------|------------------------|  
|Location Insights|Volume and trend displayed on a map|-   Volume of posts from different locations<br />-   Sentiment index for the posts on these locations|The rules in the current topic contains at least one of the sources that support location information and the authors shared the location information.|  
|Top Fans|List of authors who published the most posts with a positive sentiment value.|-   Source<br />-   Author name<br />-   Volume of posts with positive sentiment value.|Your data set contains posts with positive sentiment value.|  
|Top Critics|List of authors who published the most posts with a negative sentiment value.|-   Source<br />-   Author name<br />-   Volume of posts with negative sentiment value.|Your data set contains posts with negative sentiment value.|  
|Authors|The normal view of this widget displays the top five authors and the sources, based on the volume of their posts.<br /><br /> Click the **Full view** button ![Full view button](media/open-full-view-icon.png "Full view button") at the top right to expand the widget to Full view mode.<br /><br /> Full view mode displays additional details about the 100 most active authors and their posts. Full view also displays a **Delete** button ![Delete button](media/trashbin-icon.png "Delete button") that you can use to [delete a selected author](manage-authors.md) and the author’s posts. You must have the **Power Analyst** or **Administrator** user role to delete an author.<br /><br /> To add a filter for multiple authors at once, select the check boxes on the left side of the list for all authors that you want to include. Then click **Include** in the list header.<br /><br /> To remove an author from the authors filter, select the check boxes on the left side of the list for all authors that you want to remove from the filter. Then click **Exclude** in the list header.|**Metrics in normal view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source from where the author has posted<br />-   Trend value for the authors<br /><br /> **Metrics in Full view**<br /><br /> -   Author name and profile picture (if available)<br />-   Source<br />-   Number of posts<br />-   Trend<br />-   Sentiment<br />-   Reach<br />-   Location<br />-   Language<br />-   Time when the latest post was posted<br />-   Author details for Twitter ![View author details button in Social Engagement](media/author-details-icon.png "View author details button in Social Engagement")<br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See author details](author-details.md)<br />-   Delete button ![Delete button](media/trashbin-icon.png "Delete button")|Your data set doesn’t contain posts with positive or negative sentiment value. You can hide them by applying a Sentiment filter for neutral sentiment.|  
  
> [!CAUTION]
>  Once you delete an author, none of the author’s previous posts will be available in the solution’s database any more, they will be permanently deleted. No new posts from this author will be acquired in the future.  
  
### See Also  
[Analyze social data using widgets](analyze-social-data-using-widgets.md)   
[See the locations for the posts](analytics-location.md)   
[Adaptive learning based on changes to organization’s sentiment values](adaptive-learning.md)
 
