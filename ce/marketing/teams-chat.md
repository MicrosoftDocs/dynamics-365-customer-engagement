---
title: "Collaborate using built-in Microsoft Teams chat (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to collaborate across your organization using built-in Microsoft Teams chat in Dynamics 365 Marketing."
ms.date: 09/09/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Collaborate using built-in Microsoft Teams chat

Creating great marketing content and journeys is a team effort. With Microsoft Teams chat, you can collaborate with your team without leaving the journey canvas or the email editor. For example, after you create an email, you can tag someone to review your content. Or, while creating a journey, you can collaborate with a coworker to decide which data to use in a branch. This gives you the added benefits of seeing feedback over time and being able to refer to previous comments people made.

Dynamics 365 Marketing supports the following Teams collaboration activities:

- **Start a new connected chat conversation**: The chat is automatically connected to the record. This functionality is available by default for the following content and customer journey records:

    - **Outbound marketing**
        - Customer journey
        - Email
        - Social post
        - Marketing page
    - **Real-time marketing**
        - Customer journey
        - Email
        - Text message
        - Push notification

    > [!NOTE]
    > Your administrator can extend this list in the [Teams chat settings page](teams-chat.md#settings).

-	**Add users to an existing connected chat**: The chat appears as a connected chat for all the users involved in the conversation.
-	**Connect an existing chat to a record**: The entire chat conversation will be visible to all the users who are part of the connected chat.
-	**Access all your recent Dynamics 365 chats**: List pages, such as the opportunities list page, display all of your recent chats that are connected to Dynamics 365 records.
-	**Access all your recent chats**: Your top 200 Teams chat conversations are shown on the list and record pages.
-	**Connect an existing channel to a record**: Although the channel is connected to the record, the channel conversations can only be accessed from within Teams.

## Open Teams chats and channels related to a record

To access Teams chats, open any content or customer journey record in Dynamics 365 Marketing and select the **Teams chats and channels integration** icon ![Teams chat icon.](media/teams-chat-icon.png "Teams chat icon") on the right of the top menu bar.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Teams chat icon in the menu bar.](media/teams-chat-menu-bar.png "Screenshot of the Teams chat icon in the menu bar")

The **Teams chats** pane opens and displays the following sections in the **Chat** tab:

