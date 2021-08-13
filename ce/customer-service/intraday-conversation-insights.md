---
title: "Omnichannel Intraday insights: Conversation insights report for supervisors | MicrosoftDocs"
description: "Learn about the Intraday dashboards: Conversation insights report for supervisors in Omnichannel for Customer Service."
ms.date: 08/13/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom: intro-internal
---

# View and understand the Conversation insights report in Omnichannel intraday insights

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

The Omnichannel intraday insights dashboard contains the Conversation insights report that helps provide an overview of the conversations across the different channels.


## The Conversation insights report

The **Conversation insights** report is arranged in the following tabs:

- Conversation insights - Overview
- Conversation insights - Live chat
- Conversation insights - Digital messaging
- Conversation insights - Voice (preview)

The overview section provides the most important metrics across Live Chat, Digital messaging, and Voice. Supervisors can drill through to the detailed metrics for the respective channel type by selecting the Live chat, Digital Messaging, or Voice buttons.

The Digital messaging report includes metrics from the social channels, SMS, Microsoft Teams, entity records, and custom messaging channels.

> [!div class="mx-imgBorder"]
> ![Conversation insights dashboard.](media/conversation-insights-dashboard.png "Conversation insights dashboard")

The **Conversation insights** report displays the following metrics about conversations.

| Metric | Description | Availability|
|-------|-------|------|
| Inbound chats/Inbound conversations/Inbound calls | The number of chat, conversations, or calls that were started, closed, within the last 24 hours. | Live chat, Digital messaging, Voice (preview) |
| Ongoing chats/Ongoing conversations/Ongoing calls|The number of chat, conversations, or calls in active, waiting, and wrap-up statuses. | Live chat, Digital messaging, Voice (preview)|
|Service level | The percentage of chats that were answered within 30 seconds. The 30 seconds threshold can be modified to suit your business needs. | Live chat|
| Chats waiting in queue/Conversations waiting in queue/Calls waiting in queue | The number of conversations that are waiting in the queue and are ready to be picked up by an agent. |Live chat, Digital messaging, Voice (preview)|
| Closed chats/Closed conversations/Closed calls | The number of conversations closed in the last 24 hours. |Live chat, Digital messaging, Voice (preview)|
| Longest wait time | The longest time that a conversation is in queue waiting to be picked up by an agent. | Live chat, Digital messaging, Voice (preview)|
| Average handle time | For a conversation, the handle time used to calculate the average is defined as the cumulative handle time of its individual sessions. *Session handle time* is defined as the elapsed time between the creation of a session and the time that it's closed. More information: [Average handle time](intraday-insights-dashboard.md#average-handle-time). | Live chat, Digital messaging, Voice (preview)|
| Average wait time (min) | For a conversation, wait time is defined as the cumulative wait time of its individual sessions. This KPI is calculated as an average that considers only closed conversations. Session wait time is defined as the elapsed time between the creation of a session and the time that an agent is assigned. | Live chat, Digital messaging|
| Average wrap time (min) | The average time taken to wrap up conversations. | Live chat, Digital messaging|
| Conversation status | The distribution of the status of conversations across **Open**, **Active**, **Waiting**, **Wrap up**, and **Closed**. |Live chat, Digital messaging, Voice (preview)|
| Chat abandon rate/Call abandon rate | The percentage of conversations abandoned by customers before connecting to an agent. |Live chat, Voice (preview)|
| Transfer rate by queue | The percentage of sessions within a queue that were transferred to another agent or queue. | Live chat, Digital messaging|
|SLA - First response time | The percentage of conversations wherein the customer received the very first response from the agent within 1 minute. The 1 minute threshold can be modified to suit your business needs. |Available for only digital messaging channels; not available in Government Community Cloud (GCC).|
|SLA - Response time | The percentage of messages wherein the customer received a response within 1 min from the agent. The 1 minute threshold can be modified to suit your business needs. |Available for only digital messaging channels; not available in GCC. |
| Avg - First response time (min) | The average time that a customer waited to receive the first response from  agents. | Live chat, Digital messaging|
|Avg - Response time (min)| The average time that a customer waited to receive responses from agents.| Live chat, Digital messaging|
| Service level - Speed to answer |The percentage of voice calls that were answered within 30 seconds. The 30 seconds threshold can be modified to suit your business needs.|Voice (preview)|
| Avg. talk time (min)| The average time an agent spent talking with a customer over a voice call. | Voice (preview)|
| Avg. hold time (min) |  The average time an agent put a customer on hold over a voice call. | Voice (preview)|
|Avg. after call work time| The average time an agent took to wrap up a voice call.| Voice (preview)|
|Avg. speed to answer|The average time it took for a customer call to be answered.| Voice (preview)|
||||



### Ongoing and closed conversations

The **Ongoing conversations** table provides information about the status of the conversations that are not yet closed. The table also displays information about the channel through which the conversation came in, with the time and date that the conversation was picked up.


> [!div class="mx-imgBorder"]
> ![Ongoing conversations.](media/ongoing-conversations.png "Ongoing conversations")

The **Ongoing conversations** table displays the following metrics based on the channels through which the conversations are being held.

| Title | Description | 
|------------ | --------------- |
| Agent | Name of the agent |
| Status | The status of the conversation, that is, open, active, waiting, wrap up, and closed. |
| Action | The action that can be taken on the conversation, that is, assign, monitor, or view the conversation.|
| Queue | The name of the queue that the conversation is a part of. |
| Channel | The name of the channel that the conversation came through. |
| Workstream| The workstream that the conversation is a part of.|
| First response time (min) |After sending the message, the time the customer waited for the first response from the agent. Not available in GCC. |
| Avg. response time (min)|The average time the customer waited for the agent to respond to their messages. Not available in GCC.|
| Total response time (min)|The total time the customer waited for the agent to respond to their messages. Not available in GCC.|
| Transfers|The total number of transfers made if the conversation is routed to another agent.|
|Escalations |The total number of escalations made. It does not include escalation from a bot to a human agent.|
| Speed to answer (sec) | **For voice channel (Preview)**: The time it took for a customer call to be answered. |
| Talk time (min)| **For voice channel (Preview)**: The total time spent by the customer and agent talking on the voice call. It’s the difference between the handle time and cumulative time in hold and after call work time. |
| Hold time (min)|**For voice channel (Preview)**: The total time an agent has put a customer on hold.|
| After call work time (min)| **For voice channel (Preview)**: The time spent by an agent in wrapping up a voice call. |
| Wait time (min) | Total wait time of the conversation. |
| Handle time (min) | Total time taken to accept and close the conversation. |
| Wrap time (min) | Total time in which the conversation was in the wrap stage. |
| Sentiment | The real-time sentiment analysis. |
| Created on | The date on which the conversation was created on. The date and time is displayed in the UTC time zone. |
| Conversation ID | The conversation's ID. |
|||

The **Closed conversations** table provides information related to all the conversations that have been closed.

You can also assign a conversation to an agent or route it to another queue. More information: [Monitor and assign conversations](monitor-conversations.md#assign-conversations).


### See also

[Introduction to intraday insights dashboard](intro-intraday-insights-dashboard.md)  
[Intraday insights dashboard](intraday-insights-dashboard.md)  
[View and understand Agents insights report](intraday-agents-insights.md)  
[View and understand Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
