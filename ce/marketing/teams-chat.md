---
title: "Preview: Collaborate using built-in Microsoft Teams chat (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to collaborate across your organization using built-in Microsoft Teams chat in Dynamics 365 Marketing."
ms.date: 02/07/2022
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Preview: Collaborate using built-in Microsoft Teams chat

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Creating great marketing content and journeys is a team effort. With Microsoft Teams chat, you can collaborate with your team without leaving the journey canvas or the email editor. For example, after you create an email, you can tag someone to review your content. Or, while creating a journey, you can collaborate with a coworker to decide which data to use in a branch. This gives you the added benefit of seeing feedback over time and being able to refer to previous comments people made.

Dynamics 365 Marketing supports the following Teams collaboration activities:

- **Start a new linked chat conversation**: The chat is automatically linked to the record. This functionality is available by default for the following content and customer journey records:

    **Outbound marketing**
        - Customer journey
        - Email
        - Social post
        - Marketing page
    **Real-time marketing**
        - Customer journey
        - Email
        - SMS
        - Push notification

    > [!NOTE]
    > Your administrator can extend this list in the [Teams chat settings page](teams-chat.md#settings).

-	**Add users to an existing linked chat**: The chat appears as a linked chat for all the users involved in the conversation.
-	**Link an existing chat to a record**: The entire chat conversation will be visible to all the users who are part of the linked chat.
-	**Access all your recent Dynamics 365 chats**: The list pages, such as the opportunities list page, display all of your recent chats that are linked to Dynamics 365 records.
-	**Access all your recent chats**: Your top 200 Teams chat conversations are shown on the list and record pages.
-	**Link an existing channel to a record**: Although the channel is linked to the record, the channel conversations can only be accessed from within Teams.

## Open Teams chats and channels related to a record

Open any content or customer journey record in Dynamics 365 Marketing and select the **Teams chats and channels integration** icon in the upper-right of the page.

The **Teams chats (Preview)** pane opens and displays the following sections in the **Chat** tab:

-	**Chats linked to record** lists Teams chats that either you've linked to the selected record or someone else has linked with you as a participant.
-	**Suggested contacts** lists suggested contacts depending on the users who are working on the record. For more information, go to How contact suggestions work, later in this topic.
-	**Other chats** lists your top 200 chat conversations on Teams. You can select any existing conversation and link it to a record.

The **Channel** tab lists the channels that you've linked to the selected record, and any channels someone else has linked to where you're a participant. If you've linked a record to a channel by using the basic or enhanced collaboration experience, that channel is also listed on this tab.

## How contact suggestions work

The suggested contacts list displays users who are connected or have interacted with the record. Accordingly, a suggested contact can be one or more of the following users, in the given order:

-	If the record is assigned to a user, the owner of the record.
-	If the record is assigned to a team:
    -	The team admin.
    -	Team members who have logged an activity in the record timeline.
-	Users who have linked chats with the record.
-	Other users who have logged an activity in the record timeline.

## View all linked Dynamics 365 chats

Open the list view of a customer journey or content entity (such as email, push notification, SMS, social post, marketing page), and select. All your linked Dynamics 365 chats will appear under **Chats linked to records**.

## Start a linked Teams chat in Dynamics 365

You can start a new linked chat or convert an existing Teams chat into a linked chat to associate the chat with a Dynamics 365 Marketing record.

1. Open a content or customer journey record in Dynamics 365 Marketing and select.The Teams chats (preview) pane opens.
1. Use one of the following methods:
    -	To start a new linked chat with a participant, select New linked chat in the Chats linked to record section.
    -	To start a linked chat with a suggested contact, select More (…) > Start a linked chat with contact in the Suggested contacts section.
    -	To convert an existing chat into a linked chat, select the chat from the Other chats section, and then select More (…) > Link to this record.
The chat name can be automatically set as the record name. To do it, you can ask your administrator to turn on the Use record title as the default chat name for linked chats setting. You can modify the chat name. It's a good idea to provide a meaningful name so that you can identify the chat even when you're in Teams.
1. Add more participants to the chat, if you want to.

All the participants in the linked chat will see the chat when they open the record in Dynamics 365.

## Link a Teams channel to a record

Link relevant Teams channels to a record so that all the members can easily access the linked channels from the record and follow the conversations.

1. Open a content or customer journey record, and . The **Teams chats (Preview)** pane opens.
Alternatively, select **Collaborate** on the command bar to link a channel to the record. For more information, go to Enhanced Collaboration Experience with Microsoft Teams.
1. Select the **Channel** tab. The tab lists the channels that are already linked to the record.
1. Select the **Link channel** icon   in the upper-right corner of the **Teams chats (Preview)** pane. The **Collaborate with Microsoft** Teams dialog opens.
1. To start a new linked channel, select **Create a new connection**.
1. To link an existing channel, select the channel from the list, and then select **Start collaboration**.

## Start a regular or unlinked Teams chat in Dynamics 365

You can start a regular conversation in Dynamics 365 if you don't want to switch to Teams.

While you're in any of the records or in the list pane, select   , and then select the **Compose chat** icon   in the upper-right corner of the **Teams chats (Preview)** pane. This option starts an individual or group chat but doesn't link it to the record.

See also, [Enable or disable Microsoft Teams chat in Dynamics 365 Marketing]().

## Settings

### Enable or disable Microsoft Teams chat in Dynamics 365 Marketing

As an administrator, you can enable the preview to help your users effectively collaborate on their content and customer journey records in Dynamics 365 Marketing without having to leave the application.

### Access Teams chat and collaborate settings in Dynamics 365

To enable Teams chat in Dynamics 365 Marketing, go to the **Teams Chat** settings page by doing the following:

1. Go to collaboration category in your settings.
1. Open Teams Chat settings page.

> [!NOTE]
> Teams chat’s settings are in effect across all customer engagement apps. So, whether you enable the preview from the Marketing app or other Dynamics app, it will be enabled for all the supported apps.

### Enable or disable the preview

1. Access the **Teams chat** settings page.
1. Turn on the **Turn on Microsoft Teams chats inside Dynamics 365 (preview)** toggle.
> [!IMPORTANT]
> You must be a global administrator (tenant administrator) to provide the initial consent. After that, application administrators can enable the preview for other instances.
1. To set the chat title to be used as the record title by default, turn on the **Use record title as the default chat name for linked chats** toggle. Users can change the title if they want.
1. Save the changes.

The preview is now enabled for all the customer engagement apps. You can open a content or customer journey record in Dynamics 365 Marketing and verify whether you're able to view the chats and channels related to the record.

### Selecting areas where you’d like to turn on linked chats

By default, you can create Teams chats linked to the following content and customer journey records:

**Outbound marketing**:
-	Customer journey
-	Email
- Social post
-	Marketing page
**Real-time marketing**:
- Customer journey
-	Email
-	SMS
-	Push notification

Your administrator can extend the list of supported record types if needed. To do it:

1. Go to Settings -> Collaboration section
1. Select **Teams chat** settings page
1. Scroll down to the “Link chats to Dynamics 365 records” section
1. Select “+Add Record Types”
1. Choose record type
1. Select **Save**.