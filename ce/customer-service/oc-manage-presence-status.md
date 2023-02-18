---
title: Manage presence status in Omnichannel for Customer Service | MicrosoftDocs
description: "Use this article to learn how to view and update your presence status in Omnichannel for Customer Service."
ms.date: 02/18/2023
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

## Prerequisites

For the presence status or presence icon to display correctly, ensure that cookies are enabled in your browser for all modes.

## View your presence status

You can view your presence status on the navigation bar. You can select the presence icon to launch the presence dialog and update your presence.

  - ![Offline presence status.](media/oceh-offline-icon.png "Offline presence status")  Offline

  - ![Appear away presence status.](media/oceh-appear-away-icon.png "Appear away presence status")  Appear away

  - ![Do not disturb presence status.](media/oceh-do-not-disturb-icon.png "Do not disturb presence status")  Do not disturb

  - ![Busy presence status.](media/oceh-busy-icon.png "Busy presence status")  Busy

  - ![Available presence status.](media/oceh-available-icon.png "Available presence status")  Available
  
  - ![Inactive presence status.](media/oceh-appear-away-icon.png "Appear away presence status")  Inactive
  

 
## Update your presence status

You can update the presence status in the following two ways:

- **Manually**: To view and set the presence manually based on your availability, select the presence icon on the navigation bar. In the **Set Your Presence Status** dialog, select a status from the list. The list shows the following standard presence statuses:

  - Offline
  - Appear away
  - Do not disturb
  - Busy
  - Available
  
   You might also see other presence statuses that your administrator configured for you.

  > [!div class=mx-imgBorder]
  > ![Set your presence status.](media/oceh-presence.png "Set your presence status")

- **Automatically**: When a conversation (work item) is assigned to you, Omnichannel for Customer Service sets your presence status based on your capacity as follows:

  - When your capacity is fully utilized, then Omnichannel for Customer Service sets your presence to **Do not disturb**.
  - When your capacity is partially utilized, then Omnichannel for Customer Service sets your presence to **Busy**.
  - When your capacity isn't utilized, then Omnichannel for Customer Service sets your presence to **Available**.
  - If you already have 10 sessions open, which is the maximum multisession limit, and a new work item comes in, then Omnichannel for Customer Service changes your presence to **Do not disturb**.
  - When you miss a notification and the missed notifications setting is enabled, then the presence is set to **Inactive**.
  - When you reject a work notification and the agent reject notification setting is enabled, then the presence is set to **Do not disturb**.

## Presence status conditions

Your presence status pertains to the following three conditions:

- Omnichannel for Customer Service determines your presence based on your used or released capacity. The presence changes from **Available** to **Busy**, **Busy** to **Do not disturb**, **Do not disturb** to **Busy**, or **Busy** to **Available**.

- If your presence is **Away** or **Offline**, then Omnichannel for Customer Service doesn't update the presence. But, you can manually change it. 

- If you change your presence to **Do not disturb**, then Omnichannel for Customer Service doesn't update the presence. But, you can manually change it. 

## Presence status scenarios

The following scenarios describe how your presence status can be affected while you work with your customers.

- **Reconnect**: When the system connection is disrupted because of network issues or when you refresh the browser and connect back, then the system picks up your last known presence. 

- **Sign in**: When you sign in, your presence is set to the default presence if no work items have been assigned to you. If work items have been assigned, then your presence is automatically determined. However, if your default presence is set as Away or Offline, then the system doesn’t change your presence.  

- **Accept work items**: When you accept a work item or it's assigned automatically, then the system determines your presence based on your work capacity. But, if your presence is set to Away or Offline, or if you've manually changed your presence to Do not disturb, then the system doesn’t change your presence. 

- **Close work items**: When you close a session, or resolve, cancel, or reroute a case, the system determines your presence based on your work capacity. But, if your presence is set to Away or Offline, or if you've manually changed your presence to Do not disturb, then the system doesn’t change your presence.

- **Reset agent presence**: When you reset the agent presence based on the missed notification or the agent reject notification, then the system determines your presence based on your work capacity.

## Troubleshoot display of presence

[Why doesn't my presence load?](troubleshoot-omnichannel-customer-service.md#user-presence-isnt-loading-or-user-is-shown-as-unknown)

### See also

[View notifications](oc-notifications.md)
[Introduction to the agent interface](oc-introduction-agent-interface.md)
[Manage sessions](oc-manage-sessions.md)
[Manage applications](oc-manage-applications.md)
[View the communication panel for conversations](oc-conversation-control.md)
[Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
