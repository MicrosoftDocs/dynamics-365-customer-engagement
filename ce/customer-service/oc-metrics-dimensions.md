---
title: Use Omnichannel for Customer Service metrics
description: Understand and use Omnichannel for Customer Service metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.date: 07/21/2023
ms.custom: bap-template
---

# Use Omnichannel for Customer Service metrics

This article describes the different metrics that help you analyze key performance indicators (KPIs) as you work with agents in your contact center. Use metrics to do a quantitative assessment of the data that is shown on the Omnichannel for Customer Service dashboards. Metrics can also help you make strategic decisions, and track and improve customer satisfaction.

## Understand the Omnichannel analytics data model

Omnichannel for Customer Service provides an out-of-box data model that consists of fact and dimension tables.

- Facts, also known as metrics, represent the observational or event data that you want to analyze. Fact tables logically organize KPIs. For example, the `FactConversation` table has conversation metrics such as average handle time, whereas the `FactAgent` table has agent metrics.
- Dimensions represent the attributes of the facts. You can use them to break down the data for further analysis.

You can use facts and dimensions to visualize data according to your organizational requirements. For example, if you want to understand how average handle time varies by queue, you can filter the Average handle time fact by the Queue name dimension.

Fact tables are larger than dimension tables because numerous events, such as individual customer requests, occur in them. Dimension tables are typically smaller because you're limited to the number of items that you can filter on and group. For example, the number of queues is a limited set.

## Understand the Omnichannel for Customer Service workflow

Here is a brief description of the workflow.

When a customer raises a request through a channel such as voice, messaging, or chat, a conversation is created. A conversation represents an entire end-to-end interaction with a customer. A conversation can also be created when an agent calls a customer. A conversation typically originates in a workstream on a specific channel. It's then routed to a queue, based on your organizational rule settings. A conversation entity holds metrics about your customer's experience with the contact center. These metrics include the current status, wait time, handle time, and current customer sentiment.

A conversation can end during a single session, or it can extend to multiple sessions. A session is created when the system identifies an agent to work on a conversation. New sessions are created for different reasons. For example, a conversation might be transferred to a different queue, or an agent might reject a conversation request or let it time out. From this entity, you can get KPIs and metrics that describe queue performance and agent performance. Examples include the number of requests that landed in a queue, the number of requests that agents rejected, and agent handle time.

The workflow in the following diagram represents a single conversation where multiple sessions are created. The first session is created when the conversation is created and assigned to a bot. When the bot escalates the conversation to a human agent, the second session is created, and the first session is automatically closed. In the second session, the system identifies and assigns the best agent to work on the customer request. If that agent rejects the request, a new session is created, and the process of identifying another agent begins.

:::image type="content" source="media/customer-workflow.png" alt-text="Diagram that shows the customer conversation journey." lightbox="media/customer-workflow.png":::

For every agent who is identified to work on a conversation and associated with the latest session, a session participant entry is created. A single session can have multiple participants. Every session has one primary participant: the agent who has the assigned work item. A session might then have many other participants who monitor the conversation or help with the consultation. Alternatively, the session might have no other participants. From this entity, you can get KPIs and metrics about consultations that agents provide and monitored conversations.

## Dimensions

This section describes the different dimensions of the out-of-box omnichannel real-time analytics metrics.

For information about how you can use these metrics to customize the visual display of your reports, go to [Customize visual display](customize-reports.md).

### Capacity profile name

This dimension represents the name of the capacity profile.

### Conversation direction

This dimension applies only to voice conversations. It indicates whether the customer or an agent in the contact center initiated the conversation.

If a contact center agent initiates the conversation (and the customer receives it), it's considered outbound. If the customer initiates the conversation (and the contact center receives it), it's considered inbound.

### Conversation status

This dimension represents the current state of a customer interaction. The following status values are available:

- **Open**: The conversation is currently awaiting agent assignment.
- **Active**: Either the conversation has had an agent assigned and is awaiting acceptance, or an agent is in contact with the customer.
- **Waiting**: The conversation is currently awaiting either a customer response or an agent response. This option applies to asynchronous conversation modes, such as messages.
- **Wrap-up**: The agent is performing post–customer interaction activities such as adding notes or updates to the case after the end of a customer conversation.
- **Closed**: The conversation is currently closed.

