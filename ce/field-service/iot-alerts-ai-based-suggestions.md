---
title: "IoT alert AI-based suggestions | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/02/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# IoT alert AI-based suggestions

As IoT device alerts are received, it helps to have smart suggestions about how to treat the alert, like suggesting priority or incident type. New IoT alert suggestions add AI-based suggestions for the priority and incident type from the alert, based on past service history and actions. For example, an alert suggestion might show that a temperature-based alert is a high priority, and needs an incident type for recalibrating the equipment.

As a reminder:

- An **incident type** is the main issue of a work order and can dictate related details like work order type, products, services, and service tasks. 
- **Priority** in this feature represents the priority to the business generally measured by financial impact or customer satisfaction. As an example, imagine an IoT alerts notifies the organization that the heating of a room is down, and this could have a large impact on an event and customer satisfaction. This would represent a _high_ priority because of the large business impact.

Businesses continue to leverage IoT capabilities to further delivery of proactive service to customers. Understanding and taking quick action on IoT alerts improves service delivery. This feature helps businesses assess the importance of alerts and when to take action to improve proactive service delivery.

- learning model that will change with more data. looks at how many of similar alerts were converted to cases or work orders
- suggestions 
Benefit:
- better allocation of limited resources to issues
- too many alerts
- dont always have to rely on expertise can scale better work order creation




## Prerequisites

Connected Field Service with Azure IoTHub and Azure IoTCentral 

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Instructions

From the Field Service app go to **Settings > Settings (in IoT section) > IoT Suggestions section**

Set the IoT suggestions setting to **Enabled**. 

### Agree to terms of use

First agree to the terms of service and select **Next**.

### Select device identifier

Select how your organization primarily uses IoT alerts in relatioon to devices and customer assets. As a reminder, there is a 1:Many relationship, where many devices can be related to one customer asset.

- Select **Device ID** if your organization primarily manages the IoT alerts from individual devices. Example: you have internet-connected thermometers that send temperature readings.
- Select **Customer Asset** if your organization primarily manages the IoT alerts from devices related to customer assets. Example: you have customer assets that represent rooms 
device or customer asset
leave as device by default

### Enter rule identifier

### Enter device properties

- OOB - reading type and telemetry value
- custom - cost savings

### Finish
- takes 24 hours to apply, looks at historical data 

can reconfigure at any time 

youll know its working when it returns priority and incident types

## Configuration considerations
- can use other metrics and models to calculate other variables such as comfort index
- updated every 24 hours
- should have at least 50 cases or work orders created from IoT alerts
- will still work whether converting to case or work order


## Additional Notes
- only seeing suggestions in dynamics but can use FLow to send back to IoTHub or IotCentral