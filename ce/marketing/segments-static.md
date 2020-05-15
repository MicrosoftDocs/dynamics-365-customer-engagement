---
title: "Design a static segment (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to create a static segment by selecting specific contacts individually in Dynamics 365 Marketing"
keywords: segment; compound segment
ms.date: 05/14/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: 6620a363-8996-4d94-bbbe-fb5bffaf1ceb
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Design static segments

Static segments enable you to choose and add segment members manually based on existing lists or search results.

To create a static segment, go to **Customers** > **Segments** and select **New** in the dropdown menu on the top ribbon. Then, select the **Static Segment** option, as described in [Create and go live with a new segment](segmentation-lists-subscriptions.md#create-segment).

When you create a new static segment, you can add segment members manually one by one, or with a query (to select multiple contacts at a moment).

When you select “Add”, you will see a pane on the right offering to either type the contact name to search for a specific information or press Enter to see the full list of contacts.

When you see the list of contact names, you are able to select any number of them simply by clicking on each name. The selected contacts will be shown in the gray field on top of the right pane. When you’re done with selection process, press “Add” at the bottom of the pane and all the selected contacts will be added to your segment.

As your database may contain a multitude of contacts, the segment designer now includes the second option to add contacts – **Add by Query**. Opposite to dynamic segment, this query is executed only once, to help you find the right group of contacts and add to a segment.

In the Manage Segment Members pop-up window, you can edit the query and execute it by pressing Find button.

In the list of results corresponding the query, you can either manually select (by pressing on the left to the contact name) the required contact or add the whole list by pressing Add all button at the bottom.

When you're done picking contacts for your static segment, you will immediately see all of them on the Members tab. In order to start using a segment, select Go Live in the top menu, as usual.

### See also

[Working with segments](segmentation-lists-subscriptions.md)  
[Manage segment memberships from a contact record](manage-segments-from-contacts.md)