### Queue name

This dimension represents the name of the queue.

### Agent presence

This dimension represents the statuses that are available for agents. The out-of-box options include *Online*, *Away*, *Busy*, *Offline*, and *Do Not Disturb*. The status options that are available to you depend on your organization's configuration and include any other custom presence statuses that have been configured for your organization.

### Date hour

This dimension represents the hour of the day in 24-hour format.

### Time range

The following time-based filter options are available on real-time dashboards:

- **Today**: View all conversations that have begun since 12 AM in the selected time zone, in any state or province.
- **Last 24 hours**: View all conversations that have begun in the last 24 hours, in any state or province.
- **Include open conversations beyond 24 hours**: View all conversations that have begun in the last 24 hours, in any state or province. In addition, view all conversations that have begun in the last three days and that are still open.

### Time zone

This dimension represents the time zone that is used to calculate and show metrics across the dashboards. The available options are standard time zones.

### Agent name

This dimension represents the name of the omnichannel agent.

### Agent participation mode

The following agent participation modes are available:

- **Primary**: Agent participation mode is *Primary*.
- **Consult**: Agent participation mode is *Consult*.
- **Monitor**: Supervisor participation mode is *Monitor*. This option applies only to users who have the Omnichannel supervisor role.

### Workstream name

This dimension represents the name of the omnichannel workstream where the conversation originated.

### Channel name

This dimension represents the name of the channel.

## Metrics

### Conversation first wait time

This metric is a measure of the time, in seconds, before a human agent responds to a customer's request. In other words, it represents the amount of time that the customer spends waiting for the first response from a human agent. Agent availability, a high volume of requests, and increased handle time are some factors that can affect customer wait time. A shorter wait time indicates that customers get faster issue resolution and have a better support experience.

If a bot or interactive voice response (IVR) handles the customer before it escalates the issue to a human agent, the calculation is based on the time between the point when the bot or IVR escalates the incoming conversation to a human agent and the point when the agent accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the bot or IVR escalates the conversation to a human agent and the point when the customer disconnects the conversation.

If the customer reaches a human agent queue directly, the calculation is based on the time between the point when the customer creates the request and the point when a human agent accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the customer creates the request and the point when the customer disconnects the conversation.

This metric is available in two formats: seconds and *hh:mm:ss*.

#### Related metrics

- **Average conversation first wait time**: This metric is calculated by dividing the total wait time for customers who are waiting in the queue by the total number of customers who were served.
- **Longest wait time**: This metric is a measure of the longest first wait time among incoming conversations that an agent hasn't yet accepted.
- **Conversations in queue**: This metric is a count of customer requests that are currently awaiting agent assistance, or conversations that have had an agent assigned but are awaiting agent acceptance.

