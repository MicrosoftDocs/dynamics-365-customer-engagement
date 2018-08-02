---
title: "IoT - Parent IoT Alerts workflow (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Links potential redundant IoT alerts to an existing parent alert." 
ms.custom:
  - dyn365-developer
  - dyn365-fieldservice
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
ms.assetid: 66ed4cef-33f3-4a15-b865-f8b9e8934b68
caps.latest.revision: 7
author: JimDaly
ms.author: jdaly
manager: jdaly
---
# IoT - Parent IoT Alerts workflow

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The **IoT - Parent IoT Alerts** workflow links potential redundant alerts to an existing parent alert.  
  
 Calls the <xref href="Microsoft.Dynamics.CRM.msdyn_ParentIoTAlerts?text=msdyn_ParentIoTAlerts Action" /> and passes 60 for the `TimespanSeconds` parameter. The primary entity for this workflow is [msdyn_iotalert Entity Reference](../../developer/entities/msdyn_iotalert.md).  
  
 This workflow is an example that ships with the thermostat sample solution. It demonstrates how to handle duplicate/redundant alerts to [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)], which typically occurs when a device malfunctions.  This is a recommended best practices approach, because unfiltered alerts can result in unwanted duplicated remedial processing, for example, multiple, redundant reset commands being sent or field service repair orders being generated. These can also negatively affect the performance of your [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] instance. (The thermostat sample is coded to filter duplicate alerts so that they are not passed to [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)], which is also a recommended practice.)  
  
 This workflow is enabled by default, but can be deactivated or edited by users; for example, the time span can be modified.  
  
<a name="bkmk_Parameters"></a>   
## Parameters  
 Parameter(s) allow for data to be passed to the workflow.  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|TimespanSeconds|Edm.Int32|false||Determines the time window to consider when parenting (or suppressing) an alert, from 60 to 180 seconds.|
| | | | | |
