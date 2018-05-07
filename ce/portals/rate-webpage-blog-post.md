---
title: "Rate or vote on a webpage or blog post on a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to enable and manage ratings on a web page or a blog post on a portal."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: a3408b16-dbf3-4939-ba36-e8019d979e21
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Rate or vote on a webpage or blog post on a portal
Ratings provide users with the ability to rate or vote on a webpage or [blog post](manage-blogs.md). Ratings can also be enabled for comments on pages or blog posts. By default, this feature is disabled, but it can be enabled on a page-by-page basis within [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].

Ratings are custom [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] activities and thus can be used in the same way as any other activity such as emails, phone calls, and so on. Because ratings are activities, by using customization you can have ratings appear for any entity you choose that appears and is rendered on the portal, including custom entities.

## Enable ratings for pages and blog posts

1. Sign in to **[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]**.
2. Go to **Portals**.
3. Select **Web Pages**.
4. Select the **Web Page** you want.
5. Set **Enable Ratings** to **Yes**.
6. Select **Save & Close**.

## Use ratings

For webpages that have page ratings enabled and the developer has applied the control to the template, users can rate the page either by using the rating scale or voting, depending on the type chosen when the control was added to the page template.

### Rating Type

![Rating type](media/rating-type.png "Rating type")  

### Vote Type

![Vote type](media/vote-type.png "Vote type")  

## Manage ratings in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]

The ratings for webpages can be viewed, modified, or deleted within [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].

1. Sign in to **[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]**.
2. Navigate to **the Web page**, **Blog Post**, **Page Comment**, or **Blog Post Comment** that you are interested in seeing the ratings for.
3. Navigate to **Activities**.

The associated view lists the ratings for the selected webpage, blog post, or idea. Within this view, users can modify or delete existing ratings.

### See also

[Configure a Dynamics 365 portal](configure-portal.md)  
[Add a webpage to render a list of records](add-webpage-render-list-records.md)  
[Create and run advertisements on a portal](create-run-advertisement.md)  
[Gather feedback by using polls on a portal](gather-feedback-poll.md)  
[Redirect to a new URL on a portal](add-redirect-url.md)  
