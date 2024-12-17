---
title: Configure the inbox
description: Use this article to enable and configure inbox settings in Contact Center admin center or Customer Service admin center.
ms.date: 07/24/2024
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.collection:
ms.topic: how-to
ms.custom: bap-template
---

# Configure the inbox

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!NOTE]
> Case is applicable to Customer Service only.

As an administrator, you can [configure the inbox setting](#configure-the-inbox-setting-for-representatives) so that when your customer service representatives (service representatives or representatives) open Customer Service workspace or Contact Center workspace, they can select the inbox icon to show all the cases, conversations, and records that are assigned to them. The inbox is designed to help representatives efficiently work on high-velocity tasks, and promote inbox sessions to regular sessions when they need more time to resolve cases and complete their conversations.

You can configure the inbox settings for custom experiences only.

The following channels are supported in the inbox:

- Live chat
- Asynchronous chat
- Case
- Email
- Voice
- Unified routing enabled records

The following asynchronous channels are available in the conversation inbox:

- Text message (SMS)
- Persistent chat
- Facebook
- WeChat
- LINE
- WhatsApp
- Teams

## Live chat and voice channel in inbox

The live conversation settings in the inbox are as follows:

- When a representative accepts a live work item, that item is then added to the relevant view in the inbox, irrespective of whether the representative is using the inbox at the time of accepting the live work item.
- Voice calls always open as a new session with the card added to the inbox for awareness.
- Live work item cards have a "live" visual indicator.
- Live work item unread counts accrue to the unread count on the view.

## Prerequisites

Channel providers must have **All active channels** set to **On** to use and configure the chat setting in the inbox.

## Configure the inbox setting for representatives

You can configure the inbox in Contact Center admin center or Customer Service admin center by editing the agent experience profile to meet your preferred inbox settings.

1. Open the admin center app.

1. In **Agent experience**, select **Workspaces**.

1. In **Agent experience profiles**, select **Manage**.

1. Select the profile for which you want to configure the inbox.

1. In **Inbox**, select the **Settings** icon, and then turn on the **Inbox** toggle.

1. Select **Edit** to modify an existing view or create a view, and configure the following fields:
   - **Name:** Specify a name that shows in the inbox. Alphanumeric values are valid names.
   - **Record Type:** Select the record types for which the settings need to be applied. You can select more than one record type.
   - **Chat Status**: Is available if you select the record type as chat. Select one or more of the following settings:
     -  **Assigned**
     -  **Unassigned**
     -  **Resolved**
   - **Email**: Is available if you select the record type as Email. Select all the options that you want to enable.
     - Assigned to me:
       - Emails sent to me
       - Emails assigned to me
     - Unassigned:
       - Emails in my team
       - Emails in my queue(s)
       - Emails in a shared mailbox
    - **Agent Visibility**: Select one of the following options to show or hide the view to representatives:
      - **Show**
      - **Hide**

## Preconfigured inbox views

The following views are supported out of the box in the inbox:

- **Cases**: Shows all cases that the user owns, including active and resolved cases.
- **Assigned Conversations**: Shows all conversations assigned to the user, including active and closed conversations.
- **Resolved Conversations**: Shows all conversations marked as closed, and where the user was the primary representative in the conversation.
- **Unassigned Conversations**: Shows all active conversations and emails in a team or queue in which the user is a member. The user is able to assign conversations to themselves and reply to emails directly from this view.

Inbox views are auto refreshed every five minutes. Representatives can manually refresh the view by using the **Refresh** icon.

## Configure custom views for the inbox

You can configure a customized view for the inbox so that representatives can see their cases, conversations, emails, and voicemails all in a single view.

To configure multiple views for the inbox, complete the following steps.

1. Go to the agent experience profile for which you want to configure a custom view.

1. On the **Inbox** card, select **Edit**. The **Inbox** page is displayed.

1. Toggle **Enable Inbox** to **On** if it isn't already on, and then select **+ Add**. The **Add a new view** page is displayed.

1. On the **Add a new view** page, enter the following details:

   - **Name**: Type a name for the view.
   - **Agent visibility**: Select whether to **Show** or **Hide** the view from representatives.
   - **Record type**: Select the records that you want to include in the multi-entity view.
  
1. For each record type, choose one of the following settings. The settings are different for each record type.

    - **Simple** opens a dropdown menu where you can choose the type of records that appears in your multi-entity view. More information: [Simple settings](#simple-settings)
       
      :::image type="content" source="../media/simple-settings-inbox.png" alt-text="Simple setting option on the Add a new view page for inbox."::: 
       
    - **Advanced** opens a **Conditions** option where you can set the necessary conditions for your multi-entity view. More information: [Advanced condition builder](/business-applications-release-notes/october18/microsoft-flow/advanced-condition-builder)

      :::image type="content" source="../media/advanced-settings-inbox.png" alt-text="Advanced setting option on the Add a new view page for inbox."::: 

1. Select **Save**.

> [!NOTE]
> If you've configured new views or migrated existing views for unified routing enabled records, you might see a message that the read/unread functionality isn't supported. Open and save the view again to make sure that the read/unread functionality is supported.

### Simple settings

The following simple settings are available out of the box for the record types.

| Record type | Simple settings |
|-----------|------------------|
| Email | - Emails sent to me <br>- Emails assigned to me <br> - Emails in my team(s) <br> - Emails in my queue(s) <br> - Emails in a shared mailbox|
| Chat | - Assigned <br> - Unassigned <br> - Resolved|
| Case | - Cases assigned to me <br> - Cases in my team(s) <br> - Case(s) in my queue(s) |
| Voicemail | - Assigned <br> - Unassigned <br> - Resolved |
| Unified Routing enabled records | - Assigned <br> - Open <br> - Closed |

## Configure custom sort in the inbox

Configure a customized sort option for the inbox so that users can choose the required attributes to sort by, beyond customer and date.

1. In the site map of Customer Service admin center app, select **Workspaces**.
1. On the **Workspaces** page, next to **Agent experience profiles**, select **Manage**.
1. On the **Agent experience profiles** page, select the profile you want to edit.
1. On the **Profile** page, in **Inbox**, select **Edit**.
1. In the **Edit view** pane, in the **Sort** section, select the entity and attributes, along with sort order.

      :::image type="content" source="../media/custom-sort-inbox.png" alt-text="Custom sort option in the Edit view pane for inbox."::: 

1. Select **Save**.

## Bring your own entity to the inbox

By default, the inbox supports entities such as case, emails, conversations, and voicemails. You can also bring your own entities into the inbox to create a more customized experience, tailored to the needs of your users.

1. In the admin center site map, select **Workspaces**.
1. On the **Workspaces** page, next to **Agent experience profiles**, select the profile you want to edit.
1. On the **Profile** page, in **Inbox**, select **Edit**.
1. In the **Inbox settings** pane, select the **Inbox record types** tab.
1. Select **+Add**, and then chose the record type you want to add.
1. Select **Save and close**.

## Custom card configuration

You can help users personalize how their information displays in the inbox by customizing the card configuration.

1. In the admin center site map, select **Workspaces**.
1. On the **Workspaces** page, next to **Agent experience profiles**, select the profile you want to edit.
1. On the **Profile** page, in **Inbox**, select **Edit**.
1. In the **Inbox settings** pane, select the **Inbox record types** tab.
1. Select the attribute you want to edit. The **Edit record type** pane is displayed, showing the inbox preview of the work item.
1. Rearrange the attributes if desired.
1. To add new attributes, select the plus sign (**+**), and then use the dropdown menu to select a field.
1. When finished, select **Save and close**.

## Real-time translation

Learn more about how to configure real-time translation for conversations in the inbox, at [Enable real-time translation of conversations](enable-real-time-translation.md).


### Related information

[Inbox out-of-the-box views and filters](inbox-views-filters.md)  
[Create and use agent experience profiles](create-agent-experience-profile.md)  
[Overview of agent experience profiles](overview.md)  
[Use the inbox](../use/use-inbox.md)  
[Configure voicemail to manage inbound calls](voice-channel-voicemail.md)  
