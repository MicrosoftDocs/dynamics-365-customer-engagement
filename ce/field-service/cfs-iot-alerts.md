---
title: Create IoT alerts and convert IoT alerts into work orders
description: Learn how to create IoT alerts and convert IoT alerts into work orders with Connected Field Service for Dynamics 365 Field Service.
ms.date: 09/04/2024
ms.subservice: connected-field-service
ms.topic: how-to
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
ms.author: vhorvath
author: vhorvathms
---

# Create IoT alerts and convert IoT alerts into work orders

In Dynamics 365 Field Service, Internet of Things (IoT) alerts are a subset of IoT messages that might require attention. For example, a configured sensor in a refrigerator that you service sends an alert that the humidity is above an acceptable threshold. To help with proactive service delivery, you can convert that incoming IoT alert to a work order, which can then be scheduled and assigned to a service technician.

This article explains the following things:

- How IoT alerts are triggered
- How to see IoT alerts in Field Service
- How to create work orders based on the IoT alerts

For a guided walkthrough, see the following video: ![Video symbol](../field-service/media/video-icon.png "Video symbol") [Connected Field Service: IoT Alerts](https://youtu.be/tkBSLhKNfmQ). 

## Trigger IoT alerts in Azure IoT Hub

As IoT device information flows into Azure IoT Hub, you can create rules that dictate when IoT alerts should be created based on the IoT messages.

1. Sign in to Microsoft Azure and select your resource group.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of Microsoft Azure showing Connected Field Service IoT alert stream analytics.](./media/cfs-iot-alert-stream-analytics1.png)

1. Find and edit the **Stream Analytics job**.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of Microsoft Azure showing the appropriate resource group and stream analytics job.](./media/cfs-iot-alert-stream-analytics.png)

1. Select **Query** in the left pane, then select **IoTStream**.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the query and IoT stream options in the menu.](./media/cfs-iot-alert-stream-analytics2.png)

   With reference to the callouts in the previous image:

   - **(1)**: The bottom pane shows all incoming IoT messages from the connected device.
   - **(2)**: The top pane shows the JSON that creates the IoT alerts from the IoT messages.

### Trigger IoT alerts with the simulator

Set up the simulator to simulate IoT devices and data so that device data is pulled into Field Service.

1. To find the simulator URL, sign in to your Azure subscription, and then select the app service resource type under the newly created resource group.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of resource groups in Azure.](./media/cfs-iot-alert-simulator1.png)

1. The URL appears in the top-right corner. Copy the URL. 

   > [!div class="mx-imgBorder"]
   > ![Screenshot showing where to find the URL in the resource group.](./media/cfs-iot-alert-simulator2.png)

1. Paste the URL into your browser’s address bar to load the page.  
  
1. When the simulator page opens, select **Connection** at the top.  
  
1. Enter the IoT hub host name and key. The host is the name of the IoT Hub resource in the Azure portal. 

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the "configure connection" dialog in Azure.](./media/cfs-iot-alert-simulator-connection.png)

1. To access the key, select the IoT Hub resource and go to the shared access policies. Then, copy the primary key for **iothubowner**.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of Azure IoT Hub showing the primary key.](./media/cfs-simulator-connection.png)
  
1. Select the IoT hub in the **Resource Group**.  
  
1. On the left under **General**, select **Shared access policies** to get the host name and primary key.  
  
1. Ensure **Connection status** is marked as **Connected** and then close the dialog box.  

1. Send a test command by using the sample simulator. For example, select the temperature and increase it to above 70 degrees. The simulator is preprogrammed to create an IoT alert if the temperature is above 70 degrees.

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the IoT alert simulator.](./media/cfs-iot-alert-simulator3.png)

   > [!Note]
   > **Not using Azure IoT Hub?** Creating IoT alerts in Field Service based on IoT messages in your custom IoT provider is supported. For more information, see this article: [Extensible IoT data sources for Connected Field Service](cfs-custom-iot-provider.md). 

   After the rule is created in Stream Analytics, the logic app creates IoT alerts based on the rule criteria. 

   > [!div class="mx-imgBorder"]
   > ![Screenshot of the Azure resource group.](./media/cfs-iot-alert-logic-app.png)

## View IoT alerts in Field Service

