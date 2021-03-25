---
title: "Create workstreams | MicrosoftDocs"
description: "Understand and create workstreams in Customer Service"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Create workstreams in Omnichannel admin center

## Overview

A workstream is a collection of routing and work distribution settings. Routing settings define how conversations should be routed to queues. Work distribution settings define how conversations should be allocated to agents within a queue. You can create the workstreams in the Omnichannel admin center, Customer Service Hub, and Omnichannel Administration apps.

The workstream can be of one of the following types:

**Messaging:** To route conversations from live chat, SMS, social, and Teams channels
**Record:** To route entity records


> [!IMPORTANT]
> Entity routing must be enabled in the service configuration settings in Customer Service Hub for records to be routed using unified routing.

## Create a workstream

Perform the following steps to configure the workstream in Omnichannel admin center:

1. In Omnichannel admin center, go to the home page.
2. On the site map, select **Workstreams** under **General settings**, and then select **New**.
3. In the **Create a workstream** dialog box, enter the following details:
    - **Name:** Enter an intuitive name, such as **Contoso chat workstream**.
    - **Work distribution mode:** Select **Push** or **Pick**.
    - **Type:** Select one of the following types:
      - **Messaging:** To configure the workstream for chat and other conversation channels.
      - **Record:** To configure the workstream for entity record, such as case and email activity.
    - **Channel:** Is applicable if you have selected the type as Messaging. Select a channel from the list.
    - **Record:** Is applicable if you have selected the type as Record. Select the entity record from the list.

4. Select **Create**. The workstream that you created is displayed with the option to configure the selected channel instance.
    > [!div class=mx-imgBorder]
    > ![Set up a channel](media/set-up-wechat.png "Set up a channel")
5. Perform the steps outlined in one of the following sections depending on the channel that you've selected.
   - [Configure a chat widget](add-chat-widget.md#configure-a-chat-widget-in-omnichannel-admin-center)
   - [Configure a Facebook channel](configure-facebook-channel.md)
   - [Configure a WeChat instance](configure-wechat-channel.md)
   - [Configure a LINE channel](configure-line-channel.md)
   - [Configure a Twitter channel](configure-twitter-channel.md)
   - [Configure a WhatsApp channel](configure-whatsapp-channel.md)
   - [Configure a Microsoft Teams channel](configure-microsoft-teams.md)
   - [Configure a custom messaging channel](configure-custom-channel.md)
6. Configure routing rules for the worksteam. More information: [Configure work classification rules](configure-work-classification.md)
7. If you want to configure route to queues, see [Configure route to queues](configure-work-classification.md#configure-route-to-queues-ruleset-and-rules)

### Configure work distribution

In the **Work distribution** area of a workstream, you can either accept the default settings or select **See more** and update the following options.
- **Auto-close after inactivity:** Select a time period after which inactive conversations will be moved to the closed state automatically.
- **Work distribution mode:** The option that you selected in step 3 is displayed and can't be edited.
- **Capacity:** Select one of the following options:
   - **Unit based:** Enter value if your organization has configured unit-based capacity.
   - **Profile based:** Specify a profile in the list if your organization has configured profile-based capacity.
- **Allowed presences:** Select the presences in which agents will be assigned.
- **Default skill matching algorithm**: Select Exact Match or Closest Match.
- **Keep same agent for entire conversation:** Set the toggle to yes if you want the conversation to be remained assigned to the originally-assigned agent. More information: [Agent affinity](work-streams-introduction.md#agent-affinity)

### Configure Advanced settings

For a selected workstream, expand **Advanced settings** to configure the following options:
   - [Sessions](../app-profile-manager/session-templates.md)
   - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](#configure-context-variables)
   - [Smart assist bots](smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

### Add a bot

To add a bot, the bot must be configured and available for selection. After a bot is added to the workstream, the selected bot will be the first to pick up the incoming work item at runtime. When a work item needs to be assigned the classification rules are run and the work distribution system checks and routes the work item to the bot if the selected workstream has a bot.

For information about how to configure bots in Power Virtual Agents, see [Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md). For information about how to configure Azure bots, see [Integrate an Azure bot](configure-bot.md).

1. For the selected workstream and channel, in the **Bot** area, select **Add bot**.
2. In **Add a bot**, select the required bot in the **Name** list, and select **Save and close**.

### Configure context variables

Context variables enrich conversations with pre-chat data, channel data, and custom context data. These attributes can then be used to define routing rules to route conversations to different queues.

> [!Note]
> Context variable names must be unique. We recommend that you do not update or delete the context variables after creating them. If you need to, make sure that the variables are not used in any routing or assignment rules.

   1. Select **Add context variable** in the **Advanced settings** section of a workstream.
   2. In the **Edit** pane, select **Add**, and enter **Name**.
   3. Select the **Type** of variable from the drop-down list. You can choose from **Text** or **Number**.
   4. Repeat the steps 2 and 3 to create the required variables.
