---
title: Ask a question
description: Learn how to use the Ask a question feature in Copilot within Customer Service agent apps to enhance efficiency.
author: gandhamm
ms.author: mgandham
ms.reviewer: 
ms.topic: conceptual 
ms.collection:
ms.date: 12/13/2024
ms.custom: bap-template 
---

# Ask a question 

[!INCLUDE[cc-feature-availability-cfs-yes](../../includes/cc-feature-availability-cfs-yes.md)]

When you sign in to any of the Customer Service agent apps, Copilot opens in the right side panel with the **Ask a question** tab ready. Copilot acts as your partner, helping to answer questions without you having to search for the information. Copilot quickly retrieves information, generates summaries for cases, and gets required details about case data, all within the same interface.

> [!IMPORTANT]
> The AI-generated content is a suggestion. It's your responsibility to review and edit the suggested content to make sure it's accurate and appropriate before sharing the responses.


## Prerequisites

- Make sure that your administrator has turned on the Copilot features.
- To use the summarize cases feature, [case summaries through ask a question](../administer/enable-ask-summarize-cases.md) (preview) is enabled.

## Navigation

- In Customer Service workspace or Contact Center workspace, you can access **Ask a question** from the Copilot help pane once you sign in.
- When you sign in to a non-Microsoft CRM, you can generate case summary as follows:
   - Launch the embedded experience and then login to your Dynamics account.
   - In the Copilot help pane that appears, select **Ask a question**.

## Draft questions

You can ask free-form questions just as you'd ask your colleague or supervisor who might know the answers.

With Copilot, you can take the following actions:

- **Ask a direct question**: Copilot shows the most relevant answer from the knowledge sources that your organization has provided.
- **Ask follow-up turn by turn questions**: If Copilot's response isn't immediately useful, you can ask follow-up questions and guide Copilot in a natural, conversational way.
- **Ask Copilot to attempt a better response**: Copilot can also rephrase responses based on more guidance such as, "Can you summarize your response?" or "Can you attempt a response providing details for each of the steps you mentioned?"

:::image type="content" source="../media/copilot-ask-question-mini.png" alt-text="Screenshot of the Ask a question tab in Copilot." lightbox="../media/copilot-ask-question.png":::

## Summarize cases and ask about case data

Based on the app you are using, you can use Copilot to generate case summary and ask about case data from the **Ask a question** tab.

### [Customer Service workspace](#tab/standaloneapps)

 In the Customer Service workspace, Copilot enables you to:

- **Ask to summarize cases** (preview): Copilot generates case summaries directly within the Ask a question tab, allowing you to access them without disrupting your current workflow. The case summary includes key information such as the case title, customer, priority, case type, and description.
- **Ask about case data** (preview): Copilot enables you to access and use case data effectively, resulting in improved case management. You can ask questions about your case data to manage case workload in a better way.

You can make the following types of requests:

- Get details on the high-priority cases for a specified date range.
- Show all high-priority cases.
- Show active escalated cases.
- Show cases that are due soon.
- Show cases due the next day.
- Show active cases that agents own.
- Show my active cases.
- Get the case details.
- Get the case resolution details for a case.
- Show cases for owner {owner name}.
- Show case history.

## [Embedded experience](#tab/embeddedapps)

[!INCLUDE[cc-feature-availability-embed-only](../../includes/cc-feature-availability-embed-only.md)]


