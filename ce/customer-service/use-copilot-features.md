---
title: Use Copilot to solve customer issues
description: Learn about how you can use Copilot in Microsoft Dynamics 365 to enhance your productivity when you work on customer service requests.
ms.date: 09/26/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.collection: 
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

Make sure that your administrator has turned on the copilot features.

## Ask a question (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]


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

## Draft emails (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

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

## Draft a chat response (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]


Use Copilot to draft chat responses when you're in a conversation with a customer.

:::image type="content" source="media/copilot-responses.png" alt-text="Screenshot of Copilot suggested responses for conversations.":::

### Generate a chat response

Select the one-click response generation button at the lower-right corner of the Conversation control panel and at the lower-left corner of the Copilot pane. Copilot analyzes the context of the conversation and the latest customer question or message, and drafts a response to send directly to the customer. You don't need to manually type the question.

> [!NOTE]
> The one-click response generation feature is available in North America, Europe, and the United Kingdom only.

## Apply filters

You can setup filters for Copilot to generate responses based on a specific set of topics. Filters provide immediate context and reduce the chance of getting irrelevant responses.

For example, your organization has several departments and you work only on credit card related queries. If you apply the credit card filter, Copilot retrieves only the relevant credit card content from the knowledge source and which is then used to generate responses. 

To apply a filter, perform the following steps:

- Select **Filters** on the Copilot (preview) pane. The **Select filters** menu appears.
- Select the required options. You can also search for a filter option.
- Select **Apply**.

Once you set a filter, the following actions are applicable:
- A message indicating the filters are applied when Copilot generates new responses appears on the Copilot (preview) pane. This message also appears whenever you modify the filter configuration.
- A visual indicator with the number of filter options selected is displayed next to **Filters**..
- The filters set apply to the following Copilot features: ask a question, draft a chat, and email.
- The filter is saved. You don't have to set the filter each time you log in.

### See also

[Manage copilot features in Customer Service](configure-copilot-features.md)  
[Responsible AI FAQ for copilot features](faq-copilot-for-customer-service.md)  
