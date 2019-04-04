---
title: "Connected Field Service with IoTHub Architecture | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/03/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: gregdegruy
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

# Connected Field Service with IoTHub Architecture

Connected Field Service with IoTHub brings together AzureIoT and Dynamics 365 for Field Service, here is an explanation of the architecture.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/cfs-iothub-architecture.png)


**IoT Devices & Edge** - Internet connected sensors on equipment send data to IoTHub typically via WiFi or cellular connectivity. A single piece of equipment can have multiple sensors each taking different measurements such as temperature and pressure. If a building or area has a collection of equipment each with multiple sensors then they can be organized into an **Edge**. 

**Device Simulator** - administrators can simulate devices and telemetry for testing and development purposes before the hardware (devices) are set up.

## Prerequisites
> [!Note]
>



## Configuration considerations
## Additional Notes

### See also