---
title: "Monitor real-time customer sentiment in sessions| MicrosoftDocs"
description: "Learn how to monitor real-time customer sentiment when interacting with customers."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 0D1925AF-3124-404B-A7B6-FCC0C3430CC4
ms.custom: 
---

# Monitor real-time customer sentiment in sessions

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

As an agent, when you interact with the customers using the communication panel, you want to know the customer satisfaction levels in real-time. The analysis of the customer's sentiment helps you to understand the customer's problem and take a course of action to solve the problem. In Omnichannel for Customer Service, as agent, you can now see the customer's satisfaction levels instantly.

## Understand real-time customer sentiment

The sentiment analysis is based on the customer messages sent to you. That is, the recent six messages from the customer is used for the analysis and display the sentiment icon on the communication panel. The analysis is automatic and unbaised that measures the satisfaction levels of the customer.

There are seven sentiment icons.

| Sentiment | Icon |
|--------------------------|---------------------------------------------------|
| Very positive | ![Very positive sentiment](../../media/oceh/sentiment-very-positive.png "Very positive sentiment") |
| Positive | ![Positive sentiment](../../media//oceh/sentiment-positive.png "Positive sentiment") |
| Slightly positive | ![Slightly positive sentiment](../../media/oceh/sentiment-slightly-positive.png "Slightly positive sentiment") |
| Neutral | ![Neutral sentiment](../../media/oceh/sentiment-neutral.png "Neutral sentiment") |
| Slightly negative | ![Slightly negative sentiment](../../media/oceh/sentiment-slightly-negative.png "Slightly negative sentiment") |
| Negative | ![Negative sentiment](../../media/oceh/sentiment-negative.png " Negativesentiment") |
| Very negative | ![Very negative sentiment](../../media/oceh/sentiment-very-negative.png "Very negative sentiment") |

## View real-time customer sentiment

The real-time sentiment is displayed at the top of the communication panel. The icon changes dynamically based on the recent six customer messages sent to you.

When you get an incoming conversation request, you accept the request and communicate with the customer. By default, the sentiment icon is neutral. As you continue to communicate with the customer, the sentiment icon changes dynamically according to the conversation.

> [!div class=mx-imgBorder]
> ![Very positive sentiment](../../media/oceh/sentiment-very-positive-cc.png "Very positive sentiment")

> [!Note]
> The real-time sentiment is shown to you only if the supervisor or administrator has enabled sentiment analysis for a queue where you are added as a member.


> [!div class="nextstepaction"]
> [Next topic: Manage presence status](oceh-set-user-presence-status.md)

## See also

- [Introduction to the agent interface](oceh-introduction-agent-interface-omni-channel-engagement-hub.md)
- [Manage sessions](oceh-manage-sessions.md)
- [Manage applications](oceh-manage-applications.md)
- [View customer summary and know everything about customers](oceh-customer-360-overview-of-the-existing-challenges.md)
- [Search for and share knowledge articles](oceh-search-knowledge-articles.md)
- [Take notes specific to conversation](oceh-take-notes.md)
- [View customer summary for an incoming conversation request](oceh-view-customer-360-incoming-conversation-request.md)