---
title: "Manage forum access permissions in Dynamics 365 | MicrosoftDocs"
description: "Learn about control flow tags available in portal"
keywords: "forum access permissions"
ms.date: 05/08/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: F09DA8FB-BF40-4D50-ADBD-A259BC67CDBC
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Manage forum access permissions in Dynamics 365

Forum Access Permission is a security rule that can be assigned to a particular forum and web role that can restrict particular users from viewing the forum or granting particular users the ability to moderate a forum within the webpages. To create, edit, or delete forum access permissions from within [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]:

1. Sign in to [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].

2. Go to **Community** > **Forum Access Permissions**.

    ![Forum access permission](media/forum-access-permission.png "Forum access permission")

3. To create a new forum access permission, select **New**.

4. To edit an existing permission, select the permission name.

5. Enter appropriate values in the fields.

6. Select **Save & Close**.

    ![Edit forum access permission](media/edit-forum-access-permission.png "Edit forum access permission")  

> [!NOTE]
> A web role must be assigned for the rule to apply for users associated with the given role. See [Create web roles for portals](create-web-roles.md).

The table below explains many of the Forum Access Permission attributes used by portals.

| Name  | Description                                                                                                                                |
|-------|--------------------------------------------------------------------------------------------------------------------------------------------|
| Name  | A name used for reference within [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].                                                                                             |
| Forum | The [Manage forum threads](manage-forum-threads.md) associated with the permission.                                                          |  
| Right | The permission setting can be one of the following:<ul><li>**Restrict Read**: Prevents viewing of the forum for users in a web role associated with the rule.</li><li>**Grant Change**: Allows a user in a web role associated with the rule to moderate the forum. Grant Change takes precedence over Restrict Read.</li></ul>
||

### See also

[Setup and manage forums](setup-moderate-forums.md)  
[Manage forum threads](manage-forum-threads.md)  
[Create forum posts on the portal](create-forum-posts.md)  
[Subscribe to alerts](subscribe-alerts.md)  
