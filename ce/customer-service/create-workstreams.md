---
title: "Create workstreams in Customer Service | MicrosoftDocs"
description: "Perform the steps mentioned in the topic to understand and create workstreams for unified routing in Customer Service and Omnichannel for Customer Service."
ms.date: 11/01/2021
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.topic: article
ms.custom: intro-internal
---

# Create workstreams for unified routing

## Overview

A workstream is a container to enrich, route, and assign work items. The workstream is associated with a channel, such as live chat, voice, or case.

The workstream can belong to multiple channels of the same type, like multiple chat channels. In this case, all the conversations from these channels inherit the routing and work assignment settings of the workstream they belong to.

The workstream can be one of the following types:

- **Messaging**: To route conversations from live chat, SMS, social, and Teams channels.
- **Record**: To route records, such as case, email, and activity.
- **Voice**: To route calls made to the support numbers listed on the customer portal.


> [!IMPORTANT]
>
> - Unified routing must be enabled in the service configuration settings in Customer Service Hub for records to be routed using unified routing. More information: [Provision unified routing](provision-unified-routing.md).
> - Workstreams that you created in the Omnichannel Administration app can't be modified in the Omnichannel admin center app. You'll need to migrate the existing workstreams and then manage them in the Omnichannel admin center app. More information: [Migrate workstreams created in Omnichannel Administration](migrate-workstreams.md).

## Create a workstream

You can create workstreams for unified routing in the Omnichannel admin center and Customer Service Hub apps.

Perform the following steps:

1. In Omnichannel admin center, in the site map, select **Workstreams** under **General settings**. In Customer Service Hub, in the site map, select **Workstreams** under **Unified Routing**.

2. Select **New**.

3. In the **Create a workstream** dialog box, enter the following details:

    - **Name**: Enter an intuitive name, such as **Contoso chat workstream**.
    
    - **Type**: Select one of the following types:
         - **Messaging**: To configure the workstream for chat and other conversation channels.
         - **Record**: To configure the workstream for entity record, such as case and email activity.
         - **Voice**: To configure the workstream for the voice channel. More information: [Overview of voice channel](voice-channel.md)
    
    - **Channel**: This box appears if you have selected the type as **Messaging**. Select a channel from the list.
         - If you select **Chat**, the **Make chats persistent** option appears. Select the checkbox if you want to configure persistent chat. Also make sure that you select **Keep same agent for entire conversation** in **Work distribution** settings of the workstream. More information: [Configure persistent chat](persistent-chat.md).
    
    - **Record**: This box appears if you have selected the type as **Record**. Select the record from the list.  More information: [Set up record routing](set-up-record-routing.md).
    
    - **Work distribution mode**: Select **Push** or **Pick**.
         - In **Push** mode, a work item is dispatched to agents automatically using a message alert. You can configure the push work item to be explicitly picked up. For voice, only push mode is available.
         - In **Pick** mode, a work item is dispatched to agents when they explicitly pick the work item from the **Open work items** in the agent dashboard.

4. Select **Create**. The workstream that you created is displayed with the option to configure the selected channel instance.
    > [!div class=mx-imgBorder]
    > ![Set up a channel.](media/set-up-chat.png "Set up a channel")

