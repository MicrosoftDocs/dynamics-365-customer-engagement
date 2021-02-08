---
title: "Create quick replies | MicrosoftDocs"
description: "Instructions to set up quick replies in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 02/08/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Create quick replies

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Quick replies are predefined messages that can be created for agents to quickly respond to common questions from customers. For information about the agent's quick reply experience, see [Send predefined messages in chats](oc-conversation-control.md#send-predefined-messages-in-chats).  

1. Sign in to Omnichannel Administration.
2. Go to **Agent Experience** > **Quick replies**.
3. To create a quick reply, select **New**, or to edit an existing quick reply, select the name of the quick reply.
4. Provide or change the following information:

    - **Title:** Enter the title of the message.
    - **Locale:** Specify the language of the message.
    
        > [!NOTE]
        > Omnichannel for Customer Service does not localize quick replies. To provide quick replies in multiple languages, create a separate quick reply for each language and select its corresponding locale.

    - **Message:** Enter the text of the message.

      > [!div class=mx-imgBorder]
      > ![Create a quick reply](media/oc-create-a-quick-reply.png "Create a quick reply")

     The **Message** field supports the following slugs.  

    | Slug | Description |
    |-----------------|-----------------------------|
    | {FullName{Customer}}  | The full name of the customer who initiated the conversation. |
    | {LastName{Customer}}| The last name of the customer.|
    | {FullName{Agent}}| The full name of the agent who is assigned to the conversation.|
    | {FirstName{Agent}}| The first name of the agent.|
    | {LastName{Agent}}| The last name of the agent.|
    | {Nickname{Agent}}| The nickname for the agent.|

      For more information, see [Slugs](../app-profile-manager/automation-dictionary-keys.md#slugs).

5. Select **Save**.

## Create or edit tags for common categories of quick replies

Quick replies can be classified and tagged into categories. The categorization capability can also be leveraged to group quick replies into logical chunks that represent key conversational states for agents. These logical chunks help agents select appropriate messages that correspond to customer issues.

1. Sign in to Omnichannel Administration.

2. Go to **Agent Experience** > **Quick replies**.

3. Select two or more quick replies for which you want to create a tag, and then select **Edit Tags**.

> [!div class=mx-imgBorder]
> ![Active quick replies](media/oc-active-quick-replies.png "Active quick replies")

  The **Edit Tags** dialog box appears.

4. In the **Add new tag** field, start typing the tag you want to create. If it already exists, it will appear in a list below the field. If it doesn’t appear, select the plus **+** sign to add it.

> [!div class=mx-imgBorder]
> ![Add a tag](media/oc-quick-reply-add-tag.png "Add a tag")

5. When finished, select **Close**.

## Associate quick replies with a work stream

For organizations with diverse lines of businesses, agents will send a variety of messages, depending on their area of expertise. Administrators can determine which quick replies are necessary for different groups of agents to use. Administrators can associate quick replies with work streams in order show agents only the quick replies that apply to them. If no work stream is associated, the quick reply is available for all agents.

1. Sign in to Omnichannel Administration.

2. Go to **Agent Experience** > **Quick replies**.

3. Select a quick reply from the list.

4. In the **Workstreams** section, click the ellipsis.

5. Select **Add Existing Work Stream**.

6. Select the work stream from the list of records and then click **Add**.

   The work stream appears in the list.

7. Select **Save** to save your quick reply.

   If you select the work stream in the list, you can view the work stream record, and select the **Quick Replies** tab to view all the quick replies associated with that work stream.
   
## Understand quick reply filtering

The quick replies that agents will see is determined by the following parameters:

- The language mapped to the channel instance
- The language configured in the agent's personal settings
- The workstream the quick reply is mapped to

For example, when you set up live chat (the channel instance), you select the language used for conversations taking place on that chat widget. Then, you associate that chat widget with a queue containing a number of agents. Each agent in the queue has a user interface language associated with him or her. You also set up a workstream with routing rules to send conversations to agents in the queue. Then, to provide quick replies for the agents to use in conversations, you associate them with that workstream.

For live chat, the first filter used to determine which quick replies the agent will see is the chat widget's language. If no language is configured, the next filter is the agent's language. The agent will only see quick replies in his or her configured language. The last filter is based on the quick replies mapped to the current workstream. The agent will see all the quick replies mapped to the workstream in his or her language, plus any quick replies that aren't mapped to a workstream.

For social channels, language is not configured at the channel level, so the system filters the list of quick replies based on the agent's language. As with chat, the agent will only see quick replies that are in his or her configured language and mapped to the current workstream, plus any quick replies that aren't mapped to a workstream.

For more information about language settings for agents, see [Set personal options](https://docs.microsoft.com/en-us/powerapps/user/set-personal-options).

### See also

[Add a chat widget](add-chat-widget.md)  
[Configure a pre-chat survey](configure-pre-chat-survey.md)  
[Create and manage operating hours](create-operating-hours.md)  
[Create chat authentication settings](create-chat-auth-settings.md)  
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)  
