---
title: Conversation
description: Learn about FactConversation metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/17/2023
ms.custom: bap-template
---

# Conversation

A conversation represents an entire end-to-end interaction with a customer. A conversation is created when a customer raises a request through the various channels like voice, messaging, or chat. When the system identifies an agent to work on a conversation, a session is created. A conversation can end in a single session or extend to multiple sessions.

In the following workflow, which represents a single conversation, you'll see that multiple sessions are created. The first session is created when a conversation is created and assigned to a bot. The second session is created when the bot escalates the conversation to a human agent. This automatically closes the first session. In the second session, the best agent to work on the customer request is identified and assigned. If the agent rejects the request, a new session is created and the process of identifying another agent begins.

## Abandoned conversations

A conversation can be abandoned for multiple reasons, such as customer getting disconnected or cancelling the call due to a long waiting period, force closure of requests by supervisors, automatic system actions configured to respond to handle overflow. Abandoned conversations lead to customer dissatisfaction because of lack of assistance from the contact center. A higher abandoned rate may need further investigation into operational metrics such as agent availability and queue distribution.

If a bot or interactive voice response (IVR) handles the customer before escalating the request to human agent, it is calculated as the count of conversations that were abandoned while waiting for a human agent after escalation from bot. If the conversation is abandoned before a bot can be assigned, the conversation is considered abandoned. If customers reach human agent queue directly, it is also calculated as the count of incoming conversations that were abandoned.

The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.

**Related metric**

- Abandoned rate: Abandoned rate refers to the percentage of incoming conversation requests that ended before customers were connected to a human agent. This metric is calculated as the count of abandoned conversations divided by the count of bot-escalated conversations.

## Active conversations awaiting agent acceptance

It is the count of conversation requests from customers that have agents assigned, but are currently waiting for an agent to accept the request and join the conversation. These conversations revert to an Open conversation, if the agent chooses to reject the request or if they respond to the request.

## Active conversations with agent acceptance

It is the count of conversations that have an agent assigned and are actively in contact with the customer. Supervisors can monitor these conversations and track sentiment to ensure customer satisfaction and intervene, if needed.

## Conversation first wait time

It is a measure of the time taken before an agent responds to a customer's request. It represents the time, in seconds, spent by a customer waiting to get the first response from a human agent. Agent availability, high volume of requests, increased handle time could be some of the reasons that can influence customer waiting time. Lower waiting time indicates that customers get issue resolution faster and have a better support experience.  

If bot or IVR handles the customer before escalating the issue to human agent, the calculation is based on the time between a bot escalating an incoming conversation to a human agent and an agent accepting the conversation. If the customer ends up abandoning the conversation, the calculation is based on the time between a bot passing the conversation to the human representative and the customer disconnecting the conversation.

If the customer reaches human agent queue directly, the calculation is based on the amount of time between  a customer creating the request and an agent accepting the conversation. If the customer ends up abandoning the conversation, the calculation is based on the time between the customer creating the request to the human agent and the customer disconnecting the conversation.

This metric is available in two formats, seconds and in hh:mm:ss.

**Related metric**

- Avg. conversation first wait time: This metric is calculated by taking the total waiting time for customers waiting in queue, and then dividing it by the total number of customers who were served.
- Longest wait time: This metric is measured as the longest first waiting time amongst incoming conversations that are yet to be accepted by an agent.
- Conversations in queue: This metric is measured as the count of customer requests that are currently awaiting agent assistance or conversations that have been assigned an agent, but are waiting for agent acceptance.
- Avg. wait time
- Wait time  
 
