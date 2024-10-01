---
title: Use Copilot to solve customer issues
description: Learn about how you can use Copilot in Microsoft Dynamics 365 to enhance your productivity when you work on customer service requests.
ms.date: 09/19/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.collection: bap-ai-copilot
ms.custom: bap-template
---

# Use Copilot to solve customer issues

Copilot is an AI-powered tool that revolutionizes the agent experience in Dynamics 365 Customer Service. It provides real-time assistance to resolve issues faster, handle cases more efficiently, and automate time-consuming tasks so you can focus on delivering high-quality service to your customers.

> [!IMPORTANT]
> The AI-generated content is a suggestion. It's your responsibility to review and edit the suggested content to make sure it's accurate and appropriate before sharing the responses.

## License requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Customer Service Enterprise for summarize cases, ask a question, draft emails, and copilot analytics</li><li>Customer Service add-in (Chat, Digital Messaging, or Voice) for draft a chat response and summarize conversations</li></ul> |

## Prerequisites

- Make sure that your administrator has turned on the Copilot features.
- To use the summarize cases feature, [case summaries through ask a question](../administer/enable-ask-summarize-cases.md) (preview) is enabled.

## Ask a question 

When you sign in to any of the Customer Service agent apps, Copilot opens in the right side panel with the **Ask a question** tab ready. Copilot acts as your partner, helping to answer questions without your having to search for the information. Copilot quickly retrieves information, generates summaries for cases, and gets required details about case data, all within the same interface.

### Draft questions

You can ask free-form questions just as you'd ask your colleague or supervisor who might know the answers.

 :::image type="content" source="../media/copilot-ask-question-mini.png" alt-text="Screenshot of the Ask a question tab in Copilot." lightbox="../media/copilot-ask-question.png":::

With Copilot, you can take the following actions:

- **Ask a direct question**: Copilot shows the most relevant answer from the knowledge sources that your organization has provided.
- **Ask follow-up turn by turn questions**: If Copilot's response isn't immediately useful, you can ask follow-up questions and guide Copilot in a natural, conversational way.
- **Ask Copilot to attempt a better response**: Copilot can also rephrase responses based on more guidance such as, "Can you summarize your response?" or "Can you attempt a response providing details for each of the steps you mentioned?"
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

### Use auto prompts

When you have an active case or conversation open, Copilot suggests prompts based on the context of the case or the conversation. Copilot generates prompts only for the first question and not for follow-up questions. Copilot generates the prompts as follows:

- For a case, Copilot considers the title, description, notes, and emails linked to the case.
- For a conversation, Copilot considers the intent in the first three messages to generate a prompt, and then every third message to refresh the prompts. You can select a prompt to generate a response.

### View responses

Copilot streams the generated responses on the UI incrementally, and you can view the responses as they're generated. You can also select **Stop responding** for Copilot to stop generating responses, allowing you to start afresh.

In the Copilot's response, you can see citation numbers that show the knowledge base or website links from which Copilot drew the response. When you select the citation, you can see an inline link to the source.

### Translate responses

If your administrator enabled translation, you can select **Translate** and then select your preferred language to translate the response to that language. You can also select **Show original** to translate the response back to the original language.

### Use targeted phrases in Copilot to get responses from plugins (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note-d365.md)]

If your administrator has configured prompt plugins, you can use targeted keywords to gather quick information about the case that you're working on. For example, you can use the following steps to get the account summary of a case. If Copilot doesn't find any details that match the term, then it falls back to the knowledge source to display the resolution from the configured knowledge articles.

1. Open the case that you need to work on and then enter **Get account summary** in the Copilot **Ask a question** pane. Copilot summarizes the account details of the customer whose case that you opened and displays it.
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

## Draft a chat response (Preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note-d365.md)]

Use Copilot to draft chat responses when you're in a conversation with a customer.

:::image type="content" source="../media/copilot-responses.png" alt-text="Screenshot of Copilot suggested responses for conversations.":::

### Generate a chat response

Select the one-click response generation button at the lower-right corner of the Conversation control panel and at the lower-left corner of the Copilot pane. Copilot analyzes the context of the conversation and the latest customer question or message, and drafts a response to send directly to the customer. You don't need to manually type the question.

> [!NOTE]
> The one-click response generation feature is available in North America, Europe, and the United Kingdom only.

### Related information

[Understand Copilot language support](copilot-language-support.md)  
[Manage copilot features in Customer Service](../administer/configure-copilot-features.md)  
[Responsible AI FAQ for copilot features](../implement/faq-responsible-ai-copilot.md)   
[FAQ for Copilot in Customer Service](../administer/faq-copilot-features.md)  
