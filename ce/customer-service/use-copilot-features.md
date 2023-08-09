---
title: Use Copilot to solve customer issues (preview)
description: Learn about how you can use Copilot in Microsoft Dynamics 365 to enhance your productivity when you work on customer service requests.
ms.date: 07/24/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.collection: 
ms.custom: bap-template
---

# Use Copilot to solve customer issues (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

Copilot is an AI-powered tool that revolutionizes the agent experience in Dynamics 365 Customer Service. It provides real-time assistance to resolve issues faster, handle cases more efficiently, and automate time-consuming tasks so you can focus on delivering high-quality service to your customers.

> [!IMPORTANT]
> The AI-generated content is a suggestion. It's your responsibility to review and edit the suggested content to make sure it's accurate and appropriate before sharing the responses.

## Prerequisites

Make sure that your administrator has turned on the copilot features.

## Ask a question

When you sign in to any of the Customer Service agent apps, Copilot opens in the right side panel with the **Ask a question** tab ready. Copilot acts as your partner, helping to answer questions without your having to search for the information.

### Draft questions

You can ask free-form questions just as you'd ask your colleague or supervisor who might know the answers.

:::image type="content" source="media/copilot-ask-question.png" alt-text="Screenshot of the Ask a question tab in Copilot.":::

With Copilot, you can take the following actions:

- **Ask a direct question**: Copilot shows the most relevant answer from the knowledge sources your organization has made available.
- **Ask follow-up turn by turn questions**: If Copilot's response isn't immediately useful, you can ask follow-up questions and guide Copilot in a natural, conversational way.
- **Ask Copilot to attempt a better response**: Copilot can also rephrase responses based on more guidance such as, "Can you summarize your response?" or "Can you attempt a response providing details for each of the steps you mentioned?"

### Use the responses

If you're satisfied with the response Copilot provides, you can use the whole thing or a part of it to answer the customer's question:

- Copy part of Copilot's reply into your chat or read from it during a voice conversation. Select the copy icon to copy the entire response to the clipboard.  
- When you're in an active digital messaging conversation, select **Send to customer** to open an editing window where you can revise the response and send it to the customer. You can also change customer keywords to prompt Copilot to generate a more accurate response.
- Select **Check sources** to see the knowledge base or website links from which Copilot drew the response. You can use this supplemental information as a resource or share it with the customer.

### Clear chat to start over

After a customer conversation has ended, or if you want Copilot to disregard the conversation so far, select **Clear chat** at the bottom of the Copilot pane.

### Provide feedback

To rate the usefulness of Copilot's responses, select the thumbs-up or thumbs-down icon.

## Draft emails

With Copilot, you can draft email replies to customers quickly and be more effective in solving customer issues.

:::image type="content" source="media/copilot-email-draft.png" alt-text="Screenshot of the Copilot Write an email tab.":::

### Write an email with Copilot

When you start to draft an email, Copilot opens in the right side panel and presents five predefined prompts and one custom prompt:

- **Suggest a call**: Drafts a reply that suggests a call with the customer today or tomorrow.
- **Request more information**: Drafts a reply that requests more details from the customer to help resolve the problem.
- **Empathize with feedback**: Drafts a reply that provides an empathetic response to a customer who expresses a complaint.
- **Provide product/service details**: Drafts a reply that offers details or answers customer questions about a particular product or service.
- **Resolve the customer's problem**: Drafts a reply that provides a resolution&mdash;and resolution steps, if applicable&mdash;to the customer's problem.
- **Custom**: Allows you to provide your own prompt for the reply.

### Review and copy suggested replies

When you select one of the predefined prompts, Copilot generates a suggested reply. *Always review the response.* Make any necessary changes, and then select **Copy to email** to copy the entire response to your draft. Or, select part of the response and use the right-click menu to copy and paste the selection.

### Use the custom prompt

Use the custom prompt to include talking points, provide your objectives for the email, and determine its length and tone. Then select the **Create response** arrow to generate the response. *Always review the response* before sharing it with your customer. You can revise the custom prompt, if needed, above the reply and select **Refresh** to update the response.

### How Copilot uses knowledge base and web sources

By default, Copilot uses internal knowledge base sources for generating responses. If your administrator has set up trusted domains, Copilot searches the internal knowledge base and up to five trusted domains to produce the result.

### Start over

To return to the choice of six prompts, select **Start over** at the bottom of the Copilot pane.

## Draft a chat response

Use Copilot to draft chat responses when you're in a conversation with a customer.

:::image type="content" source="media/copilot-responses.png" alt-text="Screenshot of Copilot suggested responses for conversations.":::

### Generate a chat response

Select the one-click response generation button at the lower-right corner of the Conversation control panel and at the lower-left corner of the Copilot pane. Copilot analyzes the context of the conversation and the latest customer question or message, and drafts a response to send directly to the customer. You don't need to manually type the question.

> [!NOTE]
> The one-click response generation feature is available in North America, Europe, and the United Kingdom only.

## Summarize cases

Copilot case summaries help you to quickly understand the context of a case and resolve customer issues more efficiently. The case summary includes key information such as the case title, customer, subject, product, priority, case type, and description.

### Get a case summary

The case summary appears as a card on the case form. When you open a case, the case summary card is collapsed by default so that that your screen isn't cluttered with information. Select the card to expand the summary.

:::image type="content" source="media/copilot-case-summary.png" alt-text="Screenshot of a Copilot case summary.":::

You can copy the summary, refresh it, and provide feedback.

## Summarize conversations

Copilot conversation summaries provide context and relay the steps that you've already taken to solve the issue. You can summarize chat and transcribed voice conversations.

> [!NOTE]
> If your administrator has turned on auto-summarization for ongoing conversations, you get an AI-generated summary of the conversation along with the Copilot-generated conversation summary. The two summaries may be slightly different. [Learn more about auto-summarized conversations](cs-ai-generated-summary.md).

### Get a conversation summary

Depending on the triggers your administrator has set up, the Copilot conversation summary is generated like this:

- Automatically when you request a consultation with another agent, transfer the conversation, or end the conversation.
- When you select **Summarize conversation** in an ongoing conversation.

:::image type="content" source="media/copilot-conv-summary.png" alt-text="Screenshot of a Copilot conversation summary.":::

You can also take the following actions:

- Copy the summary.
- Select **Create case** to create a case and populate the description with the summary, if your administrator has turned on this feature.
- Share feedback about the summary.
- Close the summary card.

### See also

[Manage copilot features in Customer Service](configure-copilot-features.md)  
[Responsible AI FAQ for copilot features](faq-copilot-for-customer-service.md)  
