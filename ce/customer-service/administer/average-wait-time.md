---
title: Show customers their average wait time in a queue
description: Learn how to show customers their average wait time.
ms.date: 07/01/2024
ms.topic: article
author: lalexms
ms.author: laalexan
---

# Show customers their average wait time in a queue


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


As an administrator, you can enable the feature that displays a customer's average wait time in the queue to start a chat or voice call with an agent. It helps set customer expectations when wait times are long because of a high volume of customers needing support, understaffing, or long call-handling times. When you display or read the average wait time to the customer, the customer can decide whether to wait in the queue or return to the chat or call later.

With this feature turned on, when customers are placed in the queue, they receive the notification: **Average wait time \<n\> mins.**

The average wait time is calculated based on wait times from the previous 48 hours and a minimum of 50 conversations for the specific queue. This is an estimated time, and doesn't change for the customer. The average wait time is displayed only if the wait is one minute or longer. When there's no wait, the average wait time isn't displayed.

> [!NOTE]
> If skill-based routing is configured with exact skill match, the queue position that's displayed to a customer on the chat portal widget might not be accurate; therefore, the assignment of an agent to the customer might take longer than expected.

## Enable average wait time

If you're using the Customer Service admin center or Contact Center admin center app, follow these steps:

1. Go to the workstream in which you need to configure the settings, and on the **channel Settings** page, go to the **Behaviors** tab.

2. Select **Customer wait time** if you want to show to customers their position in the queue and the average wait time when they're waiting to interact with an agent.

3. Select **Save and Close**.

### Related information

[Show customers their position in a queue](show-queue.md) <br>
[Overview of skill-based routing](overview-skill-work-distribution.md) <br>
[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
