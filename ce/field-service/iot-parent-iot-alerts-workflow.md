---
title: IoT - Parent IoT Alerts workflow
description: "Links potential redundant IoT alerts to an existing parent alert."
ms.date: 06/24/2025
ms.topic: concept-article
ms.author: vhorvath
author: vhorvathms
search.audienceType: 
  - developer
ms.custom: 
  - dyn365-developer
  - dyn365-fieldservice
---

# IoT - Parent IoT Alerts workflow

The **IoT - Parent IoT Alerts** workflow links potential redundant alerts to an existing parent alert.  

> [!NOTE]
> The Web API types and operations mentioned in this article are available in your environment and you can use the service document of your environment or Insomnia to explore these types and operations. More information: [Web API Service Documents](/power-apps/developer/data-platform/webapi/web-api-service-documents) and [Use Insomnia with Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/insomnia).
  
Calls the `Microsoft.Dynamics.CRM.msdyn_ParentIoTAlerts` API and passes 60 for the `TimespanSeconds` parameter. The primary entity for this workflow is `msdyn_iotalert`.
  
This workflow helps manage duplicate or redundant alerts to Dynamics 365, which can happen when a device malfunctions. By filtering these alerts, you can prevent unnecessary repeated actions, such as multiple reset commands or duplicate work orders. Redundant actions can negatively affect the performance of your Dynamics 365 instance. Filtering alerts before they reach Dynamics 365 is also recommended to avoid redundant processing.
  
This workflow is enabled by default. Users can edit or deactivate it.  

## Parameters

 Parameters allow for data to be passed to the workflow.  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|TimespanSeconds|Edm.Int32|false||Determines the time window to consider when parenting (or suppressing) an alert, from 60 to 180 seconds.|


[!INCLUDE[footer-include](../includes/footer-banner.md)]
