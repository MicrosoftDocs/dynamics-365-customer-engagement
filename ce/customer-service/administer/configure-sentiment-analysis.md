---
title:  Configure sentiment analysis for emails (preview)
description: Learn how to configure sentiment for emails in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 01/20/2026
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.custom: bap-template 
---

# Configure sentiment analysis for emails (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]


Email sentiment analysis enables agents and supervisors to understand customer emotions and attitudes expressed in email communications, both in real-time and historically, to improve customer service response strategies. The application uses natural language processing (NLP) and machine learning (ML) algorithms to automatically analyze the emotional tone and sentiment expressed in customer emails.

The application displays sentiment intensity indicators based on the content and tone of incoming customer emails. Email sentiment intensity is scored across seven gradients: three positive levels, three negative levels, and one neutral level, providing granular insight into customer emotional states.

Email sentiment analysis supports multiple languages. Using Microsoft Azure Text Translator API, emails written in more than 40 languages are automatically translated and receive sentiment scores, ensuring comprehensive coverage of global customer communications.

> [!NOTE]
> - Non-English conversations are translated to English, then scored.
> - Unsupported languages don't receive a sentiment score.
> - If profanity is detected in English, the sentiment shows as Negative or Very negative.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

You have the CSR Manager and System Administrator role to enable the feature.

## Add connections and enable power automate flow

1.  Go to make.powerapps.com.
1.  In **Connection references**, add the following connection references:
    - **Microsoft Copilot Studio EmailSentiment-aec03**  
         :::image type="content" source="../media/copilot-studio-email-sentiment.png" alt-text="Image of Copilot Studio email sentiment connection reference" lightbox="../media/copilot-studio-email-sentiment.png":::

    - **Microsoft Dataverse EmailSentiment02869b**
         :::image type="content" source="../media/dataverse-email-sentiment.png" alt-text="Image of Dataverse email sentiment connection reference" lightbox="../media/dataverse-email-sentiment.png":::
      
1.  Go to **Cloud flows** and turn on the **EmailSentiment** flow.  
       :::image type="content" source="../media/email-sentiment-flow.png" alt-text="Image of EmailSentiment cloud flow" lightbox="../media/email-sentiment-flow.png":::
    
1.  Publish your changes.

## Enable email sentiment analysis

In the Customer Service admin center or Contact Center admin center app, perform the following steps:

1. In the site map, navigate to **Copilot for questions and emails** in one of the following ways:
     - **Support experience** > **Productivity**
     - **Operations** > **Insights**
1. Select **Manage**.
1. Select the **Let agents view email sentiments** check box in **Email Sentiments**.
1. Select **Save**.

## Configure sentiment analysis in inbox

1. Go to **Support experience** > **Workspaces.**
1. In **Workspaces**, select **Manage** for **Agent experience profiles**.
1. Select **Customer Service workspace+inbox-default profile**.
1. Select **Edit** on the **Inbox** section.
1. On the **Inbox settings** dialog, do the following:
     1. Select **Inbox record types** and then select **Email**.
     1. Select the ellipsis to add the **Sentiment** field and **Sentiment** icon. Learn more in [Custom card configuration](configure-inbox.md#custom-card-configuration).

### Related information

[View email sentiment (preview)](/power-apps/user/view-compose-email#view-email-sentiment-preview)
