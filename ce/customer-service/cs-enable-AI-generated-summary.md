---
title: Set up AI-generated conversation summary in Dynamics 365 Customer Service
description: Add an AI-generated summary of an ongoing customer conversation in Dynamics 365 Customer Service.
ms.date: 09/19/2022
ms.topic: article
author: gandhamm 
ms.author: mgandham
manager: shujoshi
---

# Set up AI-generated conversation summary (preview)

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

Agents can collaborate with others directly in Teams while they're working in Dynamics 365 Customer Service. To help them easily recap an ongoing customer interaction, you can turn on AI-generated conversation summaries. Agents can include a summary when they connect a case to a Teams chat or channel. The summary quickly provides context and relays any steps they've already taken.

## Components of an AI-generated conversation summary (preview)

The conversation summary feature uses an AI natural language model to summarize a transcript of an active conversation. Summaries are limited to the first 7,000 characters of a transcript.

A summary includes the following components:

- **Issue description**: Summarizes the key customer problems to solve in a conversation. The model needs at least three customer messages to generate the issue description.

- **Resolution tried**: Summarizes any troubleshooting steps or possible solutions that agents have tried. If the model can't identify a resolution from the transcript, this section is blank.

## Regional availability and supported languages

The AI-generated conversation summary is available in the United States, Europe, and the United Kingdom.

This feature is supported only in English.

For more information, see [Regional availability and service limits for Customer Service](cs-region-availability-service-limits.md).

## Prerequisites

Tenant permissions to enable the enhanced integration with Microsoft Teams feature.

## Turn on AI-generated conversation summary

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, in **Agent experience**, select **Collaboration**.
    
    1. In **Embedded chat using Teams**, select **Manage**.
   
   ### [Customer Service Hub](#tab/customerservicehub) 

    1. In the site map, select **Service Management**.

    2. In **Collaboration**, select **Embedded chat using Teams**.

1. In **Connect chats to Dynamics 365 records**, select **Conversation**.

1. In **Conversation settings**, in **New connected chats**, turn on **AI-generated intro note**.

:::image type="content" source="media/cs-ai-generated-summary-settings.png" alt-text="Screenshot of the AI-generated summary settings.":::
<!--Please confirm that this screenshot is accurate. I created it using my demo tenant, which may not be set up the way yours is. Thanks! -->

### See also

[View and share an AI-generated conversation summary in Teams](cs-ai-generated-summary.md)<br>
[Overview of Customer Service workspace](csw-overview.md)  
