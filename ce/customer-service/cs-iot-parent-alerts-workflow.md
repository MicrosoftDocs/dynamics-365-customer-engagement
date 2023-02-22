---
title: "IoT - Parent IoT Alerts workflow | MicrosoftDocs"
description: "Learn how to link potential redundant IoT alerts to an existing parent alert in Dynamics 365 Customer Service."
ms.date: 02/21/2023
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---

# The IoT - Parent IoT Alerts workflow

The **IoT - Parent IoT Alerts** workflow links potential redundant alerts to an existing parent alert.  

> [!NOTE]
> The Web API types and operations mentioned in this article/table are available in your environment and you can use the service document of your environment or Postman to explore these types and operations. More information: [Web API Service Documents](/power-apps/developer/data-platform/webapi/web-api-service-documents) and [Use Postman with Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/use-postman-web-api).
  
Calls the `Microsoft.Dynamics.CRM.msdyn_ParentIoTAlerts` API and passes 60 for the `TimespanSeconds` parameter. The primary entity for this workflow is `msdyn_iotalert`. 
  
 This workflow is an example that ships with the thermostat sample solution. It demonstrates how to handle duplicate/redundant alerts to [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)], which typically occurs when a device malfunctions. This approach is a recommended best practice because unfiltered alerts can result in unwanted duplicated remedial processing;for example, multiple, redundant reset commands being sent or repair orders being generated. These alerts can also negatively affect the performance of your [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)] instance. (The thermostat sample is coded to filter duplicate alerts so that they're not passed to [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)], which is also a recommended practice.)  
  
 This workflow is enabled by default, but can be deactivated or edited by users; for example, the time span can be modified.  
  
<a name="bkmk_Parameters"></a>   
## Parameters  
 Parameter(s) allow for data to be passed to the workflow.  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|TimespanSeconds|Edm.Int32|false||Determines the time window to consider when parenting (or suppressing) an alert, from 60 to 180 seconds.|
| | | | | |


[!INCLUDE[footer-include](../includes/footer-banner.md)]
