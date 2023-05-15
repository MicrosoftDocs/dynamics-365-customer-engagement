---
title: Omnichannel Conversation Topics Dashboard | Microsoft Docs
description: Learn about the Conversation topics dashboard in Omnichannel historical analytics to better understand agent performance in your organization.
ms.date: 10/12/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
---

# Conversation Topics dashboard

The Topics dashboard shows a detailed breakdown of conversations and their assigned topics. Customer Service Insights uses AI-generated topics and natural language understanding to automatically group your conversations to help you better understand how different topic areas are impacting your organization’s support performance. 

> [!div class="mx-imgBorder"]
> ![Omnichannel Conversation Topics dashboard.](media/oc-topics.png "Omnichannel Conversation Topics dashboard")

### Access the Topics dashboard

[!INCLUDE[cc-navigation](../includes/cc-navigation.md)]

## Report Details

The key performance indicator summary charts summarize the KPIs for the specified time and the percent change over the period. You can filter these areas by duration, channel, queue, agent, conversation status, and time zone. 

KPIs for the following areas are displayed: 

| KPI | Description |
| ----------- | ------------------------------ |
| Engaged conversations | Offered conversations that are engaged by an agent. Customer-to-agent communication can begin at this point. |
| Avg. conversation handle time (min)  | The average total conversation active time across engaged conversations. |
| Avg. CSAT | The average CSAT score provided by customers from Dynamics 365 Customer Voice survey responses.  |
| Avg. conversation sentiment | The average predicted sentiment of the customer across engaged conversations. |
| Avg. customer effort time (min) | The average time from the start of conversation to the start of the conversation wrap-up time.  |
| Transfer rate | The number of sessions transferred by an agent. |

The topics metrics chart displays the following metrics.

| KPI | Description |
| ---------------- | ------------------- |
| Engaged conversations | Offered conversations that are engaged by an agent. Customer-to-agent communication can begin at this point.  |
| Volume | The total conversation volume from customers. |
| Volume change | The change in conversation volume from customers over the specified duration. |
| Avg. conversation handle time (min) | The average total conversation active time across engaged conversations.  |
| Avg. CSAT | The average CSAT score provided by customers from Customer Voice survey responses. This is only available if Dynamics 365 Customer Voice has been configured as a post-conversation survey tool.  |
| CSAT impact | The impact (downward or upward) that the conversations in the selected topic group are driving the overall organization CSAT. |
| Avg. sentiment | The average of customer sentiment based on verbatim provided in survey responses. Only available if Customer Voice has been configured as a post conversation survey tool. |
| Sentiment impact | The impact (downward or upward) that the conversations in the selected topic group are driving the overall organization sentiment.  |
| Power Virtual Agents icon | Supervisors can use this icon to select the topic for automation to Power Virtual Agents. |

## Conversation Topics drill-down view

The Topics drill-down view provides supervisors with a holistic look into individual topics in reference to key business metrics, and can be valuable in understanding why customers are contacting support.  

To access the drill-down, select any metric value for the topic you're interested in, and then select **Details**.

> [!div class="mx-imgBorder"]
> ![Omnichannel Conversation topic drill down view.](media/oc-conversation-topics-drill-down.png "Omnichannel Conversation topic drill down view")

## Topic automation to Power Virtual Agents

AI-discovered topics in Omnichannel Historical Analytics are often prime candidates as topics for automation in Power Virtual Agents bots. If Power Virtual Agents is available in the region that your Customer Service organization is in, the feature can be enabled by your organization's administrator.  

After a topic is identified as a good automation candidate, the automation workflow can be triggered by selecting Power Virtual Agents on the **Topics** metrics grid or by selecting **Details** and then **Automate to Bot** in the drill -down view. This will open the topic editing form.

Suggested trigger phrases and the topics related to the case title are provided. The first step is to select the Power Virtual Agents bot that's ideal for adding the topic to. If no bot exists, select **Create Bot**. You'll be redirected to the Power Virtual Agents application for bot creation. You can modify both the topic name and trigger phrases, and in the case of trigger phrases; you can add additional ones. After this step is complete, select **Automate Continue** . The Power Virtual Agents topic will redirect to Power Virtual Agents for completion of authoring.

> [!NOTE]
> Bots created through the Microsoft Teams channel won't be listed in the bot selection list.


## Language availability for topics 

The topics capability in the Customer Service historical analytics reports comes with a natural language understanding model that can understand the text semantics and intent in the following languages: 

- English 
- French 
- German 
- Italian 
- Japanese 
- Portuguese 
- Simplified Chinese 
- Spanish 

> [!NOTE]
> While topic discovery is not prevented and still possible in languages that are not listed above, there may be differences in experience for users who leverage topics in unsupported languages.


### See Also

[Conversation dashboard](oc-conversation-dashboard.md)  
[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Agent dashboard](agent-dashboard.md)  
[Bot dashboard](oc-bot-dashboard.md)  
[Manage report bookmarks](manage-bookmarks.md)  
[Tracked keywords in Dynamics 365 Sales](/dynamics365/sales/dynamics365-sales-insights-app-home-page#tracked-keywords)
