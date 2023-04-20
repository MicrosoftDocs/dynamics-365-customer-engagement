---
title: "Omnichannel Intraday insights: Conversation insights report for supervisors | MicrosoftDocs"
description: "Learn about the Intraday dashboards: Conversation insights report for supervisors in Omnichannel for Customer Service."
ms.date: 02/05/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
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
- Conversation insights - Voice

The overview section provides the most important metrics across Live Chat, Digital messaging, and Voice. Supervisors can drill through to the detailed metrics for the respective channel type by selecting the Live chat, Digital Messaging, or Voice buttons.

The Digital messaging report includes metrics from the social channels, SMS, Microsoft Teams, entity records, and custom messaging channels.

> [!div class="mx-imgBorder"]
> ![Conversation insights dashboard.](media/conversation-insights-dashboard.png "Conversation insights dashboard")

The **Conversation insights** report displays the following metrics about conversations.

| Metric | Description | Availability|
|-------|-------|------|
| Inbound chats/Inbound conversations/Inbound calls | The number of chat, conversations, or calls that were started, closed, within the last 24 hours by a bot or an agent. | Live chat, Digital messaging, Voice |
| Ongoing chats/Ongoing conversations/Ongoing calls|The number of chat, conversations, or calls by a bot or an agent in active, waiting, and wrap-up statuses. | Live chat, Digital messaging, Voice |
|Service level | The percentage of chats that were accepted by an agent within 30 seconds. The threshold of 30 seconds can be modified to suit your business needs. More information: [Modify thresholds](#modify-thresholds). Only the conversations that are directly handled by the agent or escalated by the bot to the agent are considered; conversations handled and closed by the bot are excluded.| Live chat|
| Chats waiting in queue/Conversations waiting in queue/Calls waiting in queue | The number of conversations that are waiting in the queue to be accepted by the bot or agent. |Live chat, Digital messaging, Voice |
| Closed chats/Closed conversations/Closed calls | The number of conversations closed in the last 24 hours by the bot or agent. |Live chat, Digital messaging, Voice |
| Longest wait time | The longest time that an open conversation is waiting in queue to be accepted by an agent.| Live chat, Digital messaging, Voice |
| Average handle time | The average handle time is calculated as the average of all the handle times of the sessions handled by the agent. The session handle time is the total duration the agent spent on the session when it is in focus in the session panel until an agent closes the session. The handle time is paused when the agent switches to another session and is resumed when the agent returns to the session. More information: [Average handle time](intraday-insights-dashboard.md#average-handle-time). Only the conversations that are directly handled by an agent or escalated by a bot to an agent are considered; conversations handled and closed by the bot are excluded. | Live chat, Digital messaging, Voice |
| Average wait time (min) | For a conversation, wait time is defined as the cumulative wait time of its individual sessions. Session wait time is defined as the elapsed time between the creation of a session and the time that an agent accepts it. If the agent rejects the chat or lets the notification time out, the amount of time it took for the agent to reject the chat or timeout is added and the time it takes for the subsequent session to be accepted by the agent is factored into the wait time. The average wait time is computed for only closed conversations and is also displayed on a per-queue basis. Is derived as the total wait time by total number of conversations, excluding the abandoned ones. Only the conversations that are directly handled by an agent or escalated by a bot to an agent are considered; conversations handled and closed by the bot are excluded. | Live chat, Digital messaging|
| Average wrap time (min) | The average time taken to wrap up conversations. Is derived as the total wrap time by total number of conversations, excluding abandoned ones. Only the conversations that are directly handled by an agent or escalated by a bot to an agent are considered; conversations handled and closed by the bot are excluded.| Live chat, Digital messaging|
| Conversation status | The distribution of the status of conversations across **Open**, **Active**, **Waiting**, **Wrap up**, and **Closed**. |Live chat, Digital messaging, Voice |
| Chat abandon rate/Call abandon rate | The percentage of conversations in which customers left before an agent accepted it. After escalation by a bot, when a customer leaves before an agent accepts it, it's also considered as abandoned. Is derived as the number of abandoned conversations or calls by number of chats or calls.|Live chat, Voice |
| Transfer rate by queue | The percentage of sessions within a queue that were transferred to another agent or queue. Is derived as the number of sessions transferred by total sessions. This includes any sessions created by a bot and escalated to an agent. | Live chat, Digital messaging|
|SLA - First response time | The percentage of conversations wherein the customer received the first response from the agent within 1 minute. The threshold of one minute can be modified to suit your business needs. See Modify thresholds. Only the conversations that are directly handled by an agent or escalated by a bot to an agent are considered; conversations handled and closed by the bot are excluded. |Available for only digital messaging channels; not available in Government Community Cloud (GCC).|
|SLA - Response time | The percentage of messages wherein the customer received a response within 1 minute from the agent. The threshold of one minute can be modified to suit your business needs. Only the conversations that are directly handled by an agent or escalated by a bot to an agent are considered; conversations handled and closed by the bot are excluded.|Available for only digital messaging channels; not available in GCC. |
| Avg - First response time (min) | The average time that a customer waited to receive the first response from  agents. First response time is the difference between the first message from the customer and first response from the agent in a conversation, when there are multiple messages and responses exchanged between the customer and agent in quick succession. Is derived as the total first response time by the total number of conversations, excluding the abandoned ones. For a conversation escalated by the bot, the first response time is the difference between the agent’s first response and escalation time.| Live chat, Digital messaging; not available in GCC. |
|Avg - Response time (min)| The average time that a customer waited to receive responses from agents. Is derived as the total response time by the total number of such responses. Response time is the difference between the earliest message from the customer and the earliest response from the agent when there are multiple messages and responses exchanged between the customer and agent in quick succession. This excludes any responses from the bot to customer, and considers only the responses from the agent, excluding the first response, after escalation by the bot| Live chat, Digital messaging; not available in GCC. |
| Service level - Speed to answer |The percentage of voice calls that were answered within 30 seconds by the agent. The threshold of 30 seconds can be modified to suit your business needs. See Modify thresholds. Only the calls that are directly handled by an agent or escalated by the bot to agent are considered; calls handled and closed by the bot are excluded.|Voice |
| Avg. talk time (min)| The average time the agent spent talking with a customer over a voice call. Only the calls that are directly handled by the agent or escalated by the bot to agent are considered; calls handled and closed by the bot are excluded.| Voice |
| Avg. hold time (min) |  The average time the agent put a customer on hold over a voice call. Is derived as the total hold time by total calls put on hold by the agent. | Voice |
|Avg. after call work time| The average time an agent took to wrap up a voice call. Is derived as the total after call work time by number of calls, excluding the abandoned ones. Only the calls that are directly handled by the agent or escalated by the bot to agent are considered; calls handled and closed by the bot are excluded.| Voice |
|Avg. speed to answer|The average time it took for a customer call to be answered. Is derived as the total time to accept by the number of calls accepted, excluding the abandoned ones. Only the calls that are directly handled by the agent or escalated by the bot to agent are considered; calls handled and closed by the bot are excluded.| Voice |
|Customer Sentiment|An automatic and unbiased measurement of satisfaction levels of the customer in real time. More information: [Understand real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md#understand-real-time-customer-sentiment) |Voice |
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
|Escalations |The total number of escalations made. It does not include escalation from the bot to agent.|
| Speed to answer (sec) | **For voice channel**: The time it took for a customer call to be answered. |
| Talk time (min)| **For voice channel**: The total time spent by the customer and agent talking on the voice call. It’s the difference between the handle time and cumulative time in hold and after call work time. |
| Hold time (min)|**For voice channel**: The total time an agent has put a customer on hold.|
| After call work time (min)| **For voice channel**: The time spent by an agent in wrapping up a voice call. |
| Wait time (min) | For a conversation, wait time is defined as the cumulative wait time of its individual sessions. Session wait time is defined as the elapsed time between the creation of a session and the time that an agent accepts it. |
| Handle time (min) | Total time taken to accept and close the conversation. |
| Wrap time (min) | Total time in which the conversation was in the wrap stage. |
| Sentiment | An automatic and unbiased measurement of satisfaction levels of the customer in real time. |
| Created on | The date on which the conversation was created on. The date and time is displayed in the UTC time zone. |
| Conversation ID | The conversation's ID. |
|||

The **Closed conversations** table provides information related to all the conversations that have been closed.

You can also assign a conversation to an agent or route it to another queue. More information: [Monitor and assign conversations](monitor-conversations.md#assign-conversations).

### Factors that affect response time

First response time is calculated as the difference between the first message from the customer and the first response from the agent in a conversation that might contain more than one message or response. 

Response time is the difference between the earliest message from the customer and the earliest response from the agent, excluding the first message and response from the customer and agent respectively.

The successive exchange of messages will not be counted towards the calculation of the first response time and response time.

For example, a customer sends a message "Hello" at 2:20 PM and another message "I have a problem" at 2:21 PM. The agent responds as "Hello, sorry for the inconvenience." at 2:22 PM and "What is the issue you are facing?" at 2:23 PM. The first response time will be the difference between 2:20 PM and 2:22 PM, which is two minutes. Then the customer sends a message "My coffee machine has stopped working" at 2:24 PM and another message "I checked everything" at 2:25 PM. The agent responds "Let me help you with that" at 2:27 PM and "Are you near the coffee machine now?" at 2:28 PM. The response time will be the difference between 2:24 PM and 2:27 PM, which is three minutes.

The first response time and response time is calculated by keeping different factors into account. If operating hours are defined on the queue, the wait period of the out-of-operating hours is not considered in the response time. For example, an organization's operating hours are from 9:00 AM to 5:00 PM. When a chat is initiated by a customer at 8:55 AM, and agent responds at 9:03 AM. The response time will be the difference between 9:00 AM and 9:03 AM, which is three minutes. The metric doesn't consider the five minutes that are outside of the operating hours.

If a conversation is transferred from one queue to another, the messages exchanged in the currently assigned queue and its operating hours are taken into account for calculating the response time.

If the operating hours of the queue are updated to a new schedule, the latest operating hours are considered in calculating the response time for messages exchanged post the change.

### Modify thresholds

In a BI workspace that's custom configured, you can update the thresholds for the metrics that are displayed in the out-of-the-box reports. However, you can't modify the thresholds in a preconfigured BI workspace.

1. Open the report in Power BI.

2. On the report page, on the command menu, select **Edit**, and then select the KPI for which you want to change the threshold. The **Fields** pane appears on the right.

3. Expand the field on which the KPI is based, and scroll down to the fields that denote the time.

4. Clear the current selection, and then select the time field whose value meets your requirement.

    A sample change of threshold is as follows.

    :::image type="content" source="media/modify-thresholds.png" alt-text="Modify threshold value.":::

5. Save the changes.

### See also

[Introduction to intraday insights dashboard](intro-intraday-insights-dashboard.md)  
[Intraday insights dashboard](intraday-insights-dashboard.md)  
[View and understand Agents insights report](intraday-agents-insights.md)  
[View and understand Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
