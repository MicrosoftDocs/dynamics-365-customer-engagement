---
title: Conversation metrics
description: Discover key conversation metrics to improve customer service, track performance, and enhance satisfaction by analyzing KPIs and understanding workflow.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.date: 03/27/2025
ms.custom: bap-template
---

# Conversation metrics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article provides an overview of various conversation metrics available in Dynamics 365 Customer Service, helping you analyze key performance indicators (KPIs) to make strategic decisions, track agent performance, and improve customer satisfaction. 

[Understand the workflow](metrics-data-model.md#understand-the-workflow) to effectively utilize these metrics and improve customer service operations and decision-making. 

## Total conversations

The total count of conversations that occurred within the chosen timeframe across all channels (digital and voice), including interactions with both bots and human agents. This encompasses all conversation statuses such as open (unassigned), active (assigned), waiting (awaiting customer's response), wrap-up, and closed conversations across inbound and outbound communications.​

Total conversations = Total bot conversations +  Total direct agent Conversations (inbound and outbound) that can be in any of the conversation states. Learn more in [conversation states](oc-conversation-state.md#understand-conversation-states)[conversation status](metrics-data-model.md#conversation-status).

## Total Bot conversations

The total number of conversations that have taken place during the selected period of time with Voice or IVR or chat or digital bot, across all statuses (active conversations and closed conversations).

Bot Deflected Conversations + Bot Escalated Conversations = Total Bot Conversations 

### Related metrics

- **Bot deflected conversations**: Total number of conversations where bot was involved and the conversation remained contained within bot without service representative escalation. ​

- **Bot escalated conversations**: Total number of conversations where bot was initially involved and then the issue is escalated to the service representative for support. 

## Direct service representative conversations

The total number of conversations through any channel (voice, digital) including both open, active, and closed conversations for both inbound and outbound traffic involving service representatives. 

### Related metrics

- **Incoming conversations**: The total number of inbound conversations including both direct to representative and escalation from a voice or digital bot.

- **Outgoing conversations**: The total number of outbound conversations made by representative directly to the user.

## Engaged conversations

An engaged conversation describes an interaction in which both the customer and the representative are actively participating and responsive during the exchange. This engagement is measured from the moment the service representative accepts the conversation when it's presented.

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

- **Average conversation first wait time**: This metric is calculated by dividing the total wait time for customers who are waiting in the queue by the total number of handled conversations.
- **Longest wait time**: This metric is a measure of the longest first wait time among incoming conversations that a service representative hasn't yet accepted.
- **Conversations in queue**: This metric is a count of customer requests that are currently awaiting service representative assistance, or conversations where a service representative is assigned but are waiting for the service representative to accept.

For information about metrics that are related to the time that customers wait in individual queues if they're transferred from one service representative to another, go to the [Session wait time](#session-wait-time) section.

## Average speed to answer

This metric measures how quickly the customer service team responds to a customer's request. It's calculated by dividing the total time a customer waited in queue (after their issue is escalated from an AI agent to a service representative) by the total number of handled conversations. Average speed to answer reflects the efficiency and availability of the service representatives. A lower average speed to answer indicates that customers can get their issues resolved more quickly and have a better experience with the service.

If an AI agent or IVR handles the customer before it escalates the issue to a service representative, the calculation is based on the time between the point when the AI agent or IVR escalates the incoming conversation to a service representative and the point when the service representative accepts the conversation.

If the customer reaches a service representative queue directly, the calculation is based on the time between the point when the customer creates the request and the point when a service representative accepts the conversation.

This metric is available in two formats: seconds and *hh:mm:ss*.

#### Related metrics

- **Service level (10 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 10 seconds.
- **Service level (20 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 20 seconds.
- **Service level (30 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 30 seconds.
- **Service level (40 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 40 seconds.
- **Service level (60 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 60 seconds.
- **Service level (120 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 120 seconds.
- **Speed to answer**: This metric is a measure of the time before a customer request is accepted.

For information about metrics that are related to how quickly a service representative accepts a request, go to the [Average speed to answer](#average-speed-to-answer) section.

## Conversation handle time

This metric is a measure of the time that service representatives spend actively helping customers and resolving their issues. If multiple service representatives handle a conversation, the time that all the service representatives spend is aggregated. This metric also includes time that service representatives spend wrapping up the conversation after the customer disconnects, and the time that they spend updating notes or contact details. However, it excludes time that subject matter experts or other service representatives spend consulting with service representatives who are assigned to work on customer conversations.

For for chat and digital messaging channels, a service representative is considered as actively working on a conversation if they have the conversation open in the Customer Service workspace app. If a service representative is handling multiple conversations, including conversations that they're currently wrapping up, only the time that the service representative spends on the conversation on an open tab counts toward that conversation's handle time.

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

This metric can be viewed in two formats: seconds and *hh:mm:ss*.

:::image type="content" source="../media/simple-chat-conversation.png" alt-text="Diagram that illustrates conversation handle time.":::

### Related metric:

- **Average conversation handle time**: This metric represents the average duration of a single customer interaction. This metric represents the total handle time divided by the number of conversations handled.

For information about metrics that are related to the time that individual service representatives spend when multiple service representatives handle conversations, see [Average session handle time](session-metrics.md#average-session-handle-time).


## Average conversation hold time

This metric is a measure of the average time, in seconds, that the service representatives who handled a conversation had the customer on hold. If multiple service representatives handled the conversation, the hold time across all the service representatives is aggregated. This metric is calculated by dividing the total hold time for all customer requests by the total number of handled conversations.

There are several reasons why a service representative might put a customer on hold. For example, the service representative might have to gather more information or research an issue, perform tasks that don't require interaction (for example, entering data into a system), or work on an offline task. A long hold time can cause customer frustration and might lead to a poor customer experience.

:::image type="content" source="../media/conversation-hold-time.png" alt-text="Diagram that illustrates conversation hold time and talk time.":::

## Average conversation talk time

This metric is a measure of the average time, in seconds, that service representatives spent actively conversing with customers on the phone for voice conversations. If multiple service representatives handled the conversation, the conversation talk time is aggregated across all the service representatives. This metric is calculated by dividing the total talk time for all customer requests by the total number of handled conversations.

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

This metric is a count of conversations that are currently in a Wrap-up state. A conversation is moved to a Wrap-up state when the service representative ends the conversation or when the customer leaves the conversation, either by ending it on their side or by being disconnected. Learn more in [Understand conversation states](oc-conversation-state.md#understand-conversation-states).

#### Related metric:

- **Agents in wrap-up conversations**: Number of representatives handling conversations that are in wrap-up state.

### Total conversations

This metric is a measure of the total number of customer conversations. Learn more in [Understand conversation states](oc-conversation-state.md#understand-conversation-states).

#### Related metrics:

- **Total conversations offered**: Total number of conversations initiated with service representatives.
- **Total conversations handled**: Total conversations offered that were accepted by service representatives.

### Incoming conversation

This metric is a measure of the total number of conversation requests that customers initiated across all channels and received by the contact center. Learn more in [Understand conversation states](oc-conversation-state.md#understand-conversation-states).

### Sentiment

The metric is a measure of the current sentiment of customer. It's powered by Contact Center sentiment analysis.

### Average session handle time

This metric is similar to conversation handle time, but it's granular and is calculated for every service representative who works on the conversation. This metric is relevant to conversations that multiple service representatives handled. If multiple service representatives were assigned to work on a customer request for any reason (for example, transfers or escalations), this metric measures the average time that each service representative who worked with the customer spent. Conversation handle time is a measure of the aggregated session handle time for all the associated sessions.

#### Related metric

- **Session handle time**: This metric is a measure of the time that service representatives spend helping customers on assigned customer requests.

### Customer sentiment

This metric is a measure of the current sentiment of the customer. It's powered by Contact Center sentiment analysis.

### Is handled by external participant (session)

Multiple service representatives might handle a customer request, including a combination of internal contact center service representatives and external service representatives. For example, your contact center can engage external service representatives through transfers to an external phone number or through a Microsoft Teams voice call. This metric is used to identify the portion of a customer request that service representatives outside Dynamics 365 Customer Service handled. It indicates the sessions that were assigned to and handled by external service representatives only.

For information about metrics that are related to consultations with external service representatives, go to the [Is handled by external participant (session)](#is-handled-by-external-participant-session) section.

### Session transfer rate

This metric is a measure of the rate at which service representatives transfer work that is assigned to them, or the rate at which supervisors transfer work in the queue that they monitor from one service representative to another or to another queue. It's calculated by dividing the total number of transferred sessions by the total number of handled sessions.

#### Related metrics

- **Is Transferred Out**: This metric indicates whether the conversation and the underlying session were transferred out of a queue.
- **Transferred sessions**: This metric is a measure of the total number of sessions that were transferred.

### Session rejection rate

This metric is a measure of the rate at which service representatives reject work that is assigned to them. It's calculated by dividing the total number of sessions that service representatives rejected by the total number of sessions assigned to them.

#### Related metrics

- **Rejected sessions**: This metric is a measure of the total number of times that service representatives rejected work that was assigned to them.
- **Session time to reject**: This metric is a measure of the average time that service representatives take to reject work that is assigned to them. The calculation is based on the time between the point when a customer request is assigned to a service representative and the point when the service representative rejects the request.

### Session time to accept

This metric is a measure of the average time that service representatives take to accept work that is assigned to them. The calculation is based on the time between the point when a customer request is assigned to a service representative and the point when the service representative accepts the request.

#### Related metric

- **Engaged sessions**: This metric is a measure of the total number of sessions that service representatives accepted.

### Session timeout rate

This metric is a measure of the rate at which sessions time out because of service representative's inactivity. The service representative didn't accept or reject the customer requests. This metric is calculated by dividing the total number of requests where the service representative didn't provide any response by the total number of sessions that were assigned to them.

#### Related metric

- **Timeout sessions**: This metric is a measure of the total number of times that service representatives didn't respond to the work that was assigned to them.

### Session wait time

This metric is a measure of the time, in seconds, that a customer spends waiting in a specific queue before an service representative accepts their request. If the customer abandons the request, or if the conversation is transferred to another queue, the calculation is based on the time between the point when the customer request arrives in the queue and the point when the request is closed.

### Active sessions

This metric is a count of sessions that are currently in progress. The system considers a session active if no service representative has yet been assigned to it, it's awaiting service representative acceptance, or service representatives are actively helping customers.

### Closed sessions

This metric is a count of sessions that are currently closed.

### Total sessions

This metric is a measure of the total number of sessions that were presented to or handled by service representatives.

### Is handled by external participant

Multiple service representatives might handle a customer request, including a combination of internal contact center service representatives and external service representatives. For example, your contact center can engage external service representatives through transfers to an external phone number or through a Microsoft Teams voice call. This metric is used to identify the portion of a customer request that service representatives outside Dynamics 365 Customer Service handled.

#### Related metrics

- **External participant channel**: This metric helps identify the channels that external service representatives were engaged through. For example, an external service representative can help customers with requests by calling them directly at their phone number or via a Microsoft Teams Public Switched Telephone Network (PSTN) call.
- **External participant channel type**: This metric represents the details of the external service representative, such as the phone number.

### Session participant count

This metric is a measure of the total number of service representatives who were involved in helping a customer. These service representatives include the primary service representative who was assigned to work on the session and any subject matter experts who were consulted. You can use the SessionParticipationType dimension to analyze this metric and get further statistics.

### Average first response time

Speed to answer provides insights into how quickly a service representative was connected with a customer, whereas first response time provides insights into how quickly the service representative responded to the customer. First response time is a measure of the time that customers spend waiting for a first response from a service representative. The time is adjusted based on operating hours. The calculation is based on the time between the point when a customer initiates a conversation (or, in the case of an AI agent-escalated conversation, the point when the AI agent escalates it) and the point when the service representative accepts the request and responds to the customer. For messaging conversations, this time represents how soon the service representative sent the first response to customer.

The system calculates average first response time by dividing the total first response time across all engaged conversations by the number of engaged conversations.

The time can be viewed in two formats: seconds and *hh:mm:ss*.

### Average service representative response time

Service representative response time is a measure of the average time that customers who sent a message must wait to get a response from a service representative. The time is adjusted based on operating hours. The system calculates average service representative response time by dividing the total response time by the number of exchanges between customers and service representatives across all engaged conversations. A longer response time indicates that more time passes between messages as customers wait for a service representative to respond and provide updates. A longer response time negatively affects the customer experience.

The time can be viewed in two formats: seconds and *hh:mm:ss*.

### First response service level

This metric is a measure of the percentage of customer conversations that have a service representative response time of less than 60 seconds.

### Service representative response service level

This metric is a measure of the percentage of customer messages that have a service representative response time of less than 60 seconds.

### Assigned capacity profile count

This metric is a count of capacity profiles that are assigned to service representatives.

### Total available work item capacity

This metric is a measure of the maximum number of more work items that can be assigned.

### Total work item capacity in use

This metric is a measure of the work items that are currently being handled.

### Total work item capacity

This metric is a measure of the maximum work items that are allowed, based on the configuration of the capacity profile.

### Logged in service representatives

This metric is a count of omnichannel service representatives who are currently signed in.

### Total service representatives

This metric is a measure of the total number of omnichannel service representatives.

### Total available capacity units

This metric is a measure of the capacity units that are available to handle conversations.

### Total capacity units

This metric is a measure of the maximum capacity units that are assigned. It applies only to organizations that use capacity units.

### Total occupied capacity units

This metric is a measure of the capacity units that are currently occupied.

### Status duration

This metric is a measure of the time that a service representative spent in a presence status.

## Related information

[Customize visual display](customize-reports.md#customize-visual-display)
[Session](session-metrics.md#session)
[Service representatives](service-rep-metrics.md#service-representatives)
