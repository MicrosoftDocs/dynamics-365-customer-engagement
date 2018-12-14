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


User profiles are a template of properties associated with a set of omni-channel users. For example, in an organization of 100 omni-channel users, you can create a user profile as Subject Matter Experts, and associate trained and experienced agents with the profile, so that all specific customer queries which require expert acumen can be routed to these agents.

The key properties that are associated with the users to define a user profile are:

- Capacity
- Default presence status
- Work streams
- Omni-channel queues

As an administrator, you can assign the properties at both User and User profile level. For example, you define the capacity for a user as 50 units, but the capacity in the profile with which the user is associated, is 40 units. During work item allocation, user capacity will override user profile capacity and the agent will be assigned a work item of capacity 50 units.

See the below table to understand how various properties can be associated and how they affect routing and work distribution:

| Properties                                                | User | User Profile | Effect during routing and work distribution rules     |
|-----------------------------------------------------------|------|--------------|-------------------------------------------------------|
| Capacity                                                  |      |              | User capacity will over ride                          |
| Work streams                                              |      |              | Union of Channels                                     |
| Queues                                                    |      |              | Union of Queues                                       |
| Work Items (Conversations, Cases, Leads, Custom entities) |      |              | No relationship between agent profiles and work items |

A user profile can have many omni-channel users, but an omni-channel user can inherit only one user profile. For example, a user profile **Subject Matter Experts** can contain many agents, but the agent Gilda Moss can only be associated with one profile i.e. **Subject Matter Experts.** You cannot associate Gilda Moss with **Experienced Agents** user profile.

## Manage a new user

Use the Office 365 Admin Center to create user accounts for every user who needs access to Omni-channel Engagement Hub. All users who are assigned the omni-channel supervisor or omni-channel agent security role become omni-channel users.

For more information, see Create users in Dynamics 365 (online) and assign security roles.

You can view the list of omni-channel users in **Omni-channel Users** view when you log in to omni-channel.

Follow these steps to update the details of a user in the Omni-channel Engagement Hub:

