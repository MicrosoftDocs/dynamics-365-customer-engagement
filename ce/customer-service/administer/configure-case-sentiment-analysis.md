---
title: Configure sentiment analysis for case
description: Learn how to configure sentiment analysis for case in Dynamics 365 Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 09/17/2025
ms.topic: concept-article
---

# Configure sentiment analysis for case

Case sentiment provides organizations with a consolidated view of customer sentiment across email, chat, and voice interactions linked to a case. 
This feature helps organizations analyze sentiment patterns to identify
potential escalations before they occur, prioritize cases requiring
immediate attention and enable data-driven decisions to improve service
delivery.

> [!NOTE]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature isn't intended for use in making, and shouldn't be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements.

## Prerequisites

- The CSR Manager and System Administrator role to enable the feature.
- The channels you want to include in the case sentiment such as email, chat, or voice are provisioned.
- [sentiment analysis](enable-sentiment-analysis.md#enable-sentiment-analysis) is enabled.

## Set up sentiment analysis for case

In the Copilot Service admin center, perform the following steps:

1.  Go to **Customer Support** > **Case settings**.
1. On the **Case settings** page, select **Manage** for **Case sentiment (preview)**.
1. On the **Case sentiment (preview)** page, perform the following actions:
    - Select the channels that the case sentiment calculation must reflect.
    -  Select a weightage option:

       - **Equal weightage**: The system automatically assigns equal weights to all selected channels.
       - **Unequal weightage**: Manually assign weights to each channel. The total weightage must equal 100 for accurate sentiment calculation.
    
    - If the channel is deprovisioned or deleted after the weightage is defined for the channel, the application redistributes the weight assigned to the remaining channels.
    
4.  Save and close.
5.  Enable the email sentiment to be displayed on the case as follows:

1.  In the site map, navigate to **Case settings** in one of the following ways:

     - **Agent experience** > **Productivity**
     - **Operations** > **Insights**
     
2.  Select **Manage**.

3.  Select the **Let agents view email sentiments** check box in **Email Sentiments**.

4.  Select **Save**.

5.  Go to **Agent experience** > **Workspaces.**

6.  In **Workspaces**, select **Manage** for **Agent experience profiles**.

7.  Select **Customer Service workspace+inbox-default profile**.

8.  Select **Edit** on the **Inbox** section.

9.  On the **Inbox settings** dialog, do the following:

    1.  Select **Inbox record types** and then select **Case**.

    2.  Select **Add** to add the **Sentiment** field and **Sentiment** icon. Learn more in [Custom card configuration](configure-inbox.md#custom-card-configuration).

## Understand case sentiment calculation

The application calculates case sentiment is calculated considering both the sentiment score of individual interactions linked to the case and their recency. The calculation involves following steps.

 For each channel interaction, calculate the following:

1.  Calculate interaction weight by dividing the weightage of the channel of interaction (voice call/email/chat) by the number of days since the interaction.
1. Calculate sentiment factor by multiplying the interaction sentiment score and interaction weight.
1. Case sentiment is calculated by dividing the sum of all sentiment factors across channels by the sum of all interaction weights across channels.
1. The sentiment score is a numerical representation of the sentiment for use in calculations.

For a chat or a voice conversation, the application calculates the sentiment based on the conversation sentiment at two points in the conversation lifecycle:
 
  - When the conversation is linked to a case.
  - When the conversation is closed.

If email sentiment is enabled, the case sentiment is recalculated with each incoming email.

> [!NOTE]
> - If the administrator disables a channel after the sentiment score is calculated, the application doesn’t recalculate the case sentiment.
> - If the administrator disables email sentiment but email sentiment is still enabled in **Case sentiment (preview)** page, the application displays a warning and redistributes the weight assigned to email sentiment to the other active channels.

### Example

The administrator has set up the weightage for email, chat and voice channels as 50%, 20%, and 30% respectively.

A case has the following interactions:

- An email that was sent to the customer 3 days ago with an email sentiment score of 9.

- A live chat conversation that was closed 2 days ago with a sentiment score of 8.

The application calculates the case sentiment as follows:

| Metric | Email | Chat | Total |
|--------|-------|------|-------|
| **Interaction weight** (channel weight/number of days since the last interaction) | 0.5/3 = 0.1667 | 0.2/2 = 0.1 | 0.2667 |
| **Sentiment score × interaction weight** | 0.1667 × 9 = 1.5 | 0.1 × 8 = 0.8 | 2.3 |
| **Case sentiment** = Total sentiment score / total interaction weight | | | 2.3/0.2667 = 8.6 |

On the case sentiment score range of 7 to 14, where 7 is very negative and 14 being very positive, the sentiment score is 8.6, which indicates that the overall sentiment for the case is slightly negative.

