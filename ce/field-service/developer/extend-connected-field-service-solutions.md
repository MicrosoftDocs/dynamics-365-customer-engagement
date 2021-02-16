---
title: "Extend Connected Field Service solutions (Developer Guide for Dynamics 365) | MicrosoftDocs"
description: "Connected Field Service supports the customization of each standard component or service and the easy addition of custom Azure-based components and services."
ms.custom: 
  - dyn365-developer
  - dyn365-fieldservice
ms.date: 10/31/2017
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: d29a9353-73cf-4b49-b74f-d9050dc96bd7
caps.latest.revision: 7
author: FieldServiceDave
ms.author: daclar
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365FS
---

# Extend Connected Field Service solutions

[!INCLUDE[pn_connected_field_service_msdyn365](../../includes/pn-connected-field-service-msdyn365.md)] supports the customization of each standard component or service and the easy addition of custom Azure-based components and services. This flexible architecture is required to support the wide range of current and future IoT devices and the envisioned supporting services for these devices.  
  
## Extend Azure Services

 The Azure services and components, including the ones detailed in [Connected Field Service architecture](connected-field-service-architecture.md), are designed for reliability, scalability, and extensibility.  They support management and customization through UI-based and PowerShell administration, JSON-based template-driven deployment and initialization, and REST-based programming interfaces (often including client libraries for specific languages, such as C#/.NET, Python, Java, and Node.js).  
  
 After the standard installation, Connected Field Services will configure your resource group with a set of Azure services similar to the following.  
  
 ![Connected Field Service Standard Azure Services](../media/iot-standard-azure-service.jpg "Connected Field Service Standard Azure Services")  
  
 Although extending these Azure services (or adding additional ones) is beyond the scope of this topic, there are ample resources available to the developer, including the following from Microsoft:  
  
-   The [Microsoft Azure](https://azure.microsoft.com/) site for product descriptions, pricing and trial offers, documentation, downloads, blogs, and related resources, including the [Azure Documentation Center](https://azure.microsoft.com/documentation/) for developers and administrators. Most developers will want to download one or more [Azure SDKs](https://azure.microsoft.com/downloads/) and tools such as the [Azure Storage Explorer](https://storageexplorer.com/) and the [Azure Device Explorer](https://github.com/fsautomata/azure-iot-sdks/blob/master/tools/DeviceExplorer/doc/how_to_use_device_explorer.md).  
  
-   [MSDN Azure Technical Documentation Library](https://msdn.microsoft.com/library/azure/dn578280.aspx) for developer-oriented information and downloads  
  
-   [MSDN Channel 9](https://channel9.msdn.com/) for a wide selection of current and ever-growing [Azure videos and posts](https://channel9.msdn.com/tags/Azure/)  
  
-   Books from [Microsoft Press](https://www.microsoftpressstore.com/) (including [free eBooks](https://mva.microsoft.com/ebooks/)) and supplemental training through [Microsoft Virtual Academy](https://mva.microsoft.com/)  
  
## Extend Connected Field Service  
 The following table lists the custom entities and processes that Connected Field Service supplies to interface with the associated Azure services and components. These types are more fully described in <xref:Microsoft.Dynamics.CRM.IoTConnector>.
  
|Display Name (ID)|Type|Description|  
|-------------------------|----------|-----------------|  
|IoT – Debounce IoT Alerts (<xref:Microsoft.Dynamics.CRM.msdyn_ParentIoTAlerts>)|Action|Links potential redundant alerts to an existing parent alert|  
|IoT - Parent IoT Alerts|Workflow|Calls the `IoT - Debounce IoT Alerts` action and passes 60 for the `TimespanSeconds` parameter|  
|IoT – Register Custom Entity (<xref:Microsoft.Dynamics.CRM.msdyn_RegisterCustomEntity>)|Action|Registers any custom entity that may or may not already have connected IoT devices. This action invokes the `IoT – Register Device` action.|  
|IoT – Register Device (<xref:Microsoft.Dynamics.CRM.msdyn_RegisterIoTDevice>)|Action|Publishes the registration requests for an IoT device|  
|IoT – Send Test Alert (<xref:Microsoft.Dynamics.CRM.msdyn_IoTSendTestAlert>)|Action|*Reserved for future use*|  
|JSON-based Field Value – Get Boolean (<xref:Microsoft.Dynamics.CRM.msdyn_JsonGetBoolean>)|Action|Reads a Boolean property in the specified JSON object|  
|JSON-based Field Value – Get Number (<xref:Microsoft.Dynamics.CRM.msdyn_JsonGetNumber>)|Action|Reads a numeric property in the specified JSON object|  
|JSON-based Field Value – Get String (<xref:Microsoft.Dynamics.CRM.msdyn_JsonGetString>)|Action|Reads a string property in the specified JSON object|  
|IoT Alert (<xref:Microsoft.Dynamics.CRM.msdyn_iotalert>)|Entity|Represents a notable event sent from the associated IoT Hub|  
|IoT Device (<xref:Microsoft.Dynamics.CRM.msdyn_iotdevice>)|Entity|Represents a connected device that can be registered with a IoT Hub|  
|IoT Device Category (<xref:Microsoft.Dynamics.CRM.msdyn_iotdevicecategory>)|Entity|Represents a logical grouping of IoT devices|  
|IoT Device Command (<xref:Microsoft.Dynamics.CRM.msdyn_iotdevicecommand>)|Entity|Represents an outgoing message to a device connected to the IoT Hub|  
|IoT Device Registration History (<xref:Microsoft.Dynamics.CRM.msdyn_iotdeviceregistrationhistory>)|Entity|Tracks registration activities of an IoT device|  
  
### IOT enabling an entity type

 [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] entities can be associated to IoT entities listed above so that within [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] they can participate in IoT-related business processes and analyses. There are two methods of “IoT enabling” a [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] entity; you can:  
  
- Programmatically form an association through the standard Dynamics 365 [Connection entities](../../developer/connection-entities.md) capability. You can alternatively accomplish this same association through the administration UI; for more information, see [Create connections to view relationships between records](https://docs.microsoft.com/dynamics365/customer-engagement/basics/create-connections-view-relationships-between-records).  
  
- Call the `IoT – Register Custom Entity` action to associate an entity with an existing or new `IoT Device`.  
  
  A common example of this capability is to associate a [Customer Asset](https://www.microsoft.com/dynamics/crm-customer-center/configure-and-set-up-customer-assets-field-service.aspx) to an `IoT Device`.


[!INCLUDE[footer-include](../../includes/footer-banner.md)]