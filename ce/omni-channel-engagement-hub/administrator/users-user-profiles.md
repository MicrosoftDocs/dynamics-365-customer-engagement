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

All Dynamics 365 users who have omni-channel supervisor or omni-channel agent role assigned to them, automatically become omni-channel users. Omni-channel users are assigned roles in the system to distinguish them based on responsibilities.

You can view the list of omni-channel users in **Omni-channel Users** view as you log in into omni-channel.

![omni-channel users](../media/omni-channel-users.png)

User profiles are a template of properties associated with a set of omni-channel users. For example, in an organization of 100 omni-channel users, you can create a user profile as Subject Matter Experts, and associate trained and experienced agents with the profile, so that all specific customer queries which require expert acumen can be routed to these agents.

The key properties that are associated with the users to define a user profile are:

- Capacity
- Default presence status
- Work streams
- Omni-channel queues

As an administrator, you can assign the properties at both User and User profile level. For example, you define the capacity for a user as 50 units, but the capacity in the profile with which the user is associated, is 40 units. During conversation allocation, user capacity will override user profile capacity and the agent will be assigned a conversation of capacity 50 units.

See the below table to understand how various properties can be associated and how they affect routing and work distribution:

| Properties                                                | User | User Profile | Effect during routing and work distribution rules     |
|-----------------------------------------------------------|------|--------------|-------------------------------------------------------|
| Capacity                                                  |      |              | User capacity will over ride                          |
| Work streams                                              |      |              | Union of Channels                                     |
| Queues                                                    |      |              | Union of Queues                                       |
| Conversations (Conversations, Cases, Leads, Custom entities) |      |              | No relationship between agent profiles and conversations |

A user profile can have many omni-channel users, but an omni-channel user can inherit only one user profile. For example, a user profile **Subject Matter Experts** can contain many agents, but the agent Gilda Moss can only be associated with one profile i.e. **Subject Matter Experts.** You cannot associate Gilda Moss with **Experienced Agents** user profile.

## Manage a new user

Use the Office 365 Admin Center to create user accounts for every user who needs access to Omni-channel Engagement Hub. All users who are assigned the omni-channel supervisor or omni-channel agent security role become omni-channel users.

For more information, see [Create users in Dynamics 365 (online)and assign security roles](../../admin/create-users-assign-online-security-roles.md).

You can view the list of omni-channel users in **Omni-channel Users** view when you log in to omni-channel.

Follow these steps to update the details of a user in the Omni-channel Engagement Hub:

1. In the Omni-channel site map, select **User Management > Users**. </br>
The **Omni-channel Users** view is displayed. 

2. Fill in the details about the user in the respective tabs:

     - In the **Summary** tab: 

         - Provide details about the user in the **User Information** section.
         - Provide details of the user’s organization in the **Organization Information** section.
        - Specify the team to which the user belong in the **Teams** section.
         - Assign a queue to the user in the **Queue Information** section.

     - In the **Details** tab:

        - Provide contact information in the **User Information** section.
        - Provide address details in the **Address** section.
        - Add existing users as the direct reports for the user in the **Direct Reports** section.

    - In the **Administration** tab: 

        - Select the access mode from the drop-down list in the **Client Access License Information** section.
        - Select the mailbox associated with the user in the **Email Configuration** section.

    - In the **Omni-channel** tab:

        - Assign capacity and default presence status in the **User Details** section.
        - Assign an existing omni-channel queue in the **Omni-channel Queues** section.
        - Assign an existing work stream in the **Work Streams** section.

3. Select **Save** to the save the user record.

You can also enable or disable a user in omni-channel. Select a user record in **Omni-channel Users** view and select **Enable** or **Disable** in the command bar.