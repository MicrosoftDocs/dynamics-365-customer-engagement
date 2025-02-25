---
title: Conversation metrics
description: This article provides an overview of the various metrics available in Customer Service, helping you analyze key performance indicators (KPIs) to make strategic decisions, track agent performance, and improve customer satisfaction.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 02/19/2025
ms.custom: bap-template
---

# Conversation metrics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article provides an overview of various conversation metrics available in Dynamics 365 Customer Service, helping you analyze key performance indicators (KPIs) to make strategic decisions, track agent performance, and improve customer satisfaction. 

[Understand the workflow](metrics-data-model.md#understand-the-workflow) to effectively utilize these metrics and improve customer service operations and decision-making. 

## Total conversations

The total number of conversations that takes place during the selected period of time across all channels (digital, voice), and includes all [conversation status](metrics-data-model.md#conversation-status) (open (unassigned), active (assigned), and closed conversations), both bot and/or service representative conversations, and both inbound and outbound conversations. 

Bot deflected conversations + Bot escalated conversations + Total service representative (direct representative) conversations = Total conversations.

## Bot conversations

The total number of conversations that have taken place during the selected period of time, across all statuses (active conversations and closed conversations) taking place with Voice/IVR or chat/digital bot.

Bot deflected conversations + Bot escalated conversations = Total bot conversations

### Related metrics

- **Bot deflected conversations**: Total number of conversations where bot was involved and the conversation remained contained within bot without service representative escalation. ​

- **Bot escalated conversations**: Total number of conversations where bot was initially involved and then the issue is escalated to the service representative for support. 

## Direct service representative conversations

The total number of conversations through any channel (voice, digital) including both open, active, and closed conversations for both inbound and outbound traffic involving service representatives. 

### Related metrics:

**Incoming conversations**: The total number of inbound conversations including both direct to representative and escalation from a voice or digital bot.

**Outgoing conversations**: The total number of outbound conversations made by representative directly to the user.

## Engaged conversations

**Need info**

## Abandoned conversations

A conversation can be abandoned for multiple reasons. For example, a customer might be disconnected or might cancel the call because of a long waiting period, supervisors might forcibly close requests, or automatic system actions might be configured to respond to handle overflow. Abandoned conversations can lead to customer dissatisfaction because of a lack of assistance from the contact center. A high abandonment rate might require further investigation into operational metrics such as service representative availability and queue distribution.

If an AI agent or IVR handles the customer before it escalates the request to a service representative, this metric is calculated as the number of conversations that were abandoned while customers were waiting for a service representative after the AI agent escalated the request. If a conversation is abandoned before an AI agent can be assigned, the system considers the conversation abandoned.

If the customer reaches a service representative queue directly, this metric is calculated as the number of incoming conversations that were abandoned.

The conversation direction is *Incoming*. The channels that the conversation came in through are *Messaging* and *Voice*.

:::image type="content" source="../media/abandoned-conversation.png" alt-text="Diagram that illustrates abandoned conversations.":::

## Conversation first wait time

This metric is a measure of the time, in seconds, before a  service representative responds to a customer's request. In other words, it represents the amount of time that the customer spends waiting for the first response from a service representative. Service representative availability, a high volume of requests, and increased handle time are some factors that can affect customer wait time. A shorter wait time indicates that customers get faster issue resolution and have a better support experience.

If an AI agent or interactive voice response (IVR) handles the customer before it escalates the issue to a service representative, the calculation is based on the time between the point when the AI agent or IVR escalates the incoming conversation to a service representative and the point when the service representative accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the AI agent or IVR escalates the conversation to a service representative and the point when the customer disconnects the conversation.

If the customer reaches a service representative queue directly, the calculation is based on the time between the point when the customer creates the request and the point when a service representative accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the customer creates the request and the point when the customer disconnects the conversation.

This metric is available in two formats: seconds and *hh:mm:ss*.

### Related metrics

- **Average conversation first wait time**: This metric is calculated by dividing the total wait time for customers who are waiting in the queue by the total number of served customers.
- **Longest wait time**: This metric is a measure of the longest first wait time among incoming conversations that a service representative hasn't yet accepted.
- **Conversations in queue**: This metric is a count of customer requests that are currently awaiting service representative assistance, or conversations where a service representative is assigned but are waiting for the service representative to accept.

For information about metrics that are related to the time that customers wait in individual queues if they're transferred from one service representative to another, see [Session wait time](session-metrics.md#session-wait-time).

## Conversation handle time

This metric is a measure of the time that service representatives spend actively helping customers and resolving their issues. If multiple service representatives handle a conversation, the time that all the service representatives spend is aggregated. This metric also includes time that service representatives spend wrapping up the conversation after the customer disconnects, and the time that they spend updating notes or contact details. However, it excludes time that subject matter experts or other service representatives spend consulting with service representatives who are assigned to work on customer conversations.

A service representative is considered as actively working on a conversation if they have the conversation open in the Customer Service workspace app. If a service representative is handling multiple conversations, including conversations that they're currently wrapping up, only the time that the service representative spends on the conversation on an open tab counts toward that conversation's handle time.

A long average handle time might indicate that service representatives are taking too long to resolve customer issues, and that they need more training or support to help them work better. In addition, a long average handle time might suggest that customers aren't receiving the level of service or support that they need to resolve their issues. Therefore, it might lead to customer dissatisfaction.

This metric can be viewed in two formats: seconds and *hh:mm:ss*.

:::image type="content" source="../media/simple-chat-conversation.png" alt-text="Diagram that illustrates conversation handle time.":::

## Average handle time

This metric represents the average duration of a single customer interaction. This includes total time spent on the call or chat, any hold time, and the wrap up time or after-call work required to close the interaction. It helps you understand how efficiently customer inquiries are handled and issue resolution is done.

For information about metrics that are related to the time that individual service representatives spend when multiple service representatives handle conversations, see [Average session handle time](session-metrics.md#average-session-handle-time).

For the Voice report, this metric is a measure of total talk time, total hold time, and total wrap-up time or after-call work, divided by the number of calls handled, where:

- Talk time: The time a service representative spends in actively speaking with the customer.
- Hold time: The time for which a service representative puts the customer on hold during the interaction.
- Wrap-up time or after-call work: The time taken to complete any post-call tasks related to the interaction.
- Total number of calls handled: The total number of customer interactions handled by the service representatives.​

    :::image type="content" source="../media/aht_voice.png" alt-text="Screenshot of how avergae handle time is calculated for voice.":::

For the Chat report, this metric is a measure of the active chat time and active wrap-up time, divided by the number of chats handled, where:

- Active chat time: The time a service representative spends in actively chatting with the customer.
- Active wrap-up time: The time taken to complete any post-chat tasks related to the interaction.
- Total number of chats handled: The total number of customer interactions handled by the service representatives.

    :::image type="content" source="../media/aht_chat.png" alt-text="Screenshot of average handle time for chat":::

## Average conversation hold time

This metric is a measure of the average time, in seconds, that the service representatives who handled a conversation had the customer on hold. If multiple service representatives handled the conversation, the hold time across all the service representatives is aggregated. This metric is calculated by dividing the total hold time for all customer requests by the total number of customers who were served.

There are several reasons why a service representative might put a customer on hold. For example, the service representative might have to gather more information or research an issue, perform tasks that don't require interaction (for example, entering data into a system), or work on an offline task. A long hold time can cause customer frustration and might lead to a poor customer experience.

:::image type="content" source="../media/conversation-hold-time.png" alt-text="Diagram that illustrates conversation hold time and talk time.":::

## Average conversation talk time

This metric is a measure of the average time, in seconds, that service representatives spent actively conversing with customers on the phone for voice conversations. If multiple service representatives handled the conversation, the conversation talk time is aggregated across all the service representatives. This metric is calculated by dividing the total talk time for all customer requests by the total number of customers who were served.

### Related metric

- **Conversation talk time**: This metric is calculated based on the total talk time across all customer requests.

## Average conversation time

This metric is a measure of the average time, in seconds, that a customer who was seeking help from the contact center spent with a service representative. It includes the time that the customer spent waiting for service representatives to work with them.

### Related metric

- **Conversation time**: This metric is calculated as the time between the point when the customer initiated the request and the point when the service representative wrapped up the conversation.

## Average conversation wrap-up time

This metric is a measure of the average time that a service representative spends completing any necessary tasks after the customer disconnects. These tasks might include documenting the conversation, updating notes, or updating the customer's information. The calculation is based on the time between the beginning of the wrap-up and the point when the service representative closes the conversation. If multiple service representatives handled a conversation, this metric applies only to the time that the last service representative who worked with the customer spent.

This metric can be viewed in two formats: seconds and *hh:mm:ss*.

## Active conversations awaiting service representative acceptance

This metric is a count of conversation requests from customers where service representatives are assigned but that are currently waiting for a service representative to accept and join the conversation. The conversations revert to an *Open* state if the service representative rejects or responds to the request.

## Active conversations with service representative acceptance

The total number of active service representative conversations. Includes conversations that were assigned to a service representative, accepted by the representative, and actively being engaged. This includes all inbound and outbound conversations across all channels (digital, voice, and cases).

## Waiting conversations

This metric is a count of conversations that are currently in a *Waiting* state. A conversation is moved to a *Waiting* state when the service representative closes the session without ending the conversation (that is, without selecting the **End** button on the communication panel), or when the customer closes the browser window without closing the chat widget. If there are asynchronous messaging channels, a *Waiting* state indicates conversations that are waiting for a service representative to respond. Learn more in [Understand conversation states](oc-conversation-state.md#understand-conversation-states).

## Wrap-up conversations

This metric is a count of conversations that are currently in a *Wrap-up* state. A conversation is moved to a *Wrap-up* state when the service representative ends the conversation, or when the customer leaves the conversation either by ending it on their side or by being disconnected. Learn more in [Understand conversation states](oc-conversation-state.md#understand-conversation-states).

## Incoming conversations

This metric is a measure of the total number of conversation requests that customers initiated across all channels and received by the contact center. Learn more in [Understand conversation states](oc-conversation-state.md#understand-conversation-states).


## Related information

[Customize visual display](customize-reports.md#customize-visual-display)
[Session](session-metrics.md#session)
[Service representatives](service-rep-metrics.md#service-representatives)
