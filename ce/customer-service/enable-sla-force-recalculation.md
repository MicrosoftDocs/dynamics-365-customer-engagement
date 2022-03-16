---
title: "Enable custom recalculation of SLA KPIs in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to perform custom recalculation of SLAs KPIs in Dynamics 365 Customer Service."
ms.date: 03/16/2022
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

Time calculation in service-level agreements (SLAs) is dependent on SLA key performance indicators (KPIs) and input parameters. More information: [Enable custom time calculation of SLA KPIs](enable-sla-custom-time-calculation.md#introduction).

Changes in the associated customer service and the holiday schedules don't affect the existing SLA KPIs unless one of the following events occur:  

- SLA KPI is paused and resumed.
- SLA on an entity instance is updated.
- SLA item is updated.
- SLA KPI instance is reapplied after terminal state in case of recalculation.  

## Enable the custom recalculation on a target entity

You can trigger the recalculation of active SLAs KPIs instances which are in either **In Progress** or **Nearing Noncompliance** statuses and create new SLA KPIs by explicitly calling the custom action `msdyn_ManageSLAInstances` independent of the events mentioned above.

> [!NOTE]
> This doesn't affect the SLA KPI instances which are in **Paused**, **Cancelled**, **Succeeded**, or **Non-compliant** statuses.

To enable custom recalculation and create new SLA KPIs, you must set the the integer value of the **Recalculate** parameter to **1** through a custom plug-in code. By default, the integer value of the **Recalculate** parameter is **0**. You can set the integer value by creating a custom plug-in code on the SLA’s target entity and implementing the custom logic based on which the custom action will be initiated. More information: [Write a plug-in](/powerapps/developer/data-platform/write-plug-in).

For example, if you want to recalculate the SLA KPIs which are in **In progress** or **Nearing Noncompliance** statuses, on updating the **Case Type** field on the Case entity, you will need to create a custom plug-in and register it on the Case update for the **Case Type** field. On updating the **Case Type** field, you will need to call the custom action in your custom plug-in code. The previous SLA KPI instances will get cancelled and new instances will be created.

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
[FAQs about custom time calculation of SLA KPIs](faqs-custom-time-sla-kpis.md#faqs-about-custom-time-calculation-of-sla-kpis) 
