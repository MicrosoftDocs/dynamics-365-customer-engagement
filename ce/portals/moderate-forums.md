---
title: "Moderate forums on a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
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

Applies To: Dynamics 365 (online), Dynamics CRM Online

The moderators are users of the forum who are granted access to the forum's threads and posts of all members for moderating the discussion and keeping the forum clean (neutralizing spam and spambots, for example). Moderators also answer users' concerns about the forum, general questions, as well as respond to specific complaints. They also can do anything to lend a helping hand to a user in need. Common privileges of moderators include: deleting, adding, editing, removing of threads or posts. Essentially, it is the duty of the moderator to manage the day-to-day affairs of a forum or board as it applies to the stream of user contributions and interactions. The relative effectiveness of this user management directly impacts the quality of a forum in general, its appeal, and its usefulness as a community of interrelated users.

## Assign moderators to forums in Microsoft Dynamics 365

To specify moderators for a forum within Dynamics 365, the contact record of the portal user must be assigned to a web role that is associated with a Forum Access Permission record that has the Right set to Grant Change. For more information, see [Create web roles for portals](create-web-roles.md).  

## Forum moderation within the portal

For portal users with moderation permission, moderation controls will automatically be displayed in the portal once signed in. Depending on the page template implemented by your developer, the functionality providing users the ability to moderate may or may not be present and the images displayed within this document may be different than your actual portal.

### Delete an entire forum thread

1.  Click **Delete** on the admin toolbar

<!-- -->

1.  Select Yes on the pop up “Delete this thread?”

![Delete a forum thread](media/delete-forum-thread.png "Delete a forum thread")  

### Edit the forum thread

1.  Click **Edit** on the admin toolbar

<!-- -->

1.  Make the changes you want in the pop up “Edit Thread”

2.  Click **Save**

![Edit a forum thread](media/edit-forum-thread.png "Edit a forum thread")  

### Delete a forum post

1.  Click the down arrow next to the post you want to delete.

<!-- -->

1.  Click **Delete**

2.  Select **Yes** on the pop up “Delete this thread?”

![Delete a forum post](media/delete-forum-post.png "Delete a forum post")  

### Edit a forum post

1.  Click **the down arrow next to the post you wish to edit.**

<!-- -->

1.  Click **Edit**

2.  Change the desired information in the pop up “Edit this content”

3.  Click **Save**

![Edit a forum post](media/edit-forum-post.png "Edit a forum post")  

## Manage forum access permissions in Dynamics 365

Forum Access Permission is a security rule that can be assigned to a particular forum and web role that can restrict particular users from viewing the forum or granting particular users the ability to moderate a forum within the webpages. To create, edit, or delete forum access permissions from within Dynamics 365:

1.  Login to **Dynamics 365**

<!-- -->

1.  Navigate to **Community**

2.  Click **Forum Access Permissions**

![Forum access permission](media/forum-access-permission.png "Forum access permission")  

### Create a new forum access permission

1.  Click **New**

### Edit an existing forum access permission

1.  Double-click on an existing **Forum Access Permission** listed in the grid

<!-- -->

1.  Specify values for the fields provided

2.  Click **Save & Close**

![Edit forum access permission](media/edit-forum-access-permission.png "Edit forum access permission")  

| ![image6](media/image6.png) **Note **                                                                                                |  
|----------------------------------------------------------------------------------------------------------------------------------------------------------------|
| A web role must be assigned for the rule to apply for users associated with the given role. See [Create web roles for portals](create-web-roles.md). |  

## Attributes relationships

The table below explains many of the Forum Access Permission attributes used by portals.

| Name  | Description                                                                                                                                |
|-------|--------------------------------------------------------------------------------------------------------------------------------------------|
| Name  | A name used for reference within Dynamics 365.                                                                                             |
| Forum | The [Manage forum threads](manage-forum-threads.md) associated with the permission.                                                          |  
| Right | The permission setting can be one of the following:                                                                                        
                                                                                                                                              
  **Restrict Read**                                                                                                                           
                                                                                                                                              
  -   **Grant Change**                                                                                                                        
                                                                                                                                              
  Restrict Read prevents viewing of the forum for users in a web role associated with the rule.                                               
                                                                                                                                              
  Grant Change allows a user in a web role associated with the rule to moderate the forum. Grant Change takes precedence over Restrict Read.  |

### See Also

[Setup and moderate forums](setup-moderate-forums.md)  
[Manage forum threads](manage-forum-threads.md)  
[Create forum posts on the portal](create-forum-posts.md)  
[Subscribe to alerts](subscribe-alerts.md)  

