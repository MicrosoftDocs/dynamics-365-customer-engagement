---
title: Set up auto-summarization for conversations in Dynamics 365 Customer Service
description: Add an AI-generated summary of an ongoing customer conversation in Dynamics 365 Customer Service.
ms.date: 01/21/2025
ms.topic: article
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.collection: bap-ai-copilot
---

# Set up auto-summarization for conversations

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


Customer service representatives (service representatives or representatives) can collaborate with other representatives and contacts directly while they're working in Dynamics 365 Customer Service. To help representatives easily recap an ongoing customer interaction, turn on auto-summarization for conversations. Representatives can generate a conversation summary when they either transfer a conversation, add a user to consult, or start a linked Teams chat. The summary quickly provides context and relays any steps taken.

## Components of an auto-summarize conversations

The conversation summary feature uses an AI natural language model to summarize a transcript of an active conversation. Summaries are limited to the first 7,000 characters of a transcript.

A summary includes the following components:

- **Issue description**: Summarizes the key customer problems to solve in a conversation. The model needs at least three customer messages to generate the issue description.

- **Resolution tried**: Summarizes any troubleshooting steps or possible solutions that representatives have tried. If the model can't identify a resolution from the transcript, this section is blank. If the case is resolved or the conversation ends, the application displays this label as **Resolution**.

## Regional availability and supported languages

The auto-summarization of conversations is available in United States and Europe.

This feature is supported only in English.


## Prerequisites

Tenant level access to enable the enhanced integration with Microsoft Teams feature.

## Turn on auto-summarization for conversations

1. In the site map of Customer Service admin center, select **Operations** > **Insights**.

1. In **Insights**, select **Manage** next to **Auto-summarization for conversations**.

1. Turn on **Enable auto-summarization for conversations**. When you enable this option, representatives can see **AI summary**  in the communication panel of a session.

1. The **Supported triggers** section is displayed. Select the following options to define when you want the conversations to be summarized:
  
   - **When an agent joins the conversation**: To display the conversation summary when a representative has joined the conversation. This is applicable to conversations escalated to a representative from an agent, transferred conversations, or when the representative invites a collaborator.
   - **When the conversation ends**: To display the summary when the conversation ends.
   - **When an agent starts a linked chat in Microsoft Teams**: To display the summary when the representative starts a linked Teams chat. Alternatively, you can select the **See more settings related to Microsoft Teams integration** link and turn on **Include a note** in the **Case settings** flyout of **Microsoft Teams collaboration and chat**.
   
        :::image type="content" source="../media/oc-convo-summary-settings.png" alt-text="Screenshot of the AI-generated summary settings.":::

### Turn on the auto-summarization of Microsoft Teams conversations

Perform the following steps to enable auto-generated summary for Microsoft Teams chats:

1. In the site map of Customer Service admin center, select **Collaboration**, and then select **Embedded chat using Teams**.

1. In **Connect chats to Dynamics 365 records**, select **Conversation**.

1. In **Conversation settings**, in **New connected chats**, turn on **AI-generated intro note**.

:::image type="content" source="../media/cs-ai-generated-summary-setting.png" alt-text="Screenshot of the AI-generated summary settings for Teams conversations.":::


### Related information

[View and share an AI-generated conversation summary in Teams](../use/cs-ai-generated-summary.md)<br>
[Overview of Customer Service workspace](../implement/csw-overview.md)  
[Regional availability and service limits for Customer Service](cs-region-availability-service-limits.md)
