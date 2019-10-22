---
title: "Show customers their position in queue | MicrosoftDocs"
description: "Instructions to configure showing customers their queue position for a chat widget in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: aaf6cd6d-5d49-4da4-a380-143c01963564
ms.custom: 
---

# Preview: Show customers their position in queue


[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Overview

As an administrator, you can turn on the display of a customer’s position in the queue when they are waiting to chat with an agent. This feature may be useful in helping to set customer expectations when there are longer wait periods due to higher volumes of customers needing support, under-staffing, or longer than expected handle times (for example, new issues or new agents). Displaying a customer’s queue position can help the customer decide whether to wait in the queue or come back later when the wait time is shorter.

When this feature is turned on, if a customer submits a request and there are already other customers waiting ahead of them, that customer is placed in the queue and notified with the following message: **People ahead of you: \<n\>.** 

The number of customers waiting to chat counts down each time a customer ahead in line is served. When there are no other customers waiting in the queue, the customer waiting is notified with the following message: **You’re next in line…**.

> [!NOTE] 
> In a scenario where a customer is waiting in the queue and another customer who has been waiting longer is transferred over by an agent, the customer who has been waiting longer is served first, and the other customer does not see a position change in the queue.

## Enable queue position

1.	Sign in to Omnichannel Administration.

2.	Go to **Channels** > **Chat**.

3.	Open the chat widget in which you want to enable the queue position setting.

4.	Go to the **Basic details** tab.

5.	In **Queue position**, select **Show position in queue** to **Yes** (this feature is set to **No** by default).

6.  Select **Save**.

## See also

[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Dynamics 365 Portals](embed-chat-widget-portal.md)
