---
title: "Show customers their position in a queue | MicrosoftDocs"
description: "Learn how to show customers their queue position for a chat widget in Dynamics 365 Customer Service."
ms.date: 04/24/2023
ms.topic: article
author: lalexms
ms.author: laalexan
---

# Show customers their position in a queue

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

As an administrator, you can turn on the feature that notifies a customer of their position in the queue and the average wait time when they're waiting to chat with an agent. You can help set customer expectations when wait times are longer due to higher volumes of customers needing support, understaffing, or longer-than-expected handle times (for example, new issues or new agents). Knowing their queue position can help the customer decide whether to wait in the queue or come back later.

When this feature is turned on, a customer who submits a request when other customers already are waiting is placed in the queue and notified with the following message: **People ahead of you: \<n\>.** 

The number of customers waiting to chat gets updated each time a customer in line is served. When no other customer is ahead in the queue, the customer waiting is notified with the message: **You’re next in line…**.

> [!NOTE]
>  - The queue position is shown only when there is a queue of customers waiting (for example, when no agents are currently available).
> - In a scenario where a customer is waiting in the queue and another customer who has been waiting longer is transferred over by an agent, the customer who has been waiting longer is served first, and the other customer does not see a position change in the queue. 
> - If skill-based routing is configured with exact skill match, the queue position that is displayed to a customer on the chat portal widget might not be accurate; therefore, the assignment of an agent to the customer might take longer than expected.
> - The queue position isn't supported for persistent chats. More information: [Configure persistent chat](persistent-chat.md)

## Enable queue position setting

To configure the queue position setting:

1. Sign in Customer Service admin center, and then go to the workstream of the chat widget for which you want to configure the queue setting.

1. Select **Edit** for the required chat widget, and on the **Chat channel Settings** page, go to the **Behaviors** tab.

1. Enable the **Customer wait time** toggle and select the checkboxes to show customers their position in the queue and the average wait time when they're waiting to interact with an agent.

1. Select **Save and Close**.


### See also

[Show customers their average wait time in a queue](average-wait-time.md) <br>
[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
