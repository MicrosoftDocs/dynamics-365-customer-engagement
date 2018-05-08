---
title: "Moderate forums on a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to moderate forums in a portal."
ms.custom: ""
ms.date: 05/08/2018
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: bdf50eaf-e042-4a41-b826-299cd7956674
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Moderate forums
The moderators are users of the forum who are granted access to the forum's threads and posts of all members for moderating the discussion and keeping the forum clean (neutralizing spam and spambots, for example). Moderators also answer users' concerns about the forum, general questions, as well as respond to specific complaints. They also can do anything to lend a helping hand to a user in need. Common privileges of moderators include: deleting, adding, editing, removing of threads or posts. Essentially, it is the duty of the moderator to manage the day-to-day affairs of a forum or board as it applies to the stream of user contributions and interactions. The relative effectiveness of this user management directly impacts the quality of a forum in general, its appeal, and its usefulness as a community of interrelated users.

## Assign moderators to forums in Dynamics 365

To specify moderators for a forum within [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)], the contact record of the portal user must be assigned to a web role that is associated with a Forum Access Permission record that has the Right set to Grant Change. For more information, see [Create web roles for portals](create-web-roles.md).  

## Forum moderation within the portal

For portal users with moderation permission, moderation controls will automatically be displayed in the portal once signed in. Depending on the page template implemented by your developer, the functionality providing users the ability to moderate may or may not be present and the images displayed within this document may be different than your actual portal.

### Delete an entire forum thread

1. Select **Delete** on the admin toolbar.

2. In the **Delete this thread?** pop-up window, select **Yes**.

    ![Delete a forum thread](media/delete-forum-thread.png "Delete a forum thread")  

### Edit the forum thread

1. Select **Edit** on the admin toolbar.

2. Make the changes you want in the **Edit Thread** pop-up window.

3. Select **Save**.

    ![Edit a forum thread](media/edit-forum-thread.png "Edit a forum thread")

### Delete a forum post

1. Select the down arrow next to the post you want to delete.

2. Select **Delete**.

3. In the **Delete this thread?** pop-up window, select **Yes**.

    ![Delete a forum post](media/delete-forum-post.png "Delete a forum post")  

### Edit a forum post

1. Select the down arrow next to the post you want to edit.

2. Select **Edit**

3. Change the information you want to change in the **Edit this content** pop-up window.

4. Select **Save**.

    ![Edit a forum post](media/edit-forum-post.png "Edit a forum post")

### See also

[Setup and manage forums](setup-moderate-forums.md)  
[Manage forum threads](manage-forum-threads.md)  
[Create forum posts on the portal](create-forum-posts.md)  
[Subscribe to alerts](subscribe-alerts.md)
[Manage forum access permissions](forum-access-permission.md)

