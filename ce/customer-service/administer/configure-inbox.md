---
title: Configure the inbox
description: Learn how to enable the inbox, use the preconfigured views, and create custom inbox views, sorting, and cards for customer service representatives in Copilot Service admin center.
ms.date: 10/29/2026
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

As an administrator, you can [configure the inbox setting](#configure-the-inbox-setting-for-representatives) so that when your customer service representatives (representatives) open Copilot Service workspace, they can select the inbox icon to show all the cases, conversations, and records that are assigned to them. The inbox is designed to help representatives efficiently work on high-velocity tasks and promote inbox sessions to regular sessions when they need more time to resolve cases and complete their conversations.

You can configure inbox settings only for custom experience profiles. You can't edit the inbox settings in the default (out-of-the-box) experience profiles.

The following channels are supported in the inbox:

- Live chat
- Asynchronous chat
- Case
- Email
- Task
- Voice
- Unified routing–enabled records

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

- When a representative accepts a live work item, the inbox adds that item to the relevant view, regardless of whether the representative is using the inbox at the time.
- Voice calls always open as a new session with the card added to the inbox for awareness.
- Live work item cards have a "live" visual indicator.
- Live work item unread counts accrue to the unread count on the view.

## Prerequisites

Channel providers must have **All active channels** set to **On** to use and configure the chat setting in the inbox.

## Configure the inbox setting for representatives

Configure the inbox by editing the experience profile in Copilot Service admin center.

1. In the site map of Copilot Service admin center, select **Workspaces**.

1. On the **Workspaces** page, next to **Experience profiles**, select **Manage**.

1. Select the profile for which you want to configure the inbox.

1. In **Inbox**, select the **Settings** icon, and then turn on the **Inbox** toggle.

1. Select **Edit** to modify an existing view or create a view. Then, configure the following fields:

   - **Name**: Enter the view name that appears to representatives in the inbox. Alphanumeric values are valid names.
   - **Record type**: Select one or more record types to include in the view.
   - **Chat status**: Available when you select the chat record type. Select one or more of the following statuses:
     - Assigned
     - Unassigned
     - Resolved
   - **Email**: Available when you select the email record type. Select the options you want to include:
     - **Assigned to me**: Emails sent to me, Emails assigned to me
     - **Unassigned**: Emails in my team, Emails in my queues, Emails in a shared mailbox
   - **Representative visibility**: Select **Show** to display the view to representatives, or **Hide** to keep the view hidden.

## Preconfigured inbox views

When you turn on the inbox, you get the following views by default.

| View | What it shows |
|------|---------------|
| **Cases** | All cases that the representative owns, including active and resolved cases. |
| **Assigned Conversations** | All conversations assigned to the representative, including active and closed conversations. |
| **Resolved Conversations** | Closed conversations where the representative was the primary representative. |
| **Unassigned Conversations** | Active conversations and emails in the teams or queues that the representative is a member of. Representatives can assign conversations to themselves and reply to emails directly from this view. |

Inbox views refresh automatically every five minutes. Representatives can refresh a view manually by selecting the **Refresh** icon.

If the preconfigured views don't meet your needs, [configure custom views](#configure-custom-views-for-the-inbox). Learn more about the filters available in each view in [Use views and filters in the inbox](../use/inbox-views-filters.md).

## Configure the channel-focused inbox

Use the channel-focused inbox to control how incoming persistent, live chat, asynchronous chat, social, and SMS conversations are routed and displayed for representatives.

The channel-focused inbox works as follows:
- Changes apply to all users across an organization, and to all app profiles and conversation types except voice.
- The feature affects persistent, live, asynchronous, and synchronous conversations.
- Voice calls always open in a new session tab.

1. In the site map of Copilot Service admin center, select **Workspaces**.
1. On the **Workspaces** page, next to **Experience profiles**, select **Manage**.
1. Select the profile for which you want to configure the channel-focused inbox.
1. Select **Edit inbox**, and then select the **Incoming work items** tab.
1. Select one of the following options for incoming conversations:
   - **Add to inbox if customer service representative is currently in inbox; otherwise open in a new session tab**: Adds to inbox if the representative is currently in the inbox. If not, the conversation opens in a new session tab.
   - **Add to inbox**: Adds the conversation to the inbox regardless of where the representative is working.
   - **Open in a new session tab**: Opens in a new tab each time.
1. Select **Save and close**. Then, clear the browser cache or refresh the browser window for the settings to take effect.

## Configure custom views for the inbox

Create custom views so that representatives can view their cases, conversations, emails, and voicemails together in a single view. You can add multiple custom views to each experience profile.

1. In the site map of Copilot Service admin center, select **Workspaces**.

1. On the **Workspaces** page, next to **Experience profiles**, select **Manage**, and then select the profile for which you want to configure a custom view.

1. On the **Inbox** card, select **Edit**. The **Inbox** page appears.

1. Set **Enable Inbox** to **On** if it isn't already on, and then select **+ Add**. The **Add a new view** page appears.

1. On the **Add a new view** page, enter the following details:

   - **Name**: Enter a name for the view.
   - **Representative visibility**: Select **Show** or **Hide** to control whether the view appears to representatives.
   - **Record type**: Select the record types to include in the multi-entity view.

1. For each record type, choose how to filter records:

    - **Simple**: Select predefined filters from a dropdown list, such as **Emails assigned to me** or **Cases in my queues**. The options depend on the record type. Learn more in [Simple settings](#simple-settings).

      :::image type="content" source="../media/simple-settings-inbox.png" alt-text="Screenshot of the Simple setting option on the Add a new view page for the inbox.":::

    - **Advanced**: Build your own filter conditions by using the condition builder. Use this option when the simple filters don't cover your scenario. Learn more in [Advanced settings for conversations](#advanced-settings-for-conversations).

      :::image type="content" source="../media/advanced-settings-inbox.png" alt-text="Screenshot of the Advanced setting option on the Add a new view page for the inbox.":::

1. Select **Save**.

> [!NOTE]
> If you configure new views or migrate existing views for unified routing–enabled records, you might get a message that the read/unread functionality isn't supported. Open and save the view again to make sure that the read/unread functionality is supported.

### Simple settings

The following simple settings are available for each record type.

| Record type | Simple settings |
|-----------|------------------|
| Email | - Emails sent to me <br>- Emails assigned to me <br> - Emails in my teams <br> - Emails in my queues <br> - Emails in a shared mailbox|
| Chat | - Assigned <br> - Unassigned <br> - Resolved|
| Case | - Cases assigned to me <br> - Cases in my teams <br> - Cases in my queues |
| Voicemail | - Assigned <br> - Unassigned <br> - Resolved |
| Unified routing–enabled records | - Assigned <br> - Open <br> - Closed |

### Advanced settings for conversations

For custom experience profiles with conversations enabled, you can use advanced settings for the conversation record type in inbox views. Use the condition builder to define which conversation records appear to representatives. Because conversation configuration can be complex, the condition builder is prepopulated with any simple settings you saved, which you can then modify.

## Configure custom sort in the inbox

Configure a custom sort option for the inbox so that representatives can sort by attributes other than customer and date.

1. In the site map of Copilot Service admin center, select **Workspaces**.
1. On the **Workspaces** page, next to **Experience profiles**, select **Manage**.
1. On the **Experience profiles** page, select the profile you want to edit.
1. On the **Profile** page, in **Inbox**, select **Edit**.
1. In the **Edit view** pane, in the **Sort** section, select the entity and attributes, along with sort order.

      :::image type="content" source="../media/custom-sort-inbox.png" alt-text="Screenshot of the custom sort option in the Edit view pane for the inbox."::: 

1. Select **Save**.

## Bring your own entity to the inbox

By default, the inbox supports entities such as case, emails, conversations, and voicemails. You can also bring your own entities into the inbox to create a more customized experience, tailored to the needs of your representatives.

1. In the site map of Copilot Service admin center, select **Workspaces**.
1. On the **Workspaces** page, next to **Experience profiles**, select **Manage**, and then select the profile you want to edit.
1. On the **Profile** page, in **Inbox**, select **Edit**.
1. In the **Inbox settings** pane, select the **Inbox record types** tab.
1. Select **+ Add**, and then choose the record type you want to add.
1. Select **Save and close**.

## Custom card configuration

Customize the card configuration to control how information displays on inbox cards for representatives.

1. In the site map of Copilot Service admin center, select **Workspaces**.
1. On the **Workspaces** page, next to **Experience profiles**, select **Manage**, and then select the profile you want to edit.
1. On the **Profile** page, in **Inbox**, select **Edit**.
1. In the **Inbox settings** pane, select the **Inbox record types** tab.
1. Select the record type you want to edit. The **Edit record type** pane shows a preview of the work item in the inbox.
1. Optionally, rearrange the attributes.
1. To add new attributes, select the plus sign (**+**), and then use the dropdown menu to select a field.
1. When finished, select **Save and close**.

## Real-time translation

To configure real-time translation for conversations in the inbox, go to [Enable real-time translation of conversations](enable-real-time-translation.md).


### Related information

[Use views and filters in the inbox](../use/inbox-views-filters.md)  
[Create and use experience profiles](create-agent-experience-profile.md)  
[Overview of experience profiles](overview.md)  
[Use the inbox](../use/use-inbox.md)  
[Create a personalized view in the inbox](../use/inbox-create-personalized-view.md)  
[Configure voicemail to manage inbound calls](voice-channel-voicemail.md)  