For metrics around how much time customers had to wait in individual queues, if they get transferred from one agent to another, refer to [Session wait time (sec)](oc-metrics-facts-session.md#session-wait-time-sec).

## Average speed to answer

It is a measure of how quickly the customer service team responds to a customer's request. It is calculated by taking the total waiting time for customers waiting in the queue (after being escalated from the bot to get support from a human agent) and then dividing it by the total number of customers who are were served. Average speed to answer reflects the efficiency and availability of the agents. A low average speed to answer indicates that customers can get their issues resolved faster and have a better experience with the service.  

If bot or IVR handles the customer before escalating it to a human agent, the speed to answer is calculated by the time between the bot escalating the incoming conversation to a human agent and the conversation getting accepted by a human agent.

If the customer reaches the human agent queue directly, the speed to answer is calculated by the time between creating a customer request and the request getting accepted by a human agent.
 
This metric is available in two formats - seconds and in hh:mm:ss.

**Related metrics**

- Service level (10 seconds): This metric is measured as the percentage of customer conversation, where the speed to answer is less than 10 seconds.
- Service level (20 seconds): This metric is measured as the percentage of customer conversation, where the speed to answer is less than 20 seconds.
- Service level (30 seconds): This metric is measured as the percentage of customer conversation, where the speed to answer is less than 30 seconds.
- Service level (40 seconds): This metric is measured as the percentage of customer conversation, where the speed to answer is less than 40 seconds.
- Service level (60 seconds): This metric is measured as the percentage of customer conversation, where the speed to answer is less than 60 seconds.
- Service level (120 seconds): This metric is measured as the percentage of customer conversation, where the speed to answer is less than 120 seconds.
- Speed to answer: Time taken to accept an customer request

For metrics around how quickly an agent accepts a request, refer to .

## Conversation handle time  
 
Conversation handle time is time spent by human agents to actively assist and resolve the customer issue. If multiple agents handle the conversation, then the time spent by all the agents is aggregated. Time spent by agents to wrap up the conversation after the customer disconnects, update notes, or contact details is also included as the conversation handle time. Time spent by subject-matter experts or other agents consulting with agents assigned to work on customer conversation isn't included in this metric.  
 
An agent is considered actively working on the conversation, if they have the conversation open and in focus within the Customer Service Workspace application.  

High average handle time could indicate that agents are taking too long to resolve customer issues, and that agents might need more training or support to help them work better. High average handle time also indicates customer dissatisfaction, as it may suggest that customers aren't receiving the level of service or support they need to resolve their issues.

To understand the time spent by individual agents, where conversations were handled by multiple agents, go to [Avg. session handle time](oc-metrics-facts-session.md#avg-session-handle-time)  

This metric can be viewed in the seconds and in hh:mm:ss formats.  
 
The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice. 

**Related metric** 

- Average handle time: This metric is calculated by taking the total handle time of all the customer requests, and then dividing it by the total number of customers who were served.

## Avg. conversation hold time

This metric represents the average time, in seconds, when the customer was put on hold by human agents handling the conversation. If the conversation was handled by multiple agents, conversation hold time is calculated as sum of hold time across all agents handling this conversation. This metric is calculated by taking the total hold time of all customer requests, and then dividing it by the total number of customers who are were served.

There are several reasons why an agent might put a customer on hold. For example, an agent might put a customer on hold to gather additional information or research an issue, perform tasks that don’t require interaction like entering data into a system, or perform an offline task. A higher hold time may cause customer frustrations and may lead to poor customer experience.
 
## Avg. conversation talk time

This metric represents the average time, in seconds, spent by a human agent actively conversing with customers on the phone for voice conversation. If a conversation was handled by multiple agents, conversation talk time is aggregated across all agents. This metric is calculated by taking the total hold time of all customer request, and then dividing it by the total number of customers who are were served.

**Related metric** 

- Conversation talk time: This metric is calculated by taking the total talk time across all customer requests.  

## Avg. conversation time

This metric represents the average time, in seconds, that a customer spent with the human agent, while seeking assistance from the contact center. It includes the time spent waiting for agents to work with them.  

**Related metric**

- Conversation time: This metric is calculated as the time between the customer initiating the request and the agent wrapping up the conversation. Time spent by agents with bot is also included.

## Avg. conversation wrap up time

This metric represents the average time agents spend after the customer leaves to complete any necessary tasks, such as documenting the conversations, updating notes, or updating the customer’s information. It's calculated as the beginning of the wrap up to the closing of the conversation by the agent. If multiple agents handled a conversation, it applies only to the time spent by the agent who is last to work with the customer.

This metric can be viewed in two formats, seconds and in hh:mm:ss.

## Waiting conversations
 
This metric is a count of conversations currently in a waiting state. A conversation gets transitioned to waiting when an agent closes the session without ending the conversation (that is, without selecting the End button on the communication panel), or when the customer closes the browser window without closing the chat widget. In case of asynchronous messaging channels, it refers to the conversations that are waiting for an agent to respond. More information: [Understand conversation states](oc-conversation-state.md#understand-conversation-states)

## Wrap-up conversations

This metric is a count of conversations currently in a wrap-up state. A conversation is in wrap-up state when the agent ends the conversation, or when customer leaves the conversation by ending the conversation on their side or gets disconnected. More information: [Understand conversation states](oc-conversation-state.md#understand-conversation-states)

## Total conversations

Total count of customer conversation. More information: [Understand conversation states](oc-conversation-state.md#understand-conversation-states)

## Incoming conversation

Total count of conversations requests that were received by the contact center and initiated by customers across all channels. More information: [Understand conversation states](oc-conversation-state.md#understand-conversation-states)

## Sentiment

Represents the current sentiment of customer. This is powered by Omnichannel for Customer Service sentiment analysis.  

## Subject

Represents the title of the conversation.

## Conversation id

Represents the reference id of the conversation. This metric can be used for associating conversations with the sessions handled.  
 
## Created on
 
Represents the time when the customer conversation request was created. In case of incoming conversation, it is calculated as the time when the customer stared the request. In case of outgoing conversation, it is calculated as the time when the agent initiated the call.

## Next steps

[Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model)  
[Customize visual display](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service)
