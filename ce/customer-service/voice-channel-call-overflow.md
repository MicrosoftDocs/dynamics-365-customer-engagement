---
title: "Handle call overflow in the voice channel | MicrosoftDocs"
description: "Learn how to configure call overflow for the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/13/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ROBOTS: NOINDEX,NOFOLLOW
---

# Preview: Handle call overflow for the voice queues

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]

## Introduction

As an administrator, you can determine the actions when an incoming call reaches the voice queue in the following situations:

- Exceeds a defined number of calls that are waiting in the queue
- Is received during the after hours of the call center operations

When both the conditions are defined, when one of them is met, the overflow actions configured at the workstream level will be run.

## Prerequisites

For call overflow to work correctly, the following prerequisites must be met:

- Agents should be configured for the voice queues.
- To transfer calls to an external phone number, phone numbers should be available.

## Configure call overflow

In Omnichannel admin center, go to the voice queue for which you want to configure call overflow and do the following:

1. In **Overflow conditions (preview)**, select **Set overflow conditions**.

2. On the **Overflow conditions** panel, in the **Work item limit**, enter a number to denote the maximum number of calls that can be in waiting before overflow is reached. For example, if you enter 5 as the value, then five calls should be waiting in the queue for the sixth call to trigger call overflow.

3. If an operating hour record is configured for the queue, the toggle for **Out of operation hours**, is set to **On** by default and can't be edited. The call overflow is triggered when a call reaches the queue during the after hours of the call center operations. If no operating hour record is configured, the toggle will be set to **Off** and in the disabled mode. In such a case, the call center is considered to be available round the clock.

To remove the overflow setting, you'll need to set the work item limit to zero and remove the operating hour record on the queue if configured.

## Define operation hours

Perform the steps in [Create and manage operating hours](create-operating-hours.md) to configure operating hours for the voice queues.

If operation hours are not configured, the queues will be available round the clock.

## Configure overflow action in the voice workstream

Configure the action to be performed when call overflow is triggered. More information: [Configure routing rules for the voice workstream](voice-channel-route-queues.md#configure-routing-rules-for-the-voice-workstream)

## Configuration considerations

Some configuration considerations are discussed in this section.

### Edit automated messages for end call overflow action

If you have set to end the call as an overflow action, an automated message will be delivered to the customer to notify them that the conversation will end.

To edit the automated message, go to **Customer settings > Automated messages** and find the automated message for the **Voice** channel where the message trigger is "Voice call ended".

Then edit the value in the **Localized text** column as needed.

> [!div class="mx-imgBorder"]
> ![Out-of-the-box automated messages.](./media/voice-channel-overflow-end-call-message.png "Out-of-the-box automated messages.")

### See also

[Overview of voice channel](voice-channel.md)  
[Overview of unified routing](overview-unified-routing.md)  
[Configure routing for the voice channel](voice-channel-route-queues.md)  
