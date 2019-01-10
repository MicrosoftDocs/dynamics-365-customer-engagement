---
title: "Configure presence and custom presence"
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
# Configure presence and custom presence

Presence status indicates an agent's availability or status. Presence status stores, updates, and maintains the real-time status of all agents, with respect to their availability and capacity utilization. When presence status is effectively configured, you can connect customers with agents in real time, for all conversations (such as live chats) and for all asynchronous conversations (such as cases and leads).

For example, agents should have their presence status set to **Available** so that customer chats can be assigned to them.

Out of the box, omni-channel provides the following presence statuses:

- Available
- Away
- Busy
- Busy DND
- Offline

A presence status consists of two elements:

1. **Base status**: The availability or status category.
2. **Presence text**: The text that is associated with a specific base status. For example, in the **Available – Available for Work** presence status, **Available** is the base status, and **Available for Work** is the presence text.

In addition to the out-of-box presence statuses, admins can configure custom presence statuses for agents. For example, if the agents on your team want to attend a training, you can create a custom **Away – In Training** presence status. In this way, no conversations will be assigned to agents who attend the training.

## Presence for agents

The presence status for agents can be updated either manually by the agents themselves or automatically as work is assigned to the agents.

For example, agents can manually change their presence status from **Busy** to **Away** when the end of their shift is approaching. In this way, they help guarantee that no new conversations will be assigned to them. Additionally, an agent's presence status is changed to **Busy** or **Busy DND** whenever a new conversation is assigned based on that agent's capacity.

## Default presence

The default presence status is the status that is shown for agents when they first sign in to the omni-channel system after their last sign-out.

Admins can set the default presence status for an agent in the **Agent Details** section on the **Omni-channel** tab of the **User** entity.

## Create a new presence record

Follow these steps to create a new presence record.

1. In the omni-channel site map, select **User Management \> Custom Presence**.

    The **Active Presences** view is shown.

2. On the command bar, select **New** to create a presence record.
3. On the **Summary** tab, provide the following information:

    - **Name**: Enter a name for the custom presence status.
    - **Presence Text**: Enter presence text that should be associated with the new custom entity.
    - **Base Status**: Select the most applicable base status in the list.
    - **Description**: Enter a brief description of the custom presence record.

4. Select **Save** to save the new presence record.

You can view all active presence records in the **Active Presences** view.

To activate a record so that agents can use it, select the record in the **Active Presences** view, and then select **Activate** on the command bar.

You can inactivate any presence record that you don't want agents to use. Select the record in the **Active Presences** view, and then select **Deactivate** on the command bar. You can view all inactivated records in the **Inactive Presences** view. In the **Inactive Presences** view, you can also reactivate an inactivated record.