5. Perform the steps outlined in one of the following sections depending on the channel that you've selected.
   - [Configure a chat widget](add-chat-widget.md#configure-a-chat-widget-in-omnichannel-admin-center)
   - [Configure a voice channel](voice-channel-route-queues.md#configure-a-voice-channel)
   - [Configure a Facebook channel](configure-facebook-channel.md)
   - [Configure a WeChat instance](configure-wechat-channel.md)
   - [Configure a LINE channel](configure-line-channel.md)
   - [Configure a Twitter channel](configure-twitter-channel.md)
   - [Configure a WhatsApp channel](configure-whatsapp-channel.md)
   - [Configure a Microsoft Teams channel](configure-microsoft-teams.md)
   - [Configure an SMS channel for TeleSign](configure-sms-channel.md)
   - [Configure an SMS channel for Twilio](configure-sms-channel-twilio.md)
   - [Configure a custom messaging channel](configure-custom-channel.md)
   - [Configure record routing](set-up-record-routing.md)

### Configure routing rules

Routing rules for a workstream consists of work classification rules and route-to-queue rules. For the steps to configure routing rules, see the following:

- [Configure work classification rules](configure-work-classification.md)
- [Configure route to queues](configure-work-classification.md#configure-route-to-queues-rulesets-and-rules).

### Configure work distribution

In the **Work distribution** area of a workstream, you can either accept the default settings or select **See more** and update the following options:

- **Auto-close after inactivity**: Select a time period after which inactive conversations will be moved to the closed state automatically. More information: [Automatic closure of conversation](oc-conversation-state.md#automatically-close-conversations)
- **Work distribution mode**: The option that you selected in step 3 is displayed and can't be edited.
- **Capacity**: Select one of the following options. More information: [Create and manage capacity profiles](capacity-profiles.md)
  - **Unit based**: Enter a value if your organization has configured unit-based capacity.
  - **Profile based**: Specify a profile in the list if your organization has configured profile-based capacity.
- **Allowed presences**: Select the presences in which agents will be assigned.
- **Default skill matching algorithm**: Select **Exact Match**, **Closest Match**, or **None**.
- **Keep same agent for entire conversation**: Set the toggle to yes if you want the conversation to remain assigned to the originally assigned agent. More information: [Agent affinity](#agent-affinity)

### Configure advanced settings

For a selected workstream, expand **Advanced settings** to configure the following options:

- [Sessions](../app-profile-manager/session-templates.md)
- [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
- [Context variables](#configure-context-variables)
- [Smart assist bots](smart-assist-bot.md)
- [Quick replies](create-quick-replies.md)

### Add a bot

To add a bot, the bot must be configured and available for selection. After a bot is added to the workstream, the selected bot will be the first to which the incoming work item will be routed to at runtime. When a work item needs to be assigned, the classification rules are run and the work distribution system checks and routes the work item to the bot if the selected workstream has a bot. The bot is supported only in push type of workstreams.

For information about how to configure bots in Power Virtual Agents, see [Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md).
For information about how to configure Azure bots, see [Integrate an Azure bot](configure-bot.md).

1. For the selected workstream and channel, in the **Bot** area, select **Add bot**.
2. In **Add a bot**, select the required bot in the **Name** list, and select **Save and close**.

### Configure context variables

Context variables enrich conversations with pre-chat data, channel data, and custom context data. These attributes can then be used to define routing rules to route conversations to different queues.

> [!Note]
> If you create custom context variables, we recommend that you don't update or delete them. If you need to update or delete them, make sure that they aren't used in any of the unified routing classification or assignment rules.

1. Select **Add context variable** in the **Advanced settings** section of a workstream.
2. In the **Edit** pane, select **Add**, and enter **Name**.
3. Select the **Type** of variable from the dropdown list. You can choose from **Text** or **Number**.
4. Repeat steps 2 and 3 to create the required variables.

### Manage workstreams

You can manage the workstreams on the workstreams page in the Omnichannel admin center or Customer Service Hub app.

Select a workstream to perform any of the following actions:

- **Edit**: Lets you edit the workstream, such as add a new channel or update the existing settings.
- **Copy**: Lets you create a copy of the workstream with all the properties, such as the rules, so that you can reuse the configured workstream in another organization. The copied workstream name is prefixed with "Copy of "*`<workstream>`*.
- **Delete**: Lets you delete the workstream if you no longer need it in your organization. You can't delete workstreams that are used in intake rules for record routing. You'll be prompted to remove the dependencies and then try to delete the workstream.

### Agent affinity

When a conversation becomes active from the waiting status, it might not be assigned to the same agent who had previously handled it. You can use the **Keep same agent for entire conversation** option in the work distribution settings of the workstream to reassign the conversation to the agent who had worked on it earlier. This helps save the effort to reorient the agent or set the context about the problem again. The agent affinity works as follows:

- Is enabled by default for SMS, social channels, and Microsoft Teams.
- Is available only for push type of work distribution.
- Reassigns conversations to the same agent, irrespective of the agent's capacity and presence.

Because the conversation assignment takes place using the notification alert, the agent has the option to reject the assignment.

### Associate templates

You can keep the default templates for sessions and notifications or update to use custom templates. More information: [Associate templates in Omnichannel admin center](../app-profile-manager/associate-templates.md#associate-templates-with-workstreams-in-omnichannel-admin-center)

### See also

[Set up record routing](set-up-record-routing.md)  
[Manage users in Omnichannel for Customer Service](users-user-profiles.md)  
[Create workstream for entity record routing in Omnichannel Administration](set-up-entity-workstream.md)  
[Work with queues](queues-omnichannel.md)  
[Automatically identify customers using pre-chat responses](record-identification-rule.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
