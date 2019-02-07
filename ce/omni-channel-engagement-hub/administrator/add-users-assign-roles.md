---
title: Assign roles and enable users for Omni-channel Engagement Hub | MicrosoftDocs
description: Know how to assign roles and enable users for Omni-channel Engagement Hub
keywords: enable users; Omni-channel Engagement Hub; assign roles
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: be3d6733-4d16-48d0-b231-6a6a2dd5d939
ms.custom: 
---

# Assign roles and enable users for Omni-channel Engagement Hub

All Dynamics 365 users who are assigned the **Omni-channel administrator**, **Omni-channel supervisor**, or **Omni-channel agent** role are enabled for Omni-channel and become Omni-channel users.

> [!IMPORTANT]
> To enable users for Omni-channel, your org should have successfully on-boarded to the Omni-channel public preview. Refer [Provision Omni-channel Engagement Hub](omni-channel-provision-license.md) to provision Omni-channel in your Dynamics 365 org.

Use the Office 365 Admin Center to create user accounts for every user who needs access to Omni-channel Engagement Hub. For more information, see  [Create users in Dynamics 365 for Customer Engagement apps and assign security roles](../../admin/create-users-assign-online-security-roles.md).

Follow these steps to assign Omni-channel roles to users in the Dynamics 365 web application:

1. Select **Settings** > **Security** > **Users**.

2. In the list, select the user or users that you want to assign a security role to.

3. Select **Manage Roles**.

   Only the security roles available for that user's business unit are displayed.

4. In the **Manage User Roles** dialog box, select the security role or roles you want for the user or users, and then select OK.

    > [!div class=mx-imgBorder]
    > ![user roles](../media/user-roles.png)

To view and manage Omni-channel users, see [Manage users in Omni-channel Engagement Hub](users-user-profiles.md).

## Understand roles and their privileges 

Each role in Omni-channel Engagement Hub can perform a set of actions based on the privileges. 



||Area     |User Management |Custom Presence|Work Streams |Queues |    Quick Replies   | Operating Hours | Authentication Settings |
|---------|---------|---------|---------|---------|--------|---------|---------| ---------|
|**Role**        |         |         |         ||
|**Omni-channel Administrator** |         | - Can view user list </br> - Can edit roles of a user </br> - Can edit default presence and default capacity of a user </br> - Can edit queue assignment of a user|  - Can view/add/edit/delete presence </br> - Can add/remove users from presence     |  - Can view/add/edit/delete work streams </br> - Can add/edit/delete channel settings </br> - Can add/edit/delete routing rules </br> - Can add/edit/delete presence associations|  - Can view/add/edit/delete queues </br> - Can add/remove agents from queues | - Can view/add/edit/delete quick replies| - Can view/add/edit/delete operating hours | - Can view/add/edit/delete auth settings|








|**Omni-channel Supervisor** |         |         |         ||
|**Omni-channel Agent** |         |         |         ||















### See also

[Provision Omni-channel Engagement Hub](omni-channel-provision-license.md)

[Manage users in Omni-channel Engagement Hub](users-user-profiles.md)
