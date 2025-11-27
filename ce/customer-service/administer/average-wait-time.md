---
title: Show customers their average wait time in a queue
description: Learn how to show customers their average wait time when they're waiting to be assigned to a representative in Dynamics 365 Contact Center.
ms.date: 11/27/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# Show customers their average wait time in a queue

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

When enabled, the system displays a customer's average wait time in the queue to start a chat or voice call with a customer service representative (service representative or representative). The display helps set customer expectations when wait times are long because of a high volume of customers needing support, understaffing, or long call-handling times. The customer can decide whether to wait in the queue or return to the chat or call later.

When customers initiate a live chat or voice call are placed in the queue, they receive the notification: **Average wait time \<n\> mins.**

For a specific queue, the system calculates the average wait time based on wait times from the previous conversations in the queue. The system uses connected conversations only and not abandoned conversations to calculate the average wait time.

- Uses an "exponential moving average" algorithm for calculating the current average wait time. The current average has higher weight but gradually moves closer to the wait time from the latest conversations.
- Runs in the background every 10 minutes.
- Requires a minimum of 20 conversations before customers see the wait time.
- Resets the calculated average if the queue has no conversations for seven days; after a reset, 20 new conversations are required again.
- Displays the average wait time to the customer only if the wait is one minute or longer. The time is an estimate, and doesn't change for the customer.

> [!NOTE]
> If skill-based routing is configured with exact skill match, the queue position displayed to a customer on the chat portal widget might not be accurate. Therefore, the assignment of a service representative to the customer might take longer than expected.

## Enable average wait time

Do the following steps in Copilot Service admin center:

1. Go to the workstream in which you need to configure the settings, and on the **channel Settings** page, go to the **Behaviors** tab.

1. Select **Customer wait time** if you want to show customers their position in the queue and the average wait time when they're waiting to interact with a representative.

1. Select **Save and Close**.

### Related information

[Show customers their position in a queue](show-queue.md) <br>
[Overview of skill-based routing](overview-skill-work-distribution.md) <br>
[Add a chat widget](add-chat-widget.md) <br>
[Configure a prechat survey](configure-pre-chat-survey.md) <br>
[Configure representative display name](agent-display-name.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
