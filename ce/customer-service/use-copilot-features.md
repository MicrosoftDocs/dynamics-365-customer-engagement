---
title: Use Copilot features in Customer Service
description: Learn about how you as agents can use the Copilot features to enhance productivity when working on service requests.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection: 
ms.date: 05/26/2023
ms.custom: bap-template
---

# Use Copilot to solve customer issues (preview)

> [!IMPORTANT]
>
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Copilot for Customer Service is an AI-powered tool that revolutionizes the agent experience in Dynamics 365 Customer Service. It provides real-time AI-powered assistance that will help agents resolve issues faster, handle cases more efficiently, and automate time-consuming tasks so that they can focus on delivering high-quality service to their customers.

> [!IMPORTANT]
> The AI-generated content is a suggestion. It's your responsibility to review and edit the suggested content to make sure it’s accurate and appropriate before sharing the responses.

## Prerequisites

Make sure that your administrator has enabled the copilot features.

## Ask a question

When you sign in to any of the Customer Service agent apps, Copilot becomes activated on the right pane with the **Ask a question** tab in focus. Copilot acts as your partner that can help answer questions without you having to search knowledge sources or other articles for information.

### Draft questions

You can ask free-form questions just as you'd ask your colleague or supervisor who might know the answers.

:::image type="content" source="media/copilot-ask-question.png" alt-text="Ask a question in Copilot pane.":::

With Copilot, you can do the following:

- **Ask a direct question**: Copilot will show the relevant answer from the trove of knowledge sources configured by your organization.
- **Ask follow-up turn by turn questions**: If Copilot isn't able to generate the right answer immediately, you can engage in a conversation and guide Copilot to provide the correct answer in a natural, conversational manner.
- **Ask Copilot to attempt a better response**: Copilot can also rephrase responses based on additional guidance such as, “Can you summarize your response?” or “Can you attempt a response providing details for each of the steps you mentioned?”

If you're satisfied with the response that Copilot provides, you can use the whole or a part of it to answer the customer question.

### Use the responses

You can use the Copilot responses in multiple ways, such as:

- Manually copy the parts of Copilot's reply that you find useful into your chat or read out from it during a voice conversation. You can select the copy icon also to directly copy to clipboard.  
- Use the **Send to customer** option, which is available when there's an active digital messaging conversation. When you select **Send to customer**, an editing window opens, within which you can make any modifications to the response provided by Copilot and send the response to the customer directly without having to copy it. You can also change customer keywords, based on which Copilot generates the response to create a more accurate response.
- Select **Check sources** to see the relevant knowledge or website links from which Copilot has drawn the response. You can use this supplemental information as a resource or share it with the customer.

### Clear chat to start over

After a customer conversation has ended, or if you want Copilot to disregard the conversation so far, you can select **Clear chat** at the bottom of the Copilot pane.

### Provide feedback

You can rate the usefulness of the Copilot responses by selecting the thumbs-up or thumbs-down icons.

## Draft emails

With Copilot, you can craft email replies to customers quickly and be more effective in solving customer issues.

:::image type="content" source="media/copilot-email-draft.png" alt-text="Copilot draft emails to select from.":::

### Write an email with Copilot

When you start drafting an email, Copilot automatically opens in the right pane and presents five predefined prompts and one custom prompt as follows:

- **Suggest a call**: Writes a reply that suggests a call with the customer today or tomorrow.
- **Request more information**: Writes a reply to request additional details from the customer to help resolve their problem.
- **Empathize with feedback**: Writes a reply to provide an empathetic response to a customer who voices a complaint about a situation.
- **Provide product/service details**: Writes a reply to offer details or answer customer questions about a particular product or service.
- **Resolve the customer's problem**: Writes a reply to provide a resolution and resolution steps if applicable to the customer problem.
- **Custom**: Allows you to provide your own prompt for the email reply.

### Review and copy suggested replies

After you select one of the predefined prompts, Copilot will generate a suggested email reply. You can review the response, make necessary changes, and then copy it to your email draft by selecting **Copy to email**,  or select the total response or parts of it and use the right-click menu.

### Use the custom prompt

Use the custom prompt to include talking points, determine the length and tone of the email, and your objectives for the email. After entering the necessary information, select the **Create response** arrow to generate the response. You can make changes to the custom prompt above the reply and use **Refresh** to update the response.

### How knowledge base and web sources are used

By default, Copilot uses internal knowledge base sources for generating responses. If your administrator has configured trusted domains, Copilot searches the internal knowledge base and up to five trusted domains to produce the result.

### Start over

To return to the choice of six prompts, you can select **Start over** at the bottom of the pane.

## Draft a chat response

Use Copilot to draft chat responses when you're in a conversation with a customer.

:::image type="content" source="media/copilot-responses.png" alt-text="Copilot suggested responses for conversations.":::

### Generate a chat response

Use the one-click response generation option that's available on the bottom right of the Conversation control panel and on the bottom left of the Copilot pane. When you select this button, Copilot understands the context of the ongoing conversation and the latest customer question or message and drafts a response to send directly to the customer. You don't need to manually type the question.

## Summarize cases

Copilot case summaries are designed to help support agents quickly understand the context of a case, enabling them to resolve customer issues more efficiently. You get a concise summary of the case, which includes key information such as the case title, customer, case subject, product, priority, case type, and case description.

### How to get a Copilot case summary

The case summary appears as a card on the case form. When you open a case, the case summary card is collapsed by default, ensuring that your screen isn't cluttered with information.

Select the card to expand the case summary. This action triggers the loading of the case summary, which is generated based on the key information in the case.

:::image type="content" source="media/copilot-case-summary.png" alt-text="View of the Copilot case summary.":::

You can copy the summary, provide feedback, and refresh the summary.

### See also

[Manage Copilot features in Customer Service](configure-copilot-features.md)  
