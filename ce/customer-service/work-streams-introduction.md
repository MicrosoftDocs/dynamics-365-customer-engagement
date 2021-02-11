---
title: Understand and create work streams | MicrosoftDocs
description: Understand and create work streams in the Omnichannel for Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Understand and create work streams 

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

A work stream is a collection of routing and work distribution settings. Routing settings define how conversations should be routed to queues. Work distribution settings define how conversations should be allocated to agents within a queue.

In Omnichannel for Customer Service, you can create the following types of work streams:

- Live chat work stream
- SMS work stream
- Work stream for social channels

> [!NOTE]
> A work stream can belong to multiple channels of the same type, like multiple chat channels. In this case, all the conversations from these channels inherit the routing and work distribution settings of the work stream they belong to.

## Create a work stream

Perform the following steps to create a work stream in Omnichannel for Customer Service:

1. In the Omnichannel site map, go to **Work Distribution Management** > **Work Streams**.

    The **Active Work Streams** view is displayed. 

    > [!div class=mx-imgBorder] 
    > ![Omnichannel work streams](media/oc-workstream-view.png)

2. On the command bar, select **New** to create a work stream.

3. In the **Work Distribution** tab of the new work stream, follow these steps:

   1. In the **General information** section, specify the following information: </br>
      - **Name**: Enter a name for the work stream.
      - **Channel**: Channel is defined as a medium through which a customer reaches out for support. For example, a customer can contact an agent through chat. 

        Select a channel from the drop-down list:
        - Live Chat
        - SMS
        - Facebook
        - Entity Records
        - WeChat
        - Microsoft Teams
        - LINE
        - WhatsApp
        - Custom
        - Twitter

      - **Capacity**: Specify the units of capacity that are required to process a single conversation for the work stream in the text box. For information on how to determine capacity units, see [Capacity](users-user-profiles.md#capacity).

      - **Auto-close after inactivity**: Enter the unit of time after which a conversation is moved from the **Waiting** state to the **Closed** state because of inactivity.

   2. Select **Save**. The work stream is saved.

   3. In the **Work distribution** section, perform the following steps:

      1. Select whether the **Work distribution mode** should be **Push** or **Pick** for agents to take up a conversation.

         - In **Push** mode, a conversation is dispatched to agents automatically using a message alert. You can configure a push conversation to be explicitly picked up.

         - In **Pick** mode, a conversation is dispatched to agents when they explicitly pick a conversation from the **Open work items** in the agent dashboard.

      2. In **Allowed Presences**, select a base presence, such as "Available" and "Busy" from the list. You can select all options also. Agents will be allocated work items if the agent presence is set to one of the statuses specified here. If you have enabled [missed notifications](manage-missed-notifications.md), do not select "Away" as an allowed presence. For information, see [Configure and manage custom presence](presence-custom-presence.md).

          > [!div class=mx-imgBorder] 
          > ![New work stream](media/omni-channel-new-work-stream.png)

      3. If you have selected **Push** in **Work distribution mode**, set the toggle to **Yes** for **Enable selecting from push-based work streams**. The agents can assign work items to themselves irrespective of constraints, such as capacity and presence.
      4. If you want an ongoing conversation to be assigned to the same agent when the conversation status changes from waiting to active, make sure the **Enable Agent Affinity** is set to yes. By default, the toggle is enabled for SMS and social channels.
    
    > [!NOTE]
    > The **Enable Agent Affinity** option is available only when the work distribution mode is push. More information: [Agent affinity](#agent-affinity).

4. View and create context variables in the **Context variables** tab. Context variables enrich conversations with pre-chat data, channel data, and custom context data. These attributes can then be used to define routing rules to route conversations to different queues.

   1. Select **New** to create a context variable in the **Quick Create** window.
   2. Enter **Display Name** for the new variable. The **Name** field is populated accordingly.
   3. Select the **Type** of variable from the drop-down list. You can choose from **Text** or **Number**.


      > [!div class=mx-imgBorder] 
      > ![New context variable](media/context-variable.png)

5. Define routing rule items in the **Routing rule items** tab. Routing rule items are configured for each work stream, so that conversations can be routed to the correct queues. To learn how to configure a routing rule, see [Create and manage routing rules in Omnichannel](routing-rules.md).

6. Select **Save**. The work stream is saved.

## Associate work streams with channel artifacts

You can associate work streams with channel artifacts so that the conversations can be assigned to agents seamlessly. For example, for a live chat widget, a default work stream is already associated in the **Work stream** field. You can select the search icon to associate another work stream. Select **New** to create a new work stream from within the live chat widget.

To learn more about how to set up channels and associate work streams, see the following topics:

- [Configure a chat channel](set-up-chat-widget.md)
- [Configure an SMS channel](configure-sms-channel.md)

### Agent affinity

When a conversation becomes active from the waiting status, it might not be assigned to the same agent who had previously handled it. You can use the agent affinity option to reassign the conversation to the agent who had worked on it earlier. This helps save the effort to reorient the agent or set the context about the problem again. The agent affinity works as follows:

- Is enabled by default for SMS and social channels.
- Is available only for push type of work distribution.
- Reassigns conversations to the same agent, irrespective of the agent's capacity and presence.

Because the conversation assignment takes place using the notification alert, the agent has the option to reject the assignment.

### See also

[Manage users in Omnichannel for Customer Service](users-user-profiles.md)  
[Create workstream for entity record routing](set-up-entity-workstream.md)  
[Work with queues](queues-omnichannel.md)  
[Automatically identify customers using pre-chat responses](record-identification-rule.md)  
