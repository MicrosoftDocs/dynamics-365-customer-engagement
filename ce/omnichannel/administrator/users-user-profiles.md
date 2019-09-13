---
title: Create and manage users and user profiles | MicrosoftDocs
description: Know how to create and manage users and user profiles in the Omnichannel for Customer Service
keywords: users and user profiles; Omnichannel for Customer Service
author: kabala123
ms.author: kabala
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

All Dynamics 365 users who are assigned the **Omnichannel administrator**, **Omnichannel supervisor**, or **Omnichannel agent** security role are enabled for Omnichannel and become Omnichannel users.

For more information on how to create users and assign security roles, see [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md).

Navigate to **Queues & Users > Users** to view the list of Omnichannel users in the **Omnichannel Users** view.

> [!div class=mx-imgBorder] 
> ![Omnichannel users](../media/omni-channel-users.png)

## Manage a user in Omnichannel

1. Sign in to the **Omnichannel Administration** app.

2. Select **Users** under **Queues & Users**.

    The **Omnichannel Users** view is shown. 

3. Select a user from the list.

4. Select the **Omnichannel** tab.

5. Specify the following in the user page.

    | Section | Field | Description | Example value |
    |---------------|---------------------|---------------------|-------------------------------------------------|
    | User Details | Capacity | Allocate capacity to agent. | 100 |
    | User Details | Default Presence | Assign a default presence status for agent. This is the status that the agent is logged in with, in the Omnichannel app. | 

6. Select **+ Add Existing Skill** under the **Skills** section. **Quick create: Skills** pane appears.

7. Select a skill and proficiency of the from the list.

8. Select **Save and Close**.

9. Select **Save** to the save the user record.

> [!div class=mx-imgBorder]
> ![Default presnce](../media/oc-user-omni-tab.png)

### See also

[Work with queues in Omnichannel for Customer Service](queues-omnichannel.md)

[Configure and manage presence status](presence-custom-presence.md)
