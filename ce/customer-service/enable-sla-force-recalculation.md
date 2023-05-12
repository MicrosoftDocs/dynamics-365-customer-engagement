---
title: "Enable custom recalculation of SLA KPIs in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to perform custom recalculation of SLA KPIs in Dynamics 365 Customer Service."
ms.date: 03/17/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Enable custom recalculation of SLA KPIs

## Introduction

Time calculation in service-level agreements (SLAs) is dependent on SLA key performance indicators (KPIs) and input parameters. More information: [Time calculation of SLA KPIs](enable-sla-custom-time-calculation.md)

Changes in the associated customer service schedule and holiday schedule don't affect the existing SLA KPIs unless one of the following events occurs:  

- The SLA KPI is paused and resumed.
- The SLA on an entity instance is updated.
- The SLA item is updated.
- The SLA KPI instance is reapplied after terminal state in recalculation.  

## Enable the custom recalculation on a target entity

You can trigger the recalculation of active SLA KPI instances that have a status of either **In Progress** or **Nearing Noncompliance** and create new SLA KPIs by explicitly calling the custom action `msdyn_ManageSLAInstances` independent of the events mentioned previously.

> [!NOTE]
> This doesn't affect the SLA KPI instances that have a status of **Paused**, **Cancelled**, **Succeeded**, or **Non-compliant**.

To enable custom recalculation and create new SLA KPIs, you must set the integer value of the **Recalculate** parameter to **1** through custom plug-in code. By default, the integer value of the **Recalculate** parameter is **0**. You can set the integer value by creating custom plug-in code on the SLA's target entity and implementing the custom logic based on which the custom action will be initiated. More information: [Write a plug-in](/powerapps/developer/data-platform/write-plug-in)

For example, if you want to recalculate the SLA KPIs that have a status of **In progress** or **Nearing Noncompliance**, on updating the **Case Type** field on the Case entity, you'll need to create a custom plug-in and register it on the Case update for the **Case Type** field. On updating the **Case Type** field, you'll need to call the custom action in your custom plug-in code. The previous SLA KPI instances will be canceled, and new instances will be created.

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
[Apply SLAs](apply-slas.md#apply-slas)
[Enable records for SLA](enable-entities-service-level-agreements.md)
[FAQ about custom time calculation of SLA KPIs](faqs-custom-time-sla-kpis.md#) 
