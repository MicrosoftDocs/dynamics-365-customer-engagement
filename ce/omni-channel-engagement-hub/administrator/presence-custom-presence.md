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
# Configure Presence and Custom Presence

Presence status is an indication of the agent’s availability or status. Presence status stores, updates, and maintains the real-time status for all agents with respect to their availability and capacity utilization. With the help of effectively configured presence status, you can connect your customers with agents in real-time for all conversations like live chats, and all asynchronous conversations like cases, leads, and more. 

For example, agents should have the presence status set as Available so that a customer chat can be assigned to them.
Omni-channel provides the following presence status out of the box:

- Available
- Away
- Busy
- Busy DND
- Offline

A presence status comprises of two core elements:

- **Base Status**. Base Status indicates the category of availability.

- **Presence Text.** This is the text that is associated with a base presence category. For example, in **Available – Available for Work**, Available is the base presence and Available for Work is the presence text.

In addition to the above OOTB presence statuses, as an administrator, you can configure new custom presence statuses for agents. 

For example, if the agents in your team want to attend a training, you can create a custom presence status as **Away – In Training**. This way, they will not be assigned any conversation.

## Presence for agents

The presence status for agents can either be updated manually by the agents themselves or as the work is assigned to them. 

For example, agents can set the status manually from **Busy** to **Away** when they are nearing the end of shift. This will ensure that they don't get any new conversations assigned to them. Also, the status is changed to **Busy** or **Busy DND**, whenever a new conversation is assigned based on the agent’s capacity. 


## Default Presence
The default presence status is the status displayed for agents when they log into the omni-channel system after their last log off. 

As an administrator, you can set the default presence status for an agent in the **Agent Details** section of the **Omni-channel** tab of **User** entity. 

## Create a new presence record

Follow these steps to create a new presence record:

1. In the Omni-channel site map, select **User Management > Custom Presence**. </br>
   The Active Presences view is displayed. 

2. Select **New** in the command bar to create a new presence record.

3. In the **Summary** tab, provide the following information:
    - **Name**. A name for the custom presence status.
    - **Presence Text**. Text that should be associated with the new custom entity.
    - **Base Status**. Select the most applicable base status from the drop-down list.
    - **Description**. A brief description of the new custom presence record.

4. Select **Save** to save the new presence record. 

All active presence records can be seen in the **Active Presences** view. 

To activate a record so that the agents can use it, select the record from the **Active Presences** view and select **Activate** from the command bar.

You can deactivate the presence records if you do not want agents to use them. Select a record from the **Active Presences** view and select **Deactivate** from the command bar. All deactivated records can be seen in the **Inactive Presences** view. You can re-activate a record in the **Inactive Presences** view.






