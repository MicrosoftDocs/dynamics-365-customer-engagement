---
title: AI-generated summary for customer service
description: View an AI-generated summary of a customer service conversation and share it in Microsoft Teams.
ms.date: 05/24/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
---
<!-- Please change the title: View and share an AI-generated conversation summary in Teams -->

# View and share an AI-generated conversation summary in Teams (preview)
<!--Please change the H1: View and share an AI-generated conversation summary in Teams (preview) -->

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

Share an AI-generated summary of a customer conversation in Teams to easily collaborate on a case. A summary quickly provides context and relays steps you've already taken to solve the issue.

## View and share a conversation summary

<!-- I'm going to edit based on what I see here, but please confirm that UI elements are named correctly and that all steps have been included. For instance, in my testing, I had to open the Teams chats (preview) pane using the "chat" icon in the top menu bar; it didn't open automatically when I opened a case, as suggested here. Also, I see three icons in the right side pane, Recent Cases, Knowledge, and Similar Cases. Is this where Teams chats (preview) should appear? A screenshot would be really helpful! I've added some as a suggestion, but I don't think my system is set up correctly. -->
When you open a case in the Customer Service workspace, the **Teams chats (preview)** pane appears to the right of the case view.

1. Select **New connected chat**.

    :::image type="content" source="media/cs-ai-generated-summary-new-linked-chat.png" alt-text="Screenshot that shows the New linked chat button in the Teams chats (preview) pane.":::

1. Select a contact to start a chat with.  
    If your administrator has turned on AI and rules-based suggestions, the system suggests contacts you might want to chat with. They include contacts who have experience resolving similar cases, or who are related to the current case. You can select more than one contact if you want to start a group chat.

    :::image type="content" source="media/cs-ai-generated-summary-new-linked-chat-contact.png" alt-text="Screenshot of selecting a contact when linking a chat to a case.":::

    With at least three customer messages to work from, the AI generates a summary of the conversation. (You won't see a summary if the conversation doesn't include at least three messages from the customer.) The summary includes:
    <!-- Definitely would like to see a screenshot of this. -->

    - The key customer problems to solve
    - Any steps you've already taken to resolve the issue

    Before you start the chat, you can:

    - Edit the summary to provide more details.
    - Share feedback about the summary.
    - Clear the **Include introduction message (preview)** checkbox to skip including the summary and start the Teams chat without an introduction.  

    :::image type="content" source="media/cs-ai-generated-summary-new-linked-chat-send-intro.png" alt-text="Screenshot that shows the Include introduction message (preview) checkbox in the Teams chats pane.":::

1. Select **Start chat**.  

## See also

[Set up AI-generated conversation summary in Dynamics 365 Customer Service](cs-enable-ai-generated-summary.md)
