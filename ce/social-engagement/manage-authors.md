---
title: "Manage authors in Social Engagement | Microsoft Docs"
description: "Learn how to delete posts and export information about authors."
keywords: "author management, delete author, block author, export author information"
ms.date: 06/13/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: 9404a5d0-f5c8-48b4-b1c7-1ea56125fcdc
author: m-hartmann
ms.author: mhart
manager: sakudes
ms.custom:
  - dyn365-socialengagement
---

# Manage an author's data

Most posts in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] are linked to an author on a social network. With sufficient permissions, you can remove an author from [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] and block all future posts by that author. Whenever [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] acquires new posts, it checks if the author was deleted earlier and discards posts from deleted authors. It's critical to understand the implications of removing an author, because it can't be undone and can have a significant impact on data acquisition for your solution.

## Delete an author

To remove all available information about an author (for example, if you need to respond to a deletion request, or want to remove posts from a spam account) in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)], you can delete them. However, once you delete an author, there's no way to undo it. Data about and from this author will be lost, including their ability to post in the future. To delete an author in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)], you need to have a Power Analyst or Administrator [configuration role](user-roles.md). 

Deleting an author will result in:

- All posts from the author will be removed.

- No new posts from the author will be acquired in the future.

- Search rules that were configured to gather posts from the author's profile will be deleted.

### Find and delete an author

1. In **[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)]** go to **Analytics** > **Overview**

2. [Define a custom time frame](use-filters.md#edit-the-analysis-time-frame) to include the past 15 months.    
   Since posts are stored for 15 months, this ensures that you review all available data in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] and find the author if they published a post during that time. 

3. Select the **Author** filter [using the filter menu](use-filters.md#add-edit-or-remove-a-filter). 

4. Search for the author name and apply the filter to see all posts by this author. 
   > [!NOTE]
   > If you are asked to remove information about a specific author, we recommend that you confirm the identity of that author first to validate the request. To confirm their identity, you can request a private message from the author. If they have access to the social media profile, they are likely to own it.

5. Go to **Analytics > Overview**. In the **Authors** widget, select **Widget actions** ![Widget actions symbol](media/more-options-icon.png "Widget actions symbol") and select **Expand to full view** ![Expand to full view symbol](media/open-full-view-icon.png "Expand to full view symbol").

6. In the expanded view, select the **Remove Author** ![Remove author symbol](media/trashbin-icon.png "Remove author symbol") symbol and confirm your deletion.    
   ![Remove author control in full view of Authors widget](media/remove-author-full-view.png "Remove author control in full view of Authors widget")

## Export author information

To inform an author about personal social profile data that is stored in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)], administrators can export profile data to an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] file. 

### Export details about an author

1. In **[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)]** go to **Analytics** > **Overview**.

2. [Define a custom time frame](use-filters.md#edit-the-analysis-time-frame) to include the past 15 months.   
   Since posts are stored for 15 months, this ensures that you review all available data in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] and find the author if they published a post during that time. 

3. Select the **Author** filter [using the filter menu](use-filters.md#add-edit-or-remove-a-filter). 

4. Search for the author name and apply the filter to see all posts by this author. 

5. Go to **Analytics** > **Overview**. In the **Authors** widget, select the **View author details** ![View author details symbol](media/author-details-icon.png "View author details symbol") symbol.

6. In the author details view, select the **Export personal data for this author** ![Export symbol](media/export-data-icon.png "Export symbol") symbol and download the [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] file.    
   ![Control to export personal data for this author](media/export-author-details.png "Control to export personal data for this author")  

## Stop processing specific authors

To stop processing author data, you need to [delete the author](#delete-an-author). This will remove all search rules that are based on the author's profile and no new posts from this author will be acquired in the future. 

## Correcting author information

Administrators in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] can't change author names.    
However, if an author decides to change their name on a social network, this change will be reflected in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] when their next post is acquired. 

If an author decides to remove a public post on Twitter, Tumblr, or WordPress, this deletion is reflected in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] and the post is removed from the user interface, too.

### See also
[Get an overview about the data](analytics-overview.md)    
[Get started with Social Engagement](get-started.md)    
[Set up searches in Social Engagement](set-up-searches.md)
