---
title: "Manage presence status in Omnichannel for Customer Service | MicrosoftDocs"
description: "Use this topic to learn how to view and update your presence status in Omnichannel for Customer Service."
ms.date: 01/25/2022
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

- If the presence is manually changed to **Do not disturb**, the system doesn't update the presence. However, you can manually change it. 

- The system computes your presence based on your utilized or released capacity. The presence changes from **Available** to **Busy**, **Busy** to **Do not disturb**, **Do not disturb** to **Busy**, or **Busy** to **Available**.

 Following are few important scenarios which describe how your presence status could be impacted.

### Reconnect 

When system connection is disrupted due to network issues or when you refresh the browser and connect back within the stipulated time, the system picks up your last known presence. 

### Login 

When you log in, your presence is set to the default presence if no work items have been assigned to you. If work items are assigned, your presence is automatically computed. However, if your default presence is set as Away or Offline, the system doesn’t override the status.  

### Accept work items 

When you accept a work item manually or it is accepted automatically, the system computes your presence based on your work capacity. However, if your presence is set to Away or Offline, or if you have manually changed your presence to DND, the system doesn’t change your presence. 

### Close work items 

When you close a session, resolve, cancel, or reroute a case, the system computes your presence based on your work capacity. However, if your presence is set to Away or Offline, or if you have manually changed your presence to DND, the system doesn’t change your presence.

### Reset agent presence

When you reset agent presence based on the missed notification or the agent reject notification banner, the system computes your presence based on your work capacity.

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
