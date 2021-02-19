---
title: "Create IoT Alerts and convert IoT Alerts into work orders | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 02/20/2021
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

# Create IoT Alerts and convert IoT Alerts into work orders

IoT alerts are a subset of IoT messages that may require attention. 


// https://msit.microsoftstream.com/video/7a11a1ff-0400-b564-2c53-f1eb658dc97a

In this doc we will review how IoT alerts are triggered, how to view IoT Alerts in Field Service, and then how to create work orders based on the IoT Alerts. 

## Trigger IoT Alerts in Azure IoT Hub 

As IoT messages flow into Azure IoT Hub, you can create rules that dicatate when IoT alerts should be created based on the IoT messages.

View and edit the criteria in Stream Analytics in your Resource Group.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-stream-analytics1.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-stream-analytics.png)






> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-stream-analytics2.png)

### Trigger IoT Alerts with the simulator



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-simulator1.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-simulator2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-simulator3.png)

> [!Note]
> **Not using Azure IoT Hub?** Creating IoT Alerts in Field Service based on IoT messages in your custom IoT provider is supported. See the topic on [Extensible IoT data sources for Connected Field Service](cfs-custom-iot-provider.md) for more details. 



## View IoT Alerts in Field Service


cfs-iot-alert-from-simulator

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-form.png)



## Convert an IoT Alert to a work order


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-list.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-create-work-order.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-next-stage.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-work-order2.png)



## Organize IoT Alerts


Group IoT alerts

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-parent1.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-parent-diagram.png)


[IoT alert AI suggestions](iot-alerts-ai-based-suggestions)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iot-alert-high-priority.png)


## Configuration considerations
## Additional Notes
