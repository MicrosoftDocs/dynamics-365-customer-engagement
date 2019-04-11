---
title: "Set user presence status in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn how to set your presence status in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: E6A73938-1FFE-4BC9-AB05-B4C46C52F3B3
ms.custom: 
---

# Set user presence

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Presence is the indication of your (agent) availability or status. 

## Update your presence status

Presence status is updated in two ways: 
- **Manually** - Change the status manually according to your availability.<br> To view and set the presence, select the status icon at the bottom-right corner and then select the status from the list to update your status manually. The list shows five standard presence statuses: 

  - Available
  - Away
  - Busy
  - Do Not Disturb
  - Offline

    Also, you may see any other additional presence statuses that your administrator configured for you.

  > [!div class=mx-imgBorder]
  > ![Agent presence status](../../media/csh-oc-presence.png "Agent presence status")

- **Automatically** - The status is set automatically based on the work item assignment. That is, when a conversation (work item) is assigned to you, the status is updated based on the capacity.

  a. When your capacity is completely utilized the presence is set to **BusyDND**.<br>
  b. When your capacity is partially utilized the presence is set to **Busy**. <br>
  c. When your capacity is not utilized the presence is set to **Available**.<br>

> [!div class="nextstepaction"]
> [Next topic: View notifications and screen pops](csh-notifications-screen-pops.md) 

## See also

- [Introduction to the agent interface](csh-introduction-agent-interface-omni-channel-engagement-hub-customer-service-hub.md)
- [View communication panel](csh-conversation-control.md)
