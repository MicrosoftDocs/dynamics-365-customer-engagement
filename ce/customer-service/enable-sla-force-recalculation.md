---
title: "Enable custom recalculation of SLA KPIs in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to perform custom recalculation of SLAs KPIs in Dynamics 365 Customer Service."
ms.date: 03/03/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Enable custom recalculation of SLA KPIs

## Introduction

This topic describes how you can customize the recalculation of active service-level agreements (SLAs) key performance indicators (KPIs) instances which are in either **In Progress** or **Nearing Non compliance** statuses, and create new SLA KPIs by explicitly calling the custom action **msdyn_ManageSLAInstances**. This doesn't affect the SLA KPI instances which are in either **Paused**, **Cancelled**, **Succeeded** or **Non-compliant** statuses.

To enable custom calculation and create new SLA KPIs, you must set the the integer value of the **Recalculate** parameter to 1 through a custom plug-in code. By default, the integer value of the **Recalculate** parameter is 0.

## Enable the custom recalculation on a target entity

You can enable the recalculation of SLAs by creating a custom plugin code on the SLA target entity and specifying the scenarios where this custom action must be implemented. More information: [Write a plug-in](/powerapps/developer/data-platform/write-plug-in).

For example, if you want to update **Case** type on **Case** entity, the previous SLA KPI instances which are in either, **In progress** or **Nearing Non compliance** will be cancelled and new instances will be created. You can then register a plug-in on the Case entity update with the logic to implement the custom action.

Following is an example of the plug-in code:

``` OrganizationRequest customEvaluation = new OrganizationRequest("msdyn_ManageSLAInstances");
customEvaluation["SLAId"] = "<sla id>";
customEvaluation["RegardingId"] = <case id>;
customEvaluation["EntityLogicalName"] = "incident";//logical name of case entity
customEvaluation["Recalculate"] = 1;

OrganizationResponse customEvaluationResponse = service.Execute(customEvaluation);

```
### See also

[Define service-level agreements](define-service-level-agreements.md)  
[How SLAs are applied](define-service-level-agreements.md#how-is-the-sla-applied)  
[Enable records for SLA](enable-entities-service-level-agreements.md)  
