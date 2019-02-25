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

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

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

----------------------------------------------------------------------------
---------------------------------------------------------------------------

| Role |View |Add/edit/delete  |Add/Remove  |
|---------|---------|---------|---------|
|**Omni-channel administrator**|   - Can view user list </br> - Can view presence list </br> -  Can view work stream list/details  </br> -  Can view queue list/details </br> - Can view quick replies  </br> - Can view  operating hours </br> - Can view authentication settings |   -  Can edit roles of a user </br> - Can edit default presence/default capacity/queue assignment of a user </br> - Can add/edit/delete presence </br> -  Can	add/edit/delete Work stream  </br> - Can add/edit/delete  Channel settings </br> - Context settings </br> - Can add/edit/delete Routing rules  </br> - Can add/edit/delete Presence associations </br> - Add/edit/delete queue </br> - Add/edit/delete operating hours </br> - Can add/edit/delete authentication settings |    - Can add/remove users from presence   </br> - Can add/remove agents from Queue |
|**Omni-channel supervisor**      |         |         |         |
|**Omni-channel agent**     |         |         |         |


----------------------------------------------------------------------------
---------------------------------------------------------------------------


|Role | User Management | Custom Presence | Work streams | Queues | Quick Replies | Operating Hours | Authentication Settings |
|---------|---------|---------|---------|---------|---------|---------|---------|---------|
|**Omni-channel administrator**     |   - Can  view user list </br> -  Can edit roles of a user </br> -    Can edit default presence/default capacity/queue assignment of a user  |
|Row2     |         |


----------------------------------------------------------------------------
---------------------------------------------------------------------------

### Omni-channel administrator

#### User Management 
- Can  view user list </br> 
- Can edit roles of a user </br> 
- Can edit default presence/default capacity/queue assignment of a user

#### Custom Presence

- View presence list
- Add/edit/delete presence
- Add users to presence
- Remove users from presence


### See also

[Provision Omni-channel Engagement Hub](omni-channel-provision-license.md)

[Manage users in Omni-channel Engagement Hub](users-user-profiles.md)
