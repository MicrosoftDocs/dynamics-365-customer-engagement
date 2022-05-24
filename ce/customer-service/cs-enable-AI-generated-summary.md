---
title: Configure AI-generated summary for customer service
description: Add an AI-generated summary of an ongoing customer conversation in Dynamics 365 Customer Service.
ms.date: 05/24/2022
ms.topic: article
author: gandhamm 
ms.author: mgandham
manager: shujoshi
---

<!-- Please change the title: Set up AI-generated conversation summary in Dynamics 365 Customer Service -->

# Configure AI-generated conversation summary  (preview)
<!--Please change the H1: Set up AI-generated conversation summary (preview) -->

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Agents can collaborate with others directly in Teams while they're working in Dynamics 365 Customer Service. To help them easily recap an ongoing customer interaction, turn on AI-generated conversation summaries. Agents can include a summary when they link a case to a Teams chat or channel. The summary quickly provides context and relays any steps they've already taken.

## Components of an AI-generated conversation summary

The conversation summary feature uses an AI natural language model to summarize a transcript of an active conversation. Summaries are limited to the first 7,000 characters of a transcript.

A summary includes the following components:

- **Issue description** summarizes the key customer problems to solve in a conversation. The model needs at least three customer messages to generate the issue description.

- **Resolution tried** summarizes any troubleshooting steps or possible solutions that agents have tried. If the model can't identify a resolution from the transcript, this section is blank.

## Regional availability and supported languages

AI-generated conversation summary is available in the United States, Europe, and the United Kingdom.

This feature is supported only in English.

For more information, see [Regional availability and service limits for Customer Service](cs-region-availability-service-limits.md).

## Prerequisites

Tenant permissions to enable the enhanced integration with Microsoft Teams feature.

## Turn on AI-generated conversation summary

1. In Customer Service Hub, select the **Service Management** area.

1. In the left pane, under **Collaboration**, select **Embedded chat using Teams**.

1. Under **Link chats to Dynamics 365 records**, select **Conversation**.

1. In **Provide context for new linked chats**, turn on **Introduction message**.

:::image type="content" source="media/cs-ai-generated-summary-settings.png" alt-text="Screenshot of the AI-generated summary settings.":::
<!--Please confirm that this screenshot is accurate. I created it using my demo tenant, which may not be set up the way yours is. Thanks! -->

### See also

[View and share an AI-generated conversation summary in Teams](cs-ai-generated-summary.md)
[Overview of Customer Service workspace](csw-overview.md)  
