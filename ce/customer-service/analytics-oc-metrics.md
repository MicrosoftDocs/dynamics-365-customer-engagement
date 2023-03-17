---
title: Concept topic template #Required; page title displayed in search results. Don't enclose in quotation marks.
description: Concept description #Required; article description that's displayed in search results. Don't enclose in quotation marks. Do end with a period.
author: rhanajoy #Required; your GitHub user alias, with correct capitalization.
ms.author: rhcassid #Required; your Microsoft alias; optional team alias.
ms.reviewer: kfend #Required; Microsoft alias of content publishing team member.
ms.topic: conceptual #Required; don't change.
ms.date: 03/17/2023
ms.custom: bap-template #Required; don't change.
---

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->

<!--This template provides the basic structure of a concept article. See [Write a concept article](write-a-concept-article.md) in the contributor guide. To provide feedback on this template contact [bace feedback team](mailto:templateswg@microsoft.com).-->

<!--H1 - Required. This should match the title you entered in the metadata. Set expectations for what the content covers, so customers know the content meets their needs. Should NOT begin with a verb.-->
# Heading 

<!--Introductory paragraph - Required. Lead with a light intro that describes what the article covers. Answer the fundamental "What is X and how will learning this help me accomplish Y?" question. A good lead is a sentence in the form, "X is a (type of) Y that does Z." Keep this paragraph short.-->
<!--add your intro paragraph here-->

<!--H2s - Required. Give each H2 a heading that sets expectations for the content that follows. Follow H2 headings with a sentence about how the section contributes to the whole.-->
## Conversation
Conversation metrics are described here:

