---
title: Configure sentiment analysis for case (preview)
description: Learn how to configure case sentiment analysis in Dynamics 365 Customer Service by selecting channels, assigning weights, and understanding sentiment calculation.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.date: 03/26/2026
ms.topic: concept-article
---

# Configure sentiment analysis for case (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Case sentiment provides organizations with a consolidated view of customer sentiment across email, chat, and voice interactions linked to a case. 
This feature helps organizations analyze sentiment patterns to identify potential escalations before they occur, prioritize cases requiring immediate attention, and enable data-driven decisions to improve service delivery.

> [!NOTE]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature isn't intended for use in making, and shouldn't be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]


## Prerequisites

- The CSR Manager and System Administrator role to enable the feature.
- The channels you want to include in the case sentiment such as email, chat, or voice are provisioned.
- [sentiment analysis](enable-sentiment-analysis.md#enable-sentiment-analysis) is enabled.

## Enable case sentiment setting definition

1. In [Power Apps](https://make.powerapps.com/), select the Default Solution in **Solutions**.
1. Search and select the **Enable Case Sentiment** setting definition. Learn more in [Update a setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition)
1. On the **Edit Enable Case Sentiment** pane that appears, select **Add existing value** in **Setting environment value**.
1. Set the value to **Yes**.
1. Save and publish the changes.


## Set up sentiment analysis for case

In the Copilot Service admin center, perform the following steps:

1.  Go to **Customer Support** > **Case settings**.
1. On the **Case settings** page, select **Manage** for **Case sentiment (preview)**.
1. On the **Case sentiment (preview)** page, perform the following actions:
    - Select the channels that the case sentiment calculation must reflect. You can select one or more of the following channels:
       - **Voice**
       - **Chat**
       - **Email**. This option is enabled only if **Email sentiments (preview)** is enabled. To enable email sentiment, perform the following steps:
           - Select **Manage** for **Agent experience** > **Productivity**> **Copilot for questions and emails** or **Operations** > **Insights** > **Copilot for questions and emails**.
           - Select **Email sentiments (preview)**.
           - Select **Save**.
    -  Select a weightage option:

       - **Equal weightage**: The system automatically assigns equal weights to all selected channels.
       - **Unequal weightage**: Manually assign weights to each channel. The total weightage must equal 100 for accurate sentiment calculation.
    
    - If the channel is deprovisioned or deleted after you define its weight, the application redistributes that weight across the remaining channels.
    
4.  Save and close.

## Display case sentiment

For customer service representatives to view the case sentiment, you must perform the steps in the following sections. 

### Add case sentiment to case form

For case sentiment to be visible on the case form, perform the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, select **Case**, and then select **Forms**.
1. Select the required form to which you want to add the case sentiment.
1. From **Table columns** on the right, select **Sentiment** and add it to the form. Learn more in [Add columns to a form](/power-apps/maker/model-driven-apps/add-move-or-delete-fields-on-form#add-columns-to-a-form).
1. In the **Properties** tab for **Sentiment**, perform the following steps:  
     - Select **Components** > **Get more components**.
     - Search for and select **CaseSentimentControl**
     - Select **Add**.
1. Save and publish the changes.

### Add case sentiment to case grid view

For case sentiment to be visible on the case grid view, do the steps in [Add columns to the case grid](enable-case-grids.md#add-columns-to-the-case-grid) to add the **Sentiment** column to the view.

### Add case sentiment to agent inbox

For case sentiment to be visible on the agent inbox, perform the following steps:

1. Go to **Agent experience** > **Workspaces**.
1. In **Workspaces**, select **Manage** for **Agent experience profiles**.
1. Select **Customer Service workspace+inbox-default profile**.
1. Select **Edit** on the **Inbox** section.
1. On the **Inbox settings** dialog, do the following:
    1. Select **Inbox record types** and then select **Case**.
    1. Select **Add** to add the **Sentiment** field and **Sentiment** icon. Learn more in [Custom card configuration](configure-inbox.md#custom-card-configuration).


## Understand case sentiment calculation

The application calculates case sentiment considering both the sentiment score of individual interactions linked to the case and the recency of those interactions. For each channel, the application performs the following steps:

1. **Calculate the interaction weight** by dividing the channel weight (voice call, email, or chat) by the number of days since the interaction occurred.
1. **Calculate the sentiment factor** by multiplying the interaction sentiment score by the interaction weight.
1. **Calculate the case sentiment** by dividing the total of all sentiment factors across channels by the total of all interaction weights across channels.

The sentiment score is a numerical value that the application uses only for calculation.

For a chat or a voice conversation, the application recalculates the case sentiment based on the conversation sentiment only when the conversation is closed and the conversation transcript is generated.
 
If email sentiment is enabled, the case sentiment is recalculated with each incoming email.

> [!NOTE]
> - If the administrator disables a channel after the sentiment score is calculated, the application doesn’t recalculate the case sentiment.
> - If the administrator disables email sentiment but email sentiment is still enabled in **Case sentiment (preview)** page, the application displays a warning and redistributes the weight assigned to email sentiment to the other active channels.
> - When you change the case in an email's regarding field, case sentiment is recalculated for both the original and new cases. For example, if you move Email 1 from Case 1 to Case 2, the application recalculates the sentiment for both cases. Case 1 sentiment no longer includes Email 1, while Case 2 sentiment now includes Email 1.

### Example

You configure the weights for email, chat, and voice channels as 50%, 20%, and 30% respectively.

A case has the following interactions:

- An email that was sent to the customer 3 days ago with an email sentiment score of 9.

- A live chat conversation that was closed two days ago with a sentiment score of 8.

The application calculates the case sentiment as follows:

| Metric | Email | Chat | Total |
|--------|-------|------|-------|
| **Interaction weight** (channel weight/number of days since the last interaction) | 0.5/3 = 0.1667 | 0.2/2 = 0.1 | 0.2667 |
| **Sentiment score × interaction weight** | 0.1667 × 9 = 1.5 | 0.1 × 8 = 0.8 | 2.3 |
| **Case sentiment** = Total sentiment score / total interaction weight | | | 2.3/0.2667 = 8.6 |

The case sentiment score is 8.6, based on a range of 7 to 14, where 7 is very negative and 14 is very positive. This score indicates that the overall sentiment for the case is slightly negative.

