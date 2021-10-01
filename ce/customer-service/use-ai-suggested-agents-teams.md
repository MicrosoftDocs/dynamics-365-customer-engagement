---
title: "Collaborate with AI-suggested agents in Microsoft Teams | MicrosoftDocs"
description: "Learn how to use the AI-suggested experts and collaborate with them through Microsoft Teams to resolve cases in Customer Service."
ms.date: 10/04/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Collaborate with AI suggested agents in Microsoft Teams (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

If your administrator has enabled AI suggestions for similar cases and knowledge articles and configured linking of chats to Dynamics 365 records, you can chat with experts who have worked on cases similar to yours and quickly resolve customer issues. To chat with experts, your administrator must also enable the option to collaborate with other agents in Microsoft Teams.

More information: [Configure AI suggestions for contacts in Microsoft Teams](configure-teams-collaboration.md)

## Collaborate with AI-suggested agents in Microsoft Teams

In Customer Service workspace, when you open a case, **Teams chat (Preview)** appears in the app side pane on the right. The conversations pertaining to the most recent cases that are similar to the case you're viewing are displayed.

:::image type="content" source="media/teams-new-linked-chat.png" alt-text="New linked chat option in Teams.":::

If no similar cases exist, a message is displayed that no suggested contacts can be found.

You can do the following:

1. Select **New linked chat**. The following options appear:
   - Option to enter participant agent names to create linked chats.
   - A dropdown list of suggested contacts who worked on similar cases. AI and ruled-based suggested contacts are listed if admins have enabled both the options.
   - If AI suggested contacts is enabled, Resolved similar cases dropdown list is displayed.
   
        :::image type="content" source="media/ai-suggested-contacts-suggestions-dropdown.png" alt-text="AI suggested contacts dropdown list.":::
   
   - Each AI suggested contact is displayed with the following details: 
       - Full name
       - Display picture if available
       - Link to the top similar case, which is displayed under the contact’s full name. “Worked on similar case `<similar case title>`. Agents can select the link to view the similar case.
       - Confidence score that indicates how confident the AI model thinks the suggested contact can help on the active case.
   
   - The confidence score is based on multiple factors:
       - Number of similar cases that the suggested contact resolved.
       - The similarity of the similar cases to the active case.
       - How recent the suggested contact resolved the similar cases.
       - The average time that the suggested contacts use to resolve similar cases.
   
   - Agents can hover over the confidence score to view the details.
   
        :::image type="content" source="media/confidence-score-with-explanation.png" alt-text="Explanation of the confidence score of similar cases.":::
   
   - The default AI suggested contacts list show the top three suggestions. If more contacts are suggested, agents can select **View more** in the dropdown list.
   
   - The option to send an introductory message that summarizes the case and includes details, such as the following:
       - Status
       - Case title
       - Case number
       - Customer
       - Description
       - Priority


2. Type an agent name or select from the suggested contacts. You can select more than one agent and then select **Start chat**.

3. Optionally, you can edit the group name.

4. In the **Other chats** list, you can select **More commands** for a contact, and then select **Link to this Case**. The linked chat is pinned to the pane at the top.

5. Use the filter option to list the chats pertaining to a particular conversation.

The agent who receives the chat message gets a link to the case record for which you started the chat. The agent can select the link and open the case to view the details.

### See also

[View AI-suggested cases and knowledge articles](csw-view-ai-suggested-cases-knowledge-articles.md)  
[Overview of Customer Service workspace](csw-overview.md)  
