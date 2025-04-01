---
title: Show customers their position in a queue
description: Learn how to show customers their queue position for a chat widget.
ms.date: 02/05/2025
ms.topic: article
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Show customers their position in a queue

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

As an administrator, you can turn on the feature that notifies a customer of their position in the queue and the average wait time when they're waiting to chat or speak with a customer service representative (service representative or representative). You can help set customer expectations when wait times are longer due to higher volumes of customers needing support, understaffing, or longer-than-expected handle times (for example, new issues or new service representatives). Knowing their queue position can help the customer decide whether to wait in the queue or come back later.

When this feature is turned on, a customer who submits a request when other customers already are waiting is placed in the queue and notified with the following message: **People ahead of you: \<n\>.** 

The number of customers waiting to chat or speak gets updated each time a customer in line is served. When no other customer is ahead in the queue, the customer waiting is notified with the message: **You’re next in line…**.

> [!NOTE]
>  - The queue position is shown only when there is a queue of customers waiting (for example, when no service representatives are currently available).
> - In a scenario where a customer is waiting in the queue and another customer who has been waiting longer is transferred over by a representative, the customer who has been waiting longer is served first, and the other customer does not see a position change in the queue. 
> - If skill-based routing is configured with exact skill match, the queue position that is communicated to a customer might not be accurate; therefore, the assignment of a representative to the customer might take longer than expected.
> - The queue position isn't supported for persistent chats. Learn more in [Configure persistent chat](persistent-chat.md).

## Enable queue position setting

To configure the queue position setting:

1. Sign in to the admin center application, and then go to the workstream for which you want to configure the queue setting.

1. Select **Edit** on the **channel Settings** page, and go to the **Behaviors** tab.

1. Enable the **Customer wait time** toggle and select the checkboxes to show customers their position in the queue and the average wait time when they're waiting to interact with a representative.

1. Select **Save and Close**.


### Related information

[Show customers their average wait time in a queue](average-wait-time.md) <br>
[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
