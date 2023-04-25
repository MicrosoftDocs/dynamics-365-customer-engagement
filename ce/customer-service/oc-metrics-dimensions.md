---
title: Use Omnichannel for Customer Service metrics
description: Understand and use Omnichannel for Customer Service metrics
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.date: 04/25/2023
ms.custom: bap-template
---

# Use Omnichannel for Customer Service metrics

The article describes the various metrics that help you analyze the key performance indicators (KPIs) as you work with your agents in your contact center. With metrics, you can make quantitative assessment of the data that you see on the Omnichannel for Customer Service dashboards, make strategic decisions, track and improve customer satisfaction.

## Understand the Omnichannel analytics data model  

Omnichannel for Customer Service provides you with out-of-the-box data model, which consists of facts and dimension tables. Facts, otherwise known as metrics, represent the observational or event data you want to analyze. Fact tables organize key KPIs logically. For example, FactConversation has conversation metrics like Average handle time, while FactAgent has Agent metrics.

Dimensions represent the attributes of the facts, that you can use to break down with and analyze. You can use facts and dimensions to visualize data, according to your organizational requirements. If you'd like to understand how average handle time varies by queue, you can filter the fact Average Handle Time by the dimension Queue Name.
 
Fact tables are much larger than dimension tables because numerous events occur in fact tables, such as individual customer requests. Dimension tables are typically smaller because you are limited to the number of items that you can filter and group on. For instance, number of queues is a limited set.

## Understand the Omnichannel for Customer Service workflow

Here's a brief description of the workflow.

When a customer raises a request through various channels like voice, messaging, or chat, a conversation is created. A conversation represents an entire end-to-end interaction with a customer. A conversation can also be created when an agent calls a customer. A conversation typically originates in a workstream on a specific channel and gets routed to a queue, based on your organizational rule settings. A conversation entity holds metrics about your customer’s experience with the contact center, such as current status, wait time, handle time, and current customer sentiment.

A conversation can end in a single session or extend to multiple sessions. When the system identifies an agent to work on a conversation, a session is created. New sessions are created because of reasons such as a conversation being transferred to a different queue, an agent rejecting a conversation request or letting the request time out. You can get KPIs and metrics that describe queue performance, agent performance from this entity, for example, number of requests that landed in a queue, number of requests rejected by agents, and agent handle time.

In the following workflow, which represents a single conversation, you’ll see that multiple sessions are created. The first session is created when a conversation is created and assigned to a bot. The second session is created when the bot escalates the conversation to a human agent. This automatically closes the first session. In the second session, the best agent to work on the customer request is identified and assigned. If the agent rejects the request, a new session is created and the process of identifying another agent begins.

:::image type="content" source="media/customer-workflow.png" alt-text="The image describes the customer conversation journey.":::

For every agent who is identified to work on a conversation and gets associated with the latest session, a session participant entry is created. A single session can have multiple participants. Every session has one primary participant, that is the agent with the assigned work item. A session can also have none or many additional participants who monitor the conversation or help with the consult. You can get KPIs and metrics around consults provided by agents and monitored conversations from this entity.

## Dimensions

The following describes the various dimensions of the out-of-box Omnichannel real-time analytics metrics to suit your needs.

For more information about how you can customize the visual display of your reports using these metrics, go to [Customize visual display](customize-reports.md).

### Capacity profile name

Name of the capacity profile.

### Conversation direction

This applies only to voice conversations and indicates whether the conversation was started by the customer or a contact center agent.

If the conversation was initiated by an agent in the contact center, it is considered as outbound. If the conversation was received by the contact center, it is considered as inbound.

### Conversation status

Represents the current state of a customer interaction. The following is a list of the status values and their meaning:

- Open: Conversation is currently awaiting an agent assignment.
- Active: Conversation has either an agent assigned and is pending acceptance, or has an agent in contact with the customer.
- Waiting: Conversation is currently waiting for either a customer response or an agent response. Applies for asynchronous conversation modes, such as messages.
- Wrap-up: Agent is currently performing post customer interaction activities such as notes, updates to case, after the end of a customer conversation.
- Closed: Conversation is currently closed.

