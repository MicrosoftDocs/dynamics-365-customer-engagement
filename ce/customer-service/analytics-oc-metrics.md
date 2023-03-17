---
title: Omnichannel Metrics
description: Learn about the out-of-box Omnichannel historical and real-time analytics metrics and customize them to suit your needs.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 03/17/2023
ms.custom: bap-template
---

# Omnichannel Metrics

The out-of-box Omnichannel historical and real-time analytics reports provides you with various metrics that you can use to view and analyze different activities within your contact center. Additionally, the ability to customize these metrics come as an added advantage that allows you to customize your reports to view only specific data that is required by your administrators or supervisors.

This article describes the various other metrics in the data model that aren't directly exposed in the out-of-box reports. Learn about the facts and dimensions of the metrics and understand how you can use the metrics to suit your needs. For more information about how you can customize the visual display of your reports, go to [Customize visual display](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service).

## Structure out-of-the-box analytics metrics
Need info

### Facts
Need info

### Dimensions
A database dimension is a collection of related attributes that can provide information about fact data in one or more cubes. These attributes can be organized into user-defined hierarchies for easy navigation and analysis. 

## Dimensions
Here are the various dimensions that are provided out-of-the-box for Omnichannel historical and real-time reports.

- [CapacityProfileName](#capacityprofilename)
- [Has blocking assignment turned on](#has-blocking-assignment-turned-on)
- [ConversationDirection](#conversationdirection)
- [ConversationStatus](#conversationstatus)
- [Queue id](#queue-id)
- [Queue name](#queue-name)
- [Agent presence](#agent-presence)
- [Date hour](#date-hour)
- [Time range](#time-range)
- [Time zone](#time-zone)
- [Agent id](#agent-id)
- [Agent name](#agent-name)
- [Domain name](#domain-name)
- [Agent participation mode](#agent-participation-mode)
- [Workstream id](#workstream-id)
- [WorkStream name](#workstream-name)
- [Channel id](#channel-id)
- [Channel name](#channel-name)


### CapacityProfileName
Name of capacity profile.

### Has blocking assignment turned on
Indicates whether the capacity profile has the assignment blocking toggle set to on. If the profile's blocking settings are turned on, the value will be "TRUE". If the blocking settings are turned off, the value will be "FALSE".
### ConversationDirection

This applies only to voice conversations and indicates whether the conversation was started by the customer or a contact center agent. 
If the conversation was initiated by an agent in the contact center, it is considered "outbound". If the conversation was received by the contact center, it is considered "inbound".

### ConversationStatus
Represents current state of a customer interaction. Here is the glossary of values and their meaning 
- Open - Conversation is currently awaiting an agent assignment
- Active - Conversation has either an agent assigned and is pending acceptance or has an agent in contact with the customer 
- Waiting -Conversation is currently either waiting for a customer response or an agent response  Applies for aysnchronous conversation modes like SMS etc.
- Wrap-up - Agent is currently performing post contact activities like notes, updates to case etc. after the contact with customer has ended 
- Closed - Conversation is currently closed

### Queue id
Reference id of the queue.

### Queue name
Name of the queue.

### Agent presence	
Presence status options available for agents to set themselves in. Out-of-box options are Online, Away, Busy, Offline, Do Not Disturb. Options avaiable to you will depend on your organization's configuration and will include any additional custom prescence status configured for your organization.

### Date hour
Represents hour of day in 24 hour format.

### Time range
Time based filter options available in real-time dashboards  
- Today - Conversations that started since 12 AM of the time zone selected and in any state
- Last 24 hours - Conversations that started within the last 24 hours and in any state.
- Include open conversations beyond 24 hours - Conversations that started within the last 24 hours and in any state and Conversations that started earlier than 24 hours but not closed.

### Time zone
Represents the time zone used to calculate and display metrics across the dashboard. Options avaialble are standard timezones. List can be found here.

### Agent id		
Reference id of the omnichannel agent.

### Agent name
Name of the omnichannel agent.

### Domain name
Name of the Active Directory domain.

### Agent participation mode
- Primary - Agent participation mode is primary. 
- Consult - Agent participation mode is consult. 
- Monitor - Supervisor participation mode is monitor. Applies only to users with Omnichannel supervisor role.

### Workstream id
Reference id of the workstream.

### WorkStream name
Name of the workstream.

### Channel id
Reference id of the channel.

### Channel name
Name of the channel.

## Facts
### Conversation
Conversation metrics are described here:

- [Abandoned conversations](#abandoned-conversations)
- [Active conversations](#active-conversations)
- [Avg. handle time](#avg-handle-time)
- [Avg. conversation hold time](#avg-conversation-hold-time)
- [Avg. conversation talk time](#avg-conversation-talk-time)
- [Avg. conversation wait time](#avg-conversation-wait-time)
- [Avg. conversation wrap up time](#avg-conversation-wrap-up-time)
- [Closed conversations](#closed-conversations)
- [Conversation handle time](#conversation-handle-time)
- [Conversation id](#conversation-id)
- [Conversation abandoned rate](#conversation-abandoned-rate)
- [Conversation speed to answer](#conversation-speed-to-answer)
- [Conversation talk time](#conversation-talk-time)
- [Conversation wrap up time](#avg-conversation-wrap-up-time)
- [Conversation wrap up time (in seconds)](#conversation-wrap-up-time-in-seconds)
- [Conversation sentiment](#conversation-wrap-up-time-in-seconds)
- [Conversation has transfer](#conversation-has-transfer)
- [Incoming conversations](#incoming-conversations)
- [Is abandoned?](#is-abandoned)
- [Is engaged?](#is-engaged)
- [Is conversation ongoing](#is-conversation-ongoing)
- [Current longest wait time](#current-longest-wait-time)
- [Ongoing conversations](#ongoing-conversations)
- [Open conversations](#open-conversations)
- [Service level](#service-level)
- [Conversation title](#conversation-talk-time)
- [Total conversations](#total-conversations)
- [Conversation transfer count](#conversation-transfer-count)
- [Conversation wrap up initiated on](#conversation-wrap-up-initiated-on)

#### Abandoned conversations

Count of conversations that were closed before a contact center agent accepted the conversation. 
A conversation can be abandoned for multiple reasons - like customer termination or getting disconnected while waiting for the first agent from contact center to accept the conversation, force closure by supervisors, automatic system closure due to configurations like operating hours overflow etc.  The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.
### Active conversations

Count of conversations currently in an active state. Link to conversation status metric in dimension.
This includes conversations that have agents in contact with customers and conversations with customers awaiting agent acceptance. Conversations that have customers in conversation with a bot are not included. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Avg. handle time
Calculated as sum of conversation handle time across all engaged converations divided by count of engaged conversations. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Avg. conversation hold time
Calculated as sum of hold time across all engaged conversations divided by the total number of engaged voice conversations. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channel through which the conversation came in Voice.
#### Avg. conversation talk time
Calculated a sum of talk time across all engaged voice conversations divided by total number of engaged voice conversations. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channel through which the conversation came in Voice.

#### Avg. conversation wait time
Calculated as sum of wait time across all incoming conversations divided by total number of incoming conversations. Can be viewed in two formats - seconds and in hh:mm:ss. Channels through which the conversation came in are Messaging and Voice.

#### Avg. conversation wrap up time
Calculated as sum of wrap-up time across all egnaged conversations divided by the total number of egnaged conversations. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Closed conversations
Count of conversations currently in closed status. A conversation can be closed after agents completes a wrap-up of the conversation or when it gets abandoned. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Conversation handle time
Time spent by a human agents from contact center while actively working on the conversation. If multiple agents handled the conversation, then time spent by all the agents is aggregated. Wrap-up time of the conversation is also included. An agent is considered actively working on the conversation if they have the conversation open and in focus within the Customer Service Workspace application. 

Calculated as sum of handle time across all agent sessions related to the conversation
Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
#### Conversation id
Reference id of the conversation. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Conversation abandoned rate
Percentage of incoming interactions, including calls or chats, that are abandoned. Calculated as count of abadoned conversations divided by count of incoming conversation. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.

#### Conversation speed to answer
Represents the time taken for the first agent from the contact center to accept the customer conversation from the time the conversation was presented to the contact center. Calculated as time difference between the conversation creation time (or bot escalated time) and first agent acceptance. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.

#### Conversation talk time
Time spent by human agent handling the conversation on phone with customer. If a conversation was handled by multiple agents, talk time is aggregated across all agents. Calculated as sum of talk time across all agent sessions related to the conversation. The conversation direction is Incoming and Outgoing. Channel through which the conversation came in is Voice.

#### Conversation wrap up time
Represents amount of time an agent spends after the conversation has ended to complete any necessary tasks, such as documenting the conversations, updating notes or updating the customer’s information etc. If multiple agents handled a conversation, it applies only to the time spent by the agent who is last to work on the conversation. 
Calculated as the time difference between the time wrap-up was initiated and the time the conversation was closed by the agent. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Conversation wrap up time (in seconds)
Represents amount of time an agent spends after the conversation has ended to  complete any necessary tasks, such as documenting the conversations, updating notes or updating the customer’s information etc. If multiple agents handled a conversation, it applies only to the time spent by the agent who is last to work on the conversation.
Calculated as the time difference between the time wrap-up was initiated and the time the conversation was closed by the agent. Can be viewed in two formats - seconds and in hh:mm:ss.

#### Conversation sentiment
Current customer sentiment of the conversation. This is powered by Omnichannel for Customer Service sentiment analysis. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
#### Conversation has transfer
Indicates whether the conversation was transferred from one human agent to another. If the conversation was transferred at least once, this metric will be True. Transfers from and to bots are not considered.
#### Incoming conversations
Count of conversations, including call or chat, that were initiated by the customer and were directed to the contact center. This excludes conversations that were handled by bots. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.

#### Is abandoned?
Represents if the conversation was abandoned

#### Is engaged?
The presence of a human agent as the primary participant in a conversation is indicated by this metric. In turn this indicates if atleast human agent from the contact center accepted this conversation. 
Calculated as - If the conversation had atleast one session with a human agent participate as the primary participant, the value of this metric is true. If not, the value is false. This metric doesn't apply to bot deflected conversations.

#### Is conversation ongoing
Represents if the conversation is ongoing.

#### Current longest wait time
Represents the longest wait time amongst incoming conversation currently in open state that hasn't yet been accepted by a contact center agent. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.

#### Ongoing conversations
Count of conversations that are currently not in a closed status. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Open conversations
Count of conversations that are currently in open state, awaiting agent assignment. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.

#### Service level
Percentage of engaged conversations that were accepted by a contact center agent in less than 60 seconds. Additional SLAs of 10 seconds, 20 seconds, 30 seconds, 50 seconds, 120 seconds 
Applies to engaged conversations only. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.

#### Conversation title
Title of the conversation. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Total conversations
Total number of conversations between customers and agents initiated in the selected time period. This includes conversations across all messaging and voice channels. This includes conversations initiated by customers and agents. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Conversation transfer count
Refers to the number of times a customer conversation was transferred to another agent or queue. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.

#### Conversation wrap up initiated on
Date and time when the conversation moved to wrap-up status. An engaged conversation moves to wrap-up status if the agent end the conversation, customer ends the conversation or gets disconnected.

Other metrics to be added. (WIP)

## Use out-of-the-box metrics

## Infographic

## See Also

[Omnichannel for Customer Service dashboards](omnichannel-analytics-insights.md#omnichannel-for-customer-service-dashboards)

[Overview of Omnichannel real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards-preview)
