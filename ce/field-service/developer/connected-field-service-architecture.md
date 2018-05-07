---
title: "Connected Field Service architecture (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Connected Field Service is a distributed solution whose architecture reflects its dependence upon multiple components within both Dynamics 365 and Microsoft Azure services."
ms.custom: dyn365-fieldservice; dyn365-developer
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d4729c71-35d1-4286-ac83-f421904685f7
caps.latest.revision: 9
author: JimDaly
ms.author: jdaly
manager: jdaly
---
# Connected Field Service architecture

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_connected_field_service_msdyn365](../../includes/pn-connected-field-service-msdyn365.md)] is a distributed solution whose architecture reflects its dependence upon multiple components within both [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] and [!INCLUDE[pn_Windows_Azure](../../includes/pn-windows-azure.md)] services.  
  
## High-level component architecture  
 The following diagram illustrates the high-level components and services found in the standard installation of Connected Field Service for Dynamics 365 and its supporting Azure resources. In this initial release, the IoT functionality in [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] is tied directly into [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)].  
  
 ![Connected Field Service Component Architecture Diagram](../media/iot-component-architecture-diagram-1.jpg "Connected Field Service Component Architecture Diagram")  
  
 The following table describes the components in this diagram.  
  
|Component or service|Description/Purpose|  
|--------------------------|--------------------------|  
|[Dynamics 365](http://www.microsoft.com/dynamics/dynamics-365)|Includes the CRM Service and [!INCLUDE[pn_field_service](../../includes/pn-field-service.md)].  The Connected Field Service feature is only available in the online version of [!INCLUDE[pn_ms_dyn_365](../../includes/pn-ms-dyn-365.md)]. [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] provides support for popular mobile clients, which can be used to register and monitor assets in the field.|  
|[Azure Service Bus](https://azure.microsoft.com/services/service-bus/)|Provides a channel for both inbound and outbound messages flowing between [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] (CRM) and Azure: IoT Hub alerts sent to CRM, and CRM commands sent to the IoT Hub.|  
|[Azure Logic Apps](https://azure.microsoft.com/services/logic-apps/)|Custom Azure applications that provide orchestration logic that uses the CRM Connector and the Queue Connector. The CRM Connector is used construct CRM-specific entities, whereas the Queue Connectors for polling the Azure Service Bus queue.|  
|[Azure IoT Hub](https://azure.microsoft.com/services/iot-hub/)|Enables applications and administrators to connect, monitor, and manage IoT devices at scale. All the inbound messages received from and outbound messages sent to devices are routed through this service.|  
|[Azure Storage](https://azure.microsoft.com/services/storage/)|Provides persistence using a set of standard structures that include [Blob storage](https://azure.microsoft.com/services/storage/blobs/) (object storage), [Table storage](https://azure.microsoft.com/services/storage/tables/), and [File storage](https://azure.microsoft.com/services/storage/files/). Stream Analytics queries use Blob storage.|  
|Databases|For longer-term storage and querying of raw data, events, and analytical data: commonly [Azure SQL](https://azure.microsoft.com/services/sql-database/) for relational data and [DocumentDB](https://azure.microsoft.com/services/documentdb/) for semi-structured data. Connected Field Service uses SQL Azure to store device heartbeat messages for later use by PowerBI to display the status of devices in [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)].|  
|[Azure Stream Analytics](https://azure.microsoft.com/services/stream-analytics)|Provides self-managed, real-time event processing and analysis on streaming data, such as IoT data feeds.  Supports comparing different streams or with historical values and models. It can detect anomalies, shape incoming data, trigger alerts and provide real-time metrics. Ad-hoc queries are supported through an SQL-based language.  Stream Analytics is configured to pump filtered alerts into an Azure Service Bus queue, which then delivers these to [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)].|  
|Thermostat Simulator|A test web app that provides sample temperature and humidity device data and responds to a small set of device-specific commands.|  
|[Power BI service](https://powerbi.microsoft.com/)|[*Optional*] Provides advanced analysis and 360-degree visualization of data sets, with rich interaction models and natural search features.|  
  
 Note that this list is not exhaustive when considering your customized solution, as there are other Azure services or custom components that could be used.  For example, [Azure Machine Learning](https://azure.microsoft.com/services/machine-learning/) could be employed to discern patterns in the incoming device data in order to predict likely device malfunctions.  
  
 The red components in the diagram represent likely areas for developer customization when creating solutions for your organization.  For example, your solution will probably have its own simulator for your device type(s) and a custom workflow to handle device alerts.  Source code for the standard CRM and Queue Connectors will be publicly released; the source for the Thermostat Simulator will not be released.  
  
## Component Data Flow Diagram  
 A data flow between the Azure IoT Hub and Connected Field Services components is detailed in this downloadable [diagram](http://download.microsoft.com/download/3/A/7/3A744B76-3E04-49F5-A30B-938400CEB73E/AzureIoTCfsDataFlowDiagram.jpg). It details each information flow, its flow direction and relative order for a standard installation of [!INCLUDE[pn_connected_field_service_msdyn365](../../includes/pn-connected-field-service-msdyn365.md)].  
  
### See also  
 [Extend Connected Field Service solutions](extend-connected-field-service-solutions.md)     
 [Connected Field Service Developer Guide](connected-field-service-developer-guide.md)
