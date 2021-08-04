---
title: "Using Teams chat in Dynamics 365 | MicrosoftDocs"
description: "Start Teams chat conversations from within Dynamics 365 customer engagement apps and link them to records"
ms.date: 08/13/2021
ms.topic: article
author: lavanyakr01
ms.service: crm-online
ms.author: lavanyakr
manager: shujoshi
---

# Using Teams chat in Dynamics 365

As a Dynamics 365 customer engagement app user, you can start or link chat conversations with a record that you're working on.  

> [!NOTE]
> Your administrator must have enabled this functionality. For more information, see [Admin: Enable or disable the Teams chat in Dynamics 365 (preview)](enable-teams-chat.md).

## Open Teams chats and channels related to a record

Open any Dynamics 365 customer engagement record and select the **Teams chats and channels integration** icon :::image type="icon" source="media/teams-icon.png" border="false":::.

The **Teams chats (preview)** panel opens with the following sections in the **Chat** tab:

- **Chats linked to this *record***

  Lists Teams chats that either you've linked to the selected record or someone else has linked a chat with you as a participant.

- **Suggested chats & contacts**

  Lists suggested contacts depending on the users who are working on the record. For more information, see [How do contact suggestions work?](#how-do-contact-suggestions-work).

- **All recents**

  Lists your top 50 chat conversations on Teams. You can select any existing conversation and link it to a record.

The **Channel** tab lists the channels that either you've linked to the selected record or someone else has linked a channel where you're a participant. If you had linked a record to a channel using a basic or enhanced collaboration experience, that channel is also listed in this tab.

### How do contact suggestions work?

The suggested contacts list displays users who are connected or have interacted with the record. Accordingly, a suggested contact could be one or more of the following users, in the given order:

-   If the record is assigned to a user, owner of the record.

-   If the record is assigned to a team,

    -   Team admin.

    -   Team members who have logged an activity in the record timeline.

-   (Applicable only for opportunity) Sales team members who are connected with the opportunity and have logged an activity in the record timeline.

-   Users who have linked chats with the record.

-   Other users who have logged an activity in the record timeline.

-   (Applicable only for opportunity) All the connected sales team members.

## View all your Dynamics 365 chats

Open the dashboard or list view of any Dynamics 365 Customer engagement table or entity such as, an opportunities list view, and select the **Teams chats and channels integration** icon :::image type="icon" source="media/teams-icon.png" border="false":::. All your linked Dynamics 365 chats will appear under **Most recent Dynamics 365 chats**.

## Start a linked Teams chat in Dynamics 365

You can start a new linked chat or convert an existing Teams chat into a linked chat to associate the chat with a Dynamics 365 record.

1.  Open any Dynamics 365 Customer engagement record and select the **Teams chats and channels integration** icon :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats (preview)** panel opens.

2.  Use one of the following methods:

    1.  To start a new linked chat with a participant, select **New linked chat** in the **Linked to this *record ***section***.***

    2.  To start a linked chat with a **Suggested chat & contact**, select the **More icon (…) &gt; Start a linked chat.**

    3.  To convert an existing chat into a linked chat, select a chat from the **All recents** section. Select the **More icon (…) &gt; Start a linked chat.**

    The chat name uses the record name or the participants' name depending on the configuration that your administrator had chosen. To set the chat name as the record name, you can ask your administrator to turn on the **Use record title as the default chat name for linked chats** setting. You can modify the chat name. Provide a meaningful name to the chat so that you can identify the chat even on Teams.

3.  Add more participants to the chat if you want to.

All the participants in the linked chat will see the chat when they open the record in Dynamics 365.

## Link a Teams Channel to a record

Link relevant Teams channels to a record so that all the members can easily access the linked channels from the record and follow the conversations.

1.  Open any Dynamics 365 Customer engagement record and select the **Teams chats and channels integration** icon :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats (preview)** panel opens.

    Alternatively, select **Collaborate** on the command bar to link a channel to the record. For more information, see [Enhanced Collaboration Experience with Microsoft Teams](teams-collaboration-enhanced-experience.md).

2.  Select the **Channel** tab.

    The tab lists the channels that are already linked to the opportunity.

3.  Select the Link icon at the top-right corner.

    The **Collaborate with Microsoft Teams** dialog opens.

4.  To start a new linked channel, select **Create a new connection**.

5.  To link an existing channel, select the channel from the list and select **Start collaboration**.

## Start a regular or unlinked Teams chat in Dynamics 365

You can start a regular conversation in Dynamics 365 if you don't want to switch to Teams.

While you're in any of the records or in the list panel, click the **Teams chats and channels integration** icon :::image type="icon" source="media/teams-icon.png" border="false"::: and select **New** icon at the top-right corner. This option a starts an individual or group chat but doesn't link it to the record.

### See also
- [Admin: Enable or disable Teams chat in Dynamics 365 (preview)](enable-teams-chat.md)
