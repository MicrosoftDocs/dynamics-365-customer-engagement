---
title: "Associate devices with customer accounts in Connected Field Service | MicrosoftDocs"
description: Learn how to associate devices with customer accounts in Connected Field Service
ms.custom: dyn365-fieldservice
ms.service: dynamics-365-customerservice
ms.date: 09/24/2018
ms.reviewer: krbjoran
ms.topic: article
ms.author: daclar
author: FieldServiceDave
search.app: 
  - D365CE
  - D365FS
--- 

# 2 - Associate devices with customer accounts 

If an IoT device isn't associated with a customer account in Connected Field Service, the system will not be able to generate work orders or cases against incoming alerts. In this tutorial, you'll learn how to associate a device with a customer account. While customer accounts are an optional association in Azure IoT Central, they are required in Connected Field Service.

## Goals

Associate a device in Connected Field Service with a customer account so that work orders or cases can be generated against incoming IoT alerts.

## Steps

1. In your Connected Field Service application, navigate to the device page you wish to associate with a customer account. You can find this under "Devices" in the left-side menu.

> [!div class="mx-imgBorder"]
> ![Screenshot of "Devices" in the menu](media/iot-central-associate-devices-1.png)

2. On the Active Device page, select the dropdown just to the right of "Active IoT Devices" and select the view, "IoT devices without customer account." Select one of these devices.

> [!div class="mx-imgBorder"]
> ![Screenshot of a list of IoT devices in Connected Field Service](media/iot-central-associate-devices-2.png)

3. On the device detail page, start typing the name of the customer account in the "Account" field.

    a. For the purposes of this tutorial, you can select "Active Transport Inc." 
    
> [!div class="mx-imgBorder"]
> ![Screenshot of the account field on the device detail page in Connected Field Service](media/iot-central-associate-devices-3.png)

4. Save the changes you've made (the Save button is in the bottom corner of your window).

## See the results

This device will now be associated with a customer account, and can receive IoT alerts from Azure IoT Central.

> [!div class="nextstepaction"]
> [Step 3: Send work order updates to IoT Central](cfs-iot-central-work-orders.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]