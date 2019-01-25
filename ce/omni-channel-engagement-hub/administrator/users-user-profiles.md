---
title: Create and manage users and user profiles | MicrosoftDocs
description: Know how to create and manage users and user profiles in the Omni-channel Engagement Hub
keywords: users and user profiles; Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 3a61efc9-84b5-4499-8cce-578aae138d1e
ms.custom: 
---

# Manage users in Omni-channel Engagement Hub

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

All Microsoft Dynamics 365 users who are assigned the **Omni-channel supervisor** or **Omni-channel agent** security role automatically become omni-channel users. 

For more information see, [Enable users for Omni-channel](add-users-assign-roles.md).

Navigate to **Omni-channel Administration > User Management > Users** to view the list of omni-channel users in the **Omni-channel Users** view.

> [!div class=mx-imgBorder] 
> ![Omni-channel users](../media/omni-channel-users.png)

## Manage a user in omni-channel

1. In the omni-channel site map, select **User Management \> Users**.

    The **Omni-channel Users** view is shown. 

2. In the **Omni-channel** tab, provide the following information:

    - In the **Agent Details** section: </br>
        - Assign capacity to the user in the **Capacity** text box. </br>

        - Assign a default presence status in **Default Presence**. The default presence status is the status that is set for agents when they first sign in to the omni-channel system after their last sign-out.

          You can also add a new default presence status by selecting the search icon.
      
    - In the **Omni-channel Queues** section, assign an existing omni-channel queue to the user.
     
3. Select **Save** to the save the user record.

> [!div class=mx-imgBorder]
> ![Default presnce](../media/oc-user-omni-tab.png)

### See also

[Work with queues in Omni-channel Engagement Hub](queues-omni-channel.md)

[Configure and manage presence status](presence-custom-presence.md)

[Enable users for Omni-channel](add-users-assign-roles.md)
