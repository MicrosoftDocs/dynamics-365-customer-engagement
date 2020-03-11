---
title: "Enable sentiment analysis to view in Omnichannel Ongoing Conversation dashboard | MicrosoftDocs"
description: "How to enable sentiment analysis for Omnichannel Ongoing Conversation dashboard in Omnichannel for Customer Service."
author: lalexms
ms.author: lalexms
manager: shujoshi
applies_to: 
  - ""
ms.date: 04/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Analyze real-time customer sentiment

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Sentiment analysis settings in Omnichannel for Customer Service provides agents and supervisors with real-time insight regarding how customers are interacting with agents during chat sessions.

The Sentiment Analysis Settings page contains three sections:

- [Sentiment analysis](#sentiment-analysis)
- [Agent settings](#agent-settings)
- [Supervisor settings](#superviosr-settings)

## Sentiment analysis

To let agents and supervisors see the customer's satisfaction levels instantly while communicating with the customer, you need to enable the sentiment analysis.

> [!NOTE]
> Sentiment analysis is enabled by default.

1. Sign in to **Omnichannel Administration**.

2. Under **Settings**, select **Sentiment Analysis**, and then select **Real-Time Sentiment Analysis**.

3. In the **Sentiment analysis** section, set the **Monitor real-time customer sentiment** toggle to **Yes**, and then select **Save**.

4. Set the **Sentiment drivers reporting** toggle to **Yes**.

  > [!div class=mx-imgBorder]
  > ![Enable sentiment analysis](../media/monitor-real-time.png "Enable sentiment analysis")

After you enable real-time customer sentiment, you can view scores in the [Omnichannel Insights dashboards](configure-historical-sentiment-dashboard-supervisor.md).

## Agent settings

Agents can view the customer sentiment in the communication panel for an conversation session that is active and in focus. For session that is not in focus, the alert is shown on the session panel.

You can show alerts to the agents when a customer's sentiment decreases to or below a particular value. You can set the customer's sentiment to any of the following values:

- Don't show alerts
- Slightly negative
- Negative
- Very negative

For example: You the set the threshold value as **Slightly negative**. When the customer's sentiment reaches **Slightly negative** or any other sentiment value below this, an alert is displayed to agent.

1. Sign in to **Omnichannel Administration**.

2. Under **Settings**, select **Sentiment Analysis**, and then select **Real-Time Sentiment Analysis**.

3. In the **Sentiment analysis** section, set the **Monitor real-time customer sentiment** toggle to **Yes**, and then select **Save**.

  > [!div class=mx-imgBorder]
  > ![Enable sentiment analysis](../media/monitor-real-time-agent.png "Enable sentiment analysis")

To turn off agent alerts, select **Don't show alerts**.

## Supervisor settings

Supervisors can use the **Omnichannel Ongoing Conversation** dashboard to view customer sentiment in real time during conversations between customers and agents.

You can show notifications to the supervisors when a customer's sentiment decreases to or below a particular value. You can set the customer's sentiment to any of the following values:

- Don't show notifications
- Slightly negative
- Negative
- Very negative

For example: You the set the threshold value as **Slightly negative**. When the customer's sentiment reaches **Slightly negative** or any other sentiment value below this, a notification is displayed to the supervisor.

1. Sign in to **Omnichannel Administration**.

2. Under **Settings**, select **Sentiment Analysis**, and then select **Real-Time Sentiment Analysis**.

3. In the **Sentiment analysis** section, set the **Monitor real-time customer sentiment** toggle to **Yes**, and then select **Save**.

  > [!div class=mx-imgBorder]
  > ![Enable sentiment analysis](../media/monitor-real-time-supervisor.png "Enable sentiment analysis")

To turn off supervisor notification, select **Don't send notifications**.


## Multi-language sentiment

Multi-language sentiment scoring is enabled by default. Conversations in more than 40 languages are scored. The languages are listed in the following table.

<table>
<tbody>
<colgroup span = "3">
<col width = "34%"></col>
<col width = "33%"></col>
<col width = "33%"></col>
</colgroup>
<tr>
<td>Arabic<br>
Bulgarian<br>
Chinese (Hong Kong SAR)<br>
Catalan<br>
Chinese Simplified<br>
Chinese Traditional<br>
Croatian<br>
Czech<br>
Danish<br>
Dutch<br>
English<br>
Estonian<br>
Finnish<br>
French<br>
</td>
<td>German<br>
Greek<br>
Hebrew<br>
Hindi<br>
Hungarian<br>
Indonesian<br>
Italian<br>
Japanese<br>
Korean<br>
Latvian<br>
Lithuanian<br>
Malay<br>
Norwegian<br>
Polish<br>
</td>
<td>Portuguese<br>
Romanian<br>
Russian<br>
Serbian (Cyrillic)<br>
Serbian (Latin)<br>
Slovak<br>
Slovenian<br>
Spanish<br>
Swedish<br>
Thai<br>
Turkish<br>
Ukrainian<br>
Vietnamese<br>
</td>
</tbody>
</table>


### See also

[Monitor conversations](../supervisor/monitor-conversations.md)
