---
title: Enable users for Omnichannel and assign roles | MicrosoftDocs
description: Know how to enable users for Omnichannel and assign roles in the Omnichannel for Customer Service
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 08/29/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Assign roles and enable users for Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

All users who are assigned the **Omnichannel administrator**, **Omnichannel supervisor**, or **Omnichannel agent** role are enabled for Omnichannel and become Omnichannel users. Additionally, agents and supervisors must be assigned the **Customer service app access** role along with the **Omnichannel agent** and **Omnichannel supervisor** role.

> [!NOTE]
> To configure Omnichannel, you must assign the **Omnichannel administrator** role mandatorily along with system administrator role.

> [!IMPORTANT]
> To enable users for Omnichannel, your org should have successfully on-boarded to the Omnichannel public preview. Refer [Provision Omnichannel for Customer Service](omnichannel-provision-license.md) to provision Omnichannel in your Common Data Service org.

Use the Microsoft 365 admin center to create user accounts for every user who needs access to Omnichannel for Customer Service. For more information, see  [Create users in the Common Data Service platform and assign security roles](../../admin/create-users-assign-online-security-roles.md).

Follow these steps to assign Omnichannel roles to users in the Common Data Service platform:

1. Select **Settings** > **Security** > **Users**.

2. Select the user or users from the list for whom you want to assign a security role.

3. Select **Manage Roles** in the menu.

   Only the security roles available for that user's business unit are displayed.

4. In the **Manage User Roles** dialog box, select a security role or roles that you want to provide to the user, and then select **OK**.
    
    - Customer service app access
    - Omnichannel administrator
    - Omnichannel agent
    - Omnichannel supervisor

    > [!div class=mx-imgBorder]
    > ![user roles](../media/user-roles.png)

To view and manage omnichannel users, see [Manage users in Omnichannel for Customer Service](users-user-profiles.md).

## Understand roles and their privileges 

Each role in Omnichannel for Customer Service can perform a set of actions based on the privileges. 

> [!NOTE]
> Omnichannel users (agents and supervisors) should be assigned **Customer service app access** role.

|Role  |Privileges  |
|---------|---------|
|**Omnichannel Administrator**      |  Can view user list / presence list / work stream list / queue list / PBI config list       |
|    |    Can edit roles of a user     |
|    |   Can edit default presence and default capacity of a user      |
|    |     Can edit queue assignment of a user    |
|    |    Can add / edit / delete presence     |
|    |      Can add / remove users from presence   |
|    |    Can add / edit / delete presence associations     |
|    |      Can add / edit / delete work streams   |
|    |   Can add / edit / delete channel settings, context settings, routing rules      |
|    |     Can add / edit / delete queues    |
|    |     Can add / remove agents from queue    |
|    |    Can view / add / edit / delete quick replies     |
|    |     Can add / edit / delete PBI config    |
|    |    Can view add / edit / delete operating hours    |
|    |    Can view add / edit / delete auth settings     |
|**Omnichannel Supervisor**     |  Can view user list / presence list / work stream list / queue list / PBI config list       |
||Can edit default presence and default capacity of a user|
||Can edit queue assignment of a user|
|| Can add / remove users from presence |
||Can add / remove agents from queue| 
|| Can view / add / edit / delete quick replies|
||Can view operating hours |
|**Omnichannel Agent**  |Can view user list / presence list / work stream list / queue list|
||Can view quick replies|
||


### See also

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)

[Manage users in Omnichannel for Customer Service](users-user-profiles.md)
