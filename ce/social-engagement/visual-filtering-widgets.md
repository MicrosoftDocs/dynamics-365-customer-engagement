---
title: "Perform visual filtering on widgets | Microsoft Docs"
description: "Learn how you can drill down into your data and apply filters on-the-fly."
ms.custom: dyn365-socialengagement
ms.date: 09/12/2017
ms.reviewer: ""
ms.service: dynamics-365-marketing
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
applies_to: "Social Engagement"
ms.assetid: c1b8d8e5-dc14-494a-8a55-2fe4491922c3
caps.latest.revision: 15
author: m-hartmann
ms.author: mhart
manager: sakudes
redirect_url: https://docs.microsoft.com/dynamics365/customer-engagement/social-engagement/use-filters
---
# Perform visual filtering on widgets
In addition to viewing the analytics for the current data set, you can efficiently work with widgets by applying filters to see the data that matters most to you.  
  
## Add filters to perform focused analysis on Analytics pages  
 To narrow the data set information and view focused analysis, use the filters supported on each Analytics page.  
  
 Active filters apply to all widgets on the page. You can apply filters either from the drop-down list in the filter section or by drilling down to a display element on the widget (visual filter).  
  
 To identify the visual filter-enabled area, hover over or click the widget’s display area. For the areas that support visual filtering, the cursor changes to a hand pointer. Click the data point to apply the filter.  
  
> [!IMPORTANT]
>  When you apply a new filter, all of the widgets on the selected Analytics page get refreshed and update the displayed data as appropriate for the new filter. More information: [Get relevant data using filters](use-filters.md)  
  
## Visual filtering for text-based widgets  
 Text type widgets display metrics for data such as phrases. To apply visual filters on these widgets, click any phrase displayed on the widget. The selected phrase is added to the phrases filter and the page recalculates based on the selected filters.  
  
> [!IMPORTANT]
>  The newly-added phrase won’t replace the existing filters but will be added to the current list of phrases.  
  
 **For example**: A user clicks the phrase “Contoso,” and it’s added to the keyword filter and the widget is reloaded. Now, the user clicks the phrase, “Dynamics,” in the reloaded widget. “Dynamics” will be added to the phrases filter without removing the previously-added phrase.  
  
## Visual filtering for list-based widgets  
 List-based widgets display metrics in volumes and in rows, such as for languages and sources. To apply visual filters for these widgets, click anywhere in the row for a given metric, and the selected area, time, or dimension gets added to the filter.  
  
> [!NOTE]
>  Any other dimension values already present in the filter are removed. Only the current filter values are used and the appropriate metrics are displayed.  
  
### See Also  
 [Analyze social data using widgets](analyze-social-data-using-widgets.md)   
 [Understand widgets on the Overview page](analytics-overview.md)
 
