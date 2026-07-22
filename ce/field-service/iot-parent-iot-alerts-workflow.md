---
title: IoT - Parent IoT Alerts workflow
description: IoT - Parent IoT Alerts workflow links redundant IoT alerts to an existing parent alert in Dynamics 365. Learn how to filter duplicate or redundant alerts.
ms.date: 07/15/2026
ms.topic: concept-article
ms.author: vhorvath
ms.reviewer: v-wesmith
author: vhorvathms
search.audienceType: 
  - developer
ms.custom: 
  - dyn365-developer
  - dyn365-fieldservice
---

# IoT - Parent IoT Alerts workflow

The **IoT - Parent IoT Alerts** workflow links potentially redundant alerts to an existing parent alert.  

> [!NOTE]
> The Web API types and operations mentioned in this article are available in your environment. You can use the service document of your environment or Insomnia to explore these types and operations. Learn more in [Web API Service Documents](/power-apps/developer/data-platform/webapi/web-api-service-documents) and [Use Insomnia with Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/insomnia).
  
The workflow calls the `Microsoft.Dynamics.CRM.msdyn_ParentIoTAlerts` API and passes 60 for the `TimespanSeconds` parameter. The primary entity for this workflow is `msdyn_iotalert`.
  
This workflow helps manage duplicate or redundant alerts to Dynamics 365, which can happen when a device malfunctions. By filtering these alerts, you can prevent unnecessary repeated actions, such as multiple reset commands or duplicate work orders. Redundant actions can negatively affect the performance of your Dynamics 365 instance. To avoid redundant processing, filter alerts before they reach Dynamics 365.
  
This workflow is enabled by default. Users can edit or deactivate it.  

## Parameters

 Parameters allow you to pass data to the workflow.  
  
|Name|Type|Nullable|Unicode|Description|  
|----------|----------|--------------|-------------|-----------------|  
|TimespanSeconds|Edm.Int32|false||Determines the time window to consider when parenting (or suppressing) an alert, from 60 to 180 seconds.|


[!INCLUDE[footer-include](../includes/footer-banner.md)]
