---
title: "Enable sentimental analysis to view in Omnichannel Ongoing Conversation dashboard | MicrosoftDocs"
description: "Instructions to enable sentimental analysis for Omnichannel Ongoing Conversation dashboard in Omnichannel for Customer Service."
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 6/22/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 0faf3fc1-e559-4795-ac93-058bf2874fa5
ms.custom: 
---

# Enable sentiment analysis

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Enable sentiment analysis for supervisors so they can view the real-time sentiment of conversations on **Omnichannel Ongoing Conversation** dashboard in **Omnichannel for Customer Service**. You can enable or disable real-time sentiment through **Sentiment Analysis Settings** in **Omnichannel Administration**.

> [!NOTE]
> Sentiment analysis is enabled by default.

1. Go to *https://yourorganization.dynamics.com/apps* and select the **Omnichannel Administration** app

2. Go to **Settings** > **Sentimental Analysis** and select **Real-Time Sentiment Analysis**

    > [!div class=mx-imgBorder]
    > ![Select sentiment analysis](../media/supervisor-admin-activat-sentiment-analysis.png "Select sentiment analysis")

3. On the **General** tab, select **Enable** as **Yes**

    > [!div class=mx-imgBorder]
    > ![Enable sentiment analysis](../media/supervisor-admin-enable-sentiment-analysis.png "Enable sentiment analysis")

4.  Enable multilanguage sentiment: 

    a. Go to **General** tab

    b. Enable **Yes**

    > [!div class=mx-imgBorder]
    > ![Enable multilanguage sentiment](media/oc-sentiment-enable-multilanguage.png "Enable multilanguage sentiment") 

    This enables scoring of conversations in 40+ additional languages:

    > [!div class=mx-imgBorder]
    > ![Enable multilanguage sentiment](media/oc-sentiment-languages.png "Enable multilanguage sentiment") 

5. Save and close
    
    Sentiment analysis is now enabled and available.


## See also

[Monitor conversations](../supervisor/monitor-conversations.md)
