---
title: "Create and manage users and user profiles"
description: 
keywords: ""
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 3a61efc9-84b5-4499-8cce-578aae138d1e
ms.custom: 
---

# Create and manage users and user profiles

All Microsoft Dynamics 365 users who are assigned the omni-channel supervisor or omni-channel agent security role automatically become omni-channel users. Omni-channel users are then assigned roles in the system to distinguish them according to their responsibilities.

When you sign in to omni-channel, you can view the list of omni-channel users in the **Omni-channel Users** view.

![Omni-channel users](../media/omni-channel-users.png)

User profiles are a template of properties that are associated with a set of omni-channel users. For example, in an organization that has 100 omni-channel users, you can create a **Subject Matter Experts** user profile, and associate trained and experienced agents with it. Then, all customer queries that require expert knowledge can be routed to agents who are associated with that user profile.

Here are the main properties that are associated with users to define a user profile:

- Capacity
- Default presence status
- Work streams
- Omni-channel queues

As an admin, you can assign the properties at both the user level and the user profile level. For example, you define the capacity for a user as 50 units, but you define the capacity in the user profile that the user is associated with as 40 units. During conversation allocation, capacity that is defined at the user level overrides capacity that is defined at the user profile level. Therefore, the agent will be assigned a conversation that has a capacity of 50 units.

The following table shows how various properties can be associated, and how they affect routing and work distribution.

| Properties                                                   | User | User profile | Effect during routing and work distribution              |
|--------------------------------------------------------------|------|--------------|----------------------------------------------------------|
| Capacity                                                     |      |              | User capacity overrides user profile capacity            |
| Work streams                                                 |      |              | Union of channels                                        |
| Queues                                                       |      |              | Union of queues                                          |
| Conversations (Conversations, cases, leads, custom entities) |      |              | No relationship between agent profiles and conversations |

A user profile can have many omni-channel users, but an omni-channel user can inherit only one user profile. For example, a user profile that is named **Subject Matter Experts** can contain many agents, but the agent who is named Gilda Moss can be associated with only one profile, such as **Subject Matter Experts**. You can't also associate Gilda Moss with the **Experienced Agents** user profile.

## Manage a new user

Use the Microsoft Office 365 Admin center to create user accounts for every user who requires access to Omni-channel Engagement Hub. All users who are assigned the omni-channel supervisor or omni-channel agent security role become omni-channel users.

For more information, see [Create users in Dynamics 365 (online) and assign security roles](../../admin/create-users-assign-online-security-roles.md).

When you sign in to omni-channel, you can view the list of omni-channel users in the **Omni-channel Users** view.

Follow these steps to update the details of a user in Omni-channel Engagement Hub.

1. In the omni-channel site map, select **User Management \> Users**.

    The **Omni-channel Users** view is shown. 

2. On each tab, provide the appropriate information about the user:

    - **Summary**: 

        - In the **User Information** section, enter details about the user.
        - In the **Organization Information** section, enter details about the user's organization.
        - In the **Teams** section, specify the team that the user belongs to.
        - In the **Queue Information** section, assign a queue to the user.

    - **Details**:

        - In the **User Information** section, enter contact information.
        - In the **Address** section, enter address details.
        - In the **Direct Reports** section, add existing users as direct reports for the user.

    - **Administration**: 

        - In the **Client Access License Information** section, select the access mode in the drop-down list.
        - In the **Email Configuration** section, select the mailbox that is associated with the user.

    - **Omni-channel**:

        - In the **User Details** section, assign a capacity and a default presence status.
        - In the **Omni-channel Queues** section, assign an existing omni-channel queue.
        - In the **Work Streams** section, assign an existing work stream.

3. Select **Save** to the save the user record.

You can also enable or disable a user in omni-channel. Select the user record in **Omni-channel Users** view, and then select **Enable** or **Disable** on the command bar.
