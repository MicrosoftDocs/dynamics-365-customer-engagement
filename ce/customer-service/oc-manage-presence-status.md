---
title: "Manage presence status in Omnichannel for Customer Service | MicrosoftDocs"
description: "Use this topic to learn how to view and update your presence status in Omnichannel for Customer Service."
ms.date: 01/17/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Manage presence status

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Presence is the indication of your availability or status.

  > [!div class=mx-imgBorder]
  > ![Agent presence status.](media/oceh-presence-icon.png "Agent presence status")

## View your presence status

As an agent, you can view your presence status that is shown in the nav bar. Select the icon to launch the presence dialog. Each presence status is indicated by an icon:

  - ![Offline presence status.](media/oceh-offline-icon.png "Offline presence status") - Offline

  - ![Appear away presence status.](media/oceh-appear-away-icon.png "Appear away presence status") - Appear away

  - ![Do not disturb presence status.](media/oceh-do-not-disturb-icon.png "Do not disturb presence status") - Do not disturb

  - ![Busy presence status.](media/oceh-busy-icon.png "Busy presence status") - Busy

  - ![Available presence status.](media/oceh-available-icon.png "Available presence status") - Available
  
  - ![Inactive presence status.](media/oceh-appear-away-icon.png "Appear away presence status") - Inactive
  
If you can't see your presence status, make sure that cookies are not blocked in your browser in any mode.
 
## Update your presence status

Presence status is updated in two ways:
- **Manually** - Change the status manually according to your availability.<br> To view and set the presence, select the presence icon from the nav bar and then select the status from the list. The list shows five standard presence statuses:

  - Offline
  - Appear away
  - Do not disturb
  - Busy
  - Available
  
   You might also see other additional presence statuses that your administrator configured for you.

  > [!div class=mx-imgBorder]
  > ![Set your status.](media/oceh-presence.png "Set your status")

- **Automatically** - The status is set automatically based on the work item assignment. That is, when a conversation (work item) is assigned to you, the status is updated based on the capacity as follows:

  - When your capacity is fully utilized, the presence is set to **Do not disturb**.
  - When your capacity is partially utilized, the presence is set to **Busy**.
  - When your capacity is not utilized, the presence is set to **Available**.
  - If you already have 10 sessions open, which is the maximum multi-session limit, and a new work item comes in, your status automatically changes to **Do not disturb**.
  - When you miss a notification and the missed notifications setting is enabled, the presence is set to **Inactive**.
  - When you reject a work notification and the agent reject notification setting is enabled, the presence is set to **Do not disturb**.

## Understand presence status scenarios

Your agent presence status pertains to the three following scenarios:

- If the presence is **Away** or **Offline**, the system doesn't update the presence. However, you can manually change it.
- If the presence is manually changed to **Busy DND**,  the system doesn't update the presence. However, you can manually change it.
- The system computes your presence based on your utilized or released capacity. The presence changes from **Available to Busy, Busy to Busy DND, Busy DND to Busy, or Busy to Available**.

Following are examples of the various scenarios that might affect your presence status:

### Login scenarios:
Here are the login scenarios:
- You logged in for the first time.
- You got signed out but were able to sign in within the turnaround time.
- You lost connection, but were able to reconnect within the turnaround time.

Here's how your presence status changes:

Your presence is set to the default presence if no work items have been assigned to you. If work items are assigned, your presence is automatically computed. However, if configured by the admin, your default presence shows as Away or Offline. Note: Live chats assigned to the agent are reassigned to other agents in case the agent is unable to reconnect within the turnaround time. After the turnaround time, live chats are only retained with the agent if agent affinity is turned on. For cases and other async channels, work items are always retained with the agent.

### Reconnection scenarios:
Here are the reconnection scenarios:
- You lost connection, but were able to reconnect within the turnaround time.
- Your browser closed but opened within the turnaround time.
- You got signed out but were able to sign in within the turnaround time.

Here's how your presence status changes:

The system picks up your last known presence.

### Acceptance scenarios:
Here are the acceptance scenarios:
- You accepted the work item notification
- Your work item was automatically accepted.
- You opened and accepted a work item from the dashboard.

Here's how your presence status changes:

If your presence is set to Away or Offline, or if you have manually changed your presence to DND, the system doesn’t change your presence. Otherwise, the system computes your presence based on your work capacity.

### Closure scenarios:
Here are the closure scenarios:
- You closed a session.
- You resolved a case.
- You cancelled a case.
- You rerouted a case.

Here's how your presence status changes:

If your presence is set to Away or Offline, or if you have manually changed your presence to DND, the system doesn’t change your presence. Otherwise, the system computes your presence based on your work capacity.

### Reset agent presence scenarios:
Here are the reset agent presence scenarios:
- You reset your presence based on the missed notification banner.
- You reset your presence based on the agent reject notification banner.
- You reached the maximum limit of 10 sessions for Live Chat.

Here's how your presence status changes:

The system computes your presence based on your work capacity.

### Troubleshoot display of presence

[Why doesn't my presence load?](troubleshoot-omnichannel-customer-service.md#troubleshoot-presence)

### See also

- [View notifications](oc-notifications.md)
- [Introduction to the agent interface](oc-introduction-agent-interface.md)
- [Manage sessions](oc-manage-sessions.md)
- [Manage applications](oc-manage-applications.md)
- [View communication panel](oc-conversation-control.md)
- [Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
