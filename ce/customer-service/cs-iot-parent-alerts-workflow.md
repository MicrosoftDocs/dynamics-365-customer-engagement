---
title: "IoT - Parent IoT Alerts workflow | MicrosoftDocs"
description: "Learn how to link potential redundant IoT alerts to an existing parent alert in Dynamics 365 Customer Service."
ms.date: 02/22/2023
ms.topic: article
author: lalexms
ms.author: laalexan
---

# The IoT - Parent IoT Alerts workflow

The **IoT - Parent IoT Alerts** workflow links potential redundant alerts to an existing parent alert.  

> [!NOTE]
> The Web API types and operations mentioned in this article/table are available in your environment and you can use the service document of your environment or Postman to explore these types and operations. More information: [Web API Service Documents](/power-apps/developer/data-platform/webapi/web-api-service-documents) and [Use Postman with Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/use-postman-web-api).
  
Calls the `Microsoft.Dynamics.CRM.msdyn_ParentIoTAlerts` API and passes 60 for the `TimespanSeconds` parameter. The primary entity for this workflow is `msdyn_iotalert`. 
  
 This workflow is an example that ships with the thermostat sample solution. It demonstrates how to handle duplicate/redundant alerts to [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)], which typically occurs when a device malfunctions. This approach is a recommended best practice because unfiltered alerts can result in duplicated remedial processing. For example, it could result in redundant reset commands sent or multiple repair orders generated. These alerts can also negatively affect the performance of your [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)] instance. (The thermostat sample is coded to filter duplicate alerts to avoid passing them to [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)], which is also a recommended practice.)  
  
 This workflow is enabled by default, but you can deactivate or edit it. For example, you can modify the time span.  
  
<a name="bkmk_Parameters"></a>   

## Parameters  

Data passes to the workflow using parameter(s).  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|TimespanSeconds|Edm.Int32|false||Determines the time window to consider when parenting (or suppressing) an alert, from 60 to 180 seconds.|
| | | | | |


[!INCLUDE[footer-include](../includes/footer-banner.md)]
