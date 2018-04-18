---
title: "Analyze social data with widgets in Social Engagement | Microsoft Docs"
description: "Learn how to work with widgets in the Social Engagement user interface."
keywords: "widgets, analytics, get started"
ms.date: 03/27/2018
ms.service: mse
ms.topic: get-started-article
applies_to:
  - "Social Engagement"
ms.assetid: da974b6a-b242-40b6-95ad-df81ac78191e
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Analyze social data using widgets
Use widgets to visualize your organization’s data analytics. The easy-to-understand metrics on these widgets provide quantitative insights and help you understand what your customers or prospects are saying about your products, brands, and services. Identify any issues or compliments that are mentioned about your products or services on social media sources. Using this analysis, you can also understand how your team is working toward the social strategies of your organization.  
  
> [!TIP]
>  This topic is part of a walkthrough about how you can set up searches and get started with analyzing the resulting data. More information: [Set up searches to listen to social media conversations](set-up-searches.md)  
  
The **Analytics** area helps you to analyze social data and displays widgets based on the posts that result from your search topics. Widgets then display the analysis in easy-to-understand formats such as bar charts, simple curves, or percentages. 
[Learn how to navigate the Analytics area.](get-started.md#get-around-in-the-analytics-area)     
You can further [filter the displayed data](use-filters.md) to perform more detailed and focused analysis or [use the data set for other areas of Social Engagement](more-options-with-data-set.md). If no posts are available or match your filters, widgets display no metrics and an error message.
  
Widgets in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] provide you with [drill-down functionality to narrow your data set](use-filters.md#drill-down-into-data-and-apply-filters-from-widgets). Click a data point to get a more detailed view of the data.  
  
**Use Analytics widgets to**:  

-   [Get an overview for the acquired data](analytics-overview.md) and start your analysis.

-   [Find the top conversations](analytics-conversations.md) across different sources, top phrases, and the languages that are used.
  
-   [Understand the positive, negative, and neutral sentiment values](analytics-sentiment.md) for your products and services.
  
-   [Check the locations](analytics-location.md) and location groups from where the posts are coming and the volume they’re bringing in.
  
-   [Get insights for the top sources](analytics-sources.md), volume of posts on each source, and the sentiments they’re bringing in.
  
## Define the data set to display on widgets

Widgets display based on the [data set that you define](use-filters.md) by selecting a search topic or category and by using the filters. These filters include the locations, keywords, sentiment values, and so on that you select based on your business requirements.     
Every user of your organization’s [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] solution can create data sets. However, only Administrators and Power Analysts can [create new search topics](set-up-searches.md).

## View the trend values

 Many widgets support the display of **Trend** values. The trend value gives you a quick grasp of the trends for the posts across different social dimensions. The trend symbol will be upward, downward, or straight – to indicate rising, falling, or steady trend values, respectively.  
  
 When you select a time frame in the filter section, the average number of posts in the past is compared with the number of posts in the current time frame. The trend value is then calculated based on the difference.  
  
|Selected time frame|Number of past similar time frames to calculate trend|  
|-------------------------|-----------------------------------------------------------|  
|1 day or less|5|  
|2 days to 7 days|3|  
|8 days or more|1|  
  
 For example, if you select **last week** (seven days) as the time frame, posts for three weeks prior to last week are compared to the last week to calculate the trend value.  

> [!NOTE]
>  If not enough historical data is available for a trend value to display, the trend symbol is grayed out.  

## Export data from widgets

Create your own visualizations and process the data the way that suits you best by exporting data points from widgets and lists to an [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] workbook. You’ll find the resulting [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] file in your browser’s specified downloads folder 

The exported [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] file contains two sheets:  
  
- **Information sheet**: Lists the current configuration at the point in time when you exported the data.  
  
- **Data sheet**: Contains the data points and the metrics that are used on the exported data.  
  
### To export data from widgets

1. On the widget, select the widget actions symbol (![Widget actions symbol](media/more-options-icon.png "Widget actions symbol")). 

2. In the list of actions, select **Export** ![Download the data into Excel](media/export-data-icon.png "Download the data into Excel").    
> [!NOTE]
> To export data from a list in full view, you need to select the check boxes of the entries that you want to export, and then click **Export** in the list header.  
  

## Expand a widget to full view

Some widgets (for example the authors widget) show a limited number of items by default. If available, you can expand these widgets to full view to see more items in the list. 

### To expand a widget

1. On the widget, select the widget actions symbol (![Widget actions symbol](media/more-options-icon.png "Widget actions symbol")). 

2. In the list of actions, select **Expand to full view** ![Expand to full view symbol](media/open-full-view-icon.png "Expand to full view symbol").

## Switch a widget to table view

All widgets can render in a table mode. You can also set the table view as your default for all widgets by [updating the Your Preferences settings](user-preferences.md).

### To switch a widget to table view

1. On the widget, select the widget actions symbol (![Widget actions symbol](media/more-options-icon.png "Widget actions symbol")). 

2. In the list of actions, select **Switch to table view** ![Table view symbol](media/table-view-icon.jpg "Table view symbol").


### See Also  
[Get to know your filters](use-filters.md)    
[Analyze social data using widgets](analyze-social-data-using-widgets.md)   
[Understand widgets on the Overview page](analytics-overview.md)