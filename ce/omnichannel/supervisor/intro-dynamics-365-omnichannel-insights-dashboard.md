---
title: "Introduction to Omnichannel Insights dashboard for supervisor | MicrosoftDocs"
description: "Introduction to Omnichannel Insights dashboard for supervisor"
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 06/22/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: c59f8487-0f19-445c-bd96-4c2d468802d4
ms.custom: 
---

# Introduction to Omnichannel Insights dashboard

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

Customer service managers or supervisors are responsible for managing the agents who work to resolve customer queries every day through various service channels, including Chat. They need to be able to know key operational metrics to ensure that their agents are providing quality support. These metrics seen through trends over a period of time helps them understand how each agent and queue is performing over time, so that they can take corrective measures and provide appropriate guidance to agents and fine tune the customer support experience provided.

Supervisors can use Omnichannel Insights to perform the following tasks: 

-	Monitor Chat operational metrics across Queues and Agents

-	Monitor support quality of chats via sentiment analysis across Queues and Agents.

> [!NOTE]
> Contact your system administrator, for configuration errors or if you are unable to view the dashboards. To learn more, see [Configuring Omnichannel Insights dashboard](../administrator/configure-historical-sentiment-dashboard-supervisor.md)


# Omnichannel insights for Dynamics 365

Omnichannel Insights reports provide comprehensive information on how overall support is performing across channels. The reports provide administrators and supervisors with a rich visualization and ability to filter across channels, queues, agents, and date ranges to better understand performance and troubleshoot problem areas. 

Reporting structure consists of six sections:  

1. **Conversation**: This section provides historical visibility into the overall support operations across various channels: 

< waiting on updated screen shots > 

This section consists of the following conversation KPIs: 

|     KPI Visuals                               |   Description                                        |
|-----------------------------------------------|-------------------------------------------------------------|
|Incoming conversation vs Conversations engaged |This visual compares the volume of conversations initiated by the customers and engaged by an agent.                                                                        |
|Avg wait time vs Abandon rate                  |This visual gives supervisor a correlation between the time customer waited on the queue and abandon rate.                                                                |
|Transfer Rate                                  |This visual compares the transfer rate over a period selected by a user with the transfer rate for each day. This will help supervisors to know if there are any specific days contributing to the over all spike in the transfer rate.|
|Average handle time                            |This visual shows the trend of average handle time over a period selected by a user with the average handle time for each day. |
|Average customer effort time                   |This visual shows the trend of average customer effort time over a period selected by a user with the average handle time for each day.|
|Average Customer Sentiment Pulse (CSP)         | The predicted customer sentiment in the timeframe for a set queue/agent, which indicates the degree of positive sentiment expressed by customers at the end of their interactions  |

2. **Channel**: This section provides historical visibility on support operations by each channel that helps supervisors easily understand how each support channel (e.g.: SMS, chat, etc.) are performing and take appropriate actions to improve the overall support experience for customers.  

< waiting on updated screen shot > 

This section consists of the visuals: 
|Visual                              |Description  |
|------------------------------------|-------------|
|Incoming conversations by channel   |This visual provides the volume of incoming conversations by the channels supported in each organization.      |
|Conversations engaged by channel    |This visual provides the trend of conversations engaged in each channel. |
|Average Wait Time (mins) by channel |This visual provides the trend of the average time customers waited on the queue before connecting to an agent in each channel.  |
|Abandon Rate by channel             |This visual provides the trend of abandon rate in each channel.  |
|Average Handle Time (mins) by channel  |This visual provides the trend of average handle time in each channel.|
|Transfer rate                      |The percentage of conversations that are transferred to another agent/queue.  |
|Conversation metrics by channel  | The grid provides the list of metrics across each channel.   |
|Conversation metrics by date     | This grid provides the trend of each metric across channels.  |

3. **Queue**: This section provides historical visibility on how each of queue is performing so supervisors can and take appropriate steps to improve the overall support experience for the customer.  

< confirm screen shots are most current > 


This section consists of the following KPIs: 
|Visual                       | Description                                        |
|-----------------------------|----------------------------------------------------|
|Highest session volumes      |This visual provides the top queues where the sessions most sessions handled  |
|Longest average handle time  |This visual provides list of queues which has high average handle time per session. This helps supervisor to focus on queues and staff agents appropriately.  |
|Highest abandon rates        |This visual provides list of queues which has high abandon. This helps supervisor to focus on queues and staff agents appropriately.   |
|Longest average wait times(min)   |This visual provides list of queues which had longest wait time.    |
|Session metrics by queue     |Grid provides the top metrics across all queues. This helps to compare metrics across each queue.  |
|Session metrics by date      |Grid provides list of metrics by dates.   |

