---
title: "Know presence and custom presence"
description: 
keywords: ""
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 5a28a973-6c1d-41b9-8f42-74aa233f5aba
ms.custom: 
---
# Presence and Custom presence

Presence status is an indication of the agent’s availability or status. Presence status stores, updates, and maintains the real-time status for all agents with respect to their availability and capacity utilization. With the help of effectively configured presence status, you can connect your customers with agents in real-time for all live work items like live chats, and all asynchronous work items like cases, leads, and more.

For example, agents should have the presence status set as Available so that a customer chat can be assigned to them.

Omni-channel provides the following presence status out of the box:

-   Available

-   Away

-   Busy

-   Busy DND

-   Offline

A presence status comprises of two core elements:

- **Base Presence**. Base Presence indicates the category of availability.

- **Presence Text.** This is the text that is associated with a base presence category. For example, in **Available – Available for Work**, Available is the base presence and Available for Work is the presence text.

![work assignment conditions](media/oc-work-conditions.png "Work assignment conditions")

The presence status for agents can either be updated manually by the agents themselves or as the work is assigned to them. For example, agents can set the status manually from Busy to Away when they are nearing the end of shift. This will ensure that they don't get any new work items assigned to them. Also, the status is changed to Busy or Busy DND, whenever a new work item is assigned based on the agent’s capacity.

## Custom presence

Omni-channel provides five presence statuses out of the box. But, as an administrator, you can configure new custom presence statuses for agents. The custom presence is configured at org level.

For example, if the agents in your team want to attend a training, you can create a custom presence status as **Away – In Training.** This way, they will not be assigned any work item.

![omni-channel queues view](media/oc-queue.png "Omni-channel queues view")###   

**Note**: As an administrator, you can set the default presence status for an agent in the **Live Work** section of **User** entity. You can also set the default presence status for a user profile in the **Details** section. This way, all the users who are associated with that user profile will inherit the default presence status.

![work assignement in omni-channel ](media/oc-rwd-scenario.png "Work assignement in Omni-channel ")  

## Users and user profiles

All Dynamics 365 users who have omni-channel supervisor or omni-channel agent role assigned to them, automatically become omni-channel users. Omni-channel users are assigned roles in the system to distinguish them based on responsibilities.

You can view the list of omni-channel users in **Omni-channel Users** view as you log in into omni-channel.

![MarkdownConversionFile_Omni channel Engagement Hub Guide image8](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide-image8.png)  

User profiles are a template of properties associated with a set of omni-channel users. For example, in an organization of 100 omni-channel users, you can create a user profile as Subject Matter Experts, and associate trained and experienced agents with the profile, so that all specific customer queries which require expert acumen can be routed to these agents.

![MarkdownConversionFile_Omni channel Engagement Hub Guide image9](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide-image9.PNG)  

The key properties that are associated with the users to define a user profile are:

-   Capacity

-   Default presence status

-   Work streams

-   Omni-channel queues

As an administrator, you can assign the properties at both User and User profile level. For example, you define the capacity for a user as 50 units, but the capacity in the profile with which the user is associated, is 40 units. During work item allocation, user capacity will override user profile capacity and the agent will be assigned a work item of capacity 50 units.

See the below table to understand how various properties can be associated and how they affect routing and work distribution:

| Properties                                                | User | User Profile | Effect during routing and work distribution rules     |
|-----------------------------------------------------------|------|--------------|-------------------------------------------------------|
| Capacity                                                  |      |              | User capacity will over ride                          |
| Work streams                                              |      |              | Union of Channels                                     |
| Queues                                                    |      |              | Union of Queues                                       |
| Work Items (Conversations, Cases, Leads, Custom entities) |      |              | No relationship between agent profiles and work items |

A user profile can have many omni-channel users, but an omni-channel user can inherit only one user profile. For example, a user profile **Subject Matter Experts** can contain many agents, but the agent Gilda Moss can only be associated with one profile i.e. **Subject Matter Experts.** You cannot associate Gilda Moss with **Experienced Agents** user profile.### 

