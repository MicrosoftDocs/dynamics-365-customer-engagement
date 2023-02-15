---
title: Manage presence status in Omnichannel for Customer Service | MicrosoftDocs
description: "Use this article to learn how to view and update your presence status in Omnichannel for Customer Service."
ms.date: 07/04/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Manage presence status

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Presence is an indication of your availability or status in the application.

  > [!div class=mx-imgBorder]
  > ![Agent presence status.](media/oceh-presence-icon.png "Agent presence status")

## View your presence status

As an agent, you can view your presence status on the navigation bar. You can select the presence icon to launch the presence dialog and update your presence.

  - ![Offline presence status.](media/oceh-offline-icon.png "Offline presence status")  Offline

  - ![Appear away presence status.](media/oceh-appear-away-icon.png "Appear away presence status")  Appear away

  - ![Do not disturb presence status.](media/oceh-do-not-disturb-icon.png "Do not disturb presence status")  Do not disturb

  - ![Busy presence status.](media/oceh-busy-icon.png "Busy presence status")  Busy

  - ![Available presence status.](media/oceh-available-icon.png "Available presence status")  Available
  
  - ![Inactive presence status.](media/oceh-appear-away-icon.png "Appear away presence status")  Inactive
  
For the presence status or the icon to be displayed correctly, ensure that cookies are enabled in your browser for all modes.
 
## Update your presence status

You can update the presence status in the following two ways:
- **Manually** - Change the status manually according to your availability.

    To view and set the presence, select the presence icon on the navigation bar. In the **Set Your Presence Status** dialog, select a status from the list. The list shows the following standard presence statuses:

  - Offline
  - Appear away
  - Do not disturb
  - Busy
  - Available
  
   You might also see other additional presence statuses that your administrator configured for you.

  > [!div class=mx-imgBorder]
  > ![Set your presence status.](media/oceh-presence.png "Set your presence status")

- **Automatically** - The status is set automatically based on the work item assignment. That is, when a conversation (work item) is assigned to you, the status is updated based on the capacity as follows:

  - When your capacity is fully utilized, the presence is set to **Do not disturb**.
  - When your capacity is partially utilized, the presence is set to **Busy**.
  - When your capacity is not utilized, the presence is set to **Available**.
  - If you already have 10 sessions open, which is the maximum multi-session limit, and a new work item comes in, your status automatically changes to **Do not disturb**.
  - When you miss a notification and the missed notifications setting is enabled, the presence is set to **Inactive**.
  - When you reject a work notification and the agent reject notification setting is enabled, the presence is set to **Do not disturb**.

## Understand presence status scenarios

Your presence status pertains to the following three conditions:

- If the presence is **Away** or **Offline**, the system doesn't update the presence. However, you can manually change it. 

- If the presence is manually changed to **Do not disturb**, the system doesn't update the presence. However, you can again manually change it. 

- The system determines your presence based on your used or released capacity. The presence changes from **Available** to **Busy**, **Busy** to **Do not disturb**, **Do not disturb** to **Busy**, or **Busy** to **Available**.

The following scenarios describe how your presence status can be affected while you work with your customers.

### Reconnect

When the system connection is disrupted because of network issues or when you refresh the browser and connect back, the system picks up your last known presence. 

### Sign in

When you sign in, your presence is set to the default presence if no work items have been assigned to you. If work items are assigned, your presence is automatically determined. However, if your default presence is set as Away or Offline, the system doesn’t change your presence.  

### Accept work items

When you accept a work item manually or it's assigned automatically, the system determines your presence based on your work capacity. However, if your presence is set to Away or Offline, or if you've manually changed your presence to Do not disturb, the system doesn’t change your presence. 

### Close work items 

When you close a session, or resolve, cancel, or reroute a case, the system determines your presence based on your work capacity. However, if your presence is set to Away or Offline, or if you've manually changed your presence to Do not disturb, the system doesn’t change your presence.

### Reset agent presence

When you reset the agent presence based on the missed notification or the agent reject notification, the system determines your presence based on your work capacity.

### Troubleshoot display of presence

[Why doesn't my presence load?](troubleshoot-omnichannel-customer-service.md#user-presence-isnt-loading-or-user-is-shown-as-unknown)

### See also

[View notifications](oc-notifications.md)
[Introduction to the agent interface](oc-introduction-agent-interface.md)
[Manage sessions](oc-manage-sessions.md)
[Manage applications](oc-manage-applications.md)
[View the communication panel for conversations](oc-conversation-control.md)
[Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
