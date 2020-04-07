---
title: "Manage presence status in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn how to set your presence status in Omnichannel for Customer Service."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 12/27/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Manage presence status

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Presence is the indication of your availability or status.

  > [!div class=mx-imgBorder]
  > ![Agent presence status](../../media/oceh/oceh-presence-icon.png "Agent presence status")

## View your presence status

As an agent, you can view your presence status that is shown in the nav bar. Select the icon to launch the presence dialog. Each presence status indicates an icon:

  - ![Offline presence status](../../media/oceh/oceh-offline-icon.png "Offline presence status") - Offline

  - ![Appear away presence status](../../media/oceh/oceh-appear-away-icon.png "Appear away presence status") - Appear away
 
  - ![Do not disturb presence status](../../media/oceh/oceh-do-not-disturb-icon.png "Do not disturb presence status") - Do not disturb
 
  - ![Busy presence status](../../media/oceh/oceh-busy-icon.png "Busy presence status") - Busy
 
  - ![Available presence status](../../media/oceh/oceh-available-icon.png "Available presence status") - Available
 
## Update your presence status

Presence status is updated in two ways:
- **Manually** - Change the status manually according to your availability.<br> To view and set the presence, select the presence icon from the nav bar and then select the status from the list to update your status manually. The list shows five standard presence statuses:

  - Offline
  - Appear away
  - Do not disturb
  - Busy
  - Available
  

    Also, you may see any other additional presence statuses that your administrator configured for you.

  > [!div class=mx-imgBorder]
  > ![Agent presence status](../../media/oceh/oceh-presence.png "Agent presence status")

- **Automatically** - The status is set automatically based on the work item assignment. That is, when a conversation (work item) is assigned to you, the status is updated based on the capacity.

  - When your capacity is completely utilized, the presence is set to **Do not disturb**.<br>
  - When your capacity is partially utilized, the presence is set to **Busy**. <br>
  - When your capacity is not utilized, the presence is set to **Available**.<br>

## See also

- [View notifications](oc-notifications.md)
- [Introduction to the agent interface](oc-introduction-agent-interface.md)
- [Manage sessions](oc-manage-sessions.md)
- [Manage applications](oc-manage-applications.md)
- [View communication panel](oc-conversation-control.md)
- [Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)
