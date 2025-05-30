---
title: Monitor customer wait time through live conversation counter
description: Monitor customer wait time in live chats with the conversation counter. Stay compliant with SLAs and respond faster using color-coded indicators.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: conceptual
ms.collection: 
ms.date: 05/30/2025
ms.custom: bap-template
---

# Monitor customer wait time through live conversation counter

Track customer wait times during live chats by monitoring the live conversation counter to ensure compliance with service-level agreements (SLAs).

The visual counter on the conversation's multisession tab displays the time elapsed since the customer's last message without a response.

## Prerequisites

Your administrator has configured the SLA thresholds.

## Here's how it works

- The SLAs viewed by you are defined by the response time standards set by your administrator to address customer inquiries.
- You can view the SLA counter on the multisession bar for live chat workstreams and channels, and for each session or conversation.
- Each SLA counter updates its time and colors based on the time elapsed since the representative's last response, if the most recent message is from the customer.
- When a customer sends a message, the conversation wait time timer starts counting from zero. The timer resets each time you respond to the customer. If the customer doesn't respond, the timer remains at zero seconds. 

## **SLA Status Indicators**

The timer includes the following color-coded indicators that show the status of the SLA: 

- **Blue**: Indicates a standard counter when the SLA is on track, without any **Warning** or **Urgency**.
- **Yellow**: Indicates that the SLA is approaching its limits and is in the **Warning** state.
- **Red**: Indicates that the SLA surpassed the limit and is in the **Urgent** state. 

## Related information

[Configure live conversation counter to view customer wait time](../administer/configure-live-conv-counter.md#configure-live-conversation-counter-to-view-customer-wait-time)

[Configure advanced settings](../administer/create-workstreams.md#configure-advanced-settings)