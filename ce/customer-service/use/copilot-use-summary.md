---
title: Use Copilot to summarize cases and conversations
description: Learn how agents can use Copilot to summarize cases and conversations in Customer Service workspace.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 03/07/2024
ms.custom: bap-template 
---

# Use Copilot to summarize cases and conversations 

You can use Copilot to summarize cases and conversations if your administrator has enabled this feature.

## Prerequisites

Your administrator has enabled the Copilot conversation summary feature.

## Summarize cases

Copilot case summaries help you quickly understand the context of a case and resolve customer issues more efficiently. The case summary includes key information such as the case title, customer, subject, product, priority, case type, and description.

### Get a case summary

The case summary appears as a card on the case form. When you open a case, the case summary card is collapsed by default so that your screen isn't cluttered with information. Select the card to expand the summary.

:::image type="content" source="../media/copilot-case-summary.png" alt-text="Screenshot of a Copilot case summary.":::

You can copy the summary, refresh it, and provide feedback.

> [!NOTE]
> - You can also generate a case summary for cases that are resolved or canceled.
> - A case summary isn't generated if the descriptions added in the source case fields that Copilot uses are less than 38 words in English, without counting spaces.

## Summarize conversations

Copilot conversation summaries provide context and relay the steps that you took to solve the issue. You can summarize chat and transcribed voice conversations.

> [!NOTE]
> If your administrator has enabled auto-summarization for ongoing conversations, you get an AI-generated summary of the conversation along with the Copilot-generated conversation summary. The two summaries may be slightly different. [Learn more about auto-summarized conversations](cs-ai-generated-summary.md).

### Get a conversation summary

Based on your administrator's configuration, you'll see the following:

- The Copilot conversation summary generated automatically when you request a consultation with another agent, transfer the conversation, or end the conversation. You can select **Summarize conversation** to generate the summary for an ongoing conversation.
- The summary is displayed in a paragraph format or a structured format.
  - The paragraph format summarizes the conversation in a single paragraph.
     :::image type="content" source="../media/copilot-conv-summary.png" alt-text="Screenshot of a Copilot conversation summary.":::
  - The structured format summarizes and organizes the information in the conversation based on the options your administrator has selected. 
     :::image type="content" source="../media/structured-conv-summary.png" alt-text="Screenshot of a structured Copilot conversation summary.":::
       
You can also take the following actions:

- Copy the summary.
- Select **Create case** to create a case and populate the description with the summary, if your administrator has turned on this feature.
- Share feedback about the summary.
- Close the summary card.

## Next steps

[Use Copilot to solve customer issues](use-copilot-features.md)

