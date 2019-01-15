---
title: Create and manage work streams
description: See how you can create and manage work streams in the Omni-channel Engagement Hub
keywords: Create and manage work streams; Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 5e6285ee-4b79-473d-b920-d1fab636c82e
ms.custom: 
---
# Create and manage work streams

Work streams define the settings and properties for a specific source or originating point that customer requests or queries can come from. For example, if requests originate from two chat portals, you can create a different work stream for each of them. If conversations are created as case records, you can create a separate work stream for them.

All work streams are associated with unique channels. Channels can be defined for chats, entities, and so on. A work stream can't be associated with more than one channel.

Omni-channel Engagement Hub has some predefined work streams. However, as an admin, you can define new work streams to introduce a new source.

![Omni-channel work streams](../media/oc-workstream-view.png)

There are two types of work streams:

- Live Chat work stream
- CDS Entity work stream

## Live Chat work stream

When you set up Live Chat work streams, you define the following properties:

- **Channels**: In Omni-channel Engagement Hub, a channel is defined as a medium that customers can reach out and engage with agents through. For example, a customer can chat with an agent through the chat channel. As an admin, you can select the channel that a work stream is created for. 
   > [!NOTE]
   > In this preview, work streams can be defined for chat and entity channels.
- **Allowable Presence**: Allowable presence helps assign work streams only to agents whose presence status is one of the **Available** presence statuses that are associated with the work stream. For more information, see [Configure presence and custom presence](presence-custom-presence.md).

- **Capacity**: When a conversation from a work stream is assigned to an agent, it consumes some capacity. The units of capacity are defined as capacity in the work stream. For example, a conversation in the Live Chat work stream from the portal has a capacity of 20 units. When this conversation is assigned to an agent, it consumes 20 units of agent's capacity.

- **Work distribution mode and context attributes**: The context attributes can vary for each work stream. For example, for a chat conversation, context attributes include the browser, IP address, answers to pre-chat questions, and customer ID (for authenticated chat). These attributes can then be used to define routing rules that channel conversations to different queues.
   > [!NOTE]
   > Context attributes can be declared and defined at the work stream level, so that the omni-channel system understands the kind of conversations that it will receive. Conversations are preloaded with specific context attributes. Based on the context attributes, the system makes logical decisions and distributes the conversations to the correct omni-channel queue or agent. For this preview, context attributes are applicable only for Live Chat work stream.
- **Record Identification Rules**: Record identification rules help agents identify and assist customers better by showing their details on the **Customer 360** page. For more information, see [Configure record identification rule](record-identification-rule.md).

- **Routing rules**: Routing rules are configured for each work stream, so that conversations can be distributed to the correct queues. For more information, see [Create and manage routing rules in omni-channel](routing-rules.md).

## Create a new live chat work stream

Follow these steps to create a new live chat work stream.

1. In the omni-channel site map, select **Work Distribution Management \> Work Streams**.

    The **Active Work Streams** view is shown. 