4. **Agent**: This section provides historical visibility on how each agent is performing across different channels/queues so supervisors can take appropriate action to improve the overall support experience for customers.  

< waiting on updated screen shot > 

Metrics in this section are computed at the session granularity.  Each customer contact is defined as a conversation.  Each conversation is defined as a session and can be handled by one or more agents.    

|Visual                        |Description                                                     |
|------------------------------|----------------------------------------------------------------|
|Highest session volumes       |This visual provides the top agents handling the most sessions  |
|Longest average handle time   |This visual provides list of agents who have high average handle time per session. This helps supervisor to focus on these agents to help drive the cost down.  |
|Highest transfer rates        |This visual provides the list of agents who had highest transfer rates. This helps supervisor to dig deeper into the reasons behind the transfers and make corrective actions.  |
|Top sentiment pulse           |This visual helps supervisor to know the list of agents who had high customer sentiments.  |
|Sessions engaged by channel  |This visual provides the split of sessions engaged by an agent across channels.  |
|Session metrics by agent     |Grid provides the top metrics across all agents. This helps to compare agents across each metrics.|
|Session metrics by date      |Grid provides list of metrics by dates. |

5. **Bot insights (BYOB)**: This section provides historical visibility on how bots are performing to help resolve customer support issues. 

< waiting on updated screen shot >   

This section consists of the following KPIs: 
|KPI                        |Description                                                   |
|---------------------------|--------------------------------------------------------------|
|Bot conversation           |The number of conversations initiated by the customer and handled by bot.  |
|Bot Resolution Rate        |The percentage of conversations which was resolved by bot out of all conversations handed by bot.  |
|Bot Resolution time (mins) |The length of time, in minutes, a customer interacted with Bot before the issue was resolved.   |
|Bot escalation rate        |The percentage of conversations that are escalated by bot to a human agent.  |
|Bot escalation time (mins) |Average length of time that bot took to complete the conversation with customer before escalating to a human agent.   |

6. **Sentiment Insights**: This illustration of the Omnichannel Sentiment Analysis dashboard provides an **overview** of important KPIs and trends relative to the sentiment analysis of chats offered.  

Omnichannel Sentiment Analysis dashboard (Overview) 

< waiting on updated screen shot >

This illustration of the Omnichannel Sentiment Analysis report provides a **detailed view** of more comprehensive information.  

Omnichannel Insights - Sentiment Analysis Report (Detail View)  
<waiting on updated screen shot > 

Explanation of Sentiment Analysis KPI’s  
|KPI                                  |Description                                 |
|-------------------------------------|--------------------------------------------|
|Average Sentiment Pulse              |The predicted customer sentiment in a given timeframe for a set queue/agent, which indicates the degree of positive sentiment expressed by customers at the end of their interactions.  |
|% Positive Sentiment                 |Count of positive sentiment zone conversations divided by total chat sessions.  |
|% Neutral Sentiment                  |Count of neutral sentiment zone conversations divided by total chat sessions.  |
|% Negative Sentiment                 |Count of negative sentiment zone conversations divided by total chat sessions.  |
|Conversations with Sentiment predication  |Count of conversations to predict the customer sentiment metrics.|

Information displayed in following sections are based on the conversations and session level, refresh frequency can be configured using the steps here.   

## Prerequisites  

Verify the following prerequisites before you use the Omnichannel Chat and Sentiment Analysis dashboards:

-	Omnichannel supervisor role is assigned. To learn more, see [Assign roles and enable users for Omnichannel for Customer Service](../administrator/add-users-assign-roles.md). 

-	User is added in supervisor configuration. To learn more, see [Add users to supervisor configuration](../administrator/configure-historical-sentiment-dashboard-supervisor.md#add-users-to-supervisor-configuration).

### See also

-  [Configuring Omnichannel Insights dashboard](../administrator/configure-historical-sentiment-dashboard-supervisor.md)

-  [View and understand Omnichannel Insights dashboards](omnichannel-insights-dashboard.md) 
