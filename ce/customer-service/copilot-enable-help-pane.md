---
title: Enable features in Copilot pane
description: Learn how to enable features that appear in the Copilot help pane to increase agent productivity in Customer Service workspace.
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to 
ms.collection: 
ms.date: 10/20/2023
ms.custom: bap-template 
---

# Enable features in Copilot pane

The Copilot help pane allows agents to use Copilot features such as respond to questions, compose an email, and draft a chat response in Customer Service workspace.

> [!NOTE]
> Respond to questions and compose an email features are generally available in the North America region only. These features are in preview in the rest of the supported regions.

Perform the following steps to enable the Copilot features in Customer Service admin center:

1. Use one of the following navigation options:
      - **Agent Experience** > **Productivity** > **Copilot help pane**
      - **Operations** > **Insights** > **Copilot help pane**
1. Select **Manage** in **Copilot help pane**. The Copilot help pane (preview) page appears. You can select the Copilot features you'd like to enable for agents on this page.

  :::image type="content" source="media/copilot-admin-email-mini.png" alt-text="Screenshot of ask a question in Copilot pane." lightbox="media/copilot-admin-email.png":::

## Features supported with different knowledge sources

The following table summarizes the Copilot features supported for a configured knowledge source.

| Feature|Knowledge base | External web resources |
|-------|----------|---------|--------|
|Ask a question |✔|X|
|Write an email | ✔|✔|
|Draft a response |✔|✔|

## Enable ask a question

Select **Make Copilot available to agents** in the **Copilot help pane** page of Customer Service admin center. The **Ask a question** tab on the **Copilot help pane** appears when agents sign in to Customer Service workspace. Agents can ask questions conversationally, and Copilot answers the questions based on the internal and external knowledge base sources and trusted domains.

## Enable draft a response (Preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

Select **For customer chat** in the **Copilot help pane** page of Customer Service admin center. The one-click response generation button appears on both the conversation panel for a conversation and on the **Ask a question** tab on the Copilot help pane in Customer Service workspace. Copilot understands the context and drafts the response based on the knowledge resources configured for your organization.

## Enable write an email 

Select **For email** in the **Copilot help pane** page of Customer Service admin center. The **Write an email** tab appears on **Copilot help pane** in Customer Service. Copilot helps agents create email responses based on the context of the case.

## Add trusted webpages as sources

You can select **Add web address** in **Web resources** to add trusted domains. You can add up to five trusted web domains for Copilot to search and generate responses from. Copilot searches for information up to two levels down from the configured domain.

Copilot uses articles that are two nodes down the configured domain.

> [!NOTE]
> - The knowledge base content is refreshed every day.
> - Web domains are used by Copilot to only draft emails and chat replies.

## Set up filters

Filters enable Copilot to generate responses based on a specific set of topics. You can set up filters for ask a question and draft a response features by sending an email a request to d365_csaipreview@microsoft.com. See: [Apply filters](use-copilot-features.md#apply-filters).

## Next steps
[Use Copilot to solve customer issues](use-copilot-features.md)
