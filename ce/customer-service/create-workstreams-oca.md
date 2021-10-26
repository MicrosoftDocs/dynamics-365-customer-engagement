---
title: "Create workstreams in Omnichannel Administration app | MicrosoftDocs"
description: "Learn how to create workstreams in the Omnichannel Administration app"
ms.date: 10/25/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Create workstreams in Omnichannel Administration


> [!IMPORTANT]
>
> - We recommend that you upgrade to the latest version of Omnichannel for Customer Service and use unified routing. For more information, see [Overview of unified routing](overview-unified-routing.md). With the upgrade, you can also use the new Omnichannel admin center app. For more information, see [Omnichannel admin center](oc-admin-center.md).
> - Workstreams that you create in the Omnichannel Administration app can't be modified in the Omnichannel admin center app. You'll need to migrate the existing workstreams and then manage them in the Omnichannel admin center app. More information: [Migrate workstreams created in Omnichannel Administration](migrate-workstreams.md).

A workstream is a collection of routing rules. Routing settings define how conversations should be routed to queues. Work distribution settings define how conversations should be allocated to agents within a queue. You can create the workstreams in the Omnichannel admin center, Customer Service Hub, and Omnichannel Administration apps.

A workstream can belong to multiple channels of the same type, like multiple chat channels. In this case, all the conversations from these channels inherit the routing and work distribution settings of the workstream they belong to. 

If you want to create workstreams to configure unified routing, see [Create workstreams in Omnichannel admin center](create-workstreams.md).


Perform the following steps:

1. In the Omnichannel Administration site map, go to **Work Distribution Management** > **Work Streams**.

    The **Active Work Streams** view is displayed.

    > [!div class=mx-imgBorder] 
    > ![Omnichannel workstreams.](media/oc-workstream-view.png "Omnichannel workstreams")

2. On the command bar, select **New** to create a work stream.

3. In the **Work Distribution** tab of the new work stream, follow these steps:

   1. In the **General information** section, specify the following information: </br>
      - **Name**: Enter a name for the workstream.
      - **Channel**: Channel is defined as a medium through which a customer reaches out for support. For example, a customer can contact an agent through chat.

        Select a channel from the drop-down list:
        - Live chat
        - SMS
        - Facebook
        - Entity Records
        - WeChat
        - Microsoft Teams
        - LINE
        - WhatsApp
        - Custom
        - Twitter

      - **Capacity**: Specify the units of capacity that are required to process a single conversation for the workstream in the text box. For information on how to determine capacity units, see [Capacity](users-user-profiles.md#capacity).

      - **Auto-close after inactivity**: Enter the unit of time after which a conversation is moved from **Waiting** to **Closed** state because of inactivity.
      > [!NOTE]
      > If you have selected Live chat in the **Channel** field, the **Auto-close after inactivity** field will not be visible to you as Waiting state is not applicable to Live chat.

   2. Select **Save**. The workstream is saved.

   3. In the **Work distribution settings** section, perform the following steps:

      1. Select whether the **Work distribution mode** should be **Push** or **Pick** for agents to take up a conversation.
      1. From the **Block agent's capacity during wrap-up** dropdown, select a duration to block capacity when the agent is in Wrap-up state, such as **1 minute** or **15 minutes**. After the specified duration, agent capacity is released  and presence is automatically reset. By default, **Always block** is selected, where agent capacity is blocked as long as the conversation is in **Wrap-up** state. You can also select **Don't block**, where agent capacity is released immediately, when the conversation moves to the **Wrap-up** state.
      > [!IMPORTANT]
      > If you have selected **End of Day mode** in capacity profile, agent capacity won't be reset after the duration selected in the **Block agent's capacity during wrap-up** field.

      1. In **Allowed Presences**, select a base presence, such as **Available** and **Busy**, from the dropdown. You can select all options also. Agents will be allocated work items if the agent presence is set to one of the statuses specified here. If you have enabled [missed notifications](manage-missed-notifications.md), do not select **Away** as an allowed presence. For information, see [Configure and manage custom presence](presence-custom-presence.md).
      1. If you have selected **Push** in **Work distribution mode**, set the toggle to **Yes** for **Enable selecting from push-based work streams**. The agents can assign work items to themselves irrespective of constraints, such as capacity and presence.
      1. If you want an ongoing conversation to be assigned to the same agent when the conversation status changes from waiting to active, make sure the **Enable Agent Affinity** is set to yes. By default, the toggle is enabled for SMS and social channels.
      
    
    > [!NOTE]
    > The **Enable Agent Affinity** option is available only when the work distribution mode is push. More information: [Agent affinity](create-workstreams.md#agent-affinity)

4. View and create context variables in the **Context variables** tab. Context variables enrich conversations with pre-chat data, channel data, and custom context data. These attributes can then be used to define routing rules to route conversations to different queues.

   1. Select **New** to create a context variable in the **Quick Create** window.
   2. Enter **Display Name** for the new variable. The **Name** field is populated accordingly.
   3. Select the **Type** of variable from the drop-down list. You can choose from **Text** or **Number**.


      > [!div class=mx-imgBorder] 
      > ![New context variable.](media/context-variable.png "New context variable")

5. Define routing rule items in the **Routing rule items** tab. Routing rule items are configured for each work stream, so that conversations can be routed to the correct queues. To learn how to configure a routing rule, see [Create and manage routing rules in Omnichannel](routing-rules.md).

6. Select **Save**. The workstream is saved.

## Associate workstreams with channel artifacts

You can associate work streams with channel artifacts so that the conversations can be assigned to agents seamlessly. For example, for a live chat widget, a default workstream is already associated in the **Work stream** field. You can select the search icon to associate another workstream. Select **New** to create a new workstream from within the live chat widget.

### See also

[Manage users in Omnichannel for Customer Service](users-user-profiles.md)  
[Create workstream for entity record routing in Omnichannel Administration](set-up-entity-workstream.md)  
[Work with queues](queues-omnichannel.md)  
[Automatically identify customers using pre-chat responses](record-identification-rule.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
