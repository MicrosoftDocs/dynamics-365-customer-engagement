---
title: "Omnichannel Insights dashboards for supervisors | MicrosoftDocs"
description: "Learn about Omnichannel Insights dashboards for supervisors"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/07/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# View and understand Omnichannel Insights dashboards

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Omnichannel Insights  

The Omnichannel Insights dashboard provides KPIs and trends for supervisors to understand the overall state of omnichannel support experience at a glance. It also provides insights on the customer sentiments derived using support-specific machine learning algorithms with an ability to slice through different levels in the organizational hierarchy, which supervisors can rely on to improve the overall customer support experience.  

Typically, the overview dashboard is divided into two sections:

- [Omnichannel Insights dashboard](omnichannel-insights-dashboard.md#omnichannel-insights-dashboard)

- [Omnichannel Sentiment Analysis dashboard](omnichannel-insights-dashboard.md#omnichannelsentiment-analysisdashboard)

## Omnichannel Insights dashboard

The following illustration is an example of the Omnichannel Insights for Dynamics 365 dashboard:

   > [!div class=mx-imgBorder]
   > ![Omnichannel dashboard](../media/oc-full-dashboard.png "Omnichannel dashboard")

This section consists of the following conversation KPIs:

| KPI                  | Description              |
|----------------------|--------------------------|
|Incoming conversation | The number of conversations initiated by the customer.|
|Conversations engaged | Offered conversations that are engaged by an agent. Customer-to-agent communication can begin at this point.  |
|Average Wait Time (mins) | The length of time, in minutes, a customer is waiting in a queue. |
|Average wait time | Total length of time (in minutes) / Offered |
|Abandon Rate | The percentage of conversations that are not engaged by agents.|
|Average Handle Time (mins) |Average length of time an agent takes to complete a conversation with a customer. This time considers the time spent by one or more agents to help the customer.|
|Transfer rate |The percentage of conversations that are transferred to another agent/queue.|
|Average Customer Sentiment Pulse (CSP) | The predicted customer sentiment in a given timeframe for a set queue/agent, which indicates the degree of positive sentiment expressed by customers at the end of their interactions.|
|Average customer effort time |Average length of time a customer takes to contact support and complete a conversation with an agent. Only the conversations engaged by an agent are considered for this metric.|

## Omnichannel Insights for Dynamics 365

Omnichannel Insights reports provide comprehensive information on how overall support is performing across channels. The reports provide administrators and supervisors with a rich visualization and ability to filter across channels, queues, agents, and date ranges to better understand performance and troubleshoot problem areas.

Reporting structure consists of five sections:

- [Conversation](#conversation)
- [Channel](#channel)
- [Queue](#queue)
- [Agent](#agent)
- [Bot insights (BYOB)](#botinsightsbyob)

### Conversation

   This section provides historical visibility into the overall support operations across various channels: 

   > [!div class=mx-imgBorder]
   > ![Conversation](../media/conversation-report.png "Conversation")

   This section consists of the following conversation KPIs: 

   | KPI visuals    |   Description              |
   |----------------|----------------------------|
   |Incoming conversation vs. Conversations engaged  |This visual compares the volume of conversations initiated by the customers and engaged by an agent.             |
   |Avg wait time vs. Abandon rate                  |This visual gives supervisors a correlation between the time a customer waited in the queue and abandon rate.                        |
   |Transfer rate                                  |This visual compares the transfer rate over a period selected by a user with the transfer rate for each day. This helps supervisors know if there are any specific days contributing to the overall spike in the transfer rate.|
   |Average handle time                            |This visual shows the trend of average handle time over a period selected by a user with the average handle time for each day. |
   |Average customer effort time                   |This visual shows the trend of average customer effort time over a period selected by a user with the average handle time for each day.|
   |Average Customer Sentiment Pulse (CSP)         |The predicted customer sentiment in the timeframe for a set queue/agent, which indicates the degree of positive sentiment expressed by customers at the end of their interactions  |

### Channel

   This section provides historical visibility on support operations by each channel that helps supervisors easily understand how each support channel (for example, SMS or chat) are performing and take appropriate actions to improve the overall support experience for customers.  

   > [!div class=mx-imgBorder]
   > ![Channel report](../media/channel.png "Channel report")

   This section consists of these visuals: 

   |  KPI visual            | Description      | 
   |------------------|-----------------|
   |Incoming conversations by channel   |This visual provides the volume of incoming conversations by the channels supported in each organization.      |
   |Conversations engaged by channel    |This visual provides the trend of conversations engaged in each channel. |
   |Average Wait Time (mins) by channel |This visual provides the trend of the average time customers waited in the queue before connecting to an agent in each channel.  |
   |Abandon Rate by channel             |This visual provides the trend of abandon rate in each channel.  |
   |Average Handle Time (mins) by channel  |This visual provides the trend of average handle time in each channel.|
   |Transfer rate                      |The percentage of conversations that are transferred to another agent/queue.  |
   |Conversation metrics by channel  | The grid provides the list of metrics across each channel.   |
   |Conversation metrics by date     | This grid provides the trend of each metric across channels.  |

### Queue

   This section provides historical visibility into how each queue is performing so supervisors can take appropriate steps to improve the overall support experience for the customer.  

   > [!div class=mx-imgBorder]
   > ![Queue report](../media/queue-report.png "Queue report")

   This section consists of the following KPIs:

   | KPI visual        | Description                   |
   |--------------|-------------------------------|
   |Highest session volumes      |This visual provides the top queues where the most sessions are handled.  |
   |Longest average handle time  |This visual provides a list of queues that have high average handle times per session. This helps supervisors focus on queues and staff agents appropriately.  |
   |Highest abandon rates        |This visual provides a list of queues that have high abandon rates. This helps supervisors focus on queues and staff agents appropriately.   |
   |Longest average wait times (min)   |This visual provides a list of queues that have the longest wait times.    |
   |Session metrics by queue     |Grid provides the top metrics across all queues. This helps to compare metrics across each queue.  |
   |Session metrics by date      |Grid provides a list of metrics by dates.   |

### Agent

   This section provides historical visibility into how each agent is performing across different channels/queues so supervisors can take appropriate action to improve the overall support experience for customers.  

   > [!div class=mx-imgBorder]
   > ![Agent report](../media/agent.png "Agent report")

   Metrics in this section are computed at the session granularity.  Each customer contact is defined as a conversation.  Each conversation is defined as a session and can be handled by one or more agents.    

   |Visual     |Description              |
   |------------|------------------------|
   |Highest session volumes       |This visual provides the top agents handling the most sessions  |
   |Longest average handle time   |This visual provides a list of agents who have high average handle times per session. This helps supervisors to focus on these agents to help drive the cost down.  |
   |Highest transfer rates        |This visual provides the list of agents who had the highest transfer rates. This helps supervisors to dig deeper into the reasons behind the transfers and make corrective actions.  |
   |Top sentiment pulse           |This visual helps supervisors know which agents had high customer sentiments for the sessions engaged.  |
   |Sessions engaged by channel  |This visual provides the split of sessions engaged by an agent across channels.  |
   |Session metrics by agent     |Grid provides the top metrics across all agents. This helps to compare agents across each metrics.|
   |Session metrics by date      |Grid provides list of metrics by dates. |

### Bot insights (BYOB)

   This section provides historical visibility into how bots are performing to help resolve customer support issues. 

   > [!div class=mx-imgBorder]
   > ![Bot insights (BYOB)](../media/bot-insights.png "Bot insights (BYOB)")  

   This section consists of the following KPIs: 

   |KPI           |Description                    |
   |--------------|-------------------------------|
   |Bot conversation           |The number of conversations initiated by the customer and handled by a bot.  |
   |Bot Resolution Rate        |The percentage of conversations that were resolved by a bot out of all conversations handed by a bot.  |
   |Bot Resolution time (mins) |The length of time, in minutes, a customer interacted with a bot before the issue was resolved.   |
   |Bot escalation rate        |The percentage of conversations that are escalated by a bot to a human agent.  |
   |Bot escalation time (mins) |Average length of time that a bot took to complete the conversation with a customer before escalating to a human agent.   |

## Omnichannel Sentiment Analysis dashboard

This illustration of the Omnichannel Sentiment Analysis dashboard provides an **overview** of important KPIs and trends relative to the sentiment analysis of conversation offered.  

   > [!div class=mx-imgBorder]
   > ![Sentiment analysis overview](../media/oc-overview.png "Sentiment analysis overview")  

## Omnichannel Insights – Sentiment Analysis report

This illustration of the Omnichannel Sentiment Analysis report provides a **detailed view** of more comprehensive information. 

   > [!div class=mx-imgBorder]
   > ![Sentiment Analysis detailed report](../media/oc-detailed.png "Sentiment Analysis detailed report")

   Explanation of Sentiment Analysis KPIs
    
   |KPI             |Description                |
   |-----------------|---------------------------|
   |Average Sentiment Pulse              |The predicted customer sentiment in a given timeframe for a set queue/agent that indicates the degree of positive sentiment expressed by customers at the end of their interactions. For channel and queue, it provides the overall customer sentiment of the conversation. For agent, it provides the customer sentiment specific to the sessions handled by the agent in the conversation.  |
   |% Positive Sentiment                 |Count of positive sentiment zone conversations divided by total sessions.  |
   |% Neutral Sentiment                  |Count of neutral sentiment zone conversations divided by total sessions.  |
   |% Negative Sentiment                 |Count of negative sentiment zone conversations divided by total sessions.  |
   |Conversations with Sentiment prediction  |Count of conversations to predict the customer sentiment metrics.|

## Preview: Omnichannel Insights – Sentiment drivers reporting

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Topics are generated when chat transcripts from Omnichannel are analyzed and grouped together and similarities are discovered in the conversations. These are then correlated with the sentiment so that supervisors can better understand how their customers feel about each topic on which they have interacted with the agents.

   > [!div class=mx-imgBorder]
   > ![Topics impacting sentiment](../media/topics-impacting-sentiment.png "Sentiment Analysis detailed report")

   > [!NOTE]
   >
   > - The filters at the top of the report (duration, channel, agent, queue do not have an impact on the topic related tiles).
   > - This component of the report will display data only when sentiment drivers reporting is enabled and a minimum of 10 chat conversations per organization take place.


   |Tile             |Description                |
   |-----------------|---------------------------|
   |Grid             | Displays the discovered topics from the most recent 24 hour period in which chat transcripts were processed. |
   |Keyword          | Displays the keywords that are related to a topic.  |
   |Ribbon chart     | Displays the topics that have been discovered over the course of the most recent full week in which chat transcripts were processed. |


   |KPI             |Description                |
   |-----------------|---------------------------|
   |Impact           | Denotes the extent to which conversations related to a topic are driving the overall sentiment up or down. It is determined by factoring out the sentiment of chats for the topic in question and comparing the resulting average to the overall sentiment across all chats. The difference indicates negative or positive impact on sentiment.  |
   |Volume  |Denotes the total number of chat transcripts that are assigned to a topic. |
   |Avg. Sentiment    | Denotes the average sentiment of chat transcripts that correspond to a topic.

## Sentiment zones

**Positive sentiment**

Positive sentiment is expressed by the customer writing messages that they are happy, pleased, or positive as a result of the support interaction. Positive sentiment requires the positive words to **convey positive feeling beyond just simple pleasantries or politeness**.

For example, when a customer writes “thank you,” that is just being polite—it doesn’t necessarily mean they are pleased or happy. However, if a customer writes “I can’t thank you enough” or “thank you very much,” that is portraying clear positive feeling. Other examples of simple pleasantries/politeness that shouldn’t be mischaracterized as positive are “Please help” and “Yes."

**Negative sentiment**

Negative sentiment is expressed by the customer when they are disappointed with the support interaction. These can be cases where the customer is describing a problem and is frustrated or unhappy because of how it is currently impacting them. For something to be scored with negative sentiment, the words need to clearly convey that the user is unhappy, disappointed, and frustrated.

**Neutral sentiment**

Neutral sentiment is represented when a customer’s sentiment was neither positive nor negative. A customer’s problem statement isn’t to be scored negative; rather, it should be scored neutral unless it contains words that denote emotion.  This is regardless of how severe the user’s problem is. Messages with non-specific pleasantries and/or politeness are scored as neutral and not as positive.

### View and filter reports

You can filter the information presented in the reports by selecting **Duration**, **Channel**, **Queue,** and **Agent**.

   > [!div class=mx-imgBorder]
   > ![Sentiment Analysis filtered report](../media/supervisor-historical-filter-reports.png "Sentiment Analysis filtered report")

### See also

[Introduction to Omnichannel Insights dashboard](../supervisor/intro-dynamics-365-omnichannel-insights-dashboard.md)

[Configure Omnichannel Insights dashboard](../administrator/configure-historical-sentiment-dashboard-supervisor.md)

[Analyze real-time customer sentiment](../administrator/enable-sentiment-analysis.md)