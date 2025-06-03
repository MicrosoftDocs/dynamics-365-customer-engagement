---
title: Show customers their average wait time in a queue
description: Learn how to show customers their average wait time.
ms.date: 06/03/2025
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Show customers their average wait time in a queue


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


As an administrator, you can enable the feature that displays a customer's average wait time in the queue to start a chat or voice call with a customer service representative (service representative or representative). It helps set customer expectations when wait times are long because of a high volume of customers needing support, understaffing, or long call-handling times. When you display or read the average wait time to the customer, the customer can decide whether to wait in the queue or return to the chat or call later.

With this feature turned on, when customers are placed in the queue, they receive the notification: **Average wait time \<n\> mins.**

For a specific queue, the system calculates the average wait time based on wait times from the previous conversations in the queue. An "exponential moving average” algorithm is used for calculating the current average wait time. The current average has higher weight but gradually moves closer to the wait time from the latest conversations. The wait time calculation runs in the background every 10 minutes. A minimum of 20 conversations are required before the customers can be shown the wait time. If the queue doesn't receive conversations for seven days, then the system resets the calculated average wait time. To restart the calculation and display the average wait times again, 20 conversations are required again.

The time is an estimate, and doesn't change for the customer. The system displays the average wait time to the customer only if the wait is one minute or longer.

> [!NOTE]
> If skill-based routing is configured with exact skill match, the queue position displayed to a customer on the chat portal widget might not be accurate. Therefore, the assignment of a service representative to the customer might take longer than expected.

## Enable average wait time

If you're using the Copilot Service admin center or Contact Center admin center app, follow these steps:

1. Go to the workstream in which you need to configure the settings, and on the **channel Settings** page, go to the **Behaviors** tab.

2. Select **Customer wait time** if you want to show to customers their position in the queue and the average wait time when they're waiting to interact with a representative.

3. Select **Save and Close**.

### Related information

[Show customers their position in a queue](show-queue.md) <br>
[Overview of skill-based routing](overview-skill-work-distribution.md) <br>
[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure representative display name](agent-display-name.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
