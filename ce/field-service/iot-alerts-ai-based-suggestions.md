---
title: AI suggestions for IoT alerts
description: Use AI to investigate and address IoT issues before they happen, by learning from previous actions taken on alerts.
ms.date: 06/23/2023
ms.subservice: connected-field-service
ms.topic: how-to
ms.author: vhorvath
author: vhorvathms
---

# AI suggestions for IoT alerts

AI suggestions for IoT alerts use IoT data by converting IoT alerts into cases and work orders, enabling organizations to investigate and address issues before they happen. AI suggestions can also learn from previous actions taken on IoT alerts, providing recommendations on priority and incident types. For example, if your organization regularly receives IoT alerts indicating a machine's temperature exceeding the acceptable threshold. In such cases, your organization frequently converts these alerts into work orders. The AI IoT model uses this historical data to learn from the actions. When a new temperature alert arrives that surpasses the temperature threshold, the AI recognizes it and suggests appropriate actions.

Implementing these IoT alert suggestions to:

- Gain insights into the prioritization of IoT alerts.
- Improve your ability to proactively address critical issues.
- Optimize the allocation resources to IoT alerts that require further action, such as cases and work orders.
- Use AI to learn from experienced personnel's knowledge in effectively responding to issues identified through IoT data.

## Prerequisites

- IoT for Field Service is set up to use one of the following options:
  
  - [Connected Field Service for Azure IoT Hub](installation-setup-iothub.md)
  - [IoT provider for custom IoT solutions](cfs-custom-iot-provider.md)

- [Configured Incident types](configure-incident-types.md) that refer to the primary problem addressed in a work order and determines the associated details such as work order type, products, services, and service tasks.

- Priority settings on IoT alerts indicate the level of importance to the business, typically assessed based on factors like incurred cost or customer satisfaction.

- To provide the model with sufficient data for generating accurate suggestions, it's recommended to have a minimum of 50 IoT alerts that have been converted into cases or work orders.

## Enable IoT suggestions

1. In Field Service, change to the **Settings** area.
1. Under **IoT**, select **Settings** and go to the **IoT Suggestions** tab.
1. Set the **IoT suggestions** toggle to **Enabled**.

A guided experience to set up IoT suggestion launches.

If the model needs to be reconfigured based on changes to the system or changing business needs, you can launch the guided experience selecting **Reconfigure IoT suggestions** in the IoT suggestion settings.

### Step 1: Accept the terms of service

Agree to the terms of service, and select **Next**.

### Step 2: Select device identifier

Select how your organization primarily uses IoT alerts in relation to devices and customer assets. As a reminder, there's a one-to-many relationship, where many devices can be related to one customer asset.

> [!div class="mx-imgBorder"]
> ![Screenshot of the IoT suggestions setup screen, showing the device identifier section.](./media/cfs-iot-suggestions-identifier.png)

- Choose **Device ID** if your organization primarily manages the IoT alerts from individual devices like thermometers that send temperature readings.
- Choose **Customer Asset** if your organization primarily manages the IoT alerts from devices related to customer assets.

If you're not sure which option to choose or if your organization manages IoT alerts at both the device level and customer asset level, choose the default **Device ID** option.

### Step 3: Enter rule identifier

Choose the rules that you defined in IoT provider that trigger IoT alerts. The rule paths can be found in the IoT alert JSON.

An example of the rule path for IoT Hub is `ruleoutput`.

### Step 4: Enter device properties

Select the device properties that the AI model should consider when generating suggestions. These properties encompass the signals originating from connected devices, and other variables and characteristics associated with the devices. For example, an internet-connected thermometer that provides a temperature reading of 72 degrees. This temperature value should be taken into consideration when making suggestions.

> [!div class="mx-imgBorder"]
> ![Screenshot of the IoT suggestions setup screen, showing the device properties section.](./media/cfs-iot-suggestions-properties.png)

By default, the **Reading Type** and **Reading** fields in IoT Hub are used as device properties. However, you can also add custom fields. For example, you may have a model that associates a financial cost to each temperature reading. This custom addition can be added as a device property for the AI model to consider.

### Step 5: Finish

After completing the setup process, you begin receiving recommendations within 24 hours. The AI model analyzes both historical data and incoming data moving forward. Suggestions refresh and update every 24 hours.

To verify that the AI-based suggestions are functioning properly, check the **Prioritized IoT Alerts view** on **IoT Alerts**, where you find suggested priorities and incident types.

The priority and suggested incident type is also displayed on the IoT alert records.

> [!div class="mx-imgBorder"]
> ![Screenshot of an IoT alert showing the suggestion pane.](./media/cfs-iot-suggestions-alerts-drill-down.png)

The AI model assigns a priority score to alerts based on historical alerts and relevant entities. A dynamic threshold differentiates between alerts with high and low priority, depending on how quick they require a reaction. The model optimizes this threshold during each training cycle to adapt to changing data patterns. With dynamic distribution, previously scored alerts remain relevant as the model continues to learn and enhance its capabilities. The model returns **No suggestions** if there's no recommendation.

## Next steps

- [Create IoT alerts and convert IoT alerts into work orders](cfs-iot-alerts.md)
- [IoT integration with Connected Field Service](cfs-connect-data-overview.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
