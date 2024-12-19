---
title: Omnichannel historical analytics metrics
description: 
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 12/19/2024
ms.custom: bap-template
---


# Omnichannel historical analytics metrics

This article describes the metrics used in omnichannel historical analytics reports.

## Conversations

- Total conversations: The number of conversations initiated by customers. Also includes conversations initiated by the customer and connected to a human agent directly, resolved by the Copilot Studio bot, or escalated by a bot to the human agent.
- Incoming conversations: The total number of conversations that are initiated by the customer and are presented to a human agent. Summary report includes conversations escalated by the Copilot Studio bots. Conversation report excludes bot conversations.
- Engaged conversations: Offered conversations that are engaged by an agent. Customer-to-agent communication begins at this point. Conversation report includes all conversations.
- Incoming conversations by channel: The number of conversations initiated by the customer and presented to an agent, sorted by channel.
- Avg. conversation handle time (min): The average total conversation active time across engaged conversations.
- Conversations with secondary channel: The breakdown of conversations across secondary channels.
- Avg. customer effort time (min): The average time from the start of a conversation to the start of the conversation wrap-up time.
- Avg. session per conversation: The average number of sessions in each conversation.
- Switches per conversation: The average exchanges between an agent and a customer in a conversation; the number of times the conversation switched from one person to another.
- Routed conversations: In unified routing, indicates the total number of incoming conversations that have been routed successfully. **Note:** A conversation routed to a fallback queue is not considered in the calculation of the metric. 

## Topics

- Top 10 volume topics: The top 10 AI-discovered topics from conversation data sorted by conversation volume.
- Emerging conversation volume by topic: The top emerging AI-discovered topics, from conversation data that featured the greatest increase in volume over the duration being evaluated.

## Bots

- Bot deflection rate:The percentage of conversations engaged by bots that were resolved.
- Bot escalation rate: The percentage of conversations engaged by bots that were escalated to a human agent.
- Total bot conversations: The number of conversations initiated by the customer and engaged by a bot.
- Bot escalation rate: The percentage of bot sessions that were escalated by a bot to a human agent or to an external phone number.
- Total bot sessions: The total number of bot sessions within the specified time period. A bot session is any conversation where a bot is invoked, whether at the beginning, during, or end. A single bot conversation can include multiple sessions, based on the number of topics the bot traverses while interacting with the customer. For example, if a customer uses a returns bot for both an exchange and a return, the system counts this as two bot sessions, even though it is one conversation.
 - Bot engagement rate: The percentage of total bot sessions that are engaged sessions. An engaged bot session is a session in which a user-created topic (as opposed to a system topic) is triggered, or the session ends in an escalation. Engaged bot sessions can have one of three outcomes: they're either resolved, escalated, or abandoned.
 - Bot resolution rate: The percentage of sessions that were closed by interacting with a bot out of all the sessions engaged by a bot.
 - Bot abandon rate: The percentage of engaged bot sessions that are abandoned. An abandoned session is an engaged session that isn't resolved or escalated after one hour from the beginning of the session.
 - Bot CSAT: The graphical view of the average of customer satisfaction (CSAT) scores for bot sessions in which customers respond to an end-of-session request to take the survey.

## Rate

- Abandon rate: The percentage of incoming conversations that are in a human agent's queue but aren't engaged by agents.
- Agent engagement rate over time: Represents daily incoming conversations, conversations engaged by an agent, and abandoned conversations over time.
- Transfer rate: The percentage of conversations that are transferred to another agent or queue.
- Session rejected/timed out rate: The number of sessions presented to an agent that weren't accepted.

## Time to answer

- Average time to answer: The average time customers waited in the queue before being connected to an agent.
- Avg. speed to answer (seconds): The average time customers waited in the queue before connecting to an agent. (Time taken for acceptance). Conversations engaged and conversations that are in the closed state are considered.
- Avg. wait time (sec): The average time customers waited before connecting to agents. This average is similar to "speed to answer" but includes wait time from each session within a conversation.

### Avg. CSAT
- Avg. CSAT: The average of the customer satisfaction ratings provided by customers. Only available if Dynamics 365 Customer Voice is configured as a post-conversation survey tool.

### Sentiment

- Avg. conversation sentiment: The average sentiment score based on the customer's conversation experience.  Learn more about how the sentiment data is derived in [Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md).
- Avg. conversation sentiment: The average of predicted customer sentiment in a given timeframe for a set queue or agent, which indicates the degree of positive sentiment that customers expressed at the end of their interaction.
- Avg. survey sentiment: The average of customer sentiment based on verbatim provided in survey responses. Available only if Dynamics 365 Customer Voice is configured as a post-conversation survey tool.
- Avg. session sentiment: The average predicted customer sentiment for a given session.
- Sentiment zones: The breakdown of customer sentiment across sessions by level.

## Messages

- Avg. incoming messages: The average of the total number of messages sent by customers.
- Avg. outgoing messages: Average of the total number of messages sent as a response from an agent. This average doesn’t include any consult or monitoring messages a supervisor or team lead sent to an agent.
- Incoming messages: The average of the total number of messages sent by customers.
- Outgoing messages: The average of the total number of messages sent as a response from an agent. This average doesn’t include any consult or monitoring messages that a supervisor or team lead sent to an agent.

## Sessions

- Incoming sessions: The total number of sessions initiated by customers.
- Engaged sessions: The number of sessions presented to an agent that were accepted.
- Avg. session handle time: The total session active time across engaged sessions.
- Avg. session sentiment: The average predicted customer sentiment for a given session.
- Avg. session active time (min): The average total session active time across engaged conversations.
- Avg. session inactive time (min): The average total session inactive time across engaged sessions.
- Consult sessions: Number of sessions where the agent has participated in consult mode.
- Monitor sessions: Number of sessions where the agent has participated in monitor mode.
- Rejected or timed-out sessions rate: The number of sessions presented to an agent and not accepted. 

## Related information

[Omnichannel for Customer Service dashboards](omnichannel-analytics-insights.md#omnichannel-for-customer-service-dashboards)
