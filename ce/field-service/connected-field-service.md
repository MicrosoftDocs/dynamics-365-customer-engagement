---
title: "Connected Field Service - Overview | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
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

Connected Field Service enables organizations to transform the way they provide service from a costly break-fix model to a proactive and predictive service model through the combination of IoT diagnostics, scheduling, asset maintenance, and inventory on the same platform. 

Key benefits of Connected Field Service:

- Reduce downtime by connecting to IoT devices to diagnose problems before customers are aware of an issue
- Address issues faster by remotely monitoring devices and keeping customers in the loop
- Device telemetry and service maintenance data helps to make intelligent decisions around dispatching technicians with the right expertise, availability, and proximity to the job 

There are two offerings you can use to connect IoT-enabled devices into the Field Service solution:
- Connected Field Service for [**Azure IoT Central**](https://azure.microsoft.com/services/iot-central/)
- Connected Field Service for [**Azure IoT Hub**](https://azure.microsoft.com/services/iot-hub/)

See below for the differences between the two offerings.

## Connected Field Service for Azure IoT Central

Connected Field Service for IoT Central provides a direct integration of Dynamics 365 for Customer Engagement for Field Service with Microsoft Azure IoT Central, a fully managed IoT software-as-a-service (SaaS) solution. 

Microsoft Azure IoT Central enables builders to configure rules and actions. Based on those actions, IoT alerts will be created in Connected Field Service. Also, based on service activities in Connected Field Service, information can be sent back to IoT Central. This is accomplished by using Microsoft Flow, a SaaS offering for automating workflows across applications and services. 

> [!div class="mx-imgBorder"]
> ![Diagram showing the relationships between Azure IoT Central, Microsoft Flow, and Field Service](media/cfs-overview.png)
 
The below end-to-end integration processes can be easily implemented based on a pure configuration experience:

- IoT Central can send information about device anomalies to Connected Field Service (as an IoT Alert) for diagnosis
- Connected Field Service can create cases or work orders triggered from device anomalies
- Connected Field Service can schedule technicians for inspection to prevent the downtime incidents. 
- IoT Central device dashboard can be updated with relevant service and scheduling information

Azure IoT Central requires no extensive cloud development or coding skills to get an IoT solution up and running.  

With Microsoft Flow templates, users can connect their accounts, take advantage of our pre-built templates, and customize their own flows in an easy visual designer without the need for coding experience.

Check out our [Connected Field Service for IoT Central tutorial](cfs-iot-tutorial-overview.md) to get started.

## Connected Field Service for Azure IoT Hub
Connected Field Service for Azure IoT Hub is an add-on solution that brings Azure IoT platform-as-a-service (PaaS) offering into Dynamics365 for Field Service. With this offering, you can run a deployment app to put all the Azure IoT services and Dynamics puzzles together.

All Azure IoT services run in your own Azure cloud subscription. Additionally, we provide an enterprise-ready template that you can customize for each Azure IoT service.

## Privacy details for Connected Field Service
[!INCLUDE[cc-privacy-crm-connected-field-service](../includes/cc-privacy-crm-connected-field-service.md)]

### See also  
 [Overview of Dynamics 365 for Customer Engagement for Field Service](../field-service/overview.md)    
 [Install Dynamics 365 for Customer Engagement for Field Service](../field-service/install-field-service.md)   
 [Configure default settings](../field-service/configure-default-settings.md)   
 [View user accounts and security roles](../field-service/view-user-accounts-security-roles.md)<br>
 [Field Service User Guide](../field-service/user-guide.md) 
  

