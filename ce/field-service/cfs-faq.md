---
title: "Frequently asked questions for Connected Field Service | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 11/19/2020
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

# Frequently asked questions for Connected Field Service

## Why can't I Pull Device Data?

Sometimes you may see there are no records in Device Data History for a device or there is no data in the Device Reported Properties after Pulling devic data.  

One reason Pull device data may fail especially if registering devices works, is the IoT Hub tier is not set to "S1-Standard". 

Go to the Azure portal, then find your IoT Hub resource, then set Pricing and scale tier to "S1-Standard".

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-pricing-tier.png)



