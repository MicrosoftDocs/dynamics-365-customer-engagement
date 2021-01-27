---
title: "Device categories in Connected Field Service | MicrosoftDocs"
description: Learn about how to use device categories in Connected Field Service
ms.custom:
- dyn365-fieldservice
ms.date: 11/19/2020
ms.reviewer: krbjoran
ms.topic: article
ms.service: dynamics-365-customerservice
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

# Device categories in Connected Field Service

Device categories help you organize devices.

You can also manage devices by categorizing them. For example, you can categorize devices by the commands they support, the type of device, or by devices that break down more often.  
  
### Create a new IoT device category
  
1. From the main menu, go to **Settings** > **Device Categories**.  
  
2. On the command bar, select **New**.  
  
3. Enter a **Name** for the device category.  
  
4. Use the helpful tooltips to fill in information.  
  
5. When you're done, select **Save**.  
  
6. Open the IoT device category record that you created.  
  
7. In the **Devices** section, select **Add IoT Device record, and then add a device to the category.  
  
### Add devices to an existing category  
  
1. From the main menu, go to **Internet of Things** > **Registered Devices**.  
  
2. Choose an IoT device record to open it.  
  
3. In the **Category** field, use the search button to find and add the device to a category.  
  
## View device readings

Once a device is registered, you can open the record to view the readings sent by the device. For example, if you’re monitoring a thermostat, your reading will show the thermostat temperature.  
  
By default, you can view the last 20 readings. You can change the default setting in the Power BI report by using Power BI Desktop.  
  
1. To view a device reading, from the main menu, go to **Field Service** > **Customer Asset**.  
  
2. From the list of assets, choose an asset and open the record.  
  
3. Refer to the **Connect Device Readings** section to view the device readings.  
  
## Remotely send commands to a registered device

 When a device isn’t working properly, the system receives an alert. To troubleshoot the issue remotely, you can send a command by choosing a registered device or by using an existing IoT alert.  
  

> [!NOTE]
>  When you receive multiple alerts from the same device, the alerts will be listed in hierarchical order. You can change the grouping by changing the IoT - Parent IoT Alerts workflow.

### View a device's registration history  
  
1. From the main menu, go to **IoT Devices**.  
  
2. Select an IoT device record to open it.  
  
3. In the category field, use the search button to find and to add the device to a category.  