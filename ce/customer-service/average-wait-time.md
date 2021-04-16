---
title: "Show customers their average wait time in a queue | MicrosoftDocs"
description: "How to show customers their average wait time for a chat widget in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 05/31/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Show customers their average wait time in a queue


[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview

As an administrator, you can enable the feature that displays a customer's average wait time in the queue when they're waiting to chat with an agent. It helps set customer expectations when wait times are long because of a high volume of customers needing support, understaffing, or long call-handling times. When you display the average wait time to the customer, the customer can decide whether to wait in the queue or return to the chat later.

With this feature turned on, when a new customer is placed in the queue, they are notified with the following message: **Average wait time \<n\> mins.** The average wait time is displayed only if the wait is one minute or longer.

The average wait time is calculated based on wait times from the previous 48 hours and a minimum of 50 conversations for the specific queue. This is an estimated time, and doesn't change for the customer. When there is no wait, the average wait time isn't displayed.

> [!NOTE]
> If skill-based routing is configured with exact skill match, the queue position that's displayed to a customer on the chat portal widget might not be accurate; therefore, the assignment of an agent to the customer might take longer than expected.

## Enable average wait time

1.	Sign in to Omnichannel Administration.

2.	Go to **Channels** > **Chat**.

3.	Open the chat widget in which you want to enable the wait time setting.

4.	Go to the **Basic details** tab.

5.	In the **Customer waiting** area, change **Show average wait time** to **Yes**. (This feature is set to **No** by default.)

6.  Select **Save**.

### See also

[Show customers their position in a queue](show-queue.md) <br>
[Overview of skill-based routing](overview-skill-work-distribution.md) <br>
[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]