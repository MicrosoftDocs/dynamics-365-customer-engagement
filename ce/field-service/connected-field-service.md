---
title: "Connected Field Service - Overview | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: 2142d996-008b-4ada-bf2e-e9dc316715c4
caps.latest.revision: 14
ms.author: krbjoran
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Connected Field Service - Overview

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_connected_field_service_msdyn365](../includes/pn-connected-field-service-msdyn365.md)] helps service organizations move from a costly break-fix model to a more proactive service model by transforming device health data and maintenance data into proactive actions via the Internet of Things (IoT). Key benefits of Connected Field Service:

- Reduce downtime by identifying IoT alerts and fixing potential problems with customer assets before they happen.
- Address issues faster by remotely monitoring devices and keeping customers in the loop.
- Device telemetry and ongoing maintenance data help you make informed decisions around dispatching technicians with the right expertise, availability, and proximity to the job. 

There are **two solutions** you can use to connect IoT-enabled devices into the world of Field Service:
- Connected Field Service for **Azure IoT Central**
- Connected Field Service for **Azure IoT Hub**

See below for the differences between the two solutions.

## Connected Field Service for Azure IoT Central
Connected Field Service for IoT Central provides a direct way to integrate Dynamics 365 for Field Service with Azure IoT Central, a fully managed IoT software-as-a-service (SaaS) solution. Build workflows between Connected Field Service with Microsoft Flow, a service that makes it easy to create workflows between your apps and services to synchronize files, get notifications, collect data, and more. 

You can connect IoT Central and Connected Field Service in such a way that:
- IoT Central can send information about device anomalies to Connected Field Service
- Connected Field Service can create work orders triggered from device anomalies
- Connected Field Service can then schedule a technician to fix or prevent the downtime incident
- IoT Central dashboard can update device records with relevant service and scheduling information

With Azure IoT Central, there's no need for extensive cloud development or coding skills to get up and running. The solution is a fully managed offering.

Check out our overview on [Connected Field Service for IoT Central for more information](cfs-iot-central-overview.md).

## Connected Field Service for Azure IoT hub
Connected Field Service for Azure IoT Hub is an add-on solution that brings the Azure IoT platform-as-a-service (PaaS) offering into Dynamics365 for Field Service. With this offering, you can run a deployment app to pull all the Azure IoT services and Dynamics puzzles together.

All Azure IoT services are running in your own Azure cloud subscription; we built an enterprise-ready template so you'll have all the control to customize the open-source template for each Azure IoT service.
  
### See also  
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)    
 [Install Dynamics 365 for Field Service](../field-service/install-field-service.md)   
 [Configure default settings](../field-service/configure-default-settings.md)   
 [View user accounts and security roles](../field-service/view-user-accounts-security-roles.md)<br>
 [Field Service Users Guide](../field-service/user-guide.md) 
