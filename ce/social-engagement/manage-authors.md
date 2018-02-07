---
title: "Manage authors in Social Engagement | Microsoft Docs"
description: "Learn how to delete and export information about authors of posts."
keywords: "author management, delete author, block author, export author information"
ms.date: 02/07/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 9404a5d0-f5c8-48b4-b1c7-1ea56125fcdc
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Manage the personal data of authors

Most posts in Social Engagement are linked to an author, a user on a social network. With sufficient permissions, you can remove authors from Social Engagement and block all future data acquisition for posts by the removed author. It's critical to understand the implications of deleting all author information by removing an author since this can't be undone and potentially can have a significant impact on data acquisition of your solution. 

## Delete all author information

To remove all available information about an author in Social Engagement, you can delete them. However, once you delete an author, there's no way to undo this. Data about and from this author will be lost, including any future posts. To delete and author in Social Engagement, you need to have a Power Analyst or Administrator [configuration role](user-roles.md). 

Deleting an author has the following impact:

<!-- - Search rules that are configured to gather posts from the author's profile are deleted. -->

- All posts from the author are removed.

- No new posts from the author will be acquired in the future.

### Find and delete an author

1. In **Social Engagement** go to **Analytics** > **Overview**

2. Extend the time frame to include the past two years. This ensures that you review all available data in Social Engagement. 

2. In the filter menu, select the **Author** filter. 

3. Search for the author name and apply the filter to see all posts of this author. 
   > [!NOTE]
   > If you are requested to remove information about a specific author, we recommend that you confirm the identity of that author first to validate the request. To confirm the identity, you can ask for a direct message from the author. If they have access to the social media profile, they are likely to own it and have a valid request.

4. In **Analytics > Overview**, open the **Authors** widget to full-view.

5. In the expanded view, select the trashbin icon.

All posts from the author are deleted from the database and no new posts from the author will be acquired in the future. 

<!-- ## Export author information

## Stop processing specific authors

## Rectification of author information

Administrators in Social Engagement can't change author names manually.    
However, if an author decides to change the name on a social network, this change will be reflected in Social Engagement when the next post of this author is acquired. -->

### See also
[Get an overview about the data](analytics-overview.md)    
[Get started with Social Engagement](get-started.md)    
[Set up searches in Social Engagement](set-up-searches.md)