For information about metrics that are related to the time that customers wait in individual queues if they are transferred from one agent to another, go to the [Session wait time](#session-wait-time) section.

### Average speed to answer

This metric measures how quickly the customer service team responds to a customer's request. It's calculated by dividing the total wait time for customers who are waiting in the queue (after their issue has been escalated from a bot to a human agent) by the total number of customers who were served. Average speed to answer reflects the efficiency and availability of the agents. A lower average speed to answer indicates that customers can get their issues resolved more quickly and have a better experience with the service.

If a bot or IVR handles the customer before it escalates the issue to a human agent, the calculation is based on the time between the point when the bot or IVR escalates the incoming conversation to a human agent and the point when the agent accepts the conversation.

If the customer reaches a human agent queue directly, the calculation is based on the time between the point when the customer creates the request and the point when a human agent accepts the conversation.

This metric is available in two formats: seconds and *hh:mm:ss*.

#### Related metrics

- **Service level (10 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 10 seconds.
- **Service level (20 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 20 seconds.
- **Service level (30 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 30 seconds.
- **Service level (40 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 40 seconds.
- **Service level (60 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 60 seconds.
- **Service level (120 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 120 seconds.
- **Speed to answer**: This metric is a measure of the time before a customer request is accepted.

For information about metrics that are related to how quickly an agent accepts a request, go to the [Average speed to answer](#average-speed-to-answer) section.

### Conversation handle time

This metric is a measure of the time that human agents spend actively helping customers and resolving their issues. If multiple agents handle a conversation, the time that all the agents spend is aggregated. This metric also includes time that agents spend wrapping up the conversation after the customer disconnects, and the time that they spend updating notes or contact details. However, it excludes time that subject matter experts or other agents spend consulting with agents who are assigned to work on customer conversations.

An agent is considered actively working on a conversation if they have the conversation open in the Customer Service Workspace app. If an agent is handling multiple conversations, including conversations that they are currently wrapping up, only the time that the agent spends on the conversation on an open tab is counted toward that conversation's handle time.

A long average handle time might indicate that agents are taking too long to resolve customer issues, and that they need more training or support to help them work better. In addition, a long average handle time might suggest that customers aren't receiving the level of service or support that they need to resolve their issues. Therefore, it might lead to customer dissatisfaction.

This metric can be viewed in two formats: seconds and *hh:mm:ss*.

:::image type="content" source="media/simple-chat-conversation.png" alt-text="Diagram that illustrates conversation handle time.":::

#### Related metric

- **Average handle time**: This metric is calculated by dividing the total handle time of all the customer requests by the total number of customers who were served.

For information about metrics that are related to the time that individual agents spend when multiple agents handle conversations, go to the [Average session handle time](#average-session-handle-time) section.

### Average conversation hold time

This metric is a measure of the average time, in seconds, that the human agents who handled a conversation had the customer on hold. If multiple agents handled the conversation, the hold time across all the agents is aggregated. This metric is calculated by dividing the total hold time for all customer requests by the total number of customers who were served.

There are several reasons why an agent might put a customer on hold. For example, the agent might have to gather more information or research an issue, perform tasks that don't require interaction (for example, entering data into a system), or work on an offline task. A long hold time can cause customer frustration and might lead to a poor customer experience.

:::image type="content" source="media/conversation-hold-time.png" alt-text="Diagram that illustrates conversation hold time and talk time.":::

### Average conversation talk time

This metric is a measure of the average time, in seconds, that human agents spent actively conversing with customers on the phone for voice conversations. If multiple agents handled the conversation, the conversation talk time is aggregated across all the agents. This metric is calculated by dividing the total talk time for all customer requests by the total number of customers who were served.

#### Related metric

- **Conversation talk time**: This metric is calculated based on the total talk time across all customer requests.

### Average conversation time

This metric is a measure of the average time, in seconds, that a customer who was seeking help from the contact center spent with a human agent. It includes the time that the customer spent waiting for agents to work with them.

#### Related metric

- **Conversation time**: This metric is calculated as the time between the point when the customer initiated the request and the point when the agent wrapped up the conversation.

### Average conversation wrap-up time

This metric is a measure of the average time that an agent spends completing any necessary tasks after the customer disconnects. These tasks might include documenting the conversation, updating notes, or updating the customer's information. The calculation is based on the time between the beginning of the wrap-up and the point when the agent closes the conversation. If multiple agents handled a conversation, this metric applies only to the time that the last agent who worked with the customer spent.

This metric can be viewed in two formats: seconds and *hh:mm:ss*.

### Abandoned conversations

A conversation can be abandoned for multiple reasons. For example, a customer might be disconnected or might cancel the call because of a long waiting period, supervisors might forcibly close requests, or automatic system actions might be configured to respond to handle overflow. Abandoned conversations can lead to customer dissatisfaction because of a lack of assistance from the contact center. A high abandonment rate might require further investigation into operational metrics such as agent availability and queue distribution.

If a bot or IVR handles the customer before it escalates the request to a human agent, this metric is calculated as the number of conversations that were abandoned while customers were waiting for a human agent after the bot escalated the request. If a conversation is abandoned before a bot can be assigned, the conversation is considered abandoned.

If the customer reaches a human agent queue directly, this metric is calculated as the number of incoming conversations that were abandoned.

The conversation direction is *Incoming*. The channels that the conversation came in through are *Messaging* and *Voice*.

:::image type="content" source="media/abandoned-conversation.png" alt-text="Diagram that illustrates abandoned conversations.":::

#### Related metric

- **Abandoned rate**: This metric is a measure of the percentage of incoming conversation requests that ended before customers were connected to a human agent. It's calculated by dividing the number of abandoned conversations by the number of bot-escalated conversations.

### Active conversations awaiting agent acceptance

This metric is a count of conversation requests from customers that have had agents assigned but that are currently waiting for an agent to accept them and join the conversation. The conversations revert to an *Open* state if the agent rejects or responds to the request.

### Active conversations with agent acceptance

This metric is a count of conversations where an agent has been assigned and is actively in contact with the customer. Supervisors can monitor these conversations, track sentiment to ensure customer satisfaction, and intervene as needed.

### Waiting conversations

This metric is a count of conversations that are currently in a *Waiting* state. A conversation is moved to a *Waiting* state when the agent closes the session without ending the conversation (that is, without selecting the **End** button on the communication panel), or when the customer closes the browser window without closing the chat widget. If there are asynchronous messaging channels, a *Waiting* state indicates conversations that are waiting for an agent to respond. For more information, go to [Understand conversation states](oc-conversation-state.md#understand-conversation-states).

### Wrap-up conversations

This metric is a count of conversations that are currently in a *Wrap-up* state. A conversation is moved to a *Wrap-up* state when the agent ends the conversation, or when the customer leaves the conversation either by ending it on their side or by being disconnected. For more information, go to [Understand conversation states](oc-conversation-state.md#understand-conversation-states).

### Total conversations

This metric is a measure of the total number of customer conversations. For more information, go to [Understand conversation states](oc-conversation-state.md#understand-conversation-states).

### Incoming conversation

This metric is a measure of the total number of conversation requests that were initiated by customers across all channels and received by the contact center. For more information, go to [Understand conversation states](oc-conversation-state.md#understand-conversation-states).

### Sentiment

The metric is a measure of the current sentiment of customer. It's powered by Omnichannel for Customer Service sentiment analysis.

### Average session handle time

This metric is like conversation handle time, but it's granular and is calculated for every agent who works on the conversation. This metric is relevant to conversations that multiple agents handled. If multiple agents were assigned to work on a customer request for any reason (for example, transfers or escalations), this metric measures the average time that each agent who worked with the customer spent. Conversation handle time is a measure of the aggregated session handle time for all the associated sessions.

#### Related metric

- **Session handle time**: This metric is a measure of the time that agents spend helping customers on assigned customer requests.

### Customer sentiment

This metric is a measure of the current sentiment of the customer. It's powered by Omnichannel for Customer Service sentiment analysis.

### Is handled by external participant (session)

A customer request might be handled by multiple agents, including a combination of internal contact center agents and external agents. For example, your contact center can engage external agents through transfers to an external phone number or through a Microsoft Teams voice call. This metric is used to identify the portion of a customer request that agents outside Dynamics 365 Customer Service handled. It indicates the sessions that were assigned to and handled by external agents only.

For information about metrics that are related to consultations with external agents, go to the [Is handled by external participant (session)](#is-handled-by-external-participant-session) section.

### Session transfer rate

This metric is a measure of the rate at which agents transfer work that is assigned to them, or the rate at which supervisors transfer work in the queue that they monitor from one agent to another or to another queue. It's calculated by dividing the total number of sessions that were transferred by the total number of sessions that were handled.

#### Related metrics

- **Is Transferred Out**: This metric indicates whether the conversation and the underlying session were transferred out of a queue.
- **Transferred sessions**: This metric is a measure of the total number of sessions that were transferred.

### Session rejection rate

This metric is a measure of the rate at which agents reject work that is assigned to them. It's calculated by dividing the total number of sessions that agents rejected by the total number of sessions that were assigned to them.

#### Related metrics

- **Rejected sessions**: This metric is a measure of the total number of times that agents rejected work that was assigned to them.
- **Session time to reject**: This metric is a measure of the average time that agents take to reject work that is assigned to them. The calculation is based on the time between the point when a customer request is assigned to an agent and the point when the agent rejects the request.

### Session time to accept

This metric is a measure of the average time that agents take to accept work that is assigned to them. The calculation is based on the time between the point when a customer request is assigned to an agent and the point when the agent accepts the request.

#### Related metric

- **Engaged sessions**: This metric is a measure of the total number of sessions that agents accepted.

### Session timeout rate

This metric is a measure of the rate at which sessions time out because of agent inactivity. The agent didn't accept or reject the customer requests. This metric is calculated by dividing the total number of requests where the agent didn't provide any response by the total number of sessions that were assigned to them.

#### Related metric

- **Timeout sessions**: This metric is a measure of the total number of times that agents didn't respond to the work that was assigned to them.

### Session wait time

This metric is a measure of the time, in seconds, that a customer spends waiting in a specific queue before an agent accepts their request. If the customer abandons the request, or if the conversation is transferred to another queue, the calculation is based on the time between the point when the customer request arrives in the queue and the point when the request is closed.

### Active sessions

This metric is a count of sessions that are currently in progress. A session is considered active if no agent has yet been assigned to it, it's awaiting agent acceptance, or agents are actively helping customers.

### Closed sessions

This metric is a count of sessions that are currently closed.

### Total sessions

This metric is a measure of the total number of sessions that were presented to or handled by agents.

### Is handled by external participant

A customer request might be handled by multiple agents, including a combination of internal contact center agents and external agents. For example, your contact center can engage external agents through transfers to an external phone number or through a Microsoft Teams voice call. This metric is used to identify the portion of a customer request that agents outside Dynamics 365 Customer Service handled.

#### Related metrics

- **External participant channel**: This metric helps identify the channels that external agents were engaged through. For example, an external agent can help customers with requests by calling them directly at their phone number or via a Microsoft Teams Public Switched Telephone Network (PSTN) call.
- **External participant channel type**: This metric represents the details of the external agent, such as the phone number.

### Session participant count

This metric is a measure of the total number of agents who were involved in helping a customer. These agents include the primary agent who was assigned to work on the session and any subject matter experts who were consulted. You can use the SessionParticipationType dimension to analyze this metric and get further statistics.

### Average first response time

Whereas speed to answer provides insights into how quickly an agent was connected with a customer, first response time provides insights into how quickly the agent responded to the customer. First response time is a measure of the time that customers spend waiting for a first response from a human agent. The time is adjusted based on operating hours. The calculation is based on the time between the point when a customer initiates a conversation (or, in the case of a bot-escalated conversation, the point when the bot escalates it) and the point when the agent accepts the request and responds to the customer. For messaging conversations, this time represents how soon the agent sent the first response to customer.

Average first response time is calculated by dividing the total first response time across all engaged conversations by the number of engaged conversations.

The time can be viewed in two formats: seconds and *hh:mm:ss*.

### Average agent response time

Agent response time is a measure of the average time that customers who have sent a message must wait to get a response from a human agent. The time is adjusted based on operating hours. Average agent response time is calculated by dividing the total response time by the number of exchanges between customers and agents across all engaged conversations. A longer response time indicates that more time passes between messages as customers wait for an agent to respond and provide updates. A longer response time negatively affects the customer experience.

The time can be viewed in two formats: seconds and *hh:mm:ss*.

### First response service level

This metric is a measure of the percentage of customer conversations that have an agent response time of less than 60 seconds.

### Agent response service level

This metric is a measure of the percentage of customer messages that have an agent response time of less than 60 seconds.

### Assigned capacity profile count

This metric is a count of capacity profiles that are assigned to agents.

### Total available work item capacity

This metric is a measure of the maximum number of more work items that can be assigned.

### Total work item capacity in use

This metric is a measure of the work items that are currently being handled.

### Total work item capacity

This metric is a measure of the maximum work items that are allowed, based on the configuration of the capacity profile.

### Logged in agents

This metric is a count of omnichannel agents who are currently signed in.

### Total agents

This metric is a measure of the total number of omnichannel agents.

### Total available capacity units

This metric is a measure of the capacity units that are available to handle conversations.

### Total capacity units

This metric is a measure of the maximum capacity units that are assigned. It applies only to organizations that use capacity units.

### Total occupied capacity units

This metric is a measure of the capacity units that are currently occupied.

### Status duration

This metric is a measure of the time that an agent spent in a presence status.

## See also

[Omnichannel for Customer Service dashboards](omnichannel-analytics-insights.md#omnichannel-for-customer-service-dashboards)

[Overview of Omnichannel real-time analytics dashboards](intro-realtime-analytics-dashboard.md)
