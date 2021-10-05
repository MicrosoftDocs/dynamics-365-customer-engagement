---
title: "Using Teams chat in Dynamics 365 | MicrosoftDocs"
description: "Start Teams chat conversations from within Dynamics 365 customer engagement apps and link them to records"
ms.date: 10/05/2021
ms.topic: article
author: lavanyakr01
ms.service: crm-online
search.app: 
  - D365CE
  - Powerplatform
ms.author: lavanyakr
manager: shujoshi
---

# Using Microsoft Teams chat in Dynamics 365 (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

As a Dynamics 365 customer engagement app user, you can start or link chat conversations with a record that you're working on.  

> [!NOTE]
> Your administrator must have enabled this functionality. For more information, go to [Admin: Enable or disable the Teams chat in Dynamics 365 (preview)](enable-teams-chat.md).

## Open Teams chats and channels related to a record

Open any Dynamics 365 customer engagement record and select the **Teams chats and channels integration** icon :::image type="icon" source="media/teams-icon.png" border="false":::.<!--note from editor: I think this icon would be a lot easier to see if it were black on white (just my opinion). I also am a bit confused by the following image. I'd expect it to highlight this icon, not that random-seeming line in the chat. I assume that all the names in this image are from sample data? And that "2715 Ash Dr." is okay for the Alpine Ski House address? The chat itself makes no sense, but I suppose that's okay.-->

:::image type="content" source="media/teams-chat-dynamics365-view.PNG" alt-text="Screenshot of the Teams collaboration panel for a selected opportunity.":::

The **Teams chats (preview)** panel opens and displays the following sections on the **Chat** tab:

- **Chats linked to this *record*** lists Teams chats that either you've linked to the selected record or someone else has linked with you as a participant.
    
- **Suggested chats & contacts** lists suggested contacts depending on the users who are working on the record. For more information, go to [How contact suggestions work](#how-contact-suggestions-work), later in this topic.

- **All recent**<!--note from editor: To match the screenshot. Or is the image wrong?--> lists your top 50 chat conversations on Teams. You can select any existing conversation and link it to a record.

The **Channel** tab lists the channels that you've linked to the selected record, and any channels someone else has linked to where you're a participant. If you've linked a record to a channel by using the basic or enhanced collaboration experience, that channel is also listed on this tab.

### How contact suggestions work

The suggested contacts list displays users who are connected or have interacted with the record. Accordingly, a suggested contact can be one or more of the following users, in the given order:

-   If the record is assigned to a user, the owner of the record.

-   If the record is assigned to a team:

    -   The team admin.

    -   Team members who have logged an activity in the record timeline.

-   *(Applicable only for an opportunity)* Sales team members who are connected with the opportunity and have logged an activity in the record timeline.

-   Users who have linked chats with the record.

-   Other users who have logged an activity in the record timeline.

-   *(Applicable only for an opportunity)* All the connected sales team members.

## View all your Dynamics 365 chats

Open the dashboard or list view of any Dynamics 365 customer engagement table or entity, such as an opportunities list view, and select :::image type="icon" source="media/teams-icon.png" border="false":::. All your linked Dynamics 365 chats will appear under **Most recent Dynamics 365 chats**.

## Start a linked Teams chat in Dynamics 365

You can start a new linked chat or convert an existing Teams chat into a linked chat to associate the chat with a Dynamics 365 record.

1.  Open any Dynamics 365 customer engagement record and select :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats (preview)** panel opens.

2.  Use one of the following methods:

    -  To start a new linked chat with a participant, select **New linked chat** in the **Linked to this *record*** section.

    -  To start a linked chat with a suggested contact, select **More (…)** > **Start a linked chat** in the **Suggested chats & contacts** section.

    -  To convert an existing chat into a linked chat, select the chat from the **All recent** section, and then select **More (…)** > **Start a linked chat**.

    The chat name uses the record name or the participant's names, depending on the configuration that your administrator chose. To set the chat name as the record name, you can ask your administrator to turn on the **Use record title as the default chat name for linked chats** setting. You can modify the chat name. It's a good idea to provide a meaningful name so that you can identify the chat even when you're in Teams.

3.  Add more participants to the chat, if you want to.

All the participants in the linked chat will see the chat when they open the record in Dynamics 365.

## Link a Teams channel to a record

Link relevant Teams channels to a record so that all the members can easily access the linked channels from the record and follow the conversations.

1.  Open any Dynamics 365 customer engagement record, and select :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats (preview)** panel opens.

    Alternatively, select **Collaborate** on the command bar to link a channel to the record. For more information, go to [Enhanced Collaboration Experience with Microsoft Teams](teams-collaboration-enhanced-experience.md).

2.  Select the **Channel** tab. The tab lists the channels that are already linked to the record.

3.  Select the **Link** icon<!--note from editor: It would be good to use an image here.--> in the upper-right corner.

    The **Collaborate with Microsoft Teams** dialog opens.

4.  To start a new linked channel, select **Create a new connection**.

5.  To link an existing channel, select the channel from the list, and then select **Start collaboration**.

## Start a regular or unlinked Teams chat in Dynamics 365

You can start a regular conversation in Dynamics 365 if you don't want to switch to Teams.

While you're in any of the records or in the list panel, select :::image type="icon" source="media/teams-icon.png" border="false":::, and then select the **New** icon<!--note from editor: Here also.--> in the upper-right corner. This option starts an individual or group chat but doesn't link it to the record.

### See also

[Admin: Enable or disable Microsoft Teams chat in Dynamics 365 (preview)](enable-teams-chat.md)