---
title: "Manage authors in Social Engagement | Microsoft Docs"
description: "Learn how to delete posts and export information about authors."
keywords: "author management, delete author, block author, export author information"
ms.date: 03/02/2018
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

# Manage an author's data

Most posts in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] are linked to an author on a social network. With sufficient permissions, you can remove an author from [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] and block all future posts by that author. Whenever [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] acquires new posts, it checks if the author was deleted earlier and discards posts from deleted authors. It's critical to understand the implications of deleting all author information by removing an author, because it can't be undone and can have a significant impact on data acquisition for your solution.

Since your search topics gather data about the authors of the posts, you might get contacted by authors to inform them about the data you stored about them, and eventually, get requests to remove that data per the laws in the European Union. You can find the procedures below how you can remove or correct personal data of authors in Social Engagement.

## General Data Protection Regulation (GDPR)

The General Data Protection Regulation (GDPR) is a European Union (EU) directive that requires organizations operating within the EU to respect the privacy of EU citizens and obtain explicit consent to contact them or use their personal information in any data automation or storage system. [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] is prepared to help organizations work in compliance with the GDPR when using the system. However, most organizations will need to review and update all their information systems to come into complete compliance as part of a comprehensive, organization-wide effort. 

### Learn more about GDPR 

Here are some resources where you can learn more about how to bring your Dynamics 365 systems into compliance with GDPR: 

- [Microsoft Dynamics 365 and GDPR](https://docs.microsoft.com/dynamics365/get-started/gdpr/): provides links to resources, white papers, blogs, and other information related to various Dynamics 365 applications and GDPR 

- [Microsoft Trust Center](https://www.microsoft.com/trustcenter): Discover how new features help you secure personal data and meet strict GDPR privacy requirements 

- [Service Trust Portal](https://servicetrust.microsoft.com/): Control management, integrated task assignment, evidence collection, and audit-ready reporting tools to streamline your compliance workflow 

## Delete an author

To remove all available information about an author (for example, if you need to respond to a deletion request in GDPR context) in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)], you can delete them. However, once you delete an author, there's no way to undo it. Data about and from this author will be lost, including the ability to post in the future. To delete an author in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)], you need to have a Power Analyst or Administrator [configuration role](user-roles.md). 

Deleting an author will result in:

- All posts from the author will be removed.

- No new posts from the author will be acquired in the future.

- Search rules that are configured to gather posts from the author's profile are deleted.

### Find and delete an author

1. In **[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)]** go to **Analytics** > **Overview**

2. [Define a custom time frame](use-filters.md#edit-the-analysis-time-frame) to include the past two years.    
   Since posts are stored for two years, this ensures that you review all available data in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] and find the author if they published a post during that time. 

3. Select the **Author** filter [using the filter menu](use-filters.md#add-edit-or-remove-a-filter). 

4. Search for the author name and apply the filter to see all posts by this author. 
   > [!NOTE]
   > If you are asked to remove information about a specific author, we recommend that you confirm the identity of that author first to validate the request. To confirm their identity, you can request a private message from the author. If they have access to the social media profile, they are likely to own it.

5. Go to **Analytics > Overview**. In the **Authors** widget, select **Widget actions** ![Widget actions symbol](media/more-options-icon.png "Widget actions symbol") and select **Expand to full view** ![Expand to full view symbol](media/open-full-view-icon.png "Expand to full view symbol").

6. In the expanded view, select the **Remove Author** ![Remove author symbol](media/trashbin-icon.png "Remove author symbol") symbol and confirm your deletion.    
![Remove author control in full view of Authors widget](media/remove-author-full-view.png "Remove author control in full view of Authors widget")

## Export author information

To inform the owner of a social profile about the personal data that is stored in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)], you can export the author's data to an [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] file. 

### Export details about an author

1. In **[!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)]** go to **Analytics** > **Overview**

2. [Define a custom time frame](use-filters.md#edit-the-analysis-time-frame) to include the past two years.    
   Since posts are stored for two years, this ensures that you review all available data in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] and find the author if they published a post during that time. 

3. Select the **Author** filter [using the filter menu](use-filters.md#add-edit-or-remove-a-filter). 

4. Search for the author name and apply the filter to see all posts by this author. 

5. Go to **Analytics > Overview**. In the **Authors** widget, select the **View author details** ![View author details symbol](media/author-details-icon.png "View author details symbol") symbol.

6. In the author details view, select the **Export personal data for this author** ![Export symbol](media/export-data-icon.png "Export symbol") symbol and download the [!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] file.    
![Control to export personal data for this author](media/export-author-details.png "Control to export personal data for this author")  

## Stop processing specific authors

To stop processing data of authors, you need to [delete the author](#delete-an-author). This will remove all search rules that are based on the author's profile and no new posts from this author will be acquired in the future.  

## Correcting author information

Administrators in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] can't change author names.    
However, if an author decides to change their name on a social network, this change will be reflected in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] when their next post is acquired. 

If an author decides to remove a public post on Twitter, Tumblr, or WordPress, this deletion gets reflected in [!INCLUDE[pn-social-engagement-short](../includes/pn-social-engagement-short.md)] and the post is removed from the user interface too.

### See also
[Get an overview about the data](analytics-overview.md)    
[Get started with Social Engagement](get-started.md)    
[Set up searches in Social Engagement](set-up-searches.md)
