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

This topic explains how you can create a live chat work stream and a CDS entity work stream in the Omni-channel Engagement Hub.

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
      2. **Stream Source**: Select the channel that is supported for the work stream: **Live Chat** or **CDS Entity**. 
         > [!NOTE]
         > If you select **CDS Entity**, see the [CDS entity work stream](#cds-entity-work-stream) section later in this topic.
      3. **Capacity**: Specify the units of capacity that are required to process a conversation for the work stream.
      5. **Auto-close after inactivity**: Specify the amount of time after which a conversation is moved from the **Waiting** state to the **Closed** state because of inactivity. 
      6. Select **Save** to save the work stream.

    - In the **Work distribution** section, follow these steps: 
      1. Select whether the **Work distribution mode** should be **Push** or **Pick**.
      2. In the **Notification** field, select the type of notification setting.
      3. In the **Screen pop timeout** field, select the amount of time before the screen pop times out.
      4. Select the **Allowed Presences** from the drop-down list.

       > [!div class=mx-imgBorder] 
       > ![New workstream](../media/omni-channel-new-work-stream.png)

4. Define the routing rules in the **Routing Rule Items** tab. To know how to configure a routing rule, see [Create and manage routing rules in Omni-channel](routing-rules.md).

5. In the **Chat settings** tab, follow this step:

     - Add a new chat widget in the **Chat widget** section. For more information, see [Create a chat widget](set-up-chat-widget.md).


6. Add a new chat question and create a question library in the **Survey questions library** tab. For more information, see [Create a question library](create-question-library.md).

7. Select **Save** to save the live chat work stream.

> [!IMPORTANT]
> You can view customer details for an incoming conversation with the help of customer summary identification rules pre-configured in the work streams out-of-the-box. These rules are further mapped to a limited set of pre-chat survey questions. As a customer completes a pre-chat survey for an incoming conversation, the information can be used to identify the customer. </br> </br> To know more about how to configure pre-chat survey questions, see [Set up pre-chat questions to automatically load customer details](record-identification-rule.md)

After you've finished defining all the settings, the work stream is ready to receive conversations so that agents can start to work on them.

## Create a new CDS Entity work stream

CDS entity work streams help route entities from Common Data Service (CDS) to the Omni-channel Engagement Hub. For example, you can enable high-priority cases to be routed to omni-channel so that they can be automatically distributed and assigned to agents.

> [!NOTE]
> You can route any activity enabled entity.

To set up CDS entity routing, you need to configure a work stream in Omni-channel Engagement Hub
and set up a corresponding flow in Microsoft Flow. Follow the detailed steps as given below.

### In Omni-channel Engagement Hub

1. In the omni-channel site map, select **Work Distribution \> Work Streams**.
2. Fill in the **General information** section as given in [Create a new live chat work stream](#create-a-new-live-chat-work-stream).
    For CDS work stream, select **Stream Source** as **CDS Entity**.

    ![Setting for CDS in work stream](../media/oc-cds.png)

    
1. Fill in the **Work distribution** section as given in [Create a new live chat work stream](#create-a-new-live-chat-work-stream).
2. In the **Work Stream Entity Configuration** section, select **Add** to add the entity that should be routed. 
3. Set up routing rules and queues for the work stream. For more information, see [Create a new live chat work stream](#create-a-new-live-chat-work-stream).

### In Microsoft Flow

1. Go to [portal.office.com](https://www.office.com/?auth=2&home=1), and select **Flow** in the list of apps.

   ![CDS in Flow](../media/ws-flow.png)

2. Go to **Settings \> Custom Connectors**, and then select **Create Custom Connector** to create a custom connector.

    ![custom connector](../media/custom-connector-settings.png)

3. Enter the name for the custom connector.

    ![Custom connector name](../media/custom-connector-name.png)

4. On the **Create Custom Connector** menu, select **Import an API file** and import **CSS-Entity.swagger.json** file. 

    > [!NOTE]
    > You can get **CSS-Entity.swagger.json** file from Insider portal. 

5. Update the host name in the **General Information** section in the following format: </br>
    *https://**orguniquename**-public.omnichannelengagementhub.com*

    You can get **orguniquename** from  [Organization unique name](../../developer/developer-resources-page.md#organization-unique-name).

    > [!div class=mx-imgBorder] 
    > ![update host name](../media/update-host-name.png)

6. Select **Test** to test the connector.

1. Select **Create connector** to create a new connector.

    ![Test connector](../media/test-connector.png)

7. After the connector is created, select **New Connection**. A new connection is created, and the connection name is automatically selected.
8. Provide the following information, and then select **Test Operation** to test the connection:

      1. **Organization ID**: Enter your organization ID.
      2. **Work stream ID**: Enter the ID of your work stream. You can get the work stream ID. 
    a. **Entity logical name**: Enter the logical name of the CDS entity  that must be routed.
    b. **Entity set name**: Enter the entity name of the CDS entity that must be routed. (Typically, this is a plural form of the logical name.)
    c. **Record ID**: Use the Dynamics content to select the ID field.
    d. **Relationship name with work stream**: Enter the logical name of the entity regarding relationship name with conversation.

         ![Connector details](../media/connector-details.png)

         > [!IMPORTANT]
         > At first, the request will fail, and you will receive a 404 error. Continue to test the operation until you receive a 202 response. Usually, the connection takes about 15 minutes to start to work. 

9. After the connection is established, and you receive a 202 response, go to **My Flows**.
10. Select **Create from Blank** to create a flow.

    ![create flow](../media/create-flow.png)
11. Update the name of the flow, and enter the environment name.
12. Search for the **Dynamics 365 - When a record is created** trigger, and select it.

    ![Record connector](../media/record-connector.png)

13. Select **New Step \> Add an action**. Search for your custom connector, and then select the action.
2. Provide the following information:

      1. **Entity Logical Name**: Enter the logical name of the CDS entity that must be routed.
      2. **Entity Set Name**: Enter the entity name of the CDS entity that must be routed. (Typically, this is a plural form of the logical name.)
      4. **Name of Entity Relationship With**: The logical name of the entity's regarding relationship name with conversation (for Incident **incident\_msdyn\_ocliveworkitems**).
      6. **Organization ID**: Enter the ID of your organization.
      7. **Work Stream ID**: Enter the ID of your work stream.

         ![connector action](../media/connector-action.png)
         
16. After all the information is entered, select **Test** to test the flow. Then select **I'll perform the trigger action and save the flow**.

    To test the flow with the entity, follow these steps:

    1. Create a new record for the entity that you've selected to route.
    2. Keep the record page filled in CDS entity. Immediately after you select **Save & test**, go to CDS entity, and save the record. (If you don't save the record immediately, the test operation might miss it.)

        After a successful run, you should see the following page.


        ![Test saved connector](../media/save-connector.png)


Flow has been configured to route CDS entity to Omni-channel. You can now route CDS entities to the Omni-channel Engagement Hub using Microsoft Flow.

### See also 

[Understand work streams in the Omni-channel Engagement Hub](work-streams-introduction.md)

