---
title: Omnichannel Conversation Topics Dashboard
description: Learn about the Conversation topics dashboard in Omnichannel historical analytics to better understand customer service representative performance in your organization.
ms.date: 06/25/2025
ms.update-cycle: 180-days
ms.topic: conceptual
author: gandhamm
ms.collection: bap-ai-copilot
ms.author: mgandham
ms.reviewer: mgandham
---

# Conversation Topics dashboard

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

> [!NOTE]
> Starting June 20, 2025, the legacy AI topic clustering for conversation topics in Dynamics 365 Customer Service and Dynamics 365 Contact Center is deprecated and will reach the end of support. After August 31, 2025, this feature will be removed, and users won't be able to use it in Dynamics 365 Customer Service and Dynamics 365 Contact Center.

The Topics dashboard shows a detailed breakdown of conversations and their assigned topics. Customer Service Insights uses AI-generated topics and natural language understanding to automatically group your conversations to help you better understand how different topic areas are impacting your organization’s support performance. 

> [!div class="mx-imgBorder"]
> ![Omnichannel Conversation Topics dashboard.](../media/oc-topics.png "Omnichannel Conversation Topics dashboard")

## Report Details

The key performance indicator (KPI) summary charts summarize the KPIs for the specified time and the percent change over the period. You can filter these areas by duration, channel, queue, customer service representatives (service representatives or representatives), conversation status, and time zone. 

KPIs for the following areas are displayed: 

| KPI | Description |
| ----------- | ------------------------------ |
| Engaged conversations | Offered conversations that are engaged by a service representative. Customer-to-representative communication can begin at this point. |
| Avg. conversation handle time (min)  | The average total conversation active time across engaged conversations. |
| Avg. CSAT | The average CSAT score provided by customers from Dynamics 365 Customer Voice survey responses.  |
| Avg. conversation sentiment | The average predicted sentiment of the customer across engaged conversations. |
| Avg. customer effort time (min) | The average time from the start of conversation to the start of the conversation wrap-up time.  |
| Transfer rate | The number of sessions transferred by a service representative. |

The topics metrics chart displays the following metrics.

| KPI | Description |
| ---------------- | ------------------- |
| Engaged conversations | Offered conversations that are engaged by a service representative. Customer-to-representative communication can begin at this point.  |
| Volume | The total conversation volume from customers. |
| Volume change | The change in conversation volume from customers over the specified duration. |
| Avg. conversation handle time (min) | The average total conversation active time across engaged conversations.  |
| Avg. CSAT | The average CSAT score provided by customers from Customer Voice survey responses. This is only available if Dynamics 365 Customer Voice is configured as a post-conversation survey tool.  |
| CSAT impact | The impact (downward or upward) that the conversations in the selected topic group are driving the overall organization CSAT. |
| Avg. sentiment | The average of customer sentiment based on verbatim provided in survey responses. Only available if Customer Voice is configured as a post conversation survey tool. |
| Sentiment impact | The impact (downward or upward) that the conversations in the selected topic group are driving the overall organization sentiment.  |
| Copilot Studio icon | Supervisors can use this icon to select the topic for automation to Copilot Studio. |

## Conversation Topics drill-down view

The Topics drill-down view provides supervisors with a holistic look into individual topics in reference to key business metrics, and can be valuable in understanding why customers are contacting support.  

To access the drill-down, select any metric value for the topic you're interested in, and then select **Details**.

> [!div class="mx-imgBorder"]
> ![Omnichannel Conversation topic drill down view.](../media/oc-conversation-topics-drill-down.png "Omnichannel Conversation topic drill down view")

## Topic automation to Copilot Studio

AI-discovered topics in Omnichannel Historical Analytics are often prime candidates as topics for automation in Copilot agents. If Copilot Studio is available in the region that your Customer Service organization is in, the feature is enabled by your organization's administrator.  

After a topic is identified as a good automation candidate, the automation workflow can be triggered by selecting Copilot Studio on the **Topics** metrics grid or by selecting **Details** and then **Automate to Bot** in the drill -down view. This opens the topic editing form.

Suggested trigger phrases and the topics related to the case title are provided. The first step is to select the Copilot agent that's ideal for adding the topic to. If no AI agent exists, select **Create Bot**. You are redirected to the Copilot Studio application for AI agent creation. You can modify the topic name and trigger phrases. You can also add more trigger phrases.  After this step is complete, select **Automate Continue**. 

> [!NOTE]
> AI agents created through the Microsoft Teams channel won't be listed in the AI agent selection list.


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
> While topic discovery is not prevented and still possible in languages that are not listed in this section, there might be differences in experience for users who use topics in unsupported languages.


### Related information

[Conversation dashboard](oc-conversation-dashboard.md)  
[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Agent dashboard](agent-dashboard.md)  
[Bot dashboard](oc-bot-dashboard.md)  
[Manage report bookmarks](manage-bookmarks.md)  
[Tracked keywords in Dynamics 365 Sales](/dynamics365/sales/dynamics365-sales-insights-app-home-page#tracked-keywords)