### Queue name

Name of the queue.

### Agent presence

This metric represents the statuses available for agents. The out-of-box options include Online, Away, Busy, Offline, Do Not Disturb. The status options available to you will depend on your organization's configuration and will include any additional custom presence statuses configured for your organization.

### Date hour

Represents hour of the day in a 24h format.

### Time range

The following time-based filter options are available on real-time dashboards:
  
- Today: Shows all conversations that started since 12 AM in the selected time zone, in any state.
- Last 24 hours: Shows all conversations that started in the last 24 hours, in any state.
- Include open conversations beyond 24 hours: Shows all conversations that started in the last 24 hours, in any state, and those that started in the last three days and are still open.

### Time zone

Represents the time zone used to calculate and display metrics across the dashboard. Options available are standard time zones.

### Agent name

Name of the Omnichannel agent.

### Agent participation mode

The following are the agent participation modes:

- Primary: Agent participation mode is primary.
- Consult: Agent participation mode is consult.
- Monitor: Supervisor participation mode is monitor. Applies only to users with Omnichannel supervisor role.

### Workstream name

Name of the Omnichannel workstream from which the conversation originated.

### Channel name

Name of the channel.

## Metrics

### Conversation first wait time

It is a measure of the time taken before an agent responds to a customer's request. It represents the time, in seconds, spent by a customer waiting to get the first response from a human agent. Agent availability, high volume of requests, increased handle time could be some of the reasons that can influence customer waiting time. Lower waiting time indicates that customers get issue resolution faster and have a better support experience.  

If bot or IVR handles the customer before escalating the issue to human agent, the calculation is based on the time between a bot escalating an incoming conversation to a human agent and an agent accepting the conversation. If the customer ends up abandoning the conversation, the calculation is based on the time between a bot passing the conversation to the human representative and the customer disconnecting the conversation.

If the customer reaches human agent queue directly, the calculation is based on the amount of time between  a customer creating the request and an agent accepting the conversation. If the customer ends up abandoning the conversation, the calculation is based on the time between the customer creating the request to the human agent and the customer disconnecting the conversation.

This metric is available in two formats, seconds and in hh:mm:ss.

**Related metric**

- Average conversation first wait time: This metric is calculated by taking the total waiting time for customers waiting in queue, and then dividing it by the total number of customers who were served.
- Longest wait time: This metric is measured as the longest first waiting time amongst incoming conversations that are yet to be accepted by an agent.
- Conversations in queue: This metric is measured as the count of customer requests that are currently awaiting agent assistance or conversations that have been assigned an agent, but are waiting for agent acceptance.
 
