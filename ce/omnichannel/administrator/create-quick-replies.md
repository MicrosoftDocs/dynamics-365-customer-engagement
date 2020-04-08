---
title: "Create quick responses | MicrosoftDocs"
description: "Instructions to set up quick responses in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 04/06/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Create quick responses

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Quick responses are pre-defined messages that can be created for agents to quickly reply to common questions by customers. For information about the agent's quick response experience, see [Send quick responses in the chat](../agent/agent-usd/left-control-panel.md#send-quick-replies-in-the-chat).  

1. Sign in to Omnichannel Administration.
2. Go to **Agent Experience** > **Quick responses**.
3. Select **New** to add a quick reply. To edit an existing quick reply, select the name of the quick reply.
4. Provide or change the following information:

    - **Title**: Enter the title of the message.
    - **Locale**: Specify the locale of the message.

        > [!NOTE]
        > In this release, the **Locale** field can't be edited.

    - **Message**: Enter the text of the message.

        > [!NOTE]
        > This field supports slugs, but the slug editor isn't available in this release.

    > [!div class=mx-imgBorder]
    > ![Create a quick reply](../media/oc-create-a-quick-reply.png "Create a quick reply")

6. Select **Save**.

## Create or edit tags for common categories of quick responses

Quick replies can be classified and tagged into categories. The categorization capability can also be leveraged to group quick replies into logical chunks that represent key conversational states for agents. These logical chunks help agents select appropriate messages that correspond to customer issues.

1. Sign in to Omnichannel Administration.

2.	Go to **Agent Experience** > **Quick responses**.

3.	Select the quick reply or group of replies for which you want to create a tag, and then select **Edit Tags**.

> [!div class=mx-imgBorder]
> ![Create a quick reply](../media/oc-active-quick-replies.png "Create a quick reply")

The **Edit Tags** dialog displays.

4. In the **Add new tag** field, start typing the tag you want to create. If it already exists, it will appear in a list below the field. If it doesn’t appear, select the **+** sign to add it.

> [!div class=mx-imgBorder]
> ![Add a tag](../media/oc-quick-reply-add-tag.png "Add a tag")

5. When finished, select **Close**.

### See also

[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)