-	**Chats connected to record** lists Teams chats that either you've connected to the selected record or someone else has connected with you as a participant.
-	**Suggested contacts** lists suggested contacts depending on the users who are working on the record. For more information, see [How contact suggestions work](teams-chat.md#how-contact-suggestions-work) below.
-	**Other chats** lists your top 200 chat conversations on Teams. You can select an existing conversation and connect it to a record.

The **Channel** tab lists the channels that you've connected to the selected record and any channels someone else has connected to where you're a participant. If you've connected a record to a channel using the basic or enhanced collaboration experience, that channel is also listed on this tab.

## How contact suggestions work

The suggested contacts list displays users who are connected with or have interacted with the record. Accordingly, a suggested contact can be one or more of the following users, in the given order:

-	If the record is assigned to a user, the owner of the record.
-	If the record is assigned to a team:
    -	The team admin.
    -	Team members who have logged an activity in the record timeline.
-	Users who have connected chats with the record.
-	Other users who have logged an activity in the record timeline.

## View all connected Dynamics 365 chats

To view all connected chats, open the list view of a customer journey or content entity (such as an email, push notification, text message, social post, or a marketing page) and select the **Teams chats and channels integration** icon ![Teams chat icon.](media/teams-chat-icon.png "Teams chat icon"). All your connected Dynamics 365 chats will appear under **Chats connected to records**.

## Start a connected Teams chat in Dynamics 365

You can start a new connected chat or convert an existing Teams chat into a connected chat to associate the chat with a Dynamics 365 Marketing record.

1. Open a content or customer journey record in Dynamics 365 Marketing and select the **Teams chats and channels integration** icon ![Teams chat icon.](media/teams-chat-icon.png "Teams chat icon"). The **Teams chats pane** opens.
1. Use one of the following methods to start a connected chat:
    -	To start a new connected chat with a participant, select **New connected chat** in the **Chats connected to *record*** section.
    -	To start a connected chat with a suggested contact, go to **More (…)** > **Start a connected chat with *contact*** in the **Suggested contacts** section.
    -	To convert an existing chat into a connected chat, select the chat from the **Other chats** section and then go to **More (…)** > **Connect to this *record***.

    The chat name can be automatically set as the record name. To allow the chat name to be automatically set, ask your administrator to enable the [**Auto-name chats**](teams-chat.md#set-the-default-name-for-connected-chats) setting.

    If you'd like, you can modify the chat name. It's a good idea to provide a meaningful name so that you can identify the chat even when you're in the Teams app.
1. Add more participants to the chat.

All participants in the connected chat will see the chat when they open the applicable record in the Marketing app.

## Connect a Teams channel to a record

Connect relevant Teams channels to a record so that all members can easily access the connected channels from the record and follow conversations. To connect a Teams channel:

1. Open a content or customer journey record, and select the **Teams chats and channels integration** icon ![Teams chat icon.](media/teams-chat-icon.png "Teams chat icon"). The **Teams chats** pane opens.

    Alternatively, select **Collaborate** on the command bar to connect a channel to the record. Learn more: [Enhanced Collaboration Experience with Microsoft Teams](/dynamics365/teams-integration/teams-collaboration-enhanced-experience).
1. Select the **Channel** tab. The tab lists the channels that are already connected to the record.
1. Select the **Connect channel** icon in the upper-right corner of the **Teams chats** pane. The **Collaborate with Microsoft** Teams dialog opens.
1. To start a new connected channel, select **Create a new connection**.
1. To connect an existing channel, select the channel from the list then select **Start collaboration**.

## Start a regular or disconnected Teams chat in Dynamics 365

You can start a regular conversation in Dynamics 365 if you don't want to switch to Teams.

To start a conversation, while you're in any of the records or in the list pane, select the **Teams chats and channels integration** icon ![Teams chat icon.](media/teams-chat-icon.png "Teams chat icon"). Then, select the **Compose chat** icon ![Compose chat icon.](media/teams-chat-compose-chat.png "Compose chat icon") in the upper-right corner of the **Teams chats** pane. This option starts an individual or group chat but doesn't connect it to the record.

## Settings

### Access Teams chat settings in Dynamics 365

To access the Teams chat settings in Dynamics 365 Marketing, go to **Settings** > **Collaboration** > **Teams chat**.

### Enable connecting Dynamics 365 records to Microsoft Teams channels

Go to the **Teams chat** settings, then enable the **Turn on the connecting of Dynamics 365 records to Microsoft Teams channels** toggle.

This allows you to pin records and views from the Marketing app to Teams channels and allows the integration of Dynamics 365 and Teams documents.

In this section of the settings, you can also choose whether to enable enhanced Teams integration (allowing pinning of records and views directly from the Marketing app) and confidential labels (allowing private chats and confidentiality labels).

After changing any settings, make sure to select the **Save** button.

<!---### Select areas where you’d like to enable connected chats

By default, you can create Teams chats connected to the following content and customer journey records:

**Outbound marketing**:
-	Customer journey
-	Email
- Social post
-	Marketing page
**Real-time marketing**:
- Customer journey
-	Email
-	Text message
-	Push notification

Your administrator can extend the list of supported record types if needed. To extend the list:

1. Go to **Settings** > **Collaboration** > **Teams chat**.
1. Scroll down to the **Connect chats to Dynamics 365 records** section.
1. Select **+Add Record Types”**.
1. Choose a record type.
1. Select **Save**.
-->
### Set the default name for connected chats

To set the chat title to be used as the record title by default, enable the **Auto-name chats** toggle in the **Lead settings** area and then select **Save**. Users can later change the title if they want.

[!INCLUDE[footer-include](../includes/footer-banner.md)]