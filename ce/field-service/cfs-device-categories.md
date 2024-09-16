---
title: Use device categories in Connected Field Service
description: Learn how to use device categories in Connected Field Service.
ms.date: 09/04/2024
ms.topic: how-to
ms.subservice: connected-field-service
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
ms.author: vhorvath
author: vhorvathms
---

# Use device categories in Connected Field Service

Device categories help you organize Internet of Things (IoT) devices. For example, you can categorize devices by the commands they support, the type of device, or by devices that break down more often.  
  
## Create a new IoT device category
  
1. In Dynamics Field Service, go to the **Settings** area.

1. Under **IoT**, select **Device Categories**. Then, select **New**.  
  
1. Enter a **Name** for the device category and select **Save**.  
  
1. Open the IoT device category record that you created.  
  
1. In the **Devices** section, select **New IoT Device**.

1. Enter the name of the device and use the tooltips to help you fill in your information. Then, select **Save & Close**.
  
1. Continue to add devices for this device category.

## Add devices to an existing category  
  
1. In Dynamics Field Service, go to the **Service** area.

1. Under **Assets**, select **IoT Devices**.  
  
1. Open an IoT device record.  
  
1. In the **Category** field, search for and select the device category. Then, select **Save & Close**.
  
## View device readings

Once a device is registered, you can open the record to view the readings sent by the device. For example, if you’re monitoring a thermostat, your reading shows the thermostat temperature.  
  
By default, you can view the last 20 readings. You can change the default setting in the Power BI report by using Power BI Desktop.  
  
1. To view a device reading, from the main menu, go to **Field Service** > **Customer Asset**.  
  
2. From the list of assets, choose an asset and open the record.  
  
3. Refer to the **Connect Device Readings** section to view the device readings.
  
## Remotely send commands to a registered device

 When a device isn’t working properly, the system receives an alert. To troubleshoot the issue remotely, you can send a command by choosing a registered device or by using an existing IoT alert.  
  
> [!NOTE]
> When you receive multiple alerts from the same device, the alerts are listed in hierarchical order. You can change the grouping by changing the IoT - Parent IoT Alerts workflow.

### View a device's registration history  

1. In Dynamics Field Service, go to the **Service** area.  

1. Under **Assets**, select **IoT Devices**.  
  
1. Open an IoT device record.  
  
1. Select the **Registration History** tab.  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
