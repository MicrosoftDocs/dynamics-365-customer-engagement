---
title: "Use faceted search to improve portal search in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: f7941412-68ea-4de5-bc35-97aed1c8639f
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Use faceted search to improve portal search



Portal content may be searched using filters based on characteristics of the content. Faceted portal searches allow customers to find their desired content faster than a traditional search through the filters implemented by this feature.

## Enable or disable faceted search

Out-of-the-box faceted search is enabled in your portals. To control and/or enable it follow these steps:

1.  Log into Dynamics and navigate to **Portals** &gt; **Website** &gt; **Site Settings.**

<!-- -->

1.  Locate the Site Setting named Search/FacetedView **and select it**.

2.  Change the **Value** to **True** to enable or **False** to disable Faceted Search.

If you wish to only disable one piece of the Faceted View, then follow these steps instead:

1.  Log into Dynamics and navigate to **Portals** &gt; **Web Templates**.

<!-- -->

1.  Select view to disable (i.e. Knowledge Management – Top Rated Articles)

2.  Click the **Deactivate** button at the top of the page.

## Group entities as part of a record type for faceted view

The site setting **Search/RecordTypeFacetsEntities** allows you to group similar entities together so users have logical ways of filtering search results. For example, instead of having separate options for forums, forum posts, and forum threads; these entities are grouped under the Forums record type.

In Dynamics 365, navigate to **Portals** &gt; **Websites** &gt; **Site Settings** and open the **Search/RecordTypeFacetsEntities** site setting. Notice that the different entities are preceded by the word **Forums:**. This is because the first value is the name with they are grouped as. This word will be translated based on the language that is being used on the portal.

## Use faceted search to improve knowledge search results

Faceted search enables portals to have search filters on the left side allowing you to choose between items like forums, blogs, and knowledge articles. More filters are added for specific search types. For example, knowledge articles can be filtered by Record Type, Modified Date, Rating, and Products to help customers find the content they need. The right side also has a drop-down box that sorts results based on the customer’s choice of Relevance or View Count (specific to knowledge articles). Below is a screen capture with an example of some of the available filters.

![Use filters to improve search results](media/faceted-search-filter.png "Use filters to improve search results")  

