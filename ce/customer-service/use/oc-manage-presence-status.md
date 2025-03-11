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


Presence is an indication of your customer service representatives' (service representatives or representatives) availability or status to take up work in Dynamics 365 Customer Service.

:::image type="content" source="../media/oceh-presence-icon.png" alt-text="Screenshot of representative presence status.":::

## Prerequisites

The prerequisites for presence status to load correctly are as follows:

- The omnichannel provider URL is correct. Check using the [agent diagnostics tool](use-agent-diagnostics.md) in Customer Service workspace.
- The representative is assigned the [Omnichannel agent or Omnichannel supervisor role](../implement/add-users-assign-roles.md). If custom roles are used, the representative or supervisor [persona mapping](../administer/role-persona-mapping.md) must be configured.
- The representative is assigned an [experience profile](../administer/add-profile-default.md).
- The ["All active channels"](../administer/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels) setting is enabled in the experience profile.
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
> - Inactive is a special status that isn’t available for the representative to select; it’s set by the system automatically when representatives miss notifications.
> - You can’t modify or delete the out-of-the-box presence statuses.

## What are presence elements

A presence status consists of two elements:

- **Base presence**: The base presence status indicates a representative's status. The unified routing engine distributes work items to representatives as per their base statuses. Among the out-of-the-box statuses, except inactive, all others are base statuses.
- **Presence text**: The text associated with a specific base status, which is visible to representatives.

### Custom presence status

Apart from the out-of-the-box presence statuses, you can create custom presence statuses for your representatives to use. The system matches the custom presence status to a base presence.
For example, if representatives on your team want to attend a training, you can create a custom “Away–In Training” presence status. When you map a custom presence to a base presence, you must make sure that the configurations are logically viable. For example, if you map an available custom presence to offline base status, the application treats it as **Offline** while the visual effect is **Available**.

You can view custom presence statuses in Omnichannel real-time analytics and Omnichannel historical analytics reports.

More information: [Configure custom presence status](../administer/presence-custom-presence.md)

### Default presence

You can specify a default presence for representatives when they sign into Customer Service workspace. Depending on the admin configuration, default presence allows the agents to immediately start the work or have some time before they start work. If you don’t configure any default presence, the application sets "Available" as the default.

