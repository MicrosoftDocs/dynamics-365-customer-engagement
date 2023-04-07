---
title: "Use Teams chat in Sales Hub | MicrosoftDocs"
description: "Start Teams chat conversations from within Sales Hub and connect them to records"
ms.date: 03/31/2023
ms.topic: article
author: sbmjais
ms.author: shjais
---

# Use Microsoft Teams chat in Sales Hub

Start Teams chat conversations from within Sales Hub and connect them to records.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, Dynamics 365 Team Members, or any Dynamics 365 customer engagement app license</li> <li>Microsoft Teams license</li></ul>  <br>More information: <ul><li>[Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/)</li><li>[Microsoft Teams pricing](https://www.microsoft.com/microsoft-teams/compare-microsoft-teams-options?activetab=pivot:primaryr2&rtc=1)</li><li>[Dynamics 365 Team Members](/dynamics365/get-started/team-members-license)</li><li>[Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)</li></ul> |
| **Security roles** | <ul><li>Any primary sales role, such as salesperson, or sales manager</li><li>Any role that has access to a Dynamics 365 record</li></ul> <br>  More information: [Primary sales roles](../security-roles-for-sales.md#primary-sales-roles)|

## Overview

You can now engage in a Teams chat conversation from within Sales Hub. While you're working on a sales record, you can start a new Teams chat or connect an existing chat to the record, and thus collaborate efficiently without switching context. Connecting all the associated chats to the record helps you maintain all the conversations related to the record in one place.

> [!NOTE]
> - When you associate a Teams channel to a record, the channel gets connected to the record. However, unlike chat conversations, channel conversations can't be accessed from within Dynamics 365.
> - Your administrator must have enabled this functionality. For more information, go to [Enable or disable the Teams chat in Dynamics 365](enable-teams-chat.md).
> - For the embedded Teams chat functionality to work properly, ensure that web browser settings allow pop-ups for the Dynamics website.


You can do the following Teams collaboration activities from Dynamics 365:

- **Start a new connected chat conversation**: The chat gets automatically connected to the record.

- **Add users to an existing connected chat**: The chat appears as a connected chat for all the users involved in the conversation.

- **Connect an existing chat to a record**: The entire chat conversation will be visible to all the users who are part of the connected chat.

- **Access all your recent Dynamics 365 chats**: The list pages, such as the opportunities list page, display all of your recent chats that are connected to Dynamics 365 records.

- **Access all your recent chats**: Your top 200 Teams chat conversations are listed on the list and record pages.

- **Connect an existing channel to a record**: Although the channel is connected to the record, the channel conversations can only be accessed from within Teams. 

- **Join an existing connected chat**: View and easily join chats that are connected to a record you have write access to, even if you weren't originally a participant in the chat.

- **Navigate to a record from a connected chat**: Navigate to a related record directly from the connected chat.


## Open Teams chats and channels related to a record

Open any Dynamics 365 customer engagement record and select the **Teams chats and channels integration** icon :::image type="icon" source="media/teams-icon.png" border="false"::: at the upper-right of the page.

:::image type="content" source="media/teams-chat-dynamics365-view.png" alt-text="Screenshot of the Teams collaboration pane for a selected opportunity.":::

The **Teams chats** pane opens and displays the following sections on the **Chat** tab:

- **Chats connected to *record*** lists Teams chats that either you've connected to the selected record or someone else has connected with you as a participant.
    
- **Other chats** lists your top 200 chat conversations on Teams. You can select any existing conversation and connect it to a record.

The **Channel** tab lists the channels that you've connected to the selected record, and any channels someone else has connected to where you're a participant. If you've connected a record to a channel by using the basic or enhanced collaboration experience, that channel is also listed on this tab.

## View all connected Dynamics 365 chats

Open the dashboard or list view of any Dynamics 365 customer engagement table, such as an opportunities list view, and select :::image type="icon" source="media/teams-icon.png" border="false":::. All your connected Dynamics 365 chats will appear under **Chats connected to _record_**. The chats display the record names to which they are connected and the latest chat message. You can navigate to a related record from the connected chat. For more information, see [Navigate to a record from a connected chat](#navigate-to-a-record-from-a-connected-chat).

## Start a connected Teams chat in Dynamics 365

You can start a new connected chat or convert an existing Teams chat into a connected chat to associate the chat with a Dynamics 365 record.

1.  Open any Dynamics 365 customer engagement record and select :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats** pane opens.

2.  To start a new connected chat with a participant, select **New connected chat** in the **Chats connected to *record*** section.

3. Use one of the following methods to add participants:

    - In the **Participants** field, browse and select the names of the participants you want to chat with.
    - A list of suggested contacts is automatically displayed for the **Participants** field. Select a participant's name from the **Suggested contacts** list. The **Suggested contacts** list displays the contacts of the users who are working on the record. More information: [How contact suggestions work](#how-contact-suggestions-work)

    The chat name uses the record name or the participant's names, depending on the configuration that your administrator chose. To set the chat name as the record name, you can ask your administrator to turn on the **Use record title as the default chat name for connected chats** setting. You can modify the chat name. It's a good idea to provide a meaningful name so that you can identify the chat even when you're in Teams.

4. After adding the participants, select **Start chat**.

All the participants in the connected chat will see the chat when they open the record in Dynamics 365.

### How contact suggestions work

The suggested contacts capability helps you to quickly find the right coworkers to collaborate with. This collaboration can help you more quickly work on sales queries.

If you don't see suggested contacts for a record type, your administrator might not have turned on the suggested contacts capability for the record type. Ask your administrator to turn on the capability for that record type.

For the case record type, there are two types of contact suggestions: AI and rules-based. Other record types enabled for connected chats may only have rules-based suggestions.

The suggested contacts list displays users who are connected or have interacted with the record. Accordingly, a suggested contact can be one or more of the following users, in the given order:

-   If the record is assigned to a user, the owner of the record.

-   If the record is assigned to a team:

    -   The team admin.

    -   Team members who have logged an activity in the record timeline.

-   *(Applicable only for an opportunity)* Sales team members who are connected with the opportunity and have logged an activity in the record timeline.

-   Users who have connected chats with the record.

-   Other users who have logged an activity in the record timeline.

-   *(Applicable only for an opportunity)* All the connected sales team members.

## Start a connected chat with other online members

You can start a connected chat with other members who are online and viewing the same record as you are. To start a connected chat with one or more online members, select a user icon on the command bar at the top, and then select **Start Teams chat**. The Teams popup chat is displayed and you can start chatting.

:::image type="content" source="media/co-presence.png" alt-text="Start a connected chat with other online members ":::

> [!NOTE]
> You can start a connected chat with other online members only when co-presence is enabled in Power Platform admin center and [Teams chat is enabled in Dynamics 365](enable-teams-chat.md#enable-or-disable-teams-chat) Sales by your administrator. 
>
> In Power Platform admin center, your system administrator needs to turn on the **Collaboration** feature in your environment. For information, see [Manage feature settings](/power-platform/admin/settings-features).

## Connect or disconnect an existing chat from a record

You can connect a chat to a single record or multiple records. For example, if you had a chat about a lead that turned into an opportunity, you could also connect the chat to the opportunity. If you decided later that you didn't want the chat connected to the lead, you could disconnect it.

- To connect an existing chat to a record, select the chat from the **Other chats** section, and then select **More (…)** > **Connect to this _record_**.

- To disconnect a chat from a record, select the chat, and then select **More (…)** > **Disconnect from this _record_**.

## Connect a Teams channel to a record

Connect relevant Teams channels to a record so that all the members can easily access the connected channels from the record and follow the conversations.

1.  Open any Dynamics 365 customer engagement record, and select :::image type="icon" source="media/teams-icon.png" border="false":::.

    The **Teams chats** pane opens.

    Alternatively, select **Collaborate** on the command bar to connect a channel to the record. For more information, go to [Enhanced Collaboration Experience with Microsoft Teams](teams-collaboration-enhanced-experience.md).

2.  Select the **Channel** tab. The tab lists the channels that are already connected to the record.

3.  Select the **Connect a Teams channel to this record** icon :::image type="icon" source="media/link-channel-icon.png" border="false"::: in the upper-right corner of the **Teams chats** pane.

    The **Collaborate with Microsoft Teams** dialog opens.

4.  To start a new connected channel, select **Create a new connection**.

5.  To connect an existing channel, select the channel from the list, and then select **Start collaboration**.

## Start a regular Teams chat in Dynamics 365

You can start a regular conversation in Dynamics 365 if you don't want to switch to Teams.

While you're in any of the records or in the list pane, select :::image type="icon" source="media/teams-icon.png" border="false":::, and then select the **Compose chat** icon :::image type="icon" source="media/compose-chat-icon.png" border="false"::: in the upper-right corner of the **Teams chats** pane. This option starts an individual or group chat but doesn't connect it to the record.

## Navigate to a record from a connected chat

When you [view all connected Dynamics 365 chats](#view-all-connected-dynamics-365-chats) from the dashboard, list view of a table type (such as opportunities or accounts), or [open chats related to a record](#open-teams-chats-and-channels-related-to-a-record), the connected chats display one or more record names they are connected to.

:::image type="content" source="media/linked-records.png" alt-text="Connected records to a chat":::

To navigate to a related record from the connected chat, hover over the chat, select **...**, and then select the record. 

:::image type="content" source="media/linked-record-open.png" alt-text="Open a connected record":::

The selected record opens and the **Teams chats** pane is refreshed with the chats connected to the opened record.

### See also

[Enable or disable Microsoft Teams chat in Sales Hub](enable-teams-chat.md)   
[Configure the ability to use suggested contacts](enable-contact-suggest.md)  
[Collaborate with AI-suggested contacts in Dynamics 365 Customer Service](/dynamics365/customer-service/use-ai-suggested-contacts-teams)
