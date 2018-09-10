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

[!INCLUDE[pn_connected_field_service_msdyn365](../includes/pn-connected-field-service-msdyn365.md)] helps service organizations move from a costly break-fix model to a more proactive service model by combining monitoring and predictive maintenance with Internet of Things (IoT). Key benefits of Connected Field Service:  
-   Reduce downtime with proactive alerts from connected devices.  
-   Address issues faster by remotely monitoring devices and keeping customers in the loop.   
-   Reduce maintenance costs by dispatching a technician with the right expertise, availability, and location to the job.  
 
There are **two solutions** you can use to connect devices into the world of Field Service: 

- Connected Field Service for **Azure IoT Central** 
- Connected Field Service for **Azure IoT Hub** 

See below for the differences between the two solutions. 

## Connected Field Service for Azure IoT Central 

Integrate Dynamics 365 for Field Service with Azure IoT Central, a fully managed software-as-a-service (SaaS) solution. Using Microsoft Flow's user-friendly interace, you'll be able to connect IoT Central and Connected Field Service in such a way that: 

- IoT Central will send information about device anomalies to Connected Field Service, which will then create a work order and schedule a technician to fix or prevent 
- Connected Field Service will create work orders based off of device anomalies 
- Connected Field Service will then schedule the appropriate technician to address the work order
- IoT Central will update with relevant work order information

With Azure IoT Central, there's no need for extensive cloud development or coding skills to get up and running. The solution is a fully managed offering. 

Check out our [overview on Connected Field Service for IoT Central](cfs-iot-central-overview.md) for more information.
 
  
## Connected Field Service for Azure IoT hub 
 
An add-on solution that brings Azure IoT PaaS offering into Dynamics365 for Field Service. Run a deployment app to put all the Azure IoT services and Dynamics puzzles together.  
 
All Azure IoT services are running in your own Azure cloud subscription and we built an enterprise ready template and you have all the control to customize the open source template for each Azure IoT service.  
  
> [!NOTE]
> [!INCLUDE[cc_feature_included_with_2016_update_d365_online](../includes/cc-feature-included-with-update-2016.md)]  <!-- This may be the incorrect token. It was added to fix a build issue. -->  
  
 To learn more, see ![Video button](../field-service/media/video-button.PNG "Video button")[Video: Use Connected Field Service to remotely monitor and service customer equipment (2:59)](http://go.microsoft.com/fwlink/p/?LinkID=830138)  

## Privacy notice  
 [!INCLUDE[cc_privacy_crm_connected_field_service](../includes/cc-privacy-crm-connected-field-service.md)]
  
### See also  
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)    
 [Install Dynamics 365 for Field Service](../field-service/install-field-service.md)   
 [Configure default settings](../field-service/configure-default-settings.md)   
 [View user accounts and security roles](../field-service/view-user-accounts-security-roles.md)<br>
 [Field Service Users Guide](../field-service/user-guide.md) 
