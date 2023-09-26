---
title: Enable summarization of cases and conversations.
description: Learn how to enable summarization of cases and conversations using Copilot.
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to 
ms.collection: get-started 
ms.date: 09/22/2023
ms.custom: bap-template 
---

# Enable Copilot case and conversation summaries

Copilot case and conversation summaries help you to quickly understand the context of a case and resolve customer issues more efficiently.

## Enable case summaries

Case summaries help agents understand the context of a case, enabling them to resolve customer issues efficiently. Agents get a concise summary of the case with the case title, customer, case subject, product, priority, case type, and case description.
 
1. In Customer Service admin center, select **Make Copilot available to agents** in **Copilot help pane (preview)** for Copilot case summaries to be available.
1. Use one of the following navigation options: 
    - **Agent Experience** > **Productivity** > **Summaries**
    - **Operations** > **Insights** > **Summaries**
1. Select **Manage** in **Summaries**.
1. Select **Make case summaries available to agents** to display a summary of the case on the **Case** page. 

Perform the steps in [Display case summary on custom case forms](copilot-powerapps-settings.md) for the Copilot case summary to be displayed on custom case forms.

## Enable conversation summaries

Conversation summaries enable agents to collaborate effectively with other agents and contacts, by enabling agents to easily recap an ongoing chat or a transcribed voice conversation.

For Copilot to automatically trigger a conversation summary for a live conversation, in Customer Service admin center, select the following options on the **Summaries** page:
   - **When an agent joins a conversation**: Generates a summary when an agent joins a conversation. A summary is also generated when the primary agent invites a collaborator and a second agent joins the conversation or when the primary agent transfers a conversation.
   - **When a conversation ends**: Generates a summary when the conversation ends. 
      - Select **Allow agents to create case with a button in the summary** to allow agents to see the **Create case** button in the conversation summary. A new case is created when the agent selects **Create case**.
   - **On demand, by selecting a button to summarize the conversation**: Generate a summary at any point in the conversation, whenever the agent selects the copilot **Summarize conversation**.

## Next steps

[Use Copilot to summarize cases and conversations](copilot-use-summary.md)
[Enable features in Copilot pane](copilot-enable-help-pane.md)