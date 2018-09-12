---
title: "Connected Field Service for IoT Central - Overview | MicrosoftDocs"
ms.custom: "dyn365-fieldservice"
ms.date: 09/24/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shellyhaverkamp"
ms.assetid: 49207db9-d1f0-46e0-ae2c-f4acf4593da9
caps.latest.revision: 24
ms.author: "krbjoran"
ms.manager: "shellyhaverkamp"
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
--- 

# Connected Field Service for IoT Central - Overview

Connected Field Service for IoT Central provides a direct way to integrate Dynamics 365 for Field Service with Azure IoT Central, a fully managed IoT software-as-a-service (SaaS) solution. Build workflows between Connected Field Service with Microsoft Flow, a service that makes it easy to create workflows between your apps and services to synchronize files, get notifications, collect data, and more. 

You can connect IoT Central and Connected Field Service in such a way that:

- IoT Central can send information about device anomalies to Connected Field Service for diagnosis
- Connected Field Service can create work orders triggered from device anomalies
- Connected Field Service can then schedule a technician to fix or prevent the downtime incident
- IoT Central dashboard can update device records with relevant service and scheduling information

With Azure IoT Central, there's no need for extensive cloud development or coding skills to get up and running. The solution is a fully managed offering.

## Tutorial - Get integration scenarios ready in minutes
Connect IoT Central to Connected Field Service using Microsoft Flow in just a matter of minutes with these tutorials! Be sure to check out the prerequisites before getting started. 
1. [Receive IoT alerts from IoT Central](cfs-iot-central-alerts.md)
2. [Associate devices with customer accounts](cfs-iot-central-associate-devices.md)
3. [Send work order updates to IoT Central](cfs-iot-central-work-orders.md)
4. [Send booking updates to IoT Central](cfs-iot-central-bookings.md)

## Learn more about Azure IoT Central
- [What is IoT Central?](https://docs.microsoft.com/en-us/azure/iot-central/overview-iot-central)
- [Tour of Azure IoT Central user interface](https://docs.microsoft.com/en-us/azure/iot-central/overview-iot-central-tour)
- [Create a new application in IoT Central - tutorial](https://docs.microsoft.com/en-us/azure/iot-central/quick-deploy-iot-central)
