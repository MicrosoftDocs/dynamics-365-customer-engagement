---
title: "Create forum posts on a portal | MicrosoftDocs"
description: "Instructions to create forum posts on a portal."
ms.custom: 
  - dyn365-portal
ms.date: 12/03/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 9d1408d5-3f73-4aaa-bd54-3404d38acc9d
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---
# Create forum posts on the portal

A forum post is a user-submitted message enclosed into a block containing the user's details and the date and time it was submitted. Members are usually allowed to edit or delete their own posts. Posts are contained in [forum threads](manage-forum-threads.md), where they appear as boxes one after another. The first post starts the thread; this may be called the OP (original post). Posts that follow in the thread are meant to continue discussion about that post, or respond to other replies; it is not uncommon for discussions to be derailed.  

## Create forum posts

The forum post editor will appear automatically when a user has successfully signed in to the portal and navigated to a forum thread page, provided the developer has implemented the functionality in the forum thread's page template.

1. Sign in to the portal.

2. Navigate to a [forum thread](manage-forum-threads.md).  

3. Compose your reply in the rich text editor.

4. Select **Post this reply**.

    ![Create a forum post](media/create-forum-post.png "Create a forum post") 

### Attribute relationships

The table below explains many of the Forum Post attributes used by portals. It is important to note that the rendering of the content/display-oriented attributes is controlled by the page template used.

| Name         | Description                                                                                                 |
|--------------|-------------------------------------------------------------------------------------------------------------|
| Name         | The descriptive name of the record. This value will be used as a title to the post. This field is required. |
| Forum Thread | The [forum thread](manage-forum-threads.md) the post is regarding.                                            |  
| Author       | The Contact record associated with the user who wrote the post.                                             |
| Date         | The date and time the post was created.                                                                     |
| Content      | The body or message of the post.                                                                            |
| Answer?      | Checked indicates that the post is identified as being the answer to the thread's question.                 |

### See also

[Setup and manage forums](setup-manage-forums.md)  
[Manage forum threads](manage-forum-threads.md)  
[Moderate forums](moderate-forums.md)  
[Subscribe to alerts](subscribe-alerts.md)  



[!INCLUDE[footer-include](../includes/footer-banner.md)]