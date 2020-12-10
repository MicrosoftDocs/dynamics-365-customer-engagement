---
title: "Frequently asked questions for Connected Field Service | MicrosoftDocs"
description: Find answers to frequently asked questions for Connected Field Service
ms.custom:
- dyn365-fieldservice
ms.date: 11/19/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: troubleshooting
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

# Frequently asked questions for Connected Field Service

## Why can't I pull device data?

Sometimes you may see there are no records in a device's data history, or there is no data in the device reported properties after pulling device data.  

One reason pull device data may fail (especially if you've successfully registered the device) is because the Azure IoT Hub tier is not set to **S1-Standard**. 

Go to the Azure portal, find your IoT Hub resource, then set pricing and scale tier to **S1-Standard**

> [!div class="mx-imgBorder"]
> ![Screenshot of the pricing and scale tier settings in IoT Hub](./media/cfs-pricing-tier.png)
