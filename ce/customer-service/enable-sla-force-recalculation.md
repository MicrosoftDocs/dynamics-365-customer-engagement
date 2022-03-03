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

To enable custom calculation, a new parameter called *Recalculate** has been added to the custom action. This is an optional parameter. By default, the integer value is 0, but if you want to create new SLA KPIs, then you must set the the integer value to 1.

## Enable the custom recalculation on a target entity

You can enable the recalculation of SLAs by writing the custom plugin code on the SLA target entity and deciding the scenarios in which to call this custom action.

For example, if you want to update Case type on Case entity, the previous SLA KPI instances, such as, In progress or Nearing Non compliance will be cancelled and new instances get created. You can then register a plug-in on the Case entity update with the logic to call the custom action.

 Following is an example of the code snippet to call the Custom Action from plug-in:

``` OrganizationRequest customEvaluation = new OrganizationRequest("msdyn_ManageSLAInstances");
customEvaluation["SLAId"] = "<sla id>";
customEvaluation["RegardingId"] = <case id>;
customEvaluation["EntityLogicalName"] = "incident";//logical name of case entity
customEvaluation["Recalculate"] = 1;

OrganizationResponse customEvaluationResponse = service.Execute(customEvaluation);

```
### Scenarios

The scenarios in which it can be used are:
- If user has configured the same condition on SLA item applicable when and calling force recalculate custom action also on the same condition. The way it should now work is: KPI instance will cancel and trigger twice once for OOB and once for force evaluation but SLA calculations will work fine.
- If "Recalculate SLAs for SLA-enabled entities" setting is enabled which is a different setting. The way it should now work is: This setting will still work as expected for Non compliant and succeeded instances as it used to work.
- If warning action is configured for SLA item. The way it should now work is: For instance recreated using force evaluation action will trigger.

### See also

[Define service-level agreements](define-service-level-agreements.md)  
[How SLAs are applied](define-service-level-agreements.md#how-is-the-sla-applied)  
[Enable records for SLA](enable-entities-service-level-agreements.md)  
