---
title: "Send booking updates to Azure IoT Central | MicrosoftDocs"
description: Learn about how to send booking updates to Azure IoT Central from Connected Field Service.
ms.custom: dyn365-fieldservice
ms.date: 09/24/2018
ms.service: dynamics-365-customerservice
ms.topic: article
ms.author: daclar
author: FieldServiceDave
ms.reviewer: krbjoran
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
--- 

# 4 - Send booking updates to Azure IoT Central

Now that you've configured Connected Field Service to send service updates back to IoT Central, let's make it so booking details are sent back too.

## Goal
Make Connected Field Service send booking updates to Azure IoT Central when a resource is booked in Connected Field Service.

## Steps
1. Head over to the [Power Automate templates page](https://preview.flow.microsoft.com/templates/) and search for the following template: "**[Sample Contoso] When a technician is booked in Connected Field Service, update Azure IoT Central with the details.**"

2. Once you've selected the template, you'll be asked to sign in with both your Dynamics 365 account and Azure IoT Central account.

> [!div class="mx-imgBorder"]
> ![Screenshot of the account association page in Power Automate](media/iot-central-bookings-1.png)

3. Like with work order updates in step 3 of this tutorial, this Flow template will be mostly ready-to-go. To get it working, you need to update the following (see screenshots below for reference):

    a. Add your Dynamics 365 organization name in the corresponding fields in **Get the work order**, **Get the alert**, and **Get the resource details**.

    b. Add your IoT Central application name in the field for **Application**.
    
> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Automate template, with letters for reference to correspond with the instructions](media/iot-central-bookings-2.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Automate template, with letters for reference to correspond with the instructions](media/iot-central-bookings-3.png)

4. Save the flow.

5. Head on back to your Field Service environment and open the schedule board. Find a resource that matches your IoT requirements, based on criteria such as location and alert type. Confirm the booking for the work order that was generated in response to the IoT alert.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Schedule Board in Field Service, booking a resource](media/iot-central-bookings-4.png)

## See the results

Back in Azure IoT Central, you'll now see booking information associated with this device, such as technician name, estimated arrival time, and estimated service duration.

> [!div class="mx-imgBorder"]
> ![Screenshot of the device page in Azure IoT Central, which now includes booking details](media/iot-central-bookings-5.png)

You've now completed the tutorials. Nice work.


[!INCLUDE[footer-include](../includes/footer-banner.md)]