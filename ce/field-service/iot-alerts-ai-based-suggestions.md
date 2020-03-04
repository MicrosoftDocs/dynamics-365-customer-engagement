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

Any situation where there is data followed by actions, is a situation where AI can be applied to benefit an organization. This is especially true for Connected Field Service that "makes IoT data actionable" by allowing an organization to convert IoT alerts into cases and work orders. One way AI is leveraged in Connected Field Service is with a feature called **IoT alert AI-based suggestions** that tages IoT alerts with a suggested priority or incident type based on past service history and actions. For example, an alert suggestion might show that a temperature-based alert is a high priority, and needs an incident type for recalibrating the equipment.

As a reminder:

- An **incident type** is the main issue of a work order and can dictate related details like work order type, products, services, and service tasks. 
- **Priority** in this feature represents the priority to the business generally measured by financial impact or customer satisfaction. As an example, imagine an IoT alerts notifies the organization that the heating of a room is down, and this could have a large impact on an event and customer satisfaction. This would represent a _high_ priority because of the large business impact.

The AI-based suggestions are made possible by a machine learning model that is continuously learning based as more data enters the system in the form of IoT Alert records and as more actions are executed such as when a dispatcher converts an alert into a case or work order. 

Data

Action

Here's how it works. Internet-connected devices create telemetry that is stored in Azure IotHub or Azure IotCentral. If the telemetry breaks predefined rules, then an IoT alert is created in Dynamics 365. SOmetimes, the alerts are converted into cases and work orders After AI-based suggestions are enabled, the system will recommend   

- learning model that will change with more data. looks at how many of similar alerts were converted to cases or work orders
- suggestions 

Benefit:
- more proactive
- assess importance of alerts 
- better allocation of limited resources to issues
- too many alerts
- dont always have to rely on expertise can scale better work order creation




## Prerequisites

Connected Field Service with Azure IoTHub and Azure IoTCentral 


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
- Select **Customer Asset** if your organization primarily manages the IoT alerts from devices related to customer assets. Example: you have customer assets that represent rooms in a building and each room has multiple devices sending telemetry. When work orders are created from these IoT alerts, they are related to a customer asset.

> [!Note]
> If you are unsure of which option to choose or if your organization manages IoT alerts at both the device level and customer asset level equally, then leave this as the default: **Device ID**.


### Enter rule identifier

Choose the rules that you defined in IoTCentral or IoTHub that trigger IoT Alerts. The rule paths can be found in the IoT Alert JSON.

An example of the rule path for IoTCentral is **rule/id**.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-ai-iotc-rule-path.png)

An example of the rule path for IoTHub is **ruleoutput**.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-ai-ioth-rule-path.png)

### Enter device properties

Choose the device properties that should be considered by the AI model to make suggestions. This the telemetry and signals coming from the devices is typicallyreading along with other device variables and characteristics. As an example, an internet-connected thermometer may give a temperature reading of 72 degrees and this temperature output should be considered. 

By default, the **Telemetry** field in IoTCentral and the **Reading Type** and **Reading** fields in IoTHub are used as device properties. However you can add custom fields that you may have added. As an example, you may have a model that associates a financial cost to each temperature reading and this can be added here as a device property to be considered by the AI model.

### Finish

After entering the initial information you are finished and the model will take 24 hours to begin making recommendations. It will look at historical data as well as data going forward.

You'll know the AI based suggestions are working when there is a suggested priority and incident type in the IoT Alert view and form.



## Configuration considerations
- If the model needs to be reconfigured based on changes to the system or evolving business needs, you can go through the set up again by going to **Settings > Settings (in IoT section) > IoT Suggestions section** and selecting **Reconfigure IoT suggestions** in the top ribbon. 
- When applicable the model will return "No suggestion" if there is no recommendation. 
- Suggestions are updated every 24 hours.
- It is recommended to have at least 50 IoT alerts converted to cases or work orders to give the model enough data to make suggestions. 
- Suggestions work whether IoT alerts are converted in to cases or work orders because both have incident types. 
- Suggestions are only displayed in Dynamics 365 Field Service but a simple Power Automate Flow could be used to send and display the suggestions in IoTCentral or IoTHub. 

