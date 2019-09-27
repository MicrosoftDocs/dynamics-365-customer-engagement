---
title: Create and manage users and user profiles | MicrosoftDocs
description: Know how to create and manage users and user profiles in the Omnichannel for Customer Service
<<<<<<< HEAD
keywords: users and user profiles; Omnichannel for Customer Service
author: kabala123
ms.author: kabala
=======
author: anjgupta
ms.author: anjgup
>>>>>>> 4c9cd9f49bfd32b1dacbbac975fffb89f4dfc869
manager: shujoshi
applies_to: 
ms.date: 10/15/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 3a61efc9-84b5-4499-8cce-578aae138d1e
ms.custom: 
---

# Manage users in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

All users who are assigned the **Omnichannel administrator**, **Omnichannel supervisor**, or **Omnichannel agent** security role are enabled for Omnichannel and become Omnichannel users.

For more information on how to create users and assign security roles, see [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md).

Navigate to **Queues & Users > Users** to view the list of Omnichannel users in the **Omnichannel Users** view.

> [!div class=mx-imgBorder] 
> ![Omnichannel users](../media/omni-channel-users.png)

## Manage a user in Omnichannel

1. Sign in to the **Omnichannel Administration** app.

2. Select **Users** under **Queues & Users**.

    The **Omnichannel Users** view is shown. 

3. Double-click on a user from the list. For example, **Bert Hair**is the user (agent).

4. Select the **Omnichannel** tab.

5. Specify the following in the user page.

    | Section | Field | Description | Example value |
    |---------------|---------------------|---------------------|-------------------------------------------------|
    | User Details | Capacity | Allocate capacity to agent. | 100 |
    | User Details | Default Presence | Assign a default presence status for agent. This is the status that the agent is logged in with, in the Omnichannel app. | 

6. Select **+ Add Bookable Resource Characteristic** under the **Skills** section. The **New Bookable Resource Characteristic** page appears.

7. Specify the following in the **New Bookable Resource Characteristic** page.

    | Field | Description | Example value|
    |----------------|---------------------------------|-------------------------------|
    | Skill Name | Select a skill from the lookup. | Language |
    | Rating Value | Select a rating value type from the lookup |
    | User (Agent) | Select the particular user to whom you need to add this skill | Bert Hair |

8. Select **Save**.

9. Select back button on the browser, it takes you to the User form. Here, the skill you added appears.

10. Select **Save** to the save the user record.

> [!div class=mx-imgBorder]
> ![Default presence](../media/oc-user-omni-tab.png)

### See also

[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)

[Configure and manage presence status](presence-custom-presence.md)
