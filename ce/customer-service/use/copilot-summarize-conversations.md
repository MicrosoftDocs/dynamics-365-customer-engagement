---
title: Use Copilot to summarize conversations
description: Learn how agents can use Copilot to summarize cases and conversations in Customer Service workspace.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 01/10/2025
ms.custom: bap-template 
---


# Use Copilot to summarize conversations

[!INCLUDE[cc-feature-availability-cfs-yes](../../includes/cc-feature-availability-cfs-yes.md)]

Copilot conversation summaries provide context and relay the steps that you took to solve the issue. You can summarize chat and transcribed voice conversations.

[!INCLUDE[cc-product-information](../../includes/cc-product-information.md)]

## [Standalone](#tab/standaloneapps)

### Prerequisites

Your administrator has enabled the Copilot conversation summary feature.

> [!NOTE]
> If your administrator has enabled auto-summarization for ongoing conversations, you get an AI-generated summary of the conversation along with the Copilot-generated conversation summary. The two summaries may be slightly different. [Learn more about auto-summarized conversations](cs-ai-generated-summary.md).

### View a conversation summary

Based on your administrator's configuration, you'll see the following in Customer Service workspace or Contact Center workspace:

- The Copilot conversation summary generated automatically when you request a consultation with another agent, transfer the conversation, or end the conversation. You can select **Summarize conversation** to generate the summary for an ongoing conversation.
- The summary is displayed in a paragraph format or a structured format.
  - The paragraph format summarizes the conversation in a single paragraph.
     :::image type="content" source="../media/copilot-conv-summary.png" alt-text="Screenshot of a Copilot conversation summary.":::
  - The structured format summarizes and organizes the information in the conversation based on the options your administrator has selected. <br>
     :::image type="content" source="../media/structured-conv-summary.png" alt-text="Screenshot of a structured Copilot conversation summary.":::

You can perform the following actions:

- Copy the summary.
- Select **Create case** to create a case and populate the description with the summary, if your administrator has turned on this feature. 
- Share feedback about the summary.
- Close the summary card.

## [Embedded](#tab/customersummarypage)

  In Contact Center Embed and Microsoft 365 Copilot for Service, conversation summaries are generated for closed conversations as follows:

  In the non-Microsoft CRM, you can generate the case summary as follows:

   - Select the required conversation.
   - Select **Microsoft contact center**. The Copilot help pane appears.
   - In the **Ask a question** tab, select **Summarize case**. The case summary appears in the help pane.

You can copy the summary, refresh it, and provide feedback.

---

## Next steps

[Use Copilot to solve customer issues](use-copilot-features.md)

