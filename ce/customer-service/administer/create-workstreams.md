---
title: Create and manage workstreams
description: Learn about how to create and manage workstreams.
ms.date: 02/17/2025
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection:
ms.custom: bap-template
---

# Create and manage workstreams

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

A workstream is a container to enrich, route, and assign work items, and can be associated with a channel, such as live chat, voice, or case.

The workstream can belong to multiple channels of the same type, like multiple chat channels. In this case, all the conversations from these channels inherit the routing and work assignment settings of the workstream they belong to.

The workstream can be one of the following types:

- **Messaging**: To route conversations from live chat, SMS, social, and Microsoft Teams channels.
- **Record**: To route records, such as case, email, and activity.
- **Voice**: To route calls made to support numbers listed on the customer portal. Learn more in [Introduction to the voice channel](voice-channel.md).

> [!IMPORTANT]
>
> Unified routing must be enabled in the service configuration settings for records to be routed using unified routing. Learn more in [Provision unified routing](provision-unified-routing.md).

## Prerequisite

The administrator who configures workstreams must be a system administrator or have [permissions to access and modify secure columns](../implement/add-users-assign-roles.md#configure-permissions-to-access-secure-columns).

## Create a workstream

You can create workstreams for unified routing in the Customer Service admin center app.

1. In the site map of admin center, select **Workstreams** in **Customer support**.

1. Select **New workstream**.

1. In the **Create a workstream** dialog, enter the following details:

    - **Name**: Enter an intuitive name, such as **Contoso chat workstream**.
    
    - **Type**: Select one of the following types:
         - **Messaging**
         - **Record**
         - **Voice**
    
    - **Channel**: This box appears if you selected the type as **Messaging**. Select a channel from the list.
         If you select **Chat**, the **Make chats persistent** checkbox appears. Select the checkbox if you want to configure persistent chat. Also make sure that you select **Keep same agent for entire conversation** in the **Work distribution** settings of the workstream. Learn more in [Configure persistent chat](persistent-chat.md).
    
    - **Record**: This box appears if you selected the type as **Record**. Select the record from the list. Learn more in [Set up record routing](set-up-record-routing.md).
    
    - **Work distribution mode**: Select **Push** or **Pick**. You can't edit this setting later.
         - In **Push** mode, the system routes the work item to customer service representatives (service representatives or representatives) automatically using a message alert. You can configure the push work item to be explicitly picked up. For voice, push mode only is available.
         - In **Pick** mode, the system routes the work item to service representatives when they explicitly pick the work item from the **Open work items** in the representative's dashboard.
    
    - In **Fallback queue**, select one of the following options:
         - **Create new**: Enter a queue name to which work items are sent when no queue is identified in the the route-to-queue rules. You must add users to the queue after creating the workstream.
         - **Choose existing**: Select an existing queue from the dropdown list. By default, the out-of-the-box queue for the selected channel type is selected.

      Learn more in [Fallback queues](queues-omnichannel.md#how-fallback-queues-work).

      :::image type="content" source="../media/create-messaging-workstream.png" alt-text="Settings for creating workstream for live chat.":::

1. Select **Create**. The workstream that you created is displayed with the option to configure the selected channel instance.

1. Perform the steps outlined in one of the following sections depending on the channel that you selected.
   - [Configure a chat widget](add-chat-widget.md#configure-a-chat-widget)
   - [Configure a voice channel](../voice-channel-route-queues.md#configure-a-voice-channel)
   - [Configure a Facebook channel](configure-facebook-channel.md)
   - [Configure a LINE channel](configure-line-channel.md)
   - [Configure a WhatsApp channel](configure-whatsapp-channel.md)
   - [Configure a Microsoft Teams channel](configure-microsoft-teams.md)
   - [Configure an SMS channel using Azure Communication Services](configure-sms-channel-acs.md)
   - [Configure an SMS channel for Twilio](Configure-sms-channel-twilio.md)
   - [Configure a custom messaging channel](configure-custom-channel.md)
   - [Configure record routing](set-up-record-routing.md)

> [!NOTE]
> If asynchronous plug-ins are installed but disabled in your organization, ensure that you set the value of "DisabledForAsyncProcessing" to "No" to avoid issues when you're creating workstreams.

### Configure routing rules

Routing rules for a workstream consist of work classification rules and route-to-queue rules. Learn more about how to configure routing rules in the following articles:

- [Configure work classification rules](configure-work-classification.md)
- [Configure route-to-queue rules](configure-route-to-queue-rules.md)

### Configure work distribution

In the **Work distribution** area of a workstream, you can either accept the default settings or select **See more** and update the following options:

- **Auto-close after inactivity**: Select a time period after which inactive conversations are moved to the closed state automatically. This option is available for only persistent chat, SMS, social, and Microsoft Teams channels.
 
- **Work distribution mode**: The option that you selected when creating the workstream is displayed and can't be edited.
- **Capacity**: Select one of the following options. Learn more in [Create and manage capacity profiles](capacity-profiles.md).
  - **Unit based**: Enter a value if your administrator configured unit-based capacity.
  - **Profile based**: Specify a profile in the list if your administrator configured profile-based capacity.
- **Block capacity for wrap up**: 
  - **Always block**: Is the default selection. The representative capacity is consumed until the representative or supervisor closes the conversation or the system closes them automatically based on the configured time. Learn more in [Close conversations automatically](auto-close-conversation-powerapps.md#default-time-for-automatic-closure-of-conversations).
  - **Custom time**: The **Custom time in minutes** box is enabled where you can select a duration, such as **1 minute** or **60 minutes** to block capacity. After the specified duration, the system releases the capacity and automatically resets presence.
  - **Don't block**: The representative capacity is released immediately when the conversation moves to the **Wrap-up** state.
  
  > [!NOTE]
  > If you selected **End of Day mode** in capacity profile, representative capacity isn't reset when the duration selected in **Block capacity for wrap up** is over.

- **Allowed presences**: Select the presence statuses in which representatives can be assigned work. Don't select the **Inactive** and **Do not disturb** statuses if you don't want to assign new work items to representatives when they [miss](manage-missed-notifications.md) or [reject](enable-agent-reject-notifications.md) notifications.
- **Default skill matching algorithm**: Select **Exact Match**, **Closest Match**, or **None**.
- **Keep same agent for entire conversation**: Set the toggle to **Yes** if you want the conversation to remain assigned to the originally assigned representative. Learn more in [Agent affinity](#agent-affinity).

### Configure advanced settings

For a selected workstream, expand **Advanced settings** to configure the following options:

- [Sessions](session-templates.md)
- [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
- [Context variables](manage-context-variables.md)
- [Smart assist bots](../develop/smart-assist-bot.md)
- [Quick replies](create-quick-replies.md)

### Add an AI agent to a workstream

To add an AI agent to a workstream, you must configure the AI agent and make it available for selection.

Learn to configure Copilot agents in [Connect omnichannel to your Copilot Studio bot](/power-virtual-agents/configuration-hand-off-omnichannel#connect-omnichannel-to-your-power-virtual-agents-bot).
Learn to configure Azure AI agents in [Integrate Azure bots](../configure-bot.md#integrate-azure-bots-with-omnichannel-for-customer-service).

1. In Customer Service admin center or Contact Center admin center, go to **Workstreams**, and select a workstream.
2. For the selected workstream and channel, in the **Bot** area, select **Add bot**.
3. In the **Add a bot** dialog, select the required AI agent from the **Name** dropdown list, and then select **Save and close**.

When a work item needs assignment, the classification rules run, and the work distribution system checks and routes the work item to the AI agent if the selected workstream has an AI agent. After adding to the workstream, the incoming work item is first routed to the selected AI agent at runtime.

> [!NOTE]
> 
> - AI agents can receive conversations only if they're added to push-based workstreams.
> - We recommend that you don't add AI agents to workstreams that are meant for record routing.

### Manage workstreams

You can manage workstreams on the workstreams page of any of the Customer Service admin or Contact Center admin center apps.

Select a workstream to perform any of the following actions:

- **Edit**: Lets you edit the workstream, such as add a new channel or update the existing settings.
- **Copy**: Lets you create a copy of the workstream with all the properties, such as the rules, so that you can reuse the configured workstream in another organization. The copied workstream name is prefixed with "Copy of "*`<workstream>`*.
- **Delete**: Lets you delete the workstream if you no longer need it in your organization. You can't delete workstreams that are used in intake rules for record routing. You are prompted to remove the dependencies and then try to delete the workstream.
- **Fallback queue**: Select an existing queue or create a queue to set as the fallback queue. Learn more in [Fallback queues](queues-omnichannel.md#how-fallback-queues-work).

### Agent affinity

The agent affinity feature makes sure that work items are assigned to the service representatives based on their work history. When a waiting conversation becomes active, it's automatically reassigned to the same representative who handled the conversation previously, irrespective of the representative's capacity and presence. However, the agent affinity setting must align with the notification template settings that's associated with the workstream. If auto assign work items is set to no in the notification template, the system overrides the agent affinity setting.

Agent affinity is enabled by default for persistent chat, SMS, social channels, and Microsoft Teams. In these channels, when a conversation moves from the waiting to active state, it might not get assigned to the same representative who had previously handled it. You can set the **Keep same agent for entire conversation** toggle to **Yes** when you configure the work distribution for the workstream to reassign the conversation to the representative. This helps save the effort to reorient the representative or set the context about the customer issue again. 

However, for live chat, there's no waiting state. So, when the state of the conversation changes from active to open state, it is reassigned to the same representative. The representative can choose to reject the assigned conversation via the notification pane.

> [!NOTE]
> Agent affinity is applicable for push type of work distribution only.

### Associate templates

You can keep the default templates for sessions and notifications or update to use custom templates. Learn more in [Associate templates with workstreams](associate-templates.md).

### Related information

[Configure persistent chat](persistent-chat.md)  
[Set up record routing](set-up-record-routing.md)  
[Configure routing for email records](configure-routing-for-email-records.md)  
[Manage users](users-user-profiles.md)   
[Work with queues](queues-omnichannel.md)  
[Automatically identify customers using pre-chat responses](record-identification-rule.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
