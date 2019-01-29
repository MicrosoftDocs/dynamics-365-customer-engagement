---
title: Create and manage work streams | MicrosoftDocs
description: See how you can create and manage work streams in the Omni-channel Engagement Hub
keywords: Create and manage work streams; Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 5e6285ee-4b79-473d-b920-d1fab636c82e
ms.custom: 
---
# Create and manage work streams

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Use this topic to know how you can create a live chat work stream and a CDS entity work stream in the Omni-channel Engagement Hub.

## Create a new live chat work stream

Follow these steps to create a new live chat work stream.

1. In the omni-channel site map, select **Work Distribution \> Work Streams**.

    The **Active Work Streams** view is shown. 

    > [!div class=mx-imgBorder] 
    > ![Omni-channel work streams](../media/oc-workstream-view.png)

2. On the command bar, select **New** to create a work stream.
3. In the **Summary** tab of the new work stream page, follow these steps:

   - In the **General information** section, provide the following information: </br>
      1. **Name**: Enter a name for the work stream.
      2. **Capacity**: Specify the units of capacity that are required to process a conversation for the work stream.
      3. **Stream Source**: Select the channel that is supported for the work stream: **Live Chat** or **CDS Entity**. 
         > [!NOTE]
         > If you select **CDS Entity**, see the [CDS entity work stream](#cds-entity-work-stream) section later in this topic.
      4. **Auto-close after inactivity**: Specify the amount of time after which a conversation is moved from the **Waiting** state to the **Closed** state because of inactivity. 
      6. Select **Save** to save the work stream.

    - In the **Work distribution** section, follow these steps: 
      1. Select whether the **Work distribution mode** should be **Push** or **Pick**.
      2. In the **Notification** field, select the type of notification setting.
      3. In the **Screen pop timeout** field, select the amount of time before the screen pop times out.
         > [!NOTE]
         > The **Notification** and **Screen pop timeout** fields aren't supported in this preview. They will be made available in a future release.
      4. Select the **Allowed Presences** from the drop-down list.

    - In the **Context variables** section, follow these steps: 
       1. Select **New** to create a new context variable for the work stream. 
       2. In the **Quick Create** flyout, enter a name and specify the type for the context variable.
      You can edit, activate, inactivate, or delete a context variable by selecting it in the grid.

       > [!div class=mx-imgBorder] 
       > ![New workstream](../media/omni-channel-new-work-stream.png)

4. Define the routing rules in the **Routing Rule Items** tab. To know how to configure a routing rule, see [Create and manage routing rules in Omni-channel](routing-rules.md).

5. In the **Chat settings** tab, follow this step:

     - Add a new chat widget in the **Chat widget** section. For more information, see [Create a chat widget](set-up-chat-widget.md).


6. Add a new chat question and create a question library in the **Survey questions library** tab. For more information, see [Create a question library](create-question-library.md).

7. Select **Save** to save the live chat work stream.

> [!IMPORTANT]
> In this preview, the record identification rules are pre-configured in the work streams out-of-the-box. The rules are further mapped to a limited set of pre-chat survey questions. As a customer completes a pre-chat survey for an incoming conversation, the information can be used to identify the customer. For more information, see [Set up record identification rule](record-identification-rule.md).

After you've finished defining all the settings, the work stream is ready to receive conversations so that agents can start to work on them.


## Create a new CDS Entity work stream

CDS entity work streams help collect conversations from the Common Data Service for Apps system and route them to the omni-channel ecosystem. In this way, omni-channel agents can take on issues that come from Common Data Service for Apps. For example, cases from Common Data Service for Apps can be routed to omni-channel. In that way, agents can help customers who have opened high-priority cases and need help quickly.

> [!NOTE]
> For this preview, CDS Entity work streams can collect and route cases only from the Common Data Service for Apps system. 

To communicate with Common Data Service for Apps, the omni-channel system uses Microsoft Flow. The omni-channel system can accept cases from Common Data Service for Apps only if you complete the following procedures in Omni-channel Engagement Hub and Microsoft Flow.

### In Omni-channel Engagement Hub

1. In the omni-channel site map, select **Work Distribution Management \> Work Streams**.
2. Fill in the **General information** section as given in [Create a new live chat work stream](#create-a-new-live-chat-work-stream). </br>
    When you configure the new work stream in omni-channel, ensure that you set the **Stream Source** field to **CDS Entity**.

    ![Setting for CDS in work stream](../media/oc-cds.png)

    Make a note of the ID of the work stream.
1. Fill in the **Work distribution** section as given in [Create a new live chat work stream](#create-a-new-live-chat-work-stream).
2. In the **Work Stream Entity Configuration** section, select **Add New Work Stream Entity Configuration** to add the entity that should be routed. 
3. Activate the entity by selecting it, selecting the ellipsis button (**...**), and then selecting **Activate**.
4. Set up routing rules, agents, and queues for the work stream. For more information, see [Create a new live chat work stream](#create-a-new-live-chat-work-stream).

### In Microsoft Flow

1. Go to [portal.office.com](https://www.office.com/?auth=2&home=1), and select **Flow** in the list of apps.

   ![CDS in Flow](../media/ws-flow.png)

2. Go to **Settings \> Custom Connectors**, and then select **Create Custom Connector** to create a custom connector.

    ![custom connector](../media/custom-connector-settings.png)

3. Enter the name for the custom connector. The name of your environment is the custom connector name here.

    ![Custom connestor name](../media/custom-connector-name.png)

4. On the **Create Custom Connector** menu, select **Import an API file**.

    > [!NOTE]
    > Go to the Download Center, and save the file to your local computer. Select this location from your local machine while importing  the API file and select **Continue**.

5. Update the host name in the **Genera Information** section in the following format: </br>
    *https://**orguniquename**-public.omnichannelengagementhub.com*

    Where **orguniquename** is the unique name of your org.

    Select **Test** to test the connector.

    > [!div class=mx-imgBorder] 
    > ![update host name](../media/update-host-name.png)

1. When you receive a message that states that you must create a custom connector before you can test the connection, select **Create connector**.

    ![Test connector](../media/test-connector.png)

7. After the connector is created, select **New Connection**. A new connection is created, and the connection name is automatically selected.
8. Provide the following information, and then select **Test Operation** to test the connection:

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

9. After the connection is established, and you receive a 202 response, go to **My Flows**.
10. Select **Create from Blank** to create a flow.

    ![create flow](../media/create-flow.png)
11. Update the name of the flow, and enter the environment name.
12. Search for the **Dynamics 365 - When a record is created** trigger, and select it.

    ![Record connector](../media/record-connector.png)

13. Select your organization and the name of the entity that must be routed.
14. Select **New Step \> Add an action**. Search for your custom connector, and then select the action.
15. Provide the following information:

      1. **Entity Logical Name**: Enter the logical name of the Common Data Service for Apps entity that must be routed.
      2. **Entity Set Name**: Enter the entity name of the Common Data Service for Apps entity that must be routed. (Typically, the end of this name is a plural form of the logical name.)
      3. **Record Id**: Use the dynamic content to select the ID field.
      4. **Name of Entity Relationship With**: The logical name of the entity's regarding relationship name with Live conversation (for Incident **incident\_msdyn\_ocliveworkitems**).
      5. **Record Details**: Use the dynamic content to select **value-key-item-output**.
      6. **Organization ID**: Select the ID of your organization.
      7. **Live Work Stream ID**: Select the ID of your live work stream.

         ![connector action](../media/connector-action.png)
         
16. After all the information is entered, select **Test** to test the flow. Then select **I'll perform the trigger action and save the flow**.

    To test the flow with the entity, follow these steps:

    1. Create a new record for the entity that you've selected to route.
    2. Keep the record page filled in Common Data Service for Apps. Immediately after you select **Save & test**, go to Common Data Service for Apps, and save the record. (If you don't save the record immediately, the test operation might miss it.)

        ![Test saved connector](../media/save-connector.png)

After a successful run, you should see the following page.

The setup has now been successfully created. You can now route Common Data Service for Apps entities to the omni-channel system by using Microsoft Flow.

### See also 

[Understand work streams in the Omni-channel Engagement Hub](work-streams-introduction.md)