If you are using the embed experience or Microsoft 365 Copilot for Service, in a non-Microsoft CRM, the case summary appears as a card on the **Ask a question** tab in the Copilot help pane. Learn more in [Summarize cases](copilot-use-summary.md#summarize-cases-in-non-microsoft-crm).

---

## Use auto prompts

[!INCLUDE [cc-feature-availability-embedded-yes](../../../shared-content/shared/preview-includes/cc-feature-availability-embedded-yes.md)]

When you have an active case or conversation open, Copilot suggests prompts based on the context of the case or the conversation. Copilot generates prompts only for the first question and not for follow-up questions. Copilot generates the prompts as follows:

- For a case, Copilot considers the title, description, notes, and emails linked to the case.
- For a conversation, Copilot considers the intent in the first three messages to generate a prompt, and then every third message to refresh the prompts. You can select a prompt to generate a response.

> [!NOTE]
> Copilot generates auto prompts based on case data in the Customer Service only.


## Use proactive prompts

[!INCLUDE [cc-feature-availability-embedded-yes](../../../shared-content/shared/preview-includes/cc-feature-availability-embedded-yes.md)]

Copilot proactively suggests prompts, without you having to type one, that you can use to prioritize cases effectively and solve customer queries quickly.

- You can use the default prompts, such as **Summarize**, **Ask**, and **Discover** to get started with Copilot, with just a single click. For example, you can select the **Summarize** prompt to get a case summary. After you select **Summarize**, enter the case number to view the case details on the help pane, without having to open the case.
- You can also select **View prompts** which provides the default prompts on demand at any time.   
- You can use Copilot to get summaries of multiple cases in the help pane, that help you decide which case to work on first, based on priority and customer needs.
- When you pick your case or a new conversation to work on, the context of Copilot switches to the particular case and suggests new prompts automatically, without you having to type one. Copilot gathers relevant information and provides you with the information, thereby increasing your efficiency in resolving customer issues.

    :::image type="content" source="../media/proactive-prompting.png" alt-text="Screenshot shows options in proactive prompting.":::

> [!NOTE]
> Copilot generates proactive prompts based on case data in the Customer Service only.

## View responses

Copilot streams the generated responses on the UI incrementally, and you can view the responses as they're generated. You can also select **Stop responding** for Copilot to stop generating responses, allowing you to start afresh.

In the Copilot's response, you can see citation numbers that show the knowledge base or website links from which Copilot drew the response. When you select the citation, you can see an inline link to the source.

## Translate responses

If your administrator enabled translation, you can select **Translate** and then select your preferred language to translate the response to that language. You can also select **Show original** to translate the response back to the original language.

### Use targeted phrases in Copilot to get responses from plugins (preview)

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note-d365.md)]

If your administrator has configured prompt plugins, you can use targeted keywords to gather quick information about the case that you're working on. For example, you can use the following steps to get the account summary of a case. If Copilot doesn't find any details that match the term, then it falls back to the knowledge source to display the resolution from the configured knowledge articles.

1. Open the case that you need to work on and then enter **Get account summary** in the Copilot **Ask a question** pane. If your administrator has configured authentication, the **Authentication needed** message appears on the Copilot screen.
1. Select **Go to authentication**. The **Sign in or connect** dialog appears.
1. Select **Continue**. The system authenticates, and Copilot summarizes and displays the account details of the customer whose case you opened.
1. Select **Check sources**. The plugin that's used for generating the summary is displayed.
1. You can use the options on the Copilot pane to edit or copy, and provide feedback on the response.

    :::image type="content" source="../media/screenshot-of-prompt-plugin-response-in-copilot.png" alt-text="A screenshot of the Copilot response generated through the prompt plugin.":::

### Use the responses

If you're satisfied with the response Copilot provides, you can use the whole thing or a part of it to answer the customer's question:

- Copy part of Copilot's reply into your chat or read from it during a voice conversation. Select the copy icon to copy the entire response to the clipboard.  
- When you're in an active digital messaging conversation, select **Send to customer** to open an editing window where you can revise the response and send it to the customer. You can also change customer keywords to prompt Copilot to generate a more accurate response.
- Select **Check sources** to see the knowledge base or website links from which Copilot drew the response. You can use this supplemental information as a resource or share it with the customer.

### Clear chat to start over

After a customer conversation ends, or if you want Copilot to disregard the conversation so far, select **Clear chat** at the bottom of the Copilot pane.

### Provide feedback

To rate the usefulness of Copilot's responses, select the thumbs-up or thumbs-down icon.

## Related information

[Enable features in Copilot pane](../administer/copilot-enable-help-pane.md)

