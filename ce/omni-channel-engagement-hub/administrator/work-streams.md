---
title: "Create and manage work streams"
description: 
keywords: ""
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

Work streams define the settings and properties for a specific source or originating point that customer requests or queries can come from. For example, if requests originate from two chat portals, you can create two different work streams for each of them. If conversations are created as case records, you can create a separate work stream for them.

All work streams are associated with unique channels. Channels can be defined for chats, entities, and so on. A work stream can't be associated with more than one channel.

Omni-channel Engagement Hub has some predefined work streams. However, as an admin, you can define new work streams to introduce a new source.

There are two types of work streams:

- Live Chat
- CDS Entity

## Live Chat work streams

When you set up Live Chat work streams, you define the following properties:

> [!NOTE]
> These properties are applicable to Live Chat work streams. To know more about CDS Entity work streams and their properties, see the [CDS entity work stream](#cds-entity-work-stream) section later in this topic.

- **Channels**: In Omni-channel Engagement Hub, a channel is defined as a medium that customers can reach out and engage with agents through. For example, a customer can chat with an agent through the chat channel. As an admin, you can select the channel that a work stream is created for. 

    > [!NOTE]
    > In this preview, work streams can be defined for chat and entity channels.

- **Allowable Presence**: Allowable presence helps assign work streams only to agents whose presence status is one of the **Available** presence statuses that are associated with the work stream. For more information, see [Configure presence and custom presence](presence-custom-presence.md).
- **Capacity**: When a conversation from a work stream is assigned to an agent, it consumes some capacity. The units of capacity are defined as capacity in the work stream. For example, a conversation in the Chat work stream from the portal has a capacity of 20 units. When this conversation is assigned to an agent, it consumes 20 units of agent's capacity.
- **Agent association**: Agents who are associated with a work stream can receive conversations only from that work stream. 
- **Work distribution mode and context attributes**: The context attributes can vary for each work stream. For example, for a chat conversation, context attributes include the browser, IP address, answers to pre-chat questions, and customer ID (for authenticated chat). These variables can then be used to define routing rules that channel conversations to different queues.

    > [!NOTE]
    > The work stream is the area where context variables can be declared and defined, so that the omni-channel system understands the kind of conversations that it will receive. Conversations are preloaded with specific context attributes. Based on the context attributes, the system makes logical decisions and distributes the conversations to the correct omni-channel queue or agent. For this preview, context variables are applicable only to Live Chat.

- **Record Identification Rules**: Record identification rules help agents identify and assist customers better by showing their details on a **Customer 360** page. When an incoming conversation request is received, a notification appears that includes contextual information for the request. When an agent accepts the incoming notification, the **Customer 360** page opens, and shows the details of the customer and case. For more information, see View Customer 360 for an incoming engagement request.

    > [!NOTE]
    > For this preview, you can set up record identification rules while you create a new work stream. These rules are further mapped with a limited set of pre-chat survey questions. For more information, see step 3 of the [Create a new Live Chat work stream](#create-a-new-live-chat-work-stream) procedure later in this topic.

    As a customer completes a pre-chat survey for an incoming conversation, the information can be used to identify the customer. 

- **Routing rules**: Routing rules are configured for each work stream, so that conversations can be distributed to the correct queues. For more information, see [Create and manage routing rules in omni-channel](routing-rules.md).
- **Maximum Concurrency**: Maximum concurrency lets you set the maximum number of conversations that can be assigned to an agent's work list from a work stream.
- **Auto-close after inactivity**: After a specific amount of time, a conversation can be moved from the **Waiting** state to the **Closed** state because of inactivity.

## Create a new Live Chat work stream

Follow these steps to create a new Live Chat work stream.

1. In the omni-channel site map, select **Work Distribution Management \> Work Streams**.

    The **Active Work Streams** view is shown. 

2. On the command bar, select **New** to create a work stream.
3. On the **Summary** tab of the page for the new work stream, follow these steps:

    1. In the **General information** section, provide the following information:

        - **Name**: Enter a name for the work stream.
        - **Capacity**: Specify the units of capacity that are required to process a conversation for the work stream.
        - **Stream Source**: Select the channels that are supported for the work stream: **Live Chat** or **CDS Entity**. For more information, see the [CDS entity work stream](#cds-entity-work-stream) section later in this topic.
        - **Max Concurrency**: Specify the maximum number of concurrent sessions for conversations of the work stream.
        - **Auto-close after inactivity**: Specify the amount of time after which a conversation is moved from the **Waiting** state to the **Closed** state because of inactivity.
        - **Record Identification Rule**: Paste the following code snippet. This snippet helps configure record identifications rules for the work stream.

            ```csharp
            <RecordIdentificationRuleSet>
            <RecordIdentificationRule>
            <PrimaryEntity LogicalCollectionName="accounts" PrimaryKeyAttribute="accountid" PrimaryNameAttribute="name" />
            <fetch version="1.0" output-format="xml-platform" mapping="logical" top="2">
            <entity name="account">
            <attribute name="accountid" />
            <attribute name="name" />
            <filter type="and">
            <condition attribute="name" operator="eq" value="${Name}" />
            <condition attribute="emailaddress1" operator="eq" value="${Email}" />
            <condition attribute="telephone1" operator="eq" value="${Phone}"/>
            </filter>
            </entity>
            </fetch>
            <ContextKey name="msdyn_account_msdyn_ocliveworkitem_Customer" />
            </RecordIdentificationRule>
            <RecordIdentificationRule>
            <PrimaryEntity LogicalCollectionName="contacts" PrimaryKeyAttribute="contactid" PrimaryNameAttribute="fullname" />
            <fetch version="1.0" output-format="xml-platform" mapping="logical" top="2">
            <entity name="contact">
            <attribute name="contactid" />
            <attribute name="fullname" />
            <filter type="and">
            <condition attribute="contactid" operator="eq" source="msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid" value="${msdyn_portalcontactid}" /> 
            <condition attribute="fullname" operator="eq" value="${Name}" />
            <condition attribute="emailaddress1" operator="eq" value="${Email}" />
            <condition attribute="telephone1" operator="eq" value="${Phone}" />
            </filter>
            </entity>
            </fetch>
            <ContextKey name="msdyn_contact_msdyn_ocliveworkitem_Customer" />
            </RecordIdentificationRule>
            <RecordIdentificationRule>
            <PrimaryEntity LogicalCollectionName="incidents" PrimaryKeyAttribute="incidentid" PrimaryNameAttribute="title" />
            <fetch version="1.0" output-format="xml-platform" mapping="logical">
            <entity name="incident">
            <attribute name="incidentid" />
            <attribute name="title" />
            <filter type="and">
            <condition attribute="ticketnumber" operator="eq" value="${CaseNumber}" />
            </filter>
            </entity>
            </fetch>
            <ContextKey name="msdyn_incident_msdyn_ocliveworkitem" />
            </RecordIdentificationRule> 
            </RecordIdentificationRuleSet>
            ```

            > [!NOTE]
            > For each new work stream, update the condition variable values, and make sure that the names are unique and mapped to pre-chat questions (see the tables that follow). For example, if you create a work stream that is linked to the `Name1` and `Phone1` context variables, you must change the condition variable values from `{Name}` to `{Name1}` and from `{Phone}` to `{Phone1}`.

            For the preceding record identification rules to work, you **must** create the following questions for the pre-chat survey.

            **Authenticated chat**

            | Question name  | Answer type    | Question text |
            |----------------|----------------|---------------|
            | CaseNumber     | Multiple lines | Case Number   |

            **Unauthenticated chat**

            | Question name | Answer type    | Question text |
            |---------------|----------------|---------------|
            | CaseNumber    | Multiple lines | Case Number   |
            | Name          | Single line    | Name          |
            | Email         | Single line    | Email         |
            | Phone         | Single line    | Phone         |

            For information about how to create questions and use them in a pre-chat survey, see [Set up a question library](set-up-chat-widget.md#set-up-a-question-library) and [Set up a pre-chat survey](set-up-chat-widget.md#set-up-a-pre-chat-survey).

            > [!NOTE]
            > Make sure that each question name is unique, and that it's used "as is" in the preceding code snippet. Otherwise, the record identification rule won't work. You can provide question text that meets your requirements. 

    2. Select **Save** to save the work stream.
    3. In the **Work distribution** section, follow these steps: 

        1. Select whether the work distribution mode should be **Push** or **Pick**.
        2. In the **Notification** field, select the type of notification setting.
        3. In the **Screen pop timeout** field, select the amount of time before the screen pop times out.

        > [!NOTE]
        > The **Notification** and **Screen pop timeout** fields aren't supported in this preview. They will be made available in a future release.

    4. In the **Context variables** section, select **New** to create a new context variable for the work stream. Then in the **Quick Create** flyout, enter a name for the context variable, and specify the type.

        Context variables help the omni-channel system understand the kind of conversation that it will receive.

        You can edit, activate, inactivate, or delete a context variable by selecting it in the grid.

4. On the **Routing Rule Item** tab, follow these steps to define the routing rules. Routing rules help correctly route the conversations to agents or queues.

    1. Select **Add new Rule Item** to add a routing rule item.
    2. On the **General** tab, in the **General information** section, provide the following information:

        - **Name**: Enter a name for the routing rule item.
        - **Work Stream**: This field is automatically filled in.
        - **Queue**: Look up a queue, or select **New** to add a new queue. For more information, see [Create a new omni-channel queue](queues-omni-channel.md#create-a-new-omni-channel-queue).
        - **Description**: Enter a brief description of the routing rule item.

    3. In the **Condition** section, provide the conditions for the omni-channel routing rule. Based on the conditions that are defined, conversations will be routed to the correct agents or queues. When you define conditions for omni-channel routing rules, you can select any of the following:

        - Entity
        - Attribute
        - Operator
        - Value

        For an entity, you can select among a set of attributes, operators, and values that are related to the entity.

        By using appropriate conditions in the routing rules, you can achieve many more routing combinations to route conversations. Here are some examples:

        - A customer chat request that comes in from the portal, and that has specific answers to the pre-chat survey, should be routed to a specific queue.
        - Incoming custom entities such as **Change_Requests** should be routed to omni-channel queues that have live agents.

        For more information, see [Create and manage routing rules in omni-channel](routing-rules.md).

    4. Select **Save** to save the routing rule item.

5. On the **Agents** tab, select **Add Existing User** to add agents to the work stream. In the **Lookup Records** flyout menu, select the agents to add, and then select **Add**.

    To select users from other views, you can select **Change View** to change the view.

6. Select **Save** to save the Live Chat work stream.

After you've finished defining all the settings, the work stream is ready to receive conversations so that agents can start to work on them.

You can view all active work streams in the **Active Work Streams** view. Before you can use a work stream, you must activate it. To activate a work stream so that it can receive conversations, select the work stream record in the **Active Work Streams** view, and then select **Activate** on the command bar.

You can inactivate a work stream if you don't want it to receive conversations. Select the work stream record in the **Active Work Streams** view, and then select **Deactivate** on the command bar. You can view all inactivated work streams in the **Inactive Work Streams** view. You can also reactivate work streams that have been inactivated.

## CDS Entity work streams

CDS entity work streams help collect conversations from the Common Data Service for Apps system and route them to the omni-channel ecosystem. In this way, omni-channel agents can take on issues that come from Common Data Service for Apps. For example, cases from Common Data Service for Apps can be routed to omni-channel. In that way, agents can help customers who have opened high-priority cases and need help quickly.

> [!NOTE]
> For this preview, CDS Entity work streams can collect and route cases only from the Common Data Service for Apps system. 

To communicate with Common Data Service for Apps, the omni-channel system uses Microsoft Flow. The omni-channel system can accept cases from Common Data Service for Apps only if you complete the following procedures in Omni-channel Engagement Hub and Microsoft Flow.

### In Omni-channel Engagement Hub

1. When you configure the new work stream in omni-channel, make sure that you set the **Stream Source** field to **CDS Entity**.
2. Make a note of the ID of the work stream.
3. In the **Work Stream Entity Configuration** section, select **Add New Work Stream Entity Configuration** to add the entity that should be routed. 
4. Activate the entity by selecting it, selecting the ellipsis button (**...**), and then selecting **Activate**.
5. Set up routing rules, agents, and queues for the work stream.

### In Microsoft Flow

1. Go to <portal.office.com>, and select **Flow** in the list of apps.
2. Go to **Settings \> Custom Connectors**, and then select **Create Custom Connector** to create a custom connector.
3. On the **Create Custom Connector** menu, select **Import an API file**.

    > [!NOTE]
    > Go to the Download Center, and save the file to your local computer. Enter your environment name in the custom connector name and file location from your local machine while importing and this API file and select **Continue**.

4. Enter the name of the custom connector.
5. Select **Test**. When you receive a message that states that you must create a custom connector before you can test the connection, select **Create connector**.
6. After the connector is created, select **New Connection**. A new connection is created, and the connection name is automatically selected.
7. Provide the following information, and then select **Test Operation** to test the connection:

    - **Organization ID**: Select your organization ID.
    - **Live work stream ID**: Select the ID of your live work stream.
    - **Entity logical name**: Enter the logical name of the Common Data Service for Apps entity that must be routed.
    - **Entity set name**: Enter the entity name of the Common Data Service for Apps entity that must be routed. (Typically, the end of this name is a plural form of the logical name.)
    - **Record ID**: Use the dynamic content to select the ID field.
    - **Relationship name with live work stream**: Enter the logical name of the entity's regarding relationship name with Live conversation.
    - **Record details**: Use the dynamic content to select **value-key-item-output**.

    > [!IMPORTANT]
    > At first, the request will fail, and you will receive a 404 error. Continue to test the operation until you receive a 202 response. Usually, the connection takes about 15 minutes to start to work.

8. After the connection is established, and you receive a 202 response, go to **My Flows**.
9. Select **Create from Blank** to create a flow.
10. Update the name of the flow, and enter the environment name.
11. Search for the **Dynamics 365 - When a record is created** trigger, and select it.
12. Select your organization and the name of the entity that must be routed.
13. Select **New Step \> Add an action**. Search for your custom connector, and then select the action.
14. Provide the following information:

    - **Entity Logical Name**: Enter the logical name of the Common Data Service for Apps entity that must be routed.
    - **Entity Set Name**: Enter the entity name of the Common Data Service for Apps entity that must be routed. (Typically, the end of this name is a plural form of the logical name.)
    - **Record Id**: Use the dynamic content to select the ID field.
    - **Name of Entity Relationship With**: The logical name of the entity's regarding relationship name with Live conversation (for Incident **incident\_msdyn\_ocliveworkitems**).
    - **Record Details**: Use the dynamic content to select **value-key-item-output**.
    - **Organization ID**: Select the ID of your organization.
    - **Live Work Stream ID**: Select the ID of your live work stream.

15. After all the information is entered, select **Test** to test the flow. Then select **I'll perform the trigger action and save the flow**.

    To test the flow with the entity, follow these steps:

    1. Create a new record for the entity that you've selected to route.
    2. Keep the record page filled in Common Data Service for Apps. Immediately after you select **Save & test**, go to Common Data Service for Apps, and save the record. (If you don't save the record immediately, the test operation might miss it.)

After a successful run, you should see the following page.

The setup has now been successfully created. You can now route Common Data Service for Apps entities to the omni-channel system by using Microsoft Flow.
