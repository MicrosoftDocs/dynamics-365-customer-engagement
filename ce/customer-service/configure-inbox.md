---
title: Configure the inbox | MicrosoftDocs
description: Learn how to enable the inbox in Dynamics 365 Customer Service App profile manager and configure inbox settings in Customer Service admin center.
ms.date: 04/02/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Configure the inbox

As an administrator, you can configure the inbox setting so that when your agents open Dynamics 365 Customer Service workspace or Omnichannel for Customer Service, they can select the inbox icon to show all of the cases and conversations that are assigned to them. The inbox is designed to help agents efficiently work on high velocity tasks, as well as promote inbox sessions to regular sessions when they need more time to resolve cases and complete their conversations.

The following asynchronized channels are available in the conversation inbox: SMS, persistent chat, Facebook, Twitter, WeChat, LINE, WhatsApp, and Teams.

## Enable the inbox setting in App profile manager

As an administrator, you can enable the inbox in App profile manager. After you enable the inbox for a profile, any user who is added to the profile can use the inbox. More information: [Configure the inbox view in App profile manager.](/dynamics365/app-profile-manager/app-profile-manager#configure-the-inbox-view)

> [!Note]
> To configure the properties of the inbox, you must create a custom profile. Default profiles cannot be edited, and will show a lock icon next to them.

## Edit the custom app profile inbox settings

You can configure the inbox in the [Customer Service admin center](/app-profile-manager/app-profile-manager#create-agent-experience-profiles-in-customer-service-admin-center-preview) by editing the custom app profile to meet your preferred inbox settings.

1. Open the Customer Service admin center app.

1. In **Agent experience**, select **Workspaces**.

1. In **Agent experience profiles**, select **Manage**.

1. Select the profile for which you want to configure the inbox.

   > [!Note]
   > Channel providers must have **All active channels** set to **On** in order to use and configure the chat setting in the inbox.

1. You can either modify an existing view or create a new one. The following fields can be configured:
   - **Name:** The name of the view that will show in  the inbox. Alphanumeric values are valid names.
   - **Record Type:** The records that currently available for inbox configuration. Select or deselect to show or hide the status of these items:
   - **Chat Status**
     -  **Assigned**
     -  **Unassigned**
     -  **Resolved**
   - **Email**:
     - Assigned to me:
       - Emails sent to me
       - Emails assigned to me
     - Unassigned
       - Emails in my team
       - Emails in my queue(s)
       - Emails in a shred mailbox.
    - **Agent Visibility**
      - **Show**: Makes this view available to the user's in Inbox.
      - **Hide**: this view will not show in the user's Inbox

### Inbox views

The following views are supported in the inbox:

- **Cases**: Shows all cases that are owned by the user, including active and resolved cases.
- **Assigned Conversation(s)**: Shows all conversations that have been assigned to the user, including active and closed conversations.
- **Resolved Conversation(s)**: Shows all conversations that have been marked as closed, and where the user was the primary agent in the conversation.
- **Unassigned Conversation(s)**: Shows all active conversations and emails in a team or queue in which the user is a member. The user is able to assign conversations to themselves and reply to emails directly from this view.

Inbox views refresh every five minutes. To manually refresh the view, you can select the **Refresh** icon at the top of the inbox.

## Real Time Translation
For information about how to configure Real Time Translation (RTT) for conversations in the inbox, see [Enable real-time translation of conversations](enable-real-time-translation.md)

## Known issues
The following items are known issues with the inbox.

- Live Chat and Live Call won't show as part of the inbox, and will open as sessions.
- Asynchronous channels, such as Facebook, Teams, Twitter, and so forth, and those configured as persistent chat, will open within the inbox.
- Real Time Translation (RTT): Prior to the open conversation being assigned to a user, the last message will not be translated in the inbox.

### See also

[Customer Service admin center](/app-profile-manager/app-profile-manager)
[Enable real-time translation of conversations](enable-real-time-translation.md) 
