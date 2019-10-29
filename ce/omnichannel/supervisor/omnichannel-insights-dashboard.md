---
title: "Omnichannel Insights dashboards for supervisor | MicrosoftDocs"
description: "Learn about Omnichannel Insights dashboards for supervisor"
keywords: ""
author: lerobbin
ms.author: lerobbin
manager: autumna
applies_to: 
ms.date: 10/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: f7b39a03-6e47-43bd-9c9b-f33170124a78
ms.custom: 
---

# View and understand Omnichannel Insights dashboards

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Omnichannel Insights  

The Omnichannel Insights dashboard provides KPIs and trends for supervisors to understand the overall state of omnichannel support experience at a glance. It also provides insights on the customer sentiments derived using support specific machine learning algorithm with an ability to slice through different levels in the organization hierarchy which supervisors can rely on to improve the overall customer support experience.  

Typically, the overview dashboard is divided into two sections: 

[Omnichannel Insights Dashboard](#omnichannel-insights-dashboard)

[Omnichannel Sentiment Analysis Dashboard](#omnichannel-sentiment-analysis-dashboard)

## Omnichannel Insights Dashboard

The following illustration shows an example of the Omnichannel insights dashboard: 

   > [!div class=mx-imgBorder]
   > ![Omnichannel Dashboard](../media/oc-full-dashboard.png "Omnichannel Dashboard")

This section consists of the following conversation KPIs.

| KPI                  | Description              |
|----------------------|--------------------------|
|Incoming conversation | The number of conversations initiated by the customer.|
|Conversations engaged | Offered Conversations that are engaged by an agent.  Customer-to-agent communication can begin at this point.  |
|Average Wait Time (mins) | The length of time, in minutes, a customer is waiting in queue. |
|Average wait time | Total length of time (in minutes) / Offered |
|Abandon Rate | The percentage of conversations that are not engaged by agents|
|Average Handle Time (mins) |Average length of time that an agent(s) takes to complete the conversation with customer. This time considers the time spent by one or more agents to help the customer.|
|Transfer rate |The percentage of conversations that are transferred to another agent/queue.|
|Average Customer Sentiment Pulse (CSP) | The predicted customer sentiment in a given timeframe for a set queue/agent, which indicates the degree of positive sentiment expressed by customers at the end of their interactions.|
|Average customer effort time |Average length of time that a customer takes to contact support and complete the conversation an agent. Only the conversations engaged by an agent is considered for this metric.|

## Omnichannel Insights for Dynamics 365

Omnichannel Insights reports provide comprehensive information on how overall support is performing across channels. The reports provide administrators and supervisors with a rich visualization and ability to filter across channels, queues, agents, and date ranges to better understand performance and troubleshoot problem areas. 

Reporting structure consists of five sections: 

1. [Conversation](#1-conversation)
2. [Channel](#2-channel)
3. [Queue](#3-queue)
4. [Agent](#4-agent)
5. [Bot insights (BYOB)](#5-bot-insights-(byob))

### **1. Conversation**: 

   This section provides historical visibility into the overall support operations across various channels: 

   > [!div class=mx-imgBorder]
   > ![Conversation](../media/conversation-report.png "Conversation")

   This section consists of the following conversation KPIs: 

   | KPI Visuals    |   Description              |
   |----------------|----------------------------|
   |Incoming conversation vs Conversations engaged  |This visual compares the volume of conversations initiated by the customers and engaged by an agent.             |
   |Avg wait time vs Abandon rate                  |This visual gives supervisor a correlation between the time customer waited on the queue and abandon rate.                        |
   |Transfer Rate                                  |This visual compares the transfer rate over a period selected by a user with the transfer rate for each day. This will help supervisors to know if there are any specific days contributing to the over all spike in the transfer rate.|
   |Average handle time                            |This visual shows the trend of average handle time over a period selected by a user with the average handle time for each day. |
   |Average customer effort time                   |This visual shows the trend of average customer effort time over a period selected by a user with the average handle time for each day.|
   |Average Customer Sentiment Pulse (CSP)         |The predicted customer sentiment in the timeframe for a set queue/agent,which indicates the degree of positive sentiment expressed by customers at the end of their interactions  |

### **2. Channel**: 
   This section provides historical visibility on support operations by each channel that helps supervisors easily understand how each support channel (e.g.: SMS, chat, etc.) are performing and take appropriate actions to improve the overall support experience for customers.  

   > [!div class=mx-imgBorder]
   > ![Channel Report](../media/channel.png "Channel Report")

   This section consists of the visuals: 

   |  Visual            |Description      | 
   |------------------|-----------------|
   |Incoming conversations by channel   |This visual provides the volume of incoming conversations by the channels supported in each organization.      |
   |Conversations engaged by channel    |This visual provides the trend of conversations engaged in each channel. |
   |Average Wait Time (mins) by channel |This visual provides the trend of the average time customers waited on the queue before connecting to an agent in each channel.  |
   |Abandon Rate by channel             |This visual provides the trend of abandon rate in each channel.  |
   |Average Handle Time (mins) by channel  |This visual provides the trend of average handle time in each channel.|
   |Transfer rate                      |The percentage of conversations that are transferred to another agent/queue.  |
   |Conversation metrics by channel  | The grid provides the list of metrics across each channel.   |
   |Conversation metrics by date     | This grid provides the trend of each metric across channels.  |

### **3. Queue**: 
   This section provides historical visibility on how each of queue is performing so supervisors can and take appropriate steps to improve the overall support experience for the customer.  

   > [!div class=mx-imgBorder]
   > ![Queue Report](../media/queue-report.png "Queue Report")

   This section consists of the following KPIs: 

   |Visual        | Description                   |
   |--------------|-------------------------------|
   |Highest session volumes      |This visual provides the top queues where the sessions most sessions handled  |
   |Longest average handle time  |This visual provides list of queues which has high average handle time per session. This helps supervisor to focus on queues and staff agents appropriately.  |
   |Highest abandon rates        |This visual provides list of queues which has high abandon. This helps supervisor to focus on queues and staff agents appropriately.   |
   |Longest average wait times(min)   |This visual provides list of queues which had longest wait time.    |
   |Session metrics by queue     |Grid provides the top metrics across all queues. This helps to compare metrics across each queue.  |
   |Session metrics by date      |Grid provides list of metrics by dates.   |

### **4. Agent**: 

   This section provides historical visibility on how each agent is performing across different channels/queues so supervisors can take appropriate action to improve the overall support experience for customers.  

   > [!div class=mx-imgBorder]
   > ![Agent Report](../media/agent.png "Agent Report")

   Metrics in this section are computed at the session granularity.  Each customer contact is defined as a conversation.  Each conversation is defined as a session and can be handled by one or more agents.    

   |Visual     |Description              |
   |------------|------------------------|
   |Highest session volumes       |This visual provides the top agents handling the most sessions  |
   |Longest average handle time   |This visual provides list of agents who have high average handle time per session. This helps supervisor to focus on these agents to help drive the cost down.  |
   |Highest transfer rates        |This visual provides the list of agents who had highest transfer rates. This helps supervisor to dig deeper into the reasons behind the transfers and make corrective actions.  |
   |Top sentiment pulse           |This visual helps supervisor to know the list of agents who had high customer sentiments.  |
   |Sessions engaged by channel  |This visual provides the split of sessions engaged by an agent across channels.  |
   |Session metrics by agent     |Grid provides the top metrics across all agents. This helps to compare agents across each metrics.|
   |Session metrics by date      |Grid provides list of metrics by dates. |

### **5. Bot insights (BYOB)**: 

   This section provides historical visibility on how bots are performing to help resolve customer support issues. 

   > [!div class=mx-imgBorder]
   > ![Bot insights (BYOB)](../media/bot-insights.png "Bot instights (BYOB)")  

   This section consists of the following KPIs: 

   |KPI           |Description                    |
   |--------------|-------------------------------|
   |Bot conversation           |The number of conversations initiated by the customer and handled by bot.  |
   |Bot Resolution Rate        |The percentage of conversations which was resolved by bot out of all conversations handed by bot.  |
   |Bot Resolution time (mins) |The length of time, in minutes, a customer interacted with Bot before the issue was resolved.   |
   |Bot escalation rate        |The percentage of conversations that are escalated by bot to a human agent.  |
   |Bot escalation time (mins) |Average length of time that bot took to complete the conversation with customer before escalating to a human agent.   |

## Omnichannel Sentiment Analysis Dashboard

   This illustration of the Omnichannel Sentiment Analysis dashboard provides an **overview** of important KPIs and trends relative to the sentiment analysis of conversation offered.  

   > [!div class=mx-imgBorder]
   > ![Sentiment Analysis Overview](../media/oc-overview.png "Sentiment Analysis Overview")  

   This illustration of the Omnichannel Sentiment Analysis report provides a **detailed view** of more comprehensive information.  

   Omnichannel Insights - Sentiment Analysis Report (Detail View)  

   > [!div class=mx-imgBorder]
   > ![Sentiment Analysis Detailed Report](../media/oc-detailed.png "Sentiment Analysis Detailed Report")

   Explanation of Sentiment Analysis KPI’s 
    
   |KPI             |Description                |
   |-----------------|---------------------------|
   |Average Sentiment Pulse              |The predicted customer sentiment in a given timeframe for a set queue/agent, which indicates the degree of positive sentiment expressed by customers at the end of their interactions.  |
   |% Positive Sentiment                 |Count of positive sentiment zone conversations divided by total sessions.  |
   |% Neutral Sentiment                  |Count of neutral sentiment zone conversations divided by total sessions.  |
   |% Negative Sentiment                 |Count of negative sentiment zone conversations divided by total sessions.  |
   |Conversations with Sentiment predication  |Count of conversations to predict the customer sentiment metrics.|

### Sentiment Zones

**Positive Sentiment**

Positive sentiment is expressed by the customer writing messages that they are happy, pleased, or positive with the result of the support interaction. Positive sentiment requires the positive words need to **convey positive feeling beyond just simple pleasantries or politeness**. For example, when a customer writes “thank you”, that is just being polite, it doesn’t necessarily mean they are pleased or happy. However, if a customer writes “I can’t thank you enough” or “thank you very much” that is portraying clear positive feeling. Some other examples of simple pleasantries/politeness that shouldn’t be mischaracterized as positive are “Please help” and “Yes". 

**Negative Sentiment**

Negative sentiment is expressed by the customer when they are disappointed with the support interaction. These can be cases where the customer is describing their problem and are frustrated or unhappy because of how it is currently impacting them. For something to be scored with negative sentiment the words need to **clearly convey that the user is unhappy, disappointed, frustrated,** etc.

**Neutral Sentiment**

Neutral sentiment is represented when a customer’s sentiment was neither positive nor negative. A customer’s problem statement isn’t to be scored Negative, rather it should be scored Neutral, unless it contains words that denote emotion.  This is regardless of how severe the user’s problem is. Additionally, messages with non-specific pleasantries and/or politeness are also be scored Neutral and not as Positive.

### View and filter reports 

You can filter the information presented in the reports by selecting **Duration, Channel, Queue Name,** and **Agent Name**.

   > [!div class=mx-imgBorder]
   > ![Sentiment Analysis Filtered Report](../media/oc-sentiment-filtered-report.png "Sentiment Analysis Filtered Report")

### See also

[Introduction to Omnichannel Insights dashboard](../supervisor/intro-dynamics-365-omnichannel-insights-dashboard.md)

[Configuring Omnichannel Insights dashboard](../administrator/configure-historical-sentiment-dashboard-supervisor.md)