For metrics around how much time customers had to wait in individual queues, if they get transferred from one agent to another, refer to [Session wait time](#session-wait-time).

### Average speed to answer

It is a measure of how quickly the customer service team responds to a customer's request. It is calculated by taking the total waiting time for customers waiting in the queue (after being escalated from the bot to get support from a human agent) and then dividing it by the total number of customers who are were served. Average speed to answer reflects the efficiency and availability of the agents. A low average speed to answer indicates that customers can get their issues resolved faster and have a better experience with the service.  

If bot or IVR handles the customer before escalating it to a human agent, the speed to answer is calculated by the time between the bot escalating the incoming conversation to a human agent and the conversation getting accepted by a human agent.

If the customer reaches the human agent queue directly, the speed to answer is calculated by the time between creating a customer request and the request getting accepted by a human agent.
 
This metric is available in two formats - seconds and in hh:mm:ss.

**Related metrics**

- Service level (10 seconds): Percentage of customer conversation, where the speed to answer is less than or equal to 10 seconds.
- Service level (20 seconds): Percentage of customer conversation, where the speed to answer is less than or equal to 20 seconds.
- Service level (30 seconds): Percentage of customer conversation, where the speed to answer is less than or equal to 30 seconds.
- Service level (40 seconds): The percentage of customer conversation, where the speed to answer is less than or equal to 40 seconds.
- Service level (60 seconds): The percentage of customer conversation, where the speed to answer is less than or equal to 60 seconds.
- Service level (120 seconds): The percentage of customer conversation, where the speed to answer is less than or equal to 120 seconds.
- Speed to answer: Time taken to accept an customer request.

For metrics around how quickly an agent accepts a request, go to [Average speed to answer](#average-speed-to-answer).

### Conversation handle time  
 
Conversation handle time is time spent by human agents to actively assist and resolve the customer issue. If multiple agents handle the conversation, then the time spent by all the agents is aggregated. Time spent by agents to wrap up the conversation after the customer disconnects, update notes, or contact details is also included as the conversation handle time. Time spent by subject-matter experts or other agents consulting with agents assigned to work on customer conversation isn't included in this metric.  
 
An agent is considered actively working on the conversation, if they have the conversation open within the Customer Service Workspace application. If an agent is handling multiple conversations, including conversations they are wrapping up currently, only the time spent by the agent on the specific conversation on an open tab is counted towards that conversation’s handle time.

High average handle time could indicate that agents are taking too long to resolve customer issues, and that agents might need more training or support to help them work better. High average handle time also indicates customer dissatisfaction, as it may suggest that customers aren't receiving the level of service or support they need to resolve their issues.

To understand the time spent by individual agents, where conversations were handled by multiple agents, go to [Average session handle time](#average-session-handle-time).  

This metric can be viewed in the seconds and in hh:mm:ss formats.

:::image type="content" source="media/simple-chat-conversation.png" alt-text="The image describes conversation handle time":::

**Related metric** 

- Average handle time: This metric is calculated by taking the total handle time of all the customer requests, and then dividing it by the total number of customers who were served.

### Average conversation hold time

This metric represents the average time, in seconds, when the customer was put on hold by human agents handling the conversation. If the conversation was handled by multiple agents, conversation hold time is calculated as sum of hold time across all agents handling this conversation. This metric is calculated by taking the total hold time of all customer requests, and then dividing it by the total number of customers who are were served.

There are several reasons why an agent might put a customer on hold. For example, an agent might put a customer on hold to gather additional information or research an issue, perform tasks that don’t require interaction like entering data into a system, or perform an offline task. A higher hold time may cause customer frustrations and may lead to poor customer experience.

:::image type="content" source="media/conversation-hold-time.png" alt-text="The image describes conversation hold time and talk time.":::

### Average conversation talk time

This metric represents the average time, in seconds, spent by a human agent actively conversing with customers on the phone for voice conversation. If a conversation was handled by multiple agents, conversation talk time is aggregated across all agents. This metric is calculated by taking the total hold time of all customer request, and then dividing it by the total number of customers who are were served.

**Related metric** 

- Conversation talk time: This metric is calculated by taking the total talk time across all customer requests.  

### Average conversation time

This metric represents the average time, in seconds, that a customer spent with the human agent, while seeking assistance from the contact center. It includes the time spent waiting for agents to work with them.  

**Related metric**

- Conversation time: This metric is calculated as the time between the customer initiating the request and the agent wrapping up the conversation.

### Average conversation wrap up time

This metric represents the average time agents spend after the customer leaves to complete any necessary tasks, such as documenting the conversations, updating notes, or updating the customer’s information. It's calculated as the beginning of the wrap up to the closing of the conversation by the agent. If multiple agents handled a conversation, it applies only to the time spent by the agent who is last to work with the customer.

This metric can be viewed in two formats, seconds and in hh:mm:ss.

### Abandoned conversations

A conversation can be abandoned for multiple reasons, such as customer getting disconnected or cancelling the call due to a long waiting period, force closure of requests by supervisors, automatic system actions configured to respond to handle overflow. Abandoned conversations lead to customer dissatisfaction because of lack of assistance from the contact center. A higher abandoned rate may need further investigation into operational metrics such as agent availability and queue distribution.

If a bot or interactive voice response (IVR) handles the customer before escalating the request to human agent, it is calculated as the count of conversations that were abandoned while waiting for a human agent after escalation from bot. If the conversation is abandoned before a bot can be assigned, the conversation is considered abandoned. If customers reach human agent queue directly, it is also calculated as the count of incoming conversations that were abandoned.

The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice. 

:::image type="content" source="media/abandoned-conversation.png" alt-text="The image describes abandoned conversations.":::

**Related metric**

- Abandoned rate: Abandoned rate refers to the percentage of incoming conversation requests that ended before customers were connected to a human agent. This metric is calculated as the count of abandoned conversations divided by the count of bot-escalated conversations.

### Active conversations awaiting agent acceptance

It is the count of conversation requests from customers that have agents assigned, but are currently waiting for an agent to accept the request and join the conversation. These conversations revert to an Open conversation, if the agent chooses to reject the request or if they respond to the request.

### Active conversations with agent acceptance

It is the count of conversations that have an agent assigned and are actively in contact with the customer. Supervisors can monitor these conversations and track sentiment to ensure customer satisfaction and intervene, if needed.

### Waiting conversations
 
This metric is a count of conversations currently in a waiting state. A conversation gets transitioned to waiting when an agent closes the session without ending the conversation (that is, without selecting the End button on the communication panel), or when the customer closes the browser window without closing the chat widget. In case of asynchronous messaging channels, it refers to the conversations that are waiting for an agent to respond. More information: [Understand conversation states](oc-conversation-state.md#understand-conversation-states)

### Wrap-up conversations

This metric is a count of conversations currently in a wrap-up state. A conversation is in wrap-up state when the agent ends the conversation, or when customer leaves the conversation by ending the conversation on their side or gets disconnected. More information: [Understand conversation states](oc-conversation-state.md#understand-conversation-states)

### Total conversations

Total count of customer conversation. More information: [Understand conversation states](oc-conversation-state.md#understand-conversation-states)

### Incoming conversation

Total count of conversations requests that were received by the contact center and initiated by customers across all channels. More information: [Understand conversation states](oc-conversation-state.md#understand-conversation-states)

### Sentiment

Represents the current sentiment of customer. This is powered by Omnichannel for Customer Service sentiment analysis.  

### Average session handle time

This metric is like conversation handle time, but granular and is calculated for every agent working on the conversation. This metric is relevant for conversations that have been handled by multiple agents. If multiple agents were assigned to work on a customer request, due to various reasons, such as transfers and escalations, this metric provides the average time spent by each of those agents working with the customer. Conversation handle time is the aggregation of session handle time of all the associated sessions.  

**Related metric**
- Session handle time: This metric represents the time spent by agents assisting customers on assigned customer requests. 

### Customer sentiment

This metric represents the current sentiment of the customer. This is powered by Omnichannel for Customer Service sentiment analysis.

### Is handled by external participant (session)

A customer request could be handled by more than one agent, including a combination of internal contact center agents and external agents. This metric can be used to identify the portion of a customer request that was handled by agents outside of Dynamics 365 Customer Service. External agents could be engaged by your contact center through transfers to an external phone number, such as Microsoft Teams voice call.
This metric will only show sessions that were assigned to and handled by external agents. For metrics around consultations with external agents, go to [Is handled by external participant (session)](#is-handled-by-external-participant-session)

### Session transfer rate
 
This metric measures the rate at which agents transfer work assigned to them, or supervisors transfer work in the queue they monitor from one agent to another, or to another queue. It is calculated by dividing the total number of sessions transferred, by the total number of sessions handled.

**Related metrics**

- Is Transferred Out: Shows whether the conversation and the underlying session were transferred out of a queue.

- Transferred sessions: Shows the total number of sessions that were transferred.

### Session rejection rate

This metric measures the rate at which agents reject work assigned to them. It is calculated by dividing the total number of sessions rejected by agents, by the total number of sessions assigned to them.  

**Related metrics**

- Rejected sessions: This metric refers to the total number of times agents rejected work assigned to them.

- Session time to reject: This metric refers to the average time taken by agents to reject work assigned to them. It is the time difference between an agent being assigned a customer request and the agent rejecting the request.  

### Session time to accept  

This metric refers to the average time taken by agents to accept work assigned to them. It is the time difference between an agent being assigned a customer request and the agent accepting the request.  

**Related metrics**

- Engaged sessions: This metric refers to the total number of sessions accepted by agents.

### Session timeout rate

This metric measures the session timeout rate because of agent's inactivity. The agent didn’t accept or reject the customer requests. It is calculated by dividing the total number of requests where the agent didn’t provide any response, by the total number of sessions assigned to them.  

**Related metrics**

- Timeout sessions: This metric refers to the total number of times agents didn’t respond to the work assigned to them.  

### Session wait time

It is a measure of the time a customer spends waiting in a specific queue before an agent accepts the customer's request. Time is represented in seconds. If the customer abandons the request or if the conversation is transferred to another queue, the calculation is based on the amount of time between the customer request arriving in queue and the request closing time.
 
### Active sessions

Count of sessions that are currently in progress. A session is considered active, if it is yet to have an agent assigned, is waiting for agent acceptance, or have agents actively assisting customers.  

### Closed sessions

Count of sessions that are currently closed.  

### Total sessions

The total count of all sessions that were presented to or handled by agents.

### Is handled by external participant

A customer request could be handled by more than one agent, including a combination of internal and external agents. For example, external agents could be engaged by your contact center through transfers to an external phone number or through Microsoft Teams voice call. This metric is used to identify the portion of a customer requests that were handled by agents outside Dynamics 365 Customer Service.

**Related metrics** 

- External participant channel: This metric helps identify the channels through which external agents were engaged. For example, an external agent can help customer requests by calling them directly on their phone number or via Microsoft Teams Public Switched Telephone Network (PSTN) call.

- External participant channel type: This metric represents the details of the external agent like phone number.

### Session participant count

This is a measure of the total number of agents involved in assisting a customer. This includes the primary agent assigned to working on the session, as well as subject-matter experts who may have been consulted. This metric can be analyzed by the dimension SessionParticipationType to get further statistics.

### Average first response time

While speed to answer provides insights into how quickly an agent was connected with a customer, first response time provides insights into how quickly the agent responded to the customer. First response time is calculated as the time spent by a customer waiting to get the first response from a human agent, adjusted according to operating hours. The calculation is based on the time between a customer initiating a conversation (or escalation time in case of a bot escalated conversation) and the agent accepting and responding to a customer. In case of messaging conversations, this time represents how soon the agent sent the first response to customer.

Average first response time is calculated as the total of the first response time across all engaged conversations, divided by the count of engaged conversations. The time can be viewed in seconds and in hh:mm:ss format.

### Average agent response time

Agent response time is calculated as the time taken by a customer on an average, waiting to get a response from the human agent for their message, adjusted according to operating hours. Average agent response is calculated as the total response time, divided by the number of exchanges between customers and agents across all engaged conversations. The time can be viewed in seconds and in hh:mm:ss format. Higher response time indicates that customers are spending a lot of time waiting between messages for agent to provide updates and response. Higher response time also negatively impacts the customer experience.  

### First response service level

Percentage of customer conversations with an agent response time of less than 60 sec.

### Agent response service level

Percentage of customer messages with an agent response time of less than 60 sec.

### Assigned capacity profile count

Count of capacity profiles assigned to agents.

### Total available work item capacity

Maximum count of additional work items that can be assigned.

### Total work item capacity in use

Work items currently being handled.

### Total work item capacity

Maximum work items allowed based on the configuration of capacity profile.

### Logged in agents

Count of Omnichannel agents currently logged in.

### Total agents

Total count of Omnichannel agents.

### Total available capacity units

Capacity units available to handle conversations.

### Total capacity units
 
Maximum capacity units assigned. Applies to organizations using capacity units.

### Total occupied capacity units

Capacity units currently occupied.

### Status duration

Amount of time an agent spent in a presence status.

## See Also

[Omnichannel for Customer Service dashboards](omnichannel-analytics-insights.md#omnichannel-for-customer-service-dashboards)

[Overview of Omnichannel real-time analytics dashboards](intro-realtime-analytics-dashboard.md)