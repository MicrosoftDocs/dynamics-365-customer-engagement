---
title: "Connected Field Service for Azure IoT Central - Overview | MicrosoftDocs"
ms.custom: dyn365-fieldservice
ms.date: 11/08/2018
ms.author: vihuang
ms.reviewer: krbjoran
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
author: FieldServiceDave
ms.manager: shellyhaverkamp
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
--- 

# Connected Field Service for Azure IoT Central - Overview

Connected Field Service for Azure IoT Central provides a direct integration of Dynamics 365 Field Service with Azure IoT Central, a fully managed IoT software-as-a-service (SaaS) solution. 

Azure IoT Central enables builders to configure rules and actions. Based on those actions, IoT alerts will be created in Connected Field Service. Also, based on service activities in Connected Field Service, information can be sent back to Azure IoT Central. This is accomplished by using Power Automate, a SaaS offering for automating workflows across applications and services. 

> [!div class="mx-imgBorder"]
> ![Diagram representing the relationship between Azure IoT Central, Power Automate, and Connected Field Service](media/cfs-overview.png)
 
The below end-to-end integration processes can be easily implemented based on a pure configuration experience:

- Azure IoT Central can send information about device anomalies to Connected Field Service (as an IoT Alert) for diagnosis.
- Connected Field Service can create cases or work orders triggered from device anomalies.
- Connected Field Service can schedule technicians for inspection to prevent the downtime incidents. 
- Azure IoT Central device dashboard can be updated with relevant service and scheduling information.

Azure IoT Central requires no extensive cloud development or coding skills to get an IoT solution up and running.  

With Power Automate templates, users can connect their accounts, take advantage of our pre-built templates, and customize their own flows in an easy visual designer without the need for coding experience.

For a guided walkthrough, see the following video.

>[!VIDEO https://www.microsoft.com/videoplayer/embed/RE4ynS4]

## Tutorial - Get integration scenarios ready in minutes
Connect Azure IoT Central to Connected Field Service using Power Automate in just a matter of minutes with these tutorials. Be sure to [check out the prerequisites](cfs-iot-central-setup.md) before getting started. 
1. [Receive Azure IoT alerts from Azure IoT Central](cfs-iot-central-alerts.md)
2. [Associate devices with customer accounts](cfs-iot-central-associate-devices.md)
3. [Send work order updates to Azure IoT Central](cfs-iot-central-work-orders.md)
4. [Send booking updates to Azure IoT Central](cfs-iot-central-bookings.md)

## Learn more about Azure IoT Central
- [What is Azure IoT Central?](https://docs.microsoft.com/azure/iot-central/overview-iot-central)
- [Tour of Azure IoT Central user interface](https://docs.microsoft.com/azure/iot-central/overview-iot-central-tour)
- [Create a new application in Azure IoT Central - tutorial](https://docs.microsoft.com/azure/iot-central/quick-deploy-iot-central)


