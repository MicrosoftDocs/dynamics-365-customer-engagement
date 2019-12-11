---
title: "Enable sentiment analysis to view in Omnichannel Ongoing Conversation dashboard | MicrosoftDocs"
description: "How to enable sentiment analysis for Omnichannel Ongoing Conversation dashboard in Omnichannel for Customer Service."
author: lalexms
ms.author: lalexms
manager: shujoshi
applies_to: 
  - ""
ms.date: 12/13/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Enable sentiment analysis

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Enable sentiment analysis for supervisors to view the real-time sentiment of conversations on the **Omnichannel Ongoing Conversation** dashboard in **Omnichannel for Customer Service**. You can enable or disable real-time sentiment through **Sentiment Analysis Settings** in **Omnichannel Administration**.

> [!NOTE]
> Sentiment analysis is enabled by default.

1. Go to *https://yourorganization.dynamics.com/apps* and select the **Omnichannel Administration** app.

2. Go to **Settings** > **Sentiment Analysis** and select **Real-Time Sentiment Analysis**.

    > [!div class=mx-imgBorder]
    > ![Select Sentiment analysis](../media/supervisor-admin-activat-sentiment-analysis.png "Select Sentiment analysis")

3. On the **General** tab, set **Monitor real-time customer sentiment** to **Enabled** and then click **Save**.


    <!--from editor: Note that the image shows Enabled as No. Is that OK? -->
    

    > [!div class=mx-imgBorder]
    > ![Enable sentiment analysis](../media/monitor-real-time.png "Enable sentiment analysis")

After you enable real-time customer sentiment, you can view scores in the [Omnichannel Insights Dashboard](https://docs.microsoft.com/en-us/dynamics365/omnichannel/administrator/configure-historical-sentiment-dashboard-supervisor).

Multi-language sentiment scoring is enabled by default.

Conversations in more than 40 languages are scored:

    > [!div class=mx-imgBorder]
    > ![Language list](../media/oc-sentiment-langauge-list.png "Language list") 




## See also

[Monitor conversations](../supervisor/monitor-conversations.md)
