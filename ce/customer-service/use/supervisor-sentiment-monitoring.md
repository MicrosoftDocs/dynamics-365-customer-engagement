---
title: Sentiment monitoring
description: Learn how supervisors can enable sentiment monitoring to understand customer sentiment across channels and improve customer service.
ms.date: 09/10/2024
ms.topic: article
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Sentiment monitoring

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!NOTE]
> Supervisor and agent sentiment notifications aren't available in Unified Service Desk.

Sentiment analysis enables agents and supervisors to understand real-time and historical customer sentiment across channels to improve customer service. The application uses natural language processing (NLP) and machine learning (ML) algorithms to understand customer sentiments.

Sentiment intensity indicators are displayed based on the previous six customer messages received in a conversation. Sentiment intensity is scored in one of seven gradients: three positive, three negative, and one neutral.

| Sentiment | Icon |
|--------------------------|---------------------------------------------------|
| Very positive | ![Very positive sentiment.](../media/sentiment-very-positive.png "Very positive sentiment") |
| Positive | ![Positive sentiment.](../media/sentiment-positive.png "Positive sentiment") |
| Slightly positive | ![Slightly positive sentiment.](../media/sentiment-slightly-positive.png "Slightly positive sentiment") |
| Neutral | ![Neutral sentiment.](../media/sentiment-neutral.png "Neutral sentiment") |
| Slightly negative | ![Slightly negative sentiment.](../media/sentiment-slightly-negative.png "Slightly negative sentiment") |
| Negative | ![Negative sentiment.](../media/sentiment-negative.png " Negative sentiment") |
| Very negative | ![Very negative sentiment.](../media/sentiment-very-negative.png "Very negative sentiment") |

Sentiment analysis supports multiple languages. Using Microsoft Azure Text Translator API, conversations in more than 40 languages now receive sentiment scores.

> [!NOTE]
> - Non-English conversations are translated to English, then scored. 
> - Unsupported languages don't receive a sentiment score.
> - If profanity is detected in English, the sentiment shows as Negative or Very negative.

To learn more, see [Explore Text Translator API](/azure/cognitive-services/translator/translator-info-overview).

## Personas

The multi-language sentiment feature supports the following personas: administrator, supervisor (team lead), and agent.

- If you're an administrator:

   - You can configure sentiment for English-only and non-English languages.
       > [!NOTE]
       > Sentiment is enabled in by default.

- If you're a supervisor (team lead):

    - You can track agent performance and engage in real time to continuously improve the support quality.
    
        Example: You can identify negative sentiment events, including English profanity, in conversations between agents and customers.

    - When you identify negative sentiment, you can provide timely feedback to the agent to help them resolve an issue.

        Example: Monitor and join the conversation.

    - You can identify which chat and text sessions are going well, and which might require monitoring.

- If you're an agent: 

    - You want to know customer's sentiments in real time and see customer satisfaction levels instantly as you communicate with them.

    - You can be responsible for handling multiple customer engagements at any given time.

    - You can engage directly with the customer to solve the customer's issue.

    - You can use the analysis of customer sentiment to understand the severity of the problem and take action. 

## Sentiment intensity indicators

Sentiment intensity indicators are an automatic and unbiased measurement of a customer's satisfaction level in real time. These indicators show agents and supervisors how a conversation is trending, and give supervisors a real-time gauge to help them decide when they need to step in and assist.

- For agents:

    Sentiment intensity indicators at the top of the communication panel help you understand the customer’s sentiment.

    > [!div class=mx-imgBorder]
    > ![Sentiment display.](../media/oc-sentiment-sentiment-display.png "Sentiment display")

- For supervisors:

    - Sentiment intensity indicators identify ongoing chat sessions that need your attention, so that you can better assess and apply your time where it's most valuable.

    - Using sentiment intensity indicators on the Omnichannel Ongoing Conversations dashboard allows you to easily identify ongoing customer support chat sessions that aren't going well.

    > [!div class=mx-imgBorder]
    > ![Sentiment conversation display.](../media/oc-sentiment-conversation-dashboard.png "Sentiment conversation display")

## Low sentiment notification alert

While an agent is communicating with the customer, if the customer's sentiment decreases to or below a threshold level, you get a notification. The notification displays the following details:

- Agent name
- Customer
- Sentiment
- Monitor button
- Ignore button


    > [!div class=mx-imgBorder]
    > ![Sentiment notification.](../media/sentiment-notification.png "Sentiment notification")

You can select the **Monitor** button to see the **Active Conversation** and the communication panel. If the agent requires help, you can join the conversation.

For example:

An administrator sets the threshold value as **Very negative**. When the customer's sentiment reaches **Very negative** or any other sentiment value below the threshold value, a notification appears.

## Multi-language sentiment limitations

Sentiment analysis relies on the initial customer messages in any conversation to detect the language of the conversation.  

Expect the following system behaviors:

- If a customer's initial messages are detected as English, the system assumes that subsequent messages are in English as well. If your customer switches away from English after these initial messages, the system doesn't perform language redetection. In this situation, you most often see a neutral sentiment score throughout the rest of the non-English conversation.

- If a customer's initial messages are detected as non-English, the system performs redetection and scoring for subsequent messages. If any following messages are detected as non-English, the subsequent messages are redetected and scored according to the detected language.

## Requirements

Your environment must have the latest version of the application.

## Install and configure

After you sign up, see step 4 of [Enable sentiment analysis](../administer/enable-sentiment-analysis.md) to configure sentiment analysis.

## Policy notice

This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature isn't intended for use in making, and shouldn't be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using this feature, and any associated feature or service in compliance with all applicable laws, including laws that relate to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This customer responsibility also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

### Related information

[Enable sentiment analysis](../administer/enable-sentiment-analysis.md)<br>
[Monitor real-time customer sentiment](oc-monitor-real-time-customer-sentiment-sessions.md)<br>
[Monitor conversations](monitor-conversations.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
