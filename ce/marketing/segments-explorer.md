---
title: "View entity relations in the explore view (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to use the explore view to visualize entity relations in Dynamics 365 Marketing"
keywords: segment;
ms.date: 05/24/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: 71b263c7-98ac-4640-9fc8-83d177430397
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Use the explore view to visualize entity relations

The **Explore** view provides a graphical map of the entities that are available for constructing segment queries and shows how they are related. This tool can help you figure out how to traverse the various entities to create a path that ends at the required **Contact** entity (shown in turquoise). Available paths and entities are shown in blue, while entities and paths that aren't directly available to the current entity appear in light gray. Already used paths and entities are shown in dark gray.

To use the explorer, select the **Explore** button while you are building a query group for a [profile-based dynamic query](segments-profile.md). It isn't available when you are working with an behavioral segment.


![The segment explorer](media/segment-explorer-example1.png "The segment explorer")



### See also

[Working with segments](segmentation-lists-subscriptions.md)  
[Design dynamic demographic or firmographic segments](segments-profile.md)
