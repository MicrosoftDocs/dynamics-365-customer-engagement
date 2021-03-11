---
title: "Create IoT alerts and convert IoT alerts into work orders with Connected Field Service for Dynamics 365 Field Service | MicrosoftDocs"
description: Learn how to create IoT alerts and convert IoT alerts into work orders with Connected Field Service for Dynamics 365 Field Service
ms.custom:
- dyn365-fieldservice
ms.date: 03/10/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Create IoT alerts and convert IoT alerts into work orders

Within Dynamics 365 Field Service, IoT alerts are a subset of IoT messages that may require attention. For instance, maybe a configured sensor in a refrigerator you service has alerted that humidity has risen above an acceptable threshold. To help with proactive service delivery, you can convert that incoming IoT alert directly to a work order, which can then be scheduled and assigned to a service technician. 

In this aritlce, we will review:

- How IoT alerts are triggered 
- How to see IoT alerts in Field Service 
- How to create work orders based on the IoT alerts. 

## Trigger IoT Alerts in Azure IoT Hub 

As IoT device information flows into Azure IoT Hub, you can create rules that dictate when IoT alerts should be created based on the IoT messages.

> [!div class="mx-imgBorder"]
> ![Screenshot of Microsoft Azure showing Connected Field Service IoT alert stream analytics.](./media/cfs-iot-alert-stream-analytics1.png)

You can find and edit these criteria in **Stream Analytics** in your resource group.

> [!div class="mx-imgBorder"]
> ![Screenshot of Microsoft Azure showing the appropriate resource group and stream analytics job.](./media/cfs-iot-alert-stream-analytics.png)

Go to **Query** in the left pane, then select **IoTStream**. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the query and IoT stream options in the menu.](./media/cfs-iot-alert-stream-analytics2.png)

With reference to the callouts in the previous image:

- **(1)**: the bottom pane shows all incoming IoT messages from the connected device. 
- **(2)**: the top pane shows the JSON that creates IoT alerts from IoT messages.


### Trigger IoT alerts with the simulator

Set up the simulator to simulate IoT devices and data in order to see device data pulled into Field Service.

To find the simulator URL, sign in to your Azure subscription, and then select the app service resource type under the newly created resource group. 

> [!div class="mx-imgBorder"]
> ![Screenshot of resource groups in Azure.](./media/cfs-iot-alert-simulator1.png)

You’ll see the URL in the top-right corner. Copy the URL. 

> [!div class="mx-imgBorder"]
> ![Screenshot showing where to find the URL in the resource group.](./media/cfs-iot-alert-simulator2.png)

Complete the following steps:
  
1. Paste the URL into your browser’s address bar to load the page.  
  
2. When the simulator page opens, select **Connection** at the top.  
  
3. Enter the IoT hub host name and key. The host is the name of the IoT Hub resource in the Azure portal. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the "configure connection" dialog in Azure.](./media/cfs-iot-alert-simulator-connection.png)

 The key can be accessed by selecting the IoT Hub resource and going to the shared access policies, then copying the primary key for **iothubowner**, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of Azure IoT Hub showing the primary key.](./media/cfs-simulator-connection.png)
  
1. Select the IoT hub in the **Resource Group**.  
  
2. On the left under **General**, select **Shared access policies** to get the host name and primary key.  
  
3. Make sure **Connection status**  is marked as **Connected** and then close the dialog box.  

Now you can send a test command by using the sample simulator. For example, select the temperature and increase it to above 70 degrees. The simulator is preprogrammed to create an IoT alert if temperature is above 70 degrees.


> [!div class="mx-imgBorder"]
> ![Screenshot of the IoT alert simulator.](./media/cfs-iot-alert-simulator3.png)

> [!Note]
> **Not using Azure IoT Hub?** Creating IoT alerts in Field Service based on IoT messages in your custom IoT provider is supported. For more information, see this article: [Extensible IoT data sources for Connected Field Service](cfs-custom-iot-provider.md). 

After the rule is created in Stream Analytics, the logic app will create IoT alerts based on the rule criteria. 


> [!div class="mx-imgBorder"]
> ![Screenshot of the Azure resource group.](./media/cfs-iot-alert-logic-app.png)

## View IoT Alerts in Field Service

In our example with the simulator, an IoT alert was created in Field Service because the temperature reading in an IoT message exceeded 70 degrees. 

> [!div class="mx-imgBorder"]
> ![Screenshot of all active IoT alerts in Field SErvice, highlighting one with a temperature of 71 degrees.](./media/cfs-iot-alert-from-simulator.png)

The IoT alert form shows more details and the **Alert Data** section shows the details in the JSON message. 

> [!div class="mx-imgBorder"]
> ![Screenshot of an IoT alert form, showing the Alert Data section.](./media/cfs-iot-alert-form.png)

## Convert an IoT alert to a work order

Use the business process flow to take action against the IoT alert.

> [!div class="mx-imgBorder"]
> ![Screenshot of an IoT alert in Field Servive highlighting the business process flow.](./media/cfs-iot-alert-bpf.png)

Create a case related the IoT alert to investigate remotely.

> [!div class="mx-imgBorder"]
> ![Screenshot of the IoT alert, showing the create step in the business process flow.](./media/cfs-iot-alert-next-stage.png)

If the potential issue can't be identified or resolved, advance to the next step in the business process flow to create a work order. 


> [!div class="mx-imgBorder"]
> ![Screenshot of the quick-create work order form from the case we created from the IoT alert.](./media/cfs-iot-alert-create-work-order.png)


The IoT alert is referenced on the work order form and can be accessed by the technician on their mobile device. 


> [!div class="mx-imgBorder"]
> ![Screenshot of a work order showing the related IoT alert in the primary incident section.](./media/cfs-iot-alert-work-order2.png)



## Organize IoT Alerts

It is possible for multiple IoT alerts to be created for the same IoT device for the same issue.

The system recognizes similar IoT alerts and groups them together. 

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service IoT alerts, showing an icon that indicates they are grouped.](./media/cfs-iot-alert-parent1.png)

Select the group icon next to an IoT alert to see similar IoT alerts for the same device around the same time. 

> [!div class="mx-imgBorder"]
> ![Screenshot of related IoT alerts in Field Service.](./media/cfs-iot-alert-parent-diagram.png)

You can also use AI to suggest which IoT alerts are higher priority based on historical data, like which IoT alerts were converted to work orders. For more information, see this article: [IoT alert AI suggestions](iot-alerts-ai-based-suggestions.md). 


> [!div class="mx-imgBorder"]
> ![Screenshot of prioritized IoT alerts in Field Service.](./media/cfs-iot-alert-high-priority.png)

