---
title: "Sentiment Monitoring | MicrosoftDocs"
description: "Enable sentiment monitoring to understand customer sentiment across channels"
keywords: ""
author: lerobbin
ms.author: lerobbin
manager: autumna
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: c4db5425-1e08-40b7-bfd8-5d6015b5ae6a
ms.custom: 
---

# Sentiment Monitoring

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Omnichannel Sentiment Analysis enables agents and supervisors to understand real-time and historical customer sentiment across channels to improve customer service via the following:

- Natural Language Processing (NLP) and Machine Learning (ML) algorithms to understand customer sentiments. 
- Sentiment intensities and indicators are displayed based on the previous six customer messages. Sentiments are scored in seven intensities: three positive, three negative, and one neutral gradient. 

    > [!div class=mx-imgBorder]
    > ![Sentiment Analysis Chart](../media/oc-sentiment-chart.png "Sentiment Analysis Chart")

- Multilanguage Sentiment is an enhancement to Omnichannel Sentiment Analysis which leverages the power of Microsoft Azure Text Translator API to score support conversations in 40+ languages.  Customers should now be able to see sentiment scores for conversations in 40+ languages (As of October 2019 Public Preview). 

> [!NOTE]
> Multilanguage sentiment scores non-english conversations by (1) Leveraging Microsoft Azure Text Translator API to translate the conversations into English. (2) Scoring the English output.

See [Explore Dynamics 365 Customer Service](https://dynamics.microsoft.com/en-us/customer-service/capabilities/) capabilities for more details.

## Omnichannel Personas

Omnichannel for Customer Service Multilanguage Sentiment is broken out into three (3) personas whose job/tasks are as follows:

1. Administrator
    - Administrators choose whether to enable Sentiment. 
    > [!NOTE]
    > Sentiment is enabled in Omnichannel by default).
    - Administrators choose whether to enable Multilanguage Sentiment.

2. Supervisor (Team Lead)
    - Supervisors are responsible for tracking agent performance and engaging in real-time to continuously improve support quality. 
    
        Example: Identifying negative sentiment events in conversations between agents and customers.

    - When a supervisor identifies negative sentiments, they can provide timely inputs to help an agent resolve an issue 

        Example: Monitor and join the conversation. 

    - Real-time sentiment tracking enables the supervisor to identify chat and SMS sessions that are going well or that require monitoring. 

3. Agent
    - Agents want to know their customers' sentiments in real-time and see customers’ satisfaction levels instantly when communicating. 
    - They can be responsible for handling multiple customer engagements at any given time. 
    - They engage directly with the customer to solve the customer's issue. 
    - Analysis of customer's sentiment helps agents understand problem severity and act. 

## Sentiment Intensity Indicators

Omnichannel Sentiment Analysis sentiment intensity indicators are an automatic and unbiased measurement of satisfaction levels of the customer in real time. These indicators provide agents and supervisors with the ability to see how a conversation is trending and a real-time gauge which supervisors can use to decide when they need to step in and assist. 

- Agents

    Sentiment intensity indicators on the top of the communication panel help the agent understand the customer’s sentiment.

    > [!div class=mx-imgBorder]
    > ![Sentiment Display](../media/oc-sentiment-sentiment-display.png "Sentiment Display")

- Supervisors

    - Sentiment intensity indicators identify ongoing chat sessions that need the supervisor's attention, so that supervisor can better assess and apply their time where it is the most valuable. 

    - Using sentiment intensity indicators on the Omnichannel Ongoing Conversations dashboard allows supervisors to easily identify ongoing customer support chat sessions that are not going well.

    > [!div class=mx-imgBorder]
    > ![Sentiment Conversation Display](../media/oc-sentiment-conversation-dashboard.png "Sentiment Conversation Display")

## Multilanguage Sentiment Limitations

Multilanguage Sentiment relies on the initial customer messages in any conversation to detect the language of the conversation.  

Expect the following system behavior: 

A. If the customer’s initial messages are detected as English, the system assumes that subsequent messages are in English as well. If your customer switches away from English after these initial messages, the system does not perform language re-detection. In this situation, you would most often see a “Neutral” sentiment throughout the rest of the non-English conversation.

B. If the customer’s initial messages are detected as non-English, the system will perform re-detection and scoring for subsequent messages. If any following message is detected as non-English, its subsequent message will be re-detected and scored according to its detected language.

## Requirements 

The minimum app version is required. To upgrade, use the follow the instructions [here](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/omnichannel/administrator/upgrade-omnichannel). 

## Install and Configurations

Once you have signed up, see Step 4 on the [Enable sentiment analysis](https://docs.microsoft.com/en-us/dynamics365/omnichannel/administrator/enable-sentiment-analysis) to configure multilanguage sentiment analysis. 

## Policy Notice 

This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

## See Also

[Enable Sentiment Analysis](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/omnichannel/administrator/enable-sentiment-analysis)

[Monitor real-time customer sentiment](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/omnichannel/agent/agent-oc/oc-monitor-real-time-customer-sentiment-sessions)

[Monitor conversations](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/omnichannel/supervisor/monitor-conversations)








