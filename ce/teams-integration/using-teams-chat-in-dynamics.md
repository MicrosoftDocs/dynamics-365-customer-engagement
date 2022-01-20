---
title: "Using Teams chat in Dynamics 365 | MicrosoftDocs"
description: "Start Teams chat conversations from within Dynamics 365 customer engagement apps and link them to records"
ms.date: 11/03/2021
ms.topic: article
author: lavanyakr01
ms.service: crm-online
search.app: 
  - D365CE
  - Powerplatform
ms.author: lavanyakr
manager: shujoshi
---

# Preview: Using Microsoft Teams chat in Dynamics 365

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

As a Dynamics 365 customer engagement app user, you can start or link chat conversations with a record that you're working on.  

> [!NOTE]
> Your administrator must have enabled this functionality. For more information, go to [Admin: Enable or disable the Teams chat in Dynamics 365 (preview)](enable-teams-chat.md).

## Open Teams chats and channels related to a record

Open any Dynamics 365 customer engagement record and select the **Teams chats and channels integration** icon :::image type="icon" source="media/teams-icon.png" border="false"::: at the upper-right of the page.

:::image type="content" source="media/teams-chat-dynamics365-view.png" alt-text="Screenshot of the Teams collaboration pane for a selected opportunity.":::

The **Teams chats (Preview)** pane opens and displays the following sections on the **Chat** tab:

- **Chats linked to *record*** lists Teams chats that either you've linked to the selected record or someone else has linked with you as a participant.
    
- **Suggested contacts** lists suggested contacts depending on the users who are working on the record. For more information, go to [How contact suggestions work](#how-contact-suggestions-work), later in this topic.

- **Other chats** lists your top 200 chat conversations on Teams. You can select any existing conversation and link it to a record.

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

## View all linked Dynamics 365 chats

Open the dashboard or list view of any Dynamics 365 customer engagement table or entity, such as an opportunities list view, and select :::image type="icon" source="media/teams-icon.png" border="false":::. All your linked Dynamics 365 chats will appear under **Chats linked to records**.

## Start a linked Teams chat in Dynamics 365

You can start a new linked chat or convert an existing Teams chat into a linked chat to associate the chat with a Dynamics 365 record.

1.  Open any Dynamics 365 customer engagement record and select :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats (preview)** pane opens.

2.  Use one of the following methods:

    -  To start a new linked chat with a participant, select **New linked chat** in the **Chats linked to *record*** section.

    -  To start a linked chat with a suggested contact, select **More (…)** > **Start a linked chat with _contact_** in the **Suggested contacts** section.

    -  To convert an existing chat into a linked chat, select the chat from the **Other chats** section, and then select **More (…)** > **Link to this _record_**.

    The chat name uses the record name or the participant's names, depending on the configuration that your administrator chose. To set the chat name as the record name, you can ask your administrator to turn on the **Use record title as the default chat name for linked chats** setting. You can modify the chat name. It's a good idea to provide a meaningful name so that you can identify the chat even when you're in Teams.

3.  Add more participants to the chat, if you want to.

All the participants in the linked chat will see the chat when they open the record in Dynamics 365.

## Link a Teams channel to a record

Link relevant Teams channels to a record so that all the members can easily access the linked channels from the record and follow the conversations.

1.  Open any Dynamics 365 customer engagement record, and select :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats (preview)** pane opens.

    Alternatively, select **Collaborate** on the command bar to link a channel to the record. For more information, go to [Enhanced Collaboration Experience with Microsoft Teams](teams-collaboration-enhanced-experience.md).

2.  Select the **Channel** tab. The tab lists the channels that are already linked to the record.

3.  Select the **Link channel** icon :::image type="icon" source="media/link-channel-icon.png" border="false"::: in the upper-right corner of the **Teams chats (preview)** pane.

    The **Collaborate with Microsoft Teams** dialog opens.

4.  To start a new linked channel, select **Create a new connection**.

5.  To link an existing channel, select the channel from the list, and then select **Start collaboration**.

## Start a regular or unlinked Teams chat in Dynamics 365

You can start a regular conversation in Dynamics 365 if you don't want to switch to Teams.

While you're in any of the records or in the list pane, select :::image type="icon" source="media/teams-icon.png" border="false":::, and then select the **Compose chat** icon :::image type="icon" source="media/compose-chat-icon.png" border="false"::: in the upper-right corner of the **Teams chats (preview)** pane. This option starts an individual or group chat but doesn't link it to the record.

### See also

[Enable or disable Microsoft Teams chat in Dynamics 365](enable-teams-chat.md)