---
title: Manage presence in Omnichannel for Customer Service
description: Learn how to view and update your presence status in Omnichannel for Customer Service.
ms.date: 04/30/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---

# Manage presence in Customer Service

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


Presence is an indication of your agent’s availability or status to take up work in Dynamics 365 Customer Service.

:::image type="content" source="../media/oceh-presence-icon.png" alt-text="Screenshot of agent presence status.":::

## Prerequisites

The prerequisites for presence status to load correctly are as follows:

- The omnichannel provider URL is correct. Check using the [agent diagnostics tool](use-agent-diagnostics.md) in Customer Service workspace.
- The agent is assigned the [Omnichannel agent or Omnichannel supervisor role](../implement/add-users-assign-roles.md). If custom roles are used, the agent or supervisor [persona mapping](../administer/role-persona-mapping.md) must be configured.
- The agent is assigned an [experience profile](../administer/add-profile-default.md).
- The ["All active channels"](../administer/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels) setting is enabled in the agent’s experience profile.
- [Omnichannel for Customer Service is provisioned](/dynamics365/contact-center/implement/provision-channels#set-up-channels) or [Unified routing is enabled](../administer/provision-unified-routing.md).
- [Cookies are enabled in agent's browser](../implement/system-requirements-omnichannel.md#system-requirements-for-omnichannel-for-customer-service).
- The following URL is listed as allowed: https://*.service.signalr.net


## View out-of-the-box presence statuses

You can view your presence status on the navigation bar. You can select the presence icon to launch the presence dialog and update your presence.

- ![Available presence status.](../media/oceh-available-icon.png "Available presence status")  Available
- ![Appear away presence status.](../media/oceh-appear-away-icon.png "Appear away presence status")  Appear away
- ![Busy presence status.](../media/oceh-busy-icon.png "Busy presence status")  Busy
- ![Do not disturb presence status.](../media/oceh-do-not-disturb-icon.png "Do not disturb presence status")  Don't disturb
- ![Offline presence status.](../media/oceh-offline-icon.png "Offline presence status")  Offline
- ![Inactive presence status.](../media/oceh-appear-away-icon.png "Appear away presence status")  Inactive
 
> [!NOTE]
> - Inactive is a special status that isn’t available for the agent to select; it’s set by the system automatically when agents miss notifications.
> - You can’t modify or delete the out-of-the-box presence statuses.

## What are presence elements

A presence status consists of two elements:

- **Base presence**: The base presence status indicates an agent's status. The unified routing engine distributes work items to agents as per their base statuses. Among the out-of-the-box statuses, except inactive, all others are base statuses.
- **Presence text**: The text associated with a specific base status, which is visible to agents.

### Custom presence status

Apart from the out-of-the-box presence statuses, you can create custom presence statuses for your agents to use. The system matches the custom presence status to a base presence.
For example, if agents on your team want to attend a training, you can create a custom “Away–In Training” presence status. When you map a custom presence to a base presence, you must make sure that the configurations are logically viable. For example, if you map an available custom presence to offline base status, the application treats it as "offline" while the visual effect is "available".

You can view agent custom presence statuses in Omnichannel real-time analytics and Omnichannel historical analytics reports.

More information: [Configure custom presence status](../administer/presence-custom-presence.md)

### Default presence

You can specify a default presence for agents when they sign into Customer Service workspace. Depending on the admin configuration, default presence allows the agents to immediately start the work or have some time before they start work. If you don’t configure any default presence, the application sets "Available" as the default.

More information: [Configure default presence for agents](../administer/users-user-profiles.md#manage-users-using-the-classic-experience)


## How presence is calculated when agents sign in

When the agent signs into Customer Service workspace, the system sets the agent’s presence based on the following factors:

- Default presence configuration
- Agent capacity

If you set the default presence for the agent as “Offline” or “Away,” the agent signs in with the same presence. Otherwise, the system calculates the agent’s presence based on capacity utilization and sets it automatically.

For custom presence status, the system considers the base status for calculating the presence.


## How presence status is updated

The agent presence status is updated in the following two ways:

- **Manually**: The agent can view and set the presence manually by selecting the presence icon on the navigation bar. In the **Set Your Presence Status** dialog, select a status from the list. The list shows the following standard presence statuses:

  - Offline
  - Appear away
  - Don't disturb
  - Busy
  - Available
  
   The agents might also see other presence statuses that you configured for them.

  :::image type="content" source="../media/oceh-presence.png" alt-text="Set your presence status.":::

- **Automatically**: When agents start work, Omnichannel for Customer Service sets their presence status based on their capacity as follows:

  - When capacity is fully used, then presence is set to **Do not disturb**.
  - When capacity is partially used, then presence is set to **Busy**.
  - When capacity is unused, then presence is set to **Available**.
  - If agents already have 10 sessions open, which is the maximum multisession limit, and a new work item comes in, then the presence is set to **Do not disturb**.
  - When agents miss a notification and the [missed notifications](../administer/manage-missed-notifications.md) setting is enabled, then the presence changes to **Inactive**.
  - When agents reject a work notification and the [agent reject notification](../administer/enable-agent-reject-notifications.md) setting is enabled, then the presence changes to **Do not disturb**.

    For live chat and voice channels, you can avoid assigning new work items when agents miss or reject notifications. Make sure that you don't include the "inactive" and `"Do not disturb"` statuses in the allowed presence setting of the corresponding channel workstream.

  - If the agent is disconnected, the system captures the current presence status and immediately sets the status as "Offline". If the agent sign back in within 2.5 minutes, the system restores the presence status. If the agent doesn't sign back in by 2.5 minutes, the system recalculates the presence that it needs to set. The following agent actions are considered for disconnection:
    - Closes the Customer Service workspace browser tab.
    - Signs out of Customer Service workspace.
    - Closes or signs out of the device.
    - Experiences Internet disruption.

##  How capacity affects presence

Presence changes automatically based on capacity utilization. The following scenarios are applicable:

- If available capacity is negative, presence is set to "Do not disturb".
- If agent has both capacity units and profile, the system waits for both to be exhausted to mark the agent as "Do not disturb". This wouldn't bother if the capacity units are being used to or not. If the capacity units are configured, this check would happen.
- If agent has multiple capacity profiles and all are nonblocking, the system waits for them to be consumed to mark the agent as "Do not disturb". If one of the profiles is blocking, then the system waits for the blocking profile to be consumed to mark the agent as "Do not disturb".

## How do manual and automatic presence updates work together

When agents manually set their presence to "Available" or "Busy", the status persists until they accept a new conversation or close an in-progress conversation. The system recalculates the new presence based on capacity utilization. The currently assigned work items remain assigned.

However, if the agent has manually set one of the following presence statuses, the status persists until the agent signs out or changes it manually.
- Offline
- Away
- Do not disturb

## How you can use presence in routing

### Define allowed presence in workstream settings

[Allowed presence](../administer/create-workstreams.md#configure-work-distribution) is a workstream setting that indicates to the system to assign work items to agents who match one of the presence statuses. Agents are assigned work items if their presence matches one of the specified statuses.

### Use presence in assignment rules

The default assignment methods use the presence that you configured in the allowed presence setting of the workstreams to route to the most suitable agent for an incoming work item. You can also define conditions on presence in the assignment rules of custom assignment methods. More information: [Assignment methods in unified routing](../administer/assignment-methods.md)

### View analytics for presence status

See the [Agents report](realtime-agents-analytics.md) in Omnichannel real-time analytics dashboard that provides information on agent presence history.

See the drill-down views in [Agent dashboard](agent-dashboard.md) in Omnichannel historical analytics dashboard to view the information on agent's presence and custom presence statuses.

### Related information

[FAQ on presence](presence-faq.md)  
[View notifications](oc-notifications.md)  
[Introduction to the agent interface](oc-introduction-agent-interface.md)  
[Manage sessions](oc-manage-sessions.md)  
[Manage applications](oc-manage-applications.md)  
[View the communication panel for conversations](oc-conversation-control.md)  
[Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