More information: [Configure default presence for agents](../administer/users-user-profiles.md#manage-users-using-the-classic-experience)


## How presence is calculated when representatives sign in

When the representative signs into Customer Service workspace, the system sets the representative's presence based on the following factors:

- Default presence configuration
- Representative capacity

If active work items are equal to zero, then system sets the presence to default. If default presence is **Do not disturb**, **Away**, or **Offline** then the system sets the presence to default, or sets the presence based on capacity use.

When the representative accepts a work item or closes the work item, and the presence is **Do not disturb**, **Offline**, or **Away**, the system doesn't change the presence. Otherwise, the system calculates the representative's presence based on capacity use.

If you set the default presence for the representative as **Offline** or **Away**, the representative signs in with the same presence. Otherwise, the system calculates the representative's presence based on capacity use and sets it automatically.

For custom presence status, the system considers the base status for calculating the presence.


## How presence status is updated

The representative presence status is updated in the following two ways:

- **Manually**: The representative can view and set the presence manually by selecting the presence icon on the navigation bar. In the **Set Your Presence Status** dialog, select a status from the list. The list shows the following standard presence statuses:

  - Offline
  - Appear away
  - Don't disturb
  - Busy
  - Available
  
   The representatives might also see other presence statuses that you configured for them.

  :::image type="content" source="../media/oceh-presence.png" alt-text="Set your presence status.":::

- **Automatically**: When representatives start work, Omnichannel for Customer Service sets their presence status based on their capacity as follows:

  - When capacity is fully used, then presence is set to **Do not disturb**.
  - When capacity is partially used, then presence is set to **Busy**.
  - When capacity is unused, then presence is set to **Available**.
  - If representatives already have 10 sessions open, which is the maximum multisession limit, and a new work item comes in, then the presence is set to **Do not disturb**.
  - When representatives miss a notification and the [missed notifications](../administer/manage-missed-notifications.md) setting is enabled, then the presence changes to **Inactive**.
  - When representatives reject a work notification and the [agent reject notification](../administer/enable-agent-reject-notifications.md) setting is enabled, then the presence changes to **Do not disturb**.

    For live chat and voice channels, you can avoid assigning new work items when representatives miss or reject notifications. Make sure that you don't include the "inactive" and `"Do not disturb"` statuses in the allowed presence setting of the corresponding channel workstream.

  - If the representative is disconnected, the system captures the current presence status and immediately sets the status as **Offline**. If the representative sign back in within 2.5 minutes, the system restores the presence status. If the representative doesn't sign back in by 2.5 minutes, the system recalculates the presence that it needs to set. The following representative actions are considered for disconnection:
    - Closes the Customer Service workspace browser tab or the tab goes into sleep mode. Disable the sleep mode for tabs to keep presence intact on inactive browser tabs.
    - Signs out of Customer Service workspace.
    - Closes or signs out of the device.
    - Experiences Internet disruption.

##  How capacity affects presence

Presence changes automatically based on capacity utilization. The following scenarios are applicable:

- If available capacity is negative, presence is set to **Do not disturb**.

- If representative has both capacity units and profile, the system waits for both to be exhausted to mark the representative as **Do not disturb**. This wouldn't bother if the capacity units are being used or not. If the capacity units are configured, this check would happen.
- If representative has multiple capacity profiles and all are nonblocking, the system waits for them to be consumed to mark the representative as **Do not disturb**. If one of the profiles is blocking, then the system waits for the blocking profile to be consumed to mark the representative as **Do not disturb**.
- To suit your business scenario, if you set the capacity (units based) for the representative to zero, when a supervisor manually assigns a work item to them, their presence changes to **Do not disturb**. The presence isn't reset after they complete their work and remains as **Do not disturb**.

## How do manual and automatic presence updates work together

When representatives manually set their presence to **Available** or **Busy**, the status persists until they accept a new conversation or close an in-progress conversation. The system recalculates the new presence based on capacity utilization. The currently assigned work items remain assigned.

However, if the representative has manually set one of the following presence statuses, the status persists until the representative signs out or changes it manually.
- Offline
- Away
- Do not disturb

## How presence is updated on transfer of a work item

After the transfer of a work item is successful, the capacity is released for the first representative and blocked for the second representative. The presence of the representatives changes according to their respective capacity use.

## Use presence in routing

### Define allowed presence in workstream settings

[Allowed presence](../administer/create-workstreams.md#configure-work-distribution) is a workstream setting that indicates to the system to assign work items to representatives who match one of the presence statuses. Representatives are assigned work items if their presence matches one of the specified statuses.

### Use presence in assignment rules

The default assignment methods use the presence that you configured in the allowed presence setting of the workstreams to route to the most suitable representative for an incoming work item. You can also define conditions on presence in the assignment rules of custom assignment methods. More information: [Assignment methods in unified routing](../administer/assignment-methods.md)

### View analytics for presence status

See the [Agents report](realtime-agents-analytics.md) in Omnichannel real-time analytics dashboard that provides information on representative presence history.

See the drill-down views in [Agent dashboard](agent-dashboard.md) in Omnichannel historical analytics dashboard to view the information on representative's presence and custom presence statuses.

### Related information

[FAQ on presence](presence-faq.md)  
[View notifications](oc-notifications.md)  
[Introduction to the representative interface](oc-introduction-agent-interface.md)  
[Manage sessions](oc-manage-sessions.md)  
[Manage applications](oc-manage-applications.md)  
[View the communication panel for conversations](oc-conversation-control.md)  
[Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
