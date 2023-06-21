---
title: Extend Connected Field Service solutions
description: "Connected Field Service supports the customization of each standard component or service and the easy addition of custom Azure-based components and services."
ms.date: 09/07/2022
ms.topic: article
ms.author: vhorvath
author: vhorvathms
search.audienceType: 
  - developer
ms.custom: 
  - dyn365-developer
  - dyn365-fieldservice
---

# Extend Connected Field Service solutions

[!INCLUDE[pn_connected_field_service_msdyn365](../includes/pn-connected-field-service-msdyn365.md)] supports the customization of each standard component or service and the easy addition of custom Azure-based components and services. This flexible architecture is required to support the wide range of current and future IoT devices and the envisioned supporting services for these devices.  
  
## Extend Azure Services

Azure services and components, including the ones detailed in [Connected Field Service architecture](connected-field-service-architecture.md), are designed for reliability, scalability, and extensibility. They support management and customization through UI-based and PowerShell administration, JSON-based template-driven deployment and initialization, and REST-based programming interfaces (often including client libraries for specific languages, such as C#/.NET, Python, Java, and Node.js).  
  
 After the standard installation, Connected Field Services will configure your resource group with a set of Azure services similar to the following screenshot.  
  
 ![Connected Field Service Standard Azure Services.](media/iot-standard-azure-service.jpg "Connected Field Service Standard Azure Services")  
  
 Although extending these Azure services or adding other ones is beyond the scope of this article, there are several resources available:  
  
- [Microsoft Azure](https://azure.microsoft.com/) site for product descriptions, pricing and trial offers.
- [Azure Documentation Center](https://azure.microsoft.com/documentation/) for developers and administrators.
- [Azure SDKs](https://azure.microsoft.com/downloads/) and tools.
- [Shows](/shows/) for a wide selection of current and ever-growing videos.
  
## Extend Connected Field Service

> [!NOTE]
> The Web API types and operations mentioned in this article/table are available in your environment and you can use the service document of your environment or Postman to explore these types and operations. More information: [Web API Service Documents](/power-apps/developer/data-platform/webapi/web-api-service-documents) and [Use Postman with Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/use-postman-web-api).

The following table lists the custom entities and processes that Connected Field Service supplies to interface with the associated Azure services and components. These types are more fully described in `Microsoft.Dynamics.CRM.IoTConnector`.
  
|Display Name (ID)|Type|Description|  
|-------------------------|----------|-----------------|  
|IoT – Debounce IoT Alerts (`Microsoft.Dynamics.CRM.msdyn_ParentIoTAlerts`)|Action|Links potential redundant alerts to an existing parent alert|  
|IoT - Parent IoT Alerts|Workflow|Calls the `IoT - Debounce IoT Alerts` action and passes 60 for the `TimespanSeconds` parameter|  
|IoT – Register Custom Entity (`Microsoft.Dynamics.CRM.msdyn_RegisterCustomEntity`)|Action|Registers any custom entity that may or may not already have connected IoT devices. This action invokes the `IoT – Register Device` action.|  
|IoT – Register Device (`Microsoft.Dynamics.CRM.msdyn_RegisterIoTDevice`)|Action|Publishes the registration requests for an IoT device|  
|IoT – Send Test Alert (`Microsoft.Dynamics.CRM.msdyn_IoTSendTestAlert`)|Action|*Reserved for future use*|  
|JSON-based Field Value – Get Boolean (`Microsoft.Dynamics.CRM.msdyn_JsonGetBoolean`)|Action|Reads a Boolean property in the specified JSON object|  
|JSON-based Field Value – Get Number (`Microsoft.Dynamics.CRM.msdyn_JsonGetNumber`)|Action|Reads a numeric property in the specified JSON object|  
|JSON-based Field Value – Get String (`Microsoft.Dynamics.CRM.msdyn_JsonGetString`)|Action|Reads a string property in the specified JSON object|  
|IoT Alert (`Microsoft.Dynamics.CRM.msdyn_iotalert`)|Entity|Represents a notable event sent from the associated IoT Hub|  
|IoT Device (`Microsoft.Dynamics.CRM.msdyn_iotdevice`)|Entity|Represents a connected device that can be registered with a IoT Hub|  
|IoT Device Category (`Microsoft.Dynamics.CRM.msdyn_iotdevicecategory`)|Entity|Represents a logical grouping of IoT devices|  
|IoT Device Command (`Microsoft.Dynamics.CRM.msdyn_iotdevicecommand`)|Entity|Represents an outgoing message to a device connected to the IoT Hub|  
|IoT Device Registration History (`Microsoft.Dynamics.CRM.msdyn_iotdeviceregistrationhistory`)|Entity|Tracks registration activities of an IoT device|  
  
### IoT enabling an entity type

Dynamics 365 entities can be associated to IoT entities listed above so that within Dynamics 365 they can participate in IoT-related business processes and analyses. There are two methods of “IoT enabling” a Dynamics 365 entity; you can:  
  
- Programmatically form an association through the standard Dynamics 365 [Connection entities](../developer/connection-entities.md) capability. You can alternatively accomplish this same association through the administration UI; for more information, see [Create connections to view relationships between records](/dynamics365/customerengagement/on-premises/basics/create-connections-view-relationships-between-records).  
  
- Call the `IoT – Register Custom Entity` action to associate an entity with an existing or new `IoT Device`.  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
