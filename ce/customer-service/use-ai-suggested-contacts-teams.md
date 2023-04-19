---
title: "Collaborate with AI-suggested agents in Microsoft Teams | MicrosoftDocs"
description: "Learn how to use the AI-suggested experts and collaborate with them through Microsoft Teams to resolve cases in Customer Service."
ms.date: 01/18/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Collaborate with AI-suggested contacts in Microsoft Teams

If your administrator has enabled AI suggestions for similar cases and configured the ability to connect chats to Dynamics 365 records, you can view suggested contacts who have resolved cases similar to yours to help you more quickly resolve customer issues. To chat with AI-suggested contacts, your administrator must also enable the option to collaborate with other contacts in Microsoft Teams.

> [!NOTE]
> Through Teams, agents can connect and engage with customers also if Omnichannel for Customer Service is enabled.

More information: [Configure AI suggestions for contacts in Microsoft Teams](configure-teams-collaboration.md)

## Collaborate with AI-suggested contacts in Microsoft Teams

The AI-suggested contacts in Microsoft Teams functionality is applicable for cases and support conversations in the Customer Service workspace and Omnichannel for Customer Service apps.

For a case or a support conversation, **Teams chat** appears in the app side pane on the right. 

:::image type="content" source="media/teams-new-linked-chat.png" alt-text="New connected chat option in Teams.":::

You can do the following:

1. Select **New connected chat**. The following options appear:
   - An option to enter participant agent names to create connected chats.
   - A dropdown list of suggested contacts who have worked on similar and related cases. AI and rules-based suggested contacts are listed if admins have enabled both of these options.
   - If the AI-suggested contacts functionality is enabled, a **Resolved similar cases** section is displayed in the dropdown list.
   
        :::image type="content" source="media/ai-suggested-contacts-suggestions-dropdown.png" alt-text="AI suggested contacts dropdown list.":::
        
        > - If no similar cases exist, a message is displayed that no suggested contacts can be found.
        > - If the administrator hasn't enabled **Join chat** feature, a message is displayed that only chat participants can see this conversation. More information: [Configure the ability for users to join chats](configure-teams-chat.md#configure-the-ability-for-users-to-join-chats)
   
   - Each AI-suggested contact is displayed with the following details: 
       - Full name
       - Display picture if available
       - Link to the top similar case, which is displayed under the contact’s full name. “Worked on similar case `<similar case title>`. Agents can select the link to view the similar case.
       - Confidence score that indicates how confident the AI model thinks the suggested contact can help on the active case or conversation.
   
   - The confidence score is based on multiple factors:
       - Number of similar cases that the suggested contact resolved.
       - The similarity of the similar cases to the active case or conversation.
       - How recent the suggested contact resolved the similar cases.
       - The average time that the suggested contacts use to resolve similar cases.
   
   - Agents can hover over the confidence score to view the details.
   
        :::image type="content" source="media/confidence-score-with-explanation.png" alt-text="Explanation of the confidence score of similar cases.":::
   
   - The default AI-suggested contacts list shows the top three suggestions. If more contacts are suggested, agents can select **View more** in the dropdown list.
   

2. Type a participant name or select from the suggested contacts. You can select more than one contact and then select **Start chat**.

3. Optionally, you can edit the group name.

If the Teams chat is created for an active case, the participants who receive the chat message get a link to the case record for which you started the chat. The participant can select the link and open the case to view the details.

### See also

[View AI-suggested cases and knowledge articles](csw-view-ai-suggested-cases-knowledge-articles.md)  
[Overview of Customer Service workspace](csw-overview.md)  
[Use Microsoft Teams chat in Sales Hub](../sales/teams-integration/using-teams-chat-in-dynamics.md)  