2. On the command bar, select **New** to create a work stream.
3. On the **Summary** tab of the new work stream page, follow these steps:

   - In the **General information** section, provide the following information: </br>
      1. **Name**: Enter a name for the work stream.
      2. **Capacity**: Specify the units of capacity that are required to process a conversation for the work stream.
      3. **Stream Source**: Select the channel that is supported for the work stream: **Live Chat** or **CDS Entity**. 
            > [!NOTE]
            > If you select **CDS Entity**, see the [CDS entity work stream](#cds-entity-work-stream) section later in this topic.
      4. **Auto-close after inactivity**: Specify the amount of time after which a conversation is moved from the **Waiting** state to the **Closed** state because of inactivity.
      5. **Record Identification Rule**: Follow the steps given in the topic [Configure record identification rule](record-identification-rule.md). 
      6. Select **Save** to save the work stream.

    - In the **Work distribution** section, follow these steps: 
      1. Select whether the work distribution mode should be **Push** or **Pick**.
      2. In the **Notification** field, select the type of notification setting.
      3. In the **Screen pop timeout** field, select the amount of time before the screen pop times out.
         > [!NOTE]
         > The **Notification** and **Screen pop timeout** fields aren't supported in this preview. They will be made available in a future release.

    - In the **Context variables** section, follow these steps: 
       1. Select **New** to create a new context variable for the work stream. 
       2. In the **Quick Create** flyout, enter a name and specify the type for the context variable.
      You can edit, activate, inactivate, or delete a context variable by selecting it in the grid.

7. Define the routing rules in the **Routing Rule Item** tab. To know how to configure a routing rule, see [Create and manage routing rules in Omni-channel](routing-rules.md).

6. Select **Save** to save the Live Chat work stream.

   ![New workstream](../media/omni-channel-new-work-stream.png)

After you've finished defining all the settings, the work stream is ready to receive conversations so that agents can start to work on them.

You can view all active work streams in the **Active Work Streams** view. Before you can use a work stream, you must activate it. To activate a work stream so that it can receive conversations, select the work stream record in the **Active Work Streams** view, and then select **Activate** on the command bar.

You can inactivate a work stream if you don't want it to receive conversations. Select the work stream record in the **Active Work Streams** view, and then select **Deactivate** on the command bar. You can view all inactivated work streams in the **Inactive Work Streams** view. You can also reactivate work streams that have been inactivated.

## CDS Entity work streams

CDS entity work streams help collect conversations from the Common Data Service for Apps system and route them to the omni-channel ecosystem. In this way, omni-channel agents can take on issues that come from Common Data Service for Apps. For example, cases from Common Data Service for Apps can be routed to omni-channel. In that way, agents can help customers who have opened high-priority cases and need help quickly.

> [!NOTE]
> For this preview, CDS Entity work streams can collect and route cases only from the Common Data Service for Apps system. 

## Create a new CDS Entity work stream

To communicate with Common Data Service for Apps, the omni-channel system uses Microsoft Flow. The omni-channel system can accept cases from Common Data Service for Apps only if you complete the following procedures in Omni-channel Engagement Hub and Microsoft Flow.

### In Omni-channel Engagement Hub

1. When you configure the new work stream in omni-channel, ensure that you set the **Stream Source** field to **CDS Entity**.

    ![Setting for CDS in work stream](../media/oc-cds.png)

    Make a note of the ID of the work stream.
1. In the **Work Stream Entity Configuration** section, select **Add New Work Stream Entity Configuration** to add the entity that should be routed. 
2. Activate the entity by selecting it, selecting the ellipsis button (**...**), and then selecting **Activate**.
3. Set up routing rules, agents, and queues for the work stream.

### In Microsoft Flow

1. Go to <portal.office.com>, and select **Flow** in the list of apps.

   ![CDS in Flow](../media/ws-flow.png)

2. Go to **Settings \> Custom Connectors**, and then select **Create Custom Connector** to create a custom connector.

    ![custom connector](../media/custom-connector-settings.png)

4. Enter the name for the custom connector. The name of your environment is the custom connector name here.

    ![Custom connestor name](../media/custom-connector-name.png)
1. On the **Create Custom Connector** menu, select **Import an API file**.

    > [!NOTE]
    > Go to the Download Center, and save the file to your local computer. Select this location from your local machine while importing  the API file and select **Continue**.

5. Select **Test**. When you receive a message that states that you must create a custom connector before you can test the connection, select **Create connector**.

    ![Test connector](../media/test-connector.png)

1. After the connector is created, select **New Connection**. A new connection is created, and the connection name is automatically selected.
2. Provide the following information, and then select **Test Operation** to test the connection:

      1. **Organization ID**: Select your organization ID.
      2. **Live work stream ID**: Select the ID of your live work stream.
      3. **Entity logical name**: Enter the logical name of the Common Data Service for Apps entity that must be routed.
      4. **Entity set name**: Enter the entity name of the Common Data Service for Apps entity that must be routed. (Typically, the end of this name is a plural form of the logical name.)
      5. **Record ID**: Use the dynamic content to select the ID field.
      6. **Relationship name with live work stream**: Enter the logical name of the entity's regarding relationship name with Live conversation.
      7. **Record details**: Use the dynamic content to select **value-key-item-output**.

         ![Connector details](../media/connector-details.png)

         > [!IMPORTANT]
         > At first, the request will fail, and you will receive a 404 error. Continue to test the operation until you receive a 202 response. Usually, the connection takes about 15 minutes to start to work.

8. After the connection is established, and you receive a 202 response, go to **My Flows**.
9. Select **Create from Blank** to create a flow.

    ![create flow](../media/create-flow.png)
1. Update the name of the flow, and enter the environment name.
2. Search for the **Dynamics 365 - When a record is created** trigger, and select it.

    ![Record connector](../media/record-connector.png)

1. Select your organization and the name of the entity that must be routed.
2. Select **New Step \> Add an action**. Search for your custom connector, and then select the action.
3. Provide the following information:

      1. **Entity Logical Name**: Enter the logical name of the Common Data Service for Apps entity that must be routed.
      2. **Entity Set Name**: Enter the entity name of the Common Data Service for Apps entity that must be routed. (Typically, the end of this name is a plural form of the logical name.)
      3. **Record Id**: Use the dynamic content to select the ID field.
      4. **Name of Entity Relationship With**: The logical name of the entity's regarding relationship name with Live conversation (for Incident **incident\_msdyn\_ocliveworkitems**).
      5. **Record Details**: Use the dynamic content to select **value-key-item-output**.
      6. **Organization ID**: Select the ID of your organization.
      7. **Live Work Stream ID**: Select the ID of your live work stream.

         ![connector action](../media/connector-action.png)
         
15. After all the information is entered, select **Test** to test the flow. Then select **I'll perform the trigger action and save the flow**.

    To test the flow with the entity, follow these steps:

    1. Create a new record for the entity that you've selected to route.
    2. Keep the record page filled in Common Data Service for Apps. Immediately after you select **Save & test**, go to Common Data Service for Apps, and save the record. (If you don't save the record immediately, the test operation might miss it.)

        ![Test saved connector](../media/save-connector.png)

After a successful run, you should see the following page.

The setup has now been successfully created. You can now route Common Data Service for Apps entities to the omni-channel system by using Microsoft Flow.

### See also 

[Understand unified routing and work distribution](unified-routing-work-distribution.md)
