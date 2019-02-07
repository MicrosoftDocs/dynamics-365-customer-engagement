---
title: Enable users for Omni-channel and assign roles | MicrosoftDocs
description: Know how to enable users for Omni-channel and assign roles in the Omni-channel Engagement Hub
keywords: users and user profiles; Omni-channel Engagement Hub; user roles
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: be3d6733-4d16-48d0-b231-6a6a2dd5d939
ms.custom: 
---

# Assign roles and enable users for Omni-channel Engagement Hub

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

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

To view and manage omni-channel users, see [Manage users in Omni-channel Engagement Hub](users-user-profiles.md).

## Understand roles and their privileges 

Each role in Omni-channel Engagement Hub can perform a set of actions based on the privileges. 

|                        Area         |  Operation |  Omni-channel administrator                 |    Omni-channel supervisor                       |    Omni-channel agent                      |
|---------------------------------|----------------------------------|----------------------------------|----------------------------------|----------------------------|---------------------------|----------------------------------|
|    **User Management**           |    View user list|    Yes                    |     Yes  |     Yes |
|            |    Edit roles of a user |    Yes                    |     No                |      No              |
|            |    Edit default presence/default capacity/queue assignment of a user|    Yes                    |     Yes                |      No              |
|    **Custom Presence**      |    View presence list|    Yes   |     Yes  |     Yes |
|            |    Add/edit/delete presence |    Yes                    |     No                |      No              |
|            |   Add users to presence|    Yes                    |     Yes                |      No              |
|            |   Remove users from presence|    Yes                    |     Yes                |      No              |
| **Work streams** |    View work stream list/details|    Yes   |     Yes  |     Yes |
|        |    Add/edit/delete </br> - Work stream </br> - Channel settings </br> - Context settings </br> - Routing rules </br> - Presence associations  |    Yes      |     No   |      No 
|    **Queues**      |    View queue list/details|    Yes   |     Yes  |     Yes |
|            |    Add/edit/delete queue |    Yes                    |     No                |      No              |
|            |  Add agents to queue|    Yes                    |     Yes                |      No              |
|            |   Remove agents from queue|    Yes                    |     Yes                |      No              |
|    **Quick Replies**      |    View quick replies|    Yes   |     Yes  |     Yes |
|            |   Add/edit/delete quick replies |    Yes                    |     Yes                |      No              |
|    **Operating Hours**      |    View operating hours|    Yes   |     Yes  |     No |
|            |   Add/edit/delete operating hours |    Yes                    |     No                |      No              |
|    **Authentication Settings**      |    View/add/edit/delete authentication settings|    Yes   |     No  |     No |
|||


### See also

[Provision Omni-channel Engagement Hub](omni-channel-provision-license.md)

[Manage users in Omni-channel Engagement Hub](users-user-profiles.md)
