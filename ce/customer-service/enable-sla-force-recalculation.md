---
title: "Enable force recalculation of SLAs in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn how to force recalculation of SLAs KPIs in Dynamics 365 Customer Service."
ms.date: 02/28/2022
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

# Enable force recalculation

## Introduction

This feature provides the flexibility to force cancel the active **In Progress** or **Nearing Non compliance** SLA KPI instances and create new SLA KPI instances by explicitly calling the custom action **msdyn_ManageSLAInstances**.

To allow the force cancelling of instances and recreating new ones, we have added a new parameter **Recalculate** to the custom action. This is an optional parameter. By default, we use the integer value 0, but if you want to force create the instances, then you must set the the integer value as 1. This doesn't affect the KPI instances which are in **Paused**, **Cancelled**, **Succeeded** or **Non-compliant** statuses.

## Enable force recalculation of SLAs

To enable the force recalculation:
1. Go to Advanced Settings -> Settings -> Customization -> Customize the system -> Processes -> New Process.
1. On the **Create Process** dialog, enter the following:
    1. Enter a process name, for example, ManageSLAInstances
    1. Select **Action** from the **Category** dropdown list.
    1. Select **None (global)** from the Entity dropdown list.
    1. Select **OK**.
    :::image type="content" source="media/sla-create-process.png" alt-text="Create a sla process":::
1. On the Process: ManageSLAInstances dialog, Hide Process Arguments section, enter the following:
   1. Enter Recalculate as Name.
   1. Select **Integer** from the **Type** dropdown list.
   1. Select the **Input** radio button for **Direction**.
  :::image type="content" source="media/sla-process-argument.png" alt-text="Create a sla process argument":::

## Implement the recalculation on a target entity

You can enable the recalculation of SLAs by writing the custom plugin code on the SLA target entity and deciding the scenarios in which to call this custom action.

For example, if you want to update Case type on Case entity, the previous SLA KPI instances, such as, In progress or NNC will be cancelled and new instances get created. You can then  register a plug-in on the Case entity update with the logic to call the custom action.

 Following is an example of the code snippet to call the Custom Action from plugin:

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