[Abandoned conversations](#abandoned-conversations)

[Active conversations](#active-conversations)

[Avg. handle time](#avg-handle-time)

[Avg. conversation hold time](#avg-conversation-hold-time)

[Avg. conversation talk time](#avg-conversation-talk-time)

[Avg. conversation wait time](#avg-conversation-wait-time)

[Avg. conversation wrap up time](#avg-conversation-wrap-up-time)

[Closed conversations](#closed-conversations)

[Conversation handle time](#conversation-handle-time)

[Conversation id](#conversation-id)

[Conversation abandoned rate](#conversation-abandoned-rate)

[Conversation speed to answer](#conversation-speed-to-answer)

[Conversation talk time](#conversation-talk-time)

[Conversation wrap up time](#avg-conversation-wrap-up-time)

[Conversation wrap up time (in seconds)](#conversation-wrap-up-time-in-seconds)

[Conversation sentiment](#conversation-wrap-up-time-in-seconds)

[Conversation has transfer](#conversation-has-transfer)

[Incoming conversations](#incoming-conversations)

[Is abandoned?](#is-abandoned)

[Is engaged?](#is-engaged)

[Is conversation ongoing](#is-conversation-ongoing)

[Current longest wait time](#current-longest-wait-time)

[Ongoing conversations](#ongoing-conversations)

[Open conversations](#open-conversations)

[Service level](#service-level)

[Conversation title](#conversation-talk-time)

[Total conversations](#total-conversations)

[Conversation transfer count](#conversation-transfer-count)

[Conversation wrap up initiated on](#conversation-wrap-up-initiated-on)

### Abandoned conversations

Count of conversations that were closed before a contact center agent accepted the conversation. 
A conversation can be abandoned for multiple reasons - like customer termination or getting disconnected while waiting for the first agent from contact center to accept the conversation, force closure by supervisors, automatic system closure due to configurations like operating hours overflow etc.  The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.
### Active conversations

Count of conversations currently in an active state. <Link to conversation status metric in dimension>
This includes conversations that have agents in contact with customers and conversations with customers awaiting agent acceptance. Conversations that have customers in conversation with a bot are not included. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Avg. handle time
Calculated as sum of conversation handle time across all engaged converations divided by count of engaged conversations. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Avg. conversation hold time
Calculated as sum of hold time across all engaged conversations divided by the total number of engaged voice conversations. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channel through which the conversation came in Voice.
### Avg. conversation talk time
Calculated a sum of talk time across all engaged voice conversations divided by total number of engaged voice conversations. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channel through which the conversation came in Voice.

### Avg. conversation wait time
Calculated as sum of wait time across all incoming conversations divided by total number of incoming conversations. Can be viewed in two formats - seconds and in hh:mm:ss. Channels through which the conversation came in are Messaging and Voice.

### Avg. conversation wrap up time
Calculated as sum of wrap-up time across all egnaged conversations divided by the total number of egnaged conversations. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Closed conversations
Count of conversations currently in closed status. A conversation can be closed after agents completes a wrap-up of the conversation or when it gets abandoned. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Conversation handle time
Time spent by a human agents from contact center while actively working on the conversation. If multiple agents handled the conversation, then time spent by all the agents is aggregated. Wrap-up time of the conversation is also included. An agent is considered actively working on the conversation if they have the conversation open and in focus within the Customer Service Workspace application. 

Calculated as sum of handle time across all agent sessions related to the conversation
Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Conversation id
Reference id of the conversation. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Conversation abandoned rate
Percentage of incoming interactions, including calls or chats, that are abandoned. Calculated as count of abadoned conversations divided by count of incoming conversation. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.
### Conversation speed to answer
Represents the time taken for the first agent from the contact center to accept the customer conversation from the time the conversation was presented to the contact center. Calculated as time difference between the conversation creation time (or bot escalated time) and first agent acceptance. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.
### Conversation talk time
Time spent by human agent handling the conversation on phone with customer. If a conversation was handled by multiple agents, talk time is aggregated across all agents. Calculated as sum of talk time across all agent sessions related to the conversation. The conversation direction is Incoming and Outgoing. Channel through which the conversation came in is Voice.
### Conversation wrap up time
Represents amount of time an agent spends after the conversation has ended to complete any necessary tasks, such as documenting the conversations, updating notes or updating the customer’s information etc. If multiple agents handled a conversation, it applies only to the time spent by the agent who is last to work on the conversation. 
Calculated as the time difference between the time wrap-up was initiated and the time the conversation was closed by the agent. Can be viewed in two formats - seconds and in hh:mm:ss. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Conversation wrap up time (in seconds)
Represents amount of time an agent spends after the conversation has ended to  complete any necessary tasks, such as documenting the conversations, updating notes or updating the customer’s information etc. If multiple agents handled a conversation, it applies only to the time spent by the agent who is last to work on the conversation.
Calculated as the time difference between the time wrap-up was initiated and the time the conversation was closed by the agent. Can be viewed in two formats - seconds and in hh:mm:ss.
### Conversation sentiment
Current customer sentiment of the conversation. This is powered by Omnichannel for Customer Service sentiment analysis. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Conversation has transfer
Indicates whether the conversation was transferred from one human agent to another. If the conversation was transferred at least once, this metric will be True. Transfers from and to bots are not considered.
### Incoming conversations
Count of conversations, including call or chat, that were initiated by the customer and were directed to the contact center. This excludes conversations that were handled by bots. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.
### Is abandoned?
Represents if the conversation was abandoned
### Is engaged?
The presence of a human agent as the primary participant in a conversation is indicated by this metric. In turn this indicates if atleast human agent from the contact center accepted this conversation. 
Calculated as - If the conversation had atleast one session with a human agent participate as the primary participant, the value of this metric is true. If not, the value is false. This metric doesn't apply to bot deflected conversations.
### Is conversation ongoing
Represents if the conversation is ongoing.
### Current longest wait time
Represents the longest wait time amongst incoming conversation currently in open state that hasn't yet been accepted by a contact center agent. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.
### Ongoing conversations
Count of conversations that are currently not in a closed status. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Open conversations
Count of conversations that are currently in open state, awaiting agent assignment. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.
### Service level
Percentage of engaged conversations that were accepted by a contact center agent in less than 60 seconds. Additional SLAs of 10 seconds, 20 seconds, 30 seconds, 50 seconds, 120 seconds 
Applies to engaged conversations only. The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice.
### Conversation title
Title of the conversation. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Total conversations
Total number of conversations between customers and agents initiated in the selected time period. This includes conversations across all messaging and voice channels. This includes conversations initiated by customers and agents. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Conversation transfer count
Refers to the number of times a customer conversation was transferred to another agent or queue. The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice.
### Conversation wrap up initiated on
Date and time when the conversation moved to wrap-up status. An engaged conversation moves to wrap-up status if the agent end the conversation, customer ends the conversation or gets disconnected.

## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
