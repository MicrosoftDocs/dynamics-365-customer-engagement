---
title: Enable summarization of cases and conversations
description: Learn how to enable summarization of cases and conversations using Copilot in Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 03/07/2024
ms.custom: bap-template 
---

# Enable Copilot case and conversation summaries

Copilot case and conversation summaries help you to quickly understand the context of a case and resolve customer issues more efficiently.


## Enable case summaries

Case summaries help agents understand the context of a case, enabling them to resolve customer issues efficiently. Agents get a concise summary of the case with the case title, customer, case subject, product, priority, case type, and case description. Email activity records, notes linked to a case, and conversation summaries are also used to generate the case summary.

> [!IMPORTANT]
> - A minimum of 50 [tokens](https://platform.openai.com/docs/introduction) are required to generate a case summary. 50 tokens translate to approximately 38 words in English, without counting spaces. Therefore, you'll need a minimum of 38 English words specified across the case fields that copilot uses to generate the case summary.
> - Bot conversations aren't automatically included in the conversation summary.
 
1. In Customer Service admin center, select **Ask a question** in **Copilot for questions and emails** for Copilot case summaries to be available.
1. Use one of the following navigation options: 
    - **Agent Experience** > **Productivity** > **Summaries**
    - **Operations** > **Insights** > **Summaries**
1. Select **Manage** in **Summaries**.
1. Select **Make case summaries available to agents** to display a summary of the case on the **Case** page. 
1. Select **Manage data** to [modify the source case fields that Copilot uses to generate case summaries](copilot-map-custom-fields.md). 
1. Select **Specify information to exclude** and email and text that you want Copilot to exclude when generating responses. You can specify up to 10 email addresses and three disclaimers, headers, or footers within the email that you want Copilot to ignore. For example, you might not want to include automatic notification emails in your case summary. You can add the email address and Copilot won't use those emails to generate case summaries.<br>

Perform the steps in [Display case summary on custom case forms](copilot-powerapps-settings.md) for the Copilot case summary to be displayed on custom case forms. 

## Enable conversation summaries

Conversation summaries enable agents to collaborate effectively with other agents and contacts, by enabling agents to easily recap an ongoing chat or a transcribed voice conversation.

For Copilot to automatically generate a conversation summary for a live conversation, in Customer Service admin center, select the following options on the **Summaries** page:
   - **When an agent joins a conversation**: Generates a summary when an agent joins a conversation. A summary is also generated when the primary agent invites a collaborator and a second agent joins the conversation or when the primary agent transfers a conversation.
   - **When a conversation ends**: Generates a summary when the conversation ends. 
      - Select **Allow agents to create case with a button in the summary** to allow agents to see the **Create case** button in the conversation summary. A new case is created when the agent selects **Create case**.
   - **On demand, by selecting a button to summarize the conversation**: Generate a summary at any point in the conversation, whenever the agent selects the copilot **Summarize conversation** in the conversation panel.
   - Select [**Manage format**](customize-copilot-conv-summary.md) to  the change the format in which the conversation summary is displayed to agents.

### Related information

[Use Copilot to summarize cases and conversations](../use/copilot-use-summary.md)<br>
[Enable features in Copilot pane](copilot-enable-help-pane.md)
