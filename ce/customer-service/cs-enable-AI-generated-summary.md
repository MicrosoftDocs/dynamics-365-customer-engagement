---
title: Set up AI-summarization for conversations in Dynamics 365 Customer Service
description: Add an AI-generated summary of an ongoing customer conversation in Dynamics 365 Customer Service.
ms.date: 09/19/2022
ms.topic: article
author: gandhamm 
ms.author: mgandham
manager: shujoshi
---

# Set up Auto-summarization for conversations (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

> [!NOTE]
> This feature is being rolled out in phases and will be available in all geographical regions by September 30, 2022.

Agents can collaborate with others directly while they're working in Dynamics 365 Customer Service. To help them easily recap an ongoing customer interaction, turn on Auto-summarization for conversations. Agents can generate a conversation summary when they either transfer a conversation, add a user to consult, or start a linked Teams chat. The summary quickly provides context and relays any steps they've already taken.
> [!NOTE]
>  - Auto-summarization for conversations is in preview for messaging channels and voice conversations with transcription enabled.
>  - This feature is generally available for Microsoft Teams conversations.

## Components of an AI generated conversation summary (preview)

The conversation summary feature uses an AI natural language model to summarize a transcript of an active conversation. Summaries are limited to the first 7,000 characters of a transcript.

A summary includes the following components:

- **Issue description**: Summarizes the key customer problems to solve in a conversation. The model needs at least three customer messages to generate the issue description.

- **Resolution tried**: Summarizes any troubleshooting steps or possible solutions that agents have tried. If the model can't identify a resolution from the transcript, this section is blank. If the case is resolved or the conversation ends, the application displays this label as **Resolution**.

## Regional availability and supported languages

The AI-generated conversation summary is available in the United States, Europe, and the United Kingdom.

This feature is supported only in English.

For more information, see [Regional availability and service limits for Customer Service](cs-region-availability-service-limits.md).

## Prerequisites

Tenant permissions to enable the enhanced integration with Microsoft Teams feature.

## Turn on Auto-summarization for conversations (Preview)

1. In Customer Service admin center, select **Insights** in **Operations**.

1. In **Insights**, select **Manage** next to **Auto-summarization for conversations (preview)**.

1. Turn on **Enable auto-summarization for conversations**. If this option is enabled, agents can see **AI summary**  in the communication panel of a session.

1. The **Supported triggers** section is displayed. Select the following options:
  
   - **When an agent joins the conversation** : Auto-generate and display the conversation summary when an agent has joined the conversation. This is applicable to conversations escalated to a human agent from a bot, transferred conversations, or when the agent invites a collaborator.
   - **When the conversation ends** : Auto-generate and display the conversation when the conversation ends.
   - **When an agent starts a linked in Microsoft Teams**: Auto-generate and display the conversation when the agent starts a linked Teams chat. Alternatively, you can select  the **See more settings related to Microsoft Teams integration** link and turn on **Include a note** in the **Case settings** flyout of **Microsoft Teams collaboration and chat**.
   
        :::image type="content" source="media/oc-convo-summary-settings.png" alt-text="Screenshot of the AI-generated summary settings.":::

### Turn on the AI-generated summary for Microsoft Teams collaboration

You can also enable this feature from the Customer Service Hub app. Perform the following steps to enable AI-generated summary for Microsoft Teams and chats:

1. In the site map, select **Service Management**.
2. In **Collaboration**, select **Embedded chat using Teams**.
1. In **Connect chats to Dynamics 365 records**, select **Conversation**.

1.  In **Conversation settings**, in **New connected chats**, turn on **AI-generated intro note**.

:::image type="content" source="media/cs-ai-generated-summary-setting.png" alt-text="Screenshot of the AI-generated summary settings.":::


### See also

[View and share an AI-generated conversation summary in Teams](cs-ai-generated-summary.md)<br>
[Overview of Customer Service workspace](csw-overview.md)  
