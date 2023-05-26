---
title: "Develop customized IoT solutions in Connected Field Service | MicrosoftDocs"
description: "Connected Field Service integrates Internet of Things (IoT) devices with Dynamics 365 (online) to enable their registration, monitoring and management into established business processes."
ms.date: 01/05/2018

ms.topic: get-started-article
ms.author: vhorvath
author: vhorvathms
search.audienceType: 
  - developer
ms.custom: 
  - dyn365-developer
  - dyn365-fieldservice
---
# Develop customized IoT solutions in Connected Field Service

[!INCLUDE[pn_connected_field_service_msdyn365](../../includes/pn-connected-field-service-msdyn365.md)] integrates Internet of Things (IoT) devices with [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] to enable their registration, monitoring and management into established business processes. This guide explains the component architecture, supplied interfaces and customization points, and explains the approach to develop customized IoT solutions.  
  
## Supported Developer Scenarios

Connected Field Service supports the following two primary development scenarios:  
  
- Extend [!INCLUDE[pn_connected_field_service_msdyn365](../../includes/pn-connected-field-service-msdyn365.md)] so that manufacturers and hardware service organizations can register, monitor, and manage—including controlling and correcting—IoT devices. 
  
- Provide an IoT Platform that ISVs and partners can build on to IOT-enable their [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] custom entities and managed solutions.  
  
 To enable the first scenario, the following capabilities are supported:  
  
- Abstract device registration in an action, so that devices can be easily registered using the CRM web client or the mobile client  
  
- Enable any CRM entity to be IOT-enabled, enabling straightforward IoT integration within existing business processes by using [Connection entities](../../developer/connection-entities.md)  
  
- Receive service alerts and automating their response with a customized workflow  
  
- Send remote commands to IoT devices, for example after diagnosing a problem to correct a malfunctioning device  
  
- Analyze incoming device data, and displaying aggregate, trend and other metrics in custom dashboards  
  
[!INCLUDE [footer-banner](../../includes/footer-banner.md)]