In our example with the simulator, an IoT alert was created in Field Service because the temperature reading in an IoT message exceeded 70 degrees.

1. In Dynamics 365 Field Service, under **Assets**, select **IoT Alerts**.

   :::image type="content" source="media/cfs-iot-alert-from-simulator.png" alt-text="Screenshot of all active IoT alerts in Field Service, highlighting one.":::

1. Open an alert. The **Alert Data** section shows the details in the JSON message.

## Convert an IoT alert to a work order

To take action against the IoT alert, use the business process flow that's built into  Field Service.

1. In Dynamics 365 Field Service, under **Assets**, select **IoT Alerts**.

1. Open an alert. The business process flow appears at the top of the page.

1. Create a case to investigate remotely. Select **Created** > **Next Stage** > **Create**.

   :::image type="content" source="media/cfs-iot-alert-next-stage.png" alt-text="Screenshot of an open IoT alert in Field Service, showing the business process flow for create a case.":::

1. Select **Save & Close**. The **Case** page appears.

1. If the potential issue can't be identified or resolved remotely, advance to the next step in the business process flow to create a work order. Select **Create Case** > **Next Stage** > **Create**.

1. Enter the information for the work order.

1. Select **Save & Close**. The **Work Order** page appears. The IoT alert is referenced on the work order form. The technician can see it on their mobile device.

1. If applicable, you can schedule the work order.

## Organize IoT alerts

Multiple IoT alerts might be created for the same IoT device for the same issue. The system recognizes similar IoT alerts and groups them together.

1. In Dynamics 365 Field Service, under **Assets**, select **IoT Alerts**. The hierarchy icon identifies a group of similar alerts.

   :::image type="content" source="media/cfs-iot-alert-parent1.png" alt-text="Screenshot of Field Service IoT alerts, showing an icon that indicates similar alerts.":::

1. Select the hierarchy icon next to an IoT alert to see similar IoT alerts for the same device around the same time.

   :::image type="content" source="media/cfs-iot-alert-parent-diagram.png" alt-text="Screenshot of related IoT alerts in Field Service.":::

## IoT alerts parenting

When an IoT alert is created in Connected Field Service, aggregation rules decide if the alert should be parented under another existing alert since the alert might be for a device or asset that already has an open alert. With autoparenting, you can avoid overrunning the alert list with many alerts for the same issue.

1. Under **IoT**, select **Settings** > **Alert Aggregation Rules**.

   :::image type="content" source="media/iot-alert-parenting-1.png" alt-text="IoT settings in Field Service, on the Alert Aggregation Rules tab.":::

1. Select the fields to use to group similar IoT alerts, if any.

   If an alert matches all the selected fields and the alert time falls within five minutes of the previous alert, the alert is parented. If you disable all the fields, the default setting applies. The default parents an alert if the device ID matches another alert and the alert time falls within five minutes.

   If the alert time field doesn't have a value, the system uses the **Created On** field on the IoT alert record to make sure it falls within five minutes of other matching alerts.

### Change or disable parent settings

When a parent alert is found, the system checks to see if the matched alert has a parent, in which case the new alert is linked to the existing parent alert. If the matching alert doesn't have a parent, the new alert is linked to the matching alert, which becomes the parent alert.

To make the five-minute rule longer or shorter, modify the workflow "debounce" period.

1. Sign in to [Power Apps](https://make.powerapps.com/) and select **Solutions** and your organization's solution.
1. Under **Objects**, select **Processes**.
1. Search for and open **IoT - Parent Iot Alerts**.

   :::image type="content" source="media/iot-alert-parenting-3.png" alt-text="Power Apps showing IoT Parent Alerts with view properties highlighted.":::

1. Select **View properties**.
1. Change the value based on the number of seconds you want for the debounce period. Then, select **Save and Close**.

To completely turn off the autoparent feature, disable the workflow or flow depending on whether your organization uses enhanced background processing controlled through Field Service settings. For more information, go to [Use Enhanced Background Processing](/dynamics365/field-service/configure-default-settings#other-settings).

:::image type="content" source="media/iot-alert-parenting-4.png" alt-text="Power Apps showing IoT Parent Alerts with turning off highlighted.":::

[!INCLUDE[footer-include](../includes/footer-banner.md)]
