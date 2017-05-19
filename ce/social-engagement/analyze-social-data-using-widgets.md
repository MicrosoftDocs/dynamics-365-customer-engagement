---
title: "Analyze social data using widgets | MicrosoftDocs"
description:
ms.custom: ""
ms.date: "2016-11-18"
ms.reviewer: ""
ms.service: "mse"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: "Social Engagement"
ms.assetid: da974b6a-b242-40b6-95ad-df81ac78191e
caps.latest.revision: 32
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
---
# Analyze social data using widgets
Use widgets to visualize your organization’s data analytics. The easy-to-understand, visual metrics that are displayed on these widgets show you what your customers or prospects are saying about your product and services. Identify any issues or compliments that are mentioned about your products or services on social media sources. Using this analysis, you can also understand how your team is working toward the social strategies of your organization.  
  
> [!TIP]
>  This topic is part of a walkthrough about how you can set up searches and get started with analyzing the resulting data. More information: [Set up searches to listen to social media conversations](../social-engagement/set-up-searches.md)  
  
 The **Analytics** area helps you to analyze social data and displays widgets based on the posts that result from your search topics. Widgets then display the analysis in easy-to-understand formats such as bar charts, simple curves, or percentages. You can further filter the displayed data to perform more detailed and focused analysis. More information: [Get relevant data using filters](../social-engagement/use-filters.md)  
  
 [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] widgets provide you with drill-down functionality to narrow your data set. Click a data point to get a more detailed view of the data.  
  
> [!TIP]
>  Check out the video about this content: [![Video button](../social-engagement/media/video-icon.png "Video button")](http://go.microsoft.com/fwlink/p/?LinkId=613693) [Microsoft Social Engagement: Gain Insights using Analytics (7:23)](http://go.microsoft.com/fwlink/p/?LinkId=615285)  
  
> [!NOTE]
>  -   If no posts are available for your organization, widgets display no metrics and an error message.  
> - [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] supports two types of widgets - **Static** and **Dynamic**.  
> - [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)] supports the following analytics pages: **Overview**, **Conversations**, **Sentiment**, **Locations**, and **Sources**.  
  
 **Use Analytics widgets to**:  
  
-   See the top conversations across different sources, top phrases, and the languages that are used. More information: [Find out what people are saying over conversations](../social-engagement/analytics-conversations.md)  
  
-   Understand the positive, negative, and neutral sentiment values for your products and services.  More information: [Understand the public perception using sentiment analysis](../social-engagement/analytics-sentiment.md)  
  
-   Check the locations and location groups from where the posts are coming and the volume they’re bringing in. More information:  [See the locations for the posts](../social-engagement/analytics-location.md)  
  
-   See the top sources, volume of posts on each source, and the sentiments they’re bringing in. More information: [Analyze the sources for the posts](../social-engagement/analytics-sources.md)  
  
> [!TIP]
>  Widgets support intuitive tooltips that provide information about the displayed metrics. To view these tooltips, point to the widget by using the mouse or tap  the widget metric.  
  
## Define the data set to display on widgets  
 Widgets take the information from your data set that you define by selecting a search topic or category by using the filters. These filters include the locations, keywords, sentiment values, and so on that you select based on your business requirements. More information: [Get relevant data using filters](../social-engagement/use-filters.md).  
  
> [!NOTE]
>  Every user of your organization’s [!INCLUDE[pn_netbreeze_short](../includes/pn-netbreeze-short.md)] solution can create data sets. However, only Administrators and Power Analysts can create new search topics.  
  
<a name="trend"></a>   
## View the trend values  
 Many  Analytics widgets support the display of **Trend** values. The trend value metric gives you a quick grasp of the trends for the posts across different social dimensions. Trend values are displayed for top sources, top languages, top authors, top sources by sentiment, top conversations, top locations, and top cities. The trend symbol will be upward, downward, or straight – to indicate rising, falling, or steady trend values, respectively.  
  
> [!NOTE]
>  If not enough historical data is available for a trend value to display, the trend symbol is grayed out.  
  
 When you select a time frame in the filter section, the average number of posts in the past is compared with the number of posts in the current time frame. The trend value is then calculated based on the difference.  
  
|Selected time frame|Number of past similar time frames to calculate trend|  
|-------------------------|-----------------------------------------------------------|  
|1 day or less|5|  
|2 days to 7 days|3|  
|8 days or more|1|  
  
 For example, if you select **last week** (seven days) as the time frame for a widget’s display, posts for three weeks prior to last week are compared to the last week to calculate the trend value.  
  
## Static widgets and dynamic widgets  
 The following table explains static and dynamic widgets.  
  
|Feature|Static Widgets|Dynamic Widgets|  
|-------------|--------------------|---------------------|  
|Availability on the UI page|Consistently displayed.|Displayed upon certain conditions. These conditions depend on the analytics page and the selected data set.|  
|Support filters from analytics page|Yes|Yes|  
|Available on all of the analytics pages|Yes|Yes|  
|Required permissions for applying filters|Every user can apply the filters – not a role based permission.|Every user can apply the filters– not a role based permission.|  
  
> [!NOTE]
>  -   A widget could be a static widget on an analytics page and dynamic on another page. The display and type of a widget depends upon the selected analytics page and the priority of the widget on the selected social dimension.  
> -   If no data is available in the selected data set, static widgets will show an error message.  
  
<a name="export"></a>   
## Export data from widgets and lists  
 To create your own visualizations or further process the data, you can export data points from widgets and lists to an [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] workbook.  
  
- To export data from a widget, click the **Download the data into Excel** button ![Download the data into Excel](../social-engagement/media/export-data-icon.png "Download the data into Excel"). You’ll find the resulting [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] file in your browser’s specified downloads folder.  
  
- To export data from a list, select the check boxes of the entries that you want to export, and then click **Export** in the list header.  
  
The exported Excel file contains two sheets:  
  
- **Information sheet**: Lists the current configuration at the point in time when you exported the data.  
  
- **Data sheet**: Contains the data points and the metrics that are used on the exported data.  
  
### See Also  
[Perform visual filtering on widgets](../social-engagement/visual-filtering-widgets.md)   
[Understand widgets on the Overview page](../social-engagement/analytics-overview.md)
 
