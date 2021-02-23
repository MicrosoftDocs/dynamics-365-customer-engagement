---
title: "Show customers their position in a queue | MicrosoftDocs"
description: "How to show customers their queue position for a chat widget in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 05/04/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Show customers their position in a queue


[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview

As an administrator, you can turn on the feature that displays a customer’s position in the queue when they are waiting to chat with an agent. This feature can help to set customer expectations when wait times are longer due to higher volumes of customers needing support, understaffing, or longer-than-expected handle times (for example, new issues or new agents). Displaying a customer’s queue position can help the customer decide whether to wait in the queue or come back later when the wait time is shorter.

When this feature is turned on, a customer who submits a request when other customers already are waiting is placed in the queue and notified with the following message: **People ahead of you: \<n\>.** 

The number of customers waiting to chat counts down each time a customer in line is served. When no other customers are ahead in the queue, the customer waiting is notified with the following message: **You’re next in line…**.

> [!NOTE]
>  - The queue position is shown only when there is a queue of customers waiting (for example, when no agents are currently available).
> - In a scenario where a customer is waiting in the queue and another customer who has been waiting longer is transferred over by an agent, the customer who has been waiting longer is served first, and the other customer does not see a position change in the queue. 
> - If skill-based routing is configured with exact skill match, the queue position that is displayed to a customer on the chat portal widget might not be accurate; therefore, the assignment of an agent to the customer might take longer than expected.

## Enable queue position

To configure the queue display feature, follow these steps:

1.	Sign in to Omnichannel Administration.

2.	Go to **Channels** > **Chat**.

3.	Open the chat widget in which you want to enable the queue position setting.

4.	Go to the **Basic details** tab.

5.	In **Queue position**, change **Show position in queue** to **Yes** (this feature is set to **No** by default).

6.  Select **Save**.

## See also

[Show customers their average wait time in a queue](average-wait-time.md) <br>
[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